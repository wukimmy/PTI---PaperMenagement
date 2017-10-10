<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLancaDespesa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLancaDespesa))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grpPago = New System.Windows.Forms.GroupBox()
        Me.rbtNao = New System.Windows.Forms.RadioButton()
        Me.rbtSim = New System.Windows.Forms.RadioButton()
        Me.txtCodLan = New System.Windows.Forms.TextBox()
        Me.txtCodDesp = New System.Windows.Forms.TextBox()
        Me.TxtValorDesp = New System.Windows.Forms.TextBox()
        Me.dtpDataVenci = New System.Windows.Forms.DateTimePicker()
        Me.dtGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboDesp = New System.Windows.Forms.ComboBox()
        Me.grpLocalizar = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.grpPago.SuspendLayout()
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLocalizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código do lançamento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(224, 29)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Código da despesa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(422, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(201, 29)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Valor da despesa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(422, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(225, 29)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Data de vencimento"
        '
        'grpPago
        '
        Me.grpPago.Controls.Add(Me.rbtNao)
        Me.grpPago.Controls.Add(Me.rbtSim)
        Me.grpPago.Enabled = False
        Me.grpPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPago.Location = New System.Drawing.Point(22, 208)
        Me.grpPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpPago.Name = "grpPago"
        Me.grpPago.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpPago.Size = New System.Drawing.Size(338, 85)
        Me.grpPago.TabIndex = 4
        Me.grpPago.TabStop = False
        Me.grpPago.Text = "Conta paga"
        '
        'rbtNao
        '
        Me.rbtNao.AutoSize = True
        Me.rbtNao.Location = New System.Drawing.Point(225, 35)
        Me.rbtNao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtNao.Name = "rbtNao"
        Me.rbtNao.Size = New System.Drawing.Size(83, 33)
        Me.rbtNao.TabIndex = 1
        Me.rbtNao.TabStop = True
        Me.rbtNao.Text = "Não"
        Me.rbtNao.UseVisualStyleBackColor = True
        '
        'rbtSim
        '
        Me.rbtSim.AutoSize = True
        Me.rbtSim.Location = New System.Drawing.Point(32, 35)
        Me.rbtSim.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtSim.Name = "rbtSim"
        Me.rbtSim.Size = New System.Drawing.Size(80, 33)
        Me.rbtSim.TabIndex = 0
        Me.rbtSim.TabStop = True
        Me.rbtSim.Text = "Sim"
        Me.rbtSim.UseVisualStyleBackColor = True
        '
        'txtCodLan
        '
        Me.txtCodLan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodLan.Location = New System.Drawing.Point(22, 49)
        Me.txtCodLan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodLan.Name = "txtCodLan"
        Me.txtCodLan.ReadOnly = True
        Me.txtCodLan.Size = New System.Drawing.Size(251, 35)
        Me.txtCodLan.TabIndex = 19
        Me.txtCodLan.Tag = "x"
        '
        'txtCodDesp
        '
        Me.txtCodDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDesp.Location = New System.Drawing.Point(22, 148)
        Me.txtCodDesp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodDesp.Name = "txtCodDesp"
        Me.txtCodDesp.Size = New System.Drawing.Size(251, 35)
        Me.txtCodDesp.TabIndex = 1
        '
        'TxtValorDesp
        '
        Me.TxtValorDesp.AcceptsReturn = True
        Me.TxtValorDesp.Enabled = False
        Me.TxtValorDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValorDesp.Location = New System.Drawing.Point(428, 241)
        Me.TxtValorDesp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtValorDesp.Name = "TxtValorDesp"
        Me.TxtValorDesp.Size = New System.Drawing.Size(219, 35)
        Me.TxtValorDesp.TabIndex = 3
        '
        'dtpDataVenci
        '
        Me.dtpDataVenci.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataVenci.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataVenci.Location = New System.Drawing.Point(426, 49)
        Me.dtpDataVenci.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDataVenci.Name = "dtpDataVenci"
        Me.dtpDataVenci.Size = New System.Drawing.Size(220, 35)
        Me.dtpDataVenci.TabIndex = 2
        '
        'dtGrid
        '
        Me.dtGrid.AllowUserToAddRows = False
        Me.dtGrid.AllowUserToDeleteRows = False
        Me.dtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column7, Me.Column5})
        Me.dtGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtGrid.Location = New System.Drawing.Point(22, 315)
        Me.dtGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtGrid.Name = "dtGrid"
        Me.dtGrid.ReadOnly = True
        Me.dtGrid.RowHeadersVisible = False
        Me.dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrid.Size = New System.Drawing.Size(626, 360)
        Me.dtGrid.TabIndex = 107
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "lancaDesCod"
        Me.Column1.HeaderText = "Código Lançamento"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "despDescri"
        Me.Column2.HeaderText = "Despesa"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "lancaDesVal"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Valor"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "lancaDesVenci"
        Me.Column7.HeaderText = "Vencimento da conta"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "lancaDesStatus"
        Me.Column5.HeaderText = "Status"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'cboDesp
        '
        Me.cboDesp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDesp.FormattingEnabled = True
        Me.cboDesp.Location = New System.Drawing.Point(304, 148)
        Me.cboDesp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboDesp.Name = "cboDesp"
        Me.cboDesp.Size = New System.Drawing.Size(342, 37)
        Me.cboDesp.TabIndex = 148
        '
        'grpLocalizar
        '
        Me.grpLocalizar.Controls.Add(Me.btnOK)
        Me.grpLocalizar.Controls.Add(Me.txtLoc)
        Me.grpLocalizar.Controls.Add(Me.Label3)
        Me.grpLocalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLocalizar.Location = New System.Drawing.Point(687, 315)
        Me.grpLocalizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLocalizar.Name = "grpLocalizar"
        Me.grpLocalizar.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLocalizar.Size = New System.Drawing.Size(226, 360)
        Me.grpLocalizar.TabIndex = 159
        Me.grpLocalizar.TabStop = False
        Me.grpLocalizar.Text = "Localizar"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(141, 280)
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
        Me.txtLoc.Location = New System.Drawing.Point(17, 135)
        Me.txtLoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLoc.Multiline = True
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(192, 118)
        Me.txtLoc.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 82)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pesquise por código do lançamento despesa:"
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FinanceiroCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(22, 701)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 59)
        Me.btnSair.TabIndex = 158
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FinanceiroCor
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.PaperManagement.My.Resources.Resources.CancelarSmall
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(698, 250)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(210, 58)
        Me.btnCancelar.TabIndex = 114
        Me.btnCancelar.Text = "  Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FinanceiroCor
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = Global.PaperManagement.My.Resources.Resources.ExcluirrSmall
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(698, 190)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(210, 58)
        Me.btnExcluir.TabIndex = 115
        Me.btnExcluir.Text = "  Excluir"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FinanceiroCor
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.Image = Global.PaperManagement.My.Resources.Resources.NovoSmall
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(698, 11)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(210, 58)
        Me.btnNovo.TabIndex = 113
        Me.btnNovo.Text = "  Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FinanceiroCor
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = Global.PaperManagement.My.Resources.Resources.EditarSmall
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(698, 130)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(210, 58)
        Me.btnEditar.TabIndex = 161
        Me.btnEditar.Text = "  Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FinanceiroCor
        Me.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.ForeColor = System.Drawing.Color.White
        Me.btnGravar.Image = Global.PaperManagement.My.Resources.Resources.GravarSmall
        Me.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGravar.Location = New System.Drawing.Point(698, 70)
        Me.btnGravar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(210, 58)
        Me.btnGravar.TabIndex = 160
        Me.btnGravar.Text = "  Gravar"
        Me.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'frmLancaDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 806)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grpLocalizar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.cboDesp)
        Me.Controls.Add(Me.dtGrid)
        Me.Controls.Add(Me.dtpDataVenci)
        Me.Controls.Add(Me.TxtValorDesp)
        Me.Controls.Add(Me.txtCodDesp)
        Me.Controls.Add(Me.txtCodLan)
        Me.Controls.Add(Me.grpPago)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmLancaDespesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançar Despesa"
        Me.grpPago.ResumeLayout(False)
        Me.grpPago.PerformLayout()
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLocalizar.ResumeLayout(False)
        Me.grpLocalizar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grpPago As System.Windows.Forms.GroupBox
    Friend WithEvents rbtNao As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSim As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodLan As System.Windows.Forms.TextBox
    Friend WithEvents txtCodDesp As System.Windows.Forms.TextBox
    Friend WithEvents TxtValorDesp As System.Windows.Forms.TextBox
    Friend WithEvents dtpDataVenci As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboDesp As System.Windows.Forms.ComboBox
    Friend WithEvents grpLocalizar As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGravar As Button
End Class
