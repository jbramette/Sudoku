﻿Imports System.IO

Module StatsManager

    Private Const STATS_DIR As String = "stats/"
    Private Const STATS_EXT As String = "stats"

    Structure PlayerStats
        ' Pseudo du joueur
        Public nickname As String

        ' Meilleur temps du joueur
        Public recordTime As Integer

        ' temps total cumulé sur toutes les parties
        Public totalPlayTime As Integer

        ' nombre de partie jouées
        Public gamesPlayed As Integer

        ' nombre de partie gagnées par difficulté
        Public winsSimple As Integer
        Public winsMedium As Integer
        Public winsHard As Integer

        Public Function GetTotalWins() As Integer
            Return winsSimple + winsMedium + winsHard
        End Function
    End Structure

    Structure GameStats
        Public timePlayed As Integer
        Public won As Boolean
        Public difficulty As PuzzleDifficulty
    End Structure

    ' Retourne une liste de tous les joueurs qui ont joué au jeu
    Public Function ListNicknames() As String()
        ' Create directory if it does not exist yet
        Directory.CreateDirectory(STATS_DIR)

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
        Dim dataRead As Boolean = False

        stats.recordTime = Integer.MaxValue

        Try
            Using sr As New StreamReader(filePath)
                Dim line As String

                Do While sr.Peek() >= 0
                    line = sr.ReadLine().Trim()

                    If String.IsNullOrWhiteSpace(line) Then
                        Continue Do
                    End If

                    Dim gameStats As GameStats

                    If Not Deserialize(line, gameStats) Then
                        Return False
                    End If

                    dataRead = True

                    stats.gamesPlayed += 1
                    stats.totalPlayTime += gameStats.timePlayed

                    If gameStats.won Then
                        Select Case gameStats.difficulty
                            Case PuzzleDifficulty.Easy
                                stats.winsSimple += 1
                            Case PuzzleDifficulty.Medium
                                stats.winsMedium += 1
                            Case PuzzleDifficulty.Hard
                                stats.winsHard += 1
                        End Select
                    End If

                    If gameStats.timePlayed < stats.recordTime Then
                        stats.recordTime = gameStats.timePlayed
                    End If
                Loop
            End Using
        Catch ex As Exception
            Return False
        End Try

        Return dataRead
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

    Public Sub RemoveStatsFileForPlayer(nickname As String)
        File.Delete(StatsFilePath(nickname))
    End Sub

    Private Function StatsFilePath(nickname As String) As String
        Return $"{STATS_DIR}/{nickname}.{STATS_EXT}"
    End Function

    ' Convert a GameStats structure to a string
    Private Function Serialize(stats As GameStats) As String
        Return $"{stats.timePlayed} {stats.won} {stats.difficulty}{Environment.NewLine}"
    End Function

    ' Convert line from save file to a GameStats structure
    Private Function Deserialize(content As String, ByRef stats As GameStats) As Boolean
        Try
            Dim varCount As Integer = 3
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
            If Not Boolean.TryParse(vars(1), stats.won) Then
                Return False
            End If

            ' Parse the difficulty value
            If Not PuzzleDifficulty.TryParse(vars(2), stats.difficulty) Then
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

End Module
