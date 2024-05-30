Public Class FormStats

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateDataGridView()
    End Sub

    Private Sub PopulateDataGridView()
        For Each playerName As String In StatsManager.ListNicknames()
            Dim stats As New PlayerStats()

            If LoadStatsForPlayer(playerName, stats) Then
                AddStatsRow(playerName, stats)
            Else
                Dim deleteFile = MsgBox($"Error loading stats for player {playerName}, remove stats file ?", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo)

                If deleteFile = MsgBoxResult.Yes Then
                    StatsManager.RemoveStatsFileForPlayer(playerName)
                End If
            End If
        Next
    End Sub

    Private Sub AddStatsRow(playerName As String, stats As PlayerStats)
        Dim recordTimeStr As String = TimeSpan.FromSeconds(stats.recordTime).ToString()
        Dim totalTimeStr As String = TimeSpan.FromSeconds(stats.totalPlayTime).ToString()

        dgvGames.Rows.Add(playerName,
                          recordTimeStr,
                          stats.gamesPlayed,
                          stats.GetTotalWin(),
                          stats.winsSimple,
                          stats.winsMedium,
                          stats.winsHard,
                          totalTimeStr)
    End Sub
End Class