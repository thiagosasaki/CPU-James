<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.B6 = New System.Windows.Forms.Button()
        Me.btnCPU = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Inicio = New System.Windows.Forms.TabPage()
        Me.grpMouse = New System.Windows.Forms.GroupBox()
        Me.tStatusMouse = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.tDescricaoMouse = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.tFabricanteMouse = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.grpTemperatura = New System.Windows.Forms.GroupBox()
        Me.tAudioStatus = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.tAudioNome = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tAudioFabricante = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.grpRede = New System.Windows.Forms.GroupBox()
        Me.tStatusRede = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.tNomeRede = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.tFabricanteRede = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.grpBIOS = New System.Windows.Forms.GroupBox()
        Me.tSerialBIOS = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tVersaoBIOS = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tNomeBIOS = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tFabricanteBIOS = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.grpBateria = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tTempo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tQuantidade = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tConectada = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tStatusBateria = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.grpSistema = New System.Windows.Forms.GroupBox()
        Me.tInternet = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tHora = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tModelo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tFabricanteMaquina = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.grpMonitor = New System.Windows.Forms.GroupBox()
        Me.tStatusMonitor = New System.Windows.Forms.TextBox()
        Me.Resolução = New System.Windows.Forms.Label()
        Me.tResolucao = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tDescricaoMonitor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tFabricanteMonitor = New System.Windows.Forms.TextBox()
        Me.Fabricante = New System.Windows.Forms.Label()
        Me.grpTeclado = New System.Windows.Forms.GroupBox()
        Me.tLinguagemTeclado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tNumLock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tScrollLock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tCapsLock = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gpSO = New System.Windows.Forms.GroupBox()
        Me.tLinguagemSO = New System.Windows.Forms.TextBox()
        Me.Linguagem = New System.Windows.Forms.Label()
        Me.tVersao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tPlataforma = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tSistema = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CPU = New System.Windows.Forms.TabPage()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.tCPUUso = New System.Windows.Forms.TextBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.pbCPU = New System.Windows.Forms.ProgressBar()
        Me.grpProcessador = New System.Windows.Forms.GroupBox()
        Me.tProcessadorStatus = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.tProcessadorNome = New System.Windows.Forms.TextBox()
        Me.tProcessadorThreads = New System.Windows.Forms.TextBox()
        Me.picHP = New System.Windows.Forms.PictureBox()
        Me.tProcessadorFabricante = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.picQualcomm = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.tProcessadorLogicos = New System.Windows.Forms.TextBox()
        Me.tProcessadorFamilia = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tProcessadorNucleosHab = New System.Windows.Forms.TextBox()
        Me.tProcessadorClockAtual = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.tProcessadorClockMax = New System.Windows.Forms.TextBox()
        Me.Threads = New System.Windows.Forms.Label()
        Me.picIntel = New System.Windows.Forms.PictureBox()
        Me.tProcessadorNucleos = New System.Windows.Forms.TextBox()
        Me.picAMD = New System.Windows.Forms.PictureBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.picOutros = New System.Windows.Forms.PictureBox()
        Me.grpCache = New System.Windows.Forms.GroupBox()
        Me.tProcessadorCacheStatus = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.tProcessadorL3Vel = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.tProcessadorL2Vel = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.tProcessadorL1Vel = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.tProcessadorL3Tam = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.tProcessadorL2Tam = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.tProcessadorL1Tam = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.GPU = New System.Windows.Forms.TabPage()
        Me.tGPUStatus2 = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.tGPUStatus1 = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.tGPUNome2 = New System.Windows.Forms.TextBox()
        Me.tGPUTaxaMax2 = New System.Windows.Forms.TextBox()
        Me.tGPUDriver2 = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.tGPUTaxaAtual2 = New System.Windows.Forms.TextBox()
        Me.tGPUMemoria2 = New System.Windows.Forms.TextBox()
        Me.tGPUTipo2 = New System.Windows.Forms.TextBox()
        Me.tGPUDescricao2 = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.tGPUGPU2 = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.tGPUNome1 = New System.Windows.Forms.TextBox()
        Me.tGPUTaxaMax1 = New System.Windows.Forms.TextBox()
        Me.tGPUDriver1 = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.tGPUTaxaAtual1 = New System.Windows.Forms.TextBox()
        Me.tGPUMemoria1 = New System.Windows.Forms.TextBox()
        Me.tGPUTipo1 = New System.Windows.Forms.TextBox()
        Me.tGPUDescricao1 = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.tGPUGPU1 = New System.Windows.Forms.TextBox()
        Me.picGPU2Nvidia = New System.Windows.Forms.PictureBox()
        Me.picGPU2EVGA = New System.Windows.Forms.PictureBox()
        Me.picGPU2Asus = New System.Windows.Forms.PictureBox()
        Me.picGPU2Intel = New System.Windows.Forms.PictureBox()
        Me.picGPU2AMD = New System.Windows.Forms.PictureBox()
        Me.picGPU2Outros = New System.Windows.Forms.PictureBox()
        Me.picGPU1Nvidia = New System.Windows.Forms.PictureBox()
        Me.picGPU1EVGA = New System.Windows.Forms.PictureBox()
        Me.picGPU1Asus = New System.Windows.Forms.PictureBox()
        Me.picGPU1Intel = New System.Windows.Forms.PictureBox()
        Me.picGPU1AMD = New System.Windows.Forms.PictureBox()
        Me.picGPU1Outros = New System.Windows.Forms.PictureBox()
        Me.Memoria = New System.Windows.Forms.TabPage()
        Me.tRAMVoltagem4 = New System.Windows.Forms.TextBox()
        Me.tRAMFrequencia4 = New System.Windows.Forms.TextBox()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.tRAMStatus4 = New System.Windows.Forms.TextBox()
        Me.lbRAMID4 = New System.Windows.Forms.Label()
        Me.tRAMTipo4 = New System.Windows.Forms.TextBox()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.lbRAMFabricante4 = New System.Windows.Forms.Label()
        Me.tRAMFabricante4 = New System.Windows.Forms.TextBox()
        Me.lbRAMModelo4 = New System.Windows.Forms.Label()
        Me.tRAMModelo4 = New System.Windows.Forms.TextBox()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.tRAMTamanho4 = New System.Windows.Forms.TextBox()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.tRAMID4 = New System.Windows.Forms.TextBox()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.tRAMVoltagem3 = New System.Windows.Forms.TextBox()
        Me.tRAMFrequencia3 = New System.Windows.Forms.TextBox()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.tRAMStatus3 = New System.Windows.Forms.TextBox()
        Me.lbRAMID3 = New System.Windows.Forms.Label()
        Me.tRAMTipo3 = New System.Windows.Forms.TextBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.lbRAMFabricante3 = New System.Windows.Forms.Label()
        Me.tRAMFabricante3 = New System.Windows.Forms.TextBox()
        Me.lbRAMModelo3 = New System.Windows.Forms.Label()
        Me.tRAMModelo3 = New System.Windows.Forms.TextBox()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.tRAMTamanho3 = New System.Windows.Forms.TextBox()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.tRAMID3 = New System.Windows.Forms.TextBox()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.tRAMVoltagem2 = New System.Windows.Forms.TextBox()
        Me.tRAMFrequencia2 = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.tRAMStatus2 = New System.Windows.Forms.TextBox()
        Me.lbRAMID2 = New System.Windows.Forms.Label()
        Me.tRAMTipo2 = New System.Windows.Forms.TextBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.lbRAMFabricante2 = New System.Windows.Forms.Label()
        Me.tRAMFabricante2 = New System.Windows.Forms.TextBox()
        Me.lbRAMModelo2 = New System.Windows.Forms.Label()
        Me.tRAMModelo2 = New System.Windows.Forms.TextBox()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.tRAMTamanho2 = New System.Windows.Forms.TextBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.tRAMID2 = New System.Windows.Forms.TextBox()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.tRAMVoltagem1 = New System.Windows.Forms.TextBox()
        Me.tRAMFrequencia1 = New System.Windows.Forms.TextBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.tRAMStatus1 = New System.Windows.Forms.TextBox()
        Me.lbRAMID1 = New System.Windows.Forms.Label()
        Me.tRAMTipo1 = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.lbRAMFabricante1 = New System.Windows.Forms.Label()
        Me.tRAMFabricante1 = New System.Windows.Forms.TextBox()
        Me.lbRAMModelo1 = New System.Windows.Forms.Label()
        Me.tRAMModelo1 = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.tRAMTamanho1 = New System.Windows.Forms.TextBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.tRAMID1 = New System.Windows.Forms.TextBox()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.tMemoriaUtilizada = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.tMemoriaUso = New System.Windows.Forms.TextBox()
        Me.pbMemoria = New System.Windows.Forms.ProgressBar()
        Me.tMemoriaTotal = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.PlacaMae = New System.Windows.Forms.TabPage()
        Me.tPlacaBarramento2 = New System.Windows.Forms.TextBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.tPlacaStatus = New System.Windows.Forms.TextBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.tPlacaSlots = New System.Windows.Forms.TextBox()
        Me.tPlacaBarramento1 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.tPlacaSerial = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.tPlacaIDSistema = New System.Windows.Forms.TextBox()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.tPlacaVersao = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.tPlacaModelo = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.tPlacaFabricante = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Unidades = New System.Windows.Forms.TabPage()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lbStatus6 = New System.Windows.Forms.Label()
        Me.tUnidadeStatus6 = New System.Windows.Forms.TextBox()
        Me.lbFabricante6 = New System.Windows.Forms.Label()
        Me.tUnidadeFabricante6 = New System.Windows.Forms.TextBox()
        Me.lbEspacoTotal6 = New System.Windows.Forms.Label()
        Me.tUnidadeTotal6 = New System.Windows.Forms.TextBox()
        Me.lbID6 = New System.Windows.Forms.Label()
        Me.tUnidadeID6 = New System.Windows.Forms.TextBox()
        Me.lbModelo6 = New System.Windows.Forms.Label()
        Me.tUnidadeModelo6 = New System.Windows.Forms.TextBox()
        Me.lbTipo6 = New System.Windows.Forms.Label()
        Me.tUnidadeTipo6 = New System.Windows.Forms.TextBox()
        Me.lbStatus5 = New System.Windows.Forms.Label()
        Me.tUnidadeStatus5 = New System.Windows.Forms.TextBox()
        Me.lbFabricante5 = New System.Windows.Forms.Label()
        Me.tUnidadeFabricante5 = New System.Windows.Forms.TextBox()
        Me.lbEspacoTotal5 = New System.Windows.Forms.Label()
        Me.tUnidadeTotal5 = New System.Windows.Forms.TextBox()
        Me.lbID5 = New System.Windows.Forms.Label()
        Me.tUnidadeID5 = New System.Windows.Forms.TextBox()
        Me.lbModelo5 = New System.Windows.Forms.Label()
        Me.tUnidadeModelo5 = New System.Windows.Forms.TextBox()
        Me.lbTipo5 = New System.Windows.Forms.Label()
        Me.tUnidadeTipo5 = New System.Windows.Forms.TextBox()
        Me.lbStatus4 = New System.Windows.Forms.Label()
        Me.tUnidadeStatus4 = New System.Windows.Forms.TextBox()
        Me.lbFabricante4 = New System.Windows.Forms.Label()
        Me.tUnidadeFabricante4 = New System.Windows.Forms.TextBox()
        Me.lbEspacoTotal4 = New System.Windows.Forms.Label()
        Me.tUnidadeTotal4 = New System.Windows.Forms.TextBox()
        Me.lbID4 = New System.Windows.Forms.Label()
        Me.tUnidadeID4 = New System.Windows.Forms.TextBox()
        Me.lbModelo4 = New System.Windows.Forms.Label()
        Me.tUnidadeModelo4 = New System.Windows.Forms.TextBox()
        Me.lbTipo4 = New System.Windows.Forms.Label()
        Me.tUnidadeTipo4 = New System.Windows.Forms.TextBox()
        Me.lbUnidade5 = New System.Windows.Forms.Label()
        Me.lbUnidade6 = New System.Windows.Forms.Label()
        Me.lbUnidade4 = New System.Windows.Forms.Label()
        Me.lbStatus3 = New System.Windows.Forms.Label()
        Me.tUnidadeStatus3 = New System.Windows.Forms.TextBox()
        Me.lbFabricante3 = New System.Windows.Forms.Label()
        Me.tUnidadeFabricante3 = New System.Windows.Forms.TextBox()
        Me.lbEspacoTotal3 = New System.Windows.Forms.Label()
        Me.tUnidadeTotal3 = New System.Windows.Forms.TextBox()
        Me.lbID3 = New System.Windows.Forms.Label()
        Me.tUnidadeID3 = New System.Windows.Forms.TextBox()
        Me.lbModelo3 = New System.Windows.Forms.Label()
        Me.tUnidadeModelo3 = New System.Windows.Forms.TextBox()
        Me.lbTipo3 = New System.Windows.Forms.Label()
        Me.tUnidadeTipo3 = New System.Windows.Forms.TextBox()
        Me.lbStatus2 = New System.Windows.Forms.Label()
        Me.tUnidadeStatus2 = New System.Windows.Forms.TextBox()
        Me.lbFabricante2 = New System.Windows.Forms.Label()
        Me.tUnidadeFabricante2 = New System.Windows.Forms.TextBox()
        Me.lbEspacoTotal2 = New System.Windows.Forms.Label()
        Me.tUnidadeTotal2 = New System.Windows.Forms.TextBox()
        Me.lbID2 = New System.Windows.Forms.Label()
        Me.tUnidadeID2 = New System.Windows.Forms.TextBox()
        Me.lbModelo2 = New System.Windows.Forms.Label()
        Me.tUnidadeModelo2 = New System.Windows.Forms.TextBox()
        Me.lbTipo2 = New System.Windows.Forms.Label()
        Me.tUnidadeTipo2 = New System.Windows.Forms.TextBox()
        Me.lbStatus1 = New System.Windows.Forms.Label()
        Me.tUnidadeStatus1 = New System.Windows.Forms.TextBox()
        Me.lbFabricante1 = New System.Windows.Forms.Label()
        Me.tUnidadeFabricante1 = New System.Windows.Forms.TextBox()
        Me.lbEspacoTotal1 = New System.Windows.Forms.Label()
        Me.tUnidadeTotal1 = New System.Windows.Forms.TextBox()
        Me.lbID1 = New System.Windows.Forms.Label()
        Me.tUnidadeID1 = New System.Windows.Forms.TextBox()
        Me.lbModelo1 = New System.Windows.Forms.Label()
        Me.tUnidadeModelo1 = New System.Windows.Forms.TextBox()
        Me.lbTipo1 = New System.Windows.Forms.Label()
        Me.tUnidadeTipo1 = New System.Windows.Forms.TextBox()
        Me.lbUnidade2 = New System.Windows.Forms.Label()
        Me.lbUnidade3 = New System.Windows.Forms.Label()
        Me.lbUnidade1 = New System.Windows.Forms.Label()
        Me.lbPC = New System.Windows.Forms.Label()
        Me.btnGPU = New System.Windows.Forms.Button()
        Me.btnMemoria = New System.Windows.Forms.Button()
        Me.btnPlaca = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUnidades = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.tmrInicio = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrDrives = New System.Windows.Forms.Timer(Me.components)
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Inicio.SuspendLayout()
        Me.grpMouse.SuspendLayout()
        Me.grpTemperatura.SuspendLayout()
        Me.grpRede.SuspendLayout()
        Me.grpBIOS.SuspendLayout()
        Me.grpBateria.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpSistema.SuspendLayout()
        Me.grpMonitor.SuspendLayout()
        Me.grpTeclado.SuspendLayout()
        Me.gpSO.SuspendLayout()
        Me.CPU.SuspendLayout()
        Me.grpProcessador.SuspendLayout()
        CType(Me.picHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQualcomm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIntel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAMD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOutros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCache.SuspendLayout()
        Me.GPU.SuspendLayout()
        CType(Me.picGPU2Nvidia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPU2EVGA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPU2Asus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPU2Intel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPU2AMD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPU2Outros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPU1Nvidia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPU1EVGA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPU1Asus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPU1Intel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPU1AMD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPU1Outros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Memoria.SuspendLayout()
        Me.PlacaMae.SuspendLayout()
        Me.Unidades.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1538, 12)
        Me.Panel1.TabIndex = 0
        '
        'B6
        '
        Me.B6.BackColor = System.Drawing.Color.Transparent
        Me.B6.Enabled = False
        Me.B6.FlatAppearance.BorderSize = 0
        Me.B6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B6.Location = New System.Drawing.Point(1095, 5)
        Me.B6.Margin = New System.Windows.Forms.Padding(4)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(215, 12)
        Me.B6.TabIndex = 14
        Me.B6.UseVisualStyleBackColor = False
        '
        'btnCPU
        '
        Me.btnCPU.BackColor = System.Drawing.Color.Transparent
        Me.btnCPU.BackgroundImage = CType(resources.GetObject("btnCPU.BackgroundImage"), System.Drawing.Image)
        Me.btnCPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCPU.FlatAppearance.BorderSize = 0
        Me.btnCPU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCPU.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCPU.ForeColor = System.Drawing.Color.White
        Me.btnCPU.Location = New System.Drawing.Point(231, 18)
        Me.btnCPU.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCPU.Name = "btnCPU"
        Me.btnCPU.Size = New System.Drawing.Size(215, 74)
        Me.btnCPU.TabIndex = 2
        Me.btnCPU.UseVisualStyleBackColor = False
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.Transparent
        Me.btnInicio.BackgroundImage = CType(resources.GetObject("btnInicio.BackgroundImage"), System.Drawing.Image)
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Location = New System.Drawing.Point(15, 18)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(215, 74)
        Me.btnInicio.TabIndex = 1
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'btnConfig
        '
        Me.btnConfig.BackColor = System.Drawing.Color.Transparent
        Me.btnConfig.BackgroundImage = CType(resources.GetObject("btnConfig.BackgroundImage"), System.Drawing.Image)
        Me.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfig.FlatAppearance.BorderSize = 0
        Me.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfig.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfig.ForeColor = System.Drawing.Color.White
        Me.btnConfig.Location = New System.Drawing.Point(1311, 18)
        Me.btnConfig.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(107, 74)
        Me.btnConfig.TabIndex = 0
        Me.btnConfig.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Inicio)
        Me.TabControl1.Controls.Add(Me.CPU)
        Me.TabControl1.Controls.Add(Me.GPU)
        Me.TabControl1.Controls.Add(Me.Memoria)
        Me.TabControl1.Controls.Add(Me.PlacaMae)
        Me.TabControl1.Controls.Add(Me.Unidades)
        Me.TabControl1.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 96)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1540, 630)
        Me.TabControl1.TabIndex = 1
        '
        'Inicio
        '
        Me.Inicio.BackColor = System.Drawing.Color.Gainsboro
        Me.Inicio.BackgroundImage = CType(resources.GetObject("Inicio.BackgroundImage"), System.Drawing.Image)
        Me.Inicio.Controls.Add(Me.grpMouse)
        Me.Inicio.Controls.Add(Me.grpTemperatura)
        Me.Inicio.Controls.Add(Me.grpRede)
        Me.Inicio.Controls.Add(Me.grpBIOS)
        Me.Inicio.Controls.Add(Me.grpBateria)
        Me.Inicio.Controls.Add(Me.grpSistema)
        Me.Inicio.Controls.Add(Me.grpMonitor)
        Me.Inicio.Controls.Add(Me.grpTeclado)
        Me.Inicio.Controls.Add(Me.gpSO)
        Me.Inicio.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Inicio.Location = New System.Drawing.Point(4, 26)
        Me.Inicio.Margin = New System.Windows.Forms.Padding(0)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(1532, 600)
        Me.Inicio.TabIndex = 0
        Me.Inicio.Text = "Início"
        '
        'grpMouse
        '
        Me.grpMouse.BackColor = System.Drawing.Color.Transparent
        Me.grpMouse.Controls.Add(Me.tStatusMouse)
        Me.grpMouse.Controls.Add(Me.Label43)
        Me.grpMouse.Controls.Add(Me.tDescricaoMouse)
        Me.grpMouse.Controls.Add(Me.Label44)
        Me.grpMouse.Controls.Add(Me.tFabricanteMouse)
        Me.grpMouse.Controls.Add(Me.Label45)
        Me.grpMouse.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMouse.Location = New System.Drawing.Point(519, 211)
        Me.grpMouse.Margin = New System.Windows.Forms.Padding(4)
        Me.grpMouse.Name = "grpMouse"
        Me.grpMouse.Padding = New System.Windows.Forms.Padding(4)
        Me.grpMouse.Size = New System.Drawing.Size(496, 197)
        Me.grpMouse.TabIndex = 10
        Me.grpMouse.TabStop = False
        Me.grpMouse.Text = "Mouse"
        '
        'tStatusMouse
        '
        Me.tStatusMouse.Enabled = False
        Me.tStatusMouse.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStatusMouse.Location = New System.Drawing.Point(108, 119)
        Me.tStatusMouse.Margin = New System.Windows.Forms.Padding(4)
        Me.tStatusMouse.Name = "tStatusMouse"
        Me.tStatusMouse.Size = New System.Drawing.Size(375, 27)
        Me.tStatusMouse.TabIndex = 5
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(8, 122)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(59, 21)
        Me.Label43.TabIndex = 4
        Me.Label43.Text = "Status"
        '
        'tDescricaoMouse
        '
        Me.tDescricaoMouse.Enabled = False
        Me.tDescricaoMouse.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDescricaoMouse.Location = New System.Drawing.Point(108, 78)
        Me.tDescricaoMouse.Margin = New System.Windows.Forms.Padding(4)
        Me.tDescricaoMouse.Name = "tDescricaoMouse"
        Me.tDescricaoMouse.Size = New System.Drawing.Size(375, 27)
        Me.tDescricaoMouse.TabIndex = 3
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(8, 81)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(84, 21)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Descrição"
        '
        'tFabricanteMouse
        '
        Me.tFabricanteMouse.Enabled = False
        Me.tFabricanteMouse.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFabricanteMouse.Location = New System.Drawing.Point(108, 38)
        Me.tFabricanteMouse.Margin = New System.Windows.Forms.Padding(4)
        Me.tFabricanteMouse.Name = "tFabricanteMouse"
        Me.tFabricanteMouse.Size = New System.Drawing.Size(375, 27)
        Me.tFabricanteMouse.TabIndex = 1
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(8, 41)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(90, 21)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "Fabricante"
        '
        'grpTemperatura
        '
        Me.grpTemperatura.BackColor = System.Drawing.Color.Transparent
        Me.grpTemperatura.Controls.Add(Me.tAudioStatus)
        Me.grpTemperatura.Controls.Add(Me.Label35)
        Me.grpTemperatura.Controls.Add(Me.tAudioNome)
        Me.grpTemperatura.Controls.Add(Me.Label36)
        Me.grpTemperatura.Controls.Add(Me.tAudioFabricante)
        Me.grpTemperatura.Controls.Add(Me.Label37)
        Me.grpTemperatura.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTemperatura.Location = New System.Drawing.Point(519, 413)
        Me.grpTemperatura.Margin = New System.Windows.Forms.Padding(4)
        Me.grpTemperatura.Name = "grpTemperatura"
        Me.grpTemperatura.Padding = New System.Windows.Forms.Padding(4)
        Me.grpTemperatura.Size = New System.Drawing.Size(496, 197)
        Me.grpTemperatura.TabIndex = 9
        Me.grpTemperatura.TabStop = False
        Me.grpTemperatura.Text = "Placa de Áudio"
        '
        'tAudioStatus
        '
        Me.tAudioStatus.Enabled = False
        Me.tAudioStatus.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAudioStatus.Location = New System.Drawing.Point(108, 119)
        Me.tAudioStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.tAudioStatus.Name = "tAudioStatus"
        Me.tAudioStatus.Size = New System.Drawing.Size(375, 27)
        Me.tAudioStatus.TabIndex = 5
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(8, 122)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(59, 21)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Status"
        '
        'tAudioNome
        '
        Me.tAudioNome.Enabled = False
        Me.tAudioNome.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAudioNome.Location = New System.Drawing.Point(108, 78)
        Me.tAudioNome.Margin = New System.Windows.Forms.Padding(4)
        Me.tAudioNome.Name = "tAudioNome"
        Me.tAudioNome.Size = New System.Drawing.Size(375, 27)
        Me.tAudioNome.TabIndex = 3
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(8, 81)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(55, 21)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "Nome"
        '
        'tAudioFabricante
        '
        Me.tAudioFabricante.Enabled = False
        Me.tAudioFabricante.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAudioFabricante.Location = New System.Drawing.Point(108, 38)
        Me.tAudioFabricante.Margin = New System.Windows.Forms.Padding(4)
        Me.tAudioFabricante.Name = "tAudioFabricante"
        Me.tAudioFabricante.Size = New System.Drawing.Size(375, 27)
        Me.tAudioFabricante.TabIndex = 1
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(8, 41)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(90, 21)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Fabricante"
        '
        'grpRede
        '
        Me.grpRede.BackColor = System.Drawing.Color.Transparent
        Me.grpRede.Controls.Add(Me.tStatusRede)
        Me.grpRede.Controls.Add(Me.Label38)
        Me.grpRede.Controls.Add(Me.tNomeRede)
        Me.grpRede.Controls.Add(Me.Label40)
        Me.grpRede.Controls.Add(Me.tFabricanteRede)
        Me.grpRede.Controls.Add(Me.Label41)
        Me.grpRede.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRede.Location = New System.Drawing.Point(9, 413)
        Me.grpRede.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRede.Name = "grpRede"
        Me.grpRede.Padding = New System.Windows.Forms.Padding(4)
        Me.grpRede.Size = New System.Drawing.Size(496, 197)
        Me.grpRede.TabIndex = 8
        Me.grpRede.TabStop = False
        Me.grpRede.Text = "Placa de Rede"
        '
        'tStatusRede
        '
        Me.tStatusRede.Enabled = False
        Me.tStatusRede.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStatusRede.Location = New System.Drawing.Point(100, 119)
        Me.tStatusRede.Margin = New System.Windows.Forms.Padding(4)
        Me.tStatusRede.Name = "tStatusRede"
        Me.tStatusRede.Size = New System.Drawing.Size(375, 27)
        Me.tStatusRede.TabIndex = 7
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(8, 122)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(59, 21)
        Me.Label38.TabIndex = 6
        Me.Label38.Text = "Status"
        '
        'tNomeRede
        '
        Me.tNomeRede.Enabled = False
        Me.tNomeRede.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNomeRede.Location = New System.Drawing.Point(100, 78)
        Me.tNomeRede.Margin = New System.Windows.Forms.Padding(4)
        Me.tNomeRede.Name = "tNomeRede"
        Me.tNomeRede.Size = New System.Drawing.Size(375, 27)
        Me.tNomeRede.TabIndex = 3
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(8, 81)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(55, 21)
        Me.Label40.TabIndex = 2
        Me.Label40.Text = "Nome"
        '
        'tFabricanteRede
        '
        Me.tFabricanteRede.Enabled = False
        Me.tFabricanteRede.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFabricanteRede.Location = New System.Drawing.Point(100, 38)
        Me.tFabricanteRede.Margin = New System.Windows.Forms.Padding(4)
        Me.tFabricanteRede.Name = "tFabricanteRede"
        Me.tFabricanteRede.Size = New System.Drawing.Size(375, 27)
        Me.tFabricanteRede.TabIndex = 1
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(8, 41)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(90, 21)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Fabricante"
        '
        'grpBIOS
        '
        Me.grpBIOS.BackColor = System.Drawing.Color.Transparent
        Me.grpBIOS.Controls.Add(Me.tSerialBIOS)
        Me.grpBIOS.Controls.Add(Me.Label22)
        Me.grpBIOS.Controls.Add(Me.tVersaoBIOS)
        Me.grpBIOS.Controls.Add(Me.Label23)
        Me.grpBIOS.Controls.Add(Me.tNomeBIOS)
        Me.grpBIOS.Controls.Add(Me.Label24)
        Me.grpBIOS.Controls.Add(Me.tFabricanteBIOS)
        Me.grpBIOS.Controls.Add(Me.Label25)
        Me.grpBIOS.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBIOS.Location = New System.Drawing.Point(1029, 9)
        Me.grpBIOS.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBIOS.Name = "grpBIOS"
        Me.grpBIOS.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBIOS.Size = New System.Drawing.Size(496, 197)
        Me.grpBIOS.TabIndex = 9
        Me.grpBIOS.TabStop = False
        Me.grpBIOS.Text = "BIOS"
        '
        'tSerialBIOS
        '
        Me.tSerialBIOS.Enabled = False
        Me.tSerialBIOS.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSerialBIOS.Location = New System.Drawing.Point(108, 159)
        Me.tSerialBIOS.Margin = New System.Windows.Forms.Padding(4)
        Me.tSerialBIOS.Name = "tSerialBIOS"
        Me.tSerialBIOS.Size = New System.Drawing.Size(375, 27)
        Me.tSerialBIOS.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 162)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 21)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Serial"
        '
        'tVersaoBIOS
        '
        Me.tVersaoBIOS.Enabled = False
        Me.tVersaoBIOS.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tVersaoBIOS.Location = New System.Drawing.Point(108, 119)
        Me.tVersaoBIOS.Margin = New System.Windows.Forms.Padding(4)
        Me.tVersaoBIOS.Name = "tVersaoBIOS"
        Me.tVersaoBIOS.Size = New System.Drawing.Size(375, 27)
        Me.tVersaoBIOS.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 122)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 21)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Versão"
        '
        'tNomeBIOS
        '
        Me.tNomeBIOS.Enabled = False
        Me.tNomeBIOS.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNomeBIOS.Location = New System.Drawing.Point(108, 78)
        Me.tNomeBIOS.Margin = New System.Windows.Forms.Padding(4)
        Me.tNomeBIOS.Name = "tNomeBIOS"
        Me.tNomeBIOS.Size = New System.Drawing.Size(375, 27)
        Me.tNomeBIOS.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 81)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(55, 21)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Nome"
        '
        'tFabricanteBIOS
        '
        Me.tFabricanteBIOS.Enabled = False
        Me.tFabricanteBIOS.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFabricanteBIOS.Location = New System.Drawing.Point(108, 38)
        Me.tFabricanteBIOS.Margin = New System.Windows.Forms.Padding(4)
        Me.tFabricanteBIOS.Name = "tFabricanteBIOS"
        Me.tFabricanteBIOS.Size = New System.Drawing.Size(375, 27)
        Me.tFabricanteBIOS.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 41)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(90, 21)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Fabricante"
        '
        'grpBateria
        '
        Me.grpBateria.BackColor = System.Drawing.Color.Transparent
        Me.grpBateria.Controls.Add(Me.GroupBox1)
        Me.grpBateria.Controls.Add(Me.GroupBox2)
        Me.grpBateria.Controls.Add(Me.tTempo)
        Me.grpBateria.Controls.Add(Me.Label17)
        Me.grpBateria.Controls.Add(Me.tQuantidade)
        Me.grpBateria.Controls.Add(Me.Label18)
        Me.grpBateria.Controls.Add(Me.tConectada)
        Me.grpBateria.Controls.Add(Me.Label19)
        Me.grpBateria.Controls.Add(Me.tStatusBateria)
        Me.grpBateria.Controls.Add(Me.Label20)
        Me.grpBateria.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBateria.Location = New System.Drawing.Point(1029, 413)
        Me.grpBateria.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBateria.Name = "grpBateria"
        Me.grpBateria.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBateria.Size = New System.Drawing.Size(496, 197)
        Me.grpBateria.TabIndex = 8
        Me.grpBateria.TabStop = False
        Me.grpBateria.Text = "Bateria (Notebook)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1021, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(496, 197)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bateria (Notebook)"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(108, 159)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(375, 27)
        Me.TextBox7.TabIndex = 7
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 162)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(59, 21)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Tempo"
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(108, 119)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(375, 27)
        Me.TextBox8.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 122)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(94, 21)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Quantidade"
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(108, 78)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(375, 27)
        Me.TextBox9.TabIndex = 3
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(8, 81)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(74, 21)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Situação"
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(108, 38)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(375, 27)
        Me.TextBox10.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 41)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 21)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.TextBox13)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.TextBox14)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(511, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(496, 197)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Monitor Primário"
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(108, 159)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(375, 27)
        Me.TextBox11.TabIndex = 7
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 162)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(70, 21)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Label30"
        '
        'TextBox12
        '
        Me.TextBox12.Enabled = False
        Me.TextBox12.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(108, 119)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(375, 27)
        Me.TextBox12.TabIndex = 5
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(8, 122)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(104, 21)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "Identificação"
        '
        'TextBox13
        '
        Me.TextBox13.Enabled = False
        Me.TextBox13.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(108, 78)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(375, 27)
        Me.TextBox13.TabIndex = 3
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(8, 81)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 21)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "Resolução"
        '
        'TextBox14
        '
        Me.TextBox14.Enabled = False
        Me.TextBox14.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(108, 38)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(375, 27)
        Me.TextBox14.TabIndex = 1
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(8, 41)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(90, 21)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Fabricante"
        '
        'tTempo
        '
        Me.tTempo.Enabled = False
        Me.tTempo.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTempo.Location = New System.Drawing.Point(108, 119)
        Me.tTempo.Margin = New System.Windows.Forms.Padding(4)
        Me.tTempo.Name = "tTempo"
        Me.tTempo.Size = New System.Drawing.Size(375, 27)
        Me.tTempo.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 162)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 21)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Status"
        '
        'tQuantidade
        '
        Me.tQuantidade.Enabled = False
        Me.tQuantidade.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tQuantidade.Location = New System.Drawing.Point(108, 79)
        Me.tQuantidade.Margin = New System.Windows.Forms.Padding(4)
        Me.tQuantidade.Name = "tQuantidade"
        Me.tQuantidade.Size = New System.Drawing.Size(375, 27)
        Me.tQuantidade.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 122)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 21)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Tempo"
        '
        'tConectada
        '
        Me.tConectada.Enabled = False
        Me.tConectada.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tConectada.Location = New System.Drawing.Point(108, 38)
        Me.tConectada.Margin = New System.Windows.Forms.Padding(4)
        Me.tConectada.Name = "tConectada"
        Me.tConectada.Size = New System.Drawing.Size(375, 27)
        Me.tConectada.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 81)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 21)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Quantidade"
        '
        'tStatusBateria
        '
        Me.tStatusBateria.Enabled = False
        Me.tStatusBateria.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStatusBateria.Location = New System.Drawing.Point(108, 159)
        Me.tStatusBateria.Margin = New System.Windows.Forms.Padding(4)
        Me.tStatusBateria.Name = "tStatusBateria"
        Me.tStatusBateria.Size = New System.Drawing.Size(375, 27)
        Me.tStatusBateria.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 41)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 21)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Conexão"
        '
        'grpSistema
        '
        Me.grpSistema.BackColor = System.Drawing.Color.Transparent
        Me.grpSistema.Controls.Add(Me.tInternet)
        Me.grpSistema.Controls.Add(Me.Label13)
        Me.grpSistema.Controls.Add(Me.tHora)
        Me.grpSistema.Controls.Add(Me.Label14)
        Me.grpSistema.Controls.Add(Me.tModelo)
        Me.grpSistema.Controls.Add(Me.Label15)
        Me.grpSistema.Controls.Add(Me.tFabricanteMaquina)
        Me.grpSistema.Controls.Add(Me.Label16)
        Me.grpSistema.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSistema.Location = New System.Drawing.Point(9, 9)
        Me.grpSistema.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSistema.Name = "grpSistema"
        Me.grpSistema.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSistema.Size = New System.Drawing.Size(496, 197)
        Me.grpSistema.TabIndex = 8
        Me.grpSistema.TabStop = False
        Me.grpSistema.Text = "Máquina"
        '
        'tInternet
        '
        Me.tInternet.Enabled = False
        Me.tInternet.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tInternet.Location = New System.Drawing.Point(108, 159)
        Me.tInternet.Margin = New System.Windows.Forms.Padding(4)
        Me.tInternet.Name = "tInternet"
        Me.tInternet.Size = New System.Drawing.Size(375, 27)
        Me.tInternet.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 162)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 21)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Rede"
        '
        'tHora
        '
        Me.tHora.Enabled = False
        Me.tHora.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tHora.Location = New System.Drawing.Point(108, 119)
        Me.tHora.Margin = New System.Windows.Forms.Padding(4)
        Me.tHora.Name = "tHora"
        Me.tHora.Size = New System.Drawing.Size(375, 27)
        Me.tHora.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 122)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 21)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Data Local"
        '
        'tModelo
        '
        Me.tModelo.Enabled = False
        Me.tModelo.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tModelo.Location = New System.Drawing.Point(108, 78)
        Me.tModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.tModelo.Name = "tModelo"
        Me.tModelo.Size = New System.Drawing.Size(375, 27)
        Me.tModelo.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 81)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 21)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Modelo"
        '
        'tFabricanteMaquina
        '
        Me.tFabricanteMaquina.Enabled = False
        Me.tFabricanteMaquina.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFabricanteMaquina.Location = New System.Drawing.Point(108, 38)
        Me.tFabricanteMaquina.Margin = New System.Windows.Forms.Padding(4)
        Me.tFabricanteMaquina.Name = "tFabricanteMaquina"
        Me.tFabricanteMaquina.Size = New System.Drawing.Size(375, 27)
        Me.tFabricanteMaquina.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 41)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 21)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Fabricante"
        '
        'grpMonitor
        '
        Me.grpMonitor.BackColor = System.Drawing.Color.Transparent
        Me.grpMonitor.Controls.Add(Me.tStatusMonitor)
        Me.grpMonitor.Controls.Add(Me.Resolução)
        Me.grpMonitor.Controls.Add(Me.tResolucao)
        Me.grpMonitor.Controls.Add(Me.Label11)
        Me.grpMonitor.Controls.Add(Me.tDescricaoMonitor)
        Me.grpMonitor.Controls.Add(Me.Label12)
        Me.grpMonitor.Controls.Add(Me.tFabricanteMonitor)
        Me.grpMonitor.Controls.Add(Me.Fabricante)
        Me.grpMonitor.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMonitor.Location = New System.Drawing.Point(1029, 211)
        Me.grpMonitor.Margin = New System.Windows.Forms.Padding(4)
        Me.grpMonitor.Name = "grpMonitor"
        Me.grpMonitor.Padding = New System.Windows.Forms.Padding(4)
        Me.grpMonitor.Size = New System.Drawing.Size(496, 197)
        Me.grpMonitor.TabIndex = 3
        Me.grpMonitor.TabStop = False
        Me.grpMonitor.Text = "Monitor Primário"
        '
        'tStatusMonitor
        '
        Me.tStatusMonitor.Enabled = False
        Me.tStatusMonitor.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStatusMonitor.Location = New System.Drawing.Point(108, 159)
        Me.tStatusMonitor.Margin = New System.Windows.Forms.Padding(4)
        Me.tStatusMonitor.Name = "tStatusMonitor"
        Me.tStatusMonitor.Size = New System.Drawing.Size(375, 27)
        Me.tStatusMonitor.TabIndex = 7
        '
        'Resolução
        '
        Me.Resolução.AutoSize = True
        Me.Resolução.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resolução.Location = New System.Drawing.Point(8, 162)
        Me.Resolução.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Resolução.Name = "Resolução"
        Me.Resolução.Size = New System.Drawing.Size(59, 21)
        Me.Resolução.TabIndex = 6
        Me.Resolução.Text = "Status"
        '
        'tResolucao
        '
        Me.tResolucao.Enabled = False
        Me.tResolucao.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tResolucao.Location = New System.Drawing.Point(108, 119)
        Me.tResolucao.Margin = New System.Windows.Forms.Padding(4)
        Me.tResolucao.Name = "tResolucao"
        Me.tResolucao.Size = New System.Drawing.Size(375, 27)
        Me.tResolucao.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 122)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 21)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Resolução"
        '
        'tDescricaoMonitor
        '
        Me.tDescricaoMonitor.Enabled = False
        Me.tDescricaoMonitor.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDescricaoMonitor.Location = New System.Drawing.Point(108, 78)
        Me.tDescricaoMonitor.Margin = New System.Windows.Forms.Padding(4)
        Me.tDescricaoMonitor.Name = "tDescricaoMonitor"
        Me.tDescricaoMonitor.Size = New System.Drawing.Size(375, 27)
        Me.tDescricaoMonitor.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 81)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 21)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Descrição"
        '
        'tFabricanteMonitor
        '
        Me.tFabricanteMonitor.Enabled = False
        Me.tFabricanteMonitor.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFabricanteMonitor.Location = New System.Drawing.Point(108, 38)
        Me.tFabricanteMonitor.Margin = New System.Windows.Forms.Padding(4)
        Me.tFabricanteMonitor.Name = "tFabricanteMonitor"
        Me.tFabricanteMonitor.Size = New System.Drawing.Size(375, 27)
        Me.tFabricanteMonitor.TabIndex = 1
        '
        'Fabricante
        '
        Me.Fabricante.AutoSize = True
        Me.Fabricante.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fabricante.Location = New System.Drawing.Point(8, 41)
        Me.Fabricante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Fabricante.Name = "Fabricante"
        Me.Fabricante.Size = New System.Drawing.Size(90, 21)
        Me.Fabricante.TabIndex = 0
        Me.Fabricante.Text = "Fabricante"
        '
        'grpTeclado
        '
        Me.grpTeclado.BackColor = System.Drawing.Color.Transparent
        Me.grpTeclado.Controls.Add(Me.tLinguagemTeclado)
        Me.grpTeclado.Controls.Add(Me.Label6)
        Me.grpTeclado.Controls.Add(Me.tNumLock)
        Me.grpTeclado.Controls.Add(Me.Label7)
        Me.grpTeclado.Controls.Add(Me.tScrollLock)
        Me.grpTeclado.Controls.Add(Me.Label8)
        Me.grpTeclado.Controls.Add(Me.tCapsLock)
        Me.grpTeclado.Controls.Add(Me.Label9)
        Me.grpTeclado.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTeclado.Location = New System.Drawing.Point(9, 211)
        Me.grpTeclado.Margin = New System.Windows.Forms.Padding(4)
        Me.grpTeclado.Name = "grpTeclado"
        Me.grpTeclado.Padding = New System.Windows.Forms.Padding(4)
        Me.grpTeclado.Size = New System.Drawing.Size(496, 197)
        Me.grpTeclado.TabIndex = 2
        Me.grpTeclado.TabStop = False
        Me.grpTeclado.Text = "Teclado"
        '
        'tLinguagemTeclado
        '
        Me.tLinguagemTeclado.Enabled = False
        Me.tLinguagemTeclado.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLinguagemTeclado.Location = New System.Drawing.Point(100, 159)
        Me.tLinguagemTeclado.Margin = New System.Windows.Forms.Padding(4)
        Me.tLinguagemTeclado.Name = "tLinguagemTeclado"
        Me.tLinguagemTeclado.Size = New System.Drawing.Size(375, 27)
        Me.tLinguagemTeclado.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 162)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Charset"
        '
        'tNumLock
        '
        Me.tNumLock.Enabled = False
        Me.tNumLock.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNumLock.Location = New System.Drawing.Point(100, 119)
        Me.tNumLock.Margin = New System.Windows.Forms.Padding(4)
        Me.tNumLock.Name = "tNumLock"
        Me.tNumLock.Size = New System.Drawing.Size(375, 27)
        Me.tNumLock.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 122)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "NumLock"
        '
        'tScrollLock
        '
        Me.tScrollLock.Enabled = False
        Me.tScrollLock.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tScrollLock.Location = New System.Drawing.Point(100, 78)
        Me.tScrollLock.Margin = New System.Windows.Forms.Padding(4)
        Me.tScrollLock.Name = "tScrollLock"
        Me.tScrollLock.Size = New System.Drawing.Size(375, 27)
        Me.tScrollLock.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 81)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "ScrollLock"
        '
        'tCapsLock
        '
        Me.tCapsLock.Enabled = False
        Me.tCapsLock.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCapsLock.Location = New System.Drawing.Point(100, 38)
        Me.tCapsLock.Margin = New System.Windows.Forms.Padding(4)
        Me.tCapsLock.Name = "tCapsLock"
        Me.tCapsLock.Size = New System.Drawing.Size(375, 27)
        Me.tCapsLock.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 41)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "CapsLock"
        '
        'gpSO
        '
        Me.gpSO.BackColor = System.Drawing.Color.Transparent
        Me.gpSO.Controls.Add(Me.tLinguagemSO)
        Me.gpSO.Controls.Add(Me.Linguagem)
        Me.gpSO.Controls.Add(Me.tVersao)
        Me.gpSO.Controls.Add(Me.Label5)
        Me.gpSO.Controls.Add(Me.tPlataforma)
        Me.gpSO.Controls.Add(Me.Label4)
        Me.gpSO.Controls.Add(Me.tSistema)
        Me.gpSO.Controls.Add(Me.Label1)
        Me.gpSO.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpSO.Location = New System.Drawing.Point(519, 9)
        Me.gpSO.Margin = New System.Windows.Forms.Padding(4)
        Me.gpSO.Name = "gpSO"
        Me.gpSO.Padding = New System.Windows.Forms.Padding(4)
        Me.gpSO.Size = New System.Drawing.Size(496, 197)
        Me.gpSO.TabIndex = 1
        Me.gpSO.TabStop = False
        Me.gpSO.Text = "Sistema Operacional"
        '
        'tLinguagemSO
        '
        Me.tLinguagemSO.Enabled = False
        Me.tLinguagemSO.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLinguagemSO.Location = New System.Drawing.Point(108, 159)
        Me.tLinguagemSO.Margin = New System.Windows.Forms.Padding(4)
        Me.tLinguagemSO.Name = "tLinguagemSO"
        Me.tLinguagemSO.Size = New System.Drawing.Size(375, 27)
        Me.tLinguagemSO.TabIndex = 7
        '
        'Linguagem
        '
        Me.Linguagem.AutoSize = True
        Me.Linguagem.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linguagem.Location = New System.Drawing.Point(8, 162)
        Me.Linguagem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Linguagem.Name = "Linguagem"
        Me.Linguagem.Size = New System.Drawing.Size(93, 21)
        Me.Linguagem.TabIndex = 6
        Me.Linguagem.Text = "Linguagem"
        '
        'tVersao
        '
        Me.tVersao.Enabled = False
        Me.tVersao.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tVersao.Location = New System.Drawing.Point(108, 119)
        Me.tVersao.Margin = New System.Windows.Forms.Padding(4)
        Me.tVersao.Name = "tVersao"
        Me.tVersao.Size = New System.Drawing.Size(375, 27)
        Me.tVersao.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 122)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Versão"
        '
        'tPlataforma
        '
        Me.tPlataforma.Enabled = False
        Me.tPlataforma.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPlataforma.Location = New System.Drawing.Point(108, 78)
        Me.tPlataforma.Margin = New System.Windows.Forms.Padding(4)
        Me.tPlataforma.Name = "tPlataforma"
        Me.tPlataforma.Size = New System.Drawing.Size(375, 27)
        Me.tPlataforma.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 81)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Plataforma"
        '
        'tSistema
        '
        Me.tSistema.Enabled = False
        Me.tSistema.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSistema.Location = New System.Drawing.Point(108, 38)
        Me.tSistema.Margin = New System.Windows.Forms.Padding(4)
        Me.tSistema.Name = "tSistema"
        Me.tSistema.Size = New System.Drawing.Size(375, 27)
        Me.tSistema.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema"
        '
        'CPU
        '
        Me.CPU.BackColor = System.Drawing.Color.Gainsboro
        Me.CPU.BackgroundImage = CType(resources.GetObject("CPU.BackgroundImage"), System.Drawing.Image)
        Me.CPU.Controls.Add(Me.Label90)
        Me.CPU.Controls.Add(Me.tCPUUso)
        Me.CPU.Controls.Add(Me.Label89)
        Me.CPU.Controls.Add(Me.pbCPU)
        Me.CPU.Controls.Add(Me.grpProcessador)
        Me.CPU.Controls.Add(Me.grpCache)
        Me.CPU.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.CPU.Location = New System.Drawing.Point(4, 26)
        Me.CPU.Margin = New System.Windows.Forms.Padding(0)
        Me.CPU.Name = "CPU"
        Me.CPU.Size = New System.Drawing.Size(1532, 600)
        Me.CPU.TabIndex = 1
        Me.CPU.Text = "CPU"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(677, 86)
        Me.Label90.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(39, 21)
        Me.Label90.TabIndex = 74
        Me.Label90.Text = "Uso"
        '
        'tCPUUso
        '
        Me.tCPUUso.Enabled = False
        Me.tCPUUso.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCPUUso.Location = New System.Drawing.Point(716, 83)
        Me.tCPUUso.Margin = New System.Windows.Forms.Padding(4)
        Me.tCPUUso.Name = "tCPUUso"
        Me.tCPUUso.Size = New System.Drawing.Size(56, 27)
        Me.tCPUUso.TabIndex = 75
        Me.tCPUUso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(16, 9)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(252, 24)
        Me.Label89.TabIndex = 69
        Me.Label89.Text = "Unidade de Processamento"
        '
        'pbCPU
        '
        Me.pbCPU.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbCPU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.pbCPU.Location = New System.Drawing.Point(316, 28)
        Me.pbCPU.Margin = New System.Windows.Forms.Padding(0)
        Me.pbCPU.Name = "pbCPU"
        Me.pbCPU.Size = New System.Drawing.Size(900, 43)
        Me.pbCPU.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbCPU.TabIndex = 67
        '
        'grpProcessador
        '
        Me.grpProcessador.BackColor = System.Drawing.Color.Transparent
        Me.grpProcessador.Controls.Add(Me.tProcessadorStatus)
        Me.grpProcessador.Controls.Add(Me.Label73)
        Me.grpProcessador.Controls.Add(Me.tProcessadorNome)
        Me.grpProcessador.Controls.Add(Me.tProcessadorThreads)
        Me.grpProcessador.Controls.Add(Me.picHP)
        Me.grpProcessador.Controls.Add(Me.tProcessadorFabricante)
        Me.grpProcessador.Controls.Add(Me.Label21)
        Me.grpProcessador.Controls.Add(Me.picQualcomm)
        Me.grpProcessador.Controls.Add(Me.Label2)
        Me.grpProcessador.Controls.Add(Me.Label46)
        Me.grpProcessador.Controls.Add(Me.tProcessadorLogicos)
        Me.grpProcessador.Controls.Add(Me.tProcessadorFamilia)
        Me.grpProcessador.Controls.Add(Me.Label48)
        Me.grpProcessador.Controls.Add(Me.Label10)
        Me.grpProcessador.Controls.Add(Me.tProcessadorNucleosHab)
        Me.grpProcessador.Controls.Add(Me.tProcessadorClockAtual)
        Me.grpProcessador.Controls.Add(Me.Label49)
        Me.grpProcessador.Controls.Add(Me.Label42)
        Me.grpProcessador.Controls.Add(Me.tProcessadorClockMax)
        Me.grpProcessador.Controls.Add(Me.Threads)
        Me.grpProcessador.Controls.Add(Me.picIntel)
        Me.grpProcessador.Controls.Add(Me.tProcessadorNucleos)
        Me.grpProcessador.Controls.Add(Me.picAMD)
        Me.grpProcessador.Controls.Add(Me.Label47)
        Me.grpProcessador.Controls.Add(Me.picOutros)
        Me.grpProcessador.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProcessador.Location = New System.Drawing.Point(9, 142)
        Me.grpProcessador.Margin = New System.Windows.Forms.Padding(4)
        Me.grpProcessador.Name = "grpProcessador"
        Me.grpProcessador.Padding = New System.Windows.Forms.Padding(4)
        Me.grpProcessador.Size = New System.Drawing.Size(1514, 277)
        Me.grpProcessador.TabIndex = 45
        Me.grpProcessador.TabStop = False
        Me.grpProcessador.Text = "Características"
        '
        'tProcessadorStatus
        '
        Me.tProcessadorStatus.Enabled = False
        Me.tProcessadorStatus.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorStatus.Location = New System.Drawing.Point(108, 238)
        Me.tProcessadorStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorStatus.Name = "tProcessadorStatus"
        Me.tProcessadorStatus.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorStatus.TabIndex = 27
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(9, 241)
        Me.Label73.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(59, 21)
        Me.Label73.TabIndex = 26
        Me.Label73.Text = "Status"
        '
        'tProcessadorNome
        '
        Me.tProcessadorNome.Enabled = False
        Me.tProcessadorNome.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorNome.Location = New System.Drawing.Point(108, 38)
        Me.tProcessadorNome.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorNome.Name = "tProcessadorNome"
        Me.tProcessadorNome.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorNome.TabIndex = 3
        '
        'tProcessadorThreads
        '
        Me.tProcessadorThreads.Enabled = False
        Me.tProcessadorThreads.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorThreads.Location = New System.Drawing.Point(1127, 115)
        Me.tProcessadorThreads.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorThreads.Name = "tProcessadorThreads"
        Me.tProcessadorThreads.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorThreads.TabIndex = 18
        '
        'picHP
        '
        Me.picHP.Image = CType(resources.GetObject("picHP.Image"), System.Drawing.Image)
        Me.picHP.Location = New System.Drawing.Point(649, 75)
        Me.picHP.Name = "picHP"
        Me.picHP.Size = New System.Drawing.Size(150, 150)
        Me.picHP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHP.TabIndex = 25
        Me.picHP.TabStop = False
        '
        'tProcessadorFabricante
        '
        Me.tProcessadorFabricante.Enabled = False
        Me.tProcessadorFabricante.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorFabricante.Location = New System.Drawing.Point(108, 78)
        Me.tProcessadorFabricante.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorFabricante.Name = "tProcessadorFabricante"
        Me.tProcessadorFabricante.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorFabricante.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(9, 41)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 21)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Nome"
        '
        'picQualcomm
        '
        Me.picQualcomm.Image = CType(resources.GetObject("picQualcomm.Image"), System.Drawing.Image)
        Me.picQualcomm.Location = New System.Drawing.Point(649, 75)
        Me.picQualcomm.Name = "picQualcomm"
        Me.picQualcomm.Size = New System.Drawing.Size(150, 150)
        Me.picQualcomm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQualcomm.TabIndex = 24
        Me.picQualcomm.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fabricante"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(9, 121)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(66, 21)
        Me.Label46.TabIndex = 6
        Me.Label46.Text = "Família"
        '
        'tProcessadorLogicos
        '
        Me.tProcessadorLogicos.Enabled = False
        Me.tProcessadorLogicos.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorLogicos.Location = New System.Drawing.Point(1127, 198)
        Me.tProcessadorLogicos.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorLogicos.Name = "tProcessadorLogicos"
        Me.tProcessadorLogicos.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorLogicos.TabIndex = 22
        '
        'tProcessadorFamilia
        '
        Me.tProcessadorFamilia.Enabled = False
        Me.tProcessadorFamilia.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorFamilia.Location = New System.Drawing.Point(108, 118)
        Me.tProcessadorFamilia.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorFamilia.Name = "tProcessadorFamilia"
        Me.tProcessadorFamilia.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorFamilia.TabIndex = 7
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(934, 201)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(185, 21)
        Me.Label48.TabIndex = 21
        Me.Label48.Text = "Processadores Lógicos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 161)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 21)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Clock Atual"
        '
        'tProcessadorNucleosHab
        '
        Me.tProcessadorNucleosHab.Enabled = False
        Me.tProcessadorNucleosHab.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorNucleosHab.Location = New System.Drawing.Point(1127, 158)
        Me.tProcessadorNucleosHab.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorNucleosHab.Name = "tProcessadorNucleosHab"
        Me.tProcessadorNucleosHab.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorNucleosHab.TabIndex = 20
        '
        'tProcessadorClockAtual
        '
        Me.tProcessadorClockAtual.Enabled = False
        Me.tProcessadorClockAtual.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorClockAtual.Location = New System.Drawing.Point(108, 158)
        Me.tProcessadorClockAtual.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorClockAtual.Name = "tProcessadorClockAtual"
        Me.tProcessadorClockAtual.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorClockAtual.TabIndex = 9
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(934, 161)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(159, 21)
        Me.Label49.TabIndex = 19
        Me.Label49.Text = "Núcleos Habilitados"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(9, 201)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(90, 21)
        Me.Label42.TabIndex = 10
        Me.Label42.Text = "Clock Máx."
        '
        'tProcessadorClockMax
        '
        Me.tProcessadorClockMax.Enabled = False
        Me.tProcessadorClockMax.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorClockMax.Location = New System.Drawing.Point(108, 198)
        Me.tProcessadorClockMax.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorClockMax.Name = "tProcessadorClockMax"
        Me.tProcessadorClockMax.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorClockMax.TabIndex = 11
        '
        'Threads
        '
        Me.Threads.AutoSize = True
        Me.Threads.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Threads.Location = New System.Drawing.Point(934, 118)
        Me.Threads.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Threads.Name = "Threads"
        Me.Threads.Size = New System.Drawing.Size(70, 21)
        Me.Threads.TabIndex = 17
        Me.Threads.Text = "Threads"
        '
        'picIntel
        '
        Me.picIntel.Image = CType(resources.GetObject("picIntel.Image"), System.Drawing.Image)
        Me.picIntel.Location = New System.Drawing.Point(649, 75)
        Me.picIntel.Name = "picIntel"
        Me.picIntel.Size = New System.Drawing.Size(150, 150)
        Me.picIntel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIntel.TabIndex = 12
        Me.picIntel.TabStop = False
        '
        'tProcessadorNucleos
        '
        Me.tProcessadorNucleos.Enabled = False
        Me.tProcessadorNucleos.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorNucleos.Location = New System.Drawing.Point(1127, 75)
        Me.tProcessadorNucleos.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorNucleos.Name = "tProcessadorNucleos"
        Me.tProcessadorNucleos.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorNucleos.TabIndex = 16
        '
        'picAMD
        '
        Me.picAMD.Image = CType(resources.GetObject("picAMD.Image"), System.Drawing.Image)
        Me.picAMD.Location = New System.Drawing.Point(649, 75)
        Me.picAMD.Name = "picAMD"
        Me.picAMD.Size = New System.Drawing.Size(150, 150)
        Me.picAMD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAMD.TabIndex = 13
        Me.picAMD.TabStop = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(934, 78)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(71, 21)
        Me.Label47.TabIndex = 15
        Me.Label47.Text = "Núcleos"
        '
        'picOutros
        '
        Me.picOutros.Image = CType(resources.GetObject("picOutros.Image"), System.Drawing.Image)
        Me.picOutros.Location = New System.Drawing.Point(649, 75)
        Me.picOutros.Name = "picOutros"
        Me.picOutros.Size = New System.Drawing.Size(150, 150)
        Me.picOutros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOutros.TabIndex = 14
        Me.picOutros.TabStop = False
        '
        'grpCache
        '
        Me.grpCache.BackColor = System.Drawing.Color.Transparent
        Me.grpCache.Controls.Add(Me.tProcessadorCacheStatus)
        Me.grpCache.Controls.Add(Me.Label57)
        Me.grpCache.Controls.Add(Me.tProcessadorL3Vel)
        Me.grpCache.Controls.Add(Me.Label54)
        Me.grpCache.Controls.Add(Me.tProcessadorL2Vel)
        Me.grpCache.Controls.Add(Me.Label55)
        Me.grpCache.Controls.Add(Me.tProcessadorL1Vel)
        Me.grpCache.Controls.Add(Me.Label56)
        Me.grpCache.Controls.Add(Me.tProcessadorL3Tam)
        Me.grpCache.Controls.Add(Me.Label51)
        Me.grpCache.Controls.Add(Me.tProcessadorL2Tam)
        Me.grpCache.Controls.Add(Me.Label52)
        Me.grpCache.Controls.Add(Me.tProcessadorL1Tam)
        Me.grpCache.Controls.Add(Me.Label53)
        Me.grpCache.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCache.Location = New System.Drawing.Point(9, 425)
        Me.grpCache.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCache.Name = "grpCache"
        Me.grpCache.Padding = New System.Windows.Forms.Padding(4)
        Me.grpCache.Size = New System.Drawing.Size(1514, 165)
        Me.grpCache.TabIndex = 23
        Me.grpCache.TabStop = False
        Me.grpCache.Text = "Cache"
        '
        'tProcessadorCacheStatus
        '
        Me.tProcessadorCacheStatus.Enabled = False
        Me.tProcessadorCacheStatus.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorCacheStatus.Location = New System.Drawing.Point(1127, 78)
        Me.tProcessadorCacheStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorCacheStatus.Name = "tProcessadorCacheStatus"
        Me.tProcessadorCacheStatus.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorCacheStatus.TabIndex = 15
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(1019, 81)
        Me.Label57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(108, 21)
        Me.Label57.TabIndex = 14
        Me.Label57.Text = "Cache Status"
        '
        'tProcessadorL3Vel
        '
        Me.tProcessadorL3Vel.Enabled = False
        Me.tProcessadorL3Vel.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorL3Vel.Location = New System.Drawing.Point(622, 118)
        Me.tProcessadorL3Vel.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorL3Vel.Name = "tProcessadorL3Vel"
        Me.tProcessadorL3Vel.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorL3Vel.TabIndex = 13
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(512, 121)
        Me.Label54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(112, 21)
        Me.Label54.TabIndex = 12
        Me.Label54.Text = "L3 Velocidade"
        '
        'tProcessadorL2Vel
        '
        Me.tProcessadorL2Vel.Enabled = False
        Me.tProcessadorL2Vel.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorL2Vel.Location = New System.Drawing.Point(622, 78)
        Me.tProcessadorL2Vel.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorL2Vel.Name = "tProcessadorL2Vel"
        Me.tProcessadorL2Vel.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorL2Vel.TabIndex = 11
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(512, 81)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(112, 21)
        Me.Label55.TabIndex = 10
        Me.Label55.Text = "L2 Velocidade"
        '
        'tProcessadorL1Vel
        '
        Me.tProcessadorL1Vel.Enabled = False
        Me.tProcessadorL1Vel.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorL1Vel.Location = New System.Drawing.Point(622, 38)
        Me.tProcessadorL1Vel.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorL1Vel.Name = "tProcessadorL1Vel"
        Me.tProcessadorL1Vel.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorL1Vel.TabIndex = 9
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(512, 41)
        Me.Label56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(109, 21)
        Me.Label56.TabIndex = 8
        Me.Label56.Text = "L1 Velocidade"
        '
        'tProcessadorL3Tam
        '
        Me.tProcessadorL3Tam.Enabled = False
        Me.tProcessadorL3Tam.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorL3Tam.Location = New System.Drawing.Point(108, 118)
        Me.tProcessadorL3Tam.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorL3Tam.Name = "tProcessadorL3Tam"
        Me.tProcessadorL3Tam.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorL3Tam.TabIndex = 5
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(9, 121)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(99, 21)
        Me.Label51.TabIndex = 4
        Me.Label51.Text = "L3 Tamanho"
        '
        'tProcessadorL2Tam
        '
        Me.tProcessadorL2Tam.Enabled = False
        Me.tProcessadorL2Tam.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorL2Tam.Location = New System.Drawing.Point(108, 78)
        Me.tProcessadorL2Tam.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorL2Tam.Name = "tProcessadorL2Tam"
        Me.tProcessadorL2Tam.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorL2Tam.TabIndex = 3
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(9, 81)
        Me.Label52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(99, 21)
        Me.Label52.TabIndex = 2
        Me.Label52.Text = "L2 Tamanho"
        '
        'tProcessadorL1Tam
        '
        Me.tProcessadorL1Tam.Enabled = False
        Me.tProcessadorL1Tam.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProcessadorL1Tam.Location = New System.Drawing.Point(108, 38)
        Me.tProcessadorL1Tam.Margin = New System.Windows.Forms.Padding(4)
        Me.tProcessadorL1Tam.Name = "tProcessadorL1Tam"
        Me.tProcessadorL1Tam.Size = New System.Drawing.Size(375, 27)
        Me.tProcessadorL1Tam.TabIndex = 1
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(9, 41)
        Me.Label53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(96, 21)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "L1 Tamanho"
        '
        'GPU
        '
        Me.GPU.BackColor = System.Drawing.Color.Gainsboro
        Me.GPU.BackgroundImage = CType(resources.GetObject("GPU.BackgroundImage"), System.Drawing.Image)
        Me.GPU.Controls.Add(Me.tGPUStatus2)
        Me.GPU.Controls.Add(Me.Label77)
        Me.GPU.Controls.Add(Me.tGPUStatus1)
        Me.GPU.Controls.Add(Me.Label76)
        Me.GPU.Controls.Add(Me.Label75)
        Me.GPU.Controls.Add(Me.tGPUNome2)
        Me.GPU.Controls.Add(Me.tGPUTaxaMax2)
        Me.GPU.Controls.Add(Me.tGPUDriver2)
        Me.GPU.Controls.Add(Me.Label59)
        Me.GPU.Controls.Add(Me.Label66)
        Me.GPU.Controls.Add(Me.Label67)
        Me.GPU.Controls.Add(Me.Label68)
        Me.GPU.Controls.Add(Me.Label69)
        Me.GPU.Controls.Add(Me.tGPUTaxaAtual2)
        Me.GPU.Controls.Add(Me.tGPUMemoria2)
        Me.GPU.Controls.Add(Me.tGPUTipo2)
        Me.GPU.Controls.Add(Me.tGPUDescricao2)
        Me.GPU.Controls.Add(Me.Label70)
        Me.GPU.Controls.Add(Me.Label71)
        Me.GPU.Controls.Add(Me.Label72)
        Me.GPU.Controls.Add(Me.tGPUGPU2)
        Me.GPU.Controls.Add(Me.Label74)
        Me.GPU.Controls.Add(Me.tGPUNome1)
        Me.GPU.Controls.Add(Me.tGPUTaxaMax1)
        Me.GPU.Controls.Add(Me.tGPUDriver1)
        Me.GPU.Controls.Add(Me.Label65)
        Me.GPU.Controls.Add(Me.Label50)
        Me.GPU.Controls.Add(Me.Label61)
        Me.GPU.Controls.Add(Me.Label64)
        Me.GPU.Controls.Add(Me.Label60)
        Me.GPU.Controls.Add(Me.tGPUTaxaAtual1)
        Me.GPU.Controls.Add(Me.tGPUMemoria1)
        Me.GPU.Controls.Add(Me.tGPUTipo1)
        Me.GPU.Controls.Add(Me.tGPUDescricao1)
        Me.GPU.Controls.Add(Me.Label58)
        Me.GPU.Controls.Add(Me.Label62)
        Me.GPU.Controls.Add(Me.Label63)
        Me.GPU.Controls.Add(Me.tGPUGPU1)
        Me.GPU.Controls.Add(Me.picGPU2Nvidia)
        Me.GPU.Controls.Add(Me.picGPU2EVGA)
        Me.GPU.Controls.Add(Me.picGPU2Asus)
        Me.GPU.Controls.Add(Me.picGPU2Intel)
        Me.GPU.Controls.Add(Me.picGPU2AMD)
        Me.GPU.Controls.Add(Me.picGPU2Outros)
        Me.GPU.Controls.Add(Me.picGPU1Nvidia)
        Me.GPU.Controls.Add(Me.picGPU1EVGA)
        Me.GPU.Controls.Add(Me.picGPU1Asus)
        Me.GPU.Controls.Add(Me.picGPU1Intel)
        Me.GPU.Controls.Add(Me.picGPU1AMD)
        Me.GPU.Controls.Add(Me.picGPU1Outros)
        Me.GPU.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.GPU.Location = New System.Drawing.Point(4, 26)
        Me.GPU.Margin = New System.Windows.Forms.Padding(0)
        Me.GPU.Name = "GPU"
        Me.GPU.Size = New System.Drawing.Size(1532, 600)
        Me.GPU.TabIndex = 2
        Me.GPU.Text = "GPU"
        '
        'tGPUStatus2
        '
        Me.tGPUStatus2.Enabled = False
        Me.tGPUStatus2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUStatus2.Location = New System.Drawing.Point(1136, 476)
        Me.tGPUStatus2.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUStatus2.Name = "tGPUStatus2"
        Me.tGPUStatus2.Size = New System.Drawing.Size(375, 27)
        Me.tGPUStatus2.TabIndex = 74
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(943, 479)
        Me.Label77.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(59, 21)
        Me.Label77.TabIndex = 73
        Me.Label77.Text = "Status"
        '
        'tGPUStatus1
        '
        Me.tGPUStatus1.Enabled = False
        Me.tGPUStatus1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUStatus1.Location = New System.Drawing.Point(1136, 167)
        Me.tGPUStatus1.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUStatus1.Name = "tGPUStatus1"
        Me.tGPUStatus1.Size = New System.Drawing.Size(375, 27)
        Me.tGPUStatus1.TabIndex = 72
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(943, 170)
        Me.Label76.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(59, 21)
        Me.Label76.TabIndex = 71
        Me.Label76.Text = "Status"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(16, 314)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(206, 24)
        Me.Label75.TabIndex = 70
        Me.Label75.Text = "Processador Gráfico 2"
        '
        'tGPUNome2
        '
        Me.tGPUNome2.Enabled = False
        Me.tGPUNome2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUNome2.Location = New System.Drawing.Point(117, 356)
        Me.tGPUNome2.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUNome2.Name = "tGPUNome2"
        Me.tGPUNome2.Size = New System.Drawing.Size(375, 27)
        Me.tGPUNome2.TabIndex = 49
        '
        'tGPUTaxaMax2
        '
        Me.tGPUTaxaMax2.Enabled = False
        Me.tGPUTaxaMax2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUTaxaMax2.Location = New System.Drawing.Point(1136, 436)
        Me.tGPUTaxaMax2.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUTaxaMax2.Name = "tGPUTaxaMax2"
        Me.tGPUTaxaMax2.Size = New System.Drawing.Size(375, 27)
        Me.tGPUTaxaMax2.TabIndex = 66
        '
        'tGPUDriver2
        '
        Me.tGPUDriver2.Enabled = False
        Me.tGPUDriver2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUDriver2.Location = New System.Drawing.Point(117, 516)
        Me.tGPUDriver2.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUDriver2.Name = "tGPUDriver2"
        Me.tGPUDriver2.Size = New System.Drawing.Size(375, 27)
        Me.tGPUDriver2.TabIndex = 57
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(18, 359)
        Me.Label59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(52, 21)
        Me.Label59.TabIndex = 48
        Me.Label59.Text = "Placa"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(943, 439)
        Me.Label66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(193, 21)
        Me.Label66.TabIndex = 65
        Me.Label66.Text = "Taxa de Atualização Máx."
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(18, 519)
        Me.Label67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(98, 21)
        Me.Label67.TabIndex = 56
        Me.Label67.Text = "Vers. Driver"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(17, 399)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(40, 21)
        Me.Label68.TabIndex = 50
        Me.Label68.Text = "Tipo"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(18, 559)
        Me.Label69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(84, 21)
        Me.Label69.TabIndex = 61
        Me.Label69.Text = "Descrição"
        '
        'tGPUTaxaAtual2
        '
        Me.tGPUTaxaAtual2.Enabled = False
        Me.tGPUTaxaAtual2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUTaxaAtual2.Location = New System.Drawing.Point(1136, 396)
        Me.tGPUTaxaAtual2.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUTaxaAtual2.Name = "tGPUTaxaAtual2"
        Me.tGPUTaxaAtual2.Size = New System.Drawing.Size(375, 27)
        Me.tGPUTaxaAtual2.TabIndex = 64
        '
        'tGPUMemoria2
        '
        Me.tGPUMemoria2.Enabled = False
        Me.tGPUMemoria2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUMemoria2.Location = New System.Drawing.Point(117, 476)
        Me.tGPUMemoria2.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUMemoria2.Name = "tGPUMemoria2"
        Me.tGPUMemoria2.Size = New System.Drawing.Size(375, 27)
        Me.tGPUMemoria2.TabIndex = 55
        '
        'tGPUTipo2
        '
        Me.tGPUTipo2.Enabled = False
        Me.tGPUTipo2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUTipo2.Location = New System.Drawing.Point(117, 396)
        Me.tGPUTipo2.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUTipo2.Name = "tGPUTipo2"
        Me.tGPUTipo2.Size = New System.Drawing.Size(375, 27)
        Me.tGPUTipo2.TabIndex = 51
        '
        'tGPUDescricao2
        '
        Me.tGPUDescricao2.Enabled = False
        Me.tGPUDescricao2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUDescricao2.Location = New System.Drawing.Point(117, 556)
        Me.tGPUDescricao2.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUDescricao2.Name = "tGPUDescricao2"
        Me.tGPUDescricao2.Size = New System.Drawing.Size(375, 27)
        Me.tGPUDescricao2.TabIndex = 62
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(943, 399)
        Me.Label70.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(202, 21)
        Me.Label70.TabIndex = 63
        Me.Label70.Text = "Taxa de Atualização Atual."
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(18, 479)
        Me.Label71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(76, 21)
        Me.Label71.TabIndex = 54
        Me.Label71.Text = "Memória"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(18, 439)
        Me.Label72.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(43, 21)
        Me.Label72.TabIndex = 52
        Me.Label72.Text = "GPU"
        '
        'tGPUGPU2
        '
        Me.tGPUGPU2.Enabled = False
        Me.tGPUGPU2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUGPU2.Location = New System.Drawing.Point(117, 436)
        Me.tGPUGPU2.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUGPU2.Name = "tGPUGPU2"
        Me.tGPUGPU2.Size = New System.Drawing.Size(375, 27)
        Me.tGPUGPU2.TabIndex = 53
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(16, 9)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(203, 24)
        Me.Label74.TabIndex = 47
        Me.Label74.Text = "Processador Gráfico 1"
        '
        'tGPUNome1
        '
        Me.tGPUNome1.Enabled = False
        Me.tGPUNome1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUNome1.Location = New System.Drawing.Point(117, 47)
        Me.tGPUNome1.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUNome1.Name = "tGPUNome1"
        Me.tGPUNome1.Size = New System.Drawing.Size(375, 27)
        Me.tGPUNome1.TabIndex = 24
        '
        'tGPUTaxaMax1
        '
        Me.tGPUTaxaMax1.Enabled = False
        Me.tGPUTaxaMax1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUTaxaMax1.Location = New System.Drawing.Point(1136, 127)
        Me.tGPUTaxaMax1.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUTaxaMax1.Name = "tGPUTaxaMax1"
        Me.tGPUTaxaMax1.Size = New System.Drawing.Size(375, 27)
        Me.tGPUTaxaMax1.TabIndex = 43
        '
        'tGPUDriver1
        '
        Me.tGPUDriver1.Enabled = False
        Me.tGPUDriver1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUDriver1.Location = New System.Drawing.Point(117, 207)
        Me.tGPUDriver1.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUDriver1.Name = "tGPUDriver1"
        Me.tGPUDriver1.Size = New System.Drawing.Size(375, 27)
        Me.tGPUDriver1.TabIndex = 32
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(18, 50)
        Me.Label65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(52, 21)
        Me.Label65.TabIndex = 23
        Me.Label65.Text = "Placa"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(943, 130)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(193, 21)
        Me.Label50.TabIndex = 42
        Me.Label50.Text = "Taxa de Atualização Máx."
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(18, 210)
        Me.Label61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(98, 21)
        Me.Label61.TabIndex = 31
        Me.Label61.Text = "Vers. Driver"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(17, 90)
        Me.Label64.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(40, 21)
        Me.Label64.TabIndex = 25
        Me.Label64.Text = "Tipo"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(18, 250)
        Me.Label60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(84, 21)
        Me.Label60.TabIndex = 36
        Me.Label60.Text = "Descrição"
        '
        'tGPUTaxaAtual1
        '
        Me.tGPUTaxaAtual1.Enabled = False
        Me.tGPUTaxaAtual1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUTaxaAtual1.Location = New System.Drawing.Point(1136, 87)
        Me.tGPUTaxaAtual1.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUTaxaAtual1.Name = "tGPUTaxaAtual1"
        Me.tGPUTaxaAtual1.Size = New System.Drawing.Size(375, 27)
        Me.tGPUTaxaAtual1.TabIndex = 41
        '
        'tGPUMemoria1
        '
        Me.tGPUMemoria1.Enabled = False
        Me.tGPUMemoria1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUMemoria1.Location = New System.Drawing.Point(117, 167)
        Me.tGPUMemoria1.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUMemoria1.Name = "tGPUMemoria1"
        Me.tGPUMemoria1.Size = New System.Drawing.Size(375, 27)
        Me.tGPUMemoria1.TabIndex = 30
        '
        'tGPUTipo1
        '
        Me.tGPUTipo1.Enabled = False
        Me.tGPUTipo1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUTipo1.Location = New System.Drawing.Point(117, 87)
        Me.tGPUTipo1.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUTipo1.Name = "tGPUTipo1"
        Me.tGPUTipo1.Size = New System.Drawing.Size(375, 27)
        Me.tGPUTipo1.TabIndex = 26
        '
        'tGPUDescricao1
        '
        Me.tGPUDescricao1.Enabled = False
        Me.tGPUDescricao1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUDescricao1.Location = New System.Drawing.Point(117, 247)
        Me.tGPUDescricao1.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUDescricao1.Name = "tGPUDescricao1"
        Me.tGPUDescricao1.Size = New System.Drawing.Size(375, 27)
        Me.tGPUDescricao1.TabIndex = 37
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(943, 90)
        Me.Label58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(198, 21)
        Me.Label58.TabIndex = 40
        Me.Label58.Text = "Taxa de Atualização Atual"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(18, 170)
        Me.Label62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(76, 21)
        Me.Label62.TabIndex = 29
        Me.Label62.Text = "Memória"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(18, 130)
        Me.Label63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(43, 21)
        Me.Label63.TabIndex = 27
        Me.Label63.Text = "GPU"
        '
        'tGPUGPU1
        '
        Me.tGPUGPU1.Enabled = False
        Me.tGPUGPU1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGPUGPU1.Location = New System.Drawing.Point(117, 127)
        Me.tGPUGPU1.Margin = New System.Windows.Forms.Padding(4)
        Me.tGPUGPU1.Name = "tGPUGPU1"
        Me.tGPUGPU1.Size = New System.Drawing.Size(375, 27)
        Me.tGPUGPU1.TabIndex = 28
        '
        'picGPU2Nvidia
        '
        Me.picGPU2Nvidia.BackColor = System.Drawing.Color.Transparent
        Me.picGPU2Nvidia.Enabled = False
        Me.picGPU2Nvidia.Image = CType(resources.GetObject("picGPU2Nvidia.Image"), System.Drawing.Image)
        Me.picGPU2Nvidia.Location = New System.Drawing.Point(658, 393)
        Me.picGPU2Nvidia.Name = "picGPU2Nvidia"
        Me.picGPU2Nvidia.Size = New System.Drawing.Size(150, 150)
        Me.picGPU2Nvidia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU2Nvidia.TabIndex = 69
        Me.picGPU2Nvidia.TabStop = False
        '
        'picGPU2EVGA
        '
        Me.picGPU2EVGA.BackColor = System.Drawing.Color.Transparent
        Me.picGPU2EVGA.Enabled = False
        Me.picGPU2EVGA.Image = CType(resources.GetObject("picGPU2EVGA.Image"), System.Drawing.Image)
        Me.picGPU2EVGA.Location = New System.Drawing.Point(658, 393)
        Me.picGPU2EVGA.Name = "picGPU2EVGA"
        Me.picGPU2EVGA.Size = New System.Drawing.Size(150, 150)
        Me.picGPU2EVGA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU2EVGA.TabIndex = 68
        Me.picGPU2EVGA.TabStop = False
        '
        'picGPU2Asus
        '
        Me.picGPU2Asus.BackColor = System.Drawing.Color.Transparent
        Me.picGPU2Asus.Enabled = False
        Me.picGPU2Asus.Image = CType(resources.GetObject("picGPU2Asus.Image"), System.Drawing.Image)
        Me.picGPU2Asus.Location = New System.Drawing.Point(658, 393)
        Me.picGPU2Asus.Name = "picGPU2Asus"
        Me.picGPU2Asus.Size = New System.Drawing.Size(150, 150)
        Me.picGPU2Asus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU2Asus.TabIndex = 67
        Me.picGPU2Asus.TabStop = False
        '
        'picGPU2Intel
        '
        Me.picGPU2Intel.BackColor = System.Drawing.Color.Transparent
        Me.picGPU2Intel.Enabled = False
        Me.picGPU2Intel.Image = CType(resources.GetObject("picGPU2Intel.Image"), System.Drawing.Image)
        Me.picGPU2Intel.Location = New System.Drawing.Point(658, 393)
        Me.picGPU2Intel.Name = "picGPU2Intel"
        Me.picGPU2Intel.Size = New System.Drawing.Size(150, 150)
        Me.picGPU2Intel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU2Intel.TabIndex = 58
        Me.picGPU2Intel.TabStop = False
        '
        'picGPU2AMD
        '
        Me.picGPU2AMD.BackColor = System.Drawing.Color.Transparent
        Me.picGPU2AMD.Enabled = False
        Me.picGPU2AMD.Image = CType(resources.GetObject("picGPU2AMD.Image"), System.Drawing.Image)
        Me.picGPU2AMD.Location = New System.Drawing.Point(658, 393)
        Me.picGPU2AMD.Name = "picGPU2AMD"
        Me.picGPU2AMD.Size = New System.Drawing.Size(150, 150)
        Me.picGPU2AMD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU2AMD.TabIndex = 59
        Me.picGPU2AMD.TabStop = False
        '
        'picGPU2Outros
        '
        Me.picGPU2Outros.BackColor = System.Drawing.Color.Transparent
        Me.picGPU2Outros.Enabled = False
        Me.picGPU2Outros.Image = CType(resources.GetObject("picGPU2Outros.Image"), System.Drawing.Image)
        Me.picGPU2Outros.Location = New System.Drawing.Point(658, 393)
        Me.picGPU2Outros.Name = "picGPU2Outros"
        Me.picGPU2Outros.Size = New System.Drawing.Size(150, 150)
        Me.picGPU2Outros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU2Outros.TabIndex = 60
        Me.picGPU2Outros.TabStop = False
        '
        'picGPU1Nvidia
        '
        Me.picGPU1Nvidia.BackColor = System.Drawing.Color.Transparent
        Me.picGPU1Nvidia.Enabled = False
        Me.picGPU1Nvidia.Image = CType(resources.GetObject("picGPU1Nvidia.Image"), System.Drawing.Image)
        Me.picGPU1Nvidia.Location = New System.Drawing.Point(658, 84)
        Me.picGPU1Nvidia.Name = "picGPU1Nvidia"
        Me.picGPU1Nvidia.Size = New System.Drawing.Size(150, 150)
        Me.picGPU1Nvidia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU1Nvidia.TabIndex = 46
        Me.picGPU1Nvidia.TabStop = False
        '
        'picGPU1EVGA
        '
        Me.picGPU1EVGA.BackColor = System.Drawing.Color.Transparent
        Me.picGPU1EVGA.Enabled = False
        Me.picGPU1EVGA.Image = CType(resources.GetObject("picGPU1EVGA.Image"), System.Drawing.Image)
        Me.picGPU1EVGA.Location = New System.Drawing.Point(658, 84)
        Me.picGPU1EVGA.Name = "picGPU1EVGA"
        Me.picGPU1EVGA.Size = New System.Drawing.Size(150, 150)
        Me.picGPU1EVGA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU1EVGA.TabIndex = 45
        Me.picGPU1EVGA.TabStop = False
        '
        'picGPU1Asus
        '
        Me.picGPU1Asus.BackColor = System.Drawing.Color.Transparent
        Me.picGPU1Asus.Enabled = False
        Me.picGPU1Asus.Image = CType(resources.GetObject("picGPU1Asus.Image"), System.Drawing.Image)
        Me.picGPU1Asus.Location = New System.Drawing.Point(658, 84)
        Me.picGPU1Asus.Name = "picGPU1Asus"
        Me.picGPU1Asus.Size = New System.Drawing.Size(150, 150)
        Me.picGPU1Asus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU1Asus.TabIndex = 44
        Me.picGPU1Asus.TabStop = False
        '
        'picGPU1Intel
        '
        Me.picGPU1Intel.BackColor = System.Drawing.Color.Transparent
        Me.picGPU1Intel.Enabled = False
        Me.picGPU1Intel.Image = CType(resources.GetObject("picGPU1Intel.Image"), System.Drawing.Image)
        Me.picGPU1Intel.Location = New System.Drawing.Point(658, 84)
        Me.picGPU1Intel.Name = "picGPU1Intel"
        Me.picGPU1Intel.Size = New System.Drawing.Size(150, 150)
        Me.picGPU1Intel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU1Intel.TabIndex = 33
        Me.picGPU1Intel.TabStop = False
        '
        'picGPU1AMD
        '
        Me.picGPU1AMD.BackColor = System.Drawing.Color.Transparent
        Me.picGPU1AMD.Enabled = False
        Me.picGPU1AMD.Image = CType(resources.GetObject("picGPU1AMD.Image"), System.Drawing.Image)
        Me.picGPU1AMD.Location = New System.Drawing.Point(658, 84)
        Me.picGPU1AMD.Name = "picGPU1AMD"
        Me.picGPU1AMD.Size = New System.Drawing.Size(150, 150)
        Me.picGPU1AMD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU1AMD.TabIndex = 34
        Me.picGPU1AMD.TabStop = False
        '
        'picGPU1Outros
        '
        Me.picGPU1Outros.BackColor = System.Drawing.Color.Transparent
        Me.picGPU1Outros.Enabled = False
        Me.picGPU1Outros.Image = CType(resources.GetObject("picGPU1Outros.Image"), System.Drawing.Image)
        Me.picGPU1Outros.Location = New System.Drawing.Point(658, 84)
        Me.picGPU1Outros.Name = "picGPU1Outros"
        Me.picGPU1Outros.Size = New System.Drawing.Size(150, 150)
        Me.picGPU1Outros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPU1Outros.TabIndex = 35
        Me.picGPU1Outros.TabStop = False
        '
        'Memoria
        '
        Me.Memoria.BackColor = System.Drawing.Color.Gainsboro
        Me.Memoria.BackgroundImage = CType(resources.GetObject("Memoria.BackgroundImage"), System.Drawing.Image)
        Me.Memoria.Controls.Add(Me.tRAMVoltagem4)
        Me.Memoria.Controls.Add(Me.tRAMFrequencia4)
        Me.Memoria.Controls.Add(Me.Label121)
        Me.Memoria.Controls.Add(Me.tRAMStatus4)
        Me.Memoria.Controls.Add(Me.lbRAMID4)
        Me.Memoria.Controls.Add(Me.tRAMTipo4)
        Me.Memoria.Controls.Add(Me.Label123)
        Me.Memoria.Controls.Add(Me.lbRAMFabricante4)
        Me.Memoria.Controls.Add(Me.tRAMFabricante4)
        Me.Memoria.Controls.Add(Me.lbRAMModelo4)
        Me.Memoria.Controls.Add(Me.tRAMModelo4)
        Me.Memoria.Controls.Add(Me.Label126)
        Me.Memoria.Controls.Add(Me.Label127)
        Me.Memoria.Controls.Add(Me.tRAMTamanho4)
        Me.Memoria.Controls.Add(Me.Label128)
        Me.Memoria.Controls.Add(Me.tRAMID4)
        Me.Memoria.Controls.Add(Me.Label129)
        Me.Memoria.Controls.Add(Me.tRAMVoltagem3)
        Me.Memoria.Controls.Add(Me.tRAMFrequencia3)
        Me.Memoria.Controls.Add(Me.Label112)
        Me.Memoria.Controls.Add(Me.tRAMStatus3)
        Me.Memoria.Controls.Add(Me.lbRAMID3)
        Me.Memoria.Controls.Add(Me.tRAMTipo3)
        Me.Memoria.Controls.Add(Me.Label114)
        Me.Memoria.Controls.Add(Me.lbRAMFabricante3)
        Me.Memoria.Controls.Add(Me.tRAMFabricante3)
        Me.Memoria.Controls.Add(Me.lbRAMModelo3)
        Me.Memoria.Controls.Add(Me.tRAMModelo3)
        Me.Memoria.Controls.Add(Me.Label117)
        Me.Memoria.Controls.Add(Me.Label118)
        Me.Memoria.Controls.Add(Me.tRAMTamanho3)
        Me.Memoria.Controls.Add(Me.Label119)
        Me.Memoria.Controls.Add(Me.tRAMID3)
        Me.Memoria.Controls.Add(Me.Label120)
        Me.Memoria.Controls.Add(Me.tRAMVoltagem2)
        Me.Memoria.Controls.Add(Me.tRAMFrequencia2)
        Me.Memoria.Controls.Add(Me.Label99)
        Me.Memoria.Controls.Add(Me.tRAMStatus2)
        Me.Memoria.Controls.Add(Me.lbRAMID2)
        Me.Memoria.Controls.Add(Me.tRAMTipo2)
        Me.Memoria.Controls.Add(Me.Label102)
        Me.Memoria.Controls.Add(Me.lbRAMFabricante2)
        Me.Memoria.Controls.Add(Me.tRAMFabricante2)
        Me.Memoria.Controls.Add(Me.lbRAMModelo2)
        Me.Memoria.Controls.Add(Me.tRAMModelo2)
        Me.Memoria.Controls.Add(Me.Label108)
        Me.Memoria.Controls.Add(Me.Label109)
        Me.Memoria.Controls.Add(Me.tRAMTamanho2)
        Me.Memoria.Controls.Add(Me.Label110)
        Me.Memoria.Controls.Add(Me.tRAMID2)
        Me.Memoria.Controls.Add(Me.Label111)
        Me.Memoria.Controls.Add(Me.tRAMVoltagem1)
        Me.Memoria.Controls.Add(Me.tRAMFrequencia1)
        Me.Memoria.Controls.Add(Me.Label97)
        Me.Memoria.Controls.Add(Me.tRAMStatus1)
        Me.Memoria.Controls.Add(Me.lbRAMID1)
        Me.Memoria.Controls.Add(Me.tRAMTipo1)
        Me.Memoria.Controls.Add(Me.Label81)
        Me.Memoria.Controls.Add(Me.lbRAMFabricante1)
        Me.Memoria.Controls.Add(Me.tRAMFabricante1)
        Me.Memoria.Controls.Add(Me.lbRAMModelo1)
        Me.Memoria.Controls.Add(Me.tRAMModelo1)
        Me.Memoria.Controls.Add(Me.Label93)
        Me.Memoria.Controls.Add(Me.Label94)
        Me.Memoria.Controls.Add(Me.tRAMTamanho1)
        Me.Memoria.Controls.Add(Me.Label95)
        Me.Memoria.Controls.Add(Me.tRAMID1)
        Me.Memoria.Controls.Add(Me.Label96)
        Me.Memoria.Controls.Add(Me.tMemoriaUtilizada)
        Me.Memoria.Controls.Add(Me.Label86)
        Me.Memoria.Controls.Add(Me.tMemoriaUso)
        Me.Memoria.Controls.Add(Me.pbMemoria)
        Me.Memoria.Controls.Add(Me.tMemoriaTotal)
        Me.Memoria.Controls.Add(Me.Label80)
        Me.Memoria.Controls.Add(Me.Label82)
        Me.Memoria.Controls.Add(Me.Label78)
        Me.Memoria.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Memoria.Location = New System.Drawing.Point(4, 26)
        Me.Memoria.Margin = New System.Windows.Forms.Padding(0)
        Me.Memoria.Name = "Memoria"
        Me.Memoria.Size = New System.Drawing.Size(1532, 600)
        Me.Memoria.TabIndex = 3
        Me.Memoria.Text = "Memória"
        '
        'tRAMVoltagem4
        '
        Me.tRAMVoltagem4.Enabled = False
        Me.tRAMVoltagem4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMVoltagem4.Location = New System.Drawing.Point(1290, 398)
        Me.tRAMVoltagem4.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMVoltagem4.Name = "tRAMVoltagem4"
        Me.tRAMVoltagem4.Size = New System.Drawing.Size(205, 27)
        Me.tRAMVoltagem4.TabIndex = 155
        '
        'tRAMFrequencia4
        '
        Me.tRAMFrequencia4.Enabled = False
        Me.tRAMFrequencia4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMFrequencia4.Location = New System.Drawing.Point(1290, 363)
        Me.tRAMFrequencia4.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMFrequencia4.Name = "tRAMFrequencia4"
        Me.tRAMFrequencia4.Size = New System.Drawing.Size(205, 27)
        Me.tRAMFrequencia4.TabIndex = 149
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.BackColor = System.Drawing.Color.Transparent
        Me.Label121.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.Location = New System.Drawing.Point(1176, 470)
        Me.Label121.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(59, 21)
        Me.Label121.TabIndex = 160
        Me.Label121.Text = "Status"
        '
        'tRAMStatus4
        '
        Me.tRAMStatus4.Enabled = False
        Me.tRAMStatus4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMStatus4.Location = New System.Drawing.Point(1290, 467)
        Me.tRAMStatus4.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMStatus4.Name = "tRAMStatus4"
        Me.tRAMStatus4.Size = New System.Drawing.Size(205, 27)
        Me.tRAMStatus4.TabIndex = 159
        '
        'lbRAMID4
        '
        Me.lbRAMID4.AutoSize = True
        Me.lbRAMID4.BackColor = System.Drawing.Color.Transparent
        Me.lbRAMID4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRAMID4.Location = New System.Drawing.Point(1176, 296)
        Me.lbRAMID4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRAMID4.Name = "lbRAMID4"
        Me.lbRAMID4.Size = New System.Drawing.Size(104, 21)
        Me.lbRAMID4.TabIndex = 158
        Me.lbRAMID4.Text = "Identificação"
        '
        'tRAMTipo4
        '
        Me.tRAMTipo4.Enabled = False
        Me.tRAMTipo4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMTipo4.Location = New System.Drawing.Point(1290, 432)
        Me.tRAMTipo4.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMTipo4.Name = "tRAMTipo4"
        Me.tRAMTipo4.Size = New System.Drawing.Size(205, 27)
        Me.tRAMTipo4.TabIndex = 157
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.BackColor = System.Drawing.Color.Transparent
        Me.Label123.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.Location = New System.Drawing.Point(1176, 436)
        Me.Label123.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(40, 21)
        Me.Label123.TabIndex = 156
        Me.Label123.Text = "Tipo"
        '
        'lbRAMFabricante4
        '
        Me.lbRAMFabricante4.AutoSize = True
        Me.lbRAMFabricante4.BackColor = System.Drawing.Color.Transparent
        Me.lbRAMFabricante4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRAMFabricante4.Location = New System.Drawing.Point(1176, 226)
        Me.lbRAMFabricante4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRAMFabricante4.Name = "lbRAMFabricante4"
        Me.lbRAMFabricante4.Size = New System.Drawing.Size(90, 21)
        Me.lbRAMFabricante4.TabIndex = 154
        Me.lbRAMFabricante4.Text = "Fabricante"
        '
        'tRAMFabricante4
        '
        Me.tRAMFabricante4.Enabled = False
        Me.tRAMFabricante4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMFabricante4.Location = New System.Drawing.Point(1290, 223)
        Me.tRAMFabricante4.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMFabricante4.Name = "tRAMFabricante4"
        Me.tRAMFabricante4.Size = New System.Drawing.Size(205, 27)
        Me.tRAMFabricante4.TabIndex = 153
        '
        'lbRAMModelo4
        '
        Me.lbRAMModelo4.AutoSize = True
        Me.lbRAMModelo4.BackColor = System.Drawing.Color.Transparent
        Me.lbRAMModelo4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRAMModelo4.Location = New System.Drawing.Point(1176, 261)
        Me.lbRAMModelo4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRAMModelo4.Name = "lbRAMModelo4"
        Me.lbRAMModelo4.Size = New System.Drawing.Size(64, 21)
        Me.lbRAMModelo4.TabIndex = 152
        Me.lbRAMModelo4.Text = "Modelo"
        '
        'tRAMModelo4
        '
        Me.tRAMModelo4.Enabled = False
        Me.tRAMModelo4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMModelo4.Location = New System.Drawing.Point(1290, 258)
        Me.tRAMModelo4.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMModelo4.Name = "tRAMModelo4"
        Me.tRAMModelo4.Size = New System.Drawing.Size(205, 27)
        Me.tRAMModelo4.TabIndex = 151
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.BackColor = System.Drawing.Color.Transparent
        Me.Label126.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.Location = New System.Drawing.Point(1176, 401)
        Me.Label126.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(81, 21)
        Me.Label126.TabIndex = 150
        Me.Label126.Text = "Voltagem"
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.BackColor = System.Drawing.Color.Transparent
        Me.Label127.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.Location = New System.Drawing.Point(1176, 366)
        Me.Label127.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(93, 21)
        Me.Label127.TabIndex = 148
        Me.Label127.Text = "Frequência"
        '
        'tRAMTamanho4
        '
        Me.tRAMTamanho4.Enabled = False
        Me.tRAMTamanho4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMTamanho4.Location = New System.Drawing.Point(1290, 328)
        Me.tRAMTamanho4.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMTamanho4.Name = "tRAMTamanho4"
        Me.tRAMTamanho4.Size = New System.Drawing.Size(205, 27)
        Me.tRAMTamanho4.TabIndex = 147
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.BackColor = System.Drawing.Color.Transparent
        Me.Label128.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.Location = New System.Drawing.Point(1176, 331)
        Me.Label128.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(77, 21)
        Me.Label128.TabIndex = 146
        Me.Label128.Text = "Tamanho"
        '
        'tRAMID4
        '
        Me.tRAMID4.Enabled = False
        Me.tRAMID4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMID4.Location = New System.Drawing.Point(1290, 293)
        Me.tRAMID4.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMID4.Name = "tRAMID4"
        Me.tRAMID4.Size = New System.Drawing.Size(205, 27)
        Me.tRAMID4.TabIndex = 145
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.BackColor = System.Drawing.Color.Transparent
        Me.Label129.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label129.Location = New System.Drawing.Point(1173, 185)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(60, 24)
        Me.Label129.TabIndex = 144
        Me.Label129.Text = "Slot 4"
        '
        'tRAMVoltagem3
        '
        Me.tRAMVoltagem3.Enabled = False
        Me.tRAMVoltagem3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMVoltagem3.Location = New System.Drawing.Point(908, 398)
        Me.tRAMVoltagem3.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMVoltagem3.Name = "tRAMVoltagem3"
        Me.tRAMVoltagem3.Size = New System.Drawing.Size(205, 27)
        Me.tRAMVoltagem3.TabIndex = 138
        '
        'tRAMFrequencia3
        '
        Me.tRAMFrequencia3.Enabled = False
        Me.tRAMFrequencia3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMFrequencia3.Location = New System.Drawing.Point(908, 363)
        Me.tRAMFrequencia3.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMFrequencia3.Name = "tRAMFrequencia3"
        Me.tRAMFrequencia3.Size = New System.Drawing.Size(205, 27)
        Me.tRAMFrequencia3.TabIndex = 132
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.BackColor = System.Drawing.Color.Transparent
        Me.Label112.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.Location = New System.Drawing.Point(794, 470)
        Me.Label112.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(59, 21)
        Me.Label112.TabIndex = 143
        Me.Label112.Text = "Status"
        '
        'tRAMStatus3
        '
        Me.tRAMStatus3.Enabled = False
        Me.tRAMStatus3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMStatus3.Location = New System.Drawing.Point(908, 467)
        Me.tRAMStatus3.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMStatus3.Name = "tRAMStatus3"
        Me.tRAMStatus3.Size = New System.Drawing.Size(205, 27)
        Me.tRAMStatus3.TabIndex = 142
        '
        'lbRAMID3
        '
        Me.lbRAMID3.AutoSize = True
        Me.lbRAMID3.BackColor = System.Drawing.Color.Transparent
        Me.lbRAMID3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRAMID3.Location = New System.Drawing.Point(794, 296)
        Me.lbRAMID3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRAMID3.Name = "lbRAMID3"
        Me.lbRAMID3.Size = New System.Drawing.Size(104, 21)
        Me.lbRAMID3.TabIndex = 141
        Me.lbRAMID3.Text = "Identificação"
        '
        'tRAMTipo3
        '
        Me.tRAMTipo3.Enabled = False
        Me.tRAMTipo3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMTipo3.Location = New System.Drawing.Point(908, 432)
        Me.tRAMTipo3.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMTipo3.Name = "tRAMTipo3"
        Me.tRAMTipo3.Size = New System.Drawing.Size(205, 27)
        Me.tRAMTipo3.TabIndex = 140
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.BackColor = System.Drawing.Color.Transparent
        Me.Label114.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.Location = New System.Drawing.Point(794, 436)
        Me.Label114.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(40, 21)
        Me.Label114.TabIndex = 139
        Me.Label114.Text = "Tipo"
        '
        'lbRAMFabricante3
        '
        Me.lbRAMFabricante3.AutoSize = True
        Me.lbRAMFabricante3.BackColor = System.Drawing.Color.Transparent
        Me.lbRAMFabricante3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRAMFabricante3.Location = New System.Drawing.Point(794, 226)
        Me.lbRAMFabricante3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRAMFabricante3.Name = "lbRAMFabricante3"
        Me.lbRAMFabricante3.Size = New System.Drawing.Size(90, 21)
        Me.lbRAMFabricante3.TabIndex = 137
        Me.lbRAMFabricante3.Text = "Fabricante"
        '
        'tRAMFabricante3
        '
        Me.tRAMFabricante3.Enabled = False
        Me.tRAMFabricante3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMFabricante3.Location = New System.Drawing.Point(908, 223)
        Me.tRAMFabricante3.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMFabricante3.Name = "tRAMFabricante3"
        Me.tRAMFabricante3.Size = New System.Drawing.Size(205, 27)
        Me.tRAMFabricante3.TabIndex = 136
        '
        'lbRAMModelo3
        '
        Me.lbRAMModelo3.AutoSize = True
        Me.lbRAMModelo3.BackColor = System.Drawing.Color.Transparent
        Me.lbRAMModelo3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRAMModelo3.Location = New System.Drawing.Point(794, 261)
        Me.lbRAMModelo3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRAMModelo3.Name = "lbRAMModelo3"
        Me.lbRAMModelo3.Size = New System.Drawing.Size(64, 21)
        Me.lbRAMModelo3.TabIndex = 135
        Me.lbRAMModelo3.Text = "Modelo"
        '
        'tRAMModelo3
        '
        Me.tRAMModelo3.Enabled = False
        Me.tRAMModelo3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMModelo3.Location = New System.Drawing.Point(908, 258)
        Me.tRAMModelo3.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMModelo3.Name = "tRAMModelo3"
        Me.tRAMModelo3.Size = New System.Drawing.Size(205, 27)
        Me.tRAMModelo3.TabIndex = 134
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.BackColor = System.Drawing.Color.Transparent
        Me.Label117.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(794, 401)
        Me.Label117.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(81, 21)
        Me.Label117.TabIndex = 133
        Me.Label117.Text = "Voltagem"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.BackColor = System.Drawing.Color.Transparent
        Me.Label118.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.Location = New System.Drawing.Point(794, 366)
        Me.Label118.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(93, 21)
        Me.Label118.TabIndex = 131
        Me.Label118.Text = "Frequência"
        '
        'tRAMTamanho3
        '
        Me.tRAMTamanho3.Enabled = False
        Me.tRAMTamanho3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMTamanho3.Location = New System.Drawing.Point(908, 328)
        Me.tRAMTamanho3.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMTamanho3.Name = "tRAMTamanho3"
        Me.tRAMTamanho3.Size = New System.Drawing.Size(205, 27)
        Me.tRAMTamanho3.TabIndex = 130
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.BackColor = System.Drawing.Color.Transparent
        Me.Label119.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(794, 331)
        Me.Label119.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(77, 21)
        Me.Label119.TabIndex = 129
        Me.Label119.Text = "Tamanho"
        '
        'tRAMID3
        '
        Me.tRAMID3.Enabled = False
        Me.tRAMID3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMID3.Location = New System.Drawing.Point(908, 293)
        Me.tRAMID3.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMID3.Name = "tRAMID3"
        Me.tRAMID3.Size = New System.Drawing.Size(205, 27)
        Me.tRAMID3.TabIndex = 128
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.BackColor = System.Drawing.Color.Transparent
        Me.Label120.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label120.Location = New System.Drawing.Point(791, 185)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(60, 24)
        Me.Label120.TabIndex = 127
        Me.Label120.Text = "Slot 3"
        '
        'tRAMVoltagem2
        '
        Me.tRAMVoltagem2.Enabled = False
        Me.tRAMVoltagem2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMVoltagem2.Location = New System.Drawing.Point(527, 398)
        Me.tRAMVoltagem2.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMVoltagem2.Name = "tRAMVoltagem2"
        Me.tRAMVoltagem2.Size = New System.Drawing.Size(205, 27)
        Me.tRAMVoltagem2.TabIndex = 121
        '
        'tRAMFrequencia2
        '
        Me.tRAMFrequencia2.Enabled = False
        Me.tRAMFrequencia2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMFrequencia2.Location = New System.Drawing.Point(527, 363)
        Me.tRAMFrequencia2.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMFrequencia2.Name = "tRAMFrequencia2"
        Me.tRAMFrequencia2.Size = New System.Drawing.Size(205, 27)
        Me.tRAMFrequencia2.TabIndex = 115
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.BackColor = System.Drawing.Color.Transparent
        Me.Label99.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(413, 470)
        Me.Label99.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(59, 21)
        Me.Label99.TabIndex = 126
        Me.Label99.Text = "Status"
        '
        'tRAMStatus2
        '
        Me.tRAMStatus2.Enabled = False
        Me.tRAMStatus2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMStatus2.Location = New System.Drawing.Point(527, 467)
        Me.tRAMStatus2.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMStatus2.Name = "tRAMStatus2"
        Me.tRAMStatus2.Size = New System.Drawing.Size(205, 27)
        Me.tRAMStatus2.TabIndex = 125
        '
        'lbRAMID2
        '
        Me.lbRAMID2.AutoSize = True
        Me.lbRAMID2.BackColor = System.Drawing.Color.Transparent
        Me.lbRAMID2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRAMID2.Location = New System.Drawing.Point(413, 296)
        Me.lbRAMID2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRAMID2.Name = "lbRAMID2"
        Me.lbRAMID2.Size = New System.Drawing.Size(104, 21)
        Me.lbRAMID2.TabIndex = 124
        Me.lbRAMID2.Text = "Identificação"
        '
        'tRAMTipo2
        '
        Me.tRAMTipo2.Enabled = False
        Me.tRAMTipo2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMTipo2.Location = New System.Drawing.Point(527, 432)
        Me.tRAMTipo2.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMTipo2.Name = "tRAMTipo2"
        Me.tRAMTipo2.Size = New System.Drawing.Size(205, 27)
        Me.tRAMTipo2.TabIndex = 123
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.BackColor = System.Drawing.Color.Transparent
        Me.Label102.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(413, 436)
        Me.Label102.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(40, 21)
        Me.Label102.TabIndex = 122
        Me.Label102.Text = "Tipo"
        '
        'lbRAMFabricante2
        '
        Me.lbRAMFabricante2.AutoSize = True
        Me.lbRAMFabricante2.BackColor = System.Drawing.Color.Transparent
        Me.lbRAMFabricante2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRAMFabricante2.Location = New System.Drawing.Point(413, 226)
        Me.lbRAMFabricante2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRAMFabricante2.Name = "lbRAMFabricante2"
        Me.lbRAMFabricante2.Size = New System.Drawing.Size(90, 21)
        Me.lbRAMFabricante2.TabIndex = 120
        Me.lbRAMFabricante2.Text = "Fabricante"
        '
        'tRAMFabricante2
        '
        Me.tRAMFabricante2.Enabled = False
        Me.tRAMFabricante2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMFabricante2.Location = New System.Drawing.Point(527, 223)
        Me.tRAMFabricante2.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMFabricante2.Name = "tRAMFabricante2"
        Me.tRAMFabricante2.Size = New System.Drawing.Size(205, 27)
        Me.tRAMFabricante2.TabIndex = 119
        '
        'lbRAMModelo2
        '
        Me.lbRAMModelo2.AutoSize = True
        Me.lbRAMModelo2.BackColor = System.Drawing.Color.Transparent
        Me.lbRAMModelo2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRAMModelo2.Location = New System.Drawing.Point(413, 261)
        Me.lbRAMModelo2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRAMModelo2.Name = "lbRAMModelo2"
        Me.lbRAMModelo2.Size = New System.Drawing.Size(64, 21)
        Me.lbRAMModelo2.TabIndex = 118
        Me.lbRAMModelo2.Text = "Modelo"
        '
        'tRAMModelo2
        '
        Me.tRAMModelo2.Enabled = False
        Me.tRAMModelo2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMModelo2.Location = New System.Drawing.Point(527, 258)
        Me.tRAMModelo2.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMModelo2.Name = "tRAMModelo2"
        Me.tRAMModelo2.Size = New System.Drawing.Size(205, 27)
        Me.tRAMModelo2.TabIndex = 117
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.BackColor = System.Drawing.Color.Transparent
        Me.Label108.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.Location = New System.Drawing.Point(413, 401)
        Me.Label108.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(81, 21)
        Me.Label108.TabIndex = 116
        Me.Label108.Text = "Voltagem"
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.BackColor = System.Drawing.Color.Transparent
        Me.Label109.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.Location = New System.Drawing.Point(413, 366)
        Me.Label109.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(93, 21)
        Me.Label109.TabIndex = 114
        Me.Label109.Text = "Frequência"
        '
        'tRAMTamanho2
        '
        Me.tRAMTamanho2.Enabled = False
        Me.tRAMTamanho2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMTamanho2.Location = New System.Drawing.Point(527, 328)
        Me.tRAMTamanho2.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMTamanho2.Name = "tRAMTamanho2"
        Me.tRAMTamanho2.Size = New System.Drawing.Size(205, 27)
        Me.tRAMTamanho2.TabIndex = 113
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.BackColor = System.Drawing.Color.Transparent
        Me.Label110.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.Location = New System.Drawing.Point(413, 331)
        Me.Label110.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(77, 21)
        Me.Label110.TabIndex = 112
        Me.Label110.Text = "Tamanho"
        '
        'tRAMID2
        '
        Me.tRAMID2.Enabled = False
        Me.tRAMID2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMID2.Location = New System.Drawing.Point(527, 293)
        Me.tRAMID2.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMID2.Name = "tRAMID2"
        Me.tRAMID2.Size = New System.Drawing.Size(205, 27)
        Me.tRAMID2.TabIndex = 111
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.BackColor = System.Drawing.Color.Transparent
        Me.Label111.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label111.Location = New System.Drawing.Point(410, 185)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(59, 24)
        Me.Label111.TabIndex = 110
        Me.Label111.Text = "Slot 2"
        '
        'tRAMVoltagem1
        '
        Me.tRAMVoltagem1.Enabled = False
        Me.tRAMVoltagem1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMVoltagem1.Location = New System.Drawing.Point(142, 398)
        Me.tRAMVoltagem1.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMVoltagem1.Name = "tRAMVoltagem1"
        Me.tRAMVoltagem1.Size = New System.Drawing.Size(205, 27)
        Me.tRAMVoltagem1.TabIndex = 100
        '
        'tRAMFrequencia1
        '
        Me.tRAMFrequencia1.Enabled = False
        Me.tRAMFrequencia1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMFrequencia1.Location = New System.Drawing.Point(142, 363)
        Me.tRAMFrequencia1.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMFrequencia1.Name = "tRAMFrequencia1"
        Me.tRAMFrequencia1.Size = New System.Drawing.Size(205, 27)
        Me.tRAMFrequencia1.TabIndex = 94
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.BackColor = System.Drawing.Color.Transparent
        Me.Label97.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(28, 470)
        Me.Label97.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(59, 21)
        Me.Label97.TabIndex = 109
        Me.Label97.Text = "Status"
        '
        'tRAMStatus1
        '
        Me.tRAMStatus1.Enabled = False
        Me.tRAMStatus1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMStatus1.Location = New System.Drawing.Point(142, 467)
        Me.tRAMStatus1.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMStatus1.Name = "tRAMStatus1"
        Me.tRAMStatus1.Size = New System.Drawing.Size(205, 27)
        Me.tRAMStatus1.TabIndex = 108
        '
        'lbRAMID1
        '
        Me.lbRAMID1.AutoSize = True
        Me.lbRAMID1.BackColor = System.Drawing.Color.Transparent
        Me.lbRAMID1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRAMID1.Location = New System.Drawing.Point(28, 296)
        Me.lbRAMID1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRAMID1.Name = "lbRAMID1"
        Me.lbRAMID1.Size = New System.Drawing.Size(104, 21)
        Me.lbRAMID1.TabIndex = 107
        Me.lbRAMID1.Text = "Identificação"
        '
        'tRAMTipo1
        '
        Me.tRAMTipo1.Enabled = False
        Me.tRAMTipo1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMTipo1.Location = New System.Drawing.Point(142, 432)
        Me.tRAMTipo1.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMTipo1.Name = "tRAMTipo1"
        Me.tRAMTipo1.Size = New System.Drawing.Size(205, 27)
        Me.tRAMTipo1.TabIndex = 102
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(28, 436)
        Me.Label81.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(40, 21)
        Me.Label81.TabIndex = 101
        Me.Label81.Text = "Tipo"
        '
        'lbRAMFabricante1
        '
        Me.lbRAMFabricante1.AutoSize = True
        Me.lbRAMFabricante1.BackColor = System.Drawing.Color.Transparent
        Me.lbRAMFabricante1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRAMFabricante1.Location = New System.Drawing.Point(28, 226)
        Me.lbRAMFabricante1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRAMFabricante1.Name = "lbRAMFabricante1"
        Me.lbRAMFabricante1.Size = New System.Drawing.Size(90, 21)
        Me.lbRAMFabricante1.TabIndex = 99
        Me.lbRAMFabricante1.Text = "Fabricante"
        '
        'tRAMFabricante1
        '
        Me.tRAMFabricante1.Enabled = False
        Me.tRAMFabricante1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMFabricante1.Location = New System.Drawing.Point(142, 223)
        Me.tRAMFabricante1.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMFabricante1.Name = "tRAMFabricante1"
        Me.tRAMFabricante1.Size = New System.Drawing.Size(205, 27)
        Me.tRAMFabricante1.TabIndex = 98
        '
        'lbRAMModelo1
        '
        Me.lbRAMModelo1.AutoSize = True
        Me.lbRAMModelo1.BackColor = System.Drawing.Color.Transparent
        Me.lbRAMModelo1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRAMModelo1.Location = New System.Drawing.Point(28, 261)
        Me.lbRAMModelo1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRAMModelo1.Name = "lbRAMModelo1"
        Me.lbRAMModelo1.Size = New System.Drawing.Size(64, 21)
        Me.lbRAMModelo1.TabIndex = 97
        Me.lbRAMModelo1.Text = "Modelo"
        '
        'tRAMModelo1
        '
        Me.tRAMModelo1.Enabled = False
        Me.tRAMModelo1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMModelo1.Location = New System.Drawing.Point(142, 258)
        Me.tRAMModelo1.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMModelo1.Name = "tRAMModelo1"
        Me.tRAMModelo1.Size = New System.Drawing.Size(205, 27)
        Me.tRAMModelo1.TabIndex = 96
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.BackColor = System.Drawing.Color.Transparent
        Me.Label93.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(28, 401)
        Me.Label93.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(81, 21)
        Me.Label93.TabIndex = 95
        Me.Label93.Text = "Voltagem"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.BackColor = System.Drawing.Color.Transparent
        Me.Label94.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(28, 366)
        Me.Label94.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(93, 21)
        Me.Label94.TabIndex = 93
        Me.Label94.Text = "Frequência"
        '
        'tRAMTamanho1
        '
        Me.tRAMTamanho1.Enabled = False
        Me.tRAMTamanho1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMTamanho1.Location = New System.Drawing.Point(142, 328)
        Me.tRAMTamanho1.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMTamanho1.Name = "tRAMTamanho1"
        Me.tRAMTamanho1.Size = New System.Drawing.Size(205, 27)
        Me.tRAMTamanho1.TabIndex = 92
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.BackColor = System.Drawing.Color.Transparent
        Me.Label95.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(28, 331)
        Me.Label95.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(77, 21)
        Me.Label95.TabIndex = 91
        Me.Label95.Text = "Tamanho"
        '
        'tRAMID1
        '
        Me.tRAMID1.Enabled = False
        Me.tRAMID1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRAMID1.Location = New System.Drawing.Point(142, 293)
        Me.tRAMID1.Margin = New System.Windows.Forms.Padding(4)
        Me.tRAMID1.Name = "tRAMID1"
        Me.tRAMID1.Size = New System.Drawing.Size(205, 27)
        Me.tRAMID1.TabIndex = 90
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.BackColor = System.Drawing.Color.Transparent
        Me.Label96.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label96.Location = New System.Drawing.Point(25, 185)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(56, 24)
        Me.Label96.TabIndex = 89
        Me.Label96.Text = "Slot 1"
        '
        'tMemoriaUtilizada
        '
        Me.tMemoriaUtilizada.Enabled = False
        Me.tMemoriaUtilizada.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMemoriaUtilizada.Location = New System.Drawing.Point(772, 84)
        Me.tMemoriaUtilizada.Margin = New System.Windows.Forms.Padding(4)
        Me.tMemoriaUtilizada.Name = "tMemoriaUtilizada"
        Me.tMemoriaUtilizada.Size = New System.Drawing.Size(113, 27)
        Me.tMemoriaUtilizada.TabIndex = 52
        Me.tMemoriaUtilizada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(888, 87)
        Me.Label86.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(39, 21)
        Me.Label86.TabIndex = 62
        Me.Label86.Text = "Uso"
        '
        'tMemoriaUso
        '
        Me.tMemoriaUso.Enabled = False
        Me.tMemoriaUso.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMemoriaUso.Location = New System.Drawing.Point(927, 84)
        Me.tMemoriaUso.Margin = New System.Windows.Forms.Padding(4)
        Me.tMemoriaUso.Name = "tMemoriaUso"
        Me.tMemoriaUso.Size = New System.Drawing.Size(56, 27)
        Me.tMemoriaUso.TabIndex = 63
        Me.tMemoriaUso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbMemoria
        '
        Me.pbMemoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbMemoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.pbMemoria.Location = New System.Drawing.Point(316, 28)
        Me.pbMemoria.Margin = New System.Windows.Forms.Padding(0)
        Me.pbMemoria.Name = "pbMemoria"
        Me.pbMemoria.Size = New System.Drawing.Size(900, 43)
        Me.pbMemoria.Step = 1
        Me.pbMemoria.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbMemoria.TabIndex = 61
        '
        'tMemoriaTotal
        '
        Me.tMemoriaTotal.Enabled = False
        Me.tMemoriaTotal.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMemoriaTotal.Location = New System.Drawing.Point(581, 84)
        Me.tMemoriaTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.tMemoriaTotal.Name = "tMemoriaTotal"
        Me.tMemoriaTotal.Size = New System.Drawing.Size(113, 27)
        Me.tMemoriaTotal.TabIndex = 50
        Me.tMemoriaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(495, 87)
        Me.Label80.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(88, 21)
        Me.Label80.TabIndex = 49
        Me.Label80.Text = "Disponível"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(698, 87)
        Me.Label82.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(75, 21)
        Me.Label82.TabIndex = 51
        Me.Label82.Text = "Utilizada"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(16, 9)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(93, 24)
        Me.Label78.TabIndex = 48
        Me.Label78.Text = "Memória "
        '
        'PlacaMae
        '
        Me.PlacaMae.BackColor = System.Drawing.Color.Gainsboro
        Me.PlacaMae.BackgroundImage = CType(resources.GetObject("PlacaMae.BackgroundImage"), System.Drawing.Image)
        Me.PlacaMae.Controls.Add(Me.tPlacaBarramento2)
        Me.PlacaMae.Controls.Add(Me.Label106)
        Me.PlacaMae.Controls.Add(Me.tPlacaStatus)
        Me.PlacaMae.Controls.Add(Me.Label107)
        Me.PlacaMae.Controls.Add(Me.tPlacaSlots)
        Me.PlacaMae.Controls.Add(Me.tPlacaBarramento1)
        Me.PlacaMae.Controls.Add(Me.Label39)
        Me.PlacaMae.Controls.Add(Me.tPlacaSerial)
        Me.PlacaMae.Controls.Add(Me.Label85)
        Me.PlacaMae.Controls.Add(Me.Label103)
        Me.PlacaMae.Controls.Add(Me.tPlacaIDSistema)
        Me.PlacaMae.Controls.Add(Me.Label101)
        Me.PlacaMae.Controls.Add(Me.tPlacaVersao)
        Me.PlacaMae.Controls.Add(Me.Label84)
        Me.PlacaMae.Controls.Add(Me.tPlacaModelo)
        Me.PlacaMae.Controls.Add(Me.Label83)
        Me.PlacaMae.Controls.Add(Me.tPlacaFabricante)
        Me.PlacaMae.Controls.Add(Me.Label79)
        Me.PlacaMae.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlacaMae.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.PlacaMae.Location = New System.Drawing.Point(4, 26)
        Me.PlacaMae.Margin = New System.Windows.Forms.Padding(0)
        Me.PlacaMae.Name = "PlacaMae"
        Me.PlacaMae.Size = New System.Drawing.Size(1532, 600)
        Me.PlacaMae.TabIndex = 4
        Me.PlacaMae.Text = "Placa Mãe"
        '
        'tPlacaBarramento2
        '
        Me.tPlacaBarramento2.Enabled = False
        Me.tPlacaBarramento2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPlacaBarramento2.Location = New System.Drawing.Point(1090, 207)
        Me.tPlacaBarramento2.Margin = New System.Windows.Forms.Padding(4)
        Me.tPlacaBarramento2.Name = "tPlacaBarramento2"
        Me.tPlacaBarramento2.Size = New System.Drawing.Size(186, 27)
        Me.tPlacaBarramento2.TabIndex = 74
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.BackColor = System.Drawing.Color.Transparent
        Me.Label106.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(796, 330)
        Me.Label106.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(59, 21)
        Me.Label106.TabIndex = 71
        Me.Label106.Text = "Status"
        '
        'tPlacaStatus
        '
        Me.tPlacaStatus.Enabled = False
        Me.tPlacaStatus.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPlacaStatus.Location = New System.Drawing.Point(901, 327)
        Me.tPlacaStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.tPlacaStatus.Name = "tPlacaStatus"
        Me.tPlacaStatus.Size = New System.Drawing.Size(375, 27)
        Me.tPlacaStatus.TabIndex = 72
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.BackColor = System.Drawing.Color.Transparent
        Me.Label107.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(796, 290)
        Me.Label107.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(49, 21)
        Me.Label107.TabIndex = 69
        Me.Label107.Text = "Slots"
        '
        'tPlacaSlots
        '
        Me.tPlacaSlots.Enabled = False
        Me.tPlacaSlots.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPlacaSlots.Location = New System.Drawing.Point(901, 287)
        Me.tPlacaSlots.Margin = New System.Windows.Forms.Padding(4)
        Me.tPlacaSlots.Name = "tPlacaSlots"
        Me.tPlacaSlots.Size = New System.Drawing.Size(375, 27)
        Me.tPlacaSlots.TabIndex = 70
        '
        'tPlacaBarramento1
        '
        Me.tPlacaBarramento1.Enabled = False
        Me.tPlacaBarramento1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPlacaBarramento1.Location = New System.Drawing.Point(901, 207)
        Me.tPlacaBarramento1.Margin = New System.Windows.Forms.Padding(4)
        Me.tPlacaBarramento1.Name = "tPlacaBarramento1"
        Me.tPlacaBarramento1.Size = New System.Drawing.Size(186, 27)
        Me.tPlacaBarramento1.TabIndex = 66
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(796, 250)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(54, 21)
        Me.Label39.TabIndex = 68
        Me.Label39.Text = "Serial"
        '
        'tPlacaSerial
        '
        Me.tPlacaSerial.Enabled = False
        Me.tPlacaSerial.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPlacaSerial.Location = New System.Drawing.Point(901, 247)
        Me.tPlacaSerial.Margin = New System.Windows.Forms.Padding(4)
        Me.tPlacaSerial.Name = "tPlacaSerial"
        Me.tPlacaSerial.Size = New System.Drawing.Size(375, 27)
        Me.tPlacaSerial.TabIndex = 67
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.BackColor = System.Drawing.Color.Transparent
        Me.Label85.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(796, 210)
        Me.Label85.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(110, 21)
        Me.Label85.TabIndex = 65
        Me.Label85.Text = "Barramentos"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.BackColor = System.Drawing.Color.Transparent
        Me.Label103.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(248, 330)
        Me.Label103.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(91, 21)
        Me.Label103.TabIndex = 61
        Me.Label103.Text = "ID Sistema"
        '
        'tPlacaIDSistema
        '
        Me.tPlacaIDSistema.Enabled = False
        Me.tPlacaIDSistema.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPlacaIDSistema.Location = New System.Drawing.Point(348, 327)
        Me.tPlacaIDSistema.Margin = New System.Windows.Forms.Padding(4)
        Me.tPlacaIDSistema.Name = "tPlacaIDSistema"
        Me.tPlacaIDSistema.Size = New System.Drawing.Size(375, 27)
        Me.tPlacaIDSistema.TabIndex = 62
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.BackColor = System.Drawing.Color.Transparent
        Me.Label101.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(248, 290)
        Me.Label101.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(62, 21)
        Me.Label101.TabIndex = 56
        Me.Label101.Text = "Versão"
        '
        'tPlacaVersao
        '
        Me.tPlacaVersao.Enabled = False
        Me.tPlacaVersao.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPlacaVersao.Location = New System.Drawing.Point(348, 287)
        Me.tPlacaVersao.Margin = New System.Windows.Forms.Padding(4)
        Me.tPlacaVersao.Name = "tPlacaVersao"
        Me.tPlacaVersao.Size = New System.Drawing.Size(375, 27)
        Me.tPlacaVersao.TabIndex = 57
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.BackColor = System.Drawing.Color.Transparent
        Me.Label84.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(248, 250)
        Me.Label84.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(64, 21)
        Me.Label84.TabIndex = 54
        Me.Label84.Text = "Modelo"
        '
        'tPlacaModelo
        '
        Me.tPlacaModelo.Enabled = False
        Me.tPlacaModelo.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPlacaModelo.Location = New System.Drawing.Point(348, 247)
        Me.tPlacaModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.tPlacaModelo.Name = "tPlacaModelo"
        Me.tPlacaModelo.Size = New System.Drawing.Size(375, 27)
        Me.tPlacaModelo.TabIndex = 55
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.Transparent
        Me.Label83.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(248, 210)
        Me.Label83.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(90, 21)
        Me.Label83.TabIndex = 52
        Me.Label83.Text = "Fabricante"
        '
        'tPlacaFabricante
        '
        Me.tPlacaFabricante.Enabled = False
        Me.tPlacaFabricante.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPlacaFabricante.Location = New System.Drawing.Point(348, 207)
        Me.tPlacaFabricante.Margin = New System.Windows.Forms.Padding(4)
        Me.tPlacaFabricante.Name = "tPlacaFabricante"
        Me.tPlacaFabricante.Size = New System.Drawing.Size(375, 27)
        Me.tPlacaFabricante.TabIndex = 53
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.Transparent
        Me.Label79.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(16, 9)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(101, 24)
        Me.Label79.TabIndex = 49
        Me.Label79.Text = "Placa Mãe"
        '
        'Unidades
        '
        Me.Unidades.BackColor = System.Drawing.Color.Gainsboro
        Me.Unidades.BackgroundImage = CType(resources.GetObject("Unidades.BackgroundImage"), System.Drawing.Image)
        Me.Unidades.Controls.Add(Me.Label34)
        Me.Unidades.Controls.Add(Me.lbStatus6)
        Me.Unidades.Controls.Add(Me.tUnidadeStatus6)
        Me.Unidades.Controls.Add(Me.lbFabricante6)
        Me.Unidades.Controls.Add(Me.tUnidadeFabricante6)
        Me.Unidades.Controls.Add(Me.lbEspacoTotal6)
        Me.Unidades.Controls.Add(Me.tUnidadeTotal6)
        Me.Unidades.Controls.Add(Me.lbID6)
        Me.Unidades.Controls.Add(Me.tUnidadeID6)
        Me.Unidades.Controls.Add(Me.lbModelo6)
        Me.Unidades.Controls.Add(Me.tUnidadeModelo6)
        Me.Unidades.Controls.Add(Me.lbTipo6)
        Me.Unidades.Controls.Add(Me.tUnidadeTipo6)
        Me.Unidades.Controls.Add(Me.lbStatus5)
        Me.Unidades.Controls.Add(Me.tUnidadeStatus5)
        Me.Unidades.Controls.Add(Me.lbFabricante5)
        Me.Unidades.Controls.Add(Me.tUnidadeFabricante5)
        Me.Unidades.Controls.Add(Me.lbEspacoTotal5)
        Me.Unidades.Controls.Add(Me.tUnidadeTotal5)
        Me.Unidades.Controls.Add(Me.lbID5)
        Me.Unidades.Controls.Add(Me.tUnidadeID5)
        Me.Unidades.Controls.Add(Me.lbModelo5)
        Me.Unidades.Controls.Add(Me.tUnidadeModelo5)
        Me.Unidades.Controls.Add(Me.lbTipo5)
        Me.Unidades.Controls.Add(Me.tUnidadeTipo5)
        Me.Unidades.Controls.Add(Me.lbStatus4)
        Me.Unidades.Controls.Add(Me.tUnidadeStatus4)
        Me.Unidades.Controls.Add(Me.lbFabricante4)
        Me.Unidades.Controls.Add(Me.tUnidadeFabricante4)
        Me.Unidades.Controls.Add(Me.lbEspacoTotal4)
        Me.Unidades.Controls.Add(Me.tUnidadeTotal4)
        Me.Unidades.Controls.Add(Me.lbID4)
        Me.Unidades.Controls.Add(Me.tUnidadeID4)
        Me.Unidades.Controls.Add(Me.lbModelo4)
        Me.Unidades.Controls.Add(Me.tUnidadeModelo4)
        Me.Unidades.Controls.Add(Me.lbTipo4)
        Me.Unidades.Controls.Add(Me.tUnidadeTipo4)
        Me.Unidades.Controls.Add(Me.lbUnidade5)
        Me.Unidades.Controls.Add(Me.lbUnidade6)
        Me.Unidades.Controls.Add(Me.lbUnidade4)
        Me.Unidades.Controls.Add(Me.lbStatus3)
        Me.Unidades.Controls.Add(Me.tUnidadeStatus3)
        Me.Unidades.Controls.Add(Me.lbFabricante3)
        Me.Unidades.Controls.Add(Me.tUnidadeFabricante3)
        Me.Unidades.Controls.Add(Me.lbEspacoTotal3)
        Me.Unidades.Controls.Add(Me.tUnidadeTotal3)
        Me.Unidades.Controls.Add(Me.lbID3)
        Me.Unidades.Controls.Add(Me.tUnidadeID3)
        Me.Unidades.Controls.Add(Me.lbModelo3)
        Me.Unidades.Controls.Add(Me.tUnidadeModelo3)
        Me.Unidades.Controls.Add(Me.lbTipo3)
        Me.Unidades.Controls.Add(Me.tUnidadeTipo3)
        Me.Unidades.Controls.Add(Me.lbStatus2)
        Me.Unidades.Controls.Add(Me.tUnidadeStatus2)
        Me.Unidades.Controls.Add(Me.lbFabricante2)
        Me.Unidades.Controls.Add(Me.tUnidadeFabricante2)
        Me.Unidades.Controls.Add(Me.lbEspacoTotal2)
        Me.Unidades.Controls.Add(Me.tUnidadeTotal2)
        Me.Unidades.Controls.Add(Me.lbID2)
        Me.Unidades.Controls.Add(Me.tUnidadeID2)
        Me.Unidades.Controls.Add(Me.lbModelo2)
        Me.Unidades.Controls.Add(Me.tUnidadeModelo2)
        Me.Unidades.Controls.Add(Me.lbTipo2)
        Me.Unidades.Controls.Add(Me.tUnidadeTipo2)
        Me.Unidades.Controls.Add(Me.lbStatus1)
        Me.Unidades.Controls.Add(Me.tUnidadeStatus1)
        Me.Unidades.Controls.Add(Me.lbFabricante1)
        Me.Unidades.Controls.Add(Me.tUnidadeFabricante1)
        Me.Unidades.Controls.Add(Me.lbEspacoTotal1)
        Me.Unidades.Controls.Add(Me.tUnidadeTotal1)
        Me.Unidades.Controls.Add(Me.lbID1)
        Me.Unidades.Controls.Add(Me.tUnidadeID1)
        Me.Unidades.Controls.Add(Me.lbModelo1)
        Me.Unidades.Controls.Add(Me.tUnidadeModelo1)
        Me.Unidades.Controls.Add(Me.lbTipo1)
        Me.Unidades.Controls.Add(Me.tUnidadeTipo1)
        Me.Unidades.Controls.Add(Me.lbUnidade2)
        Me.Unidades.Controls.Add(Me.lbUnidade3)
        Me.Unidades.Controls.Add(Me.lbUnidade1)
        Me.Unidades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Unidades.Location = New System.Drawing.Point(4, 26)
        Me.Unidades.Name = "Unidades"
        Me.Unidades.Size = New System.Drawing.Size(1532, 600)
        Me.Unidades.TabIndex = 5
        Me.Unidades.Text = "Unidades"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(16, 9)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(218, 24)
        Me.Label34.TabIndex = 158
        Me.Label34.Text = "Dispositivos e Unidades"
        '
        'lbStatus6
        '
        Me.lbStatus6.AutoSize = True
        Me.lbStatus6.BackColor = System.Drawing.Color.Transparent
        Me.lbStatus6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus6.Location = New System.Drawing.Point(1077, 550)
        Me.lbStatus6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStatus6.Name = "lbStatus6"
        Me.lbStatus6.Size = New System.Drawing.Size(59, 21)
        Me.lbStatus6.TabIndex = 157
        Me.lbStatus6.Text = "Status"
        '
        'tUnidadeStatus6
        '
        Me.tUnidadeStatus6.Enabled = False
        Me.tUnidadeStatus6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeStatus6.Location = New System.Drawing.Point(1183, 547)
        Me.tUnidadeStatus6.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeStatus6.Name = "tUnidadeStatus6"
        Me.tUnidadeStatus6.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeStatus6.TabIndex = 156
        '
        'lbFabricante6
        '
        Me.lbFabricante6.AutoSize = True
        Me.lbFabricante6.BackColor = System.Drawing.Color.Transparent
        Me.lbFabricante6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFabricante6.Location = New System.Drawing.Point(1077, 372)
        Me.lbFabricante6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFabricante6.Name = "lbFabricante6"
        Me.lbFabricante6.Size = New System.Drawing.Size(90, 21)
        Me.lbFabricante6.TabIndex = 155
        Me.lbFabricante6.Text = "Fabricante"
        '
        'tUnidadeFabricante6
        '
        Me.tUnidadeFabricante6.Enabled = False
        Me.tUnidadeFabricante6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeFabricante6.Location = New System.Drawing.Point(1183, 369)
        Me.tUnidadeFabricante6.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeFabricante6.Name = "tUnidadeFabricante6"
        Me.tUnidadeFabricante6.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeFabricante6.TabIndex = 154
        '
        'lbEspacoTotal6
        '
        Me.lbEspacoTotal6.AutoSize = True
        Me.lbEspacoTotal6.BackColor = System.Drawing.Color.Transparent
        Me.lbEspacoTotal6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEspacoTotal6.Location = New System.Drawing.Point(1077, 407)
        Me.lbEspacoTotal6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEspacoTotal6.Name = "lbEspacoTotal6"
        Me.lbEspacoTotal6.Size = New System.Drawing.Size(77, 21)
        Me.lbEspacoTotal6.TabIndex = 153
        Me.lbEspacoTotal6.Text = "Tamanho"
        '
        'tUnidadeTotal6
        '
        Me.tUnidadeTotal6.Enabled = False
        Me.tUnidadeTotal6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeTotal6.Location = New System.Drawing.Point(1183, 404)
        Me.tUnidadeTotal6.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeTotal6.Name = "tUnidadeTotal6"
        Me.tUnidadeTotal6.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeTotal6.TabIndex = 152
        '
        'lbID6
        '
        Me.lbID6.AutoSize = True
        Me.lbID6.BackColor = System.Drawing.Color.Transparent
        Me.lbID6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID6.Location = New System.Drawing.Point(1077, 512)
        Me.lbID6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbID6.Name = "lbID6"
        Me.lbID6.Size = New System.Drawing.Size(104, 21)
        Me.lbID6.TabIndex = 151
        Me.lbID6.Text = "Identificação"
        '
        'tUnidadeID6
        '
        Me.tUnidadeID6.Enabled = False
        Me.tUnidadeID6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeID6.Location = New System.Drawing.Point(1183, 509)
        Me.tUnidadeID6.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeID6.Name = "tUnidadeID6"
        Me.tUnidadeID6.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeID6.TabIndex = 150
        '
        'lbModelo6
        '
        Me.lbModelo6.AutoSize = True
        Me.lbModelo6.BackColor = System.Drawing.Color.Transparent
        Me.lbModelo6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbModelo6.Location = New System.Drawing.Point(1077, 477)
        Me.lbModelo6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbModelo6.Name = "lbModelo6"
        Me.lbModelo6.Size = New System.Drawing.Size(64, 21)
        Me.lbModelo6.TabIndex = 149
        Me.lbModelo6.Text = "Modelo"
        '
        'tUnidadeModelo6
        '
        Me.tUnidadeModelo6.Enabled = False
        Me.tUnidadeModelo6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeModelo6.Location = New System.Drawing.Point(1183, 474)
        Me.tUnidadeModelo6.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeModelo6.Name = "tUnidadeModelo6"
        Me.tUnidadeModelo6.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeModelo6.TabIndex = 148
        '
        'lbTipo6
        '
        Me.lbTipo6.AutoSize = True
        Me.lbTipo6.BackColor = System.Drawing.Color.Transparent
        Me.lbTipo6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipo6.Location = New System.Drawing.Point(1077, 442)
        Me.lbTipo6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTipo6.Name = "lbTipo6"
        Me.lbTipo6.Size = New System.Drawing.Size(40, 21)
        Me.lbTipo6.TabIndex = 147
        Me.lbTipo6.Text = "Tipo"
        '
        'tUnidadeTipo6
        '
        Me.tUnidadeTipo6.Enabled = False
        Me.tUnidadeTipo6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeTipo6.Location = New System.Drawing.Point(1183, 439)
        Me.tUnidadeTipo6.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeTipo6.Name = "tUnidadeTipo6"
        Me.tUnidadeTipo6.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeTipo6.TabIndex = 146
        '
        'lbStatus5
        '
        Me.lbStatus5.AutoSize = True
        Me.lbStatus5.BackColor = System.Drawing.Color.Transparent
        Me.lbStatus5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus5.Location = New System.Drawing.Point(570, 550)
        Me.lbStatus5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStatus5.Name = "lbStatus5"
        Me.lbStatus5.Size = New System.Drawing.Size(59, 21)
        Me.lbStatus5.TabIndex = 145
        Me.lbStatus5.Text = "Status"
        '
        'tUnidadeStatus5
        '
        Me.tUnidadeStatus5.Enabled = False
        Me.tUnidadeStatus5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeStatus5.Location = New System.Drawing.Point(676, 547)
        Me.tUnidadeStatus5.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeStatus5.Name = "tUnidadeStatus5"
        Me.tUnidadeStatus5.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeStatus5.TabIndex = 144
        '
        'lbFabricante5
        '
        Me.lbFabricante5.AutoSize = True
        Me.lbFabricante5.BackColor = System.Drawing.Color.Transparent
        Me.lbFabricante5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFabricante5.Location = New System.Drawing.Point(570, 372)
        Me.lbFabricante5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFabricante5.Name = "lbFabricante5"
        Me.lbFabricante5.Size = New System.Drawing.Size(90, 21)
        Me.lbFabricante5.TabIndex = 143
        Me.lbFabricante5.Text = "Fabricante"
        '
        'tUnidadeFabricante5
        '
        Me.tUnidadeFabricante5.Enabled = False
        Me.tUnidadeFabricante5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeFabricante5.Location = New System.Drawing.Point(676, 369)
        Me.tUnidadeFabricante5.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeFabricante5.Name = "tUnidadeFabricante5"
        Me.tUnidadeFabricante5.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeFabricante5.TabIndex = 142
        '
        'lbEspacoTotal5
        '
        Me.lbEspacoTotal5.AutoSize = True
        Me.lbEspacoTotal5.BackColor = System.Drawing.Color.Transparent
        Me.lbEspacoTotal5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEspacoTotal5.Location = New System.Drawing.Point(570, 407)
        Me.lbEspacoTotal5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEspacoTotal5.Name = "lbEspacoTotal5"
        Me.lbEspacoTotal5.Size = New System.Drawing.Size(77, 21)
        Me.lbEspacoTotal5.TabIndex = 141
        Me.lbEspacoTotal5.Text = "Tamanho"
        '
        'tUnidadeTotal5
        '
        Me.tUnidadeTotal5.Enabled = False
        Me.tUnidadeTotal5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeTotal5.Location = New System.Drawing.Point(676, 404)
        Me.tUnidadeTotal5.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeTotal5.Name = "tUnidadeTotal5"
        Me.tUnidadeTotal5.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeTotal5.TabIndex = 140
        '
        'lbID5
        '
        Me.lbID5.AutoSize = True
        Me.lbID5.BackColor = System.Drawing.Color.Transparent
        Me.lbID5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID5.Location = New System.Drawing.Point(570, 512)
        Me.lbID5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbID5.Name = "lbID5"
        Me.lbID5.Size = New System.Drawing.Size(104, 21)
        Me.lbID5.TabIndex = 139
        Me.lbID5.Text = "Identificação"
        '
        'tUnidadeID5
        '
        Me.tUnidadeID5.Enabled = False
        Me.tUnidadeID5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeID5.Location = New System.Drawing.Point(676, 509)
        Me.tUnidadeID5.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeID5.Name = "tUnidadeID5"
        Me.tUnidadeID5.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeID5.TabIndex = 138
        '
        'lbModelo5
        '
        Me.lbModelo5.AutoSize = True
        Me.lbModelo5.BackColor = System.Drawing.Color.Transparent
        Me.lbModelo5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbModelo5.Location = New System.Drawing.Point(570, 477)
        Me.lbModelo5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbModelo5.Name = "lbModelo5"
        Me.lbModelo5.Size = New System.Drawing.Size(64, 21)
        Me.lbModelo5.TabIndex = 137
        Me.lbModelo5.Text = "Modelo"
        '
        'tUnidadeModelo5
        '
        Me.tUnidadeModelo5.Enabled = False
        Me.tUnidadeModelo5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeModelo5.Location = New System.Drawing.Point(676, 474)
        Me.tUnidadeModelo5.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeModelo5.Name = "tUnidadeModelo5"
        Me.tUnidadeModelo5.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeModelo5.TabIndex = 136
        '
        'lbTipo5
        '
        Me.lbTipo5.AutoSize = True
        Me.lbTipo5.BackColor = System.Drawing.Color.Transparent
        Me.lbTipo5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipo5.Location = New System.Drawing.Point(570, 442)
        Me.lbTipo5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTipo5.Name = "lbTipo5"
        Me.lbTipo5.Size = New System.Drawing.Size(40, 21)
        Me.lbTipo5.TabIndex = 135
        Me.lbTipo5.Text = "Tipo"
        '
        'tUnidadeTipo5
        '
        Me.tUnidadeTipo5.Enabled = False
        Me.tUnidadeTipo5.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeTipo5.Location = New System.Drawing.Point(676, 439)
        Me.tUnidadeTipo5.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeTipo5.Name = "tUnidadeTipo5"
        Me.tUnidadeTipo5.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeTipo5.TabIndex = 134
        '
        'lbStatus4
        '
        Me.lbStatus4.AutoSize = True
        Me.lbStatus4.BackColor = System.Drawing.Color.Transparent
        Me.lbStatus4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus4.Location = New System.Drawing.Point(62, 547)
        Me.lbStatus4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStatus4.Name = "lbStatus4"
        Me.lbStatus4.Size = New System.Drawing.Size(59, 21)
        Me.lbStatus4.TabIndex = 133
        Me.lbStatus4.Text = "Status"
        '
        'tUnidadeStatus4
        '
        Me.tUnidadeStatus4.Enabled = False
        Me.tUnidadeStatus4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeStatus4.Location = New System.Drawing.Point(168, 544)
        Me.tUnidadeStatus4.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeStatus4.Name = "tUnidadeStatus4"
        Me.tUnidadeStatus4.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeStatus4.TabIndex = 132
        '
        'lbFabricante4
        '
        Me.lbFabricante4.AutoSize = True
        Me.lbFabricante4.BackColor = System.Drawing.Color.Transparent
        Me.lbFabricante4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFabricante4.Location = New System.Drawing.Point(62, 372)
        Me.lbFabricante4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFabricante4.Name = "lbFabricante4"
        Me.lbFabricante4.Size = New System.Drawing.Size(90, 21)
        Me.lbFabricante4.TabIndex = 131
        Me.lbFabricante4.Text = "Fabricante"
        '
        'tUnidadeFabricante4
        '
        Me.tUnidadeFabricante4.Enabled = False
        Me.tUnidadeFabricante4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeFabricante4.Location = New System.Drawing.Point(168, 369)
        Me.tUnidadeFabricante4.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeFabricante4.Name = "tUnidadeFabricante4"
        Me.tUnidadeFabricante4.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeFabricante4.TabIndex = 130
        '
        'lbEspacoTotal4
        '
        Me.lbEspacoTotal4.AutoSize = True
        Me.lbEspacoTotal4.BackColor = System.Drawing.Color.Transparent
        Me.lbEspacoTotal4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEspacoTotal4.Location = New System.Drawing.Point(62, 407)
        Me.lbEspacoTotal4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEspacoTotal4.Name = "lbEspacoTotal4"
        Me.lbEspacoTotal4.Size = New System.Drawing.Size(77, 21)
        Me.lbEspacoTotal4.TabIndex = 129
        Me.lbEspacoTotal4.Text = "Tamanho"
        '
        'tUnidadeTotal4
        '
        Me.tUnidadeTotal4.Enabled = False
        Me.tUnidadeTotal4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeTotal4.Location = New System.Drawing.Point(168, 404)
        Me.tUnidadeTotal4.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeTotal4.Name = "tUnidadeTotal4"
        Me.tUnidadeTotal4.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeTotal4.TabIndex = 128
        '
        'lbID4
        '
        Me.lbID4.AutoSize = True
        Me.lbID4.BackColor = System.Drawing.Color.Transparent
        Me.lbID4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID4.Location = New System.Drawing.Point(62, 512)
        Me.lbID4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbID4.Name = "lbID4"
        Me.lbID4.Size = New System.Drawing.Size(104, 21)
        Me.lbID4.TabIndex = 127
        Me.lbID4.Text = "Identificação"
        '
        'tUnidadeID4
        '
        Me.tUnidadeID4.Enabled = False
        Me.tUnidadeID4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeID4.Location = New System.Drawing.Point(168, 509)
        Me.tUnidadeID4.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeID4.Name = "tUnidadeID4"
        Me.tUnidadeID4.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeID4.TabIndex = 126
        '
        'lbModelo4
        '
        Me.lbModelo4.AutoSize = True
        Me.lbModelo4.BackColor = System.Drawing.Color.Transparent
        Me.lbModelo4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbModelo4.Location = New System.Drawing.Point(62, 477)
        Me.lbModelo4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbModelo4.Name = "lbModelo4"
        Me.lbModelo4.Size = New System.Drawing.Size(64, 21)
        Me.lbModelo4.TabIndex = 125
        Me.lbModelo4.Text = "Modelo"
        '
        'tUnidadeModelo4
        '
        Me.tUnidadeModelo4.Enabled = False
        Me.tUnidadeModelo4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeModelo4.Location = New System.Drawing.Point(168, 474)
        Me.tUnidadeModelo4.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeModelo4.Name = "tUnidadeModelo4"
        Me.tUnidadeModelo4.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeModelo4.TabIndex = 124
        '
        'lbTipo4
        '
        Me.lbTipo4.AutoSize = True
        Me.lbTipo4.BackColor = System.Drawing.Color.Transparent
        Me.lbTipo4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipo4.Location = New System.Drawing.Point(62, 442)
        Me.lbTipo4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTipo4.Name = "lbTipo4"
        Me.lbTipo4.Size = New System.Drawing.Size(40, 21)
        Me.lbTipo4.TabIndex = 123
        Me.lbTipo4.Text = "Tipo"
        '
        'tUnidadeTipo4
        '
        Me.tUnidadeTipo4.Enabled = False
        Me.tUnidadeTipo4.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeTipo4.Location = New System.Drawing.Point(168, 439)
        Me.tUnidadeTipo4.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeTipo4.Name = "tUnidadeTipo4"
        Me.tUnidadeTipo4.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeTipo4.TabIndex = 122
        '
        'lbUnidade5
        '
        Me.lbUnidade5.AutoSize = True
        Me.lbUnidade5.BackColor = System.Drawing.Color.Transparent
        Me.lbUnidade5.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.lbUnidade5.Location = New System.Drawing.Point(567, 331)
        Me.lbUnidade5.Name = "lbUnidade5"
        Me.lbUnidade5.Size = New System.Drawing.Size(83, 24)
        Me.lbUnidade5.TabIndex = 119
        Me.lbUnidade5.Text = "Unidade"
        '
        'lbUnidade6
        '
        Me.lbUnidade6.AutoSize = True
        Me.lbUnidade6.BackColor = System.Drawing.Color.Transparent
        Me.lbUnidade6.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.lbUnidade6.Location = New System.Drawing.Point(1074, 331)
        Me.lbUnidade6.Name = "lbUnidade6"
        Me.lbUnidade6.Size = New System.Drawing.Size(83, 24)
        Me.lbUnidade6.TabIndex = 116
        Me.lbUnidade6.Text = "Unidade"
        '
        'lbUnidade4
        '
        Me.lbUnidade4.AutoSize = True
        Me.lbUnidade4.BackColor = System.Drawing.Color.Transparent
        Me.lbUnidade4.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.lbUnidade4.Location = New System.Drawing.Point(59, 331)
        Me.lbUnidade4.Name = "lbUnidade4"
        Me.lbUnidade4.Size = New System.Drawing.Size(83, 24)
        Me.lbUnidade4.TabIndex = 113
        Me.lbUnidade4.Text = "Unidade"
        '
        'lbStatus3
        '
        Me.lbStatus3.AutoSize = True
        Me.lbStatus3.BackColor = System.Drawing.Color.Transparent
        Me.lbStatus3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus3.Location = New System.Drawing.Point(1077, 269)
        Me.lbStatus3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStatus3.Name = "lbStatus3"
        Me.lbStatus3.Size = New System.Drawing.Size(59, 21)
        Me.lbStatus3.TabIndex = 112
        Me.lbStatus3.Text = "Status"
        '
        'tUnidadeStatus3
        '
        Me.tUnidadeStatus3.Enabled = False
        Me.tUnidadeStatus3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeStatus3.Location = New System.Drawing.Point(1183, 266)
        Me.tUnidadeStatus3.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeStatus3.Name = "tUnidadeStatus3"
        Me.tUnidadeStatus3.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeStatus3.TabIndex = 111
        '
        'lbFabricante3
        '
        Me.lbFabricante3.AutoSize = True
        Me.lbFabricante3.BackColor = System.Drawing.Color.Transparent
        Me.lbFabricante3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFabricante3.Location = New System.Drawing.Point(1077, 94)
        Me.lbFabricante3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFabricante3.Name = "lbFabricante3"
        Me.lbFabricante3.Size = New System.Drawing.Size(90, 21)
        Me.lbFabricante3.TabIndex = 110
        Me.lbFabricante3.Text = "Fabricante"
        '
        'tUnidadeFabricante3
        '
        Me.tUnidadeFabricante3.Enabled = False
        Me.tUnidadeFabricante3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeFabricante3.Location = New System.Drawing.Point(1183, 91)
        Me.tUnidadeFabricante3.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeFabricante3.Name = "tUnidadeFabricante3"
        Me.tUnidadeFabricante3.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeFabricante3.TabIndex = 109
        '
        'lbEspacoTotal3
        '
        Me.lbEspacoTotal3.AutoSize = True
        Me.lbEspacoTotal3.BackColor = System.Drawing.Color.Transparent
        Me.lbEspacoTotal3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEspacoTotal3.Location = New System.Drawing.Point(1077, 129)
        Me.lbEspacoTotal3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEspacoTotal3.Name = "lbEspacoTotal3"
        Me.lbEspacoTotal3.Size = New System.Drawing.Size(77, 21)
        Me.lbEspacoTotal3.TabIndex = 108
        Me.lbEspacoTotal3.Text = "Tamanho"
        '
        'tUnidadeTotal3
        '
        Me.tUnidadeTotal3.Enabled = False
        Me.tUnidadeTotal3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeTotal3.Location = New System.Drawing.Point(1183, 126)
        Me.tUnidadeTotal3.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeTotal3.Name = "tUnidadeTotal3"
        Me.tUnidadeTotal3.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeTotal3.TabIndex = 107
        '
        'lbID3
        '
        Me.lbID3.AutoSize = True
        Me.lbID3.BackColor = System.Drawing.Color.Transparent
        Me.lbID3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID3.Location = New System.Drawing.Point(1077, 234)
        Me.lbID3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbID3.Name = "lbID3"
        Me.lbID3.Size = New System.Drawing.Size(104, 21)
        Me.lbID3.TabIndex = 106
        Me.lbID3.Text = "Identificação"
        '
        'tUnidadeID3
        '
        Me.tUnidadeID3.Enabled = False
        Me.tUnidadeID3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeID3.Location = New System.Drawing.Point(1183, 231)
        Me.tUnidadeID3.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeID3.Name = "tUnidadeID3"
        Me.tUnidadeID3.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeID3.TabIndex = 105
        '
        'lbModelo3
        '
        Me.lbModelo3.AutoSize = True
        Me.lbModelo3.BackColor = System.Drawing.Color.Transparent
        Me.lbModelo3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbModelo3.Location = New System.Drawing.Point(1077, 199)
        Me.lbModelo3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbModelo3.Name = "lbModelo3"
        Me.lbModelo3.Size = New System.Drawing.Size(64, 21)
        Me.lbModelo3.TabIndex = 104
        Me.lbModelo3.Text = "Modelo"
        '
        'tUnidadeModelo3
        '
        Me.tUnidadeModelo3.Enabled = False
        Me.tUnidadeModelo3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeModelo3.Location = New System.Drawing.Point(1183, 196)
        Me.tUnidadeModelo3.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeModelo3.Name = "tUnidadeModelo3"
        Me.tUnidadeModelo3.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeModelo3.TabIndex = 103
        '
        'lbTipo3
        '
        Me.lbTipo3.AutoSize = True
        Me.lbTipo3.BackColor = System.Drawing.Color.Transparent
        Me.lbTipo3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipo3.Location = New System.Drawing.Point(1077, 164)
        Me.lbTipo3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTipo3.Name = "lbTipo3"
        Me.lbTipo3.Size = New System.Drawing.Size(40, 21)
        Me.lbTipo3.TabIndex = 102
        Me.lbTipo3.Text = "Tipo"
        '
        'tUnidadeTipo3
        '
        Me.tUnidadeTipo3.Enabled = False
        Me.tUnidadeTipo3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeTipo3.Location = New System.Drawing.Point(1183, 161)
        Me.tUnidadeTipo3.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeTipo3.Name = "tUnidadeTipo3"
        Me.tUnidadeTipo3.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeTipo3.TabIndex = 101
        '
        'lbStatus2
        '
        Me.lbStatus2.AutoSize = True
        Me.lbStatus2.BackColor = System.Drawing.Color.Transparent
        Me.lbStatus2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus2.Location = New System.Drawing.Point(570, 269)
        Me.lbStatus2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStatus2.Name = "lbStatus2"
        Me.lbStatus2.Size = New System.Drawing.Size(59, 21)
        Me.lbStatus2.TabIndex = 100
        Me.lbStatus2.Text = "Status"
        '
        'tUnidadeStatus2
        '
        Me.tUnidadeStatus2.Enabled = False
        Me.tUnidadeStatus2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeStatus2.Location = New System.Drawing.Point(676, 266)
        Me.tUnidadeStatus2.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeStatus2.Name = "tUnidadeStatus2"
        Me.tUnidadeStatus2.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeStatus2.TabIndex = 99
        '
        'lbFabricante2
        '
        Me.lbFabricante2.AutoSize = True
        Me.lbFabricante2.BackColor = System.Drawing.Color.Transparent
        Me.lbFabricante2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFabricante2.Location = New System.Drawing.Point(570, 94)
        Me.lbFabricante2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFabricante2.Name = "lbFabricante2"
        Me.lbFabricante2.Size = New System.Drawing.Size(90, 21)
        Me.lbFabricante2.TabIndex = 98
        Me.lbFabricante2.Text = "Fabricante"
        '
        'tUnidadeFabricante2
        '
        Me.tUnidadeFabricante2.Enabled = False
        Me.tUnidadeFabricante2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeFabricante2.Location = New System.Drawing.Point(676, 91)
        Me.tUnidadeFabricante2.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeFabricante2.Name = "tUnidadeFabricante2"
        Me.tUnidadeFabricante2.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeFabricante2.TabIndex = 97
        '
        'lbEspacoTotal2
        '
        Me.lbEspacoTotal2.AutoSize = True
        Me.lbEspacoTotal2.BackColor = System.Drawing.Color.Transparent
        Me.lbEspacoTotal2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEspacoTotal2.Location = New System.Drawing.Point(570, 129)
        Me.lbEspacoTotal2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEspacoTotal2.Name = "lbEspacoTotal2"
        Me.lbEspacoTotal2.Size = New System.Drawing.Size(77, 21)
        Me.lbEspacoTotal2.TabIndex = 96
        Me.lbEspacoTotal2.Text = "Tamanho"
        '
        'tUnidadeTotal2
        '
        Me.tUnidadeTotal2.Enabled = False
        Me.tUnidadeTotal2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeTotal2.Location = New System.Drawing.Point(676, 126)
        Me.tUnidadeTotal2.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeTotal2.Name = "tUnidadeTotal2"
        Me.tUnidadeTotal2.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeTotal2.TabIndex = 95
        '
        'lbID2
        '
        Me.lbID2.AutoSize = True
        Me.lbID2.BackColor = System.Drawing.Color.Transparent
        Me.lbID2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID2.Location = New System.Drawing.Point(570, 234)
        Me.lbID2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbID2.Name = "lbID2"
        Me.lbID2.Size = New System.Drawing.Size(104, 21)
        Me.lbID2.TabIndex = 94
        Me.lbID2.Text = "Identificação"
        '
        'tUnidadeID2
        '
        Me.tUnidadeID2.Enabled = False
        Me.tUnidadeID2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeID2.Location = New System.Drawing.Point(676, 231)
        Me.tUnidadeID2.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeID2.Name = "tUnidadeID2"
        Me.tUnidadeID2.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeID2.TabIndex = 93
        '
        'lbModelo2
        '
        Me.lbModelo2.AutoSize = True
        Me.lbModelo2.BackColor = System.Drawing.Color.Transparent
        Me.lbModelo2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbModelo2.Location = New System.Drawing.Point(570, 199)
        Me.lbModelo2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbModelo2.Name = "lbModelo2"
        Me.lbModelo2.Size = New System.Drawing.Size(64, 21)
        Me.lbModelo2.TabIndex = 92
        Me.lbModelo2.Text = "Modelo"
        '
        'tUnidadeModelo2
        '
        Me.tUnidadeModelo2.Enabled = False
        Me.tUnidadeModelo2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeModelo2.Location = New System.Drawing.Point(676, 196)
        Me.tUnidadeModelo2.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeModelo2.Name = "tUnidadeModelo2"
        Me.tUnidadeModelo2.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeModelo2.TabIndex = 91
        '
        'lbTipo2
        '
        Me.lbTipo2.AutoSize = True
        Me.lbTipo2.BackColor = System.Drawing.Color.Transparent
        Me.lbTipo2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipo2.Location = New System.Drawing.Point(570, 164)
        Me.lbTipo2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTipo2.Name = "lbTipo2"
        Me.lbTipo2.Size = New System.Drawing.Size(40, 21)
        Me.lbTipo2.TabIndex = 90
        Me.lbTipo2.Text = "Tipo"
        '
        'tUnidadeTipo2
        '
        Me.tUnidadeTipo2.Enabled = False
        Me.tUnidadeTipo2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeTipo2.Location = New System.Drawing.Point(676, 161)
        Me.tUnidadeTipo2.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeTipo2.Name = "tUnidadeTipo2"
        Me.tUnidadeTipo2.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeTipo2.TabIndex = 89
        '
        'lbStatus1
        '
        Me.lbStatus1.AutoSize = True
        Me.lbStatus1.BackColor = System.Drawing.Color.Transparent
        Me.lbStatus1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus1.Location = New System.Drawing.Point(62, 269)
        Me.lbStatus1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStatus1.Name = "lbStatus1"
        Me.lbStatus1.Size = New System.Drawing.Size(59, 21)
        Me.lbStatus1.TabIndex = 88
        Me.lbStatus1.Text = "Status"
        '
        'tUnidadeStatus1
        '
        Me.tUnidadeStatus1.Enabled = False
        Me.tUnidadeStatus1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeStatus1.Location = New System.Drawing.Point(168, 266)
        Me.tUnidadeStatus1.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeStatus1.Name = "tUnidadeStatus1"
        Me.tUnidadeStatus1.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeStatus1.TabIndex = 87
        '
        'lbFabricante1
        '
        Me.lbFabricante1.AutoSize = True
        Me.lbFabricante1.BackColor = System.Drawing.Color.Transparent
        Me.lbFabricante1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFabricante1.Location = New System.Drawing.Point(62, 94)
        Me.lbFabricante1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFabricante1.Name = "lbFabricante1"
        Me.lbFabricante1.Size = New System.Drawing.Size(90, 21)
        Me.lbFabricante1.TabIndex = 86
        Me.lbFabricante1.Text = "Fabricante"
        '
        'tUnidadeFabricante1
        '
        Me.tUnidadeFabricante1.Enabled = False
        Me.tUnidadeFabricante1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeFabricante1.Location = New System.Drawing.Point(168, 91)
        Me.tUnidadeFabricante1.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeFabricante1.Name = "tUnidadeFabricante1"
        Me.tUnidadeFabricante1.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeFabricante1.TabIndex = 85
        '
        'lbEspacoTotal1
        '
        Me.lbEspacoTotal1.AutoSize = True
        Me.lbEspacoTotal1.BackColor = System.Drawing.Color.Transparent
        Me.lbEspacoTotal1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEspacoTotal1.Location = New System.Drawing.Point(62, 129)
        Me.lbEspacoTotal1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEspacoTotal1.Name = "lbEspacoTotal1"
        Me.lbEspacoTotal1.Size = New System.Drawing.Size(77, 21)
        Me.lbEspacoTotal1.TabIndex = 68
        Me.lbEspacoTotal1.Text = "Tamanho"
        '
        'tUnidadeTotal1
        '
        Me.tUnidadeTotal1.Enabled = False
        Me.tUnidadeTotal1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeTotal1.Location = New System.Drawing.Point(168, 126)
        Me.tUnidadeTotal1.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeTotal1.Name = "tUnidadeTotal1"
        Me.tUnidadeTotal1.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeTotal1.TabIndex = 67
        '
        'lbID1
        '
        Me.lbID1.AutoSize = True
        Me.lbID1.BackColor = System.Drawing.Color.Transparent
        Me.lbID1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID1.Location = New System.Drawing.Point(62, 234)
        Me.lbID1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbID1.Name = "lbID1"
        Me.lbID1.Size = New System.Drawing.Size(104, 21)
        Me.lbID1.TabIndex = 66
        Me.lbID1.Text = "Identificação"
        '
        'tUnidadeID1
        '
        Me.tUnidadeID1.Enabled = False
        Me.tUnidadeID1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeID1.Location = New System.Drawing.Point(168, 231)
        Me.tUnidadeID1.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeID1.Name = "tUnidadeID1"
        Me.tUnidadeID1.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeID1.TabIndex = 65
        '
        'lbModelo1
        '
        Me.lbModelo1.AutoSize = True
        Me.lbModelo1.BackColor = System.Drawing.Color.Transparent
        Me.lbModelo1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbModelo1.Location = New System.Drawing.Point(62, 199)
        Me.lbModelo1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbModelo1.Name = "lbModelo1"
        Me.lbModelo1.Size = New System.Drawing.Size(64, 21)
        Me.lbModelo1.TabIndex = 64
        Me.lbModelo1.Text = "Modelo"
        '
        'tUnidadeModelo1
        '
        Me.tUnidadeModelo1.Enabled = False
        Me.tUnidadeModelo1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeModelo1.Location = New System.Drawing.Point(168, 196)
        Me.tUnidadeModelo1.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeModelo1.Name = "tUnidadeModelo1"
        Me.tUnidadeModelo1.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeModelo1.TabIndex = 63
        '
        'lbTipo1
        '
        Me.lbTipo1.AutoSize = True
        Me.lbTipo1.BackColor = System.Drawing.Color.Transparent
        Me.lbTipo1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipo1.Location = New System.Drawing.Point(62, 164)
        Me.lbTipo1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTipo1.Name = "lbTipo1"
        Me.lbTipo1.Size = New System.Drawing.Size(40, 21)
        Me.lbTipo1.TabIndex = 62
        Me.lbTipo1.Text = "Tipo"
        '
        'tUnidadeTipo1
        '
        Me.tUnidadeTipo1.Enabled = False
        Me.tUnidadeTipo1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUnidadeTipo1.Location = New System.Drawing.Point(168, 161)
        Me.tUnidadeTipo1.Margin = New System.Windows.Forms.Padding(4)
        Me.tUnidadeTipo1.Name = "tUnidadeTipo1"
        Me.tUnidadeTipo1.Size = New System.Drawing.Size(281, 27)
        Me.tUnidadeTipo1.TabIndex = 61
        '
        'lbUnidade2
        '
        Me.lbUnidade2.AutoSize = True
        Me.lbUnidade2.BackColor = System.Drawing.Color.Transparent
        Me.lbUnidade2.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.lbUnidade2.Location = New System.Drawing.Point(567, 53)
        Me.lbUnidade2.Name = "lbUnidade2"
        Me.lbUnidade2.Size = New System.Drawing.Size(83, 24)
        Me.lbUnidade2.TabIndex = 58
        Me.lbUnidade2.Text = "Unidade"
        '
        'lbUnidade3
        '
        Me.lbUnidade3.AutoSize = True
        Me.lbUnidade3.BackColor = System.Drawing.Color.Transparent
        Me.lbUnidade3.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.lbUnidade3.Location = New System.Drawing.Point(1074, 53)
        Me.lbUnidade3.Name = "lbUnidade3"
        Me.lbUnidade3.Size = New System.Drawing.Size(83, 24)
        Me.lbUnidade3.TabIndex = 55
        Me.lbUnidade3.Text = "Unidade"
        '
        'lbUnidade1
        '
        Me.lbUnidade1.AutoSize = True
        Me.lbUnidade1.BackColor = System.Drawing.Color.Transparent
        Me.lbUnidade1.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.lbUnidade1.Location = New System.Drawing.Point(59, 53)
        Me.lbUnidade1.Name = "lbUnidade1"
        Me.lbUnidade1.Size = New System.Drawing.Size(83, 24)
        Me.lbUnidade1.TabIndex = 52
        Me.lbUnidade1.Text = "Unidade"
        '
        'lbPC
        '
        Me.lbPC.AutoSize = True
        Me.lbPC.Font = New System.Drawing.Font("Bahnschrift", 8.25!)
        Me.lbPC.ForeColor = System.Drawing.Color.White
        Me.lbPC.Location = New System.Drawing.Point(9, 735)
        Me.lbPC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPC.Name = "lbPC"
        Me.lbPC.Size = New System.Drawing.Size(63, 17)
        Me.lbPC.TabIndex = 1
        Me.lbPC.Text = "Conexão"
        Me.lbPC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGPU
        '
        Me.btnGPU.BackColor = System.Drawing.Color.Transparent
        Me.btnGPU.BackgroundImage = CType(resources.GetObject("btnGPU.BackgroundImage"), System.Drawing.Image)
        Me.btnGPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGPU.FlatAppearance.BorderSize = 0
        Me.btnGPU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGPU.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPU.ForeColor = System.Drawing.Color.White
        Me.btnGPU.Location = New System.Drawing.Point(448, 18)
        Me.btnGPU.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGPU.Name = "btnGPU"
        Me.btnGPU.Size = New System.Drawing.Size(215, 74)
        Me.btnGPU.TabIndex = 4
        Me.btnGPU.UseVisualStyleBackColor = False
        '
        'btnMemoria
        '
        Me.btnMemoria.BackColor = System.Drawing.Color.Transparent
        Me.btnMemoria.BackgroundImage = CType(resources.GetObject("btnMemoria.BackgroundImage"), System.Drawing.Image)
        Me.btnMemoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemoria.FlatAppearance.BorderSize = 0
        Me.btnMemoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMemoria.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemoria.ForeColor = System.Drawing.Color.White
        Me.btnMemoria.Location = New System.Drawing.Point(662, 18)
        Me.btnMemoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMemoria.Name = "btnMemoria"
        Me.btnMemoria.Size = New System.Drawing.Size(215, 74)
        Me.btnMemoria.TabIndex = 5
        Me.btnMemoria.UseVisualStyleBackColor = False
        '
        'btnPlaca
        '
        Me.btnPlaca.BackColor = System.Drawing.Color.Transparent
        Me.btnPlaca.BackgroundImage = CType(resources.GetObject("btnPlaca.BackgroundImage"), System.Drawing.Image)
        Me.btnPlaca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlaca.FlatAppearance.BorderSize = 0
        Me.btnPlaca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaca.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaca.ForeColor = System.Drawing.Color.White
        Me.btnPlaca.Location = New System.Drawing.Point(879, 18)
        Me.btnPlaca.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPlaca.Name = "btnPlaca"
        Me.btnPlaca.Size = New System.Drawing.Size(215, 74)
        Me.btnPlaca.TabIndex = 6
        Me.btnPlaca.UseVisualStyleBackColor = False
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.Transparent
        Me.B1.Enabled = False
        Me.B1.FlatAppearance.BorderSize = 0
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B1.Location = New System.Drawing.Point(15, 5)
        Me.B1.Margin = New System.Windows.Forms.Padding(4)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(215, 12)
        Me.B1.TabIndex = 5
        Me.B1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1169, 735)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CPU-James © 2019 - Developed by Thiago Sasaki"
        '
        'btnUnidades
        '
        Me.btnUnidades.BackColor = System.Drawing.Color.Transparent
        Me.btnUnidades.BackgroundImage = CType(resources.GetObject("btnUnidades.BackgroundImage"), System.Drawing.Image)
        Me.btnUnidades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnidades.FlatAppearance.BorderSize = 0
        Me.btnUnidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnidades.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnidades.ForeColor = System.Drawing.Color.White
        Me.btnUnidades.Location = New System.Drawing.Point(1095, 18)
        Me.btnUnidades.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUnidades.Name = "btnUnidades"
        Me.btnUnidades.Size = New System.Drawing.Size(215, 74)
        Me.btnUnidades.TabIndex = 7
        Me.btnUnidades.UseVisualStyleBackColor = False
        '
        'B3
        '
        Me.B3.BackColor = System.Drawing.Color.Transparent
        Me.B3.Enabled = False
        Me.B3.FlatAppearance.BorderSize = 0
        Me.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B3.Location = New System.Drawing.Point(448, 5)
        Me.B3.Margin = New System.Windows.Forms.Padding(4)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(215, 12)
        Me.B3.TabIndex = 8
        Me.B3.UseVisualStyleBackColor = False
        '
        'B4
        '
        Me.B4.BackColor = System.Drawing.Color.Transparent
        Me.B4.Enabled = False
        Me.B4.FlatAppearance.BorderSize = 0
        Me.B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B4.Location = New System.Drawing.Point(662, 5)
        Me.B4.Margin = New System.Windows.Forms.Padding(4)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(215, 12)
        Me.B4.TabIndex = 9
        Me.B4.UseVisualStyleBackColor = False
        '
        'B5
        '
        Me.B5.BackColor = System.Drawing.Color.Transparent
        Me.B5.Enabled = False
        Me.B5.FlatAppearance.BorderSize = 0
        Me.B5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B5.Location = New System.Drawing.Point(879, 5)
        Me.B5.Margin = New System.Windows.Forms.Padding(4)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(215, 12)
        Me.B5.TabIndex = 10
        Me.B5.UseVisualStyleBackColor = False
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.Color.Transparent
        Me.B2.Enabled = False
        Me.B2.FlatAppearance.BorderSize = 0
        Me.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B2.Location = New System.Drawing.Point(231, 5)
        Me.B2.Margin = New System.Windows.Forms.Padding(4)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(215, 12)
        Me.B2.TabIndex = 13
        Me.B2.UseVisualStyleBackColor = False
        '
        'tmrInicio
        '
        Me.tmrInicio.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1482, 727)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'tmrDrives
        '
        Me.tmrDrives.Interval = 3000
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.BackgroundImage = CType(resources.GetObject("btnFechar.BackgroundImage"), System.Drawing.Image)
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.ForeColor = System.Drawing.Color.White
        Me.btnFechar.Location = New System.Drawing.Point(1421, 18)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(107, 74)
        Me.btnFechar.TabIndex = 15
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1538, 760)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.lbPC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnUnidades)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me.btnMemoria)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.btnPlaca)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCPU)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnGPU)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B6)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CPU-James"
        Me.TabControl1.ResumeLayout(False)
        Me.Inicio.ResumeLayout(False)
        Me.grpMouse.ResumeLayout(False)
        Me.grpMouse.PerformLayout()
        Me.grpTemperatura.ResumeLayout(False)
        Me.grpTemperatura.PerformLayout()
        Me.grpRede.ResumeLayout(False)
        Me.grpRede.PerformLayout()
        Me.grpBIOS.ResumeLayout(False)
        Me.grpBIOS.PerformLayout()
        Me.grpBateria.ResumeLayout(False)
        Me.grpBateria.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpSistema.ResumeLayout(False)
        Me.grpSistema.PerformLayout()
        Me.grpMonitor.ResumeLayout(False)
        Me.grpMonitor.PerformLayout()
        Me.grpTeclado.ResumeLayout(False)
        Me.grpTeclado.PerformLayout()
        Me.gpSO.ResumeLayout(False)
        Me.gpSO.PerformLayout()
        Me.CPU.ResumeLayout(False)
        Me.CPU.PerformLayout()
        Me.grpProcessador.ResumeLayout(False)
        Me.grpProcessador.PerformLayout()
        CType(Me.picHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQualcomm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIntel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAMD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOutros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCache.ResumeLayout(False)
        Me.grpCache.PerformLayout()
        Me.GPU.ResumeLayout(False)
        Me.GPU.PerformLayout()
        CType(Me.picGPU2Nvidia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPU2EVGA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPU2Asus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPU2Intel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPU2AMD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPU2Outros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPU1Nvidia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPU1EVGA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPU1Asus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPU1Intel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPU1AMD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPU1Outros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Memoria.ResumeLayout(False)
        Me.Memoria.PerformLayout()
        Me.PlacaMae.ResumeLayout(False)
        Me.PlacaMae.PerformLayout()
        Me.Unidades.ResumeLayout(False)
        Me.Unidades.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Private WithEvents btnConfig As Button
    Private WithEvents btnInicio As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Inicio As TabPage
    Friend WithEvents CPU As TabPage
    Private WithEvents btnCPU As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GPU As TabPage
    Friend WithEvents Memoria As TabPage
    Friend WithEvents PlacaMae As TabPage
    Private WithEvents btnGPU As Button
    Private WithEvents btnMemoria As Button
    Private WithEvents btnPlaca As Button
    Friend WithEvents B1 As Button
    Friend WithEvents Label3 As Label
    Private WithEvents btnUnidades As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B4 As Button
    Friend WithEvents B5 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents lbPC As Label
    Friend WithEvents gpSO As GroupBox
    Friend WithEvents tSistema As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tPlataforma As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tVersao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tLinguagemSO As TextBox
    Friend WithEvents Linguagem As Label
    Friend WithEvents grpTeclado As GroupBox
    Friend WithEvents tLinguagemTeclado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tNumLock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tScrollLock As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tCapsLock As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents grpMonitor As GroupBox
    Friend WithEvents tStatusMonitor As TextBox
    Friend WithEvents Resolução As Label
    Friend WithEvents tResolucao As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tDescricaoMonitor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tFabricanteMonitor As TextBox
    Friend WithEvents Fabricante As Label
    Friend WithEvents grpSistema As GroupBox
    Friend WithEvents tInternet As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tHora As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tModelo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tFabricanteMaquina As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents grpBateria As GroupBox
    Friend WithEvents tTempo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tQuantidade As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents tConectada As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tStatusBateria As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tProcessadorNome As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tProcessadorFabricante As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grpMouse As GroupBox
    Friend WithEvents tStatusMouse As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents tDescricaoMouse As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents tFabricanteMouse As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents grpTemperatura As GroupBox
    Friend WithEvents tAudioStatus As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents tAudioNome As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents tAudioFabricante As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents grpRede As GroupBox
    Friend WithEvents tStatusRede As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents tNomeRede As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents tFabricanteRede As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents grpBIOS As GroupBox
    Friend WithEvents tSerialBIOS As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents tVersaoBIOS As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents tNomeBIOS As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents tFabricanteBIOS As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents tProcessadorFamilia As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents tProcessadorClockAtual As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tProcessadorClockMax As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents picOutros As PictureBox
    Friend WithEvents picAMD As PictureBox
    Friend WithEvents picIntel As PictureBox
    Friend WithEvents grpCache As GroupBox
    Friend WithEvents tProcessadorL3Tam As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents tProcessadorL2Tam As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents tProcessadorL1Tam As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents tProcessadorLogicos As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents tProcessadorNucleosHab As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents tProcessadorThreads As TextBox
    Friend WithEvents Threads As Label
    Friend WithEvents tProcessadorNucleos As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents tProcessadorL3Vel As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents tProcessadorL2Vel As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents tProcessadorL1Vel As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents tProcessadorCacheStatus As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents picQualcomm As PictureBox
    Friend WithEvents picHP As PictureBox
    Friend WithEvents grpProcessador As GroupBox
    Friend WithEvents tProcessadorStatus As TextBox
    Friend WithEvents Label73 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents picGPU2Nvidia As PictureBox
    Friend WithEvents picGPU2EVGA As PictureBox
    Friend WithEvents tGPUNome2 As TextBox
    Friend WithEvents picGPU2Asus As PictureBox
    Friend WithEvents picGPU2Intel As PictureBox
    Friend WithEvents picGPU2AMD As PictureBox
    Friend WithEvents tGPUTaxaMax2 As TextBox
    Friend WithEvents tGPUDriver2 As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents picGPU2Outros As PictureBox
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents tGPUTaxaAtual2 As TextBox
    Friend WithEvents tGPUMemoria2 As TextBox
    Friend WithEvents tGPUTipo2 As TextBox
    Friend WithEvents tGPUDescricao2 As TextBox
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents tGPUGPU2 As TextBox
    Friend WithEvents Label74 As Label
    Friend WithEvents picGPU1Nvidia As PictureBox
    Friend WithEvents picGPU1EVGA As PictureBox
    Friend WithEvents tGPUNome1 As TextBox
    Friend WithEvents picGPU1Asus As PictureBox
    Friend WithEvents picGPU1Intel As PictureBox
    Friend WithEvents picGPU1AMD As PictureBox
    Friend WithEvents tGPUTaxaMax1 As TextBox
    Friend WithEvents tGPUDriver1 As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents picGPU1Outros As PictureBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents tGPUTaxaAtual1 As TextBox
    Friend WithEvents tGPUMemoria1 As TextBox
    Friend WithEvents tGPUTipo1 As TextBox
    Friend WithEvents tGPUDescricao1 As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents tGPUGPU1 As TextBox
    Friend WithEvents tGPUStatus2 As TextBox
    Friend WithEvents Label77 As Label
    Friend WithEvents tGPUStatus1 As TextBox
    Friend WithEvents Label76 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents tmrInicio As Timer
    Friend WithEvents tMemoriaTotal As TextBox
    Friend WithEvents Label80 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents tMemoriaUtilizada As TextBox
    Friend WithEvents pbMemoria As ProgressBar
    Friend WithEvents pbCPU As ProgressBar
    Friend WithEvents Label89 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents tCPUUso As TextBox
    Friend WithEvents Label86 As Label
    Friend WithEvents tMemoriaUso As TextBox
    Friend WithEvents Label83 As Label
    Friend WithEvents tPlacaFabricante As TextBox
    Friend WithEvents Label101 As Label
    Friend WithEvents tPlacaVersao As TextBox
    Friend WithEvents Label84 As Label
    Friend WithEvents tPlacaModelo As TextBox
    Friend WithEvents Unidades As TabPage
    Friend WithEvents B6 As Button
    Friend WithEvents lbUnidade1 As Label
    Friend WithEvents lbID1 As Label
    Friend WithEvents tUnidadeID1 As TextBox
    Friend WithEvents lbModelo1 As Label
    Friend WithEvents tUnidadeModelo1 As TextBox
    Friend WithEvents lbTipo1 As Label
    Friend WithEvents tUnidadeTipo1 As TextBox
    Friend WithEvents lbUnidade2 As Label
    Friend WithEvents lbUnidade3 As Label
    Friend WithEvents lbStatus6 As Label
    Friend WithEvents tUnidadeStatus6 As TextBox
    Friend WithEvents lbFabricante6 As Label
    Friend WithEvents tUnidadeFabricante6 As TextBox
    Friend WithEvents lbEspacoTotal6 As Label
    Friend WithEvents tUnidadeTotal6 As TextBox
    Friend WithEvents lbID6 As Label
    Friend WithEvents tUnidadeID6 As TextBox
    Friend WithEvents lbModelo6 As Label
    Friend WithEvents tUnidadeModelo6 As TextBox
    Friend WithEvents lbTipo6 As Label
    Friend WithEvents tUnidadeTipo6 As TextBox
    Friend WithEvents lbStatus5 As Label
    Friend WithEvents tUnidadeStatus5 As TextBox
    Friend WithEvents lbFabricante5 As Label
    Friend WithEvents tUnidadeFabricante5 As TextBox
    Friend WithEvents lbEspacoTotal5 As Label
    Friend WithEvents tUnidadeTotal5 As TextBox
    Friend WithEvents lbID5 As Label
    Friend WithEvents tUnidadeID5 As TextBox
    Friend WithEvents lbModelo5 As Label
    Friend WithEvents tUnidadeModelo5 As TextBox
    Friend WithEvents lbTipo5 As Label
    Friend WithEvents tUnidadeTipo5 As TextBox
    Friend WithEvents lbStatus4 As Label
    Friend WithEvents tUnidadeStatus4 As TextBox
    Friend WithEvents lbFabricante4 As Label
    Friend WithEvents tUnidadeFabricante4 As TextBox
    Friend WithEvents lbEspacoTotal4 As Label
    Friend WithEvents tUnidadeTotal4 As TextBox
    Friend WithEvents lbID4 As Label
    Friend WithEvents tUnidadeID4 As TextBox
    Friend WithEvents lbModelo4 As Label
    Friend WithEvents tUnidadeModelo4 As TextBox
    Friend WithEvents lbTipo4 As Label
    Friend WithEvents tUnidadeTipo4 As TextBox
    Friend WithEvents lbUnidade5 As Label
    Friend WithEvents lbUnidade6 As Label
    Friend WithEvents lbUnidade4 As Label
    Friend WithEvents lbStatus3 As Label
    Friend WithEvents tUnidadeStatus3 As TextBox
    Friend WithEvents lbFabricante3 As Label
    Friend WithEvents tUnidadeFabricante3 As TextBox
    Friend WithEvents lbEspacoTotal3 As Label
    Friend WithEvents tUnidadeTotal3 As TextBox
    Friend WithEvents lbID3 As Label
    Friend WithEvents tUnidadeID3 As TextBox
    Friend WithEvents lbModelo3 As Label
    Friend WithEvents tUnidadeModelo3 As TextBox
    Friend WithEvents lbTipo3 As Label
    Friend WithEvents tUnidadeTipo3 As TextBox
    Friend WithEvents lbStatus2 As Label
    Friend WithEvents tUnidadeStatus2 As TextBox
    Friend WithEvents lbFabricante2 As Label
    Friend WithEvents tUnidadeFabricante2 As TextBox
    Friend WithEvents lbEspacoTotal2 As Label
    Friend WithEvents tUnidadeTotal2 As TextBox
    Friend WithEvents lbID2 As Label
    Friend WithEvents tUnidadeID2 As TextBox
    Friend WithEvents lbModelo2 As Label
    Friend WithEvents tUnidadeModelo2 As TextBox
    Friend WithEvents lbTipo2 As Label
    Friend WithEvents tUnidadeTipo2 As TextBox
    Friend WithEvents lbStatus1 As Label
    Friend WithEvents tUnidadeStatus1 As TextBox
    Friend WithEvents lbFabricante1 As Label
    Friend WithEvents tUnidadeFabricante1 As TextBox
    Friend WithEvents lbEspacoTotal1 As Label
    Friend WithEvents tUnidadeTotal1 As TextBox
    Friend WithEvents tmrDrives As Timer
    Friend WithEvents Label34 As Label
    Private WithEvents btnFechar As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents tPlacaSerial As TextBox
    Friend WithEvents Label85 As Label
    Friend WithEvents tPlacaBarramento1 As TextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents tPlacaIDSistema As TextBox
    Friend WithEvents tPlacaBarramento2 As TextBox
    Friend WithEvents Label106 As Label
    Friend WithEvents tPlacaStatus As TextBox
    Friend WithEvents Label107 As Label
    Friend WithEvents tPlacaSlots As TextBox
    Friend WithEvents tRAMVoltagem4 As TextBox
    Friend WithEvents tRAMFrequencia4 As TextBox
    Friend WithEvents Label121 As Label
    Friend WithEvents tRAMStatus4 As TextBox
    Friend WithEvents lbRAMID4 As Label
    Friend WithEvents tRAMTipo4 As TextBox
    Friend WithEvents Label123 As Label
    Friend WithEvents lbRAMFabricante4 As Label
    Friend WithEvents tRAMFabricante4 As TextBox
    Friend WithEvents lbRAMModelo4 As Label
    Friend WithEvents tRAMModelo4 As TextBox
    Friend WithEvents Label126 As Label
    Friend WithEvents Label127 As Label
    Friend WithEvents tRAMTamanho4 As TextBox
    Friend WithEvents Label128 As Label
    Friend WithEvents tRAMID4 As TextBox
    Friend WithEvents Label129 As Label
    Friend WithEvents tRAMVoltagem3 As TextBox
    Friend WithEvents tRAMFrequencia3 As TextBox
    Friend WithEvents Label112 As Label
    Friend WithEvents tRAMStatus3 As TextBox
    Friend WithEvents lbRAMID3 As Label
    Friend WithEvents tRAMTipo3 As TextBox
    Friend WithEvents Label114 As Label
    Friend WithEvents lbRAMFabricante3 As Label
    Friend WithEvents tRAMFabricante3 As TextBox
    Friend WithEvents lbRAMModelo3 As Label
    Friend WithEvents tRAMModelo3 As TextBox
    Friend WithEvents Label117 As Label
    Friend WithEvents Label118 As Label
    Friend WithEvents tRAMTamanho3 As TextBox
    Friend WithEvents Label119 As Label
    Friend WithEvents tRAMID3 As TextBox
    Friend WithEvents Label120 As Label
    Friend WithEvents tRAMVoltagem2 As TextBox
    Friend WithEvents tRAMFrequencia2 As TextBox
    Friend WithEvents Label99 As Label
    Friend WithEvents tRAMStatus2 As TextBox
    Friend WithEvents lbRAMID2 As Label
    Friend WithEvents tRAMTipo2 As TextBox
    Friend WithEvents Label102 As Label
    Friend WithEvents lbRAMFabricante2 As Label
    Friend WithEvents tRAMFabricante2 As TextBox
    Friend WithEvents lbRAMModelo2 As Label
    Friend WithEvents tRAMModelo2 As TextBox
    Friend WithEvents Label108 As Label
    Friend WithEvents Label109 As Label
    Friend WithEvents tRAMTamanho2 As TextBox
    Friend WithEvents Label110 As Label
    Friend WithEvents tRAMID2 As TextBox
    Friend WithEvents Label111 As Label
    Friend WithEvents tRAMVoltagem1 As TextBox
    Friend WithEvents tRAMFrequencia1 As TextBox
    Friend WithEvents Label97 As Label
    Friend WithEvents tRAMStatus1 As TextBox
    Friend WithEvents lbRAMID1 As Label
    Friend WithEvents tRAMTipo1 As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents lbRAMFabricante1 As Label
    Friend WithEvents tRAMFabricante1 As TextBox
    Friend WithEvents lbRAMModelo1 As Label
    Friend WithEvents tRAMModelo1 As TextBox
    Friend WithEvents Label93 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents tRAMTamanho1 As TextBox
    Friend WithEvents Label95 As Label
    Friend WithEvents tRAMID1 As TextBox
    Friend WithEvents Label96 As Label
End Class
