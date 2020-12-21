Module Module1

    Sub Main()
        'variable declaration
        'local variables
        Dim a As Integer
        Dim length As Double
        Dim width As Double
        a = 10
        length = 23.4
        width = 34.5
        Dim obj As New Rectangle
        obj.Area() 'calling area procedure
        Dim obj1 As New Rectangle
        obj1.Accept(12.2, 34.5)
        obj1.Area()
        Console.ReadKey()


    End Sub

End Module
