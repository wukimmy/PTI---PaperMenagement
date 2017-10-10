<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnFinanceiro = New System.Windows.Forms.Button()
        Me.btnParceria = New System.Windows.Forms.Button()
        Me.btnFuncionario = New System.Windows.Forms.Button()
        Me.btnGerenciarSenha = New System.Windows.Forms.Button()
        Me.btnEstoque = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnFechamento = New System.Windows.Forms.Button()
        Me.btnFornecedor = New System.Windows.Forms.Button()
        Me.btnVenda = New System.Windows.Forms.Button()
        Me.listNot = New System.Windows.Forms.ListBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.PaperManagement.My.Resources.Resources.BorboletaBranca
        Me.PictureBox1.Location = New System.Drawing.Point(54, 131)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 268)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'btnFinanceiro
        '
        Me.btnFinanceiro.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FinanceiroCor
        Me.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinanceiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinanceiro.ForeColor = System.Drawing.Color.White
        Me.btnFinanceiro.Image = Global.PaperManagement.My.Resources.Resources.Financeiro
        Me.btnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinanceiro.Location = New System.Drawing.Point(1206, 1015)
        Me.btnFinanceiro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFinanceiro.Name = "btnFinanceiro"
        Me.btnFinanceiro.Size = New System.Drawing.Size(543, 223)
        Me.btnFinanceiro.TabIndex = 30
        Me.btnFinanceiro.Text = "    Financeiro"
        Me.btnFinanceiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFinanceiro.UseVisualStyleBackColor = True
        '
        'btnParceria
        '
        Me.btnParceria.BackgroundImage = Global.PaperManagement.My.Resources.Resources.ParceiroCor
        Me.btnParceria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnParceria.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParceria.ForeColor = System.Drawing.Color.White
        Me.btnParceria.Image = Global.PaperManagement.My.Resources.Resources.Parceiro
        Me.btnParceria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParceria.Location = New System.Drawing.Point(1206, 765)
        Me.btnParceria.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnParceria.Name = "btnParceria"
        Me.btnParceria.Size = New System.Drawing.Size(543, 223)
        Me.btnParceria.TabIndex = 29
        Me.btnParceria.Text = "    Parceiro"
        Me.btnParceria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnParceria.UseVisualStyleBackColor = True
        '
        'btnFuncionario
        '
        Me.btnFuncionario.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FuncionarioCor
        Me.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFuncionario.ForeColor = System.Drawing.Color.White
        Me.btnFuncionario.Image = Global.PaperManagement.My.Resources.Resources.Funcionario
        Me.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFuncionario.Location = New System.Drawing.Point(1206, 514)
        Me.btnFuncionario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFuncionario.Name = "btnFuncionario"
        Me.btnFuncionario.Size = New System.Drawing.Size(543, 223)
        Me.btnFuncionario.TabIndex = 28
        Me.btnFuncionario.Text = "   Funcionário"
        Me.btnFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFuncionario.UseVisualStyleBackColor = True
        '
        'btnGerenciarSenha
        '
        Me.btnGerenciarSenha.BackgroundImage = Global.PaperManagement.My.Resources.Resources.GerenciarSenhasCor
        Me.btnGerenciarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGerenciarSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGerenciarSenha.ForeColor = System.Drawing.Color.White
        Me.btnGerenciarSenha.Image = Global.PaperManagement.My.Resources.Resources.GerenciarSenhas
        Me.btnGerenciarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGerenciarSenha.Location = New System.Drawing.Point(632, 1015)
        Me.btnGerenciarSenha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGerenciarSenha.Name = "btnGerenciarSenha"
        Me.btnGerenciarSenha.Size = New System.Drawing.Size(543, 223)
        Me.btnGerenciarSenha.TabIndex = 27
        Me.btnGerenciarSenha.Text = "    Gerenciar"
        Me.btnGerenciarSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGerenciarSenha.UseVisualStyleBackColor = True
        '
        'btnEstoque
        '
        Me.btnEstoque.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstoque.ForeColor = System.Drawing.Color.White
        Me.btnEstoque.Image = Global.PaperManagement.My.Resources.Resources.Estoque
        Me.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEstoque.Location = New System.Drawing.Point(632, 765)
        Me.btnEstoque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEstoque.Name = "btnEstoque"
        Me.btnEstoque.Size = New System.Drawing.Size(543, 223)
        Me.btnEstoque.TabIndex = 26
        Me.btnEstoque.Text = "    Estoque"
        Me.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEstoque.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.BackgroundImage = Global.PaperManagement.My.Resources.Resources.ClientesCor
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.ForeColor = System.Drawing.Color.White
        Me.btnCliente.Image = Global.PaperManagement.My.Resources.Resources.Cliente
        Me.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCliente.Location = New System.Drawing.Point(632, 514)
        Me.btnCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(543, 223)
        Me.btnCliente.TabIndex = 25
        Me.btnCliente.Text = "   Cliente"
        Me.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnFechamento
        '
        Me.btnFechamento.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnFechamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechamento.ForeColor = System.Drawing.Color.White
        Me.btnFechamento.Image = Global.PaperManagement.My.Resources.Resources.Fechamento
        Me.btnFechamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechamento.Location = New System.Drawing.Point(54, 1015)
        Me.btnFechamento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFechamento.Name = "btnFechamento"
        Me.btnFechamento.Size = New System.Drawing.Size(543, 223)
        Me.btnFechamento.TabIndex = 24
        Me.btnFechamento.Text = "   Fechamento"
        Me.btnFechamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechamento.UseVisualStyleBackColor = True
        '
        'btnFornecedor
        '
        Me.btnFornecedor.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FornecedorCor
        Me.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFornecedor.ForeColor = System.Drawing.Color.White
        Me.btnFornecedor.Image = Global.PaperManagement.My.Resources.Resources.Fornecedor
        Me.btnFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFornecedor.Location = New System.Drawing.Point(54, 765)
        Me.btnFornecedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFornecedor.Name = "btnFornecedor"
        Me.btnFornecedor.Size = New System.Drawing.Size(543, 223)
        Me.btnFornecedor.TabIndex = 23
        Me.btnFornecedor.Text = "   Fornecedor"
        Me.btnFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFornecedor.UseVisualStyleBackColor = True
        '
        'btnVenda
        '
        Me.btnVenda.BackgroundImage = Global.PaperManagement.My.Resources.Resources.VendaCor
        Me.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenda.ForeColor = System.Drawing.Color.White
        Me.btnVenda.Image = Global.PaperManagement.My.Resources.Resources.Venda
        Me.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVenda.Location = New System.Drawing.Point(54, 514)
        Me.btnVenda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVenda.Name = "btnVenda"
        Me.btnVenda.Size = New System.Drawing.Size(543, 223)
        Me.btnVenda.TabIndex = 22
        Me.btnVenda.Text = "   Venda"
        Me.btnVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVenda.UseVisualStyleBackColor = True
        '
        'listNot
        '
        Me.listNot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listNot.FormattingEnabled = True
        Me.listNot.ItemHeight = 29
        Me.listNot.Location = New System.Drawing.Point(506, 132)
        Me.listNot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.listNot.Name = "listNot"
        Me.listNot.Size = New System.Drawing.Size(1242, 207)
        Me.listNot.TabIndex = 32
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(1258, 62)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(228, 37)
        Me.lblUser.TabIndex = 33
        Me.lblUser.Text = "Olá, Developer"
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.ClientesCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources._Exit
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(1526, 52)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(224, 65)
        Me.btnSair.TabIndex = 34
        Me.btnSair.Text = "Sair/Logout"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FUNDO_AZUL_CLARO
        Me.ClientSize = New System.Drawing.Size(1848, 1094)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.listNot)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnFinanceiro)
        Me.Controls.Add(Me.btnParceria)
        Me.Controls.Add(Me.btnFuncionario)
        Me.Controls.Add(Me.btnGerenciarSenha)
        Me.Controls.Add(Me.btnEstoque)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnFechamento)
        Me.Controls.Add(Me.btnFornecedor)
        Me.Controls.Add(Me.btnVenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paper Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFinanceiro As Button
    Friend WithEvents btnParceria As Button
    Friend WithEvents btnFuncionario As Button
    Friend WithEvents btnGerenciarSenha As Button
    Friend WithEvents btnEstoque As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnFechamento As Button
    Friend WithEvents btnFornecedor As Button
    Friend WithEvents btnVenda As Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents listNot As System.Windows.Forms.ListBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
