Module Module6
    Sub main()
        Dim i As Integer
        For i = 1 To 10
            For j = 1 To i
                Console.Write(i & vbTab)
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub
End Module
