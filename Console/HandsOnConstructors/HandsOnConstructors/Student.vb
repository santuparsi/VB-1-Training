Public Class Student
    Private sid As Integer
    Private sname As String
    Private age As Byte
    Public Sub New(sid As Integer, sname As String, age As Integer)
        Me.sid = sid
        Me.sname = sname
        Me.age = age
    End Sub
    Public Sub Details()
        Console.WriteLine("ID: {0} Name:{1} Age:{2}", sid, sname, age)
    End Sub
End Class
Module Module2
    Sub main()
        Dim s As New Student(1, "Rohan", 10)
        s.Details()
        Dim n(1) As Student
        n(0) = New Student(2, "Charan", 9)
        n(1) = New Student(3, "Suren", 8)
        For Each ob In n
            ob.Details()
        Next

    End Sub
End Module