Module Module7
    Sub main()
        '2-dimensional array
        Dim n As Integer(,) = New Integer(1, 2) {{1, 2, 3}, {4, 5, 6}}
        Dim n1(1, 1) As Integer
        'assign values
        n1(0, 0) = 10
        n1(0, 1) = 20
        n1(1, 0) = 30
        n1(1, 1) = 40

        'display array values in matrix format
        For i As Integer = 0 To 1
            For j As Integer = 0 To 1
                Console.Write(n1(i, j) & vbTab)
            Next
            Console.WriteLine()
        Next


    End Sub
End Module
