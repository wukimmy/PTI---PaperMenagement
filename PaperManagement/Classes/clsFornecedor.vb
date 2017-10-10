Public Class clsFornecedor
    Dim f_cod As Integer
    Dim f_cnpj As String
    Dim f_nom As String
    Dim f_tel As String
    Dim f_cep As String
    Dim f_endereco As String
    Dim f_email As String

    Dim sql As String
    Dim objBanco As New clsBanco

    Public Property codigo As Integer
        Get
            Return f_cod
        End Get
        Set(value As Integer)
            f_cod = value
        End Set
    End Property

    Public Property cnpj As Double
        Get
            Return f_cnpj
        End Get
        Set(value As Double)
            f_cnpj = value
        End Set
    End Property

    Public Property nome As String
        Get
            Return f_nom
        End Get
        Set(value As String)
            f_nom = value
        End Set
    End Property

    Public Property telefone As String
        Get
            Return f_tel
        End Get
        Set(value As String)
            f_tel = value
        End Set
    End Property

    Public Property cep As String
        Get
            Return f_cep
        End Get
        Set(value As String)
            f_cep = value
        End Set
    End Property
    Public Property endereco As String
        Get
            Return f_endereco
        End Get
        Set(value As String)
            f_endereco = value
        End Set
    End Property

    Public Property email As String
        Get
            Return f_email
        End Get
        Set(value As String)
            f_email = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo Then
            sql = "INSERT INTO tabFornecedor " &
            "(fornCNPJ " &
            ", fornNom" &
            ", fornTel" &
            ", fornCEP" &
            ", fornEndereco" &
            ", fornEmail" &
            ") VALUES " &
            "('" & f_cnpj & "'" &
            ",'" & f_nom & "'" &
            ",'" & f_tel & "'" &
            ",'" & f_cep & "'" &
            ",'" & f_endereco & "'" &
            ",'" & f_email & "'" &
            ")"
            objBanco.executar_comando(sql)
            sql = "SELECT MAX (fornCod) FROM tabFornecedor"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            f_cod = objdt.Rows(0).Item(0)
        Else
            sql = "UPDATE tabFornecedor SET " &
            " fornCNPJ = " & f_cnpj & "" &
            ",fornNom = '" & f_nom & "'" &
            ",fornTel = '" & f_tel & "'" &
            ",fornCEP = '" & f_cep & "'" &
            ",fornEndereco = '" & f_endereco & "'" &
            ",fornEmail = '" & f_email & "'" &
            " WHERE fornCod=" & f_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function Excluir(cod As Integer) As Boolean
        If MessageBox.Show("Deseja excluir ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "DELETE FROM tabFornecedor WHERE fornCod=" & cod
            objBanco.executar_comando(sql)
            Return True
        End If
        Return False
    End Function

    Public Function localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT tabFornecedor.fornCod, tabFornecedor.fornNom, tabFornecedor.fornTel, tabFornecedor.fornEmail, tabProduto.proCod, tabProduto.proCodBarra, tabProduto.proDesc FROM tabProduto INNER JOIN (Fornecedor_Produto INNER JOIN tabFornecedor ON tabFornecedor.fornCod = Fornecedor_Produto.fornCod) ON tabProduto.proCod = Fornecedor_Produto.proCod WHERE tabFornecedor.fornCod =" & campo
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
        Else
            sql = "SELECT tabFornecedor.fornCod, tabFornecedor.fornNom, tabFornecedor.fornTel, tabFornecedor.fornEmail, tabProduto.proCod, tabProduto.proCodBarra, tabProduto.proDesc FROM tabProduto INNER JOIN (Fornecedor_Produto INNER JOIN tabFornecedor ON tabFornecedor.fornCod = Fornecedor_Produto.fornCod) ON tabProduto.proCod = Fornecedor_Produto.proCod WHERE tabFornecedor.fornNom = '" & campo & "'"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
        End If
            Return objBanco.buscar(sql)
    End Function
    Public Function busca_rapidaForn(campo As String) As Integer
        sql = "SELECT tabFornecedor.fornCod FROM tabFornecedor WHERE fornNom = '" & campo & "'"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)

        Return objdt.Rows(0).Item(0).ToString
    End Function
    Public Function Validar_chave(campo As Integer) As Boolean

        sql = "select * from tabFornecedor where fornCod=" & campo

        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        If objdt.Rows.Count = 0 Then
            MessageBox.Show("fornecedor Inexistente")
            Return False
        Else
            f_nom = objdt.Rows(0).Item(2)
            Return True
        End If

    End Function
    Public Function localizar2(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "select * from tabFornecedor where fornCod=" & campo
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Fornecedor Inexistente")
            End If
        Else
            sql = "select * from tabFornecedor where fornNom='" & campo & "'"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Fornecedor Inexistente")
            End If
        End If
        Return objBanco.buscar(sql)
    End Function
    Public Function Exibir_combo() As DataTable
        sql = "SELECT * FROM tabFornecedor ORDER BY fornNom"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        Return objdt
    End Function
End Class
