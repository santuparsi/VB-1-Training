Public Class Circle
    Dim r As Double
    Shared PI As Double
    Shared Sub New() 'Shared constructor
        PI = 3.14
        Console.WriteLine("Shared Constructor invoked")
    End Sub
    Public Sub New(r As Double)
        Me.r = r
    End Sub
    Public Sub Area()
        Dim result As Double
        result = PI * Math.Pow(r, 2)
        Console.WriteLine("Area of Circle with Radius {0} is {1}", r, result)
    End Sub
End Class
Module Module4
    Sub main()
        Dim c As New Circle(2.1)
        Dim c1 As New Circle(23.3)
        c.Area()
        c1.Area()
    End Sub
End Module