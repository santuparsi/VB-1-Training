Module Module3
    Sub main()
        Try
            Dim i, j As Byte
            Console.WriteLine("Enter i value")
            i = Console.ReadLine
            Console.WriteLine("Enter j value")
            j = Console.ReadLine
            If j = 0 Then
                Throw New OverflowException
            End If
            Dim k As Byte = i / j
            Console.WriteLine("Divison of {0}/{1} is {2}", i, j, k)
        Catch ex As OverflowException
            Console.WriteLine("J value should not be 0")
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.Source) 'returns project name
            Console.WriteLine(ex.TargetSite) 'return only function name
            Console.WriteLine(ex.StackTrace) 'return full info about exception
        Catch ex As Exception
            Console.WriteLine("Error Occured")
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Module
