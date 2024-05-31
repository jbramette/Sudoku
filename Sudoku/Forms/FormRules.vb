Imports System.ComponentModel

Public Class FormRules

    Private _rules As List(Of String) = New List(Of String) From {
        "Rules 1",
        "Rules 2",
        "Rules 3",
        "Rules 4",
        "Rules 5"
    }

    Private _currRuleIndex As Integer = 0

    Private Sub btnPreviousPage_Click(sender As Object, e As EventArgs) Handles btnPreviousPage.Click
        If _currRuleIndex > 0 Then
            _currRuleIndex -= 1
            UpdatePage()
        End If
    End Sub

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        If _currRuleIndex < _rules.Count - 1 Then
            _currRuleIndex += 1
            UpdatePage()
        End If
    End Sub
    Private Sub FormRules_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdatePage()
    End Sub

    Private Sub OnFormClose(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormHome.Show()
    End Sub

    Private Sub UpdatePage()
        lblPageText.Text = _rules(_currRuleIndex)
    End Sub
End Class