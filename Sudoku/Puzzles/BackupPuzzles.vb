Imports System.Text.Json

Partial Public Class BackupPuzzles

    Private easy_puzzles As List(Of String)
    Private medium_puzzles As List(Of String)
    Private hard_puzzles As List(Of String)

    Public Sub New()
        easy_puzzles = New List(Of String) From {
            "{""board"": [[0,0,0,0,0,0,1,0,0],[0,0,5,0,0,0,6,0,0],[0,8,0,1,0,6,2,0,0],[2,0,3,0,6,0,7,9,8],[0,4,7,0,0,9,0,0,6],[6,9,0,7,1,0,0,5,0],[3,0,0,6,0,0,0,0,0],[0,6,0,0,7,1,0,2,0],[9,0,2,8,0,4,0,6,0]]}",
            "{""board"":[[0,0,4,0,0,7,0,0,0],[1,0,5,0,4,8,6,0,0],[0,7,8,0,5,0,0,0,0],[2,0,3,0,0,5,0,0,0],[4,0,7,8,9,1,0,0,0],[8,6,0,7,0,3,0,1,5],[0,3,0,9,0,4,0,6,2],[0,0,0,5,0,6,0,8,1],[0,0,0,1,7,2,0,0,3]]}",
            "{""board"":[[0,0,9,0,0,0,2,0,0],[0,0,0,0,0,6,0,0,0],[0,0,8,1,0,0,0,4,6],[2,0,0,0,6,5,0,0,0],[3,0,6,0,9,0,0,0,0],[8,0,0,0,1,4,0,6,0],[6,0,1,5,0,2,9,7,0],[7,0,2,9,8,0,0,3,5],[9,8,0,6,0,7,0,1,0]]}"
        }

        medium_puzzles = New List(Of String) From {
            "{""board"":[[0,3,0,6,0,0,0,0,0],[1,0,0,0,0,0,5,0,0],[0,0,0,1,0,0,0,0,0],[2,0,0,0,5,0,0,0,0],[0,5,0,2,8,0,1,0,0],[6,0,0,0,1,3,0,2,5],[0,4,0,8,6,0,9,7,0],[0,7,0,9,0,0,6,0,0],[9,6,2,0,7,0,8,0,1]]}",
            "{""board"":[[0,5,4,0,0,0,1,0,0],[0,2,0,0,0,0,0,0,0],[7,8,0,1,0,0,3,0,0],[0,0,0,4,0,6,0,0,0],[4,0,5,0,0,9,0,1,0],[0,9,7,0,0,0,0,0,5],[0,3,1,0,6,0,9,7,0],[6,7,0,0,3,0,8,0,1],[9,4,0,5,0,1,6,0,0]]}",
            "{""board"":[[0,0,0,0,6,0,3,0,1],[0,0,0,5,0,0,0,0,7],[0,0,7,0,0,0,0,8,0],[2,1,4,0,0,0,7,0,0],[3,0,6,0,9,0,0,4,2],[0,8,0,2,0,0,6,0,5],[0,0,0,9,0,2,0,5,0],[8,0,2,6,1,0,9,0,3],[0,0,0,0,0,0,0,0,6]]}"
        }

        hard_puzzles = New List(Of String) From {
            "{""board"":[[3,0,0,0,0,1,9,0,0],[0,0,0,0,0,0,0,7,0],[6,0,9,0,0,0,0,0,0],[0,1,3,4,0,0,0,0,0],[0,0,0,1,0,8,0,0,0],[0,0,0,0,2,0,4,0,0],[5,0,1,0,8,0,2,0,0],[0,0,0,0,1,0,0,0,0],[0,7,0,5,3,2,8,0,0]]}",
            "{""board"":[[0,7,0,0,0,0,8,0,0],[1,0,0,0,0,0,0,0,9],[0,0,9,0,0,0,0,2,0],[0,0,0,0,0,0,7,0,0],[3,5,6,0,0,9,0,0,1],[0,0,8,0,0,0,0,0,0],[0,0,2,0,4,0,0,8,0],[0,4,0,0,0,0,0,1,0],[9,0,0,8,0,3,4,0,2]]}",
            "{""board"":[[0,0,0,0,0,0,0,0,0],[0,0,0,2,0,7,5,0,0],[0,0,0,4,8,0,0,0,0],[2,0,0,0,0,0,0,0,0],[0,0,0,0,9,0,2,0,0],[7,0,8,1,2,0,0,0,6],[0,0,1,0,0,0,0,0,0],[0,7,0,0,3,0,8,0,2],[8,0,9,0,0,2,3,1,5]]}"
        }
    End Sub

    Public Function GetPuzzle(difficulty As PuzzleDifficulty) As List(Of List(Of Integer))
        Dim seed As New Random()
        Dim getRandomUpTo = Function(upperbound As Integer) As Integer
                                Return seed.Next(0, upperbound)
                            End Function

        Dim puzzleJson As String

        Select Case difficulty
            Case PuzzleDifficulty.Easy
                puzzleJson = easy_puzzles(getRandomUpTo(easy_puzzles.Count))
            Case PuzzleDifficulty.Medium
                puzzleJson = medium_puzzles(getRandomUpTo(medium_puzzles.Count))
            Case PuzzleDifficulty.Hard
                puzzleJson = hard_puzzles(getRandomUpTo(hard_puzzles.Count))
        End Select

        Dim json = JsonSerializer.Deserialize(Of PuzzleJson)(puzzleJson)
        Return json.board
    End Function

End Class
