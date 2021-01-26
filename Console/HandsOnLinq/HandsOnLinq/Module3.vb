Module Module3
    Sub main()
        Dim list As New List(Of Integer)
        list.Add(12)
        list.Add(243)
        list.Add(34)
        list.Add(78)
        Dim query = From k In list Where k < 100
                    Select k
        For Each n In query
            Console.WriteLine(n)
        Next

    End Sub
End Module
