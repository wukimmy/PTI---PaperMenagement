Public Class frmCadSaidaProdInterno
    Dim objctl As New clsControle
    Dim objsai As New clsSaidaProdInterrno
    Dim objprod As New clsProduto
    Dim objfun As New clsFuncionario
    Dim novo As Boolean
    Dim linhaselecionada As Integer
    Dim funcionario As Integer
    Dim produto As Integer
    Dim dataSource As DataTable

    Private Sub frmCadSaidaProdInterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dtGrid.RowCount <> 0 Then
            dataSource.Clear()
            dtGrid.Refresh()
        End If
        objctl.LimparTela(Me)
        objctl.habilitarCampos(Me, False)
        objctl.habilitarBotoes(Me, False)
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        objctl.habilitarCampos(Me, True)
        objctl.habilitarBotoes(Me, True)
        objctl.LimparTela(Me)
        txtFunc.Focus()
        novo = True
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        objctl.habilitarCampos(Me, False)
        objctl.habilitarBotoes(Me, False)
        If novo = False Then
            txtCod.Text = objsai.codigo.ToString
        End If
        objsai.produto = txtProd.Text
        objsai.funcionario = txtFunc.Text
        objsai.data = txtData.Text
        objsai.quantidade = txtQtd.Text
        objsai.Gravar(novo)
        MessageBox.Show("Saída de produto gravado com Sucesso!")
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        novo = False
        objctl.habilitarCampos(Me, True)
        objctl.habilitarBotoes(Me, True)
        btnGravar.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If objsai.Excluir(txtCod.Text) Then
            objctl.LimparTela(Me)
            btnExcluir.Enabled = False
            btnEditar.Enabled = False
        End If
        objctl.habilitarBotoes(Me, False)
        objctl.habilitarCampos(Me, False)
        btnNovo.Enabled = True
        btnSair.Enabled = True
        dtGrid.ClearSelection()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call frmCadSaidaProdInterno_Load(Nothing, Nothing)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtLoc.Text = "" Then
            MessageBox.Show("Digite o nome ou o codigo da saida de produto!!")
            txtLoc.Focus()
        Else
            dataSource = objsai.localizar(txtLoc.Text)
            dtGrid.DataSource = dataSource
            txtLoc.Text = ""
            If dtGrid.RowCount = 0 Then
                MessageBox.Show("Saida de Produto Inexistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtLoc.Focus()
            End If
        End If
    End Sub

    Private Sub dtGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid.CellDoubleClick
        If MessageBox.Show("Deseja editar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            linhaselecionada = e.RowIndex
            funcionario = dtGrid.Rows(linhaselecionada).Cells(1).Value
            produto = dtGrid.Rows(linhaselecionada).Cells(2).Value
            Me.txtCod.Text = dtGrid.Rows(linhaselecionada).Cells(0).Value
            Me.txtFunc.Text = objfun.busca_rapidaFun(funcionario)
            Me.txtProd.Text = objprod.busca_rapidaProd(produto)
            Me.txtQtd.Text = dtGrid.Rows(linhaselecionada).Cells(3).Value
            Me.txtData.Text = dtGrid.Rows(linhaselecionada).Cells(4).Value
            btnNovo.Enabled = False
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
            btnEditar.Focus()
            dataSource.Clear()
            dtGrid.Refresh()
        End If
    End Sub

    Private Sub txtFunc_LostFocus(sender As Object, e As EventArgs) Handles txtFunc.LostFocus
        If txtFunc.Text <> "" Then
            If objfun.Validar_chave(txtFunc.Text) = False Then
                MessageBox.Show("Funcionário Inexistente")
                txtFunc.Clear()
                txtFunc.Focus()
            Else
                txtNomFun.Text = objfun.nome
            End If
        End If
    End Sub

    Private Sub txtProd_LostFocus(sender As Object, e As EventArgs) Handles txtProd.LostFocus
        If txtProd.Text <> "" Then
            If objprod.Validar_chave2(txtProd.Text) = False Then
                MessageBox.Show("Produto Inexistente")
                txtProd.Clear()
                txtProd.Focus()
            Else
                txtNomProd.Text = objprod.Descricao
            End If
        End If
    End Sub

    Private Sub frmCadSaidaProdInterno_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim dtList As DataTable
        Dim listItem As String
        dtList = objprod.verificarEstoque
        listItem = ""
        My.Forms.frmMenu.listNot.Items.Clear()
        For x = 0 To dtList.Rows.Count - 1
            listItem = dtList.Rows(x).Item(0) & " está acabando!" & "     Em estoque: " & dtList.Rows(x).Item(1) &
            "     Qtd Mínima: " & dtList.Rows(x).Item(2) & "     Qtd Máxima: " & dtList.Rows(x).Item(3)
            My.Forms.frmMenu.listNot.Items.Add(listItem)
        Next
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class