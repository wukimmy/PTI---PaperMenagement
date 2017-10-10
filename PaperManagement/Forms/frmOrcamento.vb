Public Class frmOrcamento

    Private Sub btnOrca_Click(sender As Object, e As EventArgs) Handles btnOrca.Click
        frmCadOrcamento.ShowDialog()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmBuscaOrcamento.ShowDialog()
    End Sub

    Private Sub btnParceiro_Click(sender As Object, e As EventArgs) Handles btnParceiro.Click
        FrmCadParceiros.ShowDialog()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class