Public Class Student
    Public Sid As Integer
    Public Sname As String
    Public Sub Accept(obj As Student)
        'getting student details
    End Sub
    Public Function Register() As String
        Accept(Me)
    End Function
End Class
Public Class Student_Test
    Shared Sub main()
        Dim obj As New Student
        obj.Accept(obj)

    End Sub
End Class