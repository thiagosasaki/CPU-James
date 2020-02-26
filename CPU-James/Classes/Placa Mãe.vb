Imports System.Management
Namespace James
    Public Class PlacaMae
        Private Shared placamaeInfo As ManagementObjectCollection
        Private Shared placamaedvcInfo As ManagementObjectCollection
        Private Shared Sub IniciarPlacaMae()
            If placamaeInfo Is Nothing Then
                Dim query As New SelectQuery("Win32_BaseBoard")
                Dim search As New ManagementObjectSearcher(query)
                placamaeInfo = search.Get()
            End If
        End Sub
        Private Shared Sub IniciarPlacaMaeDvc()
            If placamaedvcInfo Is Nothing Then
                Dim query As New SelectQuery("Win32_MotherboardDevice")
                Dim search As New ManagementObjectSearcher(query)
                placamaedvcInfo = search.Get()
            End If
        End Sub
        Public Shared ReadOnly Property Fabricante As String
            Get
                IniciarPlacaMae()
                Dim info As ManagementObject = placamaeInfo(0)
                Return info("Manufacturer")
            End Get
        End Property
        Public Shared ReadOnly Property Modelo As String
            Get
                IniciarPlacaMae()
                Dim info As ManagementObject = placamaeInfo(0)
                Return info("Product")
            End Get
        End Property
        Public Shared ReadOnly Property Versao As String
            Get
                IniciarPlacaMae()
                Dim info As ManagementObject = placamaeInfo(0)
                Return info("Version")
            End Get
        End Property
        Public Shared ReadOnly Property IDSistema As String
            Get
                IniciarPlacaMaeDvc()
                Dim info As ManagementObject = placamaedvcInfo(0)
                Return info("DeviceID")
            End Get
        End Property
        Public Shared ReadOnly Property Barramento1 As String
            Get
                IniciarPlacaMaeDvc()
                Dim info As ManagementObject = placamaedvcInfo(0)
                Return info("PrimaryBusType")
            End Get
        End Property
        Public Shared ReadOnly Property Barramento2 As String
            Get
                IniciarPlacaMaeDvc()
                Dim info As ManagementObject = placamaedvcInfo(0)
                Return info("SecondaryBusType")
            End Get
        End Property
        Public Shared ReadOnly Property Serial As String
            Get
                IniciarPlacaMae()
                Dim info As ManagementObject = placamaeInfo(0)
                Return info("SerialNumber")
            End Get
        End Property
        Public Shared ReadOnly Property Slots As String
            Get
                IniciarPlacaMae()
                Dim info As ManagementObject = placamaeInfo(0)
                Return info("SlotLayout")
            End Get
        End Property
        Public Shared ReadOnly Property Status As String
            Get
                IniciarPlacaMae()
                Dim info As ManagementObject = placamaeInfo(0)
                Return info("Status")
            End Get
        End Property

    End Class
End Namespace
