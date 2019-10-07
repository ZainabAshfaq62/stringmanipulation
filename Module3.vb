Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim count As Integer
        Dim char1, char2, nextchar As Char

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        nextchar = ""
        count = 0

        Console.Write("enter string ")
        str1 = Console.ReadLine

        Console.Write("enter character to replace: ")
        char1 = Console.ReadLine

        Console.Write("enter character to replace with: ")
        char2 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If nextchar = char1 Then
                str2 = str2 & char2
            Else
                str2 = str2 & nextchar
            End If

        Next
        Console.WriteLine("final string is: " & str2)
        Console.ReadKey()

    End Sub

End Module
