Public Class Demo
    'procedure
    Sub Add(i As Integer, j As Integer)
        Console.WriteLine("Addition: " & (i + j))
    End Sub
    Shared Sub Sum(n() As Integer)
        Dim i As Integer = 0
        For Each k In n
            i = i + k
        Next
        Console.WriteLine("Sum of Array no's {0}", i)
    End Sub
    Sub f()
        Console.WriteLine("Sample procedure")
    End Sub
    Sub f1()
        f()
        Me.f()
    End Sub
    Shared Sub main()
        Dim obj As New Demo
        obj.Add(3, 4)
        Demo.Sum(New Integer() {12, 34, 45, 56})
    End Sub
End Class
