﻿Public Class GameController

    ' We use the MVC (Model-View-Controller) pattern to separate the sudoku grid (=Model)
    ' from the GUI (=View)
    '
    ' Separation is done via the controller which acts as a bridge.
    ' It is called by the UI whenever user input related to the game is done.
    ' The controller will translate these user inputs to call the appropriate function calls
    ' to modify the grid. It will also communicate back with the UI in case of success/failures/loose/win
    ' so that the UI can notify the user.
    '
    ' 
    ' ____________    forward UI event    ___________________    modify Grid accordingly      _________
    ' |          | ---------------------> |                 | ------------------------------> |       |
    ' | FormGame |                        |  GameController |                                 |  Grid |
    ' |__________| <--------------------- |_________________| <------------------------------ |_______|
    '                  modifies UI                               Grid function's return values
    '
    '
    ' Note that the Grid does not know anything about the controller.
    '
    ' + Prevents the FormGame and the Grid to interact between themselves as they shouldn't be aware of each other
    ' + Separates each class' purpose, grid manipulation shouldn't be directly manipulated in the UI code, and the logic code
    '   shouldn't manipulate the UI code.
    ' + Prevents cyclic dependencies, as the 'Forms' package does not depend from the 'Logic' package, and the 'Logic' package does not
    '   depend from the 'Forms' package.
    ' + This pattern also makes it easier to test Grid as a standalone component.
    ' 

    Private Const GAME_DURATION_SECONDS As Integer = 1 * 40

    Private _view As FormGame
    Private _grid As Grid

    ' Game related data, maybe move to a GameManager class ?
    Private _nickname As String
    Private _timer As Timer
    Private _remainingSeconds As Integer = GAME_DURATION_SECONDS

    Public Sub New(view As FormGame, nickname As String)
        _view = view
        _grid = New Grid()
        _nickname = nickname
        _timer = New Timer()
        _timer.Interval = 1000

        AddHandler _timer.Tick, AddressOf OnTimerTick
    End Sub

    ' Start the Sudoku game
    ' 1. Generate the grid and update the UI
    ' 2. Start the countdown
    Public Sub StartGame()
        ' Update grid
        _grid.Generate()

        ' Create the UI's cells
        For y = 0 To Grid.ROWS - 1
            For x = 0 To Grid.COLS - 1
                Dim num As Integer = _grid.GetValue(x, y)
                _view.AddCell(x, y, num)
            Next
        Next

        ' Start the countdown only once the grid has been fully loaded
        _timer.Start()
    End Sub

    Public Sub UpdateCell(cell As GridCell, value As Integer)
        cell.TrySetValue(value)

        ' Try to update the grid and notify UI in case of error
        If Not _grid.SetValue(cell.Col(), cell.Row(), cell.Value()) Then
            _view.NotifyInputError()
            cell.Text = ""
        ElseIf _grid.IsCompleted() Then
            OnGameEnded(won:=True)
        End If
    End Sub

    Private Sub OnTimerTick(sender As Object, e As EventArgs)
        _remainingSeconds -= 1

        Dim minutes As Integer = _remainingSeconds \ 60
        Dim seconds As Integer = _remainingSeconds Mod 60

        ' Notify the UI to update its timer
        _view.UpdateTimerText(minutes, seconds)

        If _remainingSeconds <= 0 Then
            OnGameEnded(won:=False)
        End If
    End Sub

    ' This function is called when the game has ended
    ' It can be triggered by completing the grid or the timer
    ' ran out, indicated by the parameter
    Private Sub OnGameEnded(won As Boolean)
        _timer.Stop()

        ' Update UI
        If won Then
            _view.NotifyWin()
        Else
            _view.NotifyGameOver()
        End If

        ' Save game stats for player
        Dim gameStats As StatsManager.GameStats

        gameStats.won = won
        gameStats.timePlayed = GAME_DURATION_SECONDS - _remainingSeconds

        StatsManager.SaveGameStatsForPlayer(gameStats, _nickname)
    End Sub
End Class
