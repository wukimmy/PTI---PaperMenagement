Public Class clsEntradaProd
    Dim e_cod As Integer
    Dim e_pro As Integer
    Dim e_data As Date
    Dim e_preco As Double
    Dim e_qtd As Integer

    Dim sql As String
    Dim objBanco As New clsBanco

    Public Property Codigo_lancamento As Integer
        Get
            Return e_cod
        End Get
        Set(value As Integer)
            e_cod = value
        End Set
    End Property

    Public Property Codigo_Produto As Integer
        Get
            Return e_pro
        End Get
        Set(value As Integer)
            e_pro = value
        End Set
    End Property

    Public Property Data_Entrada As Date
        Get
            Return e_data
        End Get
        Set(value As Date)
            e_data = value
        End Set
    End Property

    Public Property Preco As Double
        Get
            Return e_preco
        End Get
        Set(value As Double)
            e_preco = value
        End Set
    End Property

    Public Property Quantidade As Integer
        Get
            Return e_qtd
        End Get
        Set(value As Integer)
            e_qtd = value
        End Set
    End Property

    Public Sub Gravar()
        sql = "INSERT INTO tabEntradaProd" &
        "(proCod " &
        ",entProdData" &
        ",entProdPreco" &
        ",entProdQtd" &
        ") VALUES " &
        "(" & e_pro & "" &
        ",'" & e_data & "'" &
        "," & e_preco & "" &
        "," & e_qtd & "" &
        ")"
        objBanco.executar_comando(sql)
        sql = "SELECT MAX (entProdCod) FROM tabEntradaProd"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        e_cod = objdt.Rows(0).Item(0)
    End Sub

    Public Function listar() As DataTable
        sql = "SELECT * FROM tabEntradaProd"
        Return objBanco.buscar(sql)
    End Function

End Class
