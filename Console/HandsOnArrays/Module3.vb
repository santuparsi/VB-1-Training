Module Module3
    Sub main()
        Dim flowers() As String = {"Rose", "Lilly", "Jasmine", "Tulips"}
        Console.WriteLine("Enter flower name")
        Dim name As String = Console.ReadLine
        Dim flag As Boolean = False
        For Each s In flowers
            If s = name Then
                Console.WriteLine("Flower Exist")
                flag = True
                Exit For
            End If
        Next
        'If Not flag Then
        '    Console.WriteLine("Flower Not in the Garden")
        'End If
        If flag = False Then
            Console.WriteLine("Flower Not in the Garden")
        End If

    End Sub
End Module
