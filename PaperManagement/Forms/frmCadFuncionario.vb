Public Class frmCadFuncionario
    Dim novo As Boolean
    Dim objctl As New clsControle
    Dim objfun As New clsFuncionario
    Dim objval As New clsValidacao
    Dim linhaselecionada As Integer
    Dim dataSource As DataTable

    Private Sub frmCadFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txtData.Focus()
        novo = True
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        objctl.habilitarCampos(Me, False)
        objctl.habilitarBotoes(Me, False)
        If novo = False Then
            txtCod.Text = objfun.codigo.ToString
        End If
        objfun.nome = txtNome.Text
        objfun.cep = txtCep.Text
        objfun.Numero = txtNumero.Text
        objfun.telefone = txtTel.Text
        objfun.cpf = txtCpf.Text
        objfun.dtAdmissao = txtData.Text
        objfun.Gravar(novo)
        MessageBox.Show("Funcionário Gravado com Sucesso!")
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
        If objfun.Excluir(txtCod.Text) Then
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
        Call frmCadFuncionario_Load(Nothing, Nothing)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtLoc.Text = "" Then
            MessageBox.Show("Digite o nome ou o código do funcionário!!")
            txtLoc.Focus()
        Else
            dataSource = objfun.localizar(txtLoc.Text)
            dtGrid.DataSource = dataSource
            txtLoc.Text = ""
            If dtGrid.RowCount = 0 Then
                MessageBox.Show("Funcionário Inexistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtLoc.Focus()
            End If
        End If
    End Sub

    Private Sub dtGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid.CellDoubleClick
        If MessageBox.Show("Deseja editar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            linhaselecionada = e.RowIndex
            Me.txtCod.Text = dtGrid.Rows(linhaselecionada).Cells(0).Value
            Me.txtNome.Text = dtGrid.Rows(linhaselecionada).Cells(1).Value
            Me.txtTel.Text = dtGrid.Rows(linhaselecionada).Cells(2).Value
            Me.txtCEP.Text = dtGrid.Rows(linhaselecionada).Cells(3).Value
            Me.txtNumero.Text = dtGrid.Rows(linhaselecionada).Cells(4).Value
            Me.txtCpf.Text = dtGrid.Rows(linhaselecionada).Cells(5).Value
            Me.txtData.Text = dtGrid.Rows(linhaselecionada).Cells(6).Value
            btnNovo.Enabled = False
            btnEditar.Enabled = True
            btnEditar.Focus()
            dataSource.Clear()
            dtGrid.Refresh()
        End If
    End Sub

    Private Sub txtCpf_LostFocus(sender As Object, e As EventArgs) Handles txtCpf.LostFocus
        If txtCpf.Text = "" Then
            If MessageBox.Show("Desejar continuar sem digitar o CPF?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                txtCpf.Focus()
            End If
        Else
            objval.FU_ValidaCPF(txtCpf.Text)
        End If
    End Sub

    Private Sub BbtnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class