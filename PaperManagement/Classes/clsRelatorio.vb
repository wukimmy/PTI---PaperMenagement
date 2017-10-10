Public Class clsRelatorio
    Dim sql As String
    Dim objBanco As New clsBanco

    Public Function fechamentoMes(mes As String, ano As String) As DataTable
        sql = "SELECT Format(SUM(tabVenda.venVal),  'R$ ##,##') as Total, COUNT(tabVenda.VenCod) AS QtdVendas FROM tabVenda WHERE MONTH(tabVenda.venData)=" & mes & " AND YEAR(tabVenda.venData)=" & ano
        Return objBanco.buscar(sql)
    End Function
    Public Function mensalista(campo As String) As DataTable

        If IsNumeric(campo) Then
            sql = "SELECT tabCliente.CliNom, tabCliente.CliCod, tabVenda.VenVal FROM tabCliente INNER JOIN tabVenda ON tabCliente.CliCod = tabVenda.CliCod WHERE tabCliente.CliMen = TRUE AND tabCliente.CliCod = " & campo
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Cliente Inexistente ou Não Mensalista")
            End If
        Else
            sql = "SELECT tabCliente.CliNom, tabCliente.CliCod, tabVenda.VenVal FROM tabCliente INNER JOIN tabVenda ON tabCliente.CliCod = tabVenda.CliCod WHERE tabCliente.CliMen = TRUE AND tabCliente.CliCod = " & campo
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Cliente Inexistente ou Não Mensalista")
            End If
        End If
        Return objBanco.buscar(sql)
    End Function
    Public Function loc() As DataTable
        sql = "SELECT tabCliente.CliNom, tabCliente.CliCod, tabVenda.VenVal FROM tabCliente INNER JOIN tabVenda ON tabCliente.CliCod = tabVenda.CliCod WHERE tabCliente.CliMen = TRUE "
        Return objBanco.buscar(sql)

    End Function
    Public Function melhorVendedor(datini As Date, datfin As Date) As DataTable
        Dim objds As New DataSet
        Dim objda = (New OleDb.OleDbDataAdapter("FuncionarioQueMaisVende", objBanco.objCon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = datini
        objda.SelectCommand.Parameters("campo2").Value = datfin
        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function melhorCliente(datini As Date, datfin As Date) As DataTable
        Dim objds As New DataSet
        Dim objda = (New OleDb.OleDbDataAdapter("ClienteQueMaisCompra", objBanco.objCon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = datini
        objda.SelectCommand.Parameters("campo2").Value = datfin
        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Function filtrar_vendas(datIni As Date, datFim As Date) As DataTable
        sql = "SELECT tabVenda.venCod, tabVenda.venData, tabVenda.cliCod, tabCliente.cliNom, tabVenda.funCod, tabFuncionario.funNom, tabVenda.venVal FROM tabCliente INNER JOIN(tabVenda INNER JOIN tabFuncionario ON tabFuncionario.funCod = tabVenda.funCod) ON tabCliente.cliCod = tabVenda.cliCod WHERE venData BETWEEN #" & datIni & "# AND #" & datFim & "# ORDER BY venVal"
        Return objBanco.buscar(sql)
    End Function
    Public Function tipoPagamento() As DataTable
        Dim objds As New DataSet
        Dim objda = (New OleDb.OleDbDataAdapter("tipoDePagamento", objBanco.objCon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class
