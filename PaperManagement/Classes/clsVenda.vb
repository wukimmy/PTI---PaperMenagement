Public Class clsVenda
    Dim v_cod As Integer
    Dim v_cli As Integer
    Dim v_cliCPF As String
    Dim v_fun As Integer
    Dim v_date As Date
    Dim v_val As Double
    Dim v_desc As Double
    Dim v_pag As String

    Dim sql As String
    Dim objBanco As New clsBanco

    Public Property codigo As Integer
        Get
            Return v_cod
        End Get
        Set(value As Integer)
            v_cod = value
        End Set
    End Property

    Public Property cliente As Integer
        Get
            Return v_cli
        End Get
        Set(value As Integer)
            v_cli = value
        End Set
    End Property

    Public Property clienteCPF As String
        Get
            Return v_cliCPF
        End Get
        Set(value As String)
            v_cliCPF = value
        End Set
    End Property

    Public Property funcionario As Integer
        Get
            Return v_fun
        End Get
        Set(value As Integer)
            v_fun = value
        End Set
    End Property

    Public Property data As Date
        Get
            Return v_date
        End Get
        Set(value As Date)
            v_date = value
        End Set
    End Property

    Public Property valor As Double
        Get
            Return v_val
        End Get
        Set(value As Double)
            v_val = value
        End Set
    End Property

    Public Property percentualDesconto As Double
        Get
            Return v_desc
        End Get
        Set(value As Double)
            v_desc = value
        End Set
    End Property

    Public Property tipoPagamento As String
        Get
            Return v_pag
        End Get
        Set(value As String)
            v_pag = value
        End Set
    End Property

    Public Sub Gravar()
        sql = "INSERT INTO tabVenda " &
        "(cliCod " &
        ",cliCPF" &
        ",funCod" &
        ",venData" &
        ",venVal" &
        ",venDesc" &
        ",venPag" &
        ") VALUES " &
        "(" & v_cli & "" &
        ",'" & v_cliCPF & "'" &
        "," & v_fun & "" &
        ",'" & v_date & "'" &
        ",'" & v_val & "'" &
        ",'" & v_desc & "'" &
        ",'" & v_pag & "'" &
        ")"
        objBanco.executar_comando(sql)
        sql = "SELECT MAX (venCod) FROM tabVenda"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        v_cod = objdt.Rows(0).Item(0)
    End Sub

    Public Function listar_venda() As DataTable
        sql = "SELECT tabVenda.venData, tabCliente.cliNom, tabFuncionario.funNom, tabVenda.venVal, tabVenda.venPag FROM tabCliente INNER JOIN(tabVenda INNER JOIN tabFuncionario ON tabFuncionario.funCod = tabVenda.funCod) ON tabCliente.cliCod = tabVenda.cliCod"
        Return objBanco.buscar(sql)
    End Function

    Public Function fechamentoMes(mes As String, ano As String) As DataTable
        sql = "SELECT tabVenda.venData, tabCliente.cliNom, tabFuncionario.funNom, tabVenda.venVal, tabVenda.venPag FROM tabCliente INNER JOIN(tabVenda INNER JOIN tabFuncionario ON tabFuncionario.funCod = tabVenda.funCod) ON tabCliente.cliCod = tabVenda.cliCod WHERE MONTH(tabVenda.venData)=" & mes & " AND YEAR(tabVenda.venData)=" & ano
        Return objBanco.buscar(sql)
    End Function

    Public Function fechamentoDia(dia As Date) As DataTable
        Dim objds As New DataSet
        Dim objda = (New OleDb.OleDbDataAdapter("FechamentoDia", objBanco.objCon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        Dim h1, h2 As Date
        h1 = "00:00:01"
        h2 = "23:59:59"
        objda.SelectCommand.Parameters("campo1").Value = CDate(dia & " " & CDate(h1))
        objda.SelectCommand.Parameters("campo2").Value = CDate(dia & " " & CDate(h2))
        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Function VerUlt() As Integer
        sql = "SELECT MAX (venCod) FROM tabVenda"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        v_cod = objdt.Rows(0).Item(0)
        v_cod = v_cod + 1
        Return v_cod
    End Function

End Class
