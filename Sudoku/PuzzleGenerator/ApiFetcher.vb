Imports System.Text.Json

Module ApiFetcher

    Private Const DUSOKU_API_LINK As String = "https://sudoku-api.vercel.app/api/dosuku?query={newboard(limit:1){grids{solution}}}"

    ' Example JSON response
    '
    ' {
    '     "newboard": {
    '         "grids": [
    '             {
    '                 "solution": [
    '                     [1, 2, 3...],
    '                     [...],
    '                     [...],
    '                     ...
    '                 ]
    '             }         
    '         ]
    '     }
    ' }
    '
    Private Class PuzzleResponse
        Public Property newboard As NewBoard
    End Class

    Private Structure NewBoard
        Public Property grids As List(Of Solution)
    End Structure

    Private Structure Solution
        Public Property solution As List(Of List(Of Integer))
    End Structure

    Private Function HttpGet() As String
        Using webClient As New Net.WebClient
            Return webClient.DownloadString(DUSOKU_API_LINK)
        End Using
    End Function

    Public Function FetchPuzzle() As List(Of List(Of Integer))
        Dim response = HttpGet()
        Dim json = JsonSerializer.Deserialize(Of PuzzleResponse)(response)
        Return json.newboard.grids(0).solution
    End Function
End Module
