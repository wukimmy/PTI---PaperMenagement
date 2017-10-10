Public Class frmBuscaFornecedor
    Dim objFor As New clsFornecedor
    Dim dataSource As DataTable

    Private Sub frmBuscaFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLoc.Text = ""
        If dtGrid.RowCount <> 0 Then
            dataSource.Clear()
            dtGrid.Refresh()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtLoc.Text <> "" Then
            dataSource = objFor.localizar(txtLoc.Text)
            dtGrid.DataSource = dataSource
            txtLoc.Text = ""
            txtLoc.Focus()
            If dtGrid.RowCount = 0 Then
                MessageBox.Show("Nenhum resultado encontrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Digite um código ou nome", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAddFornecedor_Click(sender As Object, e As EventArgs) Handles btnAddFornecedor.Click
        frmCadFornecedor.ShowDialog()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class