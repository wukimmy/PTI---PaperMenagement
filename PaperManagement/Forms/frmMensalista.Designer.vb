<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensalista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMensalista))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.dtGrid = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnFechamento = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtLoc)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(75, 60)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(970, 128)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Digite o código ou nome do mensalista"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.PaperManagement.My.Resources.Resources.BuscarSmall
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(753, 40)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(180, 58)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "  Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(9, 58)
        Me.txtLoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(556, 35)
        Me.txtLoc.TabIndex = 3
        '
        'dtGrid
        '
        Me.dtGrid.AllowUserToAddRows = False
        Me.dtGrid.AllowUserToDeleteRows = False
        Me.dtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column4})
        Me.dtGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtGrid.Location = New System.Drawing.Point(75, 226)
        Me.dtGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtGrid.Name = "dtGrid"
        Me.dtGrid.ReadOnly = True
        Me.dtGrid.RowHeadersVisible = False
        Me.dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrid.Size = New System.Drawing.Size(970, 512)
        Me.dtGrid.TabIndex = 111
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "cliNom"
        Me.Column2.HeaderText = "Nome do Cliente"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "cliCod"
        Me.Column1.HeaderText = "Código do cliente"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "venVal"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column4.HeaderText = "Valor"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(75, 771)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 155
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnFechamento
        '
        Me.btnFechamento.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnFechamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechamento.ForeColor = System.Drawing.Color.White
        Me.btnFechamento.Image = Global.PaperManagement.My.Resources.Resources._Relatorio
        Me.btnFechamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechamento.Location = New System.Drawing.Point(720, 768)
        Me.btnFechamento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFechamento.Name = "btnFechamento"
        Me.btnFechamento.Size = New System.Drawing.Size(326, 62)
        Me.btnFechamento.TabIndex = 156
        Me.btnFechamento.Text = "  Fechamento Mensal"
        Me.btnFechamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechamento.UseVisualStyleBackColor = True
        '
        'frmMensalista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 880)
        Me.Controls.Add(Me.btnFechamento)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMensalista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente Mensalista"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents dtGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnFechamento As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As Button
End Class
