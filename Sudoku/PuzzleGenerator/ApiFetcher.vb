Imports System.Text.Json

Module ApiFetcher

    Private Const API_LINK As String = "https://sugoku.onrender.com/board?difficulty=easy"

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

    Private Function HttpGet() As String
        Using webClient As New Net.WebClient
            Return webClient.DownloadString(API_LINK)
        End Using
    End Function

    Public Function FetchPuzzle() As List(Of List(Of Integer))
        Dim response = HttpGet()
        Dim json = JsonSerializer.Deserialize(Of PuzzleJson)(response)
        Return json.board
    End Function
End Module
