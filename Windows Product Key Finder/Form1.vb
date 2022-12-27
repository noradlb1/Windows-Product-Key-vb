Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports Microsoft.Win32
Imports System.Collections
Imports System.Management

'for DLL's  (Mouse drag)
Imports System.Runtime.InteropServices


Namespace Windows_Product_Key_Finder
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		'const and dll functions for moving form
		Public Const WM_NCLBUTTONDOWN As Integer = &HA1
		Public Const HT_CAPTION As Integer = &H2

		<DllImportAttribute("user32.dll")> _
		Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
		End Function

		<DllImportAttribute("user32.dll")> _
		Public Shared Function ReleaseCapture() As Boolean
		End Function

		'Got it from http://geekswithblogs.net/willemf/archive/2006/04/23/76125.aspx
		Public Shared Function DecodeProductKey(ByVal digitalProductId() As Byte) As String
			' Offset of first byte of encoded product key in 
			'  'DigitalProductIdxxx" REG_BINARY value. Offset = 34H.
			Const keyStartIndex As Integer = 52
			' Offset of last byte of encoded product key in 
			'  'DigitalProductIdxxx" REG_BINARY value. Offset = 43H.
			Const keyEndIndex As Integer = keyStartIndex + 15
			' Possible alpha-numeric characters in product key.
			Dim digits() As Char = { "B"c, "C"c, "D"c, "F"c, "G"c, "H"c, "J"c, "K"c, "M"c, "P"c, "Q"c, "R"c, "T"c, "V"c, "W"c, "X"c, "Y"c, "2"c, "3"c, "4"c, "6"c, "7"c, "8"c, "9"c}
			' Length of decoded product key
			Const decodeLength As Integer = 29
			' Length of decoded product key in byte-form.
			' Each byte represents 2 chars.
			Const decodeStringLength As Integer = 15
			' Array of containing the decoded product key.
			Dim decodedChars(decodeLength - 1) As Char
			' Extract byte 52 to 67 inclusive.
			Dim hexPid As New ArrayList()
			For i As Integer = keyStartIndex To keyEndIndex
				hexPid.Add(digitalProductId(i))
			Next i
			For i As Integer = decodeLength - 1 To 0 Step -1
				' Every sixth char is a separator.
				If (i + 1) Mod 6 = 0 Then
					decodedChars(i) = "-"c
				Else
					' Do the actual decoding.
					Dim digitMapIndex As Integer = 0
					For j As Integer = decodeStringLength - 1 To 0 Step -1
						Dim byteValue As Integer = (digitMapIndex << 8) Or DirectCast(hexPid(j), Byte)
						hexPid(j) = CByte(byteValue \ 24)
						digitMapIndex = byteValue Mod 24
						decodedChars(i) = digits(digitMapIndex)
					Next j
				End If
			Next i
			Return New String(decodedChars)
		End Function

		'Got ot from http://www.csharphelp.com/board2/read.html?f=1&i=11982&t=11982
		Private Shared Function ToDateTime(ByVal dmtfDate As String) As Date
			'There is a utility called mgmtclassgen that ships with the .NET SDK that
			'will generate managed code for existing WMI classes. It also generates
			' datetime conversion routines like this one.
			'Thanks to Chetan Parmar and dotnet247.com for the help.
			Dim year As Integer = Date.Now.Year
			Dim month As Integer = 1
			Dim day As Integer = 1
			Dim hour As Integer = 0
			Dim minute As Integer = 0
			Dim second As Integer = 0
			Dim millisec As Integer = 0
			Dim dmtf As String = dmtfDate
			Dim tempString As String = System.String.Empty

			If ((System.String.Empty = dmtf) OrElse (dmtf Is Nothing)) Then
				Return Date.MinValue
			End If

			If (dmtf.Length <> 25) Then
				Return Date.MinValue
			End If

			tempString = dmtf.Substring(0, 4)
			If ("****" <> tempString) Then
				year = System.Int32.Parse(tempString)
			End If

			tempString = dmtf.Substring(4, 2)

			If ("**" <> tempString) Then
				month = System.Int32.Parse(tempString)
			End If

			tempString = dmtf.Substring(6, 2)

			If ("**" <> tempString) Then
				day = System.Int32.Parse(tempString)
			End If

			tempString = dmtf.Substring(8, 2)

			If ("**" <> tempString) Then
				hour = System.Int32.Parse(tempString)
			End If

			tempString = dmtf.Substring(10, 2)

			If ("**" <> tempString) Then
				minute = System.Int32.Parse(tempString)
			End If

			tempString = dmtf.Substring(12, 2)

			If ("**" <> tempString) Then
				second = System.Int32.Parse(tempString)
			End If

			tempString = dmtf.Substring(15, 3)

			If ("***" <> tempString) Then
				millisec = System.Int32.Parse(tempString)
			End If

			Dim dateRet As New Date(year, month, day, hour, minute, second, millisec)

			Return dateRet
		End Function

		'Used for holding Windows infomation
		Private WindowsCollection As New ArrayList()
		Private windows_getinfo_done As Boolean = False
		Private myWindowsHtml As New TextBox()

		Private Sub getwindowsinfo()

			WindowsCollection.Clear()
			windows_getinfo_done = False

			Try
'				#Region "Windows Info...."

				Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")

				Dim myWindows As New Windows()
				For Each wmi_Windows As ManagementObject In searcher.Get()
					myWindows.Caption = wmi_Windows("Caption").ToString()
					myWindows.CountryCode = wmi_Windows("CountryCode").ToString()
'					#Region "myWindows.CSDVersion"
					Try
						myWindows.CSDVersion = wmi_Windows("CSDVersion").ToString()
					Catch e1 As NullReferenceException
						myWindows.CSDVersion = "Unknown, or no service pack installed"
					End Try
'					#End Region
					myWindows.Description = wmi_Windows("Description").ToString()
					myWindows.RegisteredUser = wmi_Windows("RegisteredUser").ToString()

					myWindows.InstallDate = wmi_Windows("InstallDate").ToString()
					Dim dc As Date = ToDateTime(myWindows.InstallDate)
					myWindows.InstallDate = dc.AddTicks(-TimeZone.CurrentTimeZone.GetUtcOffset(Date.Now).Ticks).ToLocalTime().ToString()

'					#Region "myWindows.Organization"
					Try
						myWindows.Organization = wmi_Windows("Organization").ToString()
					Catch e2 As NullReferenceException
						myWindows.Organization = ""
					End Try
'					#End Region
					myWindows.SerialNumber = wmi_Windows("SerialNumber").ToString()
					myWindows.Version = wmi_Windows("Version").ToString()
				Next wmi_Windows

'				#Region "Windows_Productkey_txt.Text"
				Try
					'byte[] digitalProductId = null;
					'RegistryKey hklm = Registry.LocalMachine;
					'hklm = hklm.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
					'digitalProductId = hklm.GetValue("DigitalProductId") as byte[];
					'Windows_Productkey_txt.Text = "Product key : " + DecodeProductKey(digitalProductId);
				Catch e3 As NullReferenceException
					'Windows_Productkey_txt.Text = "Unknown";
				End Try
'				#End Region

				WindowsCollection.Add(myWindows)
				windows_getinfo_done = True
'				#End Region
			Catch i4 As Exception
				MessageBox.Show(i4.ToString())
			End Try

		End Sub

		Private Sub find_txt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles find_txt.Click

			Dim digitalProductId() As Byte = Nothing
			Dim hklm As RegistryKey = Registry.LocalMachine
			hklm = hklm.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion")
			digitalProductId = TryCast(hklm.GetValue("DigitalProductId"), Byte())

			textBox1.Text = DecodeProductKey(digitalProductId)
		End Sub

		Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
			If e.Button = MouseButtons.Left Then
				ReleaseCapture()
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			getwindowsinfo()

			If windows_getinfo_done = True Then
				For Each c As Windows In WindowsCollection
					windows_Caption_txt.Text = c.Caption
					windows_verison.Text = "Version : " & c.Version
					CSD_version.Text = "CSD Version : " & c.CSDVersion
					Install_Date_txt.Text = "Install Date : " & c.InstallDate
					Windows_serial_txt.Text = "Serial : " & c.SerialNumber

					Registered_User_txt.Text = "Registered User : " & c.RegisteredUser
					Windows_Organization_txt.Text = "Organization : " & c.Organization
				Next c
			Else
				MessageBox.Show("Sorry.. but the program has encountered" & ControlChars.Lf & " a error and must close." & ControlChars.Lf & ControlChars.Lf & "Remember you must have Administrative Privileges to " & ControlChars.Lf & "run the program properly.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Me.Close()
			End If

		End Sub

		Private Sub Close_txt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Close_txt.Click
			Close()
		End Sub

		Private Sub label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label1.Click
			MessageBox.Show("Windows Product Key Finder" & ControlChars.Lf & "Version 1.0.0.0" & ControlChars.Lf & ControlChars.Lf & "Made by ShoXDK Convert To VB By Monstermc", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub
	End Class
End Namespace