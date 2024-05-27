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

        '...
    End Structure

    ' Retourne une liste de tous les joueurs qui ont joué au jeu
    Public Function ListNicknames() As String()
        ' Retrieve the paths of all stats file
        Dim paths As String() = Directory.GetFiles(STATS_DIR, "*" & STATS_EXT)

        For i = 0 To paths.Length - 1
            paths(i) = Path.GetFileNameWithoutExtension(paths(i))
        Next

        Return paths
    End Function

    ' Charge les statistiques du joueur selon son pseudo
    Public Function LoadStatsForPlayer(nickname As String) As PlayerStats
        ' Deserialize()
    End Function

    ' Met à jour ou créer la sauvegarde des statistiques
    ' pour un joueur
    Public Sub AddGameStatsForPlayer(stats As GameStats, nickname As String)
        ' Créé ou ignore
        Directory.CreateDirectory(STATS_DIR)
        Environment.CurrentDirectory = STATS_DIR

        Dim fileName As String = nickname & STATS_EXT
        Dim contents As String = Serialize(stats)

        ' Créé ou ajoute
        File.AppendAllText(fileName, contents)
    End Sub

    ' Convert a GameStats structure to a string
    Private Function Serialize(stats As GameStats) As String
        Return stats.timePlayed & STATS_SEP & STATS_SEP & stats.won & Environment.NewLine
    End Function

    ' Convert line from save file to a GameStats structure
    Private Function Deserialize(content As String, ByRef stats As GameStats) As Boolean
        Try
            Dim varCount As Integer = 2
            Dim vars As String() = Split(content, STATS_SEP, varCount)

            ' Validate the split result
            If vars.Length <> varCount Then
                Return False
            End If

            ' Parse the timePlayed value
            If Not Integer.TryParse(vars(0), stats.timePlayed) Then
                Return False
            End If

            ' Parse the won value
            Dim wonValue As Integer
            If Not Integer.TryParse(vars(1), wonValue) Then
                Return False
            End If

            stats.won = (wonValue = 1)

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Module
