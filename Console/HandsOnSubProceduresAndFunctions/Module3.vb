Module Module3
    Function Greet(name As String) As String
        Return "Hello " & name
    End Function
    Function Hello() As String
        Return Nothing
    End Function
    Function GetOdd(ParamArray n() As Integer) As Integer()
        Dim size As Integer = n.Length
        Dim n1(size) As Integer
        Dim idx As Integer = 0
        For i = 0 To n.Length - 1
            If n(i) Mod 2 <> 0 Then
                n1(idx) = n(i)
                idx = idx + 1
            End If
        Next
        'ReDim Preserve n1(idx - 1)
        Return n1
    End Function
    Sub main()
        Dim result As String = Greet("Sachin")
        Dim n() As Integer = GetOdd(12, 23, 34, 45, 56, 67)
        For Each k In n
            Console.WriteLine(k)
        Next

    End Sub
End Module
