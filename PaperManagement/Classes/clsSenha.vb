Public Class clsSenha
    Dim s_login As String
    Dim s_senha As String

    Dim sql As String
    Dim objBanco As New clsBanco

    Public Property login As Integer
        Get
            Return s_login
        End Get
        Set(value As Integer)
            s_login = value
        End Set
    End Property

    Public Property senha As String
        Get
            Return s_senha
        End Get
        Set(value As String)
            s_senha = value
        End Set
    End Property

    Public Sub Atualizar(login As String, senha As String)
        sql = "UPDATE tabSenha SET senSenha='" & senha & "' WHERE senLogin = '" & login & "'"
        objBanco.executar_comando(sql)
    End Sub

    Public Function Entrar(login As String, senha As String) As Boolean
        sql = "SELECT * FROM tabSenha WHERE senLogin = '" & login & "' AND senSenha = '" & senha & "'"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        If objdt.Rows.Count = 1 Then
            Return True
        Else
            MessageBox.Show("Senha Incorreta")
            Return False
        End If
    End Function

End Class
