Module Module3
    Sub main()
        Dim str As String = ".Net was developed by microsoft"
        If str.Contains("was developed by Google") Then
            Console.WriteLine("you win")
        Else
            Console.WriteLine("better luck next time")
        End If
    End Sub
End Module
