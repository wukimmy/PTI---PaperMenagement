Public Class frmListar
    Dim subTitulo As String
    Private Sub frmListar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If rbtCliente.Checked = False And rbtForncedor.Checked = False And rbtFuncionario.Checked = False And rbtProduto.Checked = False And rbtDespesa.Checked = False Then
            MessageBox.Show("Escolha o tipo a listar")
        ElseIf rbtFuncionario.Checked = True Then
            subTitulo = "Lista de Funcionários"
            Dim rpt As New crpFuncionario
            frmImpressao.CrystalReportViewer1.ReportSource = rpt
            rpt.SummaryInfo.ReportComments = subTitulo
            frmImpressao.ShowDialog()
        ElseIf rbtCliente.Checked = True Then
            subTitulo = "Lista de Clientes"
            Dim rpt As New crpCliente
            frmImpressao.CrystalReportViewer1.ReportSource = rpt
            rpt.SummaryInfo.ReportComments = subTitulo
            frmImpressao.ShowDialog()
        ElseIf rbtForncedor.Checked = True Then
            subTitulo = "Lista de Fornecedor"
            Dim rpt As New crpFornecedor
            frmImpressao.CrystalReportViewer1.ReportSource = rpt
            rpt.SummaryInfo.ReportComments = subTitulo
            frmImpressao.ShowDialog()
        ElseIf rbtProduto.Checked = True Then
            subTitulo = "Lista de Produtos"
            Dim rpt As New crpProduto
            frmImpressao.CrystalReportViewer1.ReportSource = rpt
            rpt.SummaryInfo.ReportComments = subTitulo
            frmImpressao.ShowDialog()
        ElseIf rbtDespesa.Checked = True Then
            subTitulo = "Lista de Despesas"
            Dim rpt As New crpDespesa
            frmImpressao.CrystalReportViewer1.ReportSource = rpt
            rpt.SummaryInfo.ReportComments = subTitulo
            frmImpressao.ShowDialog()
        End If
    End Sub

    Private Sub btnSair_Click_1(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub


End Class