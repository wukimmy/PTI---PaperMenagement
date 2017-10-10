Public Class clsParceira
    Dim p_cod As Integer
    Dim p_nom As String
    Dim p_cep As String
    Dim p_num As Integer
    Dim p_tel As String
    Dim p_email As String

    Dim sql As String
    Dim objBanco As New clsBanco

    Public Property codigo As Integer
        Get
            Return p_cod
        End Get
        Set(value As Integer)
            p_cod = value
        End Set
    End Property

    Public Property nome As String
        Get
            Return p_nom
        End Get
        Set(value As String)
            p_nom = value
        End Set
    End Property
    Public Property Cep As String
        Get
            Return p_cep
        End Get
        Set(value As String)
            p_cep = value
        End Set
    End Property
    Public Property Num As Integer
        Get
            Return p_num
        End Get
        Set(value As Integer)
            p_num = value
        End Set
    End Property
    Public Property telefone As String
        Get
            Return p_tel
        End Get
        Set(value As String)
            p_tel = value
        End Set
    End Property

    Public Property email As String
        Get
            Return p_email
        End Get
        Set(value As String)
            p_email = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo Then
            sql = "INSERT INTO tabParceira " &
            "(parNom " &
            ",parCEP" &
            ",parNum" &
            ",parTel" &
            ",parEmail" &
            ") VALUES " &
            "('" & p_nom & "'" &
            ",'" & p_cep & "'" &
            ",'" & p_num & "'" &
            ",'" & p_tel & "'" &
            ",'" & p_email & "'" &
            ")"
            objBanco.executar_comando(sql)
            sql = "SELECT MAX (parCod) FROM tabParceira"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            p_cod = objdt.Rows(0).Item(0)
        Else
            sql = "UPDATE tabParceira SET " &
            " parNom = '" & p_nom & "'" &
            " ,parCEP = '" & p_cep & "'" &
            " ,parNum = '" & p_num & "'" &
            " ,parTel = '" & p_tel & "'" &
            " ,parEmail = '" & p_email & "'" &
            " WHERE parCod = " & p_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function Excluir(cod As Integer) As Boolean
        If MessageBox.Show("Deseja excluir ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "DELETE FROM tabParceira WHERE tabParceira.parCod=" & cod
            objBanco.executar_comando(sql)
            Return True
        End If
        Return False
    End Function
    Public Function localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT * from tabParceira Where parCod=" & campo
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Parceiro Inexistente")
            End If
        Else
            sql = "SELECT * from tabParceira Where parNom='" & campo & "'"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Parceiro Inexistente")
            End If
        End If
        Return objBanco.buscar(sql)
    End Function
    Public Function Exibir_combo() As DataTable
        sql = "SELECT * FROM tabParceira ORDER BY parNom"
        Dim objdt As New DataTable
        objdt = objBanco.buscar(sql)
        Return objdt
    End Function
End Class
