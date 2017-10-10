Public Class frmEstoque
    Dim objprod As New clsProduto

    Private Sub frmEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtGrid.DataSource = objprod.listar
        If dtGrid.RowCount = 0 Then
            MessageBox.Show("Não há nenhum produto cadastrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub dtGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid.CellDoubleClick
        Dim i As Integer
        i = dtGrid.CurrentCell.RowIndex
        My.Forms.FrmEntradaProduto.txtNomProd.Text = dtGrid.Item(0, i).Value
        FrmEntradaProduto.ShowDialog()
    End Sub

    Private Sub btnProduto_Click(sender As Object, e As EventArgs) Handles btnProduto.Click
        frmCadProduto.ShowDialog()
    End Sub

    Private Sub btnServico_Click(sender As Object, e As EventArgs) Handles btnServico.Click
        frmCadServicos.ShowDialog()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dtGrid.DataSource = objprod.localizarEstoque2(txtLoc.Text)
        If dtGrid.RowCount = 0 Then
            MessageBox.Show("Produto Inexistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        dtGrid.DataSource = objprod.listar
    End Sub

    Private Sub txtLoc_TextChanged(sender As Object, e As EventArgs) Handles txtLoc.TextChanged
        'dtGrid.DataSource = objprod.localizarEstoque(txtLoc.Text)
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class