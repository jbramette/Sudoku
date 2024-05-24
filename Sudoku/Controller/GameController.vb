Public Class GameController

    Private _view As FormGame
    Private _model As Grid

    Public Sub New(view As FormGame)
        _view = view
        _model = New Grid()
    End Sub

    Public Sub LoadGrid()
        ' Update grid
        _model.Generate()

        ' Update UI
        For x = 0 To Grid.COLS - 1
            For y = 0 To Grid.ROWS - 1
                Dim num As Integer = _model.GetCell(x, y)
                _view.AddCell(x, y, num)
            Next
        Next

    End Sub

    Public Sub UpdateCell(sender As GridCell)
        If Not _model.SetCell(sender.Col(), sender.Row(), sender.Num()) Then
            _view.NotifyInputError()
        End If
    End Sub

End Class
