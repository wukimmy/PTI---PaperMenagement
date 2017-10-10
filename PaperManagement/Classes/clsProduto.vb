Public Class clsProduto
    Dim p_cod As Integer
    Dim p_codBarra As Long
    Dim p_descri As String
    Dim p_fabri As String
    Dim p_forn As Integer
    Dim p_familia As Integer
    Dim p_precoAtacado As Double
    Dim p_qtdAtacado As Integer
    Dim p_precoVarejo As Double
    Dim p_qtdAtual As Integer
    Dim p_qtdMin As Integer
    Dim p_qtdMax As Integer


    Dim sql As String
    Dim objBanco As New clsBanco
    Dim objdt As New DataTable

    Public Property Codigo_Interno As Integer
        Get
            Return p_cod
        End Get
        Set(value As Integer)
            p_cod = value
        End Set
    End Property

    Public Property Codigo_Barra As Long
        Get
            Return p_codBarra
        End Get
        Set(value As Long)
            p_codBarra = value
        End Set
    End Property

    Public Property Descricao As String
        Get
            Return p_descri
        End Get
        Set(value As String)
            p_descri = value
        End Set
    End Property

    Public Property Fabricante As String
        Get
            Return p_fabri
        End Get
        Set(value As String)
            p_fabri = value
        End Set
    End Property

    Public Property Fornecedor As Integer
        Get
            Return p_forn
        End Get
        Set(value As Integer)
            p_forn = value
        End Set
    End Property

    Public Property Familia As Integer
        Get
            Return p_familia
        End Get
        Set(value As Integer)
            p_familia = value
        End Set
    End Property
    Public Property Preco_Atacado As Double
        Get
            Return p_precoAtacado
        End Get
        Set(value As Double)
            p_precoAtacado = value
        End Set
    End Property

    Public Property Qtd_Atacado As Integer
        Get
            Return p_qtdAtacado
        End Get
        Set(value As Integer)
            p_qtdAtacado = value
        End Set
    End Property

    Public Property Preco_Varejo As Double
        Get
            Return p_precoVarejo
        End Get
        Set(value As Double)
            p_precoVarejo = value
        End Set
    End Property

    Public Property Qtd_Atual As Integer
        Get
            Return p_qtdAtual
        End Get
        Set(value As Integer)
            p_qtdAtual = value
        End Set
    End Property

    Public Property Qtd_Min As Integer
        Get
            Return p_qtdMin
        End Get
        Set(value As Integer)
            p_qtdMin = value
        End Set
    End Property

    Public Property Qtd_Max As Integer
        Get
            Return p_qtdMax
        End Get
        Set(value As Integer)
            p_qtdMax = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo Then
            sql = "INSERT INTO tabProduto " &
            "(proCodBarra " &
            ",proDesc" &
            ",proFabri" &
            ",fornCod" &
            ",famiCod" &
            ",proPrecoAtacado" &
            ",proQtdAtacado" &
            ",proPrecoVarejo" &
            ",proQtdAtual" &
            ",proQtdMin" &
            ",proQtdMax" &
            ") VALUES " &
            "( " & p_codBarra & " " &
            ",'" & p_descri & "'" &
            ",'" & p_fabri & "'" &
            ", " & p_forn & " " &
            ", " & p_familia & " " &
            ",'" & p_precoAtacado & "'" &
            ",'" & p_qtdAtacado & "'" &
            ",'" & p_precoVarejo & "'" &
            ",'" & p_qtdAtual & "'" &
            ",'" & p_qtdMin & "'" &
            ",'" & p_qtdMax & "'" &
            ")"
            objBanco.executar_comando(sql)
            sql = "SELECT MAX (proCod) FROM tabProduto"
            objdt = objBanco.buscar(sql)
            p_cod = objdt.Rows(0).Item(0)
        Else
            sql = "UPDATE tabProduto SET " &
            " proCodBarra = " & p_codBarra & "" &
            ",proDesc = '" & p_descri & "'" &
            ",proFabri = '" & p_fabri & "'" &
            ",fornCod = '" & p_forn & "'" &
            ",famiCod = '" & p_familia & "'" &
            ",proPrecoAtacado = '" & p_precoAtacado & "'" &
            ",proQtdAtacado = '" & p_qtdAtacado & "'" &
            ",proPrecoVarejo = '" & p_precoVarejo & "'" &
            ",proQtdAtual = '" & p_qtdAtual & "'" &
            ",proQtdMin = '" & p_qtdMin & "'" &
            ",proQtdMax = '" & p_qtdMax & "'" &
            " WHERE proCod=" & p_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function Excluir(cod As Integer) As Boolean
        If MessageBox.Show("Deseja excluir ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "DELETE * FROM tabProduto WHERE proCod =" & cod
            objBanco.executar_comando(sql)
            Return True
        End If
        Return False
    End Function

    Public Function Validar_chave(campo As Integer) As Boolean
        sql = "SELECT tabProduto.proDesc, tabProduto.proQtdAtual, tabProduto.proQtdAtacado, tabProduto.proPrecoAtacado, tabProduto.proPrecoVarejo  FROM tabProduto WHERE proCod=" & campo
        objdt = objBanco.buscar(sql)
        If objdt.Rows.Count = 1 Then
            p_descri = objdt.Rows(0).Item(0)
            p_qtdAtual = objdt.Rows(0).Item(1)
            p_qtdAtacado = objdt.Rows(0).Item(2)
            p_precoAtacado = objdt.Rows(0).Item(3)
            p_precoVarejo = objdt.Rows(0).Item(4)
            ''p_cod = objdt.Rows(0).Item(0)
            '' p_codBarra = objdt.Rows(0).Item(1)
            '' p_descri = objdt.Rows(0).Item(2)
            '' p_fabri = objdt.Rows(0).Item(3)
            '' p_familia = objdt.Rows(0).Item(4)
            '' p_precoAtacado = objdt.Rows(0).Item(5)
            '' p_qtdAtacado = objdt.Rows(0).Item(6)
            ''p_precoVarejo = objdt.Rows(0).Item(7)
            '' p_qtdAtual = objdt.Rows(0).Item(8)
            ''p_qtdMin = objdt.Rows(0).Item(9)
            ''p_qtdMax = objdt.Rows(0).Item(10)
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub Baixar_estoque(QTD As Integer, CodigoProduto As Integer)
        sql = "UPDATE tabProduto SET proQtdAtual = proQtdAtual - " & QTD & " WHERE proCod=" & CodigoProduto
        objBanco.Executar_comando(sql)
    End Sub

    Public Sub Devolver_estoque(QTD As Integer, CodigoProduto As Integer)
        sql = "UPDATE tabProduto SET proQtdAtual = proQtdAtual +" & QTD & " WHERE proCod=" & CodigoProduto
        objBanco.Executar_comando(sql)
    End Sub

    Public Function localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT tabProduto.proCod, tabProduto.proCodBarra, tabProduto.proDesc, tabProduto.proFabri, (tabFornecedor.fornNom) as fornCod, (tabFamilia.famiDesc) as famiCod, tabProduto.proPrecoAtacado, tabProduto.proQtdAtacado, tabProduto.proPrecoVarejo, tabProduto.proQtdAtual, tabProduto.proQtdMin, tabProduto.proQtdMax FROM tabFornecedor INNER JOIN( tabProduto INNER JOIN tabFamilia ON tabProduto.famiCod = tabFamilia.famiCod) ON tabProduto.fornCod = tabFornecedor.fornCod WHERE proCod=" & campo
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Produto Inexistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
            End If
        Else
            sql = "SELECT tabProduto.proCod, tabProduto.proCodBarra, tabProduto.proDesc, tabProduto.proFabri, (tabFornecedor.fornNom) as fornCod, (tabFamilia.famiDesc) as famiCod, tabProduto.proPrecoAtacado, tabProduto.proQtdAtacado, tabProduto.proPrecoVarejo, tabProduto.proQtdAtual, tabProduto.proQtdMin, tabProduto.proQtdMax FROM tabFornecedor INNER JOIN( tabProduto INNER JOIN tabFamilia ON tabProduto.famiCod = tabFamilia.famiCod) ON tabProduto.fornCod = tabFornecedor.fornCod WHERE proDesc= '" & campo & "'"
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Produto Inexistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        Return objBanco.buscar(sql)
    End Function

    Public Function busca_rapidaProd(campo As String) As Integer
        sql = "SELECT tabProduto.proCod FROM tabProduto WHERE proDesc = '" & campo & "'"
        objdt = objBanco.buscar(sql)

        Return objdt.Rows(0).Item(0).ToString
    End Function

    Public Function Validar_chave2(campo As Integer) As Boolean
        sql = "SELECT * FROM tabProduto WHERE proCod=" & campo
        objdt = objBanco.buscar(sql)
        If objdt.Rows.Count = 0 Then
            MessageBox.Show("Produto Inexistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            p_descri = objdt.Rows(0).Item(3)
            Return True
        End If
    End Function

    Public Function localizarEstoque(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT tabProduto.proCod, tabProduto.proCodBarra, tabProduto.proDesc, tabProduto.proFabri, (tabFornecedor.fornNom) as fornCod, (tabFamilia.famiDesc) as famiCod, tabProduto.proPrecoAtacado, tabProduto.proQtdAtacado, tabProduto.proPrecoVarejo, tabProduto.proQtdAtual, tabProduto.proQtdMin, tabProduto.proQtdMax FROM tabFornecedor INNER JOIN( tabProduto INNER JOIN tabFamilia ON tabProduto.famiCod = tabFamilia.famiCod) ON tabProduto.fornCod = tabFornecedor.fornCod WHERE proCod=" & campo
            objdt = objBanco.buscar(sql)
        Else
            sql = "SELECT tabProduto.proCod, tabProduto.proCodBarra, tabProduto.proDesc, tabProduto.proFabri, (tabFornecedor.fornNom) as fornCod, (tabFamilia.famiDesc) as famiCod, tabProduto.proPrecoAtacado, tabProduto.proQtdAtacado, tabProduto.proPrecoVarejo, tabProduto.proQtdAtual, tabProduto.proQtdMin, tabProduto.proQtdMax FROM tabFornecedor INNER JOIN( tabProduto INNER JOIN tabFamilia ON tabProduto.famiCod = tabFamilia.famiCod) ON tabProduto.fornCod = tabFornecedor.fornCod WHERE proDesc= '" & campo & "'"
            objdt = objBanco.buscar(sql)
        End If
        Return objBanco.buscar(sql)
    End Function

    Public Function listar() As DataTable
        sql = "SELECT tabProduto.proDesc, tabProduto.proPrecoVarejo, tabProduto.proQtdAtual, tabProduto.proQtdMin, tabProduto.proQtdMax FROM tabProduto"
        Return objBanco.buscar(sql)
    End Function

    Public Function verificarEstoque() As DataTable
        sql = "SELECT tabProduto.proDesc, tabProduto.proQtdAtual, tabProduto.proQtdMin, tabProduto.proQtdMax FROM tabProduto WHERE tabProduto.proQtdAtual - 5 <= tabProduto.proQtdMin"
        objdt = objBanco.buscar(sql)
        Return objdt
    End Function
    Public Function verificarQtdProd(cod As Integer) As Integer
        sql = "SELECT tabProduto.proQtdAtual FROM tabProduto WHERE proCod = " & cod
        objdt = objBanco.buscar(sql)

        Return objdt.Rows(0).Item(0).ToString
    End Function
    Public Function Validar_chave3(campo As Integer) As Boolean
        sql = "SELECT * FROM tabProduto WHERE proCod=" & campo
        objdt = objBanco.buscar(sql)
        If objdt.Rows.Count = 1 Then
            
            p_cod = objdt.Rows(0).Item(0)

            p_descri = objdt.Rows(0).Item(2)
            p_fabri = objdt.Rows(0).Item(3)
            p_familia = objdt.Rows(0).Item(4)
            p_precoAtacado = objdt.Rows(0).Item(5)
            p_qtdAtacado = objdt.Rows(0).Item(6)
            p_precoVarejo = objdt.Rows(0).Item(7)
            p_qtdAtual = objdt.Rows(0).Item(8)
            p_qtdMin = objdt.Rows(0).Item(9)
            p_qtdMax = objdt.Rows(0).Item(10)
            Return True
        Else
            Return False
        End If
    End Function
    Public Function localizarEstoque2(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT tabProduto.proDesc,  tabProduto.proPrecoVarejo, tabProduto.proQtdAtual, tabProduto.proQtdMin, tabProduto.proQtdMax FROM tabProduto WHERE proCod=" & campo
            objdt = objBanco.buscar(sql)
        Else
            sql = "SELECT tabProduto.proDesc,  tabProduto.proPrecoVarejo, tabProduto.proQtdAtual, tabProduto.proQtdMin, tabProduto.proQtdMax FROM tabProduto WHERE proDesc= '" & campo & "'"
            objdt = objBanco.buscar(sql)
        End If
        Return objBanco.buscar(sql)
    End Function
End Class

