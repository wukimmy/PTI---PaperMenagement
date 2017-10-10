Public Class clsItensVendidos
    Dim m_codVen As Integer
    Dim m_seq As Integer
    Dim m_prodCod As Integer
    Dim m_venValor As Double
    Dim m_qtd As Integer
    Dim m_servProd As Boolean

    Dim sql As String
    Dim objBanco As New clsBanco
    Public Property codigo_venda As Integer
        Get
            Return m_codVen
        End Get
        Set(value As Integer)
            m_codVen = value
        End Set
    End Property
    Public Property sequencia_item As Integer
        Get
            Return m_seq
        End Get
        Set(value As Integer)
            m_seq = value
        End Set
    End Property
    Public Property codigo_produto As Integer
        Get
            Return m_prodCod
        End Get
        Set(value As Integer)
            m_prodCod = value
        End Set
    End Property
    Public Property valor_venda As Double
        Get
            Return m_venValor
        End Get
        Set(value As Double)
            m_venValor = value
        End Set
    End Property
    Public Property qtd_vendida As Integer
        Get
            Return m_qtd
        End Get
        Set(value As Integer)
            m_qtd = value
        End Set
    End Property
    Public Property servico_produto As Boolean
        Get
            Return m_servProd
        End Get
        Set(value As Boolean)
            m_servProd = value
        End Set
    End Property


    Public Sub Gravar()
        sql = "INSERT INTO tabItensVendidos " &
            "(itensVenCod " &
            ",itensVenSequencia" &
            ",proCod" &
            ",itensVenQtd" &
            ",itensVenValor" &
            ",itensVenTipoServProd" &
            ") values " &
            "('" & m_codVen & "'" &
            ",'" & m_seq & "'" &
            ",'" & m_qtd & "'" &
            ",'" & m_prodCod & "'" &
            ",'" & m_venValor & "'" &
            "," & m_servProd & "" &
            ")"
        objBanco.executar_comando(sql)
    End Sub

End Class
