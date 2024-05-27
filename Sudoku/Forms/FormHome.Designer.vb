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
        Me.btnQuit.Location = New System.Drawing.Point(12, 108)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnPlayGame
        '
        Me.btnPlayGame.Location = New System.Drawing.Point(309, 17)
        Me.btnPlayGame.Name = "btnPlayGame"
        Me.btnPlayGame.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayGame.TabIndex = 3
        Me.btnPlayGame.Text = "Play"
        Me.btnPlayGame.UseVisualStyleBackColor = True
        '
        'btnOpenStats
        '
        Me.btnOpenStats.Location = New System.Drawing.Point(309, 46)
        Me.btnOpenStats.Name = "btnOpenStats"
        Me.btnOpenStats.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenStats.TabIndex = 4
        Me.btnOpenStats.Text = "Stats"
        Me.btnOpenStats.UseVisualStyleBackColor = True
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(404, 143)
        Me.Controls.Add(Me.btnOpenStats)
        Me.Controls.Add(Me.btnPlayGame)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.cbxName)
        Me.Controls.Add(Me.lblNickname)
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sudoku"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNickname As Label
    Friend WithEvents cbxName As ComboBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnPlayGame As Button
    Friend WithEvents btnOpenStats As Button
End Class
