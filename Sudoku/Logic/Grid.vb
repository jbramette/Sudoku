Public Class Grid

    Public Const COLS As Integer = 9
    Public Const ROWS As Integer = 9

    Private _grid(COLS * ROWS) As Integer

    Public Sub New()

    End Sub
    Friend Shared Sub Load()
        Dim cellSize As Size = New Size(FormGame.pnlGrid.Width \ Grid.COLS,
                                        FormGame.pnlGrid.Height \ Grid.ROWS)

        For row = 0 To Grid.ROWS - 1
            For col = 0 To Grid.COLS - 1
                Dim cell As GridCell = New GridCell(row, col, cellSize)
                FormGame.pnlGrid.Controls.Add(cell)
            Next
        Next
    End Sub

End Class
