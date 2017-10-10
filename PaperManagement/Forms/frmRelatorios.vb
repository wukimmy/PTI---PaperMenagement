Public Class frmRelatorios

    Private Sub btnFechamento_Click(sender As Object, e As EventArgs) Handles btnFechamento.Click
        frmFechamentoDia.ShowDialog()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnMensalista_Click(sender As Object, e As EventArgs) Handles btnMensalista.Click
        frmMensalista.ShowDialog()
    End Sub

    Private Sub btnGraficos_Click(sender As Object, e As EventArgs) Handles btnGraficos.Click
        frmGraficos.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmListar.ShowDialog()
    End Sub
End Class