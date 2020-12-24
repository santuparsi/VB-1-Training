Module Module1

    Sub Main()
        'array declaration
        Dim a(5) As Integer
        'assign the values
        a(0) = 10
        a(1) = 20
        a(2) = 30
        a(3) = 40
        a(4) = 50
        a(5) = 60
        'access array value
        Dim i As Integer = a(2) '30
        'fetching array value using for 
        'For j As Integer = 0 To a.Length
        '    Console.WriteLine(a(j))
        'Next
        'fetching array values using ForEach
        Dim sum As Integer
        For Each i In a
            Console.WriteLine(i)
            sum = sum + i
        Next
        Console.WriteLine("Sum of array values: {0}", sum)
    End Sub

End Module
