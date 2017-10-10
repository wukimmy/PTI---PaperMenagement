<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGraficos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGraficos))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DtpFin = New System.Windows.Forms.DateTimePicker()
        Me.DtpIni = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtProduto = New System.Windows.Forms.RadioButton()
        Me.rbtDespesa = New System.Windows.Forms.RadioButton()
        Me.rbtPagamento = New System.Windows.Forms.RadioButton()
        Me.rbtVenda = New System.Windows.Forms.RadioButton()
        Me.rbtCliente = New System.Windows.Forms.RadioButton()
        Me.rbtVendedor = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnGrafico = New System.Windows.Forms.Button()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(128, 488)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(10, 26)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DtpFin
        '
        Me.DtpFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFin.Location = New System.Drawing.Point(216, 91)
        Me.DtpFin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DtpFin.Name = "DtpFin"
        Me.DtpFin.Size = New System.Drawing.Size(163, 35)
        Me.DtpFin.TabIndex = 99
        '
        'DtpIni
        '
        Me.DtpIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIni.Location = New System.Drawing.Point(33, 91)
        Me.DtpIni.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DtpIni.Name = "DtpIni"
        Me.DtpIni.Size = New System.Drawing.Size(163, 35)
        Me.DtpIni.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 33)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Data Final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 33)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Data Inicial"
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgdGrade.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgdGrade.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgdGrade.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgdGrade.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(33, 315)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowHeadersVisible = False
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(1070, 475)
        Me.DgdGrade.TabIndex = 95
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtProduto)
        Me.GroupBox1.Controls.Add(Me.rbtDespesa)
        Me.GroupBox1.Controls.Add(Me.rbtPagamento)
        Me.GroupBox1.Controls.Add(Me.rbtVenda)
        Me.GroupBox1.Controls.Add(Me.rbtCliente)
        Me.GroupBox1.Controls.Add(Me.rbtVendedor)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 155)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1070, 126)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Pesquisa"
        '
        'rbtProduto
        '
        Me.rbtProduto.AutoSize = True
        Me.rbtProduto.Location = New System.Drawing.Point(934, 45)
        Me.rbtProduto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtProduto.Name = "rbtProduto"
        Me.rbtProduto.Size = New System.Drawing.Size(90, 24)
        Me.rbtProduto.TabIndex = 5
        Me.rbtProduto.TabStop = True
        Me.rbtProduto.Text = "Produto"
        Me.rbtProduto.UseVisualStyleBackColor = True
        '
        'rbtDespesa
        '
        Me.rbtDespesa.AutoSize = True
        Me.rbtDespesa.Location = New System.Drawing.Point(812, 45)
        Me.rbtDespesa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtDespesa.Name = "rbtDespesa"
        Me.rbtDespesa.Size = New System.Drawing.Size(98, 24)
        Me.rbtDespesa.TabIndex = 4
        Me.rbtDespesa.TabStop = True
        Me.rbtDespesa.Text = "Despesa"
        Me.rbtDespesa.UseVisualStyleBackColor = True
        '
        'rbtPagamento
        '
        Me.rbtPagamento.AutoSize = True
        Me.rbtPagamento.Location = New System.Drawing.Point(586, 45)
        Me.rbtPagamento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtPagamento.Name = "rbtPagamento"
        Me.rbtPagamento.Size = New System.Drawing.Size(187, 24)
        Me.rbtPagamento.TabIndex = 3
        Me.rbtPagamento.TabStop = True
        Me.rbtPagamento.Text = "Tipos de pagamentos"
        Me.rbtPagamento.UseVisualStyleBackColor = True
        '
        'rbtVenda
        '
        Me.rbtVenda.AutoSize = True
        Me.rbtVenda.Location = New System.Drawing.Point(464, 45)
        Me.rbtVenda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtVenda.Name = "rbtVenda"
        Me.rbtVenda.Size = New System.Drawing.Size(93, 24)
        Me.rbtVenda.TabIndex = 2
        Me.rbtVenda.TabStop = True
        Me.rbtVenda.Text = "Vendas "
        Me.rbtVenda.UseVisualStyleBackColor = True
        '
        'rbtCliente
        '
        Me.rbtCliente.AutoSize = True
        Me.rbtCliente.Location = New System.Drawing.Point(195, 45)
        Me.rbtCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtCliente.Name = "rbtCliente"
        Me.rbtCliente.Size = New System.Drawing.Size(235, 24)
        Me.rbtCliente.TabIndex = 1
        Me.rbtCliente.TabStop = True
        Me.rbtCliente.Text = "Clientes Que Mais Compram"
        Me.rbtCliente.UseVisualStyleBackColor = True
        '
        'rbtVendedor
        '
        Me.rbtVendedor.AutoSize = True
        Me.rbtVendedor.Location = New System.Drawing.Point(27, 45)
        Me.rbtVendedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtVendedor.Name = "rbtVendedor"
        Me.rbtVendedor.Size = New System.Drawing.Size(156, 24)
        Me.rbtVendedor.TabIndex = 0
        Me.rbtVendedor.TabStop = True
        Me.rbtVendedor.Text = "Melhor Vendedor"
        Me.rbtVendedor.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.PaperManagement.My.Resources.Resources.BuscarSmall
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(687, 72)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(180, 58)
        Me.btnBuscar.TabIndex = 155
        Me.btnBuscar.Text = "  Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Image = Global.PaperManagement.My.Resources.Resources.ExitSmall
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(33, 800)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 58)
        Me.btnSair.TabIndex = 154
        Me.btnSair.Text = " Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnGrafico
        '
        Me.btnGrafico.BackgroundImage = Global.PaperManagement.My.Resources.Resources.FechamentoCor
        Me.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrafico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrafico.ForeColor = System.Drawing.Color.White
        Me.btnGrafico.Image = Global.PaperManagement.My.Resources.Resources.GraficoSmall
        Me.btnGrafico.Location = New System.Drawing.Point(898, 72)
        Me.btnGrafico.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGrafico.Name = "btnGrafico"
        Me.btnGrafico.Size = New System.Drawing.Size(204, 58)
        Me.btnGrafico.TabIndex = 103
        Me.btnGrafico.Text = "Gráfico"
        Me.btnGrafico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGrafico.UseVisualStyleBackColor = True
        '
        'frmGraficos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 895)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnGrafico)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtpFin)
        Me.Controls.Add(Me.DtpIni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmGraficos"
        Me.Text = "Gerar Gráficos"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtVendedor As System.Windows.Forms.RadioButton
    Friend WithEvents rbtVenda As System.Windows.Forms.RadioButton
    Friend WithEvents rbtPagamento As System.Windows.Forms.RadioButton
    Friend WithEvents btnGrafico As Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents rbtDespesa As RadioButton
    Friend WithEvents rbtProduto As System.Windows.Forms.RadioButton
End Class
