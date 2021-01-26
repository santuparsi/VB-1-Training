Class I
    Public Sub New()
        Console.WriteLine("I is Initiated")
    End Sub
    Public Sub New(name As String)
        Console.WriteLine("Hello " & name)
    End Sub
    Public Sub f()
        Console.WriteLine("I::f()")
    End Sub
End Class
Class J
    Inherits I
    Public Sub New()
        Console.WriteLine("J is Initiated")
    End Sub
    Public Sub New(s As String)
        MyBase.New(s)

    End Sub
    Public Sub f()
        Console.WriteLine("J::f()")
        MyBase.f()
    End Sub
End Class
Module Module2
    Sub main()
        Dim ob As New J
        Dim ob1 As New J("Sachin")

    End Sub
End Module
