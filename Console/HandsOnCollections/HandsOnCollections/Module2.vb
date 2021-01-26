Imports System.Collections

Module Module2
    Sub main()
        Dim ar As New ArrayList From {
        "Rose",
        "Lilly",
        "Jasmine",
        "Tulips"
        }
        ar.Sort()
        Dim name As String
        name = Console.ReadLine
        If ar.BinarySearch(name) >= 0 Then
            Console.WriteLine("Flower in the Garden")
        Else
            Console.WriteLine("Not in the Garden")
        End If
    End Sub
End Module
