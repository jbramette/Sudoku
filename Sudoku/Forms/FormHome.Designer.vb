<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Me.lblNickname = New System.Windows.Forms.Label()
        Me.cbxName = New System.Windows.Forms.ComboBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnPlayGame = New System.Windows.Forms.Button()
        Me.btnOpenStats = New System.Windows.Forms.Button()
        Me.rbModeSimple = New System.Windows.Forms.RadioButton()
        Me.gbxDifficulty = New System.Windows.Forms.GroupBox()
        Me.rbModeMedium = New System.Windows.Forms.RadioButton()
        Me.rbModeHard = New System.Windows.Forms.RadioButton()
        Me.gbxDifficulty.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNickname
        '
        Me.lblNickname.AutoSize = True
        Me.lblNickname.Location = New System.Drawing.Point(12, 21)
        Me.lblNickname.Name = "lblNickname"
        Me.lblNickname.Size = New System.Drawing.Size(64, 15)
        Me.lblNickname.TabIndex = 0
        Me.lblNickname.Text = "Nickname:"
        '
        'cbxName
        '
        Me.cbxName.FormattingEnabled = True
        Me.cbxName.Location = New System.Drawing.Point(82, 18)
        Me.cbxName.Name = "cbxName"
        Me.cbxName.Size = New System.Drawing.Size(195, 23)
        Me.cbxName.TabIndex = 1
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(12, 157)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnPlayGame
        '
        Me.btnPlayGame.Location = New System.Drawing.Point(353, 157)
        Me.btnPlayGame.Name = "btnPlayGame"
        Me.btnPlayGame.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayGame.TabIndex = 3
        Me.btnPlayGame.Text = "Play"
        Me.btnPlayGame.UseVisualStyleBackColor = True
        '
        'btnOpenStats
        '
        Me.btnOpenStats.Location = New System.Drawing.Point(353, 128)
        Me.btnOpenStats.Name = "btnOpenStats"
        Me.btnOpenStats.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenStats.TabIndex = 4
        Me.btnOpenStats.Text = "Stats"
        Me.btnOpenStats.UseVisualStyleBackColor = True
        '
        'rbModeSimple
        '
        Me.rbModeSimple.AutoSize = True
        Me.rbModeSimple.Checked = True
        Me.rbModeSimple.Location = New System.Drawing.Point(14, 33)
        Me.rbModeSimple.Name = "rbModeSimple"
        Me.rbModeSimple.Size = New System.Drawing.Size(61, 19)
        Me.rbModeSimple.TabIndex = 5
        Me.rbModeSimple.TabStop = True
        Me.rbModeSimple.Text = "Simple"
        Me.rbModeSimple.UseVisualStyleBackColor = True
        '
        'gbxDifficulty
        '
        Me.gbxDifficulty.Controls.Add(Me.rbModeHard)
        Me.gbxDifficulty.Controls.Add(Me.rbModeMedium)
        Me.gbxDifficulty.Controls.Add(Me.rbModeSimple)
        Me.gbxDifficulty.Location = New System.Drawing.Point(12, 51)
        Me.gbxDifficulty.Name = "gbxDifficulty"
        Me.gbxDifficulty.Size = New System.Drawing.Size(265, 75)
        Me.gbxDifficulty.TabIndex = 6
        Me.gbxDifficulty.TabStop = False
        Me.gbxDifficulty.Text = "Difficulty"
        '
        'rbModeMedium
        '
        Me.rbModeMedium.AutoSize = True
        Me.rbModeMedium.Location = New System.Drawing.Point(97, 33)
        Me.rbModeMedium.Name = "rbModeMedium"
        Me.rbModeMedium.Size = New System.Drawing.Size(70, 19)
        Me.rbModeMedium.TabIndex = 6
        Me.rbModeMedium.Text = "Medium"
        Me.rbModeMedium.UseVisualStyleBackColor = True
        '
        'rbModeHard
        '
        Me.rbModeHard.AutoSize = True
        Me.rbModeHard.Location = New System.Drawing.Point(196, 33)
        Me.rbModeHard.Name = "rbModeHard"
        Me.rbModeHard.Size = New System.Drawing.Size(51, 19)
        Me.rbModeHard.TabIndex = 7
        Me.rbModeHard.TabStop = True
        Me.rbModeHard.Text = "Hard"
        Me.rbModeHard.UseVisualStyleBackColor = True
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(440, 192)
        Me.Controls.Add(Me.gbxDifficulty)
        Me.Controls.Add(Me.btnOpenStats)
        Me.Controls.Add(Me.btnPlayGame)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.cbxName)
        Me.Controls.Add(Me.lblNickname)
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sudoku"
        Me.gbxDifficulty.ResumeLayout(False)
        Me.gbxDifficulty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNickname As Label
    Friend WithEvents cbxName As ComboBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnPlayGame As Button
    Friend WithEvents btnOpenStats As Button
    Friend WithEvents rbModeSimple As RadioButton
    Friend WithEvents gbxDifficulty As GroupBox
    Friend WithEvents rbModeHard As RadioButton
    Friend WithEvents rbModeMedium As RadioButton
End Class
