Module Module1

    Sub Main()
        Try
            Dim i, j As Byte
            Console.WriteLine("Enter i value")
            i = Console.ReadLine
            Console.WriteLine("Enter j value")
            j = Console.ReadLine
            Dim k As Byte = i / j
            Console.WriteLine("Divison of {0}/{1} is {2}", i, j, k)
        Catch ex As OverflowException
            Console.WriteLine("J value should not be 0")
        Catch ex As Exception
            Console.WriteLine("Error Occured")
            Console.WriteLine(ex.Message)
        End Try
    End Sub

End Module
