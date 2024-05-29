Imports System.Text.Json

Module ApiFetcher

    Private Const DUSOKU_API_LINK As String = "https://sudoku-api.vercel.app/api/dosuku?query={newboard(limit:1){grids{value}}}"

    Private Function HttpGet() As String
        Using webClient As New Net.WebClient
            Return webClient.DownloadString(DUSOKU_API_LINK)
        End Using
    End Function

    Public Function FetchPuzzle() As List(Of List(Of Integer))
        Dim response = HttpGet()
        Dim json = JsonSerializer.Deserialize(Of Object)(response)

        ' TODO
    End Function

End Module
