Public Class FrmEntradaProduto
    Dim objctl As New clsControle
    Dim objpro As New clsProduto
    Dim objentPro As New clsEntradaProd
    Dim objdesp As New clsLancaDespesa
    Dim dtListPro As DataTable
    Dim dtListDes
    Dim listItem As String
    Dim dtEntrada As DataTable
    Dim dtPro As DataTable

    Private Sub FrmEntradaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objctl.habilitarCampos(Me, True)
        objctl.habilitarBotoes(Me, True)
        txtCod.Text = ""
        txtPreco.Text = ""
        txtQtd.Text = ""
        dtGrid.Rows.Clear()
        txtData.Value = Date.Now
        dtPro = objpro.localizar(txtNomProd.Text)
        txtCodPro.Text = dtPro.Rows(0).Item(0)
        dtEntrada = objentPro.listar
        For x = 0 To dtEntrada.Rows.Count - 1
            dtPro = objpro.localizar(dtEntrada.Rows(x).Item(1))
            dtGrid.Rows.Add(dtEntrada.Rows(x).Item(0), dtPro.Rows(0).Item(2), dtEntrada.Rows(x).Item(2), dtEntrada.Rows(x).Item(3), dtEntrada.Rows(x).Item(4))
        Next
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        objentPro.Codigo_Produto = txtCodPro.Text
        objentPro.Data_Entrada = txtData.Text
        objentPro.Preco = txtPreco.Text
        objentPro.Quantidade = txtQtd.Text
        objentPro.Gravar()
        objpro.Devolver_estoque(txtQtd.Text, txtCodPro.Text)
        dtGrid.Rows.Clear()
        MessageBox.Show("Estoque do produto atualizado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Call FrmEntradaProduto_Load(Nothing, Nothing)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call FrmEntradaProduto_Load(Nothing, Nothing)
    End Sub

    Private Sub frmCadVenda_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        dtListPro = objpro.verificarEstoque
        listItem = ""
        My.Forms.frmMenu.listNot.Items.Clear()
        For x = 0 To dtListPro.Rows.Count - 1
            listItem = dtListPro.Rows(x).Item(0) & " está acabando!" & "     Em estoque: " & dtListPro.Rows(x).Item(1) &
            "     Qtd Mínima: " & dtListPro.Rows(x).Item(2) & "     Qtd Máxima: " & dtListPro.Rows(x).Item(3)
            My.Forms.frmMenu.listNot.Items.Add(listItem)
        Next
        dtListDes = objdesp.filtrar_por_status(False)
        For x = 0 To dtListDes.Rows.Count - 1
            listItem = "Conta de " & dtListDes.Rows(x).Item(1) _
            & " ainda não foi paga     Validade: " & dtListDes.Rows(x).Item(4)
            My.Forms.frmMenu.listNot.Items.Add(listItem)
        Next
        My.Forms.frmEstoque.dtGrid.DataSource = objpro.listar
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class