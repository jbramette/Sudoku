Imports System.Text.Json

Public Module BackupPuzzles
    Public Function GetPuzzle(difficulty As PuzzleDifficulty) As List(Of List(Of Integer))
        Dim _easyPuzzles As List(Of String)
        Dim _mediumPuzzles As List(Of String)
        Dim _hardPuzzles As List(Of String)

        _easyPuzzles = New List(Of String) From {
            "{""board"": [[0,0,0,0,0,0,1,0,0],[0,0,5,0,0,0,6,0,0],[0,8,0,1,0,6,2,0,0],[2,0,3,0,6,0,7,9,8],[0,4,7,0,0,9,0,0,6],[6,9,0,7,1,0,0,5,0],[3,0,0,6,0,0,0,0,0],[0,6,0,0,7,1,0,2,0],[9,0,2,8,0,4,0,6,0]]}",
            "{""board"":[[0,0,4,0,0,7,0,0,0],[1,0,5,0,4,8,6,0,0],[0,7,8,0,5,0,0,0,0],[2,0,3,0,0,5,0,0,0],[4,0,7,8,9,1,0,0,0],[8,6,0,7,0,3,0,1,5],[0,3,0,9,0,4,0,6,2],[0,0,0,5,0,6,0,8,1],[0,0,0,1,7,2,0,0,3]]}",
            "{""board"":[[0,0,9,0,0,0,2,0,0],[0,0,0,0,0,6,0,0,0],[0,0,8,1,0,0,0,4,6],[2,0,0,0,6,5,0,0,0],[3,0,6,0,9,0,0,0,0],[8,0,0,0,1,4,0,6,0],[6,0,1,5,0,2,9,7,0],[7,0,2,9,8,0,0,3,5],[9,8,0,6,0,7,0,1,0]]}"
        }

        _mediumPuzzles = New List(Of String) From {
            "{""board"":[[0,3,0,6,0,0,0,0,0],[1,0,0,0,0,0,5,0,0],[0,0,0,1,0,0,0,0,0],[2,0,0,0,5,0,0,0,0],[0,5,0,2,8,0,1,0,0],[6,0,0,0,1,3,0,2,5],[0,4,0,8,6,0,9,7,0],[0,7,0,9,0,0,6,0,0],[9,6,2,0,7,0,8,0,1]]}",
            "{""board"":[[0,5,4,0,0,0,1,0,0],[0,2,0,0,0,0,0,0,0],[7,8,0,1,0,0,3,0,0],[0,0,0,4,0,6,0,0,0],[4,0,5,0,0,9,0,1,0],[0,9,7,0,0,0,0,0,5],[0,3,1,0,6,0,9,7,0],[6,7,0,0,3,0,8,0,1],[9,4,0,5,0,1,6,0,0]]}",
            "{""board"":[[0,0,0,0,6,0,3,0,1],[0,0,0,5,0,0,0,0,7],[0,0,7,0,0,0,0,8,0],[2,1,4,0,0,0,7,0,0],[3,0,6,0,9,0,0,4,2],[0,8,0,2,0,0,6,0,5],[0,0,0,9,0,2,0,5,0],[8,0,2,6,1,0,9,0,3],[0,0,0,0,0,0,0,0,6]]}"
        }

        _hardPuzzles = New List(Of String) From {
            "{""board"":[[3,0,0,0,0,1,9,0,0],[0,0,0,0,0,0,0,7,0],[6,0,9,0,0,0,0,0,0],[0,1,3,4,0,0,0,0,0],[0,0,0,1,0,8,0,0,0],[0,0,0,0,2,0,4,0,0],[5,0,1,0,8,0,2,0,0],[0,0,0,0,1,0,0,0,0],[0,7,0,5,3,2,8,0,0]]}",
            "{""board"":[[0,7,0,0,0,0,8,0,0],[1,0,0,0,0,0,0,0,9],[0,0,9,0,0,0,0,2,0],[0,0,0,0,0,0,7,0,0],[3,5,6,0,0,9,0,0,1],[0,0,8,0,0,0,0,0,0],[0,0,2,0,4,0,0,8,0],[0,4,0,0,0,0,0,1,0],[9,0,0,8,0,3,4,0,2]]}",
            "{""board"":[[0,0,0,0,0,0,0,0,0],[0,0,0,2,0,7,5,0,0],[0,0,0,4,8,0,0,0,0],[2,0,0,0,0,0,0,0,0],[0,0,0,0,9,0,2,0,0],[7,0,8,1,2,0,0,0,6],[0,0,1,0,0,0,0,0,0],[0,7,0,0,3,0,8,0,2],[8,0,9,0,0,2,3,1,5]]}"
        }

        Dim rng As New Random()
        Dim getRandomUpTo = Function(upperbound As Integer) As Integer
                                Return rng.Next(0, upperbound)
                            End Function

        Dim puzzleJson As String

        Select Case difficulty
            Case PuzzleDifficulty.Easy
                puzzleJson = _easyPuzzles(getRandomUpTo(_easyPuzzles.Count))
            Case PuzzleDifficulty.Medium
                puzzleJson = _mediumPuzzles(getRandomUpTo(_mediumPuzzles.Count))
            Case PuzzleDifficulty.Hard
                puzzleJson = _hardPuzzles(getRandomUpTo(_hardPuzzles.Count))
        End Select

        Dim json = JsonSerializer.Deserialize(Of PuzzleJson)(puzzleJson)
        Return json.board
    End Function

End Module
