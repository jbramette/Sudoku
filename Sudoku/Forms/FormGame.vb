Public Class FormGame

    Private Const GAME_DURATION_SECONDS As Integer = 7 * 60

    Private _remainingSeconds As Integer = GAME_DURATION_SECONDS
    Private _controller As GameController

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        _controller = New GameController(Me)
        _controller.LoadGrid()

        lblNickname.Text = FormHome.GetNickname()
        UpdateTimerText()
        gameTimer.Start()
    End Sub

    Public Sub AddCell(col As Integer, row As Integer, num As Integer)
        Dim cellSize As Size = New Size(pnlGrid.Width \ Grid.COLS,
                                        pnlGrid.Height \ Grid.ROWS)

        Dim cell As GridCell = New GridCell(_controller, col, row, num, cellSize)
        pnlGrid.Controls.Add(cell)
    End Sub

    Public Sub LightUpInTheGroup(col As Integer, row As Integer)
        For Each c As GridCell In pnlGrid.Controls
            If Grid.IsInGroupOrIntersects(c.Col, c.Row, col, row) Then
                c.LightUp()
            End If
        Next
    End Sub

    Public Sub LightDownInTheGroup(col As Integer, row As Integer)
        For Each c As GridCell In pnlGrid.Controls
            If Grid.IsInGroupOrIntersects(c.Col, c.Row, col, row) Then
                c.LightDown()
            End If
        Next
    End Sub

    Public Sub NotifyInputError()
        MsgBox("Entrée Invalide")
    End Sub

    Private Sub Die()
        gameTimer.Stop()
        gameTimer.Enabled = False
        gameTimer.Dispose()
        FormHome.Close()
    End Sub

    Private Sub OnButtonGiveupClick(sender As Object, e As EventArgs) Handles btnGiveup.Click
        Dim r As MsgBoxResult = MsgBox("Do you really want to give up ?", vbOKCancel Or vbQuestion, "Confirmation")

        If r = MsgBoxResult.Ok Then
            Die()
        End If
    End Sub

    Private Sub OnGameTimerTick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        _remainingSeconds -= 1
        UpdateTimerText()

        If _remainingSeconds <= 0 Then
            gameTimer.Stop()
        End If
    End Sub

    Private Sub UpdateTimerText()
        Dim minutes As Integer = _remainingSeconds \ 60
        Dim seconds As Integer = _remainingSeconds Mod 60

        lblRemainingTime.Text = minutes & ":" & seconds
    End Sub

    Private Sub OnFormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Die()
    End Sub
End Class