<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtDespesa = New System.Windows.Forms.RadioButton()
        Me.rbtProduto = New System.Windows.Forms.RadioButton()
        Me.rbtForncedor = New System.Windows.Forms.RadioButton()
        Me.rbtFuncionario = New System.Windows.Forms.RadioButton()
        Me.rbtCliente = New System.Windows.Forms.RadioButton()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtDespesa)
        Me.GroupBox1.Controls.Add(Me.rbtProduto)
        Me.GroupBox1.Controls.Add(Me.rbtForncedor)
        Me.GroupBox1.Controls.Add(Me.rbtFuncionario)
        Me.GroupBox1.Controls.Add(Me.rbtCliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(39, 32)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(864, 154)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo: "
        '
        'rbtDespesa
        '
        Me.rbtDespesa.AutoSize = True
        Me.rbtDespesa.Location = New System.Drawing.Point(699, 72)
        Me.rbtDespesa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtDespesa.Name = "rbtDespesa"
        Me.rbtDespesa.Size = New System.Drawing.Size(134, 33)
        Me.rbtDespesa.TabIndex = 4
        Me.rbtDespesa.TabStop = True
        Me.rbtDespesa.Text = "Despesa"
        Me.rbtDespesa.UseVisualStyleBackColor = True
        '
        'rbtProduto
        '
        Me.rbtProduto.AutoSize = True
        Me.rbtProduto.Location = New System.Drawing.Point(549, 72)
        Me.rbtProduto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtProduto.Name = "rbtProduto"
        Me.rbtProduto.Size = New System.Drawing.Size(123, 33)
        Me.rbtProduto.TabIndex = 3
        Me.rbtProduto.TabStop = True
        Me.rbtProduto.Text = "Produto"
        Me.rbtProduto.UseVisualStyleBackColor = True
        '
        'rbtForncedor
        '
        Me.rbtForncedor.AutoSize = True
        Me.rbtForncedor.Location = New System.Drawing.Point(358, 72)
        Me.rbtForncedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtForncedor.Name = "rbtForncedor"
        Me.rbtForncedor.Size = New System.Drawing.Size(164, 33)
        Me.rbtForncedor.TabIndex = 2
        Me.rbtForncedor.TabStop = True
        Me.rbtForncedor.Text = "Fornecedor"
        Me.rbtForncedor.UseVisualStyleBackColor = True
        '
        'rbtFuncionario
        '
        Me.rbtFuncionario.AutoSize = True
        Me.rbtFuncionario.Location = New System.Drawing.Point(164, 72)
        Me.rbtFuncionario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtFuncionario.Name = "rbtFuncionario"
        Me.rbtFuncionario.Size = New System.Drawing.Size(165, 33)
        Me.rbtFuncionario.TabIndex = 1
        Me.rbtFuncionario.TabStop = True
        Me.rbtFuncionario.Text = "Funcionário"
        Me.rbtFuncionario.UseVisualStyleBackColor = True
        '
        'rbtCliente
        '
        Me.rbtCliente.AutoSize = True
        Me.rbtCliente.Location = New System.Drawing.Point(27, 72)
        Me.rbtCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtCliente.Name = "rbtCliente"
        Me.rbtCliente.Size = New System.Drawing.Size(114, 33)
        Me.rbtCliente.TabIndex = 0
        Me.rbtCliente.TabStop = True
        Me.rbtCliente.Tag = ""
        Me.rbtCliente.Text = "Cliente"
        Me.rbtCliente.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(39, 212)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 155
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(762, 212)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(141, 58)
        Me.btnImprimir.TabIndex = 156
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 342)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmListar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtForncedor As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFuncionario As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtProduto As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDespesa As RadioButton
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
End Class
