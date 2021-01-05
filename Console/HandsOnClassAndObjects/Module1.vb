Module Module1

    Sub Main()
        'Create object of Student Class
        Dim obj As New Student

        obj.Sname = "Rohan"
        obj.Age = 10
        obj.Address = "Hi-tech City,Hyderabad"
        obj.Details()
        Dim s As New Student
        s.Sname = "Karan"
        s.Address = "Banglore,BTM"
        s.Age = 12
        s.Details()
        Dim s1 As New Student With {.Sname = "John", .Address = "Chennai", .Age = 10}
        s1.Details()

    End Sub

End Module
