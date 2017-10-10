<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscaFornecedor))
        Me.dtGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAddFornecedor = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtGrid
        '
        Me.dtGrid.AllowUserToAddRows = False
        Me.dtGrid.AllowUserToDeleteRows = False
        Me.dtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dtGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtGrid.Location = New System.Drawing.Point(48, 203)
        Me.dtGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtGrid.Name = "dtGrid"
        Me.dtGrid.RowHeadersVisible = False
        Me.dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrid.Size = New System.Drawing.Size(1180, 555)
        Me.dtGrid.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "fornCod"
        Me.Column1.HeaderText = "Código Fornecedor"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "fornNom"
        Me.Column2.HeaderText = "Fornecedor"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "fornTel"
        Me.Column3.HeaderText = "Telefone"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "fornEmail"
        Me.Column4.HeaderText = "Email"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "proCod"
        Me.Column5.HeaderText = "Código Produto"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "proCodBarra"
        Me.Column6.HeaderText = "Código de Barras"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "proDesc"
        Me.Column7.HeaderText = "Produto"
        Me.Column7.Name = "Column7"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLoc)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(108, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1050, 162)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Procurar Fornecedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Pesquise por código ou nome:"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(28, 82)
        Me.txtLoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(757, 35)
        Me.txtLoc.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FornecedorCor
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.PaperManagement.My.Resources.Resources.BuscarSmall
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(836, 72)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(180, 58)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "  Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAddFornecedor
        '
        Me.btnAddFornecedor.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FornecedorCor
        Me.btnAddFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFornecedor.ForeColor = System.Drawing.Color.White
        Me.btnAddFornecedor.Location = New System.Drawing.Point(1002, 774)
        Me.btnAddFornecedor.Name = "btnAddFornecedor"
        Me.btnAddFornecedor.Size = New System.Drawing.Size(226, 58)
        Me.btnAddFornecedor.TabIndex = 3
        Me.btnAddFornecedor.Text = "Add Fornecedor"
        Me.btnAddFornecedor.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FornecedorCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(48, 774)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmBuscaFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 898)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnAddFornecedor)
        Me.Controls.Add(Me.dtGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuscaFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Fornecedores"
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtGrid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAddFornecedor As Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
