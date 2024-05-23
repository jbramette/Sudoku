Public Class Grid

    Public Const COLS As Integer = 9
    Public Const ROWS As Integer = 9

    Private _grid(COLS * ROWS) As Integer

    Public Sub New()
        For i As Integer = 0 To _grid.Length - 1
            _grid(i) = 0
        Next
    End Sub

    Public Function getValue(row As Integer, col As Integer) As Integer
        Dim index As Integer
        index = row * COLS + col
        Return _grid(index)
    End Function

    Public Sub setValue(col As Integer, row As Integer, value As Integer)
        Dim index As Integer
        index = row * COLS + col
        _grid(index) = value
    End Sub


End Class
