Public Class FormGame

    Private _controller As GameController

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        _controller = New GameController(Me)
        _controller.StartGame()

        lblNickname.Text = FormHome.GetNickname()
    End Sub

    Public Sub AddCell(col As Integer, row As Integer, value As Integer)
        Dim cellSize As Size = New Size(pnlGrid.Width \ Grid.COLS,
                                        pnlGrid.Height \ Grid.ROWS)

        Dim cell As GridCell = New GridCell(col, row, value, cellSize)

        ' Assign the handlers
        AddHandler cell.GotFocus, AddressOf OnFocusChange
        AddHandler cell.LostFocus, AddressOf OnFocusChange

        ' TextChanged rather than KeyPress to enable text pasting filtering, so that only numerics can be pasted
        AddHandler cell.TextChanged, AddressOf OnCellInput

        pnlGrid.Controls.Add(cell)
    End Sub

    Public Sub UpdateTimerText(minutes As Integer, seconds As Integer)
        If minutes = 0 And seconds < 30 Then
            lblRemainingTime.ForeColor = Color.Red
        End If

        lblRemainingTime.Text = minutes & ":" & seconds
    End Sub

    Public Sub NotifyInputError()
        MsgBox("Invalid input")
    End Sub

    Private Sub Die()
        FormHome.Close()
    End Sub

    Private Sub OnFormClosed(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ConfirmQuit() = True Then
            die()
        Else
            e.Cancel = True ' Prevent the window from closing
        End If
    End Sub

    Private Sub OnButtonGiveUpClick(sender As Object, e As EventArgs) Handles btnGiveup.Click
        If ConfirmQuit() Then
            die()
        End If
    End Sub

    Public Shared Function isInputCorrect(input As Integer, col As Integer, row As Integer) As Boolean
        Dim currcell As Integer

        ' check columns
        For rows = 0 To Grid.ROWS - 1
            currcell = grid.getValue(col, rows)
            If currcell = input Then
                Return False
            End If
        Next

        'check lines
        For cols = 0 To Grid.COLS - 1
            currcell = grid.getValue(cols, row)
            If currcell = input Then
                Return False
            End If
        Next

        'check squares 3x3
        Dim squareFirstRow As Integer = (row \ 3) * 3
        Dim squareFirstCol As Integer = (col \ 3) * 3

        For r As Integer = squareFirstRow To squareFirstRow + 2
            For c As Integer = squareFirstCol To squareFirstCol + 2
                If grid.getValue(c, r) = input AndAlso (r <> row OrElse c <> col) Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    ' Event handling for the GridCells is done in FormGame so that 
    ' the GridCell don't need to carry a reference to the game controller.
    ' We could also make GameController a shared class, we feel like all three
    ' solutions are okay.
    Private Sub OnCellInput(cell As GridCell, e As EventArgs)
        If Not IsNumeric(cell.Text) Then
            cell.Text = ""
        Else
            cell.SetValue(Convert.ToInt32(cell.Text))
            _controller.UpdateCell(cell)
        End If
    End Sub

    Private Sub OnFocusChange(cell As GridCell, e As EventArgs)
        SwitchLightInTheGroup(cell.Col, cell.Row, cell.Focused)
    End Sub

    ' Lights up or down the cells that are in the same square,
    ' column or row of the focused cell
    Private Sub SwitchLightInTheGroup(col As Integer, row As Integer, lightUp As Boolean)
        Dim squareIndex As Integer = Grid.SquareIndexFor(col, row)

        Dim startRow As Integer = (squareIndex \ 3) * 3
        Dim startCol As Integer = (squareIndex Mod 3) * 3

        ' Square
        For r = startRow To startRow + 3 - 1
            For c = startCol To startCol + 3 - 1
                Dim cell As GridCell = pnlGrid.Controls(c + r * Grid.COLS)
                If lightUp Then cell.LightUp() Else cell.LightDown()
            Next
        Next

        ' Columns
        For i = 0 To Grid.COLS - 1
            Dim cell As GridCell = pnlGrid.Controls(i + row * Grid.COLS)
            If lightUp Then cell.LightUp() Else cell.LightDown()
        Next

        ' Rows
        For i = 0 To Grid.ROWS - 1
            Dim cell As GridCell = pnlGrid.Controls(col + i * Grid.COLS)
            If lightUp Then cell.LightUp() Else cell.LightDown()
        Next
    End Sub

End Class