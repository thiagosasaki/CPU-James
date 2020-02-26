Imports System.Management
Namespace James
    Public Class Memoria
        Private Shared memoriaInfo As ManagementObjectCollection
        Private Shared Sub IniciarMemoria()
            If memoriaInfo Is Nothing Then
                Dim query As New SelectQuery("Win32_PhysicalMemory")
                Dim search As New ManagementObjectSearcher(query)
                memoriaInfo = search.Get()
            End If
        End Sub

        Public Shared ReadOnly Property Capacidade As String
            Get
                IniciarMemoria()
                Dim info As ManagementObject = memoriaInfo(0)
                Return info("Capacity")
            End Get
        End Property

    End Class
End Namespace
