Public Class frmBuscaOrcamento
    Dim objorcProd As New clsOrcamentoProduto
    Dim objprod As New clsProduto
    Dim dataSource As DataTable

    Private Sub frmBuscaOrcamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLoc.Text = ""
        If dtgrid.RowCount <> 0 Then
            dataSource.Clear()
            dtgrid.Refresh()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtLoc.Text = "" Then
            MessageBox.Show("Digite o código de orçamento antes de buscar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLoc.Focus()
        Else
            dataSource = objorcProd.buscar(txtLoc.Text)
            dtgrid.DataSource = dataSource
            txtLoc.Text = ""
            txtLoc.Focus()
            Dim x As Integer
            Dim qtd As Integer
            Dim valor As Double
            For x = 0 To dtgrid.Rows.Count - 1
                qtd = dtgrid.Rows(x).Cells(2).Value
                valor = dtgrid.Rows(x).Cells(3).Value
                'dtgrid.Rows(x).Cells(4).Value = qtd * valor
                'valor subtotal na tabela nao esta indo
                If txtTot.Text = "" Then
                    txtTot.Text = 0.0
                End If
                txtTot.Text = txtTot.Text + (qtd * valor)
            Next
        End If
    End Sub

    Private Sub btnEfetuarVenda_Click(sender As Object, e As EventArgs) Handles btnEfeVenda.Click
        Dim x As Integer
        For x = 0 To dtgrid.Rows.Count - 1
            frmCadVenda.dtGrid.Rows.Add("Produto", objprod.busca_rapidaProd(dtgrid.Rows(x).Cells(1).Value), dtgrid.Rows(x).Cells(1).Value, dtgrid.Rows(x).Cells(2).Value, dtgrid.Rows(x).Cells(3).Value, (dtgrid.Rows(x).Cells(2).Value * dtgrid.Rows(x).Cells(3).Value))
            'If frmCadVenda.txtTot.Text = "" Then
            'frmCadVenda.txtTot.Text = 0.0
            'End If
            ' frmCadVenda.txtTot.Text = frmCadVenda.dtGrid.Rows(x).Cells(5).Value + frmCadVenda.txtTot.Text
        Next
        frmCadVenda.ShowDialog()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class