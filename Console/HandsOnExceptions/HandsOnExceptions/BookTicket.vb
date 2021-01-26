Public Class BookTicket

    Public Sub Book(count As Integer)
        Try
            If count <= 2 Then
                Console.WriteLine("Booking Success..")
            Else
                Throw New BookException
            End If
        Catch ex As BookException
            Console.WriteLine(ex.ErrorMsg())
        End Try
    End Sub
End Class
Module Module2
    Sub main()
        Dim ob As New BookTicket
        ob.Book(2)
        ob.Book(10)
    End Sub
End Module