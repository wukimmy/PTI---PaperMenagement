<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrcamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrcamento))
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnParceiro = New System.Windows.Forms.Button()
        Me.btnOrca = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.ParceiroCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(39, 297)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 157
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnParceiro
        '
        Me.btnParceiro.BackgroundImage = Global.PaperManagement.My.Resources.Resources.ParceiroCor
        Me.btnParceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParceiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParceiro.ForeColor = System.Drawing.Color.White
        Me.btnParceiro.Image = Global.PaperManagement.My.Resources.Resources.NovoSmall
        Me.btnParceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParceiro.Location = New System.Drawing.Point(182, 165)
        Me.btnParceiro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnParceiro.Name = "btnParceiro"
        Me.btnParceiro.Size = New System.Drawing.Size(237, 75)
        Me.btnParceiro.TabIndex = 156
        Me.btnParceiro.Text = "  Parceiro"
        Me.btnParceiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnParceiro.UseVisualStyleBackColor = True
        '
        'btnOrca
        '
        Me.btnOrca.BackgroundImage = Global.PaperManagement.My.Resources.Resources.ParceiroCor
        Me.btnOrca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrca.ForeColor = System.Drawing.Color.White
        Me.btnOrca.Image = Global.PaperManagement.My.Resources.Resources.NovoSmall
        Me.btnOrca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrca.Location = New System.Drawing.Point(44, 57)
        Me.btnOrca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOrca.Name = "btnOrca"
        Me.btnOrca.Size = New System.Drawing.Size(237, 75)
        Me.btnOrca.TabIndex = 159
        Me.btnOrca.Text = " Orçamento"
        Me.btnOrca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrca.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.ParceiroCor
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.PaperManagement.My.Resources.Resources.BuscarSmall
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(310, 57)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(237, 75)
        Me.btnBuscar.TabIndex = 160
        Me.btnBuscar.Text = "  Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmOrcamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 403)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnOrca)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnParceiro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmOrcamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOrcamento"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnParceiro As System.Windows.Forms.Button
    Friend WithEvents btnOrca As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
