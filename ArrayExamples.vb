Module ArrayExamples

    Sub Main()

        SimpleArray()

    End Sub


    Sub SimpleArray()
        Dim Names(5) As String


        Names(0) = "Bilbo"
        Names(3) = "Baggins"

        Console.WriteLine("Hello " & Names(0))


        Console.ReadLine()




    End Sub

End Module
