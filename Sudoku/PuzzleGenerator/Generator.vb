Public Module Generator
    Public Enum PuzzleDifficulty
        Simple
        Medium
        Hard
    End Enum

    Public Function QueryPuzzle(difficulty As PuzzleDifficulty) As List(Of List(Of Integer))
        Dim puzzle = ApiFetcher.FetchPuzzle()

        Dim rng As New Random()

        Dim removedCells As New HashSet(Of (Integer, Integer))

        ' Remove a certain amount of cells based on difficulty
        While removedCells.Count < GetRemoveCountFor(difficulty)
            Dim randomCol As Integer = rng.Next(0, Grid.COLS)
            Dim randomRow As Integer = rng.Next(0, Grid.ROWS)

            If Not removedCells.Contains((randomCol, randomRow)) Then
                puzzle(randomRow)(randomCol) = 0
                removedCells.Add((randomCol, randomRow))
            End If
        End While

        Return puzzle
    End Function

    Private Function GetRemoveCountFor(difficulty As PuzzleDifficulty) As Integer
        Dim rng As New Random()

        Select Case difficulty
            Case PuzzleDifficulty.Simple
                Return rng.Next(20, 40)
            Case PuzzleDifficulty.Medium
                Return rng.Next(45, 65)
            Case PuzzleDifficulty.Hard
                Return rng.Next(70, 75)
        End Select
    End Function
End Module

