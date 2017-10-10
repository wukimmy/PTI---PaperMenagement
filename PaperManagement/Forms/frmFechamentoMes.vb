Public Class frmFechamentoMes
    Dim objRelatorio As New clsRelatorio
    Dim objVenda As New clsVenda
    Dim dtSoma As DataTable
    Dim mes As Integer
    Dim ano As Integer

    Private Sub frmFechamentoMes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtQtd.Text = ""
        txtTot.Text = ""
        txtAno.Text = ""
        cmbMes.SelectedItem = -1
        dtGrid.DataSource = objVenda.listar_venda
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtAno.Text = "" Then
            MessageBox.Show("Digite o ano!!")
            txtAno.Focus()
            Exit Sub
        End If
        If cmbMes.Text = "Janeiro" Then
            mes = 1
        ElseIf cmbMes.Text = "Fevereiro" Then
            mes = 2
        ElseIf cmbMes.Text = "Março" Then
            mes = 3
        ElseIf cmbMes.Text = "Abril" Then
            mes = 4
        ElseIf cmbMes.Text = "Maio" Then
            mes = 5
        ElseIf cmbMes.Text = "Junho" Then
            mes = 6
        ElseIf cmbMes.Text = "Julho" Then
            mes = 7
        ElseIf cmbMes.Text = "Agosto" Then
            mes = 8
        ElseIf cmbMes.Text = "Setembro" Then
            mes = 9
        ElseIf cmbMes.Text = "Outubro" Then
            mes = 10
        ElseIf cmbMes.Text = "Novembro" Then
            mes = 11
        ElseIf cmbMes.Text = "Dezembro" Then
            mes = 12
        End If
        ano = txtAno.Text
        dtSoma = objRelatorio.fechamentoMes(mes, ano)
        If dtSoma.Rows.Count <> 0 Then
            txtTot.Text = dtSoma.Rows(0).Item(0)
            txtQtd.Text = dtSoma.Rows(0).Item(1)
        End If
        dtGrid.DataSource = objVenda.fechamentoMes(mes, ano)
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class