Imports System.IO

Module Module7
    Sub main()
        Dim directries() As String = Directory.GetDirectories("D:\OnlineBatch\Dotnet-Batch-1")

        For i As Integer = 0 To directries.Length - 1
            Dim files() As String = Directory.GetFiles(directries(i))
            For j As Integer = 0 To files.Length - 1
                Console.WriteLine(files(j))
            Next
        Next


    End Sub
End Module
