Module Module1

    Sub Main()
        Dim a As Integer = 10
        'While a < 20
        '    If a = 12 Then
        '        a = a + 1
        '        Continue While
        '    End If
        '    Console.WriteLine("a:{0}", a)
        '    a = a + 1
        'End While
        While True

            If a = 12 Then
                a = a + 1
                Continue While
            End If
            Console.WriteLine("a:{0}", a)
            a = a + 1
            If a = 20 Then
                Exit While
            End If
        End While
    End Sub

End Module
