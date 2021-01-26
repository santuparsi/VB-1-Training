Module Module4
    Function Validate(list As SortedList, uname As String, pwd As String) As Boolean
        For Each k In list.Keys
            If k = uname And list(k) = pwd Then
                Return True
            End If
        Next
        Return False
    End Function
    Sub main()
        Dim list As New SortedList From {
        {"Rohan", "12345"},
        {"Tim", "12345"},
        {"Suren", "12345"},
        {"John", "12345"},
        {"Ram", "12345"},
        {"Faran", "12345"}
        }
        Dim uname, pwd As String
        Console.WriteLine("Enter username")
        uname = Console.ReadLine
        Console.WriteLine("Enter password")
        pwd = Console.ReadLine
        Dim result As Boolean = Validate(list, uname, pwd)
        If result Then
            Console.WriteLine("Valid User")
        Else
            Console.WriteLine("Invalid User")
        End If


    End Sub
End Module
