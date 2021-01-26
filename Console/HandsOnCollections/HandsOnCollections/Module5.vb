Module Module5
    Sub main()
        Dim ob As New Stack
        'add items
        ob.Push(10)
        ob.Push(23)
        ob.Push(89)
        ob.Push(78)
        ob.Push(90)
        Console.WriteLine("count: {0}", ob.Count)
        Console.WriteLine("top value: {0}", ob.Peek())
        'remove top value
        ob.Pop()
        For Each k In ob
            Console.WriteLine(k)
        Next
        'clear stack
        ob.Clear()

    End Sub
End Module
