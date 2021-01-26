Public Class BookException
    Inherits ApplicationException
    Function ErrorMsg() As String
        Return "Booking failed" & vbNewLine & "Reason: Order more than 2 tickets"
    End Function
End Class
