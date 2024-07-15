Module Validaciones
    Function Solo_Numeros(ByVal Tecla As System.Windows.Forms.KeyPressEventArgs)
        Dim Tecla_Presionada As Integer
        Tecla_Presionada = AscW(Tecla.KeyChar)
        If Tecla_Presionada >= 48 And Tecla_Presionada <= 57 Or Tecla_Presionada = 13 Or Tecla_Presionada = 8 Or Tecla_Presionada = 32 Then
            Solo_Numeros = AscW(Tecla.KeyChar)
        Else
            Solo_Numeros = 0

        End If
        'e.KeyChar = ChrW(Solo_Numeros(e))
        'If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
        '    DireccionTextBox.Focus()
        'End If
    End Function

    Function Solo_Letras(ByVal Tecla As System.Windows.Forms.KeyPressEventArgs)
        Dim Tecla_Presionada As Integer
        Tecla_Presionada = AscW(Tecla.KeyChar)
        If (Tecla_Presionada >= 65 And Tecla_Presionada <= 90) Or (Tecla_Presionada >= 97 And Tecla_Presionada <= 122) Or Tecla_Presionada = 13 Or Tecla_Presionada = 8 Or Tecla_Presionada = 32 Then
            Solo_Letras = AscW(Tecla.KeyChar)
        Else
            Solo_Letras = 0
        End If
        'e.KeyChar = ChrW(Solo_Letras(e))
        'If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
        '    CbxDistrito.Focus()
        'End If
    End Function
End Module
