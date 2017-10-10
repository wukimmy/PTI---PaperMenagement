Public Class frmSenha
    Dim objSenha As New clsSenha

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        If txtLogin.SelectedIndex = -1 And txtSenha.Text = "" Then
            MessageBox.Show("Selecione um login e digite a senha", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txtLogin.SelectedIndex = -1 Then
            MessageBox.Show("Selecione um login", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txtSenha.Text = "" Then
            MessageBox.Show("Digite a senha", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            objSenha.Atualizar(txtLogin.Text, txtSenha.Text)
            MessageBox.Show("Senha de " & txtLogin.Text & " atualizada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSenha.Text = ""
            txtSenha.Focus()
            txtLogin.SelectedIndex = -1
        End If
    End Sub

    Private Sub chkVisualizarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisualizarSenha.CheckedChanged
        If chkVisualizarSenha.Checked Then
            txtSenha.PasswordChar = ""
        Else
            txtSenha.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class