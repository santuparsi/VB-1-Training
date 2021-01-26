Public Class Employee
    Private eid As Integer
    Private ename As String
    Public Property ID() As Integer
        Get
            Return eid
        End Get
        Set(value As Integer)
            If value < 0 Then
                Console.WriteLine("EId should no be -ve value")
            Else
                eid = value
            End If

        End Set
    End Property
    Public Property Name() As String
        Get
            Return ename
        End Get
        Set(value As String)
            ename = value
        End Set
    End Property

End Class
