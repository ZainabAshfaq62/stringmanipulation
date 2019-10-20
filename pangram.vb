Module Module1

    Sub Main()
        Dim STR1, STR2 As String
        Dim count As Integer
        Dim nextchar As Char
        Dim pangram As Boolean

        pangram = False
        STR1 = ""
        STR2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        count = 0
        nextchar = ""


        Console.Write("ENTER STRING 1:")
        STR1 = Console.ReadLine

        For count = 1 To Len(STR1)
            nextchar = Mid(STR1, count, 1)
            STR2 = InStr(STR2, nextchar)
            If STR2 >= "1" Then
                pangram = True

            End If
        Next
        If pangram = True Then
            Console.WriteLine("it is pangram")
        Else
            Console.WriteLine("it is not pangram")

        End If
        Console.ReadKey()

    End Sub

End Module
