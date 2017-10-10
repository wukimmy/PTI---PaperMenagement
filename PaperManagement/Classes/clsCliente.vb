Public Class clsCliente
    Dim c_cod As Integer
    Dim c_nom As String
    Dim c_tel As String
    Dim c_email As String
    Dim c_cpf As String
    Dim c_men As Boolean

    Dim sql As String
    Dim objBanco As New clsBanco

    Public Property codigo As Integer
        Get
            Return c_cod
        End Get
        Set(value As Integer)
            c_cod = value
        End Set
    End Property

    Public Property nome As String
        Get
            Return c_nom
        End Get
        Set(value As String)
            c_nom = value
        End Set
    End Property

    Public Property telefone As String
        Get
            Return c_tel
        End Get
        Set(value As String)
            c_tel = value
        End Set
    End Property

    Public Property email As String
        Get
            Return c_email
        End Get
        Set(value As String)
            c_email = value
        End Set
    End Property

    Public Property cpf As String
        Get
            Return c_cpf
        End Get
        Set(value As String)
            c_cpf = value
        End Set
    End Property

    Public Property mensalista As Boolean
        Get
            Return c_men
        End Get
        Set(value As Boolean)
            c_men = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo Then
            sql = "INSERT INTO tabCliente " &
            "(cliNom " &
            ",cliTel" &
            ",cliEmail" &
            ",cliCPF" &
            ",cliMen" &
            ") VALUES " &
            "('" & c_nom & "'" &
            ",'" & c_tel & "'" &
            ",'" & c_email & "'" &
            ",'" & c_cpf & "'" &
            ", " & c_men & " " &
            ")"
            objBanco.executar_comando(sql)
            sql = "SELECT MAX (cliCod) FROM tabCliente"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            c_cod = objdt.Rows(0).Item(0)
        Else
            sql = "UPDATE tabCliente SET " &
            " cliNom = '" & c_nom & "'" &
            ",cliTel = '" & c_tel & "'" &
            ",cliEmail = '" & c_email & "'" &
            ",cliCPF = '" & c_cpf & "'" &
            ",cliMen = " & c_men & " " &
            " WHERE cliCod=" & c_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function Excluir(cod As Integer) As Boolean
        If MessageBox.Show("Deseja excluir ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "DELETE FROM tabCliente WHERE cliCod=" & cod
            objBanco.executar_comando(sql)
            Return True
        End If
        Return False
    End Function

    Public Function Validar_chave(campo As String) As Boolean
        sql = "select * from tabCliente where cliCPF='" & campo & "'"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        If objdt.Rows.Count = 0 Then
            Return False
        Else
            c_nom = objdt.Rows(0).Item(1)
            c_men = objdt.Rows(0).Item(5)
            Return True
        End If

    End Function
    Public Function localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT tabCliente.cliCod, tabCliente.cliNom, tabCliente.cliTel, tabCliente.cliEmail, tabCliente.cliCPF, iif(tabCliente.cliMen = true , 'Sim' , 'Não') as cliMen from tabCliente where cliCod = " & campo
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
        Else
            sql = "SELECT tabCliente.cliCod, tabCliente.cliNom, tabCliente.cliTel, tabCliente.cliEmail, tabCliente.cliCPF, iif(tabCliente.cliMen = true , 'Sim' , 'Não') as cliMen from tabCliente where cliNom = '" & campo & "'"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
        End If
        Return objBanco.buscar(sql)
    End Function
    Public Function locVen(campo As String) As String
        sql = "SELECT tabCliente.cliCod from tabCliente where cliCPF='" & campo & "'"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        Return objdt.Rows(0).Item(0).ToString
    End Function

End Class
