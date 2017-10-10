<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadVenda
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadVenda))
        Me.cboFun = New System.Windows.Forms.ComboBox()
        Me.lblCli = New System.Windows.Forms.Label()
        Me.txtTot = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodPro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLocPro = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomPro = New System.Windows.Forms.TextBox()
        Me.txtPrePro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQtdPro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSubPro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtCupon = New System.Windows.Forms.RadioButton()
        Me.rbtCartao = New System.Windows.Forms.RadioButton()
        Me.rbtDinheiro = New System.Windows.Forms.RadioButton()
        Me.cbmTipo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLimparTab = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnAdicio = New System.Windows.Forms.Button()
        Me.txtCli = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboFun
        '
        Me.cboFun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFun.FormattingEnabled = True
        Me.cboFun.Location = New System.Drawing.Point(686, 75)
        Me.cboFun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboFun.Name = "cboFun"
        Me.cboFun.Size = New System.Drawing.Size(348, 37)
        Me.cboFun.TabIndex = 130
        '
        'lblCli
        '
        Me.lblCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCli.Location = New System.Drawing.Point(514, 171)
        Me.lblCli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCli.Name = "lblCli"
        Me.lblCli.Size = New System.Drawing.Size(518, 40)
        Me.lblCli.TabIndex = 129
        Me.lblCli.Tag = "x"
        '
        'txtTot
        '
        Me.txtTot.Enabled = False
        Me.txtTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTot.Location = New System.Drawing.Point(885, 712)
        Me.txtTot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTot.Name = "txtTot"
        Me.txtTot.Size = New System.Drawing.Size(148, 40)
        Me.txtTot.TabIndex = 127
        Me.txtTot.Tag = "x"
        Me.txtTot.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(879, 662)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 33)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Código"
        '
        'txtCod
        '
        Me.txtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(44, 77)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(98, 35)
        Me.txtCod.TabIndex = 144
        Me.txtCod.Tag = "x"
        '
        'txtData
        '
        Me.txtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Location = New System.Drawing.Point(190, 77)
        Me.txtData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtData.MaxDate = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.txtData.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(451, 35)
        Me.txtData.TabIndex = 147
        Me.txtData.Tag = "x"
        Me.txtData.Value = New Date(2016, 9, 7, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(184, 43)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 29)
        Me.Label10.TabIndex = 146
        Me.Label10.Text = "Data"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(38, 138)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(177, 29)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "CPF do Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(680, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 29)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Funcionário"
        '
        'txtCodPro
        '
        Me.txtCodPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPro.Location = New System.Drawing.Point(244, 274)
        Me.txtCodPro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodPro.Name = "txtCodPro"
        Me.txtCodPro.Size = New System.Drawing.Size(96, 35)
        Me.txtCodPro.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(240, 238)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 29)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Código"
        '
        'btnLocPro
        '
        Me.btnLocPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocPro.Location = New System.Drawing.Point(350, 268)
        Me.btnLocPro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLocPro.Name = "btnLocPro"
        Me.btnLocPro.Size = New System.Drawing.Size(45, 48)
        Me.btnLocPro.TabIndex = 157
        Me.btnLocPro.Text = "..."
        Me.btnLocPro.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(398, 238)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 29)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "Descrição"
        '
        'txtNomPro
        '
        Me.txtNomPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomPro.Location = New System.Drawing.Point(402, 272)
        Me.txtNomPro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNomPro.Name = "txtNomPro"
        Me.txtNomPro.Size = New System.Drawing.Size(256, 35)
        Me.txtNomPro.TabIndex = 160
        Me.txtNomPro.Tag = "x"
        '
        'txtPrePro
        '
        Me.txtPrePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrePro.Location = New System.Drawing.Point(666, 272)
        Me.txtPrePro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrePro.Name = "txtPrePro"
        Me.txtPrePro.Size = New System.Drawing.Size(96, 35)
        Me.txtPrePro.TabIndex = 163
        Me.txtPrePro.Tag = "x"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(662, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 29)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "Preço"
        '
        'txtQtdPro
        '
        Me.txtQtdPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdPro.Location = New System.Drawing.Point(770, 274)
        Me.txtQtdPro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQtdPro.Name = "txtQtdPro"
        Me.txtQtdPro.Size = New System.Drawing.Size(61, 35)
        Me.txtQtdPro.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(764, 238)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 29)
        Me.Label12.TabIndex = 164
        Me.Label12.Text = "Qtd"
        '
        'txtSubPro
        '
        Me.txtSubPro.Enabled = False
        Me.txtSubPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubPro.Location = New System.Drawing.Point(838, 274)
        Me.txtSubPro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubPro.Name = "txtSubPro"
        Me.txtSubPro.Size = New System.Drawing.Size(102, 35)
        Me.txtSubPro.TabIndex = 167
        Me.txtSubPro.Tag = "x"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(832, 238)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 29)
        Me.Label7.TabIndex = 166
        Me.Label7.Text = "Sub Tot"
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(666, 712)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(164, 40)
        Me.txtDesc.TabIndex = 170
        Me.txtDesc.Tag = ""
        Me.txtDesc.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(660, 662)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 33)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "Desconto(%)"
        '
        'dtGrid
        '
        Me.dtGrid.AllowUserToAddRows = False
        Me.dtGrid.AllowUserToDeleteRows = False
        Me.dtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dtGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtGrid.Location = New System.Drawing.Point(44, 331)
        Me.dtGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtGrid.Name = "dtGrid"
        Me.dtGrid.ReadOnly = True
        Me.dtGrid.RowHeadersVisible = False
        Me.dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrid.Size = New System.Drawing.Size(990, 266)
        Me.dtGrid.TabIndex = 171
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tipo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Código"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Produto"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column8.HeaderText = "Preço"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Quantidade"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column10.HeaderText = "Sub Total"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtCupon)
        Me.GroupBox1.Controls.Add(Me.rbtCartao)
        Me.GroupBox1.Controls.Add(Me.rbtDinheiro)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 662)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(534, 95)
        Me.GroupBox1.TabIndex = 172
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pagamento"
        '
        'rbtCupon
        '
        Me.rbtCupon.AutoSize = True
        Me.rbtCupon.Enabled = False
        Me.rbtCupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCupon.Location = New System.Drawing.Point(398, 45)
        Me.rbtCupon.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbtCupon.Name = "rbtCupon"
        Me.rbtCupon.Size = New System.Drawing.Size(108, 30)
        Me.rbtCupon.TabIndex = 2
        Me.rbtCupon.TabStop = True
        Me.rbtCupon.Text = "Cupom"
        Me.rbtCupon.UseVisualStyleBackColor = True
        '
        'rbtCartao
        '
        Me.rbtCartao.AutoSize = True
        Me.rbtCartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCartao.Location = New System.Drawing.Point(212, 45)
        Me.rbtCartao.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbtCartao.Name = "rbtCartao"
        Me.rbtCartao.Size = New System.Drawing.Size(102, 30)
        Me.rbtCartao.TabIndex = 1
        Me.rbtCartao.TabStop = True
        Me.rbtCartao.Text = "Cartão"
        Me.rbtCartao.UseVisualStyleBackColor = True
        '
        'rbtDinheiro
        '
        Me.rbtDinheiro.AutoSize = True
        Me.rbtDinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDinheiro.Location = New System.Drawing.Point(20, 45)
        Me.rbtDinheiro.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbtDinheiro.Name = "rbtDinheiro"
        Me.rbtDinheiro.Size = New System.Drawing.Size(118, 30)
        Me.rbtDinheiro.TabIndex = 0
        Me.rbtDinheiro.TabStop = True
        Me.rbtDinheiro.Text = "Dinheiro"
        Me.rbtDinheiro.UseVisualStyleBackColor = True
        '
        'cbmTipo
        '
        Me.cbmTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmTipo.Enabled = False
        Me.cbmTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbmTipo.FormattingEnabled = True
        Me.cbmTipo.Items.AddRange(New Object() {"Produto", "Serviço"})
        Me.cbmTipo.Location = New System.Drawing.Point(44, 274)
        Me.cbmTipo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbmTipo.Name = "cbmTipo"
        Me.cbmTipo.Size = New System.Drawing.Size(190, 37)
        Me.cbmTipo.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 238)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 29)
        Me.Label9.TabIndex = 174
        Me.Label9.Text = "Selecione o tipo"
        '
        'txtLimparTab
        '
        Me.txtLimparTab.BackgroundImage = Global.PaperManagement.My.Resources.Resources.VendaCor
        Me.txtLimparTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtLimparTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimparTab.ForeColor = System.Drawing.Color.White
        Me.txtLimparTab.Location = New System.Drawing.Point(44, 606)
        Me.txtLimparTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLimparTab.Name = "txtLimparTab"
        Me.txtLimparTab.Size = New System.Drawing.Size(180, 46)
        Me.txtLimparTab.TabIndex = 175
        Me.txtLimparTab.Text = "Limpar itens"
        Me.txtLimparTab.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.VendaCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(44, 785)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 149
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.VendaCor
        Me.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.ForeColor = System.Drawing.Color.White
        Me.btnGravar.Location = New System.Drawing.Point(806, 785)
        Me.btnGravar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(230, 58)
        Me.btnGravar.TabIndex = 6
        Me.btnGravar.Text = "Efetuar Venda"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnAdicio
        '
        Me.btnAdicio.BackgroundImage = Global.PaperManagement.My.Resources.Resources.VendaCor
        Me.btnAdicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicio.ForeColor = System.Drawing.Color.White
        Me.btnAdicio.Location = New System.Drawing.Point(948, 271)
        Me.btnAdicio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdicio.Name = "btnAdicio"
        Me.btnAdicio.Size = New System.Drawing.Size(86, 48)
        Me.btnAdicio.TabIndex = 5
        Me.btnAdicio.Tag = ""
        Me.btnAdicio.Text = "Add+"
        Me.btnAdicio.UseVisualStyleBackColor = True
        '
        'txtCli
        '
        Me.txtCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCli.Location = New System.Drawing.Point(42, 172)
        Me.txtCli.Mask = "###,###,###-##"
        Me.txtCli.Name = "txtCli"
        Me.txtCli.Size = New System.Drawing.Size(176, 35)
        Me.txtCli.TabIndex = 1
        Me.txtCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'frmCadVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 868)
        Me.Controls.Add(Me.txtCli)
        Me.Controls.Add(Me.txtLimparTab)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbmTipo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtGrid)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSubPro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtQtdPro)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPrePro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNomPro)
        Me.Controls.Add(Me.txtCodPro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLocPro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.btnAdicio)
        Me.Controls.Add(Me.cboFun)
        Me.Controls.Add(Me.lblCli)
        Me.Controls.Add(Me.txtTot)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmCadVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Venda"
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdicio As Button
    Friend WithEvents cboFun As ComboBox
    Friend WithEvents lblCli As Label
    Friend WithEvents txtTot As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents txtData As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSair As Button
    Friend WithEvents btnGravar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodPro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLocPro As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomPro As TextBox
    Friend WithEvents txtPrePro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQtdPro As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSubPro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCupon As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCartao As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDinheiro As System.Windows.Forms.RadioButton
    Friend WithEvents cbmTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLimparTab As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents txtCli As System.Windows.Forms.MaskedTextBox
End Class
