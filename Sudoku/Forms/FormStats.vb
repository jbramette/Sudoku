Imports System.ComponentModel

Public Class FormStats

    ' On ne peut pas utiliser un dictionnaire car il ne permet pas de récupérer ses entrées facilement
    Private _stats As New List(Of (String, PlayerStats))

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPlayersStats()
        PopulateStatsListBoxes()
    End Sub

    Private Sub LoadPlayersStats()
        For Each playerName As String In StatsManager.ListNicknames()
            Dim playerStats As New PlayerStats()

            If LoadStatsForPlayer(playerName, playerStats) Then
                _stats.Add((playerName, playerStats))
            Else
                Dim deleteFile = MsgBox($"Error loading stats for player {playerName}, remove stats file ?", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo)

                If deleteFile = MsgBoxResult.Yes Then
                    StatsManager.RemoveStatsFileForPlayer(playerName)
                End If
            End If
        Next
    End Sub

    Private Sub PopulateStatsListBoxes()
        ' Reset
        lbxNames.Items.Clear()
        lbxBestTimes.Items.Clear()

        ' Sort based on players names or best times
        If rbSortByNames.Checked Then
            _stats.Sort(Function(x, y) x.Item1.CompareTo(y.Item1))
        Else
            _stats.Sort(Function(x, y) x.Item2.recordTime.CompareTo(y.Item2.recordTime))
        End If

        For Each pair In _stats
            Dim nickname As String = pair.Item1
            Dim recordTime As Integer = pair.Item2.recordTime

            lbxNames.Items.Add(nickname)
            lbxBestTimes.Items.Add(TimeSpan.FromSeconds(recordTime).ToString())
        Next
    End Sub

    Private Sub OnSortModeCheckedChanged(sender As Object, e As EventArgs) Handles rbSortByNames.CheckedChanged
        PopulateStatsListBoxes()
    End Sub

    Private Sub ListBoxesSelectedIndexChanged(sender As ListBox, e As EventArgs) Handles lbxNames.SelectedIndexChanged, lbxBestTimes.SelectedIndexChanged
        lbxNames.SelectedIndex = sender.SelectedIndex
        lbxBestTimes.SelectedIndex = sender.SelectedIndex
    End Sub

    Private Sub FormStats_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormHome.Show()
    End Sub
End Class