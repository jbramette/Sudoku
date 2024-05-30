Public Class FormStats

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateDataGridView()
    End Sub

    Private Sub PopulateDataGridView()
        For Each playerName As String In StatsManager.ListNicknames()
            Dim stats As New PlayerStats()

            If LoadStatsForPlayer(playerName, stats) Then

                Dim recordTimeStr As String = TimeSpan.FromSeconds(stats.recordTime).ToString()
                Dim totalTimeStr As String = TimeSpan.FromSeconds(stats.totalPlayTime).ToString()

                dgvGames.Rows.Add(playerName, recordTimeStr, stats.gamesPlayed, stats.totalWin, totalTimeStr)
            End If
        Next
    End Sub
End Class