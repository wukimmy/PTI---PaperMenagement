Public Class clsFamilia
    Dim f_cod As Integer
    Dim f_desc As String

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

    Public Property descricao As String
        Get
            Return f_desc
        End Get
        Set(value As String)
            f_desc = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo Then
            sql = "INSERT INTO tabFamilia (famiDesc) VALUES ('" & f_desc & "')"
            objBanco.executar_comando(sql)
            sql = "SELECT MAX (famiCod) FROM tabFamilia"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            f_cod = objdt.Rows(0).Item(0)
        Else
            sql = "UPDATE tabFamilia SET famiDesc='" & f_desc & "' WHERE famiCod =" & f_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function Excluir(cod As Integer) As Boolean
        If MessageBox.Show("Deseja excluir ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "DELETE FROM tabFamilia WHERE famiCod=" & cod
            objBanco.executar_comando(sql)
            Return True
        End If
        Return False
    End Function

    Public Function busca_rapidaFam(campo As String) As Integer
        sql = "SELECT tabFamilia.famiCod FROM tabFamilia WHERE famiDesc = '" & campo & "'"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)

        Return objdt.Rows(0).Item(0).ToString
    End Function

    Public Function Validar_chave(campo As Integer) As Boolean

        sql = "select * from tabFamilia where famiCod=" & campo

        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        If objdt.Rows.Count = 0 Then
            MessageBox.Show("Familia Inexistente")
            Return False
        Else
            f_desc = objdt.Rows(0).Item(1)
            Return True
        End If

    End Function

    Public Function localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "select * from tabFamilia where famiCod=" & campo
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Família Inexistente")
            End If
        Else
            sql = "select * from tabFamilia where famiDesc='" & campo & "'"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Família Inexistente")
            End If
        End If
        Return objBanco.buscar(sql)
    End Function
    Public Function Exibir_combo() As DataTable
        sql = "SELECT * FROM tabFamilia ORDER BY famiDesc"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        Return objdt
    End Function
End Class
