Public Class GameController

    Private Const GAME_DURATION_SECONDS As Integer = 5 * 60

    Private _view As FormGame
    Private _model As Grid
    Private _timer As Timer
    Private _remainingSeconds As Integer = GAME_DURATION_SECONDS

    Public Sub New(view As FormGame)
        _view = view
        _model = New Grid()
        _timer = New Timer()
        _timer.Interval = 1000

        AddHandler _timer.Tick, AddressOf OnTimerTick
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

        ' Start the countdown only once the grid has been fully loaded
        _timer.Start()
    End Sub

    Public Sub LightUpInTheGroup(col As Integer, row As Integer)
        _view.LightUpInTheGroup(col, row)
    End Sub

    Public Sub LightDownInTheGroup(col As Integer, row As Integer)
        _view.LightDownInTheGroup(col, row)
    End Sub

    Public Sub UpdateCell(sender As GridCell)
        ' Try to update the cell and notify UI
        If Not _model.SetCell(sender.Col(), sender.Row(), sender.Num()) Then
            _view.NotifyInputError()
        End If
    End Sub

    Private Sub OnTimerTick(sender As Object, e As EventArgs)
        _remainingSeconds -= 1

        Dim minutes As Integer = _remainingSeconds \ 60
        Dim seconds As Integer = _remainingSeconds Mod 60

        _view.UpdateTimerText(minutes, seconds)

        If _remainingSeconds <= 0 Then
            _timer.Stop()
        End If
    End Sub

End Class
