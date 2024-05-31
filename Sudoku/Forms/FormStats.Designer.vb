<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStats
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
        Me.lbxNames = New System.Windows.Forms.ListBox()
        Me.lbxBestTimes = New System.Windows.Forms.ListBox()
        Me.gbxRbSorting = New System.Windows.Forms.GroupBox()
        Me.rbSortByBestTimes = New System.Windows.Forms.RadioButton()
        Me.rbSortByNames = New System.Windows.Forms.RadioButton()
        Me.cbxNicknames = New System.Windows.Forms.ComboBox()
        Me.gbxRbSorting.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbxNames
        '
        Me.lbxNames.FormattingEnabled = True
        Me.lbxNames.ItemHeight = 15
        Me.lbxNames.Location = New System.Drawing.Point(12, 92)
        Me.lbxNames.Name = "lbxNames"
        Me.lbxNames.Size = New System.Drawing.Size(147, 349)
        Me.lbxNames.TabIndex = 0
        '
        'lbxBestTimes
        '
        Me.lbxBestTimes.FormattingEnabled = True
        Me.lbxBestTimes.ItemHeight = 15
        Me.lbxBestTimes.Location = New System.Drawing.Point(167, 92)
        Me.lbxBestTimes.Name = "lbxBestTimes"
        Me.lbxBestTimes.Size = New System.Drawing.Size(153, 349)
        Me.lbxBestTimes.TabIndex = 1
        '
        'gbxRbSorting
        '
        Me.gbxRbSorting.Controls.Add(Me.rbSortByBestTimes)
        Me.gbxRbSorting.Controls.Add(Me.rbSortByNames)
        Me.gbxRbSorting.Location = New System.Drawing.Point(12, 4)
        Me.gbxRbSorting.Name = "gbxRbSorting"
        Me.gbxRbSorting.Size = New System.Drawing.Size(306, 47)
        Me.gbxRbSorting.TabIndex = 2
        Me.gbxRbSorting.TabStop = False
        Me.gbxRbSorting.Text = "Order by"
        '
        'rbSortByBestTimes
        '
        Me.rbSortByBestTimes.AutoSize = True
        Me.rbSortByBestTimes.Location = New System.Drawing.Point(191, 19)
        Me.rbSortByBestTimes.Name = "rbSortByBestTimes"
        Me.rbSortByBestTimes.Size = New System.Drawing.Size(79, 19)
        Me.rbSortByBestTimes.TabIndex = 1
        Me.rbSortByBestTimes.Text = "Best times"
        Me.rbSortByBestTimes.UseVisualStyleBackColor = True
        '
        'rbSortByNames
        '
        Me.rbSortByNames.AutoSize = True
        Me.rbSortByNames.Checked = True
        Me.rbSortByNames.Location = New System.Drawing.Point(37, 19)
        Me.rbSortByNames.Name = "rbSortByNames"
        Me.rbSortByNames.Size = New System.Drawing.Size(62, 19)
        Me.rbSortByNames.TabIndex = 0
        Me.rbSortByNames.TabStop = True
        Me.rbSortByNames.Text = "Names"
        Me.rbSortByNames.UseVisualStyleBackColor = True
        '
        'cbxNicknames
        '
        Me.cbxNicknames.FormattingEnabled = True
        Me.cbxNicknames.Location = New System.Drawing.Point(12, 57)
        Me.cbxNicknames.Name = "cbxNicknames"
        Me.cbxNicknames.Size = New System.Drawing.Size(147, 23)
        Me.cbxNicknames.TabIndex = 3
        '
        'FormStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 453)
        Me.Controls.Add(Me.cbxNicknames)
        Me.Controls.Add(Me.gbxRbSorting)
        Me.Controls.Add(Me.lbxBestTimes)
        Me.Controls.Add(Me.lbxNames)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormStats"
        Me.Text = "Stats Menu"
        Me.gbxRbSorting.ResumeLayout(False)
        Me.gbxRbSorting.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbxNames As ListBox
    Friend WithEvents lbxBestTimes As ListBox
    Friend WithEvents gbxRbSorting As GroupBox
    Friend WithEvents rbSortByBestTimes As RadioButton
    Friend WithEvents rbSortByNames As RadioButton
    Friend WithEvents cbxNicknames As ComboBox
End Class
