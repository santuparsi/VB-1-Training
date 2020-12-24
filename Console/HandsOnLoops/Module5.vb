Module Module5
    Sub main()
        'for loop
        Dim a As Integer
        'For a = 10 To 20
        '    Console.WriteLine("value of a:{0}", a)
        'Next
        'For a = 10 To 20 Step 2
        '    Console.WriteLine("value of a:{0}", a)
        'Next

        'For a = 10 To 10000 Step 2
        '    Console.WriteLine("value of a:{0}", a)
        '    If a = 100 Then
        '        Exit For
        '    End If
        'Next
        For a = 100 To 0 Step -5
            Console.WriteLine("value of a:{0}", a)
        Next
    End Sub
End Module
