Module ArrayExamples

    Sub Main()

        'SimpleArray()
        'IterateSimpleArray()
        'LessSimple()
        Multidimensional()
        Console.ReadLine()
    End Sub


    Sub SimpleArray()
        Dim Names(5) As String


        Names(0) = "Bilbo"
        Names(3) = "Baggins"

        Console.WriteLine("Hello " & Names(0))


        Console.ReadLine()




    End Sub

    Sub IterateSimpleArray()
        Dim Names(5) As String
        Names(0) = "Bilbo"
        Names(3) = "Baggins"




        ' For i = 0 To 5

        'Console.WriteLine("Hello " & Names(i))
        'Next





        For i = LBound(Names) To UBound(Names)

            Console.WriteLine("Hello " & Names(i))
        Next

        Console.ReadLine()




    End Sub

    Sub LessSimple()

        Dim animals() = New String() {"dog", "cat", "bird", "liger"}

        For i = LBound(animals) To UBound(animals)

            Console.WriteLine("Hello " & animals(i))

        Next

    End Sub


    Sub Multidimensional()
        Dim DataArray(3, 5) As Integer

        DataArray(0, 0) = 5I
        DataArray(1, 0) = 6I
        DataArray(2, 0) = 7I
        DataArray(3, 0) = 8I
        DataArray(2, 3) = 22I



        'nested loop
        For column = 0 To 5
            For row = 0 To 3
                Console.Write(DataArray(row, column) & " ")
            Next
            Console.WriteLine()
        Next

        For Each thingy In DataArray
            Console.Write(thingy)
        Next



    End Sub

End Module
