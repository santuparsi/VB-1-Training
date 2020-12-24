Module Module6
    Sub main()
        Console.WriteLine("Enter Name")
        Dim name As String = Console.ReadLine()
        If name <> "" Then
            Console.WriteLine("Hello " & name)
        Else
            Console.WriteLine("Enter your Name")
        End If
        Console.ReadKey()
    End Sub

End Module
