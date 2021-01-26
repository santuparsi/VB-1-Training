Imports System.Collections
Module Module1

    Sub Main()

        Try
            Dim obj As New ArrayList
            'Add items
            obj.Add(89)
            obj.Add(68)
            obj.Add(10)
            obj.Add(23)
            obj.Add(67)

            obj.Insert(1, 22)
            Console.WriteLine("Count: " & obj.Count)
            'access value
            Dim i As Integer = obj(2)
            ' Dim j As Integer = obj(100) Exception
            Console.WriteLine(i)
            'Remove value
            obj.Remove(89)
            'Sort
            obj.Sort()
            For Each k In obj
                Console.WriteLine(k)
            Next
            obj.Clear() 'clear all the values
            Console.WriteLine("Count: " & obj.Count)
        Catch ex As ArgumentOutOfRangeException
            Console.WriteLine(ex.Message)
        End Try

    End Sub

End Module
