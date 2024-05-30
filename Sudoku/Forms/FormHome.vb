Public Class FormHome

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxName.Items.AddRange(StatsManager.ListNicknames())
    End Sub

    Public Function GetNickname()
        Return cbxName.Text
    End Function

    Private Sub OnButtonQuitClick(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim r As MsgBoxResult = MsgBox("Do you really want to leave ?", vbOKCancel Or vbQuestion, "Confirmation")

        If r = MsgBoxResult.Ok Then
            Me.Close()
        End If

    End Sub

    Private Sub OnKeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxName.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TryPlay()
        End If
    End Sub

    Private Sub OnButtonPlayClick(sender As Object, e As EventArgs) Handles btnPlayGame.Click
        TryPlay()
    End Sub

    Private Sub TryPlay()
        Dim nickname As String = GetNickname()

        If nickname.Length <= 0 Then
            MsgBox("No nickname selected", vbInformation, "Missing information")
            Exit Sub
        End If

        Me.Hide()
        FormGame.Show()
    End Sub

    Private Sub OnButtonStatsClick(sender As Object, e As EventArgs) Handles btnOpenStats.Click
        FormStats.Show()
    End Sub
End Class