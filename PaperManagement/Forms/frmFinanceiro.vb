Public Class frmFinanceiro
    Dim objLancaDesp As New clsLancaDespesa
    Dim linhaselecionada As Integer
    Dim status As Boolean
    Dim dataSource As DataTable

    Private Sub frmFinanceiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbdNPaga.Checked = False
        rbdPago.Checked = False
        If dtGrid.RowCount <> 0 Then
            dataSource.Clear()
            dtGrid.Refresh()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If rbdPago.Checked = False And rbdNPaga.Checked = False Then
            MessageBox.Show("Selecione um tipo de despesa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If rbdPago.Checked Then
                status = True
            Else
                status = False
            End If
            dataSource = objLancaDesp.filtrar_por_status(status)
            dtGrid.DataSource = dataSource
            If dtGrid.RowCount = 0 Then
                If status = True Then
                    MessageBox.Show("Nenhuma despesa paga", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Todas despesas pagas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub btnAdicionarDispesa_Click(sender As Object, e As EventArgs) Handles btnAdicionarDispesa.Click
        frmCadDespesa.ShowDialog()
    End Sub

    Private Sub btnLancaDes_Click(sender As Object, e As EventArgs) Handles btnLancaDes.Click
        frmLancaDespesa.ShowDialog()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class