<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelatorios))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnMensalista = New System.Windows.Forms.Button()
        Me.btnGraficos = New System.Windows.Forms.Button()
        Me.btnFechamento = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.PaperManagement.My.Resources.Resources._Listar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(316, 62)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 75)
        Me.Button1.TabIndex = 153
        Me.Button1.Text = "  Listar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(50, 308)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 152
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnMensalista
        '
        Me.btnMensalista.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnMensalista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMensalista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMensalista.ForeColor = System.Drawing.Color.White
        Me.btnMensalista.Image = Global.PaperManagement.My.Resources.Resources._Fechamento
        Me.btnMensalista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMensalista.Location = New System.Drawing.Point(316, 165)
        Me.btnMensalista.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMensalista.Name = "btnMensalista"
        Me.btnMensalista.Size = New System.Drawing.Size(237, 75)
        Me.btnMensalista.TabIndex = 37
        Me.btnMensalista.Text = "  Mensalista"
        Me.btnMensalista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMensalista.UseVisualStyleBackColor = True
        '
        'btnGraficos
        '
        Me.btnGraficos.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficos.ForeColor = System.Drawing.Color.White
        Me.btnGraficos.Image = Global.PaperManagement.My.Resources.Resources._Graficos
        Me.btnGraficos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGraficos.Location = New System.Drawing.Point(50, 165)
        Me.btnGraficos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGraficos.Name = "btnGraficos"
        Me.btnGraficos.Size = New System.Drawing.Size(237, 75)
        Me.btnGraficos.TabIndex = 36
        Me.btnGraficos.Text = "  Gráficos"
        Me.btnGraficos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGraficos.UseVisualStyleBackColor = True
        '
        'btnFechamento
        '
        Me.btnFechamento.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnFechamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechamento.ForeColor = System.Drawing.Color.White
        Me.btnFechamento.Image = Global.PaperManagement.My.Resources.Resources._Relatorio
        Me.btnFechamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechamento.Location = New System.Drawing.Point(50, 62)
        Me.btnFechamento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFechamento.Name = "btnFechamento"
        Me.btnFechamento.Size = New System.Drawing.Size(237, 75)
        Me.btnFechamento.TabIndex = 35
        Me.btnFechamento.Text = "  Fechamento"
        Me.btnFechamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechamento.UseVisualStyleBackColor = True
        '
        'frmRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 403)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnMensalista)
        Me.Controls.Add(Me.btnGraficos)
        Me.Controls.Add(Me.btnFechamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmRelatorios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatórios"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFechamento As System.Windows.Forms.Button
    Friend WithEvents btnGraficos As System.Windows.Forms.Button
    Friend WithEvents btnMensalista As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
