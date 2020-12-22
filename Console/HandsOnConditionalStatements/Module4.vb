Module Module4
    Sub main()
        Dim a As Integer = 10
        While a < 20
            If a Mod 2 <> 0 Then
                a = a + 1
                Continue While
            End If
            Console.WriteLine("Value of a:{0}", a)
            a = a + 1
        End While
        Console.ReadKey()
    End Sub
End Module
