Module Module1

    Sub Main()
        Dim str1, finalstring, nextchar2, stringposition As String
        Dim count1, count2, total As Integer
        Dim nextchar1 As Char
        Dim validbinarystring As Boolean

        str1 = ""
        finalstring = ""
        total = 0
        count1 = 0
        count2 = 0
        nextchar1 = ""
        nextchar2 = ""
        validbinarystring = True
        stringposition = ""


        Console.WriteLine("enter your binary number: ")
        str1 = Console.ReadLine

        If Len(str1) < 1 Or Len(str1) > 8 Then
            validbinarystring = False
        Else
            For count1 = 1 To Len(str1)
                nextchar1 = Mid(str1, count1, 1)
                If nextchar1 <> "0" And nextchar1 <> "1" Then
                    validbinarystring = False
                End If
            Next
        End If
        If validbinarystring = True Then
            stringposition = 1
            For count2 = 1 To Len(str1)
                nextchar2 = Mid(str1, count2, 1)
                total = total + (nextchar2 * stringposition)
                stringposition = stringposition * 2
            Next

        End If
        If validbinarystring = True Then
            Console.WriteLine("valid binary string and denary value is: " & total)
        Else : Console.WriteLine("invalid binary string")
        End If
        Console.ReadKey()

    End Sub



End Module
