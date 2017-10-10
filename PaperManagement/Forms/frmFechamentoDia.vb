Public Class frmFechamentoDia
    Dim objVenda As New clsVenda
    Dim data As Date

    Private Sub frmFechamentoDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtGrid.DataSource = objVenda.fechamentoDia(Now.Date)
    End Sub

    Private Sub btnFechamento_Click(sender As Object, e As EventArgs) Handles btnFechamento.Click
        frmFechamentoMes.ShowDialog()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dtGrid.DataSource = objVenda.fechamentoDia(dtpData.Text)
        If dtGrid.RowCount = 0 Then
            MessageBox.Show("Nenhum registro encontrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class