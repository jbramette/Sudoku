Imports System.Text.Json

Module ApiFetcher

    Private Const DUSOKU_API_LINK As String = "https://sudoku-api.vercel.app/api/dosuku?query={newboard(limit:1){grids{value}}}"

    ' Example JSON response
    '
    ' {
    '     "newboard": {
    '         "grids": [
    '             {
    '                 "value": [
    '                     [0, 8, 9, 0, 0, 0, 0, 0, 0],
    '                     [0, 8, 9, 0, 0, 0, 0, 0, 0],
    '                     [0, 8, 9, 0, 0, 0, 0, 0, 0],
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
        Public Property grids As List(Of Value)
    End Structure

    Private Structure Value
        Public Property value As List(Of List(Of Integer))
    End Structure

    Private Function HttpGet() As String
        Using webClient As New Net.WebClient
            Return webClient.DownloadString(DUSOKU_API_LINK)
        End Using
    End Function

    Public Function FetchPuzzle() As List(Of List(Of Integer))
        Dim response = HttpGet()
        Dim json = JsonSerializer.Deserialize(Of PuzzleResponse)(response)

        Return json.newboard.grids(0).value
    End Function

End Module
