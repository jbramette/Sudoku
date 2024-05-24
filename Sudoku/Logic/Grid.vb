Public Class Grid

    Public Const COLS As Integer = 9
    Public Const ROWS As Integer = 9

    Private Shared _grid(COLS - 1, ROWS - 1) As GridCell

    Friend Shared Sub Load()
        Dim cellSize As Size = New Size(FormGame.pnlGrid.Width \ Grid.COLS,
                                        FormGame.pnlGrid.Height \ Grid.ROWS)

        For row = 0 To Grid.ROWS - 1
            For col = 0 To Grid.COLS - 1
                Dim cell As New GridCell(row, col, cellSize)
                _grid(col, row) = cell
                FormGame.pnlGrid.Controls.Add(cell)
            Next
        Next
    End Sub

End Class
