Module Module2
    Sub main()
        Dim s As String = "23"
        Dim d As Double
        d = 12.345
        Dim i As Integer
        i = CInt(d)
        Console.WriteLine(i)
        i = s
        Console.WriteLine(i)
        Dim jdate As Date
        jdate = CDate(Console.ReadLine())
        ' jdate = Date.Parse("1222019")
        Console.WriteLine(jdate)
        Console.ReadKey()
    End Sub
End Module
