Module Module1

    Sub Main()
        Dim arr() As Integer = {1, 3, 5, 7, 10, 13, 15, 18, 22}
        Console.WriteLine(binarySearch(arr, 15, 0, arr.Length - 1))
        Console.ReadLine()
    End Sub


    Function serialSearch(ByVal arr() As Integer, ByVal input As Integer)
        Dim found As Boolean = False
        Dim index As Integer
        Do While found = False And index <= arr.Length - 1
            If arr(index) = input Then
                found = True
            End If
            index += 1
        Loop
        If found = True Then
            Return index
        Else
            Return -1
        End If
    End Function
    Function binarySearch(ByRef arr() As Integer, ByVal input As Integer, ByVal min As Integer, ByVal max As Integer)
        If input <= arr(max) And input >= arr(min) Then
            Dim mid As Integer = (max + min) / 2
            If input = arr(mid) Then
                Return mid
            ElseIf input < arr(mid) Then
                Return binarySearch(arr, input, min, mid)
            ElseIf input > arr(mid) Then
                Return binarySearch(arr, input, mid, max)
            End If
        Else
            Return -1
        End If
    End Function
End Module
