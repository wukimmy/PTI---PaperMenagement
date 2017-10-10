Public Class clsServico
    Dim s_cod As Integer
    Dim s_desc As String
    Dim s_preco As Double

    Dim sql As String
    Dim objBanco As New clsBanco

    Public Property Codigo As Integer
        Get
            Return s_cod
        End Get
        Set(value As Integer)
            s_cod = value
        End Set
    End Property
    Public Property Descricao As String
        Get
            Return s_desc
        End Get
        Set(value As String)
            s_desc = value
        End Set
    End Property
    Public Property Preco As Double
        Get
            Return s_preco
        End Get
        Set(value As Double)
            s_preco = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo Then
            sql = "INSERT INTO tabServico " &
            "(serDesc " &
            ",serPreco" &
            ") VALUES " &
            "('" & s_desc & "'" &
            "," & s_preco & "" &
            ")"
            objBanco.executar_comando(sql)
            sql = "SELECT MAX (serCod) FROM tabServico"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            s_cod = objdt.Rows(0).Item(0)
        Else
            sql = "UPDATE tabServico SET " &
            " serDesc = '" & s_desc & "'" &
            " ,serPreco = '" & s_preco & "'" &
            " WHERE serCod=" & s_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function Excluir(cod As Integer) As Boolean
        If MessageBox.Show("Deseja excluir ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "DELETE FROM tabServico WHERE serCod=" & cod
            objBanco.executar_comando(sql)
            Return True
        End If
        Return False
    End Function
    Public Function localizar(campo) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT *FROM tabServico WHERE serCod=" & campo

            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Serviço Inexistente")
            End If
        Else
            sql = "SELECT *FROM tabServico WHERE serDesc= '" & campo & "'"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Serviço Inexistente")
            End If
        End If
        Return objBanco.buscar(sql)
    End Function

    Public Function Validar_chave(campo As Integer) As Boolean
        sql = "SELECT * FROM tabServico WHERE serCod=" & campo
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        If objdt.Rows.Count = 1 Then
            s_cod = objdt.Rows(0).Item(0)
            s_desc = objdt.Rows(0).Item(1)
            s_preco = objdt.Rows(0).Item(2)
            Return True
        Else
            Return False
        End If
    End Function

End Class
