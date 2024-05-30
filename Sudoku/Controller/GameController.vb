Public Class GameController

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
    Private _timer As Timer
    Private _remainingSeconds As Integer = GAME_DURATION_SECONDS

    Public Sub New(view As FormGame)
        _view = view
        _grid = New Grid()
        _timer = New Timer()
        _timer.Interval = 1000

        AddHandler _timer.Tick, AddressOf OnTimerTick
    End Sub

    ' Start the Sudoku game
    ' 1. Generate the grid and update the UI
    ' 2. Start the countdown
    Public Sub StartGame()
        ' Create the UI's cells
        For y = 0 To Grid.ROWS - 1
            For x = 0 To Grid.COLS - 1
                Dim num As Integer = _grid.GetValue(x, y)
                _view.AddCell(x, y, num)
            Next
        Next

        Dim puzzle = ApiFetcher.FetchPuzzle()
        LoadPuzzle(puzzle)

        ' Start the countdown only once the grid has been fully loaded
        _timer.Start()
    End Sub

    ' Algorithm to generate a random Sudoku grid
    ' Accepts the number of cells to be filled, that determines the difficulty of the puzzle
    Public Sub GenerateSudoku(filled As Integer)
        For i = 0 To filled
            Dim seed As New Random()
            Dim getRandomUpTo = Function(upperbound As Integer) As Integer
                                    Return seed.Next(0, upperbound)
                                End Function

            Dim randomCol = getRandomUpTo(Grid.COLS)
            Dim randomRow = getRandomUpTo(Grid.ROWS)

            ' Gets random position, if it lands on a filled one, it will loop
            While _grid.GetValue(randomCol, randomRow) <> 0
                randomCol = getRandomUpTo(Grid.COLS)
                randomRow = getRandomUpTo(Grid.ROWS)
            End While

            Dim possibleValues = _grid.GetAvaivableValues(randomCol, randomRow)
            Dim randomPossibleValue As Integer = possibleValues(getRandomUpTo(possibleValues.Count))

            UpdateCell(_view.GetCell(randomCol, randomRow), randomPossibleValue)
        Next
    End Sub

    Private Sub LoadPuzzle(puzzle As List(Of List(Of Integer)))
        For r = 0 To Grid.ROWS - 1
            For c = 0 To Grid.COLS - 1
                Dim cell As GridCell = _view.GetCell(c, r)
                Dim value As Integer = puzzle(r)(c)

                PutIntoCellUnchecked(cell, value)

                If value <> 0 Then
                    cell.Enabled = False ' The data cannot be changed inside the cell
                End If
            Next
        Next
    End Sub

    Private Sub PutIntoCellUnchecked(cell As GridCell, value As Integer)
        cell.TrySetValue(value)
        _grid.PutValueUnchecked(cell.Col(), cell.Row(), value)
    End Sub

    Public Sub UpdateCell(cell As GridCell, value As Integer)
        cell.TrySetValue(value)

        ' Try to update the grid and notify UI in case of error
        If Not _grid.SetValue(cell.Col(), cell.Row(), cell.Value()) Then
            _view.NotifyInputError()
            cell.Text = ""
        ElseIf _grid.IsCompleted() Then
            _view.NotifyWin()
            _timer.Stop()
        End If
    End Sub

    Private Sub OnTimerTick(sender As Object, e As EventArgs)
        _remainingSeconds -= 1

        Dim minutes As Integer = _remainingSeconds \ 60
        Dim seconds As Integer = _remainingSeconds Mod 60

        ' Notify the UI to update its timer
        _view.UpdateTimerText(minutes, seconds)

        If _remainingSeconds <= 0 Then
            _timer.Stop()
            OnGameLost()
        End If
    End Sub

    Private Sub OnGameLost()
        _view.NotifyGameOver()
    End Sub

End Class
