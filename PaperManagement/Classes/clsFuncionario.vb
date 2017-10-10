Public Class clsFuncionario
    Dim f_cod As Integer
    Dim f_nom As String
    Dim f_tel As String
    Dim f_cep As String
    Dim f_cpf As String
    Dim f_dtAdm As Date
    Dim f_num As Integer

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

    Public Property nome As String
        Get
            Return f_nom
        End Get
        Set(value As String)
            f_nom = value
        End Set
    End Property

    Public Property telefone As String
        Get
            Return f_tel
        End Get
        Set(value As String)
            f_tel = value
        End Set
    End Property

    Public Property cep As String
        Get
            Return f_cep
        End Get
        Set(value As String)
            f_cep = value
        End Set
    End Property
    Public Property Numero As Integer
        Get
            Return f_num
        End Get
        Set(value As Integer)
            f_num = value
        End Set
    End Property

    Public Property cpf As String
        Get
            Return f_cpf
        End Get
        Set(value As String)
            f_cpf = value
        End Set
    End Property

    Public Property dtAdmissao As Date
        Get
            Return f_dtAdm
        End Get
        Set(value As Date)
            f_dtAdm = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo Then
            sql = "INSERT INTO tabFuncionario " &
            "(funNom " &
            ",funTel" &
            ",funCEP" &
            ",Numero" &
            ",funCPF" &
            ",funDtAdm" &
            ") VALUES " &
            "('" & f_nom & "'" &
            ",'" & f_tel & "'" &
            ",'" & f_cep & "'" &
            ",'" & f_num & "'" &
            ",'" & f_cpf & "'" &
            ",'" & f_dtAdm & "'" &
            ")"
            objBanco.executar_comando(sql)
            sql = "SELECT MAX (funCod) FROM tabFuncionario"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            f_cod = objdt.Rows(0).Item(0)
        Else
            sql = "UPDATE tabFuncionario SET " &
            " funNom = '" & f_nom & "'" &
            ",funTel = '" & f_tel & "'" &
            ",funCEP = '" & f_cep & "'" &
            ",Numero = '" & f_num & "'" &
            ",funCPF = '" & f_cpf & "'" &
            ",funDtAdm = '" & f_dtAdm & "'" &
            " WHERE funCod=" & f_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function Excluir(cod As Integer) As Boolean
        If MessageBox.Show("Deseja excluir ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "DELETE FROM tabFuncionario WHERE funCod=" & cod
            objBanco.executar_comando(sql)
            Return True
        End If
        Return False
    End Function

    Public Function Exibir_combo() As DataTable
        sql = "SELECT * FROM tabFuncionario ORDER BY funNom"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        Return objdt
    End Function
    Public Function localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT * FROM tabFuncionario where funCod = " & campo
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Funcionário Inexistente")
            End If
        Else
            sql = "SELECT * FROM tabFuncionario where funNom ='" & campo & "'"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Funcionário Inexistente")
            End If
        End If
        Return objBanco.buscar(sql)
    End Function
    Public Function busca_rapidaFun(campo As String) As Integer
        sql = "SELECT tabFuncionario.funCod FROM tabFuncionario WHERE funNom = '" & campo & "'"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)

        Return objdt.Rows(0).Item(0).ToString
    End Function
    Public Function Validar_chave(campo As Integer) As Boolean

        sql = "select * from tabFuncionario where funCod=" & campo

        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        If objdt.Rows.Count = 0 Then
            MessageBox.Show("Funcionário Inexistente")
            Return False
        Else
            f_nom = objdt.Rows(0).Item(1)
            Return True
        End If

    End Function
End Class
