Class A 'base class
    Public Sub f()
        Console.WriteLine("f task")
    End Sub
End Class
Class B 'derived-class
    Inherits A
    Public Sub M()
        f()
    End Sub
End Class
Module Module1

    Sub Main()
        Dim ob As New B
        ob.f()
        ob.M()

    End Sub

End Module
