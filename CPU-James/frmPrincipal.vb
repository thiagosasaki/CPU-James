Imports System.Management
Public Class frmHome

    Dim pcCPU As New System.Diagnostics.PerformanceCounter("Processor", "% Processor Time", "_Total")
    Dim tmrCPU As Timer = New Timer()
    Public Sub FrmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CarregarHome()
        CarregarCPU()
        CarregarGPU()
        CarregarMemoria()
        CarregarPlacaMae()
        CarregarDrives()

        tmrInicio.Start()
        tmrDrives.Start()

        tmrCPU.Interval = 1000
        tmrCPU.Enabled = True
        AddHandler tmrCPU.Tick, AddressOf TmrCPU_Tick

        GV.Load = True

        My.Computer.Audio.Play(My.Resources.BG_Song, AudioPlayMode.BackgroundLoop)

    End Sub
    Private Sub CarregarHome()
        GV.Azul = Color.FromArgb(0, 113, 197)
        Panel1.BackColor = GV.Azul
        B1.BackColor = GV.Azul

        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed

        lbPC.Text = "Conexão estabelecida com " & My.Computer.Name & " /  " & SystemInformation.UserName

        tFabricanteMaquina.Text = James.Home.FabricantePC
        tModelo.Text = James.Home.ModeloPC

        'OS
        tSistema.Text = My.Computer.Info.OSFullName
        tPlataforma.Text = My.Computer.Info.OSPlatform
        tVersao.Text = My.Computer.Info.OSVersion
        tLinguagemSO.Text = My.Computer.Info.InstalledUICulture.NativeName

        'BIOS
        tFabricanteBIOS.Text = James.Home.FabricanteBIOS
        tNomeBIOS.Text = James.Home.NomeBIOS
        tVersaoBIOS.Text = James.Home.VersaoBIOS
        tSerialBIOS.Text = James.Home.SerialBIOS

        'Teclado
        tLinguagemTeclado.Text = InputLanguage.CurrentInputLanguage.LayoutName

        'Monitor
        tDescricaoMonitor.Text = James.Home.DescricaoMonitor
        tFabricanteMonitor.Text = James.Home.FabricanteMonitor
        tResolucao.Text = Screen.PrimaryScreen.WorkingArea.Width & "x" & Screen.PrimaryScreen.WorkingArea.Height & " px"

        'Mouse
        tFabricanteMouse.Text = James.Home.FabricanteMouse
        tDescricaoMouse.Text = James.Home.DescricaoMouse

        'Rede
        tFabricanteRede.Text = James.Home.FabricanteRede
        tNomeRede.Text = James.Home.NomeRede

        'Áudio
        tAudioFabricante.Text = James.Home.FabricanteAudio
        tAudioNome.Text = James.Home.NomeAudio
        tAudioStatus.Text = James.Home.StatusAudio

        'Placa-Mãe
        tPlacaStatus.Text = James.PlacaMae.Status

    End Sub
    Private Sub CarregarCPU()
        'Processador
        tProcessadorNome.Text = James.CPU.Nome
        tProcessadorFabricante.Text = James.CPU.Fabricante
        tProcessadorFamilia.Text = James.CPU.Familia
        tProcessadorClockAtual.Text = Math.Round(James.CPU.ClockAtual / 1000, 2, MidpointRounding.AwayFromZero) & "GHz"
        tProcessadorClockMax.Text = Math.Round(James.CPU.ClockMax / 1000, 2, MidpointRounding.AwayFromZero) & "GHz"
        tProcessadorNucleos.Text = James.CPU.Nucleos
        tProcessadorNucleosHab.Text = James.CPU.NucleosHab
        tProcessadorLogicos.Text = James.CPU.ProcLogicos

        'Cache
        tProcessadorThreads.Text = James.CPU.Threads
        tProcessadorL1Tam.Text = James.CPU.L1Tamanho & " KBytes"
        tProcessadorL2Tam.Text = James.CPU.L2Tamanho & " KBytes"
        tProcessadorL3Tam.Text = James.CPU.L3Tamanho & " KBytes"

        If tProcessadorFabricante.Text.ToUpper.Contains("INTEL") Then
            picIntel.Visible = True
            picAMD.Visible = False
            picQualcomm.Visible = False
            picHP.Visible = False
            picOutros.Visible = False
        ElseIf tProcessadorFabricante.Text.ToUpper.Contains("AMD") Then
            picIntel.Visible = False
            picAMD.Visible = True
            picQualcomm.Visible = False
            picHP.Visible = False
            picOutros.Visible = False
        ElseIf tProcessadorFabricante.Text.ToUpper.Contains("QUALCOMM") Then
            picIntel.Visible = False
            picAMD.Visible = False
            picQualcomm.Visible = True
            picHP.Visible = False
            picOutros.Visible = False
        ElseIf tProcessadorFabricante.Text.ToUpper.Contains("HP") Then
            picIntel.Visible = False
            picAMD.Visible = False
            picQualcomm.Visible = False
            picHP.Visible = True
            picOutros.Visible = False
        Else
            picIntel.Visible = False
            picAMD.Visible = False
            picQualcomm.Visible = False
            picHP.Visible = False
            picOutros.Visible = True
        End If
    End Sub
    Private Sub CarregarGPU()
        Dim x As Integer
        Dim query As New SelectQuery("Win32_VideoController")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject

        x = 1
        For Each info In search.Get()
            CType(Me.TabControl1.TabPages("GPU").Controls("tGPUNome" & x), TextBox).Text = info("Name").ToString
            CType(Me.TabControl1.TabPages("GPU").Controls("tGPUTipo" & x), TextBox).Text = info("AdapterDACType").ToString
            CType(Me.TabControl1.TabPages("GPU").Controls("tGPUGPU" & x), TextBox).Text = info("VideoProcessor").ToString
            CType(Me.TabControl1.TabPages("GPU").Controls("tGPUMemoria" & x), TextBox).Text = Math.Round(Convert.ToUInt32(info("AdapterRAM")) / 1073741824, 2, MidpointRounding.AwayFromZero) & " GB"
            CType(Me.TabControl1.TabPages("GPU").Controls("tGPUDriver" & x), TextBox).Text = info("DriverVersion").ToString
            CType(Me.TabControl1.TabPages("GPU").Controls("tGPUDescricao" & x), TextBox).Text = info("Description").ToString
            CType(Me.TabControl1.TabPages("GPU").Controls("tGPUTaxaAtual" & x), TextBox).Text = Convert.ToUInt32(info("CurrentRefreshRate")) & "Hz"
            CType(Me.TabControl1.TabPages("GPU").Controls("tGPUTaxaMax" & x), TextBox).Text = Convert.ToUInt32(info("MaxRefreshRate")) & "Hz"
            CType(Me.TabControl1.TabPages("GPU").Controls("tGPUStatus" & x), TextBox).Text = info("Status")

            x += 1
        Next

        If tGPUNome1.Text.ToUpper.Contains("AMD") Then
            picGPU1AMD.Visible = True
            picGPU1Asus.Visible = False
            picGPU1EVGA.Visible = False
            picGPU1Intel.Visible = False
            picGPU1Nvidia.Visible = False
            picGPU1Outros.Visible = False
        ElseIf tGPUNome1.Text.ToUpper.Contains("ASUS") Then
            picGPU1AMD.Visible = False
            picGPU1Asus.Visible = True
            picGPU1EVGA.Visible = False
            picGPU1Intel.Visible = False
            picGPU1Nvidia.Visible = False
            picGPU1Outros.Visible = False
        ElseIf tGPUNome1.Text.ToUpper.Contains("EVGA") Then
            picGPU1AMD.Visible = False
            picGPU1Asus.Visible = False
            picGPU1EVGA.Visible = True
            picGPU1Intel.Visible = False
            picGPU1Nvidia.Visible = False
            picGPU1Outros.Visible = False
        ElseIf tGPUNome1.Text.ToUpper.Contains("INTEL") Then
            picGPU1AMD.Visible = False
            picGPU1Asus.Visible = False
            picGPU1EVGA.Visible = False
            picGPU1Intel.Visible = True
            picGPU1Nvidia.Visible = False
            picGPU1Outros.Visible = False
        ElseIf tGPUNome1.Text.ToUpper.Contains("NVIDIA") Then
            picGPU1AMD.Visible = False
            picGPU1Asus.Visible = False
            picGPU1EVGA.Visible = False
            picGPU1Intel.Visible = False
            picGPU1Nvidia.Visible = True
            picGPU1Outros.Visible = False
        Else
            picGPU1AMD.Visible = False
            picGPU1Asus.Visible = False
            picGPU1EVGA.Visible = False
            picGPU1Intel.Visible = False
            picGPU1Nvidia.Visible = False
            picGPU1Outros.Visible = True
        End If

        If tGPUNome2.Text.ToUpper.Contains("AMD") Then
            picGPU2AMD.Visible = True
            picGPU2Asus.Visible = False
            picGPU2EVGA.Visible = False
            picGPU2Intel.Visible = False
            picGPU2Nvidia.Visible = False
            picGPU2Outros.Visible = False
        ElseIf tGPUNome2.Text.ToUpper.Contains("ASUS") Then
            picGPU2AMD.Visible = False
            picGPU2Asus.Visible = True
            picGPU2EVGA.Visible = False
            picGPU2Intel.Visible = False
            picGPU2Nvidia.Visible = False
            picGPU2Outros.Visible = False
        ElseIf tGPUNome2.Text.ToUpper.Contains("EVGA") Then
            picGPU2AMD.Visible = False
            picGPU2Asus.Visible = False
            picGPU2EVGA.Visible = True
            picGPU2Intel.Visible = False
            picGPU2Nvidia.Visible = False
            picGPU2Outros.Visible = False
        ElseIf tGPUNome2.Text.ToUpper.Contains("INTEL") Then
            picGPU2AMD.Visible = False
            picGPU2Asus.Visible = False
            picGPU2EVGA.Visible = False
            picGPU2Intel.Visible = True
            picGPU2Nvidia.Visible = False
            picGPU2Outros.Visible = False
        ElseIf tGPUNome2.Text.ToUpper.Contains("NVIDIA") Then
            picGPU2AMD.Visible = False
            picGPU2Asus.Visible = False
            picGPU2EVGA.Visible = False
            picGPU2Intel.Visible = False
            picGPU2Nvidia.Visible = True
            picGPU2Outros.Visible = False
        Else
            picGPU2AMD.Visible = False
            picGPU2Asus.Visible = False
            picGPU2EVGA.Visible = False
            picGPU2Intel.Visible = False
            picGPU2Nvidia.Visible = False
            picGPU2Outros.Visible = True
        End If
    End Sub
    Private Sub CarregarMemoria()
        tMemoriaTotal.Text = Math.Round(My.Computer.Info.TotalPhysicalMemory / 1073741824, 2, MidpointRounding.AwayFromZero) & " GB"

        Dim x As Integer
        Dim Tipo As String
        Dim query As New SelectQuery("Win32_PhysicalMemory")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject

        x = 1
        For Each info In search.Get()
            CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMFabricante" & x), TextBox).Text = info("Manufacturer").ToString
            If info("PartNumber") IsNot Nothing Then
                CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMModelo" & x), TextBox).Text = info("PartNumber").ToString
            End If
            CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMID" & x), TextBox).Text = info("Caption").ToString
            CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTamanho" & x), TextBox).Text = Convert.ToUInt64(info("Capacity")) / 1073741824 & " GB"
            CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMFrequencia" & x), TextBox).Text = Convert.ToUInt32(info("ConfiguredClockSpeed")).ToString & " MHz"
            CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMVoltagem" & x), TextBox).Text = Convert.ToUInt32(info("ConfiguredVoltage")) / 1000 & " V"
            Tipo = Convert.ToUInt16(info("MemoryType")).ToString
            If info("Status") IsNot Nothing Then
                CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMStatus" & x), TextBox).Text = info("Status").ToString
            End If

            'Tipo de Memória
            Select Case Tipo
                Case "0"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "Desconhecido"
                Case "1"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "Outro"
                Case "2"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "DRAM"
                Case "3"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "Synchronous DRAM"
                Case "4"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "Cache DRAM"
                Case "5"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "EDO"
                Case "6"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "EDRAM"
                Case "7"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "VRAM"
                Case "8"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "SRAM"
                Case "9"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "RAM"
                Case "10"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "ROM"
                Case "11"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "Flash"
                Case "12"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "EEPROM"
                Case "13"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "FEPROM"
                Case "14"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "EPROM"
                Case "15"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "CDRAM"
                Case "16"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "3DRAM"
                Case "17"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "SDRAM"
                Case "18"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "SGRAM"
                Case "19"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "RDRAM"
                Case "20"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "DDR"
                Case "21"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "DDR2"
                Case "22"
                    CType(Me.TabControl1.TabPages("Memoria").Controls("tRAMTipo" & x), TextBox).Text = "DDR2 FB-DIMM"
            End Select

            x += 1
        Next

    End Sub
    Private Sub CarregarPlacaMae()
        tPlacaFabricante.Text = James.PlacaMae.Fabricante
        tPlacaModelo.Text = James.PlacaMae.Modelo
        tPlacaVersao.Text = James.PlacaMae.Versao
        tPlacaIDSistema.Text = James.PlacaMae.IDSistema
        tPlacaBarramento1.Text = James.PlacaMae.Barramento1
        tPlacaBarramento2.Text = James.PlacaMae.Barramento2
        tPlacaSerial.Text = James.PlacaMae.Serial
        tPlacaSlots.Text = James.PlacaMae.Slots
    End Sub
    Private Sub CarregarDrives()
        Dim x As Integer
        Dim query As New SelectQuery("Win32_DiskDrive")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject

        x = 1
        'Visible = False
        Do Until x = 7
            'Labels
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbUnidade" & x), Label).Visible = False
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbFabricante" & x), Label).Visible = False
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbTipo" & x), Label).Visible = False
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbModelo" & x), Label).Visible = False
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbID" & x), Label).Visible = False
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbEspacoTotal" & x), Label).Visible = False
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbStatus" & x), Label).Visible = False

            'Textboxes
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeFabricante" & x), TextBox).Visible = False
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeTipo" & x), TextBox).Visible = False
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeModelo" & x), TextBox).Visible = False
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeID" & x), TextBox).Visible = False
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeTotal" & x), TextBox).Visible = False
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeStatus" & x), TextBox).Visible = False

            x += 1
        Loop

        x = 1
        'Visible das unidades disponíveis
        For Each info In search.Get()
            'Labels
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbUnidade" & x), Label).Visible = True
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbFabricante" & x), Label).Visible = True
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbTipo" & x), Label).Visible = True
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbModelo" & x), Label).Visible = True
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbID" & x), Label).Visible = True
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbEspacoTotal" & x), Label).Visible = True
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbStatus" & x), Label).Visible = True

            'Textboxes
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeFabricante" & x), TextBox).Visible = True
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeTipo" & x), TextBox).Visible = True
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeModelo" & x), TextBox).Visible = True
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeID" & x), TextBox).Visible = True
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeTotal" & x), TextBox).Visible = True
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeStatus" & x), TextBox).Visible = True

            x += 1
        Next

        x = 1
        'Display das unidades disponíveis
        For Each info In search.Get()
            CType(Me.TabControl1.TabPages("Unidades").Controls("lbUnidade" & x), Label).Text = info("Description").ToString
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeFabricante" & x), TextBox).Text = info("Model").ToString.Substring(0, info("Model").ToString.IndexOf(" "))
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeTipo" & x), TextBox).Text = info("MediaType").ToString
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeModelo" & x), TextBox).Text = info("Model").ToString
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeID" & x), TextBox).Text = info("DeviceID").ToString
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeTotal" & x), TextBox).Text = Math.Round(Convert.ToUInt64(info("Size")) / 1073741824, 2, MidpointRounding.AwayFromZero) & " GB"
            CType(Me.TabControl1.TabPages("Unidades").Controls("tUnidadeStatus" & x), TextBox).Text = info("Status").ToString

            x += 1
        Next

        GV.Drives = x

    End Sub
    Private Sub DetectarDrives()
        Dim cont As Integer
        Dim query As New SelectQuery("Win32_DiskDrive")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject

        cont = 1
        For Each info In search.Get()
            cont += 1
        Next

        If cont <> GV.Drives Then
            CarregarDrives()
            Me.TabControl1.TabPages("Unidades").Refresh()
        End If
    End Sub
    Private Sub TmrInicio_Tick(sender As Object, e As EventArgs) Handles tmrInicio.Tick
        'Máquina
        tHora.Text = My.Computer.Clock.LocalTime
        If My.Computer.Network.IsAvailable = True Then
            tInternet.Text = "Conectada"
        Else
            tInternet.Text = "Desconectada"
        End If

        'Teclado
        If My.Computer.Keyboard.CapsLock = False Then
            tCapsLock.Text = "Desativado"
        Else
            tCapsLock.Text = "Ativado"
        End If
        If My.Computer.Keyboard.ScrollLock = False Then
            tScrollLock.Text = "Desativado"
        Else
            tScrollLock.Text = "Ativado"
        End If
        If My.Computer.Keyboard.NumLock = False Then
            tNumLock.Text = "Desativado"
        Else
            tNumLock.Text = "Ativado"
        End If

        'Bateria
        tStatusBateria.Text = James.Home.StatusBateria
        If SystemInformation.PowerStatus.PowerLineStatus = 1 Then
            tConectada.Text = "Carregando"
        Else
            tConectada.Text = "Não carregando"
        End If
        tQuantidade.Text = SystemInformation.PowerStatus.BatteryLifePercent * 100 & "%"
        If tConectada.Text = "Não carregando" Then
            tTempo.Text = Math.Round(SystemInformation.PowerStatus.BatteryLifeRemaining / 60, 2, MidpointRounding.AwayFromZero) & " min restantes"
        Else
            tTempo.Text = "N/A"
        End If

        'Monitor e mouse
        tStatusMonitor.Text = James.Home.StatusMonitor
        tStatusMouse.Text = James.Home.StatusMouse

        'Rede
        tStatusRede.Text = James.Home.StatusRede

        'Processador
        tProcessadorStatus.Text = James.CPU.Status

        'Cache
        tProcessadorCacheStatus.Text = James.CPU.CacheStatus
        tProcessadorL1Vel.Text = James.CPU.L1Velocidade & " μs"
        tProcessadorL2Vel.Text = James.CPU.L2Velocidade & " MHz"
        tProcessadorL3Vel.Text = James.CPU.L3Velocidade & " MHz"

        'Monitoramento de Memória
        pbMemoria.Value = ((My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory) * 100
        tMemoriaUtilizada.Text = Math.Round((My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / 1073741824, 3, MidpointRounding.AwayFromZero) & " GB"
        tMemoriaUso.Text = pbMemoria.Value & "%"

    End Sub
    Private Sub TmrCPU_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pbCPU.Value = pcCPU.NextValue
        tCPUUso.Text = pbCPU.Value.ToString & "%"
    End Sub
    Private Sub TmrDrives_Tick(sender As Object, e As EventArgs) Handles tmrDrives.Tick
        DetectarDrives()
    End Sub
    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        GV.Azul = Color.FromArgb(0, 113, 197)
        GV.BG = Color.FromArgb(6, 0, 27)
        B1.BackColor = GV.Azul
        B2.BackColor = GV.BG
        B3.BackColor = GV.BG
        B4.BackColor = GV.BG
        B5.BackColor = GV.BG
        B6.BackColor = GV.BG

        Me.TabControl1.SelectedIndex = 0
    End Sub
    Private Sub btnCPU_Click(sender As Object, e As EventArgs) Handles btnCPU.Click
        GV.Azul = Color.FromArgb(0, 113, 197)
        GV.BG = Color.FromArgb(6, 0, 27)
        B1.BackColor = GV.BG
        B2.BackColor = GV.Azul
        B3.BackColor = GV.BG
        B4.BackColor = GV.BG
        B5.BackColor = GV.BG
        B6.BackColor = GV.BG

        Me.TabControl1.SelectedIndex = 1
    End Sub
    Private Sub BtnGPU_Click(sender As Object, e As EventArgs) Handles btnGPU.Click
        GV.Azul = Color.FromArgb(0, 113, 197)
        GV.BG = Color.FromArgb(6, 0, 27)
        B1.BackColor = GV.BG
        B2.BackColor = GV.BG
        B3.BackColor = GV.Azul
        B4.BackColor = GV.BG
        B5.BackColor = GV.BG
        B6.BackColor = GV.BG

        Me.TabControl1.SelectedIndex = 2
    End Sub
    Private Sub BtnMemoria_Click(sender As Object, e As EventArgs) Handles btnMemoria.Click
        GV.Azul = Color.FromArgb(0, 113, 197)
        GV.BG = Color.FromArgb(6, 0, 27)
        B1.BackColor = GV.BG
        B2.BackColor = GV.BG
        B3.BackColor = GV.BG
        B4.BackColor = GV.Azul
        B5.BackColor = GV.BG
        B6.BackColor = GV.BG

        Me.TabControl1.SelectedIndex = 3
    End Sub
    Private Sub BtnPlaca_Click(sender As Object, e As EventArgs) Handles btnPlaca.Click
        GV.Azul = Color.FromArgb(0, 113, 197)
        GV.BG = Color.FromArgb(6, 0, 27)
        B1.BackColor = GV.BG
        B2.BackColor = GV.BG
        B3.BackColor = GV.BG
        B4.BackColor = GV.BG
        B5.BackColor = GV.Azul
        B6.BackColor = GV.BG

        Me.TabControl1.SelectedIndex = 4
    End Sub
    Private Sub btnUnidades_Click(sender As Object, e As EventArgs) Handles btnUnidades.Click
        GV.Azul = Color.FromArgb(0, 113, 197)
        GV.BG = Color.FromArgb(6, 0, 27)
        B1.BackColor = GV.BG
        B2.BackColor = GV.BG
        B3.BackColor = GV.BG
        B4.BackColor = GV.BG
        B5.BackColor = GV.BG
        B6.BackColor = GV.Azul

        Me.TabControl1.SelectedIndex = 5
    End Sub
    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        frmOpcoes.Show()
    End Sub
    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        If MsgBox("Deseja mesmo encerrar a aplicação?", vbYesNo) = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

End Class
Public Class GV

    Public Shared Azul As Color
    Public Shared BG As Color
    Public Shared Load As Boolean
    Public Shared Drives As Integer

End Class
