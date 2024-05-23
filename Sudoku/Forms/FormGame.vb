Public Class FormGame

    Private Const GAME_DURATION As Integer = 7 * 60
    Private remainingSeconds As Integer = GAME_DURATION

    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNickname.Text = FormHome.GetNickname()

        LoadGridView()
        UpdateTimerText()
        gameTimer.Start()
    End Sub

    Private Sub LoadGridView()

        ' Pass-in size
        Dim cellSize As Size = New Size(pnlGrid.Width \ Grid.COLS,
                                        pnlGrid.Height \ Grid.ROWS)

        For row = 0 To Grid.ROWS - 1
            For col = 0 To Grid.COLS - 1
                Dim tbCell As GridCell = New GridCell(row, col, cellSize)
                pnlGrid.Controls.Add(tbCell)
            Next
        Next
    End Sub

    Private Sub die()
        gameTimer.Stop()
        gameTimer.Enabled = False
        gameTimer.Dispose()
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub btnGiveup_Click(sender As Object, e As EventArgs) Handles btnGiveup.Click
        Dim r As MsgBoxResult = MsgBox("Do you really want to give up ?", vbOKCancel Or vbQuestion, "Confirmation")

        If r = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        If r = MsgBoxResult.Ok Then
            die()
        End If
    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        remainingSeconds -= 1
        UpdateTimerText()

        If remainingSeconds <= 0 Then
            gameTimer.Stop()
        End If
    End Sub

    Private Sub UpdateTimerText()
        Dim minutes As Integer = remainingSeconds \ 60
        Dim seconds As Integer = remainingSeconds Mod 60

        lblRemainingTime.Text = minutes & ":" & seconds
    End Sub
End Class