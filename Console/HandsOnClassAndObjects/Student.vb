Class Student

    Private Sid As Integer
    Public Sname As String
    Public Age As Integer
    Public Address As String
    Dim Std As String  'Private variable
    Sub Details()
        Dim rand As New Random()
        Sid = rand.Next(10, 1000)
        Sid = Sid * 99
        Console.WriteLine("ID: " & Sid)
        Console.WriteLine("Name: " & Sname)
        Console.WriteLine("Age: " & Age)
        Console.WriteLine("Address: " + Address)
    End Sub
    Shared Sub main()
        Dim obj1 As Student
        obj1.Std = "II"
        obj1.Sid = 100
    End Sub
End Class
