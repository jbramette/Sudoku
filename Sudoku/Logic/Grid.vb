Public Class Grid

    Public Const COLS As Integer = 9
    Public Const ROWS As Integer = 9

    ' Internal grid
    Private _grid(COLS - 1, ROWS - 1) As Integer

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
        If Not IsInputCorrect(col, row, value) Then Return False

        _grid(row, col) = value
        Return True
    End Function

    Public Function GetValue(col As Integer, row As Integer) As Integer
        Return _grid(row, col)
    End Function

    Public Function IsCompleted() As Boolean
        For row = 0 To ROWS - 1
            For col = 0 To COLS - 1
                If _grid(row, col) = 0 Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    ' Returns coordinates of all the cells that are in the same row as the cell, whose the coord we pass
    Friend Shared Function GetTheRow(row As Integer, col As Integer) As List(Of (Integer, Integer))
        Dim theRow As New List(Of (Integer, Integer))

        ' Going to the right
        For r = row + 1 To Grid.COLS - 1
            theRow.Add((r, col))
        Next

        ' Going to the left
        For r = 0 To row - 1
            theRow.Add((r, col))
        Next

        Return theRow
    End Function

    ' Returns coordinates of all the cells that are in the same column as the cell, whose the coord we pass
    Friend Shared Function GetTheCol(row As Integer, col As Integer) As List(Of (Integer, Integer))
        Dim theCol As New List(Of (Integer, Integer))

        ' Going up
        For c = 0 To col - 1
            theCol.Add((row, c))
        Next

        ' Going down
        For c = col + 1 To ROWS - 1
            theCol.Add((row, c))
        Next

        Return theCol
    End Function

    ' Using index of the square in which the cell, whose the coord we pass, is located, gets coords of the cell in the square
    Friend Shared Function GetTheSquare(row As Integer, col As Integer) As List(Of (Integer, Integer))
        Dim theSquare As New List(Of (Integer, Integer))
        Dim squareIndex As Integer = SquareIndexFor(col, row)

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
    Friend Shared Function GetGroup(row As Integer, col As Integer) As List(Of (Integer, Integer))
        Dim theSquare As New List(Of (Integer, Integer))

        theSquare.AddRange(GetTheRow(row, col))
        theSquare.AddRange(GetTheCol(row, col))
        theSquare.AddRange(GetTheSquare(row, col))

        Return theSquare
    End Function

    Private Function IsInputCorrect(col As Integer, row As Integer, value As Integer) As Boolean
        ' Assert the value and coordinates are correct
        If value <= 0 Or value > COLS Or col < 0 Or col >= COLS Or row < 0 Or row >= ROWS Then
            Return False
        End If

        For Each coord As (Integer, Integer) In Grid.GetGroup(row, col)
            Dim r As Integer = coord.Item1
            Dim c As Integer = coord.Item2

            If r = row AndAlso c = col Then
                Continue For
            End If

            If GetValue(c, r) = value Then
                Return False
            End If
        Next

        Return True
    End Function

    Friend Function GetAvaivableValues(col As Integer, row As Integer) As List(Of Integer)
        Dim coordinates As List(Of (Integer, Integer)) = GetGroup(row, col)
        Dim existingValues As List(Of Integer) = coordinates.Select(Function(coord) _grid(coord.Item1, coord.Item2)).ToList()

        Dim possibleValues As New List(Of Integer)

        For possibleValue = 1 To ROWS
            If Not existingValues.Contains(possibleValue) Then
                possibleValues.Add(possibleValue)
            End If
        Next

        Return possibleValues
    End Function

    Friend Sub PutValueUnchecked(col As Integer, row As Integer, value As Integer)
        _grid(row, col) = value
    End Sub

End Class
