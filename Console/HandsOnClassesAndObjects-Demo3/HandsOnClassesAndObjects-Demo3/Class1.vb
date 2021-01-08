Public Class Class1
    Sub Add(i As Integer, j As Integer)
        Console.WriteLine(i + j)
    End Sub
    Sub Add(a As Integer)
        Console.WriteLine(a + a)
    End Sub
    Sub Add(i As Double, j As Double)
        Console.WriteLine(i + j)

    End Sub
    Function Add(i As Integer, j As Integer, k As Integer) As Integer
        Dim result As Integer = i + j + k
        Return result
    End Function
    'Function Add(i As Integer, j As Integer) As Integer
    '    Dim result As Integer = i + j
    '    Return result
    'End Function
End Class
Class Test_Class
    Shared Sub main()
        Dim obj As New Class1
        obj.Add(1, 2)
        obj.Add(2)
        obj.Add(12.3, 34.5)
        obj.Add(1, 2, 3)
    End Sub
End Class