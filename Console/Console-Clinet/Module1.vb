Imports My.MathLib
Module Module1

    Sub Main()
        Dim obj As New Calculate
        Dim a, b As Integer
        a = 10
        b = 20
        Console.WriteLine(obj.Add(a, b))
        Dim obj1 As New Convertor
        Dim amt As Double
        amt = 100000
        Console.WriteLine(obj1.RTD(amt))
    End Sub

End Module
