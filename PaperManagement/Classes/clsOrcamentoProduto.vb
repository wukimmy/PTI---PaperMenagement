Public Class clsOrcamentoProduto
    Dim op_codigo As Integer
    Dim op_seq As Integer
    Dim op_procod As Integer
    Dim op_qtd As Integer
    Dim op_codorc As Integer

    Dim sql As String
    Dim objBanco As New clsBanco
    Dim objdt As New DataTable

    Public Property codigo As Integer
        Get
            Return op_codigo
        End Get
        Set(value As Integer)
            op_codigo = value
        End Set
    End Property

    Public Property sequencia As Integer
        Get
            Return op_seq

        End Get
        Set(value As Integer)
            op_seq = value
        End Set
    End Property

    Public Property codigoProduto As Integer
        Get
            Return op_procod
        End Get
        Set(value As Integer)
            op_procod = value
        End Set
    End Property

    Public Property quantidade As Integer
        Get
            Return op_qtd
        End Get
        Set(value As Integer)
            op_qtd = value
        End Set
    End Property

    Public Property orcCod As Integer
        Get
            Return op_codorc
        End Get
        Set(value As Integer)
            op_codorc = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo Then
            sql = "INSERT INTO Orcamento_Produto" &
       "(orc_prodSequencia " &
       ",proCod" &
       ",orc_prodQtd" &
       ",orc_cod" &
       ") VALUES " &
       "('" & op_seq & "'" &
       ",'" & op_procod & "'" &
       ",'" & op_qtd & "'" &
       ",'" & op_codorc & "'" &
       ")"
            objBanco.executar_comando(sql)
            ' sql = "SELECT MAX (orcCod) FROM tabOrcamento"
            ' Dim objdt As New DataTable
            ' objdt = objBanco.buscar(sql)
            ' o_cod = objdt.Rows(0).Item(0)
            'objBanco.executar_comando(sql)

        Else
            sql = "UPDATE "
        End If
    End Sub

    Public Function buscar(campo As String) As DataTable
        sql = "SELECT Orcamento_Produto.orc_cod, tabProduto.proDesc, Orcamento_Produto.orc_prodQtd, tabProduto.proPrecoVarejo FROM Orcamento_Produto INNER JOIN tabProduto ON Orcamento_Produto.proCod = tabProduto.proCod WHERE  Orcamento_Produto.orc_cod =" & campo
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        If objdt.Rows.Count = 0 Then
            MessageBox.Show("Orçamento Inexistente")
        End If
        Return objBanco.buscar(sql)
    End Function
End Class
