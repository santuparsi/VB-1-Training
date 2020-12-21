Public Class Rectangle
    Private length As Double
    Private width As Double
    Sub Accept(l As Double, w As Double)
        length = l
        width = w
    End Sub
    Sub Area()
        Dim ar As Double
        ar = length * width
        Console.WriteLine("Area " & ar)
    End Sub

End Class
