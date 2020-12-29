Module Module1
    Sub Hello()
        Console.WriteLine("Hello everyone")

    End Sub
    Sub Greet(name As String)
        Hello()
        Console.WriteLine("Hello " & name)
    End Sub
    Sub Add(i As Integer, Optional j As Integer = 10)
        Dim k As Integer
        k = i + j
        Console.WriteLine(k)
    End Sub
    Sub Sum(n() As Integer)
        Dim s As Integer = 0
        For Each k In n
            s = s + k
        Next
        Console.WriteLine("sum of Array no's {0} ", s)
    End Sub
    Sub search(n() As String, srch As String)
        Dim s As String = String.Join(" ", n)
        If s.Contains(srch) Then
            Console.WriteLine("Valid name")
        Else
            Console.WriteLine("Invalid name")
        End If
    End Sub
    Sub Main()
        ' Hello()
        ' Greet("Sachin")
        'Greet("Rahul")
        Add(12, 13)
        Add(29)
        Dim n() As Integer = {12, 34, 45, 56}
        Sum(n)
        Sum(New Integer() {12, 34, 45, 56, 90})

        search(New String() {"Ram", "Robert", "Rahim"}, "Krishna")
        search(srch:="Krishna", n:=New String() {"Ram", "Robert", "Rahim"})
        Dim a, b As Integer
        a = 10
        b = 20
        Add(a, b)
        Add(j:=b, i:=a)

    End Sub

End Module
