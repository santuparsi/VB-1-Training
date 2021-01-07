Public Class Demo3
    Sub M()

    End Sub
    Function F() As String
        M()
        Me.M()
        Return Nothing
    End Function
End Class
