Imports System
Imports System.Management
Namespace James
    Public Class Home

        Private Shared monitorInfo As ManagementObjectCollection
        Private Shared mouseInfo As ManagementObjectCollection
        Private Shared pcInfo As ManagementObjectCollection
        Private Shared bateriaInfo As ManagementObjectCollection
        Private Shared BIOSInfo As ManagementObjectCollection
        Private Shared redeInfo As ManagementObjectCollection
        Private Shared audioInfo As ManagementObjectCollection
        Private Shared Sub IniciarPC()
            If monitorInfo Is Nothing Then
                Dim query As New SelectQuery("Win32_ComputerSystem")
                Dim search As New ManagementObjectSearcher(query)
                pcInfo = search.Get()
            End If
        End Sub
        Private Shared Sub IniciarMonitor()
            If monitorInfo Is Nothing Then
                Dim query As New SelectQuery("Win32_DesktopMonitor")
                Dim search As New ManagementObjectSearcher(query)
                monitorInfo = search.Get()
            End If
        End Sub
        Private Shared Sub IniciarMouse()
            If mouseInfo Is Nothing Then
                Dim query As New SelectQuery("Win32_PointingDevice")
                Dim search As New ManagementObjectSearcher(query)
                mouseInfo = search.Get()
            End If
        End Sub
        Private Shared Sub IniciarBateria()
            If bateriaInfo Is Nothing Then
                Dim query As New SelectQuery("Win32_Battery")
                Dim search As New ManagementObjectSearcher(query)
                bateriaInfo = search.Get()
            End If
        End Sub
        Private Shared Sub IniciarBIOS()
            If BIOSInfo Is Nothing Then
                Dim query As New SelectQuery("Win32_BIOS")
                Dim search As New ManagementObjectSearcher(query)
                BIOSInfo = search.Get()
            End If
        End Sub
        Private Shared Sub IniciarRede()
            If redeInfo Is Nothing Then
                Dim query As New SelectQuery("Win32_NetworkAdapter")
                Dim search As New ManagementObjectSearcher(query)
                redeInfo = search.Get()
            End If
        End Sub
        Private Shared Sub IniciarAudio()
            If audioInfo Is Nothing Then
                Dim query As New SelectQuery("Win32_SoundDevice")
                Dim search As New ManagementObjectSearcher(query)
                audioInfo = search.Get()
            End If
        End Sub

        '--------------------------------------------------------------------------------------------------------

        Public Shared ReadOnly Property FabricantePC As String
            Get
                IniciarPC()
                Dim info As ManagementObject = pcInfo(0)
                Return info("Manufacturer")
            End Get
        End Property
        Public Shared ReadOnly Property ModeloPC As String
            Get
                IniciarPC()
                Dim info As ManagementObject = pcInfo(0)
                Return info("Model")
            End Get
        End Property
        Public Shared ReadOnly Property FabricanteMonitor As String
            Get
                IniciarMonitor()
                Dim info As ManagementObject = monitorInfo(0)
                Return info("MonitorManufacturer")
            End Get
        End Property
        Public Shared ReadOnly Property DescricaoMonitor As String
            Get
                IniciarMonitor()
                Dim info As ManagementObject = monitorInfo(0)
                Return info("Description")
            End Get
        End Property
        Public Shared ReadOnly Property StatusMonitor As String
            Get
                IniciarMonitor()
                Dim info As ManagementObject = monitorInfo(0)
                Return info("Status")
            End Get
        End Property
        Public Shared ReadOnly Property FabricanteMouse As String
            Get
                IniciarMouse()
                Dim info As ManagementObject = mouseInfo(0)
                Return info("Manufacturer")
            End Get
        End Property
        Public Shared ReadOnly Property DescricaoMouse As String
            Get
                IniciarMouse()
                Dim info As ManagementObject = mouseInfo(0)
                Return info("Description")
            End Get
        End Property
        Public Shared ReadOnly Property StatusMouse As String
            Get
                IniciarMouse()
                Dim info As ManagementObject = mouseInfo(0)
                Return info("Status")
            End Get
        End Property
        Public Shared ReadOnly Property StatusBateria As String
            Get
                IniciarBateria()
                Dim info As ManagementObject = bateriaInfo(0)
                Return info("Status")
            End Get
        End Property
        Public Shared ReadOnly Property FabricanteBIOS As String
            Get
                IniciarBIOS()
                Dim info As ManagementObject = BIOSInfo(0)
                Return info("Manufacturer")
            End Get
        End Property
        Public Shared ReadOnly Property NomeBIOS As String
            Get
                IniciarBIOS()
                Dim info As ManagementObject = BIOSInfo(0)
                Return info("Name")
            End Get
        End Property
        Public Shared ReadOnly Property VersaoBIOS As String
            Get
                IniciarBIOS()
                Dim info As ManagementObject = BIOSInfo(0)
                Return info("Version")
            End Get
        End Property
        Public Shared ReadOnly Property SerialBIOS As String
            Get
                IniciarBIOS()
                Dim info As ManagementObject = BIOSInfo(0)
                Return info("SerialNumber")
            End Get
        End Property
        Public Shared ReadOnly Property FabricanteRede As String
            Get
                IniciarRede()
                Dim info As ManagementObject = redeInfo(0)
                Return info("Manufacturer")
            End Get
        End Property
        Public Shared ReadOnly Property NomeRede As String
            Get
                IniciarRede()
                Dim info As ManagementObject = redeInfo(0)
                Return info("Name")
            End Get
        End Property
        Public Shared ReadOnly Property StatusRede As String
            Get
                IniciarRede()
                Dim info As ManagementObject = redeInfo(0)
                Return info("Status")
            End Get
        End Property
        Public Shared ReadOnly Property FabricanteAudio As String
            Get
                IniciarAudio()
                Dim info As ManagementObject = audioInfo(0)
                Return info("Manufacturer")
            End Get
        End Property
        Public Shared ReadOnly Property NomeAudio As String
            Get
                IniciarAudio()
                Dim info As ManagementObject = audioInfo(0)
                Return info("ProductName")
            End Get
        End Property
        Public Shared ReadOnly Property StatusAudio As String
            Get
                IniciarAudio()
                Dim info As ManagementObject = audioInfo(0)
                Return info("Status")
            End Get
        End Property

    End Class
End Namespace
