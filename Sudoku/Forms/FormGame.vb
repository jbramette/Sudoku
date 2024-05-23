Public Class FormGame

    Private Const GAME_DURATION_SECONDS As Integer = 7 * 60
    Private remainingSeconds As Integer = GAME_DURATION_SECONDS

    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNickname.Text = FormHome.GetNickname()

        Grid.Load()
        UpdateTimerText()
        gameTimer.Start()
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

    Private Sub OnFormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Die()
    End Sub
End Class