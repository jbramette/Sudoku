Imports System.Configuration

Public Class FormGame

    Private _controller As GameController

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNickname.Text = FormHome.GetNickname()

        _controller = New GameController(view:=Me,
                                         nickname:=lblNickname.Text,
                                         gameDurationSeconds:=FormHome.GetSelectedSeconds())

        _controller.StartGame(FormHome.GetSelectedDifficulty())
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

    Public Function GetCell(col As Integer, row As Integer) As GridCell
        Return pnlGrid.Controls(row * Grid.COLS + col)
    End Function

    Public Sub UpdateTimerText(remainingSeconds As Integer)
        If remainingSeconds < 30 Then
            lblRemainingTime.ForeColor = Color.Red
        End If

        Dim minutes As Integer = remainingSeconds \ 60
        Dim seconds As Integer = remainingSeconds Mod 60

        lblRemainingTime.Text = String.Format("{0:00}:{1:00}", minutes, seconds)
    End Sub

    Public Sub NotifyWin()
        MsgBox("Win")
    End Sub

    Public Sub NotifyGameOver()
        pnlGrid.Enabled = False
        MsgBox("You lost")
    End Sub

    Private Sub OnFormClose(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _controller.IsGameFinished() OrElse ConfirmQuit() Then
            FormHome.Show()
        Else
            e.Cancel = True ' Prevent the window from closing
        End If
    End Sub

    Private Sub OnButtonGiveUpClick(sender As Object, e As EventArgs) Handles btnGiveup.Click
        Me.Close()
    End Sub

    Private Function ConfirmQuit()
        Dim r As MsgBoxResult = MsgBox("Do you really want to give up ? Will not count as a lose", vbOKCancel Or vbQuestion, "Confirmation")
        Return r = MsgBoxResult.Ok
    End Function

    ' Event handling for the GridCells is done in FormGame so that 
    ' the GridCell don't need to carry a reference to the game controller.
    ' We could also make GameController a shared class, we feel like all three
    ' solutions are okay.
    Private Sub OnCellInput(cell As GridCell, e As EventArgs)
        Dim value As Integer
        If Integer.TryParse(cell.Text, value) Then
            _controller.UpdateCell(cell, value)
        Else
            cell.Text = ""
        End If
    End Sub

    Private Sub OnFocusChange(cell As GridCell, e As EventArgs)
        SwitchLightInTheGroup(cell.Col, cell.Row, cell.Focused)
    End Sub

    ' Lights up or down the cells that are in the same square,
    ' column or row of the focused cell
    Private Sub SwitchLightInTheGroup(col As Integer, row As Integer, lightUp As Boolean)
        For Each coord As (Integer, Integer) In Grid.GetGroup(row, col)
            Dim cell As GridCell = GetCell(coord.Item2, coord.Item1)
            If lightUp Then cell.LightUp() Else cell.LightDown()
        Next
    End Sub
End Class