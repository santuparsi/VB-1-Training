Module Module1

    Sub Main()
        'Compare

        'Dim str As String = "Good Morning"
        'Dim str1 As String = "Good morning"
        'If String.Compare(str, str1, True) = 0 Then
        '    Console.WriteLine("strings are equal")
        'Else
        '    Console.WriteLine("strings are not eqaual")
        'End If

        'Join

        'Dim s1, s2 As String
        's1 = "Hello "
        's2 = "Ram"
        'Dim s3 As String = s1 + " " + s2
        's3 = String.Join("_", s1, s2)
        'Console.WriteLine(s3)
        'Dim s() As String = {"Hello", "EveryOne", "Good Morning", "to all"}
        's3 = String.Join(" ", s)
        'Console.WriteLine(s3)

        'Split
        Dim str As String = "Hello everyone good morning to_all"
        Dim s() As String = str.Split(" "c, "_"c)
        For Each k In s
            Console.WriteLine(k)
        Next


    End Sub

End Module
