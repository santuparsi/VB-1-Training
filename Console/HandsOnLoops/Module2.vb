Module Module2
    Sub main()
        ' Dim no As Integer
        ' no = Console.ReadLine
        Dim flag As Integer = 1
        Do
            If flag Mod 2 = 0 Then
                Console.WriteLine(flag)
            End If
            flag += 1
            'If flag = 50 Then
            '    Exit Do

            'End If
        Loop While flag <= 50

    End Sub
End Module
