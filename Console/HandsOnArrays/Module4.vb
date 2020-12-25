Module Module4
    Sub main()
        Dim size As Integer
        Console.WriteLine("How many Employee you want to store")
        size = CInt(Console.ReadLine)
        Dim names(size - 1) As String
        For i As Integer = 0 To size - 1
            Console.Write("Enter name({0}):", i)
            names(i) = Console.ReadLine()
        Next
        Console.WriteLine(vbNewLine)
        'print employees
        For Each k In names
            Console.WriteLine(k)
        Next
        Console.ReadKey()

    End Sub
End Module
