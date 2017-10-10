<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadSaidaProdInterno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadSaidaProdInterno))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFunc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.dtGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNomFun = New System.Windows.Forms.TextBox()
        Me.txtNomProd = New System.Windows.Forms.TextBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.grpLocalizar = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLocalizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(450, 186)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 29)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Qtd"
        '
        'txtQtd
        '
        Me.txtQtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.Location = New System.Drawing.Point(456, 220)
        Me.txtQtd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(109, 35)
        Me.txtQtd.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(330, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 29)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 186)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 29)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Produto"
        '
        'txtProd
        '
        Me.txtProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProd.Location = New System.Drawing.Point(24, 220)
        Me.txtProd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(130, 35)
        Me.txtProd.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 29)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Funcionário"
        '
        'txtFunc
        '
        Me.txtFunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFunc.Location = New System.Drawing.Point(24, 137)
        Me.txtFunc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFunc.Name = "txtFunc"
        Me.txtFunc.Size = New System.Drawing.Size(130, 35)
        Me.txtFunc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Código"
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(24, 49)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.ReadOnly = True
        Me.txtCod.Size = New System.Drawing.Size(229, 35)
        Me.txtCod.TabIndex = 42
        '
        'txtData
        '
        Me.txtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtData.Location = New System.Drawing.Point(336, 46)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(229, 35)
        Me.txtData.TabIndex = 148
        Me.txtData.Value = New Date(2016, 7, 31, 0, 0, 0, 0)
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FuncionarioCor
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.PaperManagement.My.Resources.Resources.CancelarSmall
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(624, 254)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(210, 58)
        Me.btnCancelar.TabIndex = 156
        Me.btnCancelar.Text = "  Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FuncionarioCor
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = Global.PaperManagement.My.Resources.Resources.ExcluirrSmall
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(624, 194)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(210, 58)
        Me.btnExcluir.TabIndex = 153
        Me.btnExcluir.Text = "  Excluir"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FuncionarioCor
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = Global.PaperManagement.My.Resources.Resources.EditarSmall
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(624, 134)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(210, 58)
        Me.btnEditar.TabIndex = 152
        Me.btnEditar.Text = "  Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FuncionarioCor
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.Image = Global.PaperManagement.My.Resources.Resources.NovoSmall
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(624, 14)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(210, 58)
        Me.btnNovo.TabIndex = 140
        Me.btnNovo.Text = "  Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FuncionarioCor
        Me.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.ForeColor = System.Drawing.Color.White
        Me.btnGravar.Image = Global.PaperManagement.My.Resources.Resources.GravarSmall
        Me.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGravar.Location = New System.Drawing.Point(624, 74)
        Me.btnGravar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(210, 58)
        Me.btnGravar.TabIndex = 4
        Me.btnGravar.Text = "  Gravar"
        Me.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'dtGrid
        '
        Me.dtGrid.AllowUserToAddRows = False
        Me.dtGrid.AllowUserToDeleteRows = False
        Me.dtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dtGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtGrid.Location = New System.Drawing.Point(24, 320)
        Me.dtGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtGrid.Name = "dtGrid"
        Me.dtGrid.RowHeadersVisible = False
        Me.dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrid.Size = New System.Drawing.Size(543, 335)
        Me.dtGrid.TabIndex = 157
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "saidaProIntCod"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "funCod"
        Me.Column2.HeaderText = "Funcionario"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "proCod"
        Me.Column3.HeaderText = "Produto"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "saidaProIntQtd"
        Me.Column4.HeaderText = "Qtd"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "saidaProIntData"
        Me.Column5.HeaderText = "Data"
        Me.Column5.Name = "Column5"
        '
        'txtNomFun
        '
        Me.txtNomFun.Enabled = False
        Me.txtNomFun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomFun.Location = New System.Drawing.Point(177, 137)
        Me.txtNomFun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNomFun.Name = "txtNomFun"
        Me.txtNomFun.ReadOnly = True
        Me.txtNomFun.Size = New System.Drawing.Size(388, 35)
        Me.txtNomFun.TabIndex = 158
        '
        'txtNomProd
        '
        Me.txtNomProd.Enabled = False
        Me.txtNomProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomProd.Location = New System.Drawing.Point(165, 220)
        Me.txtNomProd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNomProd.Name = "txtNomProd"
        Me.txtNomProd.ReadOnly = True
        Me.txtNomProd.Size = New System.Drawing.Size(280, 35)
        Me.txtNomProd.TabIndex = 159
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FuncionarioCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(24, 680)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 160
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'grpLocalizar
        '
        Me.grpLocalizar.Controls.Add(Me.btnOK)
        Me.grpLocalizar.Controls.Add(Me.txtLoc)
        Me.grpLocalizar.Controls.Add(Me.Label6)
        Me.grpLocalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLocalizar.Location = New System.Drawing.Point(608, 320)
        Me.grpLocalizar.Name = "grpLocalizar"
        Me.grpLocalizar.Size = New System.Drawing.Size(226, 335)
        Me.grpLocalizar.TabIndex = 161
        Me.grpLocalizar.TabStop = False
        Me.grpLocalizar.Text = "Localizar"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(141, 248)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(69, 49)
        Me.btnOK.TabIndex = 112
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'txtLoc
        '
        Me.txtLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoc.Location = New System.Drawing.Point(16, 117)
        Me.txtLoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLoc.Multiline = True
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(192, 118)
        Me.txtLoc.TabIndex = 112
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 65)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Pesquise por código da saída:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmCadSaidaProdInterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 762)
        Me.Controls.Add(Me.grpLocalizar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.txtNomProd)
        Me.Controls.Add(Me.txtNomFun)
        Me.Controls.Add(Me.dtGrid)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQtd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFunc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCadSaidaProdInterno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saída de Produto Interno"
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLocalizar.ResumeLayout(False)
        Me.grpLocalizar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQtd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFunc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents txtData As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents dtGrid As System.Windows.Forms.DataGridView
    Friend WithEvents txtNomFun As System.Windows.Forms.TextBox
    Friend WithEvents txtNomProd As System.Windows.Forms.TextBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents grpLocalizar As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
