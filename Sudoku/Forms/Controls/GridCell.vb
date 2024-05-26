Partial Public Class GridCell
    Inherits TextBox

    ' Zero based indices
    Private _row As Integer
    Private _col As Integer

    Private _value As Integer

    ' Default state of the cell
    Private CellForeColorUnfocused As Color = Color.Black

    ' State of the cell when we interact with it
    Private CellForeColorFocused As Color = Color.Black
    Private CellBackColorFocused As Color = Color.LightBlue

    ' The cells are either white or grey to differentiate their group
    Private CellBackColorGroupLight As Color = Color.White
    Private CellBackColorGroupDark As Color = Color.LightGray

    Public Sub New(col As Integer, row As Integer, value As Integer, size As Size)
        _col = col
        _row = row

        SetValue(value)

        ' Only groups with a pair index should be white
        Me.BackColor = GetBackgroundColor()

        ' Allow height resize
        Me.MinimumSize = size
        Me.Size = size

        ' Position the cell inside the parent control
        Dim posX = _col * Me.Size.Width
        Dim posY = _row * Me.Size.Height

        Me.Location = New Point(posX, posY)

        ' Only allow 1 character input (from 1 to 9)
        Me.MaxLength = 1

        ' Center and resize input text
        Me.TextAlign = HorizontalAlignment.Center
        Me.Font = New Font("Segoe UI", 24, FontStyle.Regular)
    End Sub

    Public Function Col()
        Return _col
    End Function

    Public Function Row()
        Return _row
    End Function

    Public Function Value()
        Return _value
    End Function

    Public Sub SetValue(value As Integer)
        _value = value

        If _value = 0 Then
            Me.Text = ""
        Else
            Me.Text = _value.ToString()
        End If
    End Sub

    ' Highlights the cell when it is focused
    Public Sub LightUp()
        Me.BackColor = CellBackColorFocused
        Me.ForeColor = CellForeColorFocused
    End Sub

    ' Removes the highlighting the cell when it is unfocused
    Public Sub LightDown()
        Me.BackColor = GetBackgroundColor()
        Me.ForeColor = CellForeColorUnfocused
    End Sub

    ' The background color of the cell is going to be determined by the square
    ' in which the cell is located
    ' One square out of two is light
    Private Function GetBackgroundColor() As Color
        If Grid.SquareIndexFor(_col, _row) Mod 2 = 0 Then
            Return CellBackColorGroupLight
        Else
            Return CellBackColorGroupDark
        End If
    End Function

End Class
