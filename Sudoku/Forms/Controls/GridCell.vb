Partial Public Class GridCell
    Inherits TextBox

    Private _controller As GameController

    ' Zero based indices
    Private _row As Integer
    Private _col As Integer
    Private _num As Integer

    ' Default state of the cell
    Private CellForeColorUnfocused As Color = Color.Black

    ' State of the cell when we interact with it
    Private CellForeColorFocused As Color = Color.Black
    Private CellBackColorFocused As Color = Color.LightBlue

    ' The cells are either white or grey to differentiate their group
    Private CellBackColorGroupLight As Color = Color.White
    Private CellBackColorGroupDark As Color = Color.LightGray


    Public Sub New(controller As GameController, col As Integer, row As Integer, num As Integer, size As Size)
        _controller = controller

        _col = col
        _row = row
        _num = num

        If _num = 0 Then
            Me.Text = ""
        Else
            Me.Text = _num.ToString()
        End If

        ' Only groups with a pair index should be white
        Me.BackColor = GetGroupColor()

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

    Public Function Num()
        Return _num
    End Function

    Public Sub LightUp()
        Me.BackColor = CellBackColorFocused
        Me.ForeColor = CellForeColorFocused
    End Sub

    Public Sub LightDown()
        Me.BackColor = GetGroupColor()
        Me.ForeColor = CellForeColorUnfocused
    End Sub

    ' Enable text pasting filtering, so that only numerics can be pasted
    Private Sub OnInput(sender As Object, e As EventArgs) Handles Me.TextChanged
        If Not IsNumeric(Me.Text) Then
            Me.Text = ""
        Else
            _num = Convert.ToInt32(Me.Text)
            _controller.UpdateCell(Me)
        End If
    End Sub

    Private Sub OnFocus(sender As GridCell, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = CellBackColorFocused
        Me.ForeColor = CellForeColorFocused

        _controller.LightUpInTheGroup(_col, Row)
    End Sub

    Private Sub OnFocusLost(sender As GridCell, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = GetGroupColor()
        Me.ForeColor = CellForeColorUnfocused

        _controller.LightDownInTheGroup(_col, _row)
    End Sub

    Private Function GetGroupColor()
        If Grid.GroupIndexFor(_col, _row) Mod 2 = 0 Then
            Return CellBackColorGroupLight
        Else
            Return CellBackColorGroupDark
        End If
    End Function

End Class
