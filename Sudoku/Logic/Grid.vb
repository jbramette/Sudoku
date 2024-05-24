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

    Friend Shared Function GetCell(row As Integer, col As Integer) As GridCell
        Return _grid(row, col)
    End Function

    ' Returns coordinates of all the cells that are in the same row as the cell, whose the coord we pass
    Friend Shared Function GetTheRow(row As Integer, col As Integer) As List(Of (Integer, Integer))
        Dim theRow As New List(Of (Integer, Integer))

        ' Going to the right
        For r = row + 1 To Grid.COLS - 1
            Dim cell = GetCell(r, col)
            theRow.Add((cell.Row(), cell.Col()))
        Next

        'Going to the left
        For r = row - 1 To 0
            Dim cell = GetCell(r, col)
            theRow.Add((cell.Row(), cell.Col()))
        Next

        Return theRow
    End Function

    ' Returns coordinates of all the cells that are in the same column as the cell, whose the coord we pass
    Friend Shared Function GetTheCol(row As Integer, col As Integer) As List(Of (Integer, Integer))
        Dim theCol As New List(Of (Integer, Integer))

        ' Going up
        For c = col - 1 To 0
            Dim cell = GetCell(row, c)
            theCol.Add((cell.Row(), cell.Col()))
        Next

        ' Going down
        For c = col + 1 To ROWS - 1
            Dim cell = GetCell(row, c)
            theCol.Add((cell.Row(), cell.Col()))
        Next

        Return theCol
    End Function

    ' The grid is composed of 9 squares, function gets the index of the square where the cell, whose the coords we pass in parameters, is
    Private Shared Function GetSquareIndex(row As Integer, col As Integer) As Integer
        Return (row \ 3) * 3 + (col \ 3)
    End Function

    ' Using index of the square in which the cell, whose the coord we pass, is located, gets coords of the cell in the square
    Friend Shared Function GetTheSquare(row As Integer, col As Integer) As List(Of (Integer, Integer))
        Dim theSquare As New List(Of (Integer, Integer))
        Dim squareIndex As Integer = GetSquareIndex(row, col)

        Dim startRow As Integer = (squareIndex \ 3) * 3
        Dim startCol As Integer = (squareIndex Mod 3) * 3

        For r = startRow To startRow + 3 - 1
            For c = startCol To startCol + 3 - 1
                theSquare.Add((r, c))
            Next
        Next

        Return theSquare
    End Function

End Class
