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
        btnGiveup.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnGiveup.Location = New Point(582, 8)
        btnGiveup.Margin = New Padding(3, 4, 3, 4)
        btnGiveup.Name = "btnGiveup"
        btnGiveup.Size = New Size(128, 43)
        btnGiveup.TabIndex = 0
        btnGiveup.Text = "Give up"
        btnGiveup.UseVisualStyleBackColor = True
        ' 
        ' lblNickname
        ' 
        lblNickname.AutoSize = True
        lblNickname.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        lblNickname.Location = New Point(12, 13)
        lblNickname.Name = "lblNickname"
        lblNickname.Size = New Size(126, 35)
        lblNickname.TabIndex = 1
        lblNickname.Text = "Nickname"
        ' 
        ' lblRemainingTime
        ' 
        lblRemainingTime.AutoSize = True
        lblRemainingTime.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        lblRemainingTime.Location = New Point(314, 16)
        lblRemainingTime.Name = "lblRemainingTime"
        lblRemainingTime.Size = New Size(0, 35)
        lblRemainingTime.TabIndex = 2
        ' 
        ' pnlGrid
        ' 
        pnlGrid.Location = New Point(12, 59)
        pnlGrid.Margin = New Padding(3, 4, 3, 4)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(699, 700)
        pnlGrid.TabIndex = 3
        ' 
        ' FormGame
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(722, 771)
        Controls.Add(pnlGrid)
        Controls.Add(lblRemainingTime)
        Controls.Add(lblNickname)
        Controls.Add(btnGiveup)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
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
