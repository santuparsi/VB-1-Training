Public Class Employee
    Public Eid As Integer
    Public Ename As String
    Private Sub New() 'restict object creation using new keyword
        Eid = 1000
        Ename = "Rohan"
    End Sub
    Public Shared Function GetObject() As Employee
        Dim obj As New Employee()
        Return obj
    End Function
    Public Sub Details()
        Console.WriteLine("ID:{0} Name:{1}", Eid, Ename)
    End Sub
End Class
Module Module3
    Sub main()
        ' Dim ob As New Employee() error
        Dim ob As Employee = Employee.GetObject
        ob.Details()

    End Sub
End Module