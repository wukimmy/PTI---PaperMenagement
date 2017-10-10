Public Class clsValidacao
    Public Function FU_ValidaCPF(CPF As String) As Boolean

        Dim soma As Integer
        Dim Resto As Integer
        Dim I As Integer

        ''Valida argumento
        If Len(CPF) <> 11 Then
            FU_ValidaCPF = False
            Exit Function

        End If

        soma = 0

        For I = 1 To 9
            soma = soma + Val(Mid$(CPF, I, 1)) * (11 - I)
        Next I
        Resto = 11 - (soma - (Int(soma / 11) * 11))

        If Resto = 10 Or Resto = 11 Then Resto = 0

        If Resto <> Val(Mid$(CPF, 10, 1)) Then
            MessageBox.Show("CPF Invalido!")
            FU_ValidaCPF = False
            Exit Function

        End If
        soma = 0
        For I = 1 To 10
            soma = soma + Val(Mid$(CPF, I, 1)) * (12 - I)
        Next I
        Resto = 11 - (soma - (Int(soma / 11) * 11))
        If Resto = 10 Or Resto = 11 Then Resto = 0
        If Resto <> Val(Mid$(CPF, 11, 1)) Then
            MessageBox.Show("CPF Invalido!")
            FU_ValidaCPF = False
            Exit Function
        End If
        ' MessageBox.Show("CPF Valido!")
        FU_ValidaCPF = True
    End Function
    Public Function validarEmail(email As String)
        Dim regexPattern As String = "^(?<user>[^@]+)@(?<host>.+)$"
        Dim emailRegEx As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(regexPattern)
        Dim result As Boolean = emailRegEx.IsMatch(email.ToString)
        If result = False Then
            MessageBox.Show("E-mail inexistente!!")
            My.Forms.frmCadCliente.txtCpf.Text = ""
            My.Forms.frmCadCliente.txtCpf.Focus()
        End If
    End Function
    Public Function IsCNPJ(ByVal strCNPJ As String) As Boolean

        IsCNPJ = False

        Dim a, j, d1, d2 As Double
        Dim i As Integer

        If Len(strCNPJ) <> 14 Then
            IsCNPJ = False
            Exit Function
        End If

        If Not IsNumeric(strCNPJ) Then
            IsCNPJ = False
            Exit Function
        End If

        a = 0
        i = 0
        d1 = 0
        d2 = 0
        j = 5

        For i = 1 To 12 Step 1
            a = a + (Val(Mid(strCNPJ, i, 1)) * j)
            j = Convert.ToDouble(If(j > 2, j - 1, 9))
        Next i
        a = a Mod 11
        d1 = Convert.ToDouble(If(a > 1, 11 - a, 0))

        a = 0
        i = 0
        j = 6

        For i = 1 To 13 Step 1
            a = a + (Val(Mid(strCNPJ, i, 1)) * j)
            j = Convert.ToDouble(If(j > 2, j - 1, 9))
        Next i
        a = a Mod 11
        d2 = Convert.ToDouble(If(a > 1, 11 - a, 0))

        If (d1 = Val(Mid(strCNPJ, 13, 1)) And d2 = Val(Mid(strCNPJ, 14, 1))) Then
            IsCNPJ = True
        Else
            IsCNPJ = False
            MessageBox.Show("CNPJ inválido!!")

        End If

    End Function

  
End Class
