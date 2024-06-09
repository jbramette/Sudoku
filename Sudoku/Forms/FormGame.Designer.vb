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
        Me.btnGiveup = New System.Windows.Forms.Button()
        Me.lblNickname = New System.Windows.Forms.Label()
        Me.lblRemainingTime = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnGiveup
        '
        Me.btnGiveup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGiveup.Location = New System.Drawing.Point(509, 6)
        Me.btnGiveup.Name = "btnGiveup"
        Me.btnGiveup.Size = New System.Drawing.Size(112, 32)
        Me.btnGiveup.TabIndex = 0
        Me.btnGiveup.Text = "Give up"
        Me.btnGiveup.UseVisualStyleBackColor = True
        '
        'lblNickname
        '
        Me.lblNickname.AutoSize = True
        Me.lblNickname.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNickname.Location = New System.Drawing.Point(10, 10)
        Me.lblNickname.Name = "lblNickname"
        Me.lblNickname.Size = New System.Drawing.Size(99, 28)
        Me.lblNickname.TabIndex = 1
        Me.lblNickname.Text = "Nickname"
        '
        'lblRemainingTime
        '
        Me.lblRemainingTime.AutoSize = True
        Me.lblRemainingTime.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRemainingTime.Location = New System.Drawing.Point(275, 12)
        Me.lblRemainingTime.Name = "lblRemainingTime"
        Me.lblRemainingTime.Size = New System.Drawing.Size(0, 28)
        Me.lblRemainingTime.TabIndex = 2
        '
        'pnlGrid
        '
        Me.pnlGrid.Location = New System.Drawing.Point(10, 44)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(612, 525)
        Me.pnlGrid.TabIndex = 3
        '
        'FormGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(632, 578)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.lblRemainingTime)
        Me.Controls.Add(Me.lblNickname)
        Me.Controls.Add(Me.btnGiveup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sudoku"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGiveup As Button
    Friend WithEvents lblNickname As Label
    Friend WithEvents lblRemainingTime As Label
    Friend WithEvents pnlGrid As Panel
End Class
