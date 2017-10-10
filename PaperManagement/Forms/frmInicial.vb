Public Class frmInicial
    Dim objSenha As New clsSenha

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        '  If objSenha.Entrar(txtLogin.Text, txtSenha.Text) = True Then
        If objSenha.Entrar("ADMIN", "321") = True Then
            frmMenu.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

End Class