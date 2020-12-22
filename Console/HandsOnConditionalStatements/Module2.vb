Module Module2
    Sub main()
        Dim i As Integer
        Console.WriteLine("enter i values")
        i = Console.ReadLine
        If i Mod 2 = 0 Then
            Console.WriteLine("{0} is Even", i)
        Else
            Console.WriteLine("{0} is Odd", i)
        End If
        Console.ReadKey()
    End Sub
End Module
