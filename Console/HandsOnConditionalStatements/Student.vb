Public Class Student
    Public Sid As Integer
    Shared Sub main()
        Dim obj As Student
        Dim obj1 As New Student
        ' obj = New Student
        obj.Sid = 10
        If obj Is Nothing Then

            Console.WriteLine("Object is null")
        Else

            Console.WriteLine("Object is Exist")
        End If
        Console.ReadKey()
    End Sub
End Class
