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
        lblNickname = New Label()
        cbxName = New ComboBox()
        btnQuit = New Button()
        btnPlayGame = New Button()
        btnOpenStats = New Button()
        rbModeSimple = New RadioButton()
        gbxDifficulty = New GroupBox()
        rbModeHard = New RadioButton()
        rbModeMedium = New RadioButton()
        btnRules = New Button()
        gbxDifficulty.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNickname
        ' 
        lblNickname.AutoSize = True
        lblNickname.Location = New Point(12, 21)
        lblNickname.Name = "lblNickname"
        lblNickname.Size = New Size(64, 15)
        lblNickname.TabIndex = 0
        lblNickname.Text = "Nickname:"
        ' 
        ' cbxName
        ' 
        cbxName.FormattingEnabled = True
        cbxName.Location = New Point(82, 18)
        cbxName.Name = "cbxName"
        cbxName.Size = New Size(195, 23)
        cbxName.TabIndex = 1
        ' 
        ' btnQuit
        ' 
        btnQuit.Location = New Point(12, 157)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(75, 23)
        btnQuit.TabIndex = 2
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' btnPlayGame
        ' 
        btnPlayGame.Location = New Point(353, 157)
        btnPlayGame.Name = "btnPlayGame"
        btnPlayGame.Size = New Size(75, 23)
        btnPlayGame.TabIndex = 3
        btnPlayGame.Text = "Play"
        btnPlayGame.UseVisualStyleBackColor = True
        ' 
        ' btnOpenStats
        ' 
        btnOpenStats.Location = New Point(353, 128)
        btnOpenStats.Name = "btnOpenStats"
        btnOpenStats.Size = New Size(75, 23)
        btnOpenStats.TabIndex = 4
        btnOpenStats.Text = "Stats"
        btnOpenStats.UseVisualStyleBackColor = True
        ' 
        ' rbModeSimple
        ' 
        rbModeSimple.AutoSize = True
        rbModeSimple.Checked = True
        rbModeSimple.Location = New Point(14, 33)
        rbModeSimple.Name = "rbModeSimple"
        rbModeSimple.Size = New Size(61, 19)
        rbModeSimple.TabIndex = 5
        rbModeSimple.TabStop = True
        rbModeSimple.Text = "Simple"
        rbModeSimple.UseVisualStyleBackColor = True
        ' 
        ' gbxDifficulty
        ' 
        gbxDifficulty.Controls.Add(rbModeHard)
        gbxDifficulty.Controls.Add(rbModeMedium)
        gbxDifficulty.Controls.Add(rbModeSimple)
        gbxDifficulty.Location = New Point(12, 51)
        gbxDifficulty.Name = "gbxDifficulty"
        gbxDifficulty.Size = New Size(265, 75)
        gbxDifficulty.TabIndex = 6
        gbxDifficulty.TabStop = False
        gbxDifficulty.Text = "Difficulty"
        ' 
        ' rbModeHard
        ' 
        rbModeHard.AutoSize = True
        rbModeHard.Location = New Point(196, 33)
        rbModeHard.Name = "rbModeHard"
        rbModeHard.Size = New Size(51, 19)
        rbModeHard.TabIndex = 7
        rbModeHard.TabStop = True
        rbModeHard.Text = "Hard"
        rbModeHard.UseVisualStyleBackColor = True
        ' 
        ' rbModeMedium
        ' 
        rbModeMedium.AutoSize = True
        rbModeMedium.Location = New Point(97, 33)
        rbModeMedium.Name = "rbModeMedium"
        rbModeMedium.Size = New Size(70, 19)
        rbModeMedium.TabIndex = 6
        rbModeMedium.Text = "Medium"
        rbModeMedium.UseVisualStyleBackColor = True
        ' 
        ' btnRules
        ' 
        btnRules.Location = New Point(353, 18)
        btnRules.Name = "btnRules"
        btnRules.Size = New Size(75, 23)
        btnRules.TabIndex = 7
        btnRules.Text = "Rules"
        btnRules.UseVisualStyleBackColor = True
        ' 
        ' FormHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(440, 192)
        Controls.Add(btnRules)
        Controls.Add(gbxDifficulty)
        Controls.Add(btnOpenStats)
        Controls.Add(btnPlayGame)
        Controls.Add(btnQuit)
        Controls.Add(cbxName)
        Controls.Add(lblNickname)
        MaximizeBox = False
        Name = "FormHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sudoku"
        gbxDifficulty.ResumeLayout(False)
        gbxDifficulty.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents btnRules As Button
End Class
