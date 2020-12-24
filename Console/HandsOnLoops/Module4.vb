Module Module4
    Sub main()
        Dim flag As Integer = 19
        Do While flag <= 10
            Console.WriteLine(flag)
            flag += 1
        Loop
        Do
            Console.WriteLine(flag)
            flag += 1
        Loop While flag <= 10
    End Sub
End Module
