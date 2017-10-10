<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSenha))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.chkVisualizarSenha = New System.Windows.Forms.CheckBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 29)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Login"
        '
        'txtLogin
        '
        Me.txtLogin.BackColor = System.Drawing.Color.White
        Me.txtLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.FormattingEnabled = True
        Me.txtLogin.Items.AddRange(New Object() {"GLOBAL", "ADMIN"})
        Me.txtLogin.Location = New System.Drawing.Point(152, 95)
        Me.txtLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(268, 37)
        Me.txtLogin.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(146, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 29)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Nova Senha"
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(150, 200)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(270, 35)
        Me.txtSenha.TabIndex = 35
        '
        'btnAtualizar
        '
        Me.btnAtualizar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.GerenciarSenhasCor
        Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizar.ForeColor = System.Drawing.Color.White
        Me.btnAtualizar.Location = New System.Drawing.Point(152, 303)
        Me.btnAtualizar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(272, 58)
        Me.btnAtualizar.TabIndex = 143
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'chkVisualizarSenha
        '
        Me.chkVisualizarSenha.AutoSize = True
        Me.chkVisualizarSenha.Location = New System.Drawing.Point(150, 249)
        Me.chkVisualizarSenha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkVisualizarSenha.Name = "chkVisualizarSenha"
        Me.chkVisualizarSenha.Size = New System.Drawing.Size(154, 24)
        Me.chkVisualizarSenha.TabIndex = 144
        Me.chkVisualizarSenha.Text = "Visualizar Senha"
        Me.chkVisualizarSenha.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.GerenciarSenhasCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(38, 431)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 153
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 522)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.chkVisualizarSenha)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Senhas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents chkVisualizarSenha As System.Windows.Forms.CheckBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
