Public Class GameController

    Private _remainingSeconds As Integer

    Private _form As New FormGame
    Private _timer As Timer = _form.gameTimer
    Private _grid As New Grid()

    Public Sub New(game_duration As Integer)
        Dim cellSize As Size = New Size(FormGame.pnlGrid.Width \ Grid.COLS,
                                        FormGame.pnlGrid.Height \ Grid.ROWS)

        _remainingSeconds = game_duration

        For row = 0 To Grid.ROWS - 1
            For col = 0 To Grid.COLS - 1
                Dim cell As New GridCell(row, col, cellSize)
                AddHandler cell.GotFocus, AddressOf LightUpInTheGroup
                AddHandler cell.LostFocus, AddressOf LightDownInTheGroup

                _grid.PutCell(cell)
                _form.pnlGrid.Controls.Add(cell)
                FormGame.pnlGrid.Controls.Add(cell)
            Next
        Next

        AddHandler _timer.Tick, AddressOf OnGameTimerTick
    End Sub

    Friend Sub LightUpInTheGroup(cell As GridCell, e As EventArgs)
        For Each coord As (Integer, Integer) In _grid.GetGroup(cell.Row(), cell.Col())
            _grid.GetCell(coord.Item1, coord.Item2).LightUp()
        Next
    End Sub

    Friend Sub LightDownInTheGroup(cell As GridCell, e As EventArgs)
        For Each coord As (Integer, Integer) In _grid.GetGroup(cell.Row(), cell.Col())
            _grid.GetCell(coord.Item1, coord.Item2).LightDown()
        Next
    End Sub

    Private Sub OnGameTimerTick(sender As Timer, e As EventArgs)
        _remainingSeconds -= 1
        _form.UpdateTimerText(_remainingSeconds)

        If _remainingSeconds <= 0 Then
            _timer.Stop()
        End If
    End Sub

    Friend Function GetRemainingSeconds() As Integer
        Return _remainingSeconds
    End Function

End Class
