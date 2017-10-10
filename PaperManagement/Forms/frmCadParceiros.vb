Public Class FrmCadParceiros
    Dim objctl As New clsControle
    Dim objpar As New clsParceira
    Dim objval As New clsValidacao
    Dim novo As Boolean
    Dim linhaselecionada As Integer
    Dim dataSource As DataTable

    Private Sub FrmCadParceiros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txtTel.Focus()
        novo = True
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        objctl.habilitarCampos(Me, False)
        objctl.habilitarBotoes(Me, False)
        objpar.nome = txtNomPar.Text
        objpar.Cep = txtCEP.Text
        objpar.Num = txtNum.Text
        objpar.telefone = txtTel.Text
        objpar.email = txtEmail.Text
        objpar.Gravar(novo)
        txtCod.Text = objpar.codigo.ToString
        MessageBox.Show("Parceiro Gravada com Sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        btnEditar.Enabled = True
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
        If objpar.Excluir(txtCod.Text) Then
            objctl.LimparTela(Me)
            btnExcluir.Enabled = False
            btnEditar.Enabled = False
            objctl.habilitarCampos(Me, False)
        End If
        objctl.habilitarBotoes(Me, False)
        btnNovo.Enabled = True
        btnSair.Enabled = True
        dtGrid.ClearSelection()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call FrmCadParceiros_Load(Nothing, Nothing)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtLoc.Text = "" Then
            MessageBox.Show("Digite o nome ou o codigo do parceiro!!")
            txtLoc.Focus()
        Else
            dataSource = objpar.localizar(txtLoc.Text)
            dtGrid.DataSource = dataSource
            txtLoc.Text = ""
            If dtGrid.RowCount = 0 Then
                MessageBox.Show("Parceiro Inexistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtLoc.Focus()
            End If
        End If
    End Sub

    Private Sub dtGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid.CellDoubleClick
        If MessageBox.Show("Deseja editar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            linhaselecionada = e.RowIndex
            Me.txtCod.Text = dtGrid.Rows(linhaselecionada).Cells(0).Value
            Me.txtNomPar.Text = dtGrid.Rows(linhaselecionada).Cells(1).Value
            Me.txtCEP.Text = dtGrid.Rows(linhaselecionada).Cells(2).Value
            Me.txtNum.Text = dtGrid.Rows(linhaselecionada).Cells(3).Value
            Me.txtTel.Text = dtGrid.Rows(linhaselecionada).Cells(4).Value
            Me.txtEmail.Text = dtGrid.Rows(linhaselecionada).Cells(5).Value
            btnNovo.Enabled = False
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
            btnEditar.Focus()
            dataSource.Clear()
            dtGrid.Refresh()
        End If
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        objval.validarEmail(txtEmail.Text)
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class