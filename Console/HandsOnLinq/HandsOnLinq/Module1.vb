Imports System.Linq

Module Module1

    Sub Main()
        Dim a() As Integer = {12, 34, 56, 65, 43, 32, 21, 67, 87, 98, 80}
        'fetch even values from array
        Dim result = From i In a Where i Mod 2 = 0 Select i
        'fetch array values in sorted order
        result = From i In a
                 Where i Mod 2 = 0
                 Order By i Descending
                 Select i

        For Each k In result
            Console.WriteLine(k)
        Next




    End Sub

End Module
