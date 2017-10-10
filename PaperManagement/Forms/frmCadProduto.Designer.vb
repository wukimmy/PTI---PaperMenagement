<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProduto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblForn = New System.Windows.Forms.Label()
        Me.lblfam = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodPro = New System.Windows.Forms.TextBox()
        Me.txtCodBar = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtFabri = New System.Windows.Forms.TextBox()
        Me.txtPrecAta = New System.Windows.Forms.TextBox()
        Me.txtQtdAtac = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecVar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQtdAtu = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQtdMin = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtQtdMax = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAddFami = New System.Windows.Forms.Button()
        Me.cboFam = New System.Windows.Forms.ComboBox()
        Me.cboforn = New System.Windows.Forms.ComboBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.grpLocalizar = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLocalizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código do Produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(363, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código de Barra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 195)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome do Produto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fabricante"
        '
        'lblForn
        '
        Me.lblForn.AutoSize = True
        Me.lblForn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForn.Location = New System.Drawing.Point(363, 105)
        Me.lblForn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForn.Name = "lblForn"
        Me.lblForn.Size = New System.Drawing.Size(139, 29)
        Me.lblForn.TabIndex = 4
        Me.lblForn.Text = "Fornecedor"
        '
        'lblfam
        '
        Me.lblfam.AutoSize = True
        Me.lblfam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfam.Location = New System.Drawing.Point(18, 282)
        Me.lblfam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfam.Name = "lblfam"
        Me.lblfam.Size = New System.Drawing.Size(92, 29)
        Me.lblfam.TabIndex = 5
        Me.lblfam.Text = "Familia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(706, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 29)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Preço Atacado"
        '
        'txtCodPro
        '
        Me.txtCodPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPro.Location = New System.Drawing.Point(24, 49)
        Me.txtCodPro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodPro.Name = "txtCodPro"
        Me.txtCodPro.ReadOnly = True
        Me.txtCodPro.Size = New System.Drawing.Size(286, 35)
        Me.txtCodPro.TabIndex = 7
        '
        'txtCodBar
        '
        Me.txtCodBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBar.Location = New System.Drawing.Point(369, 49)
        Me.txtCodBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodBar.Name = "txtCodBar"
        Me.txtCodBar.Size = New System.Drawing.Size(286, 35)
        Me.txtCodBar.TabIndex = 1
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(24, 231)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(631, 35)
        Me.txtNom.TabIndex = 3
        '
        'txtFabri
        '
        Me.txtFabri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFabri.Location = New System.Drawing.Point(24, 142)
        Me.txtFabri.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFabri.Name = "txtFabri"
        Me.txtFabri.Size = New System.Drawing.Size(286, 35)
        Me.txtFabri.TabIndex = 2
        '
        'txtPrecAta
        '
        Me.txtPrecAta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecAta.Location = New System.Drawing.Point(712, 49)
        Me.txtPrecAta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrecAta.Name = "txtPrecAta"
        Me.txtPrecAta.Size = New System.Drawing.Size(182, 35)
        Me.txtPrecAta.TabIndex = 6
        '
        'txtQtdAtac
        '
        Me.txtQtdAtac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdAtac.Location = New System.Drawing.Point(712, 142)
        Me.txtQtdAtac.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQtdAtac.Name = "txtQtdAtac"
        Me.txtQtdAtac.Size = New System.Drawing.Size(182, 35)
        Me.txtQtdAtac.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(706, 105)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 29)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Qtd Atacado"
        '
        'txtPrecVar
        '
        Me.txtPrecVar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecVar.Location = New System.Drawing.Point(712, 231)
        Me.txtPrecVar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrecVar.Name = "txtPrecVar"
        Me.txtPrecVar.Size = New System.Drawing.Size(182, 35)
        Me.txtPrecVar.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(706, 195)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 29)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Preço Varejo"
        '
        'txtQtdAtu
        '
        Me.txtQtdAtu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdAtu.Location = New System.Drawing.Point(326, 318)
        Me.txtQtdAtu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQtdAtu.Name = "txtQtdAtu"
        Me.txtQtdAtu.Size = New System.Drawing.Size(182, 35)
        Me.txtQtdAtu.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 282)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 29)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Qtd Atual"
        '
        'txtQtdMin
        '
        Me.txtQtdMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdMin.Location = New System.Drawing.Point(519, 318)
        Me.txtQtdMin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQtdMin.Name = "txtQtdMin"
        Me.txtQtdMin.Size = New System.Drawing.Size(182, 35)
        Me.txtQtdMin.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(513, 282)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 29)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Qtd Mínima"
        '
        'txtQtdMax
        '
        Me.txtQtdMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdMax.Location = New System.Drawing.Point(712, 318)
        Me.txtQtdMax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQtdMax.Name = "txtQtdMax"
        Me.txtQtdMax.Size = New System.Drawing.Size(182, 35)
        Me.txtQtdMax.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(706, 282)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 29)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Qtd Máxima"
        '
        'dtGrid
        '
        Me.dtGrid.AllowUserToAddRows = False
        Me.dtGrid.AllowUserToDeleteRows = False
        Me.dtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.dtGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtGrid.Location = New System.Drawing.Point(24, 391)
        Me.dtGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtGrid.Name = "dtGrid"
        Me.dtGrid.RowHeadersVisible = False
        Me.dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrid.Size = New System.Drawing.Size(1446, 442)
        Me.dtGrid.TabIndex = 110
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "proCod"
        Me.Column1.HeaderText = "Código do Produto"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "proCodBarra"
        Me.Column2.HeaderText = "Código de Barra"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "proDesc"
        Me.Column3.HeaderText = "Nome do Produto"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "proFabri"
        Me.Column4.HeaderText = "Fabricante"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "fornCod"
        Me.Column5.HeaderText = "Fornecedor"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "famiCod"
        Me.Column6.HeaderText = "Familia"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "proPrecoAtacado"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column7.HeaderText = "Preço Atacado"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "proQtdAtacado"
        Me.Column8.HeaderText = "Qtd Atacado"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "proPrecoVarejo"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column9.HeaderText = "Preço Varejo"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "proQtdAtual"
        Me.Column10.HeaderText = "Qtd Atual"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "proQtdMin"
        Me.Column11.HeaderText = "Qtd Mínima"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "proQtdMax"
        Me.Column12.HeaderText = "Qtd Máxima"
        Me.Column12.Name = "Column12"
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.Image = Global.PaperManagement.My.Resources.Resources.NovoSmall
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(1244, 32)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(210, 58)
        Me.btnNovo.TabIndex = 133
        Me.btnNovo.Text = "  Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = Global.PaperManagement.My.Resources.Resources.EditarSmall
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(1244, 168)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(210, 58)
        Me.btnEditar.TabIndex = 132
        Me.btnEditar.Text = "  Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = Global.PaperManagement.My.Resources.Resources.ExcluirrSmall
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(1244, 235)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(210, 58)
        Me.btnExcluir.TabIndex = 131
        Me.btnExcluir.Text = "  Excluir"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.ForeColor = System.Drawing.Color.White
        Me.btnGravar.Image = Global.PaperManagement.My.Resources.Resources.GravarSmall
        Me.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGravar.Location = New System.Drawing.Point(1244, 100)
        Me.btnGravar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(210, 58)
        Me.btnGravar.TabIndex = 130
        Me.btnGravar.Text = "  Gravar"
        Me.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.PaperManagement.My.Resources.Resources.CancelarSmall
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(1244, 302)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(210, 58)
        Me.btnCancelar.TabIndex = 136
        Me.btnCancelar.Text = "  Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAddFami
        '
        Me.btnAddFami.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnAddFami.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFami.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFami.ForeColor = System.Drawing.Color.White
        Me.btnAddFami.Location = New System.Drawing.Point(246, 318)
        Me.btnAddFami.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddFami.Name = "btnAddFami"
        Me.btnAddFami.Size = New System.Drawing.Size(70, 42)
        Me.btnAddFami.TabIndex = 139
        Me.btnAddFami.Text = "Add"
        Me.btnAddFami.UseVisualStyleBackColor = True
        '
        'cboFam
        '
        Me.cboFam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFam.FormattingEnabled = True
        Me.cboFam.Location = New System.Drawing.Point(24, 318)
        Me.cboFam.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboFam.Name = "cboFam"
        Me.cboFam.Size = New System.Drawing.Size(211, 37)
        Me.cboFam.TabIndex = 140
        '
        'cboforn
        '
        Me.cboforn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboforn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboforn.FormattingEnabled = True
        Me.cboforn.Location = New System.Drawing.Point(369, 142)
        Me.cboforn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboforn.Name = "cboforn"
        Me.cboforn.Size = New System.Drawing.Size(286, 37)
        Me.cboforn.TabIndex = 141
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(24, 860)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 151
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'grpLocalizar
        '
        Me.grpLocalizar.Controls.Add(Me.btnOK)
        Me.grpLocalizar.Controls.Add(Me.txtLoc)
        Me.grpLocalizar.Controls.Add(Me.Label5)
        Me.grpLocalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLocalizar.Location = New System.Drawing.Point(957, 14)
        Me.grpLocalizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLocalizar.Name = "grpLocalizar"
        Me.grpLocalizar.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLocalizar.Size = New System.Drawing.Size(226, 348)
        Me.grpLocalizar.TabIndex = 152
        Me.grpLocalizar.TabStop = False
        Me.grpLocalizar.Text = "Localizar"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(141, 278)
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
        Me.txtLoc.Location = New System.Drawing.Point(16, 149)
        Me.txtLoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLoc.Multiline = True
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(192, 118)
        Me.txtLoc.TabIndex = 112
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 109)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Pesquise por nome " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ou código (interno/barra) do " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "produto:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmCadProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1488, 945)
        Me.Controls.Add(Me.grpLocalizar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.cboforn)
        Me.Controls.Add(Me.cboFam)
        Me.Controls.Add(Me.btnAddFami)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.dtGrid)
        Me.Controls.Add(Me.txtQtdMax)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtQtdMin)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtQtdAtu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPrecVar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtQtdAtac)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPrecAta)
        Me.Controls.Add(Me.txtFabri)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtCodBar)
        Me.Controls.Add(Me.txtCodPro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblfam)
        Me.Controls.Add(Me.lblForn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCadProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produto"
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLocalizar.ResumeLayout(False)
        Me.grpLocalizar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblForn As System.Windows.Forms.Label
    Friend WithEvents lblfam As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCodPro As System.Windows.Forms.TextBox
    Friend WithEvents txtCodBar As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtFabri As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecAta As System.Windows.Forms.TextBox
    Friend WithEvents txtQtdAtac As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrecVar As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtQtdAtu As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtQtdMin As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtQtdMax As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAddFami As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboFam As System.Windows.Forms.ComboBox
    Friend WithEvents cboforn As System.Windows.Forms.ComboBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents grpLocalizar As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
