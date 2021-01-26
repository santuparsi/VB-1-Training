Class X
    Public a As Integer
End Class
Class Y
    Inherits X
    Public b As Integer
End Class
Class Z
    Inherits Y
    Public c As Integer
    Public Sub f()
        a = 10
        b = 20
        c = 30
    End Sub
End Class
Public Class Class1
    Shared Sub main()
        Dim o As New Z
        o.a = 10
        o.b = 20
        o.c = 30
        Dim o1 As New Y
        o1.a = 10
        o1.b = 20
        Dim o2 As New X
        o2.a = 20
    End Sub
End Class
