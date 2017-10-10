Public Class frmLancaDespesa
    Dim objDesp As New clsDespesa
    Dim objLanDesp As New clsLancaDespesa
    Dim objCtl As New clsControle
    Dim objpro As New clsProduto
    Dim dtListPro As DataTable
    Dim dtListDes
    Dim listItem As String
    Dim novo As Boolean
    Dim linhaselecionada As Integer

    Private Sub frmLancaDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCtl.LimparTela(Me)
        objCtl.habilitarCampos(Me, False)
        objCtl.habilitarBotoes(Me, False)
        cboDesp.DisplayMember = "despDescri"
        cboDesp.ValueMember = "despCod"
        cboDesp.DataSource = objDesp.Exibir_combo
    End Sub

    Private Sub txtCodDesp_LostFocus(sender As Object, e As EventArgs) Handles txtCodDesp.LostFocus
        If txtCodDesp.Text <> "" Then
            If objDesp.Validar_chave(txtCodDesp.Text) = False Then
                MessageBox.Show("Cliente Inexistente")
                txtCodDesp.Clear()
                txtCodDesp.Focus()
            Else
                cboDesp.Text = objDesp.Descricao
            End If
        End If
    End Sub

    Private Sub btnNovo_Click_1(sender As Object, e As EventArgs) Handles btnNovo.Click
        objCtl.habilitarCampos(Me, True)
        objCtl.habilitarBotoes(Me, True)
        objCtl.LimparTela(Me)
        btnEditar.Enabled = False
        btnNovo.Enabled = False
        btnExcluir.Enabled = False
        txtCodDesp.Focus()
        novo = True
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        objCtl.habilitarCampos(Me, False)
        objCtl.habilitarBotoes(Me, True)
        If novo = False Then
            txtCodLan.Text = objLanDesp.Codigo.ToString
        End If
        objLanDesp.Cod_Despesas = cboDesp.SelectedValue
        objLanDesp.DataVenc = dtpDataVenci.Text
        objLanDesp.Valor = TxtValorDesp.Text
        If rbtSim.Checked Then
            objLanDesp.Status = True
        ElseIf rbtNao.Checked Then
            objLanDesp.Status = False
        End If
        objLanDesp.Gravar(novo)
        MessageBox.Show("Lançamento de Despesa feito com Sucesso!")

    End Sub

    Private Sub btnEditar_Click_1(sender As Object, e As EventArgs) Handles btnEditar.Click
        novo = False
        objCtl.habilitarCampos(Me, True)
        txtCodDesp.Focus()

        grpPago.Enabled = True
        btnGravar.Enabled = True
        btnExcluir.Enabled = True
    End Sub

    Private Sub btnExcluir_Click_1(sender As Object, e As EventArgs) Handles btnEditar.Click
        If objLanDesp.Excluir(txtCodLan.Text) Then
            objCtl.LimparTela(Me)
            btnExcluir.Enabled = False
            btnEditar.Enabled = False
        End If
        objCtl.habilitarBotoes(Me, False)
        objCtl.habilitarCampos(Me, False)
        btnNovo.Enabled = True
        btnSair.Enabled = True
        dtGrid.ClearSelection()
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call frmLancaDespesa_Load(Nothing, Nothing)
        objCtl.LimparTela(Me)
        objCtl.habilitarBotoes(Me, False)
        btnNovo.Enabled = True
        btnSair.Enabled = True
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtLoc.Text = "" Then
            MessageBox.Show("Digite o nome ou o código da despesa!!")
            txtLoc.Focus()
        Else
            dtGrid.DataSource = objLanDesp.localizar(txtLoc.Text)
        End If
    End Sub

    Private Sub dtGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid.CellDoubleClick
        If MessageBox.Show("Deseja editar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            linhaselecionada = e.RowIndex
            Me.txtCodLan.Text = dtGrid.Rows(linhaselecionada).Cells(0).Value
            Me.cboDesp.Text = dtGrid.Rows(linhaselecionada).Cells(1).Value
            Me.TxtValorDesp.Text = dtGrid.Rows(linhaselecionada).Cells(2).Value
            If dtGrid.Rows(linhaselecionada).Cells(3).Value.ToString = "Pago" Then
                Me.rbtSim.Checked = True
            ElseIf dtGrid.Rows(linhaselecionada).Cells(3).Value.ToString = "Não Pago" Then
                Me.rbtNao.Checked = True
            End If
            Me.dtpDataVenci.Text = dtGrid.Rows(linhaselecionada).Cells(4).Value
            btnNovo.Enabled = False
            btnEditar.Enabled = True
            btnEditar.Focus()
        End If
    End Sub

    Private Sub frmLancaDespesa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        dtListPro = objpro.verificarEstoque
        listItem = ""
        My.Forms.frmMenu.listNot.Items.Clear()
        For x = 0 To dtListPro.Rows.Count - 1
            listItem = dtListPro.Rows(x).Item(0) & " está acabando!" & "     Em estoque: " & dtListPro.Rows(x).Item(1) &
            "     Qtd Mínima: " & dtListPro.Rows(x).Item(2) & "     Qtd Máxima: " & dtListPro.Rows(x).Item(3)
            My.Forms.frmMenu.listNot.Items.Add(listItem)
        Next
        dtListDes = objLanDesp.filtrar_por_status(False)
        For x = 0 To dtListDes.Rows.Count - 1
            listItem = "Conta de " & dtListDes.Rows(x).Item(1) _
            & " ainda não foi paga     Validade: " & dtListDes.Rows(x).Item(4)
            My.Forms.frmMenu.listNot.Items.Add(listItem)
        Next
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class