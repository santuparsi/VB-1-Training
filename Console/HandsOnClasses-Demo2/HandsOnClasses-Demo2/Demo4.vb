Class A
    Public Sub f()

    End Sub
    Public Sub f1()

    End Sub
End Class
Class B
    Inherits A
    Sub f()

    End Sub
    Sub Doit()
        f1()
        f() 'B.f()

    End Sub
End Class
Public Class Demo4

End Class
