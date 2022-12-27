Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Windows_Product_Key_Finder
	Friend Class Windows
		'
		Private buildNumber_Renamed As String = ""
		'private string buildType = null;
		'
		Private caption_Renamed As String = ""
		'
		Private countryCode_Renamed As String = ""

		Private cSDVersion_Renamed As String = ""

		Private description_Renamed As String = ""

		Private encryptionLevel_Renamed As String = ""

		Private freePhysicalMemory_Renamed As String = ""
		'private string freeSpaceInPagingFiles = null;

		Private installDate_Renamed As String = ""

		Private lastBootUpTime_Renamed As String = ""

		Private numberOfLicensedUsers_Renamed As String = ""

		Private organization_Renamed As String = ""
		'private string productType = null;

		Private registeredUser_Renamed As String = ""

		Private serialNumber_Renamed As String = ""

		Private servicePackMajorVersion_Renamed As String = ""

		Private servicePackMinorVersion_Renamed As String = ""

		Private totalVirtualMemorySize_Renamed As String = ""

		Private totalVisibleMemorySize_Renamed As String = ""

		Private version_Renamed As String = ""
		'private string sizeStoredInPagingFiles = null;



		Public Property BuildNumber() As String
			Get
				Return buildNumber_Renamed
			End Get
			Set(ByVal value As String)
				buildNumber_Renamed = value
			End Set
		End Property

		'public string BuildType
		'{
		'    get { return buildType; }
		'    set { buildType = value; }
		'}

		Public Property Caption() As String
			Get
				Return caption_Renamed
			End Get
			Set(ByVal value As String)
				caption_Renamed = value
			End Set
		End Property

		Public Property CountryCode() As String
			Get
				Return countryCode_Renamed
			End Get
			Set(ByVal value As String)
				countryCode_Renamed = value
			End Set
		End Property

		Public Property CSDVersion() As String
			Get
				Return cSDVersion_Renamed
			End Get
			Set(ByVal value As String)
				cSDVersion_Renamed = value
			End Set
		End Property

		Public Property Description() As String
			Get
				Return description_Renamed
			End Get
			Set(ByVal value As String)
				description_Renamed = value
			End Set
		End Property

		Public Property EncryptionLevel() As String
			Get
				Return encryptionLevel_Renamed
			End Get
			Set(ByVal value As String)
				encryptionLevel_Renamed = value
			End Set
		End Property

		Public Property FreePhysicalMemory() As String
			Get
				Return freePhysicalMemory_Renamed
			End Get
			Set(ByVal value As String)
				freePhysicalMemory_Renamed = value
			End Set
		End Property

		'public string FreeSpaceInPagingFiles
		'{
		'    get { return freeSpaceInPagingFiles; }
		'    set { freeSpaceInPagingFiles = value; }
		'}

		Public Property InstallDate() As String
			Get
				Return installDate_Renamed
			End Get
			Set(ByVal value As String)
				installDate_Renamed = value
			End Set
		End Property

		Public Property LastBootUpTime() As String
			Get
				Return lastBootUpTime_Renamed
			End Get
			Set(ByVal value As String)
				lastBootUpTime_Renamed = value
			End Set
		End Property

		Public Property NumberOfLicensedUsers() As String
			Get
				Return numberOfLicensedUsers_Renamed
			End Get
			Set(ByVal value As String)
				numberOfLicensedUsers_Renamed = value
			End Set
		End Property

		Public Property Organization() As String
			Get
				Return organization_Renamed
			End Get
			Set(ByVal value As String)
				organization_Renamed = value
			End Set
		End Property

		'public string ProductType
		'{
		'    get { return productType; }
		'    set { productType = value; }
		'}

		Public Property RegisteredUser() As String
			Get
				Return registeredUser_Renamed
			End Get
			Set(ByVal value As String)
				registeredUser_Renamed = value
			End Set
		End Property

		Public Property SerialNumber() As String
			Get
				Return serialNumber_Renamed
			End Get
			Set(ByVal value As String)
				serialNumber_Renamed = value
			End Set
		End Property

		Public Property ServicePackMajorVersion() As String
			Get
				Return servicePackMajorVersion_Renamed
			End Get
			Set(ByVal value As String)
				servicePackMajorVersion_Renamed = value
			End Set
		End Property

		Public Property ServicePackMinorVersion() As String
			Get
				Return servicePackMinorVersion_Renamed
			End Get
			Set(ByVal value As String)
				servicePackMinorVersion_Renamed = value
			End Set
		End Property

		Public Property TotalVirtualMemorySize() As String
			Get
				Return totalVirtualMemorySize_Renamed
			End Get
			Set(ByVal value As String)
				totalVirtualMemorySize_Renamed = value
			End Set
		End Property

		Public Property TotalVisibleMemorySize() As String
			Get
				Return totalVisibleMemorySize_Renamed
			End Get
			Set(ByVal value As String)
				totalVisibleMemorySize_Renamed = value
			End Set
		End Property

		Public Property Version() As String
			Get
				Return version_Renamed
			End Get
			Set(ByVal value As String)
				version_Renamed = value
			End Set
		End Property

		'public string SizeStoredInPagingFiles
		'{
		'    get { return sizeStoredInPagingFiles; }
		'    set { sizeStoredInPagingFiles = value; }
		'}

	End Class
End Namespace