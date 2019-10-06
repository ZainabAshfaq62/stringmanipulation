Module Module1

    Sub Main()
        Dim str1, str2, str3, firstword, secondword As String
        Dim sp As Integer

        str1 = ""
        str2 = ""
        str3 = ""
        sp = 0
        firstword = ""
        secondword = ""


        Console.Write("enter name1: ")
        str1 = Console.ReadLine

        Console.Write("enter name2: ")
        str2 = Console.ReadLine

        sp = InStr(str1, " ")
        firstword = Left(str1, sp - 1)

        sp = InStr(str2, " ")
        secondword = Right(str2, Len(str2) - sp)

        str3 = firstword & " " & secondword
        Console.WriteLine(str3)

        Console.ReadKey()




    End Sub

End Module
