Public Class Employee
    Public Eid As Integer
    Public Ename As String
    Public Salary As Double
End Class
Module Module4
    Sub main()
        Dim list As New List(Of Employee) From
            {
            New Employee() With {.Eid = 1, .Ename = "Charan", .Salary = 10000},
            New Employee() With {.Eid = 2, .Ename = "Karan", .Salary = 10000},
            New Employee() With {.Eid = 3, .Ename = "Suren", .Salary = 12000},
            New Employee() With {.Eid = 4, .Ename = "Jeson", .Salary = 12000},
            New Employee() With {.Eid = 5, .Ename = "Lenin", .Salary = 10000}
            }
        'fetch employees having salary of 10000
        Dim query = From e In list Where e.Salary = 10000 Select e
        'fetch employee using id
        query = From e In list Where e.Eid = 1 Select e
        ' fetch employees sorted order of ename
        query = From e In list Order By e.Ename Select e
        For Each item In query
            Console.WriteLine("{0} {1} {2} ", item.Eid, item.Ename, item.Salary)
        Next
        Dim list1 As List(Of Employee)
        list1 = (From e In list Where e.Salary = 10000 Select e).ToList()
        list1 = list.Where(Function(e) e.Salary = 10000).ToList()
        Console.WriteLine("Employee Count: " + list1.Count)
        Dim ob As Employee = (From e In list Where e.Eid = 1 Select e).SingleOrDefault()
        ob = list.SingleOrDefault(Function(x As Employee) x.Eid = 1)
    End Sub
End Module