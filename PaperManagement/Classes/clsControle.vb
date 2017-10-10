Public Class clsControle

    Public Sub habilitarCampos(Tela As Control, tipo As Boolean)
        Dim controle As Control
        For Each controle In Tela.Controls
            If TypeOf controle Is TextBox Or TypeOf controle Is
                MaskedTextBox Or TypeOf controle Is
                ComboBox Or TypeOf controle Is
                DateTimePicker Or TypeOf controle Is
                RadioButton Or TypeOf controle Is
                CheckBox Then
                If tipo = True And controle.Tag = "x" Then
                    controle.Enabled = False
                Else
                    controle.Enabled = tipo
                End If
            End If
        Next
    End Sub

    Public Function verificarNumero(ByVal tecla As String) As Boolean
        If Asc(tecla) = 8 Or Asc(tecla) = 13 Then
        ElseIf Asc(tecla) < 48 Or Asc(tecla) > 57 Then
            Return True
        End If
    End Function

    Public Function verificarNumeroInteiro(ByVal tecla As String) As Boolean
        If Asc(tecla) = 8 Or Asc(tecla) = 13 Or Asc(",") Then
        ElseIf Asc(tecla) < 48 Or Asc(tecla) > 57 Then
            Return True
        End If
    End Function

    Public Sub habilitarBotoes(Tela As Control, tipo As Boolean)
        Dim controle As Control
        For Each controle In Tela.Controls
            If TypeOf controle Is Button Then
                If tipo = False Then
                    If controle.Name.ToUpper = "BTNGRAVAR" Or controle.Name.ToUpper = "BTNEDITAR" _
                        Or controle.Name.ToUpper = "BTNALTERAR" Or controle.Name.ToUpper = "BTNEXCLUIR" Then
                        controle.Enabled = tipo
                    ElseIf controle.Name.ToUpper = "BTNSAIR" Or controle.Name.ToUpper = "BTNCANCELAR" _
                        Or controle.Name.ToUpper = "BTNNOVO" Then
                        controle.Enabled = Not tipo
                    End If
                Else
                    If controle.Name.ToUpper = "BTNGRAVAR" Or controle.Name.ToUpper = "BTNSAIR" _
                        Or controle.Name.ToUpper = "BTNCANCELAR" Then
                        controle.Enabled = tipo
                    ElseIf controle.Name.ToUpper = "BTNNOVO" Then
                        controle.Enabled = Not tipo
                    End If
                End If
            End If
        Next
    End Sub

    Public Sub LimparTela(Tela As Control)
        Dim controle As Object
        For Each controle In Tela.Controls
            If TypeOf controle Is TextBox Or TypeOf controle Is MaskedTextBox Or TypeOf controle Is ComboBox Then
                controle.Text = ""
            ElseIf TypeOf controle Is RadioButton Or TypeOf controle Is CheckBox Then
                controle.checked = False
            ElseIf TypeOf controle Is Label And controle.tag = "x" Then
                controle.Text = ""
            End If
        Next
    End Sub

    Public Function verificarVazio(tela As Control)
        'Dim controle As Object
        '   For Each controle In tela.Controls
        '      If TypeOf controle Is TextBox Or TypeOf controle Is ComboBox Then
        '         If controle.Text = "" And controle.tag <> "x" Then
        '            MessageBox.Show("Preencha todos os campos obrigatórios", "Aviso")
        '           controle.focus()
        '          Return True
        '     End If
        'End If
        ' Next
    End Function

End Class
