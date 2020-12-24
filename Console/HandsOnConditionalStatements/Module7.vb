Module Module7
    Sub main()
        Dim a, b, c As Integer
        a = 10
        b = 20
        c = 30
        If a > b Then
            If a > c Then
                Console.WriteLine("{0} is Max", a)
            Else
                Console.WriteLine("{0} is Max", c)
            End If
        Else
            If b > c Then
                Console.WriteLine("{0} is Max", b)
            Else
                Console.WriteLine("{0} is Max", c)
            End If
        End If


    End Sub
End Module
