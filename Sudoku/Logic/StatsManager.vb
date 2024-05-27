Imports System.IO

Module StatsManager

    Private Const STATS_DIR As String = "stats/"
    Private Const STATS_EXT As String = ".stats"
    Private Const STATS_SEP As String = " "

    Structure PlayerStats
        ' Pseudo du joueur
        Public nickname As String

        ' Meilleur temps du joueur
        Public recordTime As Integer

        ' temps total cumulé sur toutes les parties
        Public totalPlayTime As Integer

        ' nombre de partie jouées
        Public gamesPlayed As Integer

        ' nombre de partie gagnées
        Public totalWin As Integer
    End Structure

    Structure GameStats
        Public timePlayed As Integer
        Public won As Boolean
    End Structure

    ' Charge les statistiques du joueur selon son pseudo
    Public Function LoadStatsForPlayer(nickname As String) As PlayerStats

    End Function

    ' Met à jour ou créer la sauvegarde des statistiques
    ' pour un joueur
    Public Sub AddGameStatsForPlayer(stats As GameStats, nickname As String)
        Directory.CreateDirectory(STATS_DIR)

        Dim fileName As String = nickname & STATS_EXT
        Dim contents As String = Serialize(stats)

        File.AppendAllText(fileName, contents)
    End Sub

    Private Function Serialize(stats As GameStats) As String
        Return stats.timePlayed & STATS_SEP & stats.won
    End Function

    Private Function Deserialize(content As String) As GameStats
        Dim stats As GameStats

        Dim split As String() = content.Split(STATS_SEP, 2)

    End Function

End Module
