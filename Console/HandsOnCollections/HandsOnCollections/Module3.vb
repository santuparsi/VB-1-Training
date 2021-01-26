Module Module3
    Sub main()
        '  Dim ob As New Hashtable
        Dim ob As New SortedList
        'add items
        ob.Add(2312, "Rohan")
        ob.Add(3456, "Karan")
        ob.Add(4567, "John")
        ob.Add(5678, "Ram")
        Dim s As String = ob(4560) 'return value of the key
        Console.WriteLine(s)
        ob.Remove(5689)
        For Each k In ob.Keys
            Console.WriteLine("Key:{0} and Value:{1}", k, ob(k))
        Next
        ob.Clear()
    End Sub
End Module
