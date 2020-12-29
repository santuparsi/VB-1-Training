Module Module2
    Sub main()
        Dim a As Integer
        a = 10
        M(a)
        Console.WriteLine("a value after calling M() " & a)
        M1(a)
        Console.WriteLine("a value after calling M1() " & a)
        sum(12, 23, 45)
        sum(90, 45, 67, 78)
        sum(34, 56)
    End Sub
    Sub M(ByVal a As Integer)
        a = a * a
        Console.WriteLine(a)
    End Sub
    Sub M1(ByRef a As Integer)
        a = a * a
        Console.WriteLine(a)
    End Sub
    Sub sum(ParamArray n() As Integer)
        Dim s As Integer = 0
        For Each k In n
            s = s + k
        Next
        Console.WriteLine("sum of Array no's {0} ", s)
    End Sub

End Module
