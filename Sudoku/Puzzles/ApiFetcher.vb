Imports System.Text.Json

Module ApiFetcher

    Private Const BASE_API_LINK As String = "https://sugoku.onrender.com/board"

    ' Example JSON response
    '
    ' {
    '     "board": [
    '         [
    '           [1, 2, 3...],
    '           [...],
    '           [...],
    '           ...
    '         ]
    '     ]
    ' }
    '
    Friend Class PuzzleJson
        Public Property board As List(Of List(Of Integer))
    End Class

    Public Function GetPuzzle(difficulty As PuzzleDifficulty) As List(Of List(Of Integer))
        Dim url = BASE_API_LINK & GetDifficultySuffix(difficulty)
        Return FetchPuzzle(url)
    End Function

    Private Function HttpGet(url) As String
        Using webClient As New Net.WebClient
            Return webClient.DownloadString(url)
        End Using
    End Function

    Private Function FetchPuzzle(url As String) As List(Of List(Of Integer))
        Dim response = HttpGet(url)
        Dim json = JsonSerializer.Deserialize(Of PuzzleJson)(response)
        Return json.board
    End Function

    Private Function GetDifficultySuffix(difficulty As PuzzleDifficulty) As String
        Dim prefix = "?difficulty="
        Dim difficultyName As String

        Select Case difficulty
            Case PuzzleDifficulty.Easy
                difficultyName = "easy"
            Case PuzzleDifficulty.Medium
                difficultyName = "medium"
            Case PuzzleDifficulty.Hard
                difficultyName = "hard"
        End Select

        Return prefix & difficultyName
    End Function
End Module
