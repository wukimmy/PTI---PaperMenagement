<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstoque))
        Me.btnProduto = New System.Windows.Forms.Button()
        Me.btnServico = New System.Windows.Forms.Button()
        Me.dtGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProduto
        '
        Me.btnProduto.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduto.ForeColor = System.Drawing.Color.White
        Me.btnProduto.Location = New System.Drawing.Point(34, 898)
        Me.btnProduto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnProduto.Name = "btnProduto"
        Me.btnProduto.Size = New System.Drawing.Size(363, 49)
        Me.btnProduto.TabIndex = 1
        Me.btnProduto.Text = "Cadastre um novo Produto"
        Me.btnProduto.UseVisualStyleBackColor = True
        '
        'btnServico
        '
        Me.btnServico.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServico.ForeColor = System.Drawing.Color.White
        Me.btnServico.Location = New System.Drawing.Point(663, 898)
        Me.btnServico.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnServico.Name = "btnServico"
        Me.btnServico.Size = New System.Drawing.Size(363, 49)
        Me.btnServico.TabIndex = 2
        Me.btnServico.Text = "Cadastre um novo Serviço"
        Me.btnServico.UseVisualStyleBackColor = True
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
        Me.dtGrid.Location = New System.Drawing.Point(34, 280)
        Me.dtGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtGrid.Name = "dtGrid"
        Me.dtGrid.ReadOnly = True
        Me.dtGrid.RowHeadersVisible = False
        Me.dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrid.Size = New System.Drawing.Size(992, 598)
        Me.dtGrid.TabIndex = 107
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "proDesc"
        Me.Column1.HeaderText = "Nome"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "proPrecoVarejo"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "Preço"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "proQtdAtual"
        Me.Column3.HeaderText = "Quantidade atual"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "proQtdMin"
        Me.Column4.HeaderText = "Quantidade Min"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "proQtdMax"
        Me.Column5.HeaderText = "Quantidade Max"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLoc)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(80, 32)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(891, 162)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Procurar Produto"
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
        Me.txtLoc.Size = New System.Drawing.Size(530, 35)
        Me.txtLoc.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.PaperManagement.My.Resources.Resources.BuscarSmall
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(674, 72)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(180, 58)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "  Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(34, 965)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 152
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.EstoqueCor
        Me.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.ForeColor = System.Drawing.Color.White
        Me.btnListar.Location = New System.Drawing.Point(34, 222)
        Me.btnListar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(177, 49)
        Me.btnListar.TabIndex = 153
        Me.btnListar.Text = "Listar Todos"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'frmEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1064, 1038)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtGrid)
        Me.Controls.Add(Me.btnServico)
        Me.Controls.Add(Me.btnProduto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque"
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnProduto As System.Windows.Forms.Button
    Friend WithEvents btnServico As System.Windows.Forms.Button
    Friend WithEvents dtGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnListar As System.Windows.Forms.Button
End Class
