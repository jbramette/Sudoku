Imports System.Diagnostics.Eventing.Reader
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles

Partial Public Class GridCell
    Inherits TextBox

    ' Zero based indices
    Private _row As Integer
    Private _col As Integer

    ' Default state of the cell
    Private GridForeColorUnfocused As Color = Color.Black
    Private GridBackColorUnfocused As Color = Color.LightGray

    ' State of the cell when we interact with it
    Private GridForeColorFocused As Color = Color.Yellow
    Private GridBackColorFocused As Color = Color.Black


    Private Sub Input(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            Dim input As Integer
            If Integer.TryParse(e.KeyChar.ToString(), input) Then
                If Not FormGame.isInputCorrect(input, Me._col, Me._row) Then
                    Me.ForeColor = Color.Red
                End If
            End If
        End If
    End Sub

    ' Enable text pasting filtering, so that only numerics can be pasted
    Private Sub Paste(sender As Object, e As System.EventArgs) Handles Me.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        Me.Text = digitsOnly.Replace(Me.Text, "")
    End Sub

    Private Sub focus(sender As GridCell, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = GridBackColorFocused
        Me.ForeColor = GridForeColorFocused
    End Sub

    Private Sub unfocus(sender As GridCell, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = WhichColor()
        Me.ForeColor = GridForeColorUnfocused
    End Sub

    Sub New(col As Integer, row As Integer, size As Size)
        _col = col
        _row = row

        Me.BackColor = WhichColor()

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

    Private Function WhichColor()
        Dim groupIndex = _col \ 3 + _row \ 3
        ' Only groups with a pair index should be white
        If groupIndex Mod 2 <> 0 Then
            Return GridBackColorUnfocused
        Else
            Return Color.White
        End If
    End Function

    Public Function Row()
        Return _row
    End Function

    Public Function Col()
        Return _col
    End Function

End Class
