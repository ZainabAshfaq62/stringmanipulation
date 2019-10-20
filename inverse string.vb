Module Module1

    Sub Main()
        Dim str1, finalstr As String
        Dim count As Integer
        Dim nextchar As Char

        str1 = ""
        finalstr = ""
        count = 0
        nextchar = ""

        Console.Write("enter your string: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            finalstr = nextchar & finalstr


        Next
        Console.WriteLine("the inverse string is: " & finalstr)
        Console.ReadKey()

    End Sub

End Module
