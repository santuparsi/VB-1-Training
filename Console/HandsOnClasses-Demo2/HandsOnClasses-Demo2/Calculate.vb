Public Class Calculate
    Dim s As String
    Public Shared Function Greet(name As String) As String
        Return "Hello " + name
    End Function
    Public Function EvenNo(n() As Integer) As Integer()
        'find even values in the n() array and return as array type
        Dim n1(n.Length) As Integer
        Dim i As Integer = 0
        For Each k In n
            If k Mod 2 = 0 Then
                n1(i) = k
                i = i + 1
            End If
        Next
        Return n1
    End Function
End Class
Public Class Test_Calculate
    Shared Sub main()
        Dim msg As String = Calculate.Greet("Sachin")
    End Sub
End Class
