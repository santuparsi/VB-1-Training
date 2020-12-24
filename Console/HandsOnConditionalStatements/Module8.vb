Module Module8
    Sub main()
        Dim grade As Char
        grade = "C"
        Select Case grade
            Case "A"
                Console.WriteLine("Excellent")
            Case "B", "C"
                Console.WriteLine("Well Done")
            Case "D"
                Console.WriteLine("You Passed")
            Case "F"
                Console.WriteLine("Better luck next time")
            Case Else
                Console.WriteLine("Invalid Input")
        End Select
    End Sub
End Module
