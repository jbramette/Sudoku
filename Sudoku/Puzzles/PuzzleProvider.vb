Public Module PuzzleProvider
    Public Enum PuzzleDifficulty
        Easy
        Medium
        Hard
    End Enum

    Public Function QueryPuzzle(difficulty As PuzzleDifficulty) As List(Of List(Of Integer))
        Try
            Return ApiFetcher.GetPuzzle(difficulty)
        Catch ex As Exception ' No internet connection
            Return BackupPuzzles.GetPuzzle(difficulty)
        End Try
    End Function
End Module
