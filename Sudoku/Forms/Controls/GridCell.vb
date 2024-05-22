Imports System.Windows.Forms.VisualStyles

Partial Public Class GridCell
    Inherits TextBox

    ' Zero based indices
    Private _row As Integer
    Private _col As Integer

    Sub New(col As Integer, row As Integer, size As Size)
        _col = col
        _row = row

        Dim groupIndex = _col \ 3 + _row \ 3

        ' Only groups with a pair index should be white
        If groupIndex Mod 2 <> 0 Then
            Me.BackColor = Color.LightGray
        End If

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

End Class
