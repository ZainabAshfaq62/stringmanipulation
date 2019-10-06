Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim myChar, nextChar As Char
        Dim counter As Integer

        str1 = ""
        str2 = ""
        myChar = ""
        nextChar = ""
        counter = 0

        Console.Write("Enter string: ")
        str1 = Console.ReadLine

        Console.Write("Enter character to remove: ")
        myChar = Console.ReadLine


        For counter = 1 To Len(str1)
            nextChar = Mid(str1, counter, 1)
            If nextChar <> myChar Then
                str2 = str2 & nextChar


            End If


        Next
        Console.WriteLine("final string is: " & str2)
        Console.ReadKey()


    End Sub

End Module
