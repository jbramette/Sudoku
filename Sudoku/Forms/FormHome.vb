Public Class FormHome

    Public Function GetNickname()
        Return cbxName.Text
    End Function

    Private Sub OnQuitClick(sender As Object, e As EventArgs) Handles btnQuit.Click

        Dim r As MsgBoxResult = MsgBox("Do you really want to leave ?", vbOKCancel Or vbQuestion, "Confirmation")

        If r = MsgBoxResult.Ok Then
            Me.Close()
        End If

    End Sub

    Private Sub OnKeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxName.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            OnPlayClick(sender, e)
        End If
    End Sub


    Private Sub OnPlayClick(sender As Object, e As EventArgs) Handles btnPlayGame.Click
        Dim nickname As String = GetNickname()

        If nickname.Length <= 0 Then
            MsgBox("No nickname selected", vbInformation, "Missing information")
            Exit Sub
        End If

        Me.Hide()
        FormGame.Show()
    End Sub

End Class