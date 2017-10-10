Public Class frmCadOrcamento
    Dim objCtl As New clsControle
    Dim objOrc As New clsOrcamento
    Dim objcli As New clsCliente
    Dim objpro As New clsProduto
    Dim objpar As New clsParceira
    Dim objorcprod As New clsOrcamentoProduto
    Dim novo As Boolean
    Dim geral As Single
    Dim tot As Double
    Dim qtdAtacado As Integer

    Private Sub frmCadOrcamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCtl.LimparTela(Me)
        objCtl.habilitarCampos(Me, True)
        cboPar.DataSource = objpar.Exibir_combo
        cboPar.DisplayMember = "parNom"
        cboPar.ValueMember = "parCod"
        cboPar.SelectedIndex = -1
        txtData.Text = DateTime.Now
    End Sub
    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If txtCodPro.Text = "" Then
            MessageBox.Show("Preencha o Código Antes de Adicionar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodPro.Focus()
        ElseIf txtQtdPro.Text = "" Then
            MessageBox.Show("Preencha a Quantidade Antes de Adicionar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtQtdPro.Focus()

        Else
            dtGrid.Rows.Add(txtCodPro.Text, txtNomPro.Text, txtQtdPro.Text, txtPrePro.Text, txtSubPro.Text)

            Dim x As Integer
            For x = 0 To (dtGrid.Rows.Count - 1).ToString
                tot = dtGrid.Rows(x).Cells(4).Value

            Next
            If txtTot.Text = "" Then
                txtTot.Text = 0.0
            End If
            tot = tot + txtTot.Text
            txtTot.Text = tot

            txtCodPro.Clear()
            txtNomPro.Clear()
            txtQtdPro.Clear()
            txtPrePro.Clear()
            txtSubPro.Clear()
            txtCodPro.Focus()
        End If
    End Sub

    Private Sub txtQtdPro_TextChanged(sender As Object, e As EventArgs) Handles txtQtdPro.TextChanged
        If txtQtdPro.Text <> "" And txtCodPro.Text <> "" Then
            Dim estoque As Integer
            txtSubPro.Text = txtQtdPro.Text * txtPrePro.Text
            estoque = objpro.verificarQtdProd(txtCodPro.Text).ToString
            If txtQtdPro.Text > estoque Then
                MessageBox.Show("Possuímos apenas " & estoque & " itens", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
        End If
    End Sub

    Private Sub txtCodPro_TextChanged(sender As Object, e As EventArgs) Handles txtCodPro.TextChanged
        If txtCodPro.Text <> "" Then
            If objpro.Validar_chave3(txtCodPro.Text) = False Then
                MessageBox.Show("Produto não cadastrado!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCodPro.Clear()
                txtNomPro.Clear()
                txtPrePro.Clear()
                txtQtdPro.Clear()
                txtCodPro.Focus()
            Else
                txtNomPro.Text = objpro.Descricao

                qtdAtacado = objpro.Qtd_Atacado
                If txtQtdPro.Text < qtdAtacado.ToString Then
                    txtPrePro.Text = objpro.Preco_Varejo
                Else
                    txtPrePro.Text = objpro.Preco_Atacado
                End If
            End If
            txtQtdPro.Clear()
            txtQtdPro.Focus()
        End If

    End Sub

    Private Sub btnCriar_Click(sender As Object, e As EventArgs) Handles btnCriar.Click
        If Not objCtl.verificarVazio(Me) Then
            novo = True
            If cboPar.SelectedValue = 0 Then
                MessageBox.Show("Selecione o parceiro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cboPar.Focus()
            End If
            objOrc.Parceiro = cboPar.SelectedValue
            objOrc.Data = txtData.Text
            objOrc.valor = txtTot.Text
            objOrc.Gravar(novo)
            txtCodOrc.Text = objorc.Codigo

            Dim x As Integer
            For x = 0 To (dtGrid.Rows.Count - 1).ToString
                objorcprod.sequencia = x + 1
                objorcprod.quantidade = dtGrid.Rows(x).Cells(2).Value
                objorcprod.orcCod = txtCodOrc.Text
                objorcprod.codigoProduto = dtGrid.Rows(x).Cells(0).Value
                objorcprod.Gravar(novo)

            Next
            objCtl.LimparTela(Me)
            dtGrid.Rows.Clear()
            MessageBox.Show("Orçamento gravado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtLimparTab_Click(sender As Object, e As EventArgs) Handles txtLimparTab.Click
        dtGrid.Rows.Clear()
        txtTot.Clear()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
        If dtGrid.RowCount > 0 Then
            dtGrid.Rows.Clear()
        End If
    End Sub

    Private Sub dtGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid.CellContentClick

    End Sub
End Class