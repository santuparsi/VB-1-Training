Public Class Employee
    Public Eid As Integer
    Public Ename As String
End Class
Public Class Info
    Public list(1) As Employee
    Public Function Details(id As Integer) As Employee
        For Each i In list
            If i.Eid = id Then
                Return i
            End If
        Next
        Return Nothing
    End Function
End Class
Public Class Test_Employee
    Shared Sub main()
        Dim Obj As New Info
        Obj.list(0) = New Employee() With {.Eid = 1, .Ename = "Rohan"}
        Obj.list(1) = New Employee() With {.Ename = "Charan", .Eid = 2}
        Dim e As Employee = Obj.Details(1)
        If e IsNot Nothing Then

            Console.WriteLine("Hello " + e.Ename)
        Else
            Console.WriteLine("Invalid Id")
        End If


    End Sub
End Class