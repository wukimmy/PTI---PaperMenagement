Public Class frmCadProduto
    Dim objctl As New clsControle
    Dim objProd As New clsProduto
    Dim objForn As New clsFornecedor
    Dim objFam As New clsFamilia
    Dim objdes As New clsLancaDespesa
    Dim dtListPro As DataTable
    Dim dtListDes
    Dim listItem As String
    Dim novo As Boolean
    Dim linhaselecionada As Integer
    Dim familia As String
    Dim fornecedor As String
    Dim dataSource As DataTable

    Private Sub frmCadProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dtGrid.RowCount <> 0 Then
            dataSource.Clear()
            dtGrid.Refresh()
        End If
        objctl.LimparTela(Me)
        objctl.habilitarCampos(Me, False)
        objctl.habilitarBotoes(Me, False)
        cboFam.DataSource = objFam.Exibir_combo
        cboFam.DisplayMember = "famiDesc"
        cboFam.ValueMember = "famiCod"
        cboFam.SelectedIndex = -1
        cboforn.DataSource = objForn.Exibir_combo
        cboforn.DisplayMember = "fornNom"
        cboforn.ValueMember = "fornCod"
        cboforn.SelectedIndex = -1
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        objctl.habilitarCampos(Me, True)
        objctl.habilitarBotoes(Me, True)
        objctl.LimparTela(Me)
        txtCodBar.Focus()
        novo = True
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        objctl.habilitarCampos(Me, False)
        objctl.habilitarBotoes(Me, False)
        If novo = False Then
            objProd.Codigo_Interno = txtCodPro.Text
            objctl.habilitarCampos(Me, False)
        End If
        objProd.Codigo_Barra = txtCodBar.Text
        objProd.Descricao = txtNom.Text
        objProd.Fabricante = txtFabri.Text
        objProd.Fornecedor = cboforn.SelectedValue
        objProd.Familia = cboFam.SelectedValue
        objProd.Preco_Atacado = txtPrecAta.Text
        objProd.Qtd_Atacado = txtQtdAtac.Text
        objProd.Preco_Varejo = txtPrecVar.Text
        objProd.Qtd_Atual = txtQtdAtu.Text
        objProd.Qtd_Max = txtQtdMax.Text
        objProd.Qtd_Min = txtQtdMin.Text
        objProd.Gravar(novo)
        MessageBox.Show("Produto Gravado com Sucesso!")
        txtCodPro.Text = objProd.Codigo_Interno.ToString
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
        If objProd.Excluir(txtCodPro.Text) Then
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
        Call frmCadProduto_Load(Nothing, Nothing)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtLoc.Text = "" Then
            MessageBox.Show("Digite o nome ou o codigo do produto!!")
            txtLoc.Focus()
        Else
            dataSource = objProd.localizar(txtLoc.Text)
            dtGrid.DataSource = dataSource
            txtLoc.Text = ""
            If dtGrid.RowCount = 0 Then
                MessageBox.Show("Produto Inexistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtLoc.Focus()
            End If
        End If
    End Sub


    Private Sub dtGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid.CellDoubleClick
        If MessageBox.Show("Deseja editar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            linhaselecionada = e.RowIndex
            fornecedor = dtGrid.Rows(linhaselecionada).Cells(4).Value
            Me.cboforn.Text = fornecedor.ToString
            familia = dtGrid.Rows(linhaselecionada).Cells(5).Value
            Me.cboFam.Text = familia.ToString
            Me.txtCodPro.Text = dtGrid.Rows(linhaselecionada).Cells(0).Value
            Me.txtCodBar.Text = dtGrid.Rows(linhaselecionada).Cells(1).Value
            Me.txtNom.Text = dtGrid.Rows(linhaselecionada).Cells(2).Value
            Me.txtFabri.Text = dtGrid.Rows(linhaselecionada).Cells(3).Value
            ' Me.TxtFamilia.Text = objFam.busca_rapidaFam(familia)
            'Me.txtForne.Text = objForn.busca_rapidaForn(fornecedor)
            Me.txtPrecAta.Text = dtGrid.Rows(linhaselecionada).Cells(6).Value
            Me.txtQtdAtac.Text = dtGrid.Rows(linhaselecionada).Cells(7).Value
            Me.txtPrecVar.Text = dtGrid.Rows(linhaselecionada).Cells(8).Value
            Me.txtQtdAtu.Text = dtGrid.Rows(linhaselecionada).Cells(9).Value
            Me.txtQtdMin.Text = dtGrid.Rows(linhaselecionada).Cells(10).Value
            Me.txtQtdMax.Text = dtGrid.Rows(linhaselecionada).Cells(11).Value
            btnNovo.Enabled = False
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
            btnEditar.Focus()
            dataSource.Clear()
            dtGrid.Refresh()
        End If
    End Sub

    Private Sub txtForne_LostFocus(sender As Object, e As EventArgs)
        ' If txtForne.Text <> "" Then
        ' If objForn.Validar_chave(txtForne.Text) = False Then
        'MessageBox.Show("Fornecedor Inexistente")
        '  txtForne.Clear()
        '  txtForne.Focus()
        ' Else
        ' cboforn.Text = objForn.nome
        ' End If
        ' End If
    End Sub

    Private Sub TxtFamilia_LostFocus(sender As Object, e As EventArgs)
        ' If TxtFamilia.Text <> "" Then
        'If objFam.Validar_chave(TxtFamilia.Text) = False Then
        'MessageBox.Show("Familia Inexistente")
        ' TxtFamilia.Clear()
        ' TxtFamilia.Focus()
        ' Else
        ' cboFam.Text = objFam.descricao
        ' End If
        ' End If
    End Sub

    Private Sub btnAddFami_Click(sender As Object, e As EventArgs) Handles btnAddFami.Click
        frmCadFamilia.Show()
    End Sub

    Private Sub frmCadProduto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        dtListPro = objProd.verificarEstoque
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
        My.Forms.frmEstoque.dtGrid.DataSource = objProd.listar
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class