Public Class Student
    Public Sid As Integer
    Public Sname As String
    Public Age As Integer
End Class
Public Class Info
    Public list As New ArrayList
    Public Sub Register(s As Student)
        list.Add(s)
    End Sub
    Public Function GetAll() As ArrayList
        Return list
    End Function
End Class
Module Test_Student
    Sub main()
        Dim s1 As New Student With {.Sid = 1, .Sname = "Rohan", .Age = 10}
        Dim s2 As New Student With {.Sid = 2, .Sname = "Karan", .Age = 11}
        Dim s3 As New Student With {.Sid = 3, .Sname = "Charan", .Age = 10}
        Dim s4 As New Student With {.Sid = 4, .Sname = "Kiran", .Age = 12}
        Dim s5 As New Student With {.Sid = 5, .Sname = "Krishna", .Age = 10}
        Dim s6 As New Student With {.Sid = 6, .Sname = "John", .Age = 11}
        Dim s7 As New Student With {.Sid = 7, .Sname = "Ram", .Age = 10}
        Dim s8 As New Student With {.Sid = 8, .Sname = "Robert", .Age = 12}
        'Dim ar As New ArrayList From {s1, s2, s3, s4, s5, s6, s7}
        'ar.Add(s8)
        'ar.Add(New Student With {.Sid = 9, .Sname = "Suren", .Age = 10})
        ''fetch Student using index
        'Dim s As Student = ar(0)
        'Console.WriteLine(s.Sname)
        'Dim ar1 As New ArrayList
        ''fetch all student data
        'For Each ob As Student In ar
        '    Console.WriteLine("{0} {1} {2}", ob.Sid, ob.Sname, ob.Age)
        '    If ob.Age = 10 Then
        '        ar1.Add(ob.Sname)
        '    End If
        'Next
        'For Each ob As String In ar1
        '    Console.WriteLine(ob)
        'Next
        Dim db As New Info
        db.Register(s1)
        db.Register(s2)
        Dim ar As New ArrayList
        ar = db.GetAll()
        For Each ob As Student In ar
            Console.WriteLine("{0} {1} {2}", ob.Sid, ob.Sname, ob.Age)
        Next

    End Sub
End Module