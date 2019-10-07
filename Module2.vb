Module Module1

    Sub Main()
        Dim str1 As String
        Dim count, alphabet, number As Integer
        Dim nextchar As Char

        str1 = ""
        count = 0
        alphabet = 0
        number = 0
        nextchar = ""

        Console.Write("enter string: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If nextchar >= "0" And nextchar <= "9" Then
                number = number + 1
            Else
                alphabet = alphabet + 1
            End If



        Next
        Console.WriteLine("digits in the string are: " & number)
        Console.WriteLine("alphabets in the strings are: " & alphabet)
        Console.ReadKey()

    End Sub

End Module
