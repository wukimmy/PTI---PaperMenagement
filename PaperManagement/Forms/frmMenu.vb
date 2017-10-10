Public Class frmMenu
    Dim objpro As New clsProduto
    Dim objdes As New clsLancaDespesa
    Dim dtListPro As DataTable
    Dim dtListDes As DataTable
    Dim listItem As String

    Private Sub btnVenda_Click(sender As Object, e As EventArgs) Handles btnVenda.Click
        frmCadVenda.ShowDialog()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        frmCadCliente.ShowDialog()
    End Sub

    Private Sub btnFuncionario_Click(sender As Object, e As EventArgs) Handles btnFuncionario.Click
        frmCadFuncionario.ShowDialog()
    End Sub

    Private Sub btnFornecedor_Click(sender As Object, e As EventArgs) Handles btnFornecedor.Click
        frmBuscaFornecedor.ShowDialog()
    End Sub

    Private Sub btnEstoque_Click(sender As Object, e As EventArgs) Handles btnEstoque.Click
        frmEstoque.ShowDialog()
    End Sub

    Private Sub btnParceria_Click(sender As Object, e As EventArgs) Handles btnParceria.Click
        frmOrcamento.ShowDialog()
    End Sub

    Private Sub btnFechamento_Click(sender As Object, e As EventArgs) Handles btnFechamento.Click
        frmRelatorios.ShowDialog()
    End Sub

    Private Sub btnGerenciarSenha_Click(sender As Object, e As EventArgs) Handles btnGerenciarSenha.Click
        frmSenha.ShowDialog()
    End Sub

    Private Sub btnFinanceiro_Click(sender As Object, e As EventArgs) Handles btnFinanceiro.Click
        frmFinanceiro.ShowDialog()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginType As String
        loginType = My.Forms.frmInicial.txtLogin.Text
        If loginType <> "" Then
            If loginType = "GLOBAL" Then
                btnGerenciarSenha.Enabled = False
                btnFuncionario.Enabled = False
                btnFinanceiro.Enabled = False
                btnFornecedor.Enabled = False
            End If
            lblUser.Text = "Olá, " + loginType
        End If
        dtListPro = objpro.verificarEstoque
        listItem = ""
        For x = 0 To dtListPro.Rows.Count - 1
            listItem = dtListPro.Rows(x).Item(0) & " está acabando!" & "     Em estoque: " & dtListPro.Rows(x).Item(1) &
            "     Qtd Mínima: " & dtListPro.Rows(x).Item(2) & "     Qtd Máxima: " & dtListPro.Rows(x).Item(3)
            listNot.Items.Add(listItem)
        Next
        dtListDes = objdes.filtrar_por_status(False)
        For x = 0 To dtListDes.Rows.Count - 1
            listItem = "Conta de " & dtListDes.Rows(x).Item(1) _
            & " ainda não foi paga     Validade: " & dtListDes.Rows(x).Item(4)
            listNot.Items.Add(listItem)
        Next
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        DialogExit.ShowDialog()
    End Sub

End Class
