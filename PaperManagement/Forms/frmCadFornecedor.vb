Public Class frmCadFornecedor
    Dim novo As Boolean
    Dim objctl As New clsControle
    Dim objforn As New clsFornecedor
    Dim objval As New clsValidacao
    Dim linhaselecionada As Integer
    Dim dataSource As DataTable

    Private Sub frmCadFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txtNome.Focus()
        novo = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        novo = False
        objctl.habilitarCampos(Me, True)
        objctl.habilitarBotoes(Me, True)
        btnGravar.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        objctl.habilitarCampos(Me, False)
        objctl.habilitarBotoes(Me, False)
        If novo = False Then
            objforn.codigo = txtCod.Text
            objctl.habilitarCampos(Me, False)
        End If
        objforn.nome = txtNome.Text
        objforn.cnpj = txtCnpj.Text
        objforn.telefone = txtTel.Text
        objforn.cep = txtCEP.Text
        objforn.endereco = txtEndereco.Text
        objforn.email = txtEmail.Text
        objforn.Gravar(novo)
        MessageBox.Show("Produto Gravado com Sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        txtCod.Text = objforn.codigo.ToString
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If objforn.Excluir(txtCod.Text) Then
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
        Call frmCadFornecedor_Load(Nothing, Nothing)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtLoc.Text = "" Then
            MessageBox.Show("Digite o nome ou o codigo do fornecedor!!")
            txtLoc.Focus()
        Else
            dataSource = objforn.localizar2(txtLoc.Text)
            dtGrid.DataSource = dataSource
            txtLoc.Text = ""
            If dtGrid.RowCount = 0 Then
                MessageBox.Show("Fornecedor Inexistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtLoc.Focus()
            End If
        End If
    End Sub
    Private Sub dtGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid.CellDoubleClick
        If MessageBox.Show("Deseja editar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            linhaselecionada = e.RowIndex
            Me.txtCod.Text = dtGrid.Rows(linhaselecionada).Cells(0).Value
            Me.txtCnpj.Text = dtGrid.Rows(linhaselecionada).Cells(1).Value
            Me.txtNome.Text = dtGrid.Rows(linhaselecionada).Cells(2).Value
            Me.txtTel.Text = dtGrid.Rows(linhaselecionada).Cells(3).Value
            Me.txtCEP.Text = dtGrid.Rows(linhaselecionada).Cells(4).Value
            Me.txtEndereco.Text = dtGrid.Rows(linhaselecionada).Cells(5).Value
            Me.txtEmail.Text = dtGrid.Rows(linhaselecionada).Cells(6).Value
            btnNovo.Enabled = False
            btnEditar.Enabled = True
            btnEditar.Focus()
            dataSource.Clear()
            dtGrid.Refresh()
        End If
    End Sub

    Private Sub txtCnpj_LostFocus(sender As Object, e As EventArgs) Handles txtCnpj.LostFocus
        If txtCnpj.Text = "" Then
            If MessageBox.Show("Desejar continuar sem digitar o CNPJ?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                txtCnpj.Focus()
            End If
        Else
            If objval.IsCNPJ(txtCnpj.Text) = False Then
                txtCnpj.Clear()
                txtCnpj.Focus()
            End If
            End If
    End Sub
    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        objval.validarEmail(txtEmail.Text)
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class