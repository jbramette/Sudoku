Imports System.ComponentModel

Public Class FormStats

    ' On ne peut pas utiliser un dictionnaire car il ne permet pas de récupérer ses entrées facilement
    Private _stats As New List(Of (String, PlayerStats))

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPlayersStats()
        PopulateStatsControls()
    End Sub

    Private Sub LoadPlayersStats()
        For Each playerName As String In StatsManager.ListNicknames()
            Dim playerStats As New PlayerStats()

            If LoadStatsForPlayer(playerName, playerStats) Then
                _stats.Add((playerName, playerStats))
                cbxNicknames.Items.Add(playerName)
            Else
                Dim deleteFile = MsgBox($"Error loading stats for player {playerName}, remove stats file ?", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo)

                If deleteFile = MsgBoxResult.Yes Then
                    StatsManager.RemoveStatsFileForPlayer(playerName)
                End If
            End If
        Next
    End Sub

    Private Sub PopulateStatsControls()
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
        ' Reset
        lbxNames.Items.Clear()
        lbxBestTimes.Items.Clear()

        PopulateStatsControls()
    End Sub

    Private Sub ListBoxesSelectedIndexChanged(sender As ListBox, e As EventArgs) Handles lbxNames.SelectedIndexChanged, lbxBestTimes.SelectedIndexChanged
        SyncSelectedIndices(sender.SelectedIndex)

        cbxNicknames.SelectedItem = lbxNames.SelectedItem
    End Sub

    Private Sub OnFormClose(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormHome.Show()
    End Sub

    Private Sub NicknamesSelectedValueChanged(sender As Object, e As EventArgs) Handles cbxNicknames.SelectedValueChanged
        For i = 0 To lbxNames.Items.Count - 1
            If lbxNames.Items(i) = cbxNicknames.SelectedItem Then
                SyncSelectedIndices(i)
                Exit For
            End If
        Next
    End Sub

    Private Sub SyncSelectedIndices(i As Integer)
        If i < _stats.Count Then
            lbxNames.SelectedIndex = i
            lbxBestTimes.SelectedIndex = i
        End If
    End Sub
End Class