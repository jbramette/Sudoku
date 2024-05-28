Imports System.IO

Module StatsManager

    Private Const STATS_DIR As String = "stats/"
    Private Const STATS_EXT As String = "stats"
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
        Dim paths As String() = Directory.GetFiles(STATS_DIR, "*." & STATS_EXT)

        For i = 0 To paths.Length - 1
            paths(i) = Path.GetFileNameWithoutExtension(paths(i))
        Next

        Return paths
    End Function

    ' Charge les statistiques globales pour un certain joueur
    Public Function LoadStatsForPlayer(nickname As String, ByRef stats As PlayerStats) As Boolean
        Dim filePath As String = StatsFilePath(nickname)

        Try
            Using reader As New StreamReader(filePath)
                Dim line As String = reader.ReadLine()

                If line Is Nothing Then
                    Return False
                End If

                stats.recordTime = Integer.MaxValue

                While line IsNot Nothing
                    Dim gameStats As GameStats

                    If Not Deserialize(line, gameStats) Then
                        Return False
                    End If

                    stats.gamesPlayed += 1
                    stats.totalPlayTime += gameStats.timePlayed

                    If gameStats.won Then
                        stats.totalWin += 1
                    End If

                    If gameStats.timePlayed < stats.recordTime Then
                        stats.recordTime = gameStats.timePlayed
                    End If

                    line = reader.ReadLine()
                End While
            End Using
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    ' Met à jour ou créer la sauvegarde des statistiques
    ' pour un joueur
    Public Sub SaveGameStatsForPlayer(stats As GameStats, nickname As String)
        ' Créé ou ignore
        Directory.CreateDirectory(STATS_DIR)

        Dim filePath As String = StatsFilePath(nickname)
        Dim contents As String = Serialize(stats)

        ' Créé ou ajoute
        File.AppendAllText(filePath, contents)
    End Sub

    Private Function StatsFilePath(nickname As String) As String
        Return $"{STATS_DIR}/{nickname}.{STATS_EXT}"
    End Function

    ' Convert a GameStats structure to a string
    Private Function Serialize(stats As GameStats) As String
        Return $"{stats.timePlayed} {stats.won}{Environment.NewLine}"
    End Function

    ' Convert line from save file to a GameStats structure
    Private Function Deserialize(content As String, ByRef stats As GameStats) As Boolean
        Try
            Dim varCount As Integer = 2
            Dim vars As String() = Split(content, Limit:=varCount)

            ' Validate the split result
            If vars.Length <> varCount Then
                Return False
            End If

            ' Parse the timePlayed value
            If Not Integer.TryParse(vars(0), stats.timePlayed) Then
                Return False
            End If

            ' Parse the won value
            Dim wonValue As Boolean
            If Not Boolean.TryParse(vars(1), wonValue) Then
                Return False
            End If

            stats.won = wonValue
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

End Module
