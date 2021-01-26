Imports System.Collections.Generic
Module Module1
    Dim db As New PracticeDBEntities
    Sub GetAll() 'fetch all the Employees
        Dim list As List(Of Employee) = (From i In db.Employees Select i).ToList()
        For Each item In list
            Console.WriteLine("{0} {1} {2} {3} {4} ", item.Eid, item.Ename, item.JoinDate, item.Salary, item.Desingnation)
        Next
    End Sub
    Sub GetById(id As Integer)
        Dim ob As Employee = db.Employees.SingleOrDefault(Function(e) e.Eid = id)
        If ob Is Nothing Then
            Console.WriteLine("Invalid id")
        Else
            Console.WriteLine("Name: " & ob.Ename)
            Console.WriteLine("Salary: " & ob.Salary)
        End If


    End Sub
    Sub Add(item As Employee)
        db.Employees.Add(item)
        db.SaveChanges()
    End Sub
    Sub Delete(id As Integer)
        Using repo As New PracticeDBEntities
            Dim e As Employee = repo.Employees.Find(id)
            repo.Employees.Remove(e)
            repo.SaveChanges()
        End Using
    End Sub
    Sub Update(id As Integer)
        Using repo As New PracticeDBEntities
            Dim e As Employee = repo.Employees.Find(id)
            e.Salary = 90000
            e.Desingnation = "TeamLead"
            repo.SaveChanges()
        End Using
    End Sub
    Sub Main()
        'Add(New Employee() With {.Eid = 40, .Ename = "Hari", .Desingnation = "Programmer", .JoinDate = Today, .Salary = 10000})
        ' Delete(40)
        Update(2)
        GetAll()
        'GetById(20)
    End Sub

End Module
