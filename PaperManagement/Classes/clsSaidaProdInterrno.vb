Public Class clsSaidaProdInterrno
    Dim s_cod As Integer
    Dim s_prod As Integer
    Dim s_qtd As Integer
    Dim s_fun As Integer
    Dim s_data As Date

    Dim sql As String
    Dim objBanco As New clsBanco

    Public Property codigo As Integer
        Get
            Return s_cod
        End Get
        Set(value As Integer)
            s_cod = value
        End Set
    End Property

    Public Property produto As Integer
        Get
            Return s_prod
        End Get
        Set(value As Integer)
            s_prod = value
        End Set
    End Property

    Public Property quantidade As Integer
        Get
            Return s_qtd
        End Get
        Set(value As Integer)
            s_qtd = value
        End Set
    End Property

    Public Property funcionario As Integer
        Get
            Return s_fun
        End Get
        Set(value As Integer)
            s_fun = value
        End Set
    End Property

    Public Property data As Date
        Get
            Return s_data
        End Get
        Set(value As Date)
            s_data = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo Then
            sql = "INSERT INTO tabSaidaProdInterno " &
            "( proCod " &
            ", saidaProIntQtd" &
            ", funCod" &
            ",saidaProIntData" &
            ") VALUES " &
            "(" & s_prod & "'" &
            ",'" & s_qtd & "'" &
            ",'" & s_fun & "'" &
            ",'" & s_data & "'" &
            ")"
            objBanco.executar_comando(sql)
            sql = "SELECT MAX (saidaProIntCod) FROM tabSaidaProdInterno"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            s_cod = objdt.Rows(0).Item(0)
        Else
            sql = "UPDATE tabSaidaProdInterno SET " &
            " proCod = '" & s_prod & "'" &
            ",saidaProIntQtd = '" & s_qtd & "'" &
            ",funCod = '" & s_fun & "'" &
            ",saidaProIntData = '" & s_data & "'" &
            " WHERE saidaProIntCod=" & s_cod
            objBanco.executar_comando(sql)
        End If
    End Sub
    Public Function localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT tabSaidaProdInterno.saidaProIntCod, tabProduto.proDesc, tabSaidaProdInterno.saidaProIntQtd, tabFuncionario.funNom, tabSaidaProdInterno.saidaProIntData FROM tabFuncionario INNER JOIN ( tabSaidaProdInterno INNER JOIN tabProduto ON tabSaidaProdInterno.proCod = tabProduto.proCod) ON tabFuncionario.funCod = tabSaidaProdInterno.funCod WHERE tabSaidaProdInterno.tabsaidaProIntCod = " & campo

            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Cliente Inexistente")
            End If
        Else
            sql = " SELECT tabSaidaProdInterno.saidaProIntCod, tabProduto.proDesc, tabSaidaProdInterno.saidaProIntQtd, tabFuncionario.funNom, tabSaidaProdInterno.saidaProIntData FROM tabFuncionario INNER JOIN ( tabSaidaProdInterno INNER JOIN tabProduto ON tabSaidaProdInterno.proCod = tabProduto.proCod) ON tabFuncionario.funCod = tabSaidaProdInterno.funCod WHERE tabProduto.proDesc = '" & campo & "'"
            Dim objdt As New DataTable
            objdt = objBanco.buscar(sql)
            If objdt.Rows.Count = 0 Then
                MessageBox.Show("Cliente Inexistente")
            End If
        End If
        Return objBanco.buscar(sql)
    End Function
    Public Function Excluir(cod As Integer) As Boolean
        If MessageBox.Show("Deseja excluir ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "DELETE FROM tabSaidaProdInterno WHERE saidaProIntCod=" & cod
            objBanco.executar_comando(sql)
            Return True
        End If
        Return False
    End Function
End Class
