Public Class FormHome
    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Dim r As MsgBoxResult = MsgBox("You are about to leave, please confirm exit", vbOKCancel Or vbExclamation, "Exit")

        If r = MsgBoxResult.Ok Then
            Me.Close()
        End If

    End Sub

    Private Sub btnPlayGame_Click(sender As Object, e As EventArgs) Handles btnPlayGame.Click
        Dim nickname As String = cbxName.Text

        If nickname.Length <= 0 Then
            MsgBox("No nickname selected", vbInformation)
        End If

        cbxName.Items.Add(nickname)
    End Sub
End Class