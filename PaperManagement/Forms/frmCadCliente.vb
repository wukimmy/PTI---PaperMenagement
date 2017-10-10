Public Class frmCadCliente
    Dim novo As Boolean
    Dim objctl As New clsControle
    Dim objcli As New clsCliente
    Dim objval As New clsValidacao
    Dim linhaselecionada As Integer
    Dim dataSource As DataTable

    Private Sub frmCadCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dtGrid.RowCount <> 0 Then
            dataSource.Clear()
            dtGrid.Refresh()
        End If
        If Application.OpenForms.OfType(Of frmCadVenda)().Count() > 0 Then
            objctl.habilitarCampos(Me, True)
            objctl.habilitarBotoes(Me, True)
            objctl.LimparTela(Me)
            btnEditar.Enabled = False
            btnNovo.Enabled = False
            btnExcluir.Enabled = False
            txtCpf.Text = My.Forms.frmCadVenda.txtCli.Text
            txtCpf.Focus()
            novo = True
        Else
            objctl.LimparTela(Me)
            objctl.habilitarCampos(Me, False)
            objctl.habilitarBotoes(Me, False)
        End If
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        objctl.habilitarCampos(Me, True)
        objctl.habilitarBotoes(Me, True)
        objctl.LimparTela(Me)
        txtTel.Focus()
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
        If rbtSim.Checked Then
            objcli.mensalista = True
        ElseIf rbtNao.Checked Then
            objcli.mensalista = False
        End If
        objcli.nome = txtNome.Text
        objcli.telefone = txtTel.Text
        objcli.cpf = txtCpf.Text
        objcli.email = txtEmail.Text
        objcli.Gravar(novo)
        txtCod.Text = objcli.codigo.ToString
        MessageBox.Show("Cliente Gravado com Sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        objctl.LimparTela(Me)
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If objcli.Excluir(txtCod.Text) Then
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
        Call frmCadCliente_Load(Nothing, Nothing)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtLoc.Text = "" Then
            MessageBox.Show("Digite o nome ou o codigo do cliente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLoc.Focus()
        Else
            dataSource = objcli.localizar(txtLoc.Text)
            dtGrid.DataSource = dataSource
            txtLoc.Text = ""
            If dtGrid.RowCount = 0 Then
                MessageBox.Show("Cliente Inexistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtLoc.Focus()
            End If
        End If
    End Sub

    Private Sub dtGrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid.CellContentDoubleClick
        If MessageBox.Show("Deseja editar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            linhaselecionada = e.RowIndex
            Me.txtCod.Text = dtGrid.Rows(linhaselecionada).Cells(0).Value
            Me.txtCpf.Text = dtGrid.Rows(linhaselecionada).Cells(4).Value
            Me.txtNome.Text = dtGrid.Rows(linhaselecionada).Cells(1).Value
            Me.txtTel.Text = dtGrid.Rows(linhaselecionada).Cells(2).Value
            Me.txtEmail.Text = dtGrid.Rows(linhaselecionada).Cells(3).Value
            If dtGrid.Rows(linhaselecionada).Cells(5).Value = "Sim" Then
                rbtSim.Checked = True
            ElseIf dtGrid.Rows(linhaselecionada).Cells(5).Value = "Não" Then
                rbtNao.Checked = True
            End If
            btnNovo.Enabled = False
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
            btnEditar.Focus()
            dataSource.Clear()
            dtGrid.Refresh()
        End If
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        ' If objctl.validarEmail(txtEmail.Text) = False Then
        'txtEmail.Clear()
        ' txtEmail.Focus()
        'End If
        objval.validarEmail(txtEmail.Text)
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

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class