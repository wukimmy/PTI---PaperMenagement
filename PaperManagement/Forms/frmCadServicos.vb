Public Class frmCadServicos
    Dim novo As Boolean
    Dim objCtl As New clsControle
    Dim objSer As New clsServico
    Dim linhaselecionada As Integer
    Dim dataSource As DataTable

    Private Sub frmCadServicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dtGrid.RowCount <> 0 Then
            dataSource.Clear()
            dtGrid.Refresh()
        End If
        objCtl.LimparTela(Me)
        objCtl.habilitarCampos(Me, False)
        objCtl.habilitarBotoes(Me, False)
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        objCtl.habilitarCampos(Me, True)
        objCtl.habilitarBotoes(Me, True)
        objCtl.LimparTela(Me)
        txtNomSer.Focus()
        novo = True
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        objCtl.habilitarCampos(Me, False)
        objCtl.habilitarBotoes(Me, False)
        objSer.Descricao = txtNomSer.Text
        objSer.Preco = txtPreSer.Text
        If novo = False Then
            objSer.Codigo = txtCodServ.Text
        End If
        objSer.Gravar(novo)
        MessageBox.Show("Gravado com sucesso!")
        txtCodServ.Text = objSer.Codigo
        btnGravar.Enabled = False
        btnEditar.Enabled = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        novo = False
        objCtl.habilitarCampos(Me, True)
        objCtl.habilitarBotoes(Me, True)
        btnGravar.Enabled = True
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If objSer.Excluir(txtCodServ.Text) Then
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call frmCadServicos_Load(Nothing, Nothing)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtLoc.Text = "" Then
            MessageBox.Show("Digite o nome ou o codigo do serviço!!")
            txtLoc.Focus()
        Else
            dataSource = objSer.localizar(txtLoc.Text)
            dtGrid.DataSource = dataSource
            txtLoc.Text = ""
            If dtGrid.RowCount = 0 Then
                MessageBox.Show("Serviço Inexistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtLoc.Focus()
            End If
        End If
    End Sub

    Private Sub dtGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid.CellDoubleClick
        If MessageBox.Show("Deseja editar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            linhaselecionada = e.RowIndex
            Me.txtCodServ.Text = dtGrid.Rows(linhaselecionada).Cells(0).Value
            Me.txtNomSer.Text = dtGrid.Rows(linhaselecionada).Cells(1).Value
            Me.txtPreSer.Text = dtGrid.Rows(linhaselecionada).Cells(2).Value
            btnNovo.Enabled = False
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
            btnEditar.Focus()
            dataSource.Clear()
            dtGrid.Refresh()
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class