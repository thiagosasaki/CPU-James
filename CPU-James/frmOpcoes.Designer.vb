<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcoes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpcoes))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.grpSobre = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnMudo = New System.Windows.Forms.Button()
        Me.btnAumentarVol = New System.Windows.Forms.Button()
        Me.btnDiminuirVol = New System.Windows.Forms.Button()
        Me.grpMusica = New System.Windows.Forms.GroupBox()
        Me.grpSobre.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMusica.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Transparent
        Me.btnPlay.BackgroundImage = CType(resources.GetObject("btnPlay.BackgroundImage"), System.Drawing.Image)
        Me.btnPlay.FlatAppearance.BorderSize = 0
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(10, 28)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(100, 50)
        Me.btnPlay.TabIndex = 6
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'grpSobre
        '
        Me.grpSobre.BackColor = System.Drawing.Color.Transparent
        Me.grpSobre.Controls.Add(Me.PictureBox2)
        Me.grpSobre.Controls.Add(Me.Label1)
        Me.grpSobre.Controls.Add(Me.PictureBox1)
        Me.grpSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpSobre.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSobre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.grpSobre.Location = New System.Drawing.Point(12, 107)
        Me.grpSobre.Name = "grpSobre"
        Me.grpSobre.Size = New System.Drawing.Size(439, 132)
        Me.grpSobre.TabIndex = 7
        Me.grpSobre.TabStop = False
        Me.grpSobre.Text = "Sobre"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(184, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(249, 98)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CPU-JAMES"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(6, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 98)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.Transparent
        Me.btnPause.BackgroundImage = CType(resources.GetObject("btnPause.BackgroundImage"), System.Drawing.Image)
        Me.btnPause.FlatAppearance.BorderSize = 0
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.Location = New System.Drawing.Point(10, 28)
        Me.btnPause.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(100, 50)
        Me.btnPause.TabIndex = 8
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'btnMudo
        '
        Me.btnMudo.BackColor = System.Drawing.Color.Transparent
        Me.btnMudo.BackgroundImage = CType(resources.GetObject("btnMudo.BackgroundImage"), System.Drawing.Image)
        Me.btnMudo.FlatAppearance.BorderSize = 0
        Me.btnMudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMudo.Location = New System.Drawing.Point(117, 28)
        Me.btnMudo.Name = "btnMudo"
        Me.btnMudo.Size = New System.Drawing.Size(100, 50)
        Me.btnMudo.TabIndex = 10
        Me.btnMudo.UseVisualStyleBackColor = False
        '
        'btnAumentarVol
        '
        Me.btnAumentarVol.BackColor = System.Drawing.Color.Transparent
        Me.btnAumentarVol.BackgroundImage = CType(resources.GetObject("btnAumentarVol.BackgroundImage"), System.Drawing.Image)
        Me.btnAumentarVol.FlatAppearance.BorderSize = 0
        Me.btnAumentarVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAumentarVol.Location = New System.Drawing.Point(329, 28)
        Me.btnAumentarVol.Name = "btnAumentarVol"
        Me.btnAumentarVol.Size = New System.Drawing.Size(100, 50)
        Me.btnAumentarVol.TabIndex = 11
        Me.btnAumentarVol.UseVisualStyleBackColor = False
        '
        'btnDiminuirVol
        '
        Me.btnDiminuirVol.BackColor = System.Drawing.Color.Transparent
        Me.btnDiminuirVol.BackgroundImage = CType(resources.GetObject("btnDiminuirVol.BackgroundImage"), System.Drawing.Image)
        Me.btnDiminuirVol.FlatAppearance.BorderSize = 0
        Me.btnDiminuirVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiminuirVol.Location = New System.Drawing.Point(223, 28)
        Me.btnDiminuirVol.Name = "btnDiminuirVol"
        Me.btnDiminuirVol.Size = New System.Drawing.Size(100, 50)
        Me.btnDiminuirVol.TabIndex = 12
        Me.btnDiminuirVol.Text = "-"
        Me.btnDiminuirVol.UseVisualStyleBackColor = False
        '
        'grpMusica
        '
        Me.grpMusica.BackColor = System.Drawing.Color.Transparent
        Me.grpMusica.Controls.Add(Me.btnDiminuirVol)
        Me.grpMusica.Controls.Add(Me.btnAumentarVol)
        Me.grpMusica.Controls.Add(Me.btnPause)
        Me.grpMusica.Controls.Add(Me.btnMudo)
        Me.grpMusica.Controls.Add(Me.btnPlay)
        Me.grpMusica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpMusica.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMusica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.grpMusica.Location = New System.Drawing.Point(12, 12)
        Me.grpMusica.Name = "grpMusica"
        Me.grpMusica.Size = New System.Drawing.Size(439, 89)
        Me.grpMusica.TabIndex = 8
        Me.grpMusica.TabStop = False
        Me.grpMusica.Text = "Controle de Música"
        '
        'frmOpcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(464, 251)
        Me.Controls.Add(Me.grpSobre)
        Me.Controls.Add(Me.grpMusica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpcoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configurações"
        Me.grpSobre.ResumeLayout(False)
        Me.grpSobre.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMusica.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlay As Button
    Friend WithEvents grpSobre As GroupBox
    Friend WithEvents btnPause As Button
    Friend WithEvents btnMudo As Button
    Friend WithEvents btnAumentarVol As Button
    Friend WithEvents btnDiminuirVol As Button
    Friend WithEvents grpMusica As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
