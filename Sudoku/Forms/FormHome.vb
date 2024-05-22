Public Class FormHome

    Public Function GetNickname()
        Return cbxName.Text
    End Function

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Dim r As MsgBoxResult = MsgBox("Do you really want to leave ?", vbOKCancel Or vbQuestion, "Confirmation")

        If r = MsgBoxResult.Ok Then
            Me.Close()
        End If

    End Sub

    Private Sub btnPlayGame_Click(sender As Object, e As EventArgs) Handles btnPlayGame.Click
        Dim nickname As String = GetNickname()

        If nickname.Length <= 0 Then
            MsgBox("No nickname selected", vbInformation, "Missing information")
            Exit Sub
        End If

        Me.Hide()
        FormGame.Show()
    End Sub
End Class