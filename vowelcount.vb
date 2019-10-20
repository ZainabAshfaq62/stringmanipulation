Module Module1

    Sub Main()
        Dim str1 As String
        Dim count, vcount As Integer
        Dim nextchar As Char

        str1 = ""
        count = 0
        nextchar = ""
        vcount = 0

        Console.WriteLine("ENTER YOUR STRING: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If UCase(nextchar) = "A" Or UCase(nextchar) = "E" Or UCase(nextchar) = "I" Or UCase(nextchar) = "O" Or UCase(nextchar) = "U" Then
                vcount = vcount + 1

            End If
        Next
        Console.Write("the number of vowels are: " & vcount)
        Console.ReadKey()

    End Sub

End Module
