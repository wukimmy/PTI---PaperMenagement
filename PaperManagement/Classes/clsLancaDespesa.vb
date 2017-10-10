Public Class clsLancaDespesa
    Dim l_cod As Integer
    Dim l_despesa As Integer
    Dim l_val As String
    Dim l_status As Boolean
    Dim l_dataVen As Date

    Dim sql As String
    Dim objBanco As New clsBanco

    Public Property Codigo As Integer
        Get
            Return l_cod
        End Get
        Set(value As Integer)
            l_cod = value

        End Set
    End Property

    Public Property Cod_Despesas As Integer
        Get
            Return l_despesa
        End Get
        Set(value As Integer)
            l_despesa = value

        End Set
    End Property

    Public Property Valor As String
        Get
            Return l_val
        End Get
        Set(value As String)
            l_val = value

        End Set
    End Property


    Public Property Status As Boolean
        Get
            Return l_status
        End Get
        Set(value As Boolean)
            l_status = value

        End Set
    End Property

    Public Property DataVenc As Date
        Get
            Return l_dataVen
        End Get
        Set(value As Date)
            l_dataVen = value

        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo Then
            sql = "INSERT INTO tabLancaDespesa " &
            "(despCod " &
            ",lancaDesVal" &
            ",lancaDesStatus" &
            ",lancaDesVenci" &
            ") VALUES " &
            "('" & l_despesa & "'" &
            "," & l_val & "" &
            "," & l_status & "" &
            ",'" & l_dataVen & "'" &
            ")"
            objBanco.executar_comando(sql)
            sql = "SELECT MAX (lancaDesCod) FROM tabLancaDespesa"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            l_cod = objdt.Rows(0).Item(0)    
        Else
            sql = "UPDATE tabLancaDespesa SET  despCod =" & l_cod & ", lancaDesVal='" & l_despesa & "', lancaDesStatus=" & l_status & ", lancaDesVenci= '" & l_dataVen & "' WHERE despCod=" & l_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function Excluir(cod As Integer) As Boolean
        If MessageBox.Show("Deseja excluir ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "DELETE FROM tabLancaDespesa WHERE lancaDesCod =" & cod
            objBanco.executar_comando(sql)
            Return True
        End If
        Return False
    End Function

    Public Function filtrar_por_status(status As Boolean) As DataTable
        sql = "SELECT tabLancaDespesa.lancaDesCod, tabDespesa.despDescri , tabLancaDespesa.lancaDesVal, iif(tabLancaDespesa.lancaDesStatus = false , 'Não Pago' , 'Pago') as lancaDesStatus, tabLancaDespesa.lancaDesVenci FROM tabDespesa INNER JOIN tabLancaDespesa ON tabLancaDespesa.despCod = tabDespesa.despCod WHERE tabLancaDespesa.lancaDesStatus = " & status & ";"
        Return objBanco.buscar(sql)
    End Function
    Public Function localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT tabLancaDespesa.lancaDesCod, tabDespesa.despDescri , tabLancaDespesa.lancaDesVal, iif(tabLancaDespesa.lancaDesStatus = false , 'Não Pago' , 'Pago') as lancaDesStatus, tabLancaDespesa.lancaDesVenci FROM tabDespesa INNER JOIN tabLancaDespesa ON tabLancaDespesa.despCod = tabDespesa.despCod WHERE tabLancaDespesa.lancaDesCod = " & campo
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Despesa Inexistente")
            End If
        Else
            sql = "SELECT tabLancaDespesa.lancaDesCod, tabDespesa.despDescri , tabLancaDespesa.lancaDesVal, iif(tabLancaDespesa.lancaDesStatus = false , 'Não Pago' , 'Pago') as lancaDesStatus, tabLancaDespesa.lancaDesVenci FROM tabDespesa INNER JOIN tabLancaDespesa ON tabLancaDespesa.despCod = tabDespesa.despCod WHERE tabDespesa.despDescri = '" & campo & "'"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Despesa Inexistente")
            End If
        End If
        Return objBanco.buscar(sql)
    End Function

End Class
