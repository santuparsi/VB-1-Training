Module Module2
    Sub main()
        Dim str() As String = {"Rohan", "Karan", "Charan", "Kiran"}
        'fetch names starts with k
        Dim query = From k In str Where k.StartsWith("K") Select k.ToUpper
        For Each r In query
            Console.WriteLine(r)
        Next

    End Sub
End Module
