Public Class clsBanco
    Dim strCon As String = "provider=microsoft.ace.oledb.12.0;data source=PaperManagement.accdb"
    Public objCon As New OleDb.OleDbConnection(strCon)

    Private Sub abrir_banco()
        Try
            objCon.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub fechar_banco()
        If objCon.State = ConnectionState.Open Then
            objCon.Close()
        End If
    End Sub

    Public Sub executar_comando(sql As String)
        abrir_banco()
        Dim objCmd As New OleDb.OleDbCommand(sql, objCon)
        objCmd.ExecuteNonQuery()
        fechar_banco()
    End Sub

    Public Function buscar(sql As String) As DataTable
        Dim objDA As New OleDb.OleDbDataAdapter(sql, objCon)
        Dim objDS As New DataSet
        objDA.Fill(objDS)
        Return objDS.Tables(0)
    End Function

End Class
