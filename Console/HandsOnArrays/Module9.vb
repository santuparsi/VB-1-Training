Module Module9
    Sub main()
        Dim a As Integer()() = New Integer(3)() {}
        a(0) = New Integer() {12, 23}
        a(1) = New Integer() {23, 34, 56, 67}
        a(2) = New Integer() {45, 56, 67}
        a(3) = New Integer() {12}
        'access array 0 elemets
        For k = 0 To 1
            Console.Write(a(0)(k) & vbTab)
        Next
        Console.WriteLine()
        'access all array elements
        For j As Integer = 0 To 3
            For k As Integer = 0 To a(j).Length - 1
                Console.Write(a(j)(k) & vbTab)
            Next
            Console.WriteLine()
        Next

    End Sub
End Module
