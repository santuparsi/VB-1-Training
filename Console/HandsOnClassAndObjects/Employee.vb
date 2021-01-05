Public Class Employee
    'instance variables
    Public Eid As Integer
    Public Ename As String
    Public JoinDate As Date
    'shared variables
    Public Shared Company As String
    Public Shared Project As String
    'Public Sub Show()
    '    Console.WriteLine("Eid: " & Eid)
    '    Console.WriteLine("Name: " & Ename)
    '    Console.WriteLine("JoinDate: " & JoinDate)
    '    Console.WriteLine("Company: " & Company)
    '    Console.WriteLine("Project: " & Project)
    'End Sub
End Class
Class Info
    Sub Register(e As Employee)
        'Register the employee details
        Console.WriteLine("Eid: " & e.Eid)
        Console.WriteLine("Name: " & e.Ename)
        Console.WriteLine("JoinDate: " & e.JoinDate)
        Console.WriteLine("Company: " & Employee.Company)
        Console.WriteLine("Project: " & Employee.Project)
    End Sub
End Class
Class Test_Employee
    Shared Sub main()
        Employee.Company = "ABC"
        Employee.Project = "Insurence"
        Dim e1 As New Employee With {.Eid = 100, .Ename = "Karan", .JoinDate = Date.Parse("12.2.2020")}
        ' e1.Show()
        Dim e2 As New Employee With {.Eid = 101, .Ename = "Rohan", .JoinDate = Date.Parse("10.2.2020")}
        ' e2.Show()
        'Array of EMployee
        'Dim list(2) As Employee
        'list(0) = e1
        'list(1) = e2
        'list(2) = New Employee With {.Eid = 102, .Ename = "Charan", .JoinDate = Now}
        'For Each obj In list
        '    obj.Show()
        '    Console.WriteLine("----------------------")
        'Next
        Dim info As New Info
        info.Register(e1)
        info.Register(e2)



    End Sub
End Class
