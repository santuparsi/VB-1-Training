Module Module6
    Sub main()
        Dim ob As New Queue
        'add items
        ob.Enqueue("Rose")
        ob.Enqueue("Lilly")
        ob.Enqueue("Tuplip")
        ob.Enqueue("Jasmine")
        Console.WriteLine("Count: {0} ", ob.Count)
        Console.WriteLine("First Flower: {0} ", ob.Peek())
        For Each k In ob
            Console.WriteLine(k)
        Next
        ob.Clear()
    End Sub
End Module
