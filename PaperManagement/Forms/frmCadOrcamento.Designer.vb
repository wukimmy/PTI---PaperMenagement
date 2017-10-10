<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadOrcamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadOrcamento))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTot = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtdPro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomPro = New System.Windows.Forms.TextBox()
        Me.dtGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCodOrc = New System.Windows.Forms.TextBox()
        Me.txtCodPro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboPar = New System.Windows.Forms.ComboBox()
        Me.txtPrePro = New System.Windows.Forms.TextBox()
        Me.txtSubPro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.DateTimePicker()
        Me.txtLimparTab = New System.Windows.Forms.Button()
        Me.btnCriar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(282, 142)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 29)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "Descrição"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(732, 842)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 29)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Total"
        '
        'txtTot
        '
        Me.txtTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTot.Location = New System.Drawing.Point(807, 838)
        Me.txtTot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTot.Name = "txtTot"
        Me.txtTot.ReadOnly = True
        Me.txtTot.Size = New System.Drawing.Size(244, 35)
        Me.txtTot.TabIndex = 128
        Me.txtTot.Tag = "x"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(534, 142)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 29)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Preço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(669, 142)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 29)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "Qtd"
        '
        'txtQtdPro
        '
        Me.txtQtdPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdPro.Location = New System.Drawing.Point(675, 178)
        Me.txtQtdPro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQtdPro.Name = "txtQtdPro"
        Me.txtQtdPro.Size = New System.Drawing.Size(109, 35)
        Me.txtQtdPro.TabIndex = 2
        Me.txtQtdPro.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(786, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 29)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Parceiro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Código"
        '
        'txtNomPro
        '
        Me.txtNomPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomPro.Location = New System.Drawing.Point(288, 178)
        Me.txtNomPro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNomPro.Name = "txtNomPro"
        Me.txtNomPro.ReadOnly = True
        Me.txtNomPro.Size = New System.Drawing.Size(224, 35)
        Me.txtNomPro.TabIndex = 131
        Me.txtNomPro.Tag = "x"
        '
        'dtGrid
        '
        Me.dtGrid.AllowUserToAddRows = False
        Me.dtGrid.AllowUserToDeleteRows = False
        Me.dtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column3, Me.Column5})
        Me.dtGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtGrid.Location = New System.Drawing.Point(34, 255)
        Me.dtGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtGrid.Name = "dtGrid"
        Me.dtGrid.RowHeadersVisible = False
        Me.dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrid.Size = New System.Drawing.Size(1018, 555)
        Me.dtGrid.TabIndex = 130
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Produto"
        Me.Column4.Name = "Column4"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantidade"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Preço"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sub Total"
        Me.Column5.Name = "Column5"
        '
        'txtCodOrc
        '
        Me.txtCodOrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodOrc.Location = New System.Drawing.Point(34, 80)
        Me.txtCodOrc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodOrc.Name = "txtCodOrc"
        Me.txtCodOrc.ReadOnly = True
        Me.txtCodOrc.Size = New System.Drawing.Size(206, 35)
        Me.txtCodOrc.TabIndex = 129
        Me.txtCodOrc.Tag = "x"
        '
        'txtCodPro
        '
        Me.txtCodPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPro.Location = New System.Drawing.Point(34, 178)
        Me.txtCodPro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodPro.Name = "txtCodPro"
        Me.txtCodPro.Size = New System.Drawing.Size(206, 35)
        Me.txtCodPro.TabIndex = 1
        Me.txtCodPro.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 142)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(217, 29)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Código do Produto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(282, 45)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 29)
        Me.Label11.TabIndex = 148
        Me.Label11.Text = "Data"
        '
        'cboPar
        '
        Me.cboPar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPar.FormattingEnabled = True
        Me.cboPar.Location = New System.Drawing.Point(792, 82)
        Me.cboPar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboPar.Name = "cboPar"
        Me.cboPar.Size = New System.Drawing.Size(259, 37)
        Me.cboPar.TabIndex = 152
        '
        'txtPrePro
        '
        Me.txtPrePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrePro.Location = New System.Drawing.Point(540, 178)
        Me.txtPrePro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrePro.Name = "txtPrePro"
        Me.txtPrePro.Size = New System.Drawing.Size(109, 35)
        Me.txtPrePro.TabIndex = 164
        Me.txtPrePro.Tag = "x"
        '
        'txtSubPro
        '
        Me.txtSubPro.Enabled = False
        Me.txtSubPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubPro.Location = New System.Drawing.Point(810, 178)
        Me.txtSubPro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubPro.Name = "txtSubPro"
        Me.txtSubPro.Size = New System.Drawing.Size(133, 35)
        Me.txtSubPro.TabIndex = 169
        Me.txtSubPro.Tag = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(804, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 29)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "Sub Tot"
        '
        'txtData
        '
        Me.txtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Location = New System.Drawing.Point(288, 80)
        Me.txtData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtData.MaxDate = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.txtData.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(451, 35)
        Me.txtData.TabIndex = 170
        Me.txtData.Tag = "x"
        Me.txtData.Value = New Date(2016, 9, 7, 0, 0, 0, 0)
        '
        'txtLimparTab
        '
        Me.txtLimparTab.BackgroundImage = Global.PaperManagement.My.Resources.Resources.ParceiroCor
        Me.txtLimparTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtLimparTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimparTab.ForeColor = System.Drawing.Color.White
        Me.txtLimparTab.Location = New System.Drawing.Point(34, 820)
        Me.txtLimparTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLimparTab.Name = "txtLimparTab"
        Me.txtLimparTab.Size = New System.Drawing.Size(180, 46)
        Me.txtLimparTab.TabIndex = 176
        Me.txtLimparTab.Text = "Limpar itens"
        Me.txtLimparTab.UseVisualStyleBackColor = True
        '
        'btnCriar
        '
        Me.btnCriar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.ParceiroCor
        Me.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCriar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCriar.ForeColor = System.Drawing.Color.White
        Me.btnCriar.Location = New System.Drawing.Point(844, 909)
        Me.btnCriar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCriar.Name = "btnCriar"
        Me.btnCriar.Size = New System.Drawing.Size(208, 58)
        Me.btnCriar.TabIndex = 4
        Me.btnCriar.Text = "Criar Orçamento"
        Me.btnCriar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.ParceiroCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(34, 909)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 151
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.ParceiroCor
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.ForeColor = System.Drawing.Color.White
        Me.btnAdicionar.Location = New System.Drawing.Point(968, 175)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(86, 48)
        Me.btnAdicionar.TabIndex = 3
        Me.btnAdicionar.Text = "Add+"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'frmCadOrcamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 992)
        Me.Controls.Add(Me.txtLimparTab)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCriar)
        Me.Controls.Add(Me.txtTot)
        Me.Controls.Add(Me.txtSubPro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrePro)
        Me.Controls.Add(Me.cboPar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCodPro)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQtdPro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomPro)
        Me.Controls.Add(Me.dtGrid)
        Me.Controls.Add(Me.txtCodOrc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCadOrcamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Orçamento"
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnCriar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTot As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQtdPro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomPro As TextBox
    Friend WithEvents dtGrid As DataGridView
    Friend WithEvents txtCodOrc As TextBox
    Friend WithEvents txtCodPro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents cboPar As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrePro As System.Windows.Forms.TextBox
    Friend WithEvents txtSubPro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtData As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLimparTab As System.Windows.Forms.Button
End Class
