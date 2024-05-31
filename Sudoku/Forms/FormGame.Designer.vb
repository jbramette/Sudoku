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
        btnGiveup = New Button()
        lblNickname = New Label()
        lblRemainingTime = New Label()
        pnlGrid = New Panel()
        SuspendLayout()
        ' 
        ' btnGiveup
        ' 
        btnGiveup.Location = New Point(642, 514)
        btnGiveup.Name = "btnGiveup"
        btnGiveup.Size = New Size(75, 23)
        btnGiveup.TabIndex = 0
        btnGiveup.Text = "Give up"
        btnGiveup.UseVisualStyleBackColor = True
        ' 
        ' lblNickname
        ' 
        lblNickname.AutoSize = True
        lblNickname.Location = New Point(642, 10)
        lblNickname.Name = "lblNickname"
        lblNickname.Size = New Size(61, 15)
        lblNickname.TabIndex = 1
        lblNickname.Text = "Nickname"
        ' 
        ' lblRemainingTime
        ' 
        lblRemainingTime.AutoSize = True
        lblRemainingTime.Location = New Point(642, 44)
        lblRemainingTime.Name = "lblRemainingTime"
        lblRemainingTime.Size = New Size(0, 15)
        lblRemainingTime.TabIndex = 2
        ' 
        ' pnlGrid
        ' 
        pnlGrid.Location = New Point(12, 12)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(612, 525)
        pnlGrid.TabIndex = 3
        ' 
        ' FormGame
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(728, 550)
        Controls.Add(pnlGrid)
        Controls.Add(lblRemainingTime)
        Controls.Add(lblNickname)
        Controls.Add(btnGiveup)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
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
End Class
