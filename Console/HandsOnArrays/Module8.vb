Module Module8
    Sub main()
        Dim names(,) As String = {{"Admin", "12345"}, {"Rohan", "12345"}, {"Charan", "12345"}}
        Console.WriteLine("enter username")
        Dim uname As String = Console.ReadLine
        Console.WriteLine("enter password")
        Dim pwd As String = Console.ReadLine
        Dim flag As Integer = 0
        For i As Integer = 0 To 2
            If names(i, 0) = uname And names(i, 1) = pwd Then
                Console.WriteLine("valid user.")
                flag = 1
                Exit For
            End If
        Next
        If flag = 0 Then
            Console.WriteLine("Invalid User")
        End If

    End Sub
End Module
