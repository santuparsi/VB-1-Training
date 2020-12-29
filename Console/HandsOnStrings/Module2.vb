Module Module2
    Sub main()
        Dim str As String = "Good Morning"
        Console.WriteLine(str.LastIndexOf("o"c))
        Console.WriteLine(str.IndexOf("o"c))
        Console.WriteLine(str(2))
        Dim s1, s2 As String
        Console.WriteLine("enter password")
        s1 = Console.ReadLine
        Console.WriteLine("re-type password")
        s2 = Console.ReadLine
        If s1.Equals(s2) Then
            Console.WriteLine("matched")
        Else

            Console.WriteLine("mis matched")
        End If

    End Sub
End Module
