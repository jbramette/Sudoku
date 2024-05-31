Public Class FormHome

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxName.Items.AddRange(StatsManager.ListNicknames())
    End Sub

    ' Settings getters
    Public Function GetNickname() As String
        Return cbxName.Text.Trim()
    End Function

    Public Function GetSelectedDifficulty() As PuzzleDifficulty
        If rbModeSimple.Checked Then Return PuzzleDifficulty.Easy
        If rbModeMedium.Checked Then Return PuzzleDifficulty.Medium
        If rbModeHard.Checked Then Return PuzzleDifficulty.Hard
    End Function

    Public Function GetSelectedSeconds() As Integer
        Return numMinutes.Value * 60 + numSeconds.Value
    End Function

    Private Sub TryPlay()
        If GetNickname().Length <= 0 Then
            MsgBox("No nickname selected", vbInformation, "Missing information")
            Exit Sub
        End If

        If GetSelectedSeconds() = 0 Then
            MsgBox("Invalid selected time", vbInformation, "Missing information")
            Exit Sub
        End If

        Me.Hide()
        FormGame.Show()
    End Sub

    Private Sub OnKeyPressed(sender As Object, e As KeyPressEventArgs) Handles cbxName.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TryPlay()
        End If
    End Sub

    Private Sub OnButtonPlayClick(sender As Object, e As EventArgs) Handles btnPlayGame.Click
        TryPlay()
    End Sub

    Private Sub OnButtonStatsClick(sender As Object, e As EventArgs) Handles btnOpenStats.Click
        Me.Hide()
        FormStats.Show()
    End Sub

    Private Sub OnButtonRulesClick(sender As Object, e As EventArgs) Handles btnRules.Click
        Me.Hide()
        FormRules.Show()
    End Sub

    Private Sub OnButtonQuitClick(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim r As MsgBoxResult = MsgBox("Do you really want to leave ?", vbOKCancel Or vbQuestion, "Confirmation")

        If r = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub
End Class