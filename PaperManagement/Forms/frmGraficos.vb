Public Class frmGraficos
    Dim objRelatorio As New clsRelatorio

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If rbtVendedor.Checked = False And rbtCliente.Checked = False And rbtVenda.Checked = False And rbtPagamento.Checked = False And rbtDespesa.Checked = False And rbtProduto.Checked = False Then
            MessageBox.Show("Escolha uma das opções")
        ElseIf rbtVendedor.Checked = True Then
            DgdGrade.DataSource = objRelatorio.melhorVendedor(DtpIni.Text, DtpFin.Text)
        ElseIf rbtCliente.Checked = True Then
            DgdGrade.DataSource = objRelatorio.melhorCliente(DtpIni.Text, DtpFin.Text)
        ElseIf rbtVenda.Checked = True Then
            DgdGrade.DataSource = objRelatorio.filtrar_vendas(DtpIni.Text, DtpFin.Text)
        ElseIf rbtPagamento.Checked = True Then
            DgdGrade.DataSource = objRelatorio.tipoPagamento()
        ElseIf rbtDespesa.Checked = True Then
            MessageBox.Show("Opção apenas para Gráfico")
        ElseIf rbtProduto.Checked = True Then
            MessageBox.Show("Opção apenas para Gráfico")
        End If
        If DgdGrade.RowCount = 0 Then
            MessageBox.Show("Nenhum registro encontrado nesse período")
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnGrafico_Click(sender As Object, e As EventArgs) Handles btnGrafico.Click
        If rbtVendedor.Checked = False And rbtCliente.Checked = False And rbtVenda.Checked = False And rbtPagamento.Checked = False And rbtDespesa.Checked = False And rbtProduto.Checked = False Then
            MessageBox.Show("Escolha uma das opções")
        ElseIf rbtVendedor.Checked = True Then
            DgdGrade.DataSource = objRelatorio.melhorVendedor(DtpIni.Text, DtpFin.Text)
        ElseIf rbtCliente.Checked = True Then
            DgdGrade.DataSource = objRelatorio.melhorCliente(DtpIni.Text, DtpFin.Text)
        ElseIf rbtVenda.Checked = True Then
            DgdGrade.DataSource = objRelatorio.filtrar_vendas(DtpIni.Text, DtpFin.Text)
            Dim rpt As New crpGraficoVendaMes
            frmImpressao.CrystalReportViewer1.ReportSource = rpt
            frmImpressao.ShowDialog()
        ElseIf rbtPagamento.Checked = True Then
            DgdGrade.DataSource = objRelatorio.tipoPagamento()
            Dim rpt As New crpGaficoTipoPagamento
            frmImpressao.CrystalReportViewer1.ReportSource = rpt
            frmImpressao.ShowDialog()
        ElseIf rbtDespesa.Checked = True Then
            Dim rpt As New crpGraficoDespesa
            frmImpressao.CrystalReportViewer1.ReportSource = rpt
            frmImpressao.ShowDialog()
        ElseIf rbtProduto.Checked = True Then
            DgdGrade.DataSource = objRelatorio.filtrar_vendas(DtpIni.Text, DtpFin.Text)
            Dim rpt As New crpItensMaisVendidos
            frmImpressao.CrystalReportViewer1.ReportSource = rpt
            frmImpressao.ShowDialog()
        End If
        If DgdGrade.RowCount = 0 Then
            MessageBox.Show("Nenhum registro encontrado nesse período")
        End If
    End Sub
End Class