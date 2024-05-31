Imports System.ComponentModel

Public Class FormRules

    Private _rules As List(Of String) = New List(Of String) From {
        "Sudoku is a logic-based number placement puzzle played on a 9x9 grid. The objective is to fill the grid so that each row, each column, and each of the nine 3x3 subgrids, contains all the digits from 1 to 9.",
        "The puzzle begins with a partially completed grid, which provides clues to help deduce the remaining numbers",
        "The primary rule of Sudoku is that each row must contain all the digits from 1 to 9 without repetition. This means no number can be repeated in any on the nine rows. Ensuring that each row follows this rules is essential for solving the puzzle correctly, as it forms the basis of the puzzle's logical structure.",
        "Similarly, each column in the grid must also contain all the digits from 1 to 9 without any repetition. This rule is analogous to the rule for rows and is equally important. Cross-reference digits in both rows and columns, player can eliminate possibilities and find the correct placement for each number",
        "In addition, each of the nine 3x3 subgrids must also contain all the digits from 1 to 9, with no repeated numbers. This rules ensure that the puzzle's solution is unique and adheres to the logical constraints."
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
    Private Sub FormRules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatePage()
    End Sub

    Private Sub OnFormClose(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        FormHome.Show()
    End Sub

    Private Sub UpdatePage()
        gbxPage.Text = $"Rule n°{(_currRuleIndex + 1)}/{_rules.Count}"
        lblPageText.Text = _rules(_currRuleIndex)
    End Sub
End Class