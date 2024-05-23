<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGame
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btnGiveup = New Button()
        lblNickname = New Label()
        lblRemainingTime = New Label()
        pnlGrid = New Panel()
        gameTimer = New Timer(components)
        SuspendLayout()
        ' 
        ' btnGiveup
        ' 
        btnGiveup.Location = New Point(734, 685)
        btnGiveup.Margin = New Padding(3, 4, 3, 4)
        btnGiveup.Name = "btnGiveup"
        btnGiveup.Size = New Size(86, 31)
        btnGiveup.TabIndex = 0
        btnGiveup.Text = "Give up"
        btnGiveup.UseVisualStyleBackColor = True
        ' 
        ' lblNickname
        ' 
        lblNickname.AutoSize = True
        lblNickname.Location = New Point(734, 14)
        lblNickname.Name = "lblNickname"
        lblNickname.Size = New Size(75, 20)
        lblNickname.TabIndex = 1
        lblNickname.Text = "Nickname"
        ' 
        ' lblRemainingTime
        ' 
        lblRemainingTime.AutoSize = True
        lblRemainingTime.Location = New Point(734, 58)
        lblRemainingTime.Name = "lblRemainingTime"
        lblRemainingTime.Size = New Size(47, 20)
        lblRemainingTime.TabIndex = 2
        lblRemainingTime.Text = "Timer"
        ' 
        ' pnlGrid
        ' 
        pnlGrid.Location = New Point(14, 16)
        pnlGrid.Margin = New Padding(3, 4, 3, 4)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(700, 700)
        pnlGrid.TabIndex = 3
        ' 
        ' gameTimer
        ' 
        gameTimer.Interval = 1000
        ' 
        ' FormGame
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(832, 733)
        Controls.Add(pnlGrid)
        Controls.Add(lblRemainingTime)
        Controls.Add(lblNickname)
        Controls.Add(btnGiveup)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormGame"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sudoku"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnGiveup As Button
    Friend WithEvents lblNickname As Label
    Friend WithEvents lblRemainingTime As Label
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents gameTimer As Timer
End Class
