Public Class frmCadVenda
    Dim objctl As New clsControle
    Dim objven As New clsVenda
    Dim objpro As New clsProduto
    Dim objser As New clsServico
    Dim objcli As New clsCliente
    Dim objfun As New clsFuncionario
    Dim objitem As New clsItensVendidos
    Dim objval As New clsValidacao
    Dim objdes As New clsLancaDespesa
    Dim dtListPro As DataTable
    Dim dtListDes
    Dim listItem As String
    Dim estoque As Integer
    Dim geral As Single
    Dim valTot As Double
    Dim valFixo As Double
    Dim cliExiste As Boolean

    Private Sub frmCadVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objctl.LimparTela(Me)
        objctl.habilitarCampos(Me, True)
        txtCli.Focus()
        cboFun.DisplayMember = "funNom"
        cboFun.ValueMember = "funCod"
        cboFun.DataSource = objfun.Exibir_combo
        cboFun.SelectedIndex = -1
        txtData.Value = DateTime.Now
        estoque = 0
        txtDesc.Text = 0
    End Sub

    Private Sub txtCli_LostFocus(sender As Object, e As EventArgs) Handles txtCli.LostFocus
        If txtCli.Text = "" Then
            ' MessageBox.Show("Digite o CPF!")
            ' txtCli.Focus()
        ElseIf txtCli.Text <> "" Then
            If objval.FU_ValidaCPF(txtCli.Text) Then
                If objcli.Validar_chave(txtCli.Text) = True Then
                    cliExiste = True
                    lblCli.Text = objcli.nome
                    If objcli.mensalista Then
                        rbtCupon.Enabled = True
                    End If
                Else
                    cliExiste = False
                    Dim response As DialogResult
                    response = MessageBox.Show("Deseja cadastrar esse Cliente?", "Cliente não cadastrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If response = DialogResult.Yes Then
                        frmCadCliente.ShowDialog()
                    Else
                        lblCli.Text = "Cliente não cadastrado"
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TxtCodPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodPro.KeyPress, txtQtdPro.KeyPress
        e.Handled = objctl.verificarNumeroInteiro(e.KeyChar)
    End Sub

    Private Sub TxtCodPro_LostFocus(sender As Object, e As EventArgs) Handles txtCodPro.LostFocus
        If txtCodPro.Text <> "" Then
            If cbmTipo.SelectedIndex = -1 Then
                MessageBox.Show("Escolha o tipo de item", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCodPro.Text = ""
            ElseIf cbmTipo.SelectedIndex = 0 Then
                If objpro.Validar_chave(txtCodPro.Text) = False Then
                    MessageBox.Show("Produto não cadastrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCodPro.Clear()
                    txtNomPro.Clear()
                    txtPrePro.Clear()
                    txtQtdPro.Clear()
                    txtSubPro.Clear()
                    txtCodPro.Focus()
                Else
                    txtNomPro.Text = objpro.Descricao
                    estoque = objpro.Qtd_Atual
                    txtPrePro.Text = Format(objpro.Preco_Varejo, "0.00")
                    txtQtdPro.Clear()
                    txtSubPro.Clear()
                    txtQtdPro.Focus()
                End If
            ElseIf cbmTipo.SelectedIndex = 1 Then
                If objser.Validar_chave(txtCodPro.Text) = False Then
                    MessageBox.Show("Serviço não cadastrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCodPro.Clear()
                    txtNomPro.Clear()
                    txtPrePro.Clear()
                    txtQtdPro.Clear()
                    txtSubPro.Clear()
                    txtCodPro.Focus()
                Else
                    txtNomPro.Text = objser.Descricao
                    txtPrePro.Text = objser.Preco
                    txtQtdPro.Clear()
                    txtSubPro.Clear()
                    txtQtdPro.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub TxtQtdPro_TextChanged(sender As Object, e As EventArgs) Handles txtQtdPro.TextChanged
        Dim subt, pre As Double
        If txtQtdPro.Text <> "" And txtCodPro.Text <> "" And cbmTipo.SelectedIndex = 0 Then
            If txtQtdPro.Text > estoque Then
                MessageBox.Show("Quantidade indisponível, possuímos apenas " & estoque & " itens", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtQtdPro.Clear()
                txtQtdPro.Focus()
                Exit Sub
            End If
            If CInt(txtQtdPro.Text) >= objpro.Qtd_Atacado Then
                txtPrePro.Text = Format(objpro.Preco_Atacado, "0.00")
            Else
                txtPrePro.Text = Format(objpro.Preco_Varejo, "0.00")
            End If
            pre = CDbl(txtPrePro.Text)
            subt = pre * CInt(txtQtdPro.Text)
            txtSubPro.Text = Format(subt, "0.00")
        ElseIf txtQtdPro.Text <> "" And txtCodPro.Text <> "" And cbmTipo.SelectedIndex = 1 Then
            pre = CDbl(txtPrePro.Text)
            subt = pre * CInt(txtQtdPro.Text)
            txtSubPro.Text = Format(subt, "0.00")
        Else
            txtSubPro.Clear()
            txtQtdPro.Clear()
        End If
    End Sub

    Private Sub BtnAdicio_Click(sender As Object, e As EventArgs) Handles btnAdicio.Click
        If txtCodPro.Text = "" Then
            MessageBox.Show("Preencha o código antes de adicionar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodPro.Focus()
        ElseIf txtQtdPro.Text = "" Then
            MessageBox.Show("Preencha a quantidade antes de adicionar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtQtdPro.Focus()
        Else
            dtGrid.Rows.Add(cbmTipo.SelectedItem, txtCodPro.Text, txtNomPro.Text, txtPrePro.Text, txtQtdPro.Text, txtSubPro.Text)
            objpro.Baixar_estoque(txtQtdPro.Text, txtCodPro.Text)
            estoque = estoque - CInt(txtQtdPro.Text)
            geral = geral + CSng(txtSubPro.Text)
            valFixo = Format(geral, "0.00")
            txtTot.Text = valFixo
            txtCodPro.Clear()
            txtNomPro.Clear()
            txtQtdPro.Clear()
            txtPrePro.Clear()
            txtSubPro.Clear()
            txtCodPro.Focus()
        End If
    End Sub

    Private Sub txtDesc_LostFocus(sender As Object, e As EventArgs) Handles txtDesc.LostFocus
        txtTot.Text = valFixo
        Dim valDesc As Double
        If txtDesc.Text = "" Then
            txtDesc.Text = 0
        End If
        valDesc = CInt(txtDesc.Text) / 100
        valDesc = valDesc * CDec(txtTot.Text)
        valTot = CDec(txtTot.Text) - valDesc
        txtTot.Text = Format(valTot, "0.00")
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        If cboFun.SelectedIndex = -1 Then
            MessageBox.Show("Selecione um funcionário!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf dtGrid.Rows.Count = 0 Then
            MessageBox.Show("Nenhum produto a ser vendido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf rbtCartao.Checked = False And rbtCupon.Checked = False And rbtDinheiro.Checked = False Then
            MessageBox.Show("Selecione um tipo de pagamento!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf dtGrid.RowCount = 0 Then
            MessageBox.Show("Nenhum item na compra!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If cliExiste Then
                objven.cliente = objcli.locVen(txtCli.Text)
            Else
                objven.cliente = 14
            End If
            objven.clienteCPF = txtCli.Text
            objven.funcionario = cboFun.SelectedValue
            objven.data = DateTime.Now
            objven.percentualDesconto = CInt(txtDesc.Text) / 100
            objven.valor = txtTot.Text
            If rbtCartao.Checked = True Then
                objven.tipoPagamento = "cartao"
            ElseIf rbtCupon.Checked = True Then
                objven.tipoPagamento = "cupom"
            ElseIf rbtDinheiro.Checked = True Then
                objven.tipoPagamento = "dinheiro"
            End If
            objven.Gravar()
            txtCod.Text = objven.codigo.ToString
            For x = 0 To (dtGrid.Rows.Count - 1)
                objitem.codigo_venda = txtCod.Text
                objitem.sequencia_item = x + 1
                objitem.codigo_produto = dtGrid.Item(1, x).Value
                objitem.valor_venda = dtGrid.Item(3, x).Value
                objitem.qtd_vendida = dtGrid.Item(4, x).Value
                If cbmTipo.Text = "Produto" Then
                    objitem.servico_produto = False
                Else
                    objitem.servico_produto = True
                End If
                objitem.Gravar()
                MessageBox.Show("Venda efetuada com Sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.None)
                dtGrid.Rows.Clear()
                objctl.LimparTela(Me)
                objctl.habilitarCampos(Me, True)
                objctl.habilitarBotoes(Me, True)
                txtCod.Enabled = False
                txtData.Enabled = False
                cboFun.SelectedIndex = -1
                lblCli.Text = ""
                btnGravar.Enabled = True
            Next
        End If
    End Sub

    Private Sub dtGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid.CellDoubleClick
        Dim i As Integer
        i = dtGrid.CurrentCell.RowIndex
        objpro.Devolver_estoque(dtGrid.Item(4, i).Value, dtGrid.Item(1, i).Value)
        estoque = estoque + dtGrid.Item(4, i).Value
        geral = geral - CSng(dtGrid.Item(5, i).Value)
        valFixo = Format(geral, "0.00")
        txtTot.Text = valFixo
        dtGrid.Rows.RemoveAt(i)
    End Sub

    Private Sub txtLimparTab_Click(sender As Object, e As EventArgs) Handles txtLimparTab.Click
        For x = 0 To dtGrid.RowCount - 1
            objpro.Devolver_estoque(dtGrid.Item(4, x).Value, dtGrid.Item(1, x).Value)
            estoque = estoque + dtGrid.Item(4, x).Value
        Next
        dtGrid.Rows.Clear()
        txtTot.Clear()
        txtDesc.Clear()
        cbmTipo.SelectedIndex = -1
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
        dtListDes = objdes.filtrar_por_status(False)
        For x = 0 To dtListDes.Rows.Count - 1
            listItem = "Conta de " & dtListDes.Rows(x).Item(1) _
            & " ainda não foi paga     Validade: " & dtListDes.Rows(x).Item(4)
            My.Forms.frmMenu.listNot.Items.Add(listItem)
        Next
        If dtGrid.RowCount > 0 Then
            For x = 0 To dtGrid.RowCount - 1
                objpro.Devolver_estoque(dtGrid.Item(4, x).Value, dtGrid.Item(1, x).Value)
                estoque = estoque + dtGrid.Item(4, x).Value
            Next
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class