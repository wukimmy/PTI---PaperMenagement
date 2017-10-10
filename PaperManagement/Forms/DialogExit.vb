Imports System.Windows.Forms

Public Class DialogExit
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnDeslogar_Click(sender As Object, e As EventArgs) Handles btnDeslogar.Click
        frmInicial.Show()
        frmMenu.Close()
        Me.Close()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

End Class
