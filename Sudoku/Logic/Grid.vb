Public Class Grid

    ' rendre dynamique ?
    Public Const COLS As Integer = 9
    Public Const ROWS As Integer = 9

    ' Tableau interne
    Private _grid(COLS - 1, ROWS - 1) As Integer

    Public Sub Generate()
        _grid(0, 0) = 1
        _grid(1, 1) = 2
        _grid(2, 2) = 3
        _grid(3, 3) = 4
        _grid(4, 4) = 5
    End Sub

    Public Shared Function GroupIndexFor(col As Integer, row As Integer)
        Return col \ 3 + (row \ 3) * 3
    End Function

    Public Shared Function IsInGroupOrIntersects(c1 As Integer, r1 As Integer, c2 As Integer, r2 As Integer)
        Return GroupIndexFor(c1, r1) = GroupIndexFor(c2, r2) Or c1 = c2 Or r1 = r2
    End Function


    Public Function SetCell(col As Integer, row As Integer, num As Integer)
        If num <= 0 Or num >= 10 Or col < 0 Or col >= COLS Or row < 0 Or row >= ROWS Then
            Return False
        End If

        _grid(row, col) = num
        Return True

    End Function

    Public Function GetCell(col As Integer, row As Integer)
        Return _grid(row, col)
    End Function

End Class
