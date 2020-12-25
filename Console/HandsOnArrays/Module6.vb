Module Module6
    Sub main()
        Dim n() As Integer = {39, 34, 45, 56, 9, 4, 12}
        'return size of the array
        Console.WriteLine("size: " & n.Length)
        Console.WriteLine("rank: " & n.Rank) 'return dimension of the array
        Array.Sort(n) 'sort array elements
        Array.Reverse(n) 'reverse array elements
        For Each k In n
            Console.WriteLine(k)
        Next
        Console.WriteLine()
        Console.WriteLine("Enter a no")
        Dim no As Integer = Console.ReadLine
        Dim idx As Integer
        Array.Sort(n)
        idx = Array.BinarySearch(n, no)
        If idx >= 0 Then
            Console.WriteLine("you win..")
        Else
            Console.WriteLine("try your luck next time..")
        End If

    End Sub
End Module
