Imports System.Text.Json

Public Module PuzzleProvider
    Public Enum PuzzleDifficulty
        Easy
        Medium
        Hard
    End Enum

    Public Structure Puzzle
        Public solution As List(Of List(Of Integer))
        Public puzzle As List(Of List(Of Integer))
        Public difficulty As PuzzleDifficulty

        Public Sub New(solution As List(Of List(Of Integer)), difficulty As PuzzleDifficulty)
            Me.solution = solution
            Me.puzzle = New List(Of List(Of Integer))
            Me.difficulty = difficulty

            ' Deep copy solution to puzzle
            For Each row As List(Of Integer) In solution
                Dim copy As New List(Of Integer)

                For Each col As Integer In row
                    copy.Add(col)
                Next

                Me.puzzle.Add(copy)
            Next

            Dim rng As New Random()

            Dim removedCells As New HashSet(Of (Integer, Integer))
            Dim nbCellsToRemove = GetEmptyCellsCount(difficulty)

            ' Remove a certain amount of cells based on difficulty
            While removedCells.Count < nbCellsToRemove
                Dim randomCol As Integer = rng.Next(Grid.COLS)
                Dim randomRow As Integer = rng.Next(Grid.ROWS)

                If Not removedCells.Contains((randomCol, randomRow)) Then
                    puzzle(randomRow)(randomCol) = 0
                    removedCells.Add((randomCol, randomRow))
                End If
            End While
        End Sub
    End Structure

    Private Class JSONPuzzle
        Public Property newboard As JSONNewBoard
    End Class

    Private Structure JSONNewBoard
        Public Property grids As List(Of JSONSolution)
    End Structure

    Private Structure JSONSolution
        Public Property solution As List(Of List(Of Integer))
    End Structure

    Public Function QueryPuzzle(difficulty As PuzzleDifficulty) As Puzzle
        Dim jsonPuzzle As String

        Try
            ' Try to fetch a solution from an API
            Using webClient As New Net.WebClient()
                jsonPuzzle = webClient.DownloadString("https://sudoku-api.vercel.app/api/dosuku?query={newboard(limit:1){grids{solution}}}")
            End Using
        Catch ex As Exception
            ' If it did not work, fallback to defaults
            Dim defaultPuzzles() As String = {
                "{""newboard"":{""grids"":[{""solution"":[[1,8,9,2,5,3,6,4,7],[2,5,7,4,1,6,8,3,9],[3,4,6,7,9,8,1,2,5],[6,3,8,1,2,5,9,7,4],[7,1,5,9,3,4,2,6,8],[9,2,4,6,8,7,5,1,3],[8,6,3,5,4,1,7,9,2],[4,9,1,8,7,2,3,5,6],[5,7,2,3,6,9,4,8,1]]}]}}",
                "{""newboard"":{""grids"":[{""solution"":[[7,1,5,6,2,3,4,9,8],[6,3,9,4,5,8,1,7,2],[4,8,2,7,1,9,6,3,5],[8,7,1,9,6,4,2,5,3],[5,4,3,1,7,2,9,8,6],[9,2,6,8,3,5,7,4,1],[3,9,4,2,8,1,5,6,7],[2,6,8,5,4,7,3,1,9],[1,5,7,3,9,6,8,2,4]]}]}}",
                "{""newboard"":{""grids"":[{""solution"":[[5,6,7,3,8,1,4,2,9],[3,8,2,4,9,7,6,5,1],[1,4,9,6,5,2,7,3,8],[8,1,4,5,2,6,9,7,3],[9,7,5,8,3,4,2,1,6],[2,3,6,7,1,9,5,8,4],[7,2,8,9,4,3,1,6,5],[4,5,1,2,6,8,3,9,7],[6,9,3,1,7,5,8,4,2]]}]}}"
            }

            jsonPuzzle = defaultPuzzles(New Random().Next(defaultPuzzles.Length))
        End Try

        Dim solution = JsonSerializer.Deserialize(Of JSONPuzzle)(jsonPuzzle).newboard.grids(0).solution
        Return New Puzzle(solution, difficulty)
    End Function

    Private Function GetEmptyCellsCount(difficulty As PuzzleDifficulty) As Integer
        Dim rng As New Random()

        Select Case difficulty
            Case PuzzleDifficulty.Easy
                Return rng.Next(15, 25)
            Case PuzzleDifficulty.Medium
                Return rng.Next(30, 50)
            Case PuzzleDifficulty.Hard
                Return rng.Next(60, 70)
        End Select
    End Function
End Module
