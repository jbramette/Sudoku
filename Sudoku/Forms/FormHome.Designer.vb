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
        btnShowScores = New Button()
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
        btnQuit.Location = New Point(14, 144)
        btnQuit.Margin = New Padding(3, 4, 3, 4)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(86, 31)
        btnQuit.TabIndex = 2
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' btnPlayGame
        ' 
        btnPlayGame.Location = New Point(353, 23)
        btnPlayGame.Margin = New Padding(3, 4, 3, 4)
        btnPlayGame.Name = "btnPlayGame"
        btnPlayGame.Size = New Size(86, 31)
        btnPlayGame.TabIndex = 3
        btnPlayGame.Text = "Play"
        btnPlayGame.UseVisualStyleBackColor = True
        ' 
        ' btnShowScores
        ' 
        btnShowScores.Location = New Point(353, 61)
        btnShowScores.Margin = New Padding(3, 4, 3, 4)
        btnShowScores.Name = "btnShowScores"
        btnShowScores.Size = New Size(86, 31)
        btnShowScores.TabIndex = 4
        btnShowScores.Text = "Scores"
        btnShowScores.UseVisualStyleBackColor = True
        ' 
        ' FormHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(462, 191)
        Controls.Add(btnShowScores)
        Controls.Add(btnPlayGame)
        Controls.Add(btnQuit)
        Controls.Add(cbxName)
        Controls.Add(lblNickname)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sudoku"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblNickname As Label
    Friend WithEvents cbxName As ComboBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnPlayGame As Button
    Friend WithEvents btnShowScores As Button
End Class
