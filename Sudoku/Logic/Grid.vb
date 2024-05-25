Public Class Grid

    Public Const COLS As Integer = 9
    Public Const ROWS As Integer = 9

    ' Internal grid
    Private _grid(COLS - 1, ROWS - 1) As Integer

    ' Algorithm to generate a random Sudoku grid
    Public Sub Generate()
        ' Dummy values ATM
        _grid(0, 0) = 1
        _grid(1, 1) = 2
        _grid(2, 2) = 3
        _grid(3, 3) = 4
        _grid(4, 4) = 5
    End Sub

    ' Index of the square (ie: group) in which the coordinates are part of
    '
    ' top left is 0, top right is 2
    ' bottom right is 8....
    Public Shared Function SquareIndexFor(col As Integer, row As Integer)
        Return col \ 3 + (row \ 3) * 3
    End Function


    ' Checks whether two coordinates are in the same square, row, or column
    Public Shared Function IsInSameSquareRowOrColumn(c1 As Integer, r1 As Integer, c2 As Integer, r2 As Integer)
        Return SquareIndexFor(c1, r1) = SquareIndexFor(c2, r2) Or c1 = c2 Or r1 = r2
    End Function


    ' Sets the number at given coordinates
    Public Function SetCell(col As Integer, row As Integer, num As Integer)
        ' Assert the value and coordinates are correct
        If num <= 0 Or num >= 10 Or col < 0 Or col >= COLS Or row < 0 Or row >= ROWS Then
            Return False
        End If

        _grid(row, col) = num
        Return True

    End Function

    ' Gets the number at given coordinates
    Public Function GetCell(col As Integer, row As Integer)
        Return _grid(row, col)
    End Function

End Class
