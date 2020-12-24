Module Module5
    Sub main()
        Dim m1, m2, m3, m4, m5, tot, avg As Double
        m1 = 67
        m3 = 50
        m2 = 55
        m4 = 77
        m5 = 66
        tot = m1 + m2 + m3 + m4 + m5
        avg = tot / 5
        Dim result As String = Nothing
        If avg >= 70 Then
            result = "Distinction"
        ElseIf avg >= 60 And avg < 70 Then
            result = "FirstClass"
        ElseIf avg >= 50 And avg < 60 Then
            result = "SecondClass"
        Else
            result = "ThirdClass"
        End If
        Console.WriteLine(result)
        Console.ReadKey()
    End Sub
End Module
