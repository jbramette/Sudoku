Imports System.Windows.Forms.VisualStyles

Partial Public Class GridCell
    Inherits TextBox

    ' Zero based indices
    Private _row As Integer
    Private _col As Integer

    ' Default state of the cell
    Private CellForeColorUnfocused As Color = Color.Black

    ' State of the cell when we interact with it
    Private CellForeColorFocused As Color = Color.Yellow
    Private CellBackColorFocused As Color = Color.Black

    ' The cells are either white or grey to differentiate their group
    Private CellBackColorGroupLight As Color = Color.White
    Private CellBackColorGroupDark As Color = Color.LightGray

    Public Sub New(col As Integer, row As Integer, size As Size)
        _col = col
        _row = row

        ' Only groups with a pair index should be white
        Me.BackColor = GetGroupColor()

        ' Allow height resize
        Me.MinimumSize = size
        Me.Size = size

        ' Position the cell inside the parent control
        Dim posX = col * Me.Size.Width
        Dim posY = row * Me.Size.Height

        Me.Location = New Point(posX, posY)

        ' Only allow 1 character input (from 1 to 9)
        Me.MaxLength = 1

        ' Center and resize input text
        Me.TextAlign = HorizontalAlignment.Center
        Me.Font = New Font("Segoe UI", 24, FontStyle.Regular)
    End Sub

    Public Function Row()
        Return _row
    End Function

    Public Function Col()
        Return _col
    End Function


    ' Enable input filtering, accepting only numeric or Backspace
    Private Shared Sub OnInput(sender As GridCell, e As KeyPressEventArgs) Handles Me.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Enable text pasting filtering, so that only numerics can be pasted
    Private Sub OnPaste(sender As Object, e As EventArgs) Handles Me.TextChanged
        If Not IsNumeric(Me.Text) Then
            Me.Text = ""
        End If
    End Sub

    Private Sub OnFocus(sender As GridCell, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = CellBackColorFocused
        Me.ForeColor = CellForeColorFocused
    End Sub

    Private Sub OnFocusLost(sender As GridCell, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = GetGroupColor()
        Me.ForeColor = CellForeColorUnfocused
    End Sub

    Private Function GetGroupIndex()
        Return _col \ 3 + _row \ 3
    End Function

    Private Function GetGroupColor()
        If GetGroupIndex() Mod 2 = 0 Then
            Return CellBackColorGroupLight
        Else
            Return CellBackColorGroupDark
        End If
    End Function

End Class
