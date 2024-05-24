Public Class Grid

    ' rendre dynamique ?
    Public Const COLS As Integer = 9
    Public Const ROWS As Integer = 9

    Private _grid(COLS * ROWS) As Integer

    Public Sub Generate()
        _grid(0) = 1
        _grid(10) = 2
        _grid(20) = 3
        _grid(30) = 4
        _grid(40) = 5
    End Sub

    Public Function SetCell(col As Integer, row As Integer, num As Integer)
        ' Pour l'exemple
        Return num <> 0
    End Function

    Public Function GetCell(col As Integer, row As Integer)
        Return _grid(col + row * COLS)
    End Function

End Class
