Imports System.Management
Namespace James
    Public Class CPU

        Private Shared cpuInfo As ManagementObjectCollection
        Private Shared cacheInfo As ManagementObjectCollection
        Private Shared Sub IniciarCPU()
            If cpuInfo Is Nothing Then
                Dim query As New SelectQuery("Win32_processor")
                Dim search As New ManagementObjectSearcher(query)
                cpuInfo = search.Get()
            End If
        End Sub
        Private Shared Sub IniciarCache()
            If cacheInfo Is Nothing Then
                Dim query As New SelectQuery("Win32_CacheMemory")
                Dim search As New ManagementObjectSearcher(query)
                cacheInfo = search.Get()
            End If
        End Sub

        '-----------------------------------------------------------------------------

        Public Shared ReadOnly Property Nome As String
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return info("Name")
            End Get
        End Property
        Public Shared ReadOnly Property Fabricante As String
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return info("Manufacturer")
            End Get
        End Property
        Public Shared ReadOnly Property Familia As String
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return info("Family")
            End Get
        End Property
        Public Shared ReadOnly Property ClockAtual As UInt32
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return Convert.ToUInt32(info("CurrentClockSpeed"))
            End Get
        End Property
        Public Shared ReadOnly Property ClockMax As UInt32
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return Convert.ToUInt32(info("MaxClockSpeed"))
            End Get
        End Property
        Public Shared ReadOnly Property Nucleos As UInt32
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return Convert.ToUInt32(info("NumberOfCores"))
            End Get
        End Property
        Public Shared ReadOnly Property Threads As UInt32
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return Convert.ToUInt32(info("ThreadCount"))
            End Get
        End Property
        Public Shared ReadOnly Property Status As String
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return info("Status")
            End Get
        End Property
        Public Shared ReadOnly Property NucleosHab As UInt32
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return Convert.ToUInt32(info("NumberOfEnabledCore"))
            End Get
        End Property
        Public Shared ReadOnly Property ProcLogicos As String
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return Convert.ToUInt32(info("NumberOfLogicalProcessors"))
            End Get
        End Property
        Public Shared ReadOnly Property L1Tamanho As UInt32
            Get
                IniciarCache()
                Dim info As ManagementObject = cacheInfo(0)
                Return Convert.ToUInt32(info("MaxCacheSize"))
            End Get
        End Property
        Public Shared ReadOnly Property L1Velocidade As UInt32
            Get
                IniciarCache()
                Dim info As ManagementObject = cacheInfo(0)
                Return Convert.ToUInt32(info("CacheSpeed"))
            End Get
        End Property
        Public Shared ReadOnly Property L2Tamanho As UInt32
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return Convert.ToUInt32(info("L2CacheSize"))
            End Get
        End Property
        Public Shared ReadOnly Property L2Velocidade As UInt32
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return Convert.ToUInt32(info("L2CacheSpeed"))
            End Get
        End Property
        Public Shared ReadOnly Property L3Tamanho As UInt32
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return Convert.ToUInt32(info("L3CacheSize"))
            End Get
        End Property
        Public Shared ReadOnly Property L3Velocidade As UInt32
            Get
                IniciarCPU()
                Dim info As ManagementObject = cpuInfo(0)
                Return Convert.ToUInt32(info("L3CacheSpeed"))
            End Get
        End Property
        Public Shared ReadOnly Property CacheStatus As String
            Get
                IniciarCache()
                Dim info As ManagementObject = cacheInfo(0)
                Return info("Status")
            End Get
        End Property

    End Class
End Namespace
