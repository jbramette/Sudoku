Public Class FormGame

    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _controller As New GameController(7 * 60)

        lblNickname.Text = FormHome.GetNickname()
        UpdateTimerText(_controller.GetRemainingSeconds())
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

    Friend Sub UpdateTimerText(seconds As Integer)
        Dim minutes As Integer = seconds \ 60
        Dim remaining_seconds As Integer = seconds Mod 60

        lblRemainingTime.Text = minutes & ":" & remaining_seconds
    End Sub

    Private Sub OnFormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Die()
    End Sub

End Class