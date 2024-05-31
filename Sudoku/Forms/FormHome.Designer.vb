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
        lblNickname.Location = New Point(14, 28)
        lblNickname.Name = "lblNickname"
        lblNickname.Size = New Size(78, 20)
        lblNickname.TabIndex = 0
        lblNickname.Text = "Nickname:"
        ' 
        ' cbxName
        ' 
        cbxName.FormattingEnabled = True
        cbxName.Location = New Point(94, 24)
        cbxName.Margin = New Padding(3, 4, 3, 4)
        cbxName.Name = "cbxName"
        cbxName.Size = New Size(222, 28)
        cbxName.TabIndex = 1
        ' 
        ' btnQuit
        ' 
        btnQuit.Location = New Point(341, 151)
        btnQuit.Margin = New Padding(3, 4, 3, 4)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(86, 31)
        btnQuit.TabIndex = 2
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' btnPlayGame
        ' 
        btnPlayGame.Location = New Point(341, 68)
        btnPlayGame.Margin = New Padding(3, 4, 3, 4)
        btnPlayGame.Name = "btnPlayGame"
        btnPlayGame.Size = New Size(86, 31)
        btnPlayGame.TabIndex = 3
        btnPlayGame.Text = "Play"
        btnPlayGame.UseVisualStyleBackColor = True
        ' 
        ' btnOpenStats
        ' 
        btnOpenStats.Location = New Point(341, 112)
        btnOpenStats.Margin = New Padding(3, 4, 3, 4)
        btnOpenStats.Name = "btnOpenStats"
        btnOpenStats.Size = New Size(86, 31)
        btnOpenStats.TabIndex = 4
        btnOpenStats.Text = "Stats"
        btnOpenStats.UseVisualStyleBackColor = True
        ' 
        ' rbModeSimple
        ' 
        rbModeSimple.AutoSize = True
        rbModeSimple.Checked = True
        rbModeSimple.Location = New Point(16, 51)
        rbModeSimple.Margin = New Padding(3, 4, 3, 4)
        rbModeSimple.Name = "rbModeSimple"
        rbModeSimple.Size = New Size(76, 24)
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
        gbxDifficulty.Location = New Point(14, 68)
        gbxDifficulty.Margin = New Padding(3, 4, 3, 4)
        gbxDifficulty.Name = "gbxDifficulty"
        gbxDifficulty.Padding = New Padding(3, 4, 3, 4)
        gbxDifficulty.Size = New Size(321, 114)
        gbxDifficulty.TabIndex = 6
        gbxDifficulty.TabStop = False
        gbxDifficulty.Text = "Difficulty"
        ' 
        ' rbModeHard
        ' 
        rbModeHard.AutoSize = True
        rbModeHard.Location = New Point(239, 51)
        rbModeHard.Margin = New Padding(3, 4, 3, 4)
        rbModeHard.Name = "rbModeHard"
        rbModeHard.Size = New Size(63, 24)
        rbModeHard.TabIndex = 7
        rbModeHard.TabStop = True
        rbModeHard.Text = "Hard"
        rbModeHard.UseVisualStyleBackColor = True
        ' 
        ' rbModeMedium
        ' 
        rbModeMedium.AutoSize = True
        rbModeMedium.Location = New Point(120, 51)
        rbModeMedium.Margin = New Padding(3, 4, 3, 4)
        rbModeMedium.Name = "rbModeMedium"
        rbModeMedium.Size = New Size(85, 24)
        rbModeMedium.TabIndex = 6
        rbModeMedium.Text = "Medium"
        rbModeMedium.UseVisualStyleBackColor = True
        ' 
        ' btnRules
        ' 
        btnRules.Location = New Point(341, 24)
        btnRules.Margin = New Padding(3, 4, 3, 4)
        btnRules.Name = "btnRules"
        btnRules.Size = New Size(86, 31)
        btnRules.TabIndex = 7
        btnRules.Text = "Rules"
        btnRules.UseVisualStyleBackColor = True
        ' 
        ' FormHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(439, 194)
        Controls.Add(btnRules)
        Controls.Add(gbxDifficulty)
        Controls.Add(btnOpenStats)
        Controls.Add(btnPlayGame)
        Controls.Add(btnQuit)
        Controls.Add(cbxName)
        Controls.Add(lblNickname)
        Margin = New Padding(3, 4, 3, 4)
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
