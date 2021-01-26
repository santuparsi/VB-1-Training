Imports System.Linq
Public Interface IShape
    Sub Area()
End Interface
Class Circle
    Implements IShape
    Dim r As Double
    Public Sub New(r As Double)
        Me.r = r
    End Sub
    Public Sub Area() Implements IShape.Area
        Console.WriteLine("Area of Circle: " & Math.PI * r * r)
    End Sub
End Class
Class Rectangle
    Implements IShape
    Public Sub Area() Implements IShape.Area

    End Sub
End Class
Module Module3
    Sub main()
        Dim c As New Circle(12.2)
        Dim a As New ArrayList
        Dim b As New Stack
        c.Area()
    End Sub
End Module