﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStats
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvGames = New System.Windows.Forms.DataGridView()
        Me.ColumnPlayerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnBestTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnGamesPlayed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnWins = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTotalTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvGames, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGames
        '
        Me.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGames.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnPlayerName, Me.ColumnBestTime, Me.ColumnGamesPlayed, Me.ColumnWins, Me.ColumnTotalTime})
        Me.dgvGames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGames.Location = New System.Drawing.Point(0, 0)
        Me.dgvGames.Name = "dgvGames"
        Me.dgvGames.RowTemplate.Height = 25
        Me.dgvGames.Size = New System.Drawing.Size(540, 362)
        Me.dgvGames.TabIndex = 0
        '
        'ColumnPlayerName
        '
        Me.ColumnPlayerName.Frozen = True
        Me.ColumnPlayerName.HeaderText = "Player"
        Me.ColumnPlayerName.Name = "ColumnPlayerName"
        Me.ColumnPlayerName.ReadOnly = True
        '
        'ColumnBestTime
        '
        Me.ColumnBestTime.Frozen = True
        Me.ColumnBestTime.HeaderText = "Best time"
        Me.ColumnBestTime.Name = "ColumnBestTime"
        Me.ColumnBestTime.ReadOnly = True
        '
        'ColumnGamesPlayed
        '
        Me.ColumnGamesPlayed.Frozen = True
        Me.ColumnGamesPlayed.HeaderText = "Games"
        Me.ColumnGamesPlayed.Name = "ColumnGamesPlayed"
        Me.ColumnGamesPlayed.ReadOnly = True
        '
        'ColumnWins
        '
        Me.ColumnWins.Frozen = True
        Me.ColumnWins.HeaderText = "Wins"
        Me.ColumnWins.Name = "ColumnWins"
        Me.ColumnWins.ReadOnly = True
        '
        'ColumnTotalTime
        '
        Me.ColumnTotalTime.Frozen = True
        Me.ColumnTotalTime.HeaderText = "Total time"
        Me.ColumnTotalTime.Name = "ColumnTotalTime"
        Me.ColumnTotalTime.ReadOnly = True
        '
        'FormStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 362)
        Me.Controls.Add(Me.dgvGames)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormStats"
        Me.Text = "Stats Menu"
        CType(Me.dgvGames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvGames As DataGridView
    Friend WithEvents ColumnPlayerName As DataGridViewTextBoxColumn
    Friend WithEvents ColumnBestTime As DataGridViewTextBoxColumn
    Friend WithEvents ColumnGamesPlayed As DataGridViewTextBoxColumn
    Friend WithEvents ColumnWins As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotalTime As DataGridViewTextBoxColumn
End Class