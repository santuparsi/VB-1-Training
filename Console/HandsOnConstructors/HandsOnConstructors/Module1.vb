Class Sample
    Public i, j As Integer
    Public Sub New() 'default constructor
        i = 10
        j = 20
    End Sub
    Public Sub New(a As Integer, b As Integer) 'Parametarized constructor
        i = a
        j = b
    End Sub
    Public Sub Show()
        Console.WriteLine("i={0} and j={1}", i, j)
    End Sub

End Class
Module Module1

    Sub Main()
        Dim ob As New Sample
        ob.Show()
        Dim ob1 As New Sample
        ob1.Show()
        Dim ob2 As New Sample(2, 4)
        ob2.Show()


    End Sub

End Module
