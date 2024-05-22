Public Class FormGame

    Private Const TOTAL_TIME_SECONDS As Integer = 7 * 60
    Private remainingSeconds As Integer = TOTAL_TIME_SECONDS

    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNickname.Text = FormHome.GetNickname()

        UpdateTimerText()
        gameTimer.Start()
    End Sub

    Private Sub btnGiveup_Click(sender As Object, e As EventArgs) Handles btnGiveup.Click
        Dim r As MsgBoxResult = MsgBox("Do you really want to give up ?", vbOKCancel Or vbQuestion, "Confirmation")

        If r = MsgBoxResult.Cancel Then
            Exit Sub
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