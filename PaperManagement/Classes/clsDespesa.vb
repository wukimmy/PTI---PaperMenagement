Public Class clsDespesa
    Dim d_cod As Integer
    Dim d_desc As String

    Dim sql As String
    Dim objBanco As New clsBanco

    Public Property Codigo As Integer
        Get
            Return d_cod
        End Get
        Set(value As Integer)
            d_cod = value
        End Set
    End Property

    Public Property Descricao As String
        Get
            Return d_desc
        End Get
        Set(value As String)
            d_desc = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo Then
            sql = "INSERT INTO tabDespesa (despDescri) VALUES ('" & d_desc & "')"
            objBanco.executar_comando(sql)
            sql = "SELECT MAX (despCod) FROM tabDespesa"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            d_cod = objdt.Rows(0).Item(0)
        Else
            sql = "UPDATE tabDespesa SET despDescri='" & d_desc & "' WHERE despCod =" & d_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function Excluir(cod As Integer) As Boolean
        If MessageBox.Show("Deseja excluir ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "DELETE FROM tabDespesa WHERE despCod=" & cod
            objBanco.executar_comando(sql)
            Return True
        End If
        Return False
    End Function

    Public Function LocalizarPorCodigo(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "SELECT * FROM tabDespesa WHERE despCod =" & campo
        Else
            sql = "SELECT * FROM tabDespesa WHERE despDescri='" & campo & "'"
        End If
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        If objdt.Rows.Count = 0 Then
            MessageBox.Show("Registro não encontrado")
            Return False
        Else
            d_cod = objdt.Rows(0).Item(0)
            d_desc = objdt.Rows(0).Item(1)
        End If
        objBanco.buscar(sql)
        Return True
    End Function
    Public Function Validar_chave(campo As Integer) As Boolean

        sql = "SELECT * FROM tabDespesa WHERE despCod=" & campo
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        If objdt.Rows.Count = 0 Then
            MessageBox.Show("Despesa Inexistente")
            Return False
        Else
            d_desc = objdt.Rows(0).Item(1)
            Return True
        End If

    End Function
    Public Function localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT * FROM tabDespesa WHERE despCod=" & campo
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
        Else
            sql = "SELECT * FROM tabDespesa WHERE despDescri='" & campo & "'"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
        End If
        Return objBanco.buscar(sql)
    End Function

    Public Function Exibir_combo() As DataTable
        sql = "SELECT * FROM tabDespesa ORDER BY despDescri"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        Return objdt
    End Function

End Class
