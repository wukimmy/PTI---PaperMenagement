Public Class frmMensalista
    Dim objRelatorio As New clsRelatorio
    Dim objVenda As New clsVenda

    Private Sub frmMensalista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLoc.Text = ""
        dtGrid.DataSource = objRelatorio.loc()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtLoc.Text = "" Then
            MessageBox.Show("Digite o nome ou o codigo do cliente!!")
            txtLoc.Focus()
        Else
            dtGrid.DataSource = objRelatorio.mensalista(txtLoc.Text)
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class