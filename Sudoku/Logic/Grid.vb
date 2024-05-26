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
    ' Squares on the grid:
    ' 0 1 2
    ' 3 4 5
    ' 6 7 8
    Public Shared Function SquareIndexFor(col As Integer, row As Integer)
        Return col \ 3 + (row \ 3) * 3
    End Function

    ' Sets the number at given coordinates, return value indicates if the operation was successful or not
    Public Function SetValue(col As Integer, row As Integer, value As Integer) As Boolean
        ' Assert the value and coordinates are correct
        If value <= 0 Or value >= 10 Or col < 0 Or col >= COLS Or row < 0 Or row >= ROWS Then
            Return False
        End If

        _grid(row, col) = value
        Return True
    End Function

    Public Function GetValue(col As Integer, row As Integer) As Integer
        Return _grid(row, col)
    End Function

End Class
