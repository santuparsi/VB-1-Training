Module Module1

    Sub Main()
        'Dim name As String
        'Console.WriteLine("enter your name.")
        'name = Console.ReadLine() 'reads value from input
        'Console.WriteLine("Hello " + name)
        'Dim i As Integer = 10
        'Console.WriteLine("My Age " & i)
        'Console.WriteLine("My Age is " + i.ToString())
        'Console.ReadKey()
        Dim a, b, c As Integer
        Console.WriteLine("Enter a,b values")
        a = CInt(Console.ReadLine())
        b = Integer.Parse(Console.ReadLine())
        c = a + b
        Console.WriteLine("Addition: " + c.ToString())
        Console.ReadKey()
    End Sub

End Module
