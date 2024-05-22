<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGame
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
        Me.components = New System.ComponentModel.Container()
        Me.btnGiveup = New System.Windows.Forms.Button()
        Me.lblNickname = New System.Windows.Forms.Label()
        Me.lblRemainingTime = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnGiveup
        '
        Me.btnGiveup.Location = New System.Drawing.Point(713, 489)
        Me.btnGiveup.Name = "btnGiveup"
        Me.btnGiveup.Size = New System.Drawing.Size(75, 23)
        Me.btnGiveup.TabIndex = 0
        Me.btnGiveup.Text = "Give up"
        Me.btnGiveup.UseVisualStyleBackColor = True
        '
        'lblNickname
        '
        Me.lblNickname.AutoSize = True
        Me.lblNickname.Location = New System.Drawing.Point(602, 9)
        Me.lblNickname.Name = "lblNickname"
        Me.lblNickname.Size = New System.Drawing.Size(41, 15)
        Me.lblNickname.TabIndex = 1
        Me.lblNickname.Text = "Label1"
        '
        'lblRemainingTime
        '
        Me.lblRemainingTime.AutoSize = True
        Me.lblRemainingTime.Location = New System.Drawing.Point(602, 41)
        Me.lblRemainingTime.Name = "lblRemainingTime"
        Me.lblRemainingTime.Size = New System.Drawing.Size(41, 15)
        Me.lblRemainingTime.TabIndex = 2
        Me.lblRemainingTime.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 500)
        Me.Panel1.TabIndex = 3
        '
        'gameTimer
        '
        Me.gameTimer.Interval = 1000
        '
        'FormGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 524)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblRemainingTime)
        Me.Controls.Add(Me.lblNickname)
        Me.Controls.Add(Me.btnGiveup)
        Me.Name = "FormGame"
        Me.Text = "Sudoku"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGiveup As Button
    Friend WithEvents lblNickname As Label
    Friend WithEvents lblRemainingTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gameTimer As Timer
End Class
