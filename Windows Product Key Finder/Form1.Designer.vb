Namespace Windows_Product_Key_Finder
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.find_txt = New System.Windows.Forms.Label()
			Me.windows_verison = New System.Windows.Forms.Label()
			Me.CSD_version = New System.Windows.Forms.Label()
			Me.Install_Date_txt = New System.Windows.Forms.Label()
			Me.windows_Caption_txt = New System.Windows.Forms.Label()
			Me.info1_txt = New System.Windows.Forms.Label()
			Me.Registered_User_txt = New System.Windows.Forms.Label()
			Me.Windows_serial_txt = New System.Windows.Forms.Label()
			Me.Windows_Organization_txt = New System.Windows.Forms.Label()
			Me.Close_txt = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(68, 147)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.ReadOnly = True
			Me.textBox1.Size = New System.Drawing.Size(205, 20)
			Me.textBox1.TabIndex = 0
			' 
			' find_txt
			' 
			Me.find_txt.AutoSize = True
			Me.find_txt.BackColor = System.Drawing.Color.Transparent
			Me.find_txt.Cursor = System.Windows.Forms.Cursors.Hand
			Me.find_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.find_txt.ForeColor = System.Drawing.Color.Black
			Me.find_txt.Location = New System.Drawing.Point(146, 176)
			Me.find_txt.Name = "find_txt"
			Me.find_txt.Size = New System.Drawing.Size(48, 13)
			Me.find_txt.TabIndex = 1
			Me.find_txt.Text = "Find Key"
'			Me.find_txt.Click += New System.EventHandler(Me.find_txt_Click)
			' 
			' windows_verison
			' 
			Me.windows_verison.AutoSize = True
			Me.windows_verison.BackColor = System.Drawing.Color.Transparent
			Me.windows_verison.ForeColor = System.Drawing.Color.White
			Me.windows_verison.Location = New System.Drawing.Point(24, 36)
			Me.windows_verison.Name = "windows_verison"
			Me.windows_verison.Size = New System.Drawing.Size(45, 13)
			Me.windows_verison.TabIndex = 2
			Me.windows_verison.Text = "Version:"
			' 
			' CSD_version
			' 
			Me.CSD_version.AutoSize = True
			Me.CSD_version.BackColor = System.Drawing.Color.Transparent
			Me.CSD_version.ForeColor = System.Drawing.Color.White
			Me.CSD_version.Location = New System.Drawing.Point(24, 49)
			Me.CSD_version.Name = "CSD_version"
			Me.CSD_version.Size = New System.Drawing.Size(70, 13)
			Me.CSD_version.TabIndex = 3
			Me.CSD_version.Text = "CSD Version:"
			' 
			' Install_Date_txt
			' 
			Me.Install_Date_txt.AutoSize = True
			Me.Install_Date_txt.BackColor = System.Drawing.Color.Transparent
			Me.Install_Date_txt.ForeColor = System.Drawing.Color.White
			Me.Install_Date_txt.Location = New System.Drawing.Point(24, 62)
			Me.Install_Date_txt.Name = "Install_Date_txt"
			Me.Install_Date_txt.Size = New System.Drawing.Size(66, 13)
			Me.Install_Date_txt.TabIndex = 4
			Me.Install_Date_txt.Text = "Install Date :"
			' 
			' windows_Caption_txt
			' 
			Me.windows_Caption_txt.AutoSize = True
			Me.windows_Caption_txt.BackColor = System.Drawing.Color.Transparent
			Me.windows_Caption_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.windows_Caption_txt.ForeColor = System.Drawing.Color.White
			Me.windows_Caption_txt.Location = New System.Drawing.Point(24, 23)
			Me.windows_Caption_txt.Name = "windows_Caption_txt"
			Me.windows_Caption_txt.Size = New System.Drawing.Size(58, 13)
			Me.windows_Caption_txt.TabIndex = 5
			Me.windows_Caption_txt.Text = "Windows"
			' 
			' info1_txt
			' 
			Me.info1_txt.AutoSize = True
			Me.info1_txt.BackColor = System.Drawing.Color.Transparent
			Me.info1_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.info1_txt.ForeColor = System.Drawing.Color.White
			Me.info1_txt.Location = New System.Drawing.Point(24, 94)
			Me.info1_txt.Name = "info1_txt"
			Me.info1_txt.Size = New System.Drawing.Size(146, 13)
			Me.info1_txt.TabIndex = 6
			Me.info1_txt.Text = "Windows Is Licensed to:"
			' 
			' Registered_User_txt
			' 
			Me.Registered_User_txt.AutoSize = True
			Me.Registered_User_txt.BackColor = System.Drawing.Color.Transparent
			Me.Registered_User_txt.ForeColor = System.Drawing.Color.White
			Me.Registered_User_txt.Location = New System.Drawing.Point(24, 108)
			Me.Registered_User_txt.Name = "Registered_User_txt"
			Me.Registered_User_txt.Size = New System.Drawing.Size(83, 13)
			Me.Registered_User_txt.TabIndex = 7
			Me.Registered_User_txt.Text = "Registered User"
			' 
			' Windows_serial_txt
			' 
			Me.Windows_serial_txt.AutoSize = True
			Me.Windows_serial_txt.BackColor = System.Drawing.Color.Transparent
			Me.Windows_serial_txt.ForeColor = System.Drawing.Color.White
			Me.Windows_serial_txt.Location = New System.Drawing.Point(24, 75)
			Me.Windows_serial_txt.Name = "Windows_serial_txt"
			Me.Windows_serial_txt.Size = New System.Drawing.Size(78, 13)
			Me.Windows_serial_txt.TabIndex = 8
			Me.Windows_serial_txt.Text = "Windows serial"
			' 
			' Windows_Organization_txt
			' 
			Me.Windows_Organization_txt.AutoSize = True
			Me.Windows_Organization_txt.BackColor = System.Drawing.Color.Transparent
			Me.Windows_Organization_txt.ForeColor = System.Drawing.Color.White
			Me.Windows_Organization_txt.Location = New System.Drawing.Point(24, 121)
			Me.Windows_Organization_txt.Name = "Windows_Organization_txt"
			Me.Windows_Organization_txt.Size = New System.Drawing.Size(69, 13)
			Me.Windows_Organization_txt.TabIndex = 9
			Me.Windows_Organization_txt.Text = "Organization:"
			' 
			' Close_txt
			' 
			Me.Close_txt.AutoSize = True
			Me.Close_txt.BackColor = System.Drawing.Color.Transparent
			Me.Close_txt.Cursor = System.Windows.Forms.Cursors.Hand
			Me.Close_txt.Location = New System.Drawing.Point(307, 0)
			Me.Close_txt.Name = "Close_txt"
			Me.Close_txt.Size = New System.Drawing.Size(12, 13)
			Me.Close_txt.TabIndex = 10
			Me.Close_txt.Text = "x"
'			Me.Close_txt.Click += New System.EventHandler(Me.Close_txt_Click)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.BackColor = System.Drawing.Color.Transparent
			Me.label1.Cursor = System.Windows.Forms.Cursors.Hand
			Me.label1.Location = New System.Drawing.Point(296, 1)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(13, 13)
			Me.label1.TabIndex = 11
			Me.label1.Text = "?"
'			Me.label1.Click += New System.EventHandler(Me.label1_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackgroundImage = My.Resources.bg9
			Me.ClientSize = New System.Drawing.Size(340, 190)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.Close_txt)
			Me.Controls.Add(Me.Windows_Organization_txt)
			Me.Controls.Add(Me.Windows_serial_txt)
			Me.Controls.Add(Me.Registered_User_txt)
			Me.Controls.Add(Me.info1_txt)
			Me.Controls.Add(Me.windows_Caption_txt)
			Me.Controls.Add(Me.Install_Date_txt)
			Me.Controls.Add(Me.CSD_version)
			Me.Controls.Add(Me.windows_verison)
			Me.Controls.Add(Me.find_txt)
			Me.Controls.Add(Me.textBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Windows Product Key Finder"
'			Me.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.Form1_MouseDown)
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents find_txt As System.Windows.Forms.Label
		Private windows_verison As System.Windows.Forms.Label
		Private CSD_version As System.Windows.Forms.Label
		Private Install_Date_txt As System.Windows.Forms.Label
		Private windows_Caption_txt As System.Windows.Forms.Label
		Private info1_txt As System.Windows.Forms.Label
		Private Registered_User_txt As System.Windows.Forms.Label
		Private Windows_serial_txt As System.Windows.Forms.Label
		Private Windows_Organization_txt As System.Windows.Forms.Label
		Private WithEvents Close_txt As System.Windows.Forms.Label
		Private WithEvents label1 As System.Windows.Forms.Label
	End Class
End Namespace

