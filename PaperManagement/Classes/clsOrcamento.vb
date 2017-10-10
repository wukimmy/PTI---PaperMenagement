Public Class clsOrcamento
    Dim o_cod As Integer
    Dim o_parcod As Integer
    Dim o_data As Date
    Dim o_valor As Double

    Dim sql As String
    Dim objBanco As New clsBanco
    Dim objdt As New DataTable
    Public Property Codigo As Integer
        Get
            Return o_cod
        End Get
        Set(value As Integer)
            o_cod = value
        End Set
    End Property

    Public Property Parceiro As Integer
        Get
            Return o_parcod
        End Get
        Set(value As Integer)
            o_parcod = value
        End Set
    End Property

    Public Property Data As Date
        Get
            Return o_data
        End Get
        Set(value As Date)
            o_data = value
        End Set
    End Property
    Public Property valor As Double
        Get
            Return o_valor
        End Get
        Set(value As Double)
            o_valor = value
        End Set
    End Property

    Public Sub Gravar(novo)

        sql = "INSERT INTO tabOrcamento" &
        "(parCod " &
        ",orcData" &
        ",orcValor" &
        ") VALUES " &
        "('" & o_parcod & "'" &
        ",'" & o_data & "'" &
        "," & o_valor & "" &
        ")"
        objBanco.executar_comando(sql)
        sql = "SELECT MAX (orcCod) FROM tabOrcamento"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        o_cod = objdt.Rows(0).Item(0)
        objBanco.executar_comando(sql)

    End Sub
End Class
