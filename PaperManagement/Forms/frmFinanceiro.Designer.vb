<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinanceiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinanceiro))
        Me.dtGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.rbdNPaga = New System.Windows.Forms.RadioButton()
        Me.rbdPago = New System.Windows.Forms.RadioButton()
        Me.btnAdicionarDispesa = New System.Windows.Forms.Button()
        Me.btnLancaDes = New System.Windows.Forms.Button()
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
        Me.dtGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column7, Me.Column5})
        Me.dtGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtGrid.Location = New System.Drawing.Point(40, 238)
        Me.dtGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtGrid.Name = "dtGrid"
        Me.dtGrid.ReadOnly = True
        Me.dtGrid.RowHeadersVisible = False
        Me.dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrid.Size = New System.Drawing.Size(1048, 555)
        Me.dtGrid.TabIndex = 106
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.rbdNPaga)
        Me.GroupBox1.Controls.Add(Me.rbdPago)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(75, 35)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(972, 154)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Procurar Despesas"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FinanceiroCor
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.PaperManagement.My.Resources.Resources.BuscarSmall
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(765, 48)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(180, 58)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "  Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'rbdNPaga
        '
        Me.rbdNPaga.AutoSize = True
        Me.rbdNPaga.Location = New System.Drawing.Point(26, 97)
        Me.rbdNPaga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbdNPaga.Name = "rbdNPaga"
        Me.rbdNPaga.Size = New System.Drawing.Size(264, 33)
        Me.rbdNPaga.TabIndex = 1
        Me.rbdNPaga.TabStop = True
        Me.rbdNPaga.Text = "Despesas não pagas"
        Me.rbdNPaga.UseVisualStyleBackColor = True
        '
        'rbdPago
        '
        Me.rbdPago.AutoSize = True
        Me.rbdPago.Location = New System.Drawing.Point(26, 46)
        Me.rbdPago.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbdPago.Name = "rbdPago"
        Me.rbdPago.Size = New System.Drawing.Size(218, 33)
        Me.rbdPago.TabIndex = 0
        Me.rbdPago.Text = "Despesas pagas"
        Me.rbdPago.UseVisualStyleBackColor = True
        '
        'btnAdicionarDispesa
        '
        Me.btnAdicionarDispesa.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FinanceiroCor
        Me.btnAdicionarDispesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionarDispesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionarDispesa.ForeColor = System.Drawing.Color.White
        Me.btnAdicionarDispesa.Location = New System.Drawing.Point(424, 826)
        Me.btnAdicionarDispesa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdicionarDispesa.Name = "btnAdicionarDispesa"
        Me.btnAdicionarDispesa.Size = New System.Drawing.Size(280, 51)
        Me.btnAdicionarDispesa.TabIndex = 109
        Me.btnAdicionarDispesa.Text = "Adicionar Despesa"
        Me.btnAdicionarDispesa.UseVisualStyleBackColor = True
        '
        'btnLancaDes
        '
        Me.btnLancaDes.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FinanceiroCor
        Me.btnLancaDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLancaDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLancaDes.ForeColor = System.Drawing.Color.White
        Me.btnLancaDes.Location = New System.Drawing.Point(804, 826)
        Me.btnLancaDes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLancaDes.Name = "btnLancaDes"
        Me.btnLancaDes.Size = New System.Drawing.Size(280, 51)
        Me.btnLancaDes.TabIndex = 110
        Me.btnLancaDes.Text = "Lançar Despesa"
        Me.btnLancaDes.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FinanceiroCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(40, 822)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 152
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmFinanceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 931)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnLancaDes)
        Me.Controls.Add(Me.btnAdicionarDispesa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmFinanceiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Despesas "
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbdNPaga As System.Windows.Forms.RadioButton
    Friend WithEvents rbdPago As System.Windows.Forms.RadioButton
    Friend WithEvents btnAdicionarDispesa As System.Windows.Forms.Button
    Friend WithEvents btnLancaDes As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
