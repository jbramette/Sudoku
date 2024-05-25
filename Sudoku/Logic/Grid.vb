Public Class Grid

    Public Const COLS As Integer = 9
    Public Const ROWS As Integer = 9

    Private _grid(COLS - 1, ROWS - 1) As GridCell

    Friend Function GetCell(row As Integer, col As Integer) As GridCell
        Return _grid(row, col)
    End Function

    Friend Sub PutCell(cell As GridCell)
        _grid(cell.Row(), cell.Col()) = cell
    End Sub

    ' Returns coordinates of all the cells that are in the same row as the cell, whose the coord we pass
    Friend Function GetTheRow(row As Integer, col As Integer) As List(Of (Integer, Integer))
        Dim theRow As New List(Of (Integer, Integer))

        ' Going to the right
        For r = row + 1 To Grid.COLS - 1
            Dim cell = GetCell(r, col)
            theRow.Add((cell.Row(), cell.Col()))
        Next

        ' Going to the left
        For r = 0 To row - 1
            Dim cell = GetCell(r, col)
            theRow.Add((cell.Row(), cell.Col()))
        Next

        Return theRow
    End Function

    ' Returns coordinates of all the cells that are in the same column as the cell, whose the coord we pass
    Friend Function GetTheCol(row As Integer, col As Integer) As List(Of (Integer, Integer))
        Dim theCol As New List(Of (Integer, Integer))

        ' Going up
        For c = 0 To col - 1
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
    Private Function GetSquareIndex(row As Integer, col As Integer) As Integer
        Return (row \ 3) * 3 + (col \ 3)
    End Function

    ' Using index of the square in which the cell, whose the coord we pass, is located, gets coords of the cell in the square
    Friend Function GetTheSquare(row As Integer, col As Integer) As List(Of (Integer, Integer))
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

    ' Returns the coordinates of all the cells that are in the same group as the cell, whose coord we pass
    ' Group means the combination of: row, column and square
    Friend Function GetGroup(row As Integer, col As Integer) As List(Of (Integer, Integer))
        Dim theSquare As New List(Of (Integer, Integer))

        theSquare.AddRange(GetTheRow(row, col))
        theSquare.AddRange(GetTheCol(row, col))
        theSquare.AddRange(GetTheSquare(row, col))

        Return theSquare
    End Function

End Class
