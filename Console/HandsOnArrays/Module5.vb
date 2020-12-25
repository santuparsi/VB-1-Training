Module Module5
    Sub main()
        Dim n() As Integer
        ReDim n(2)
        n(0) = 1
        n(1) = 2
        n(2) = 3
        'change array size
        'ReDim n(4) 'array values are truncated
        ReDim Preserve n(4) 'array values are preserved
        n(3) = 4
        n(4) = 5
        For Each k In n
            Console.WriteLine(k)
        Next


    End Sub
End Module
