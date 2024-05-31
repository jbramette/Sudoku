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
        lbxNames = New ListBox()
        lbxBestTimes = New ListBox()
        gbxRbSorting = New GroupBox()
        rbSortByBestTimes = New RadioButton()
        rbSortByNames = New RadioButton()
        cbxNicknames = New ComboBox()
        btnDetailedStats = New Button()
        gbxRbSorting.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbxNames
        ' 
        lbxNames.FormattingEnabled = True
        lbxNames.ItemHeight = 15
        lbxNames.Location = New Point(12, 92)
        lbxNames.Name = "lbxNames"
        lbxNames.Size = New Size(147, 349)
        lbxNames.TabIndex = 0
        ' 
        ' lbxBestTimes
        ' 
        lbxBestTimes.FormattingEnabled = True
        lbxBestTimes.ItemHeight = 15
        lbxBestTimes.Location = New Point(167, 92)
        lbxBestTimes.Name = "lbxBestTimes"
        lbxBestTimes.Size = New Size(153, 349)
        lbxBestTimes.TabIndex = 1
        ' 
        ' gbxRbSorting
        ' 
        gbxRbSorting.Controls.Add(rbSortByBestTimes)
        gbxRbSorting.Controls.Add(rbSortByNames)
        gbxRbSorting.Location = New Point(12, 4)
        gbxRbSorting.Name = "gbxRbSorting"
        gbxRbSorting.Size = New Size(306, 47)
        gbxRbSorting.TabIndex = 2
        gbxRbSorting.TabStop = False
        gbxRbSorting.Text = "Order by"
        ' 
        ' rbSortByBestTimes
        ' 
        rbSortByBestTimes.AutoSize = True
        rbSortByBestTimes.Location = New Point(191, 19)
        rbSortByBestTimes.Name = "rbSortByBestTimes"
        rbSortByBestTimes.Size = New Size(79, 19)
        rbSortByBestTimes.TabIndex = 1
        rbSortByBestTimes.Text = "Best times"
        rbSortByBestTimes.UseVisualStyleBackColor = True
        ' 
        ' rbSortByNames
        ' 
        rbSortByNames.AutoSize = True
        rbSortByNames.Checked = True
        rbSortByNames.Location = New Point(37, 19)
        rbSortByNames.Name = "rbSortByNames"
        rbSortByNames.Size = New Size(62, 19)
        rbSortByNames.TabIndex = 0
        rbSortByNames.TabStop = True
        rbSortByNames.Text = "Names"
        rbSortByNames.UseVisualStyleBackColor = True
        ' 
        ' cbxNicknames
        ' 
        cbxNicknames.FormattingEnabled = True
        cbxNicknames.Location = New Point(12, 57)
        cbxNicknames.Name = "cbxNicknames"
        cbxNicknames.Size = New Size(147, 23)
        cbxNicknames.TabIndex = 3
        ' 
        ' btnDetailedStats
        ' 
        btnDetailedStats.Location = New Point(167, 57)
        btnDetailedStats.Name = "btnDetailedStats"
        btnDetailedStats.Size = New Size(151, 23)
        btnDetailedStats.TabIndex = 4
        btnDetailedStats.Text = "Player's details"
        btnDetailedStats.UseVisualStyleBackColor = True
        ' 
        ' FormStats
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(332, 453)
        Controls.Add(btnDetailedStats)
        Controls.Add(cbxNicknames)
        Controls.Add(gbxRbSorting)
        Controls.Add(lbxBestTimes)
        Controls.Add(lbxNames)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "FormStats"
        Text = "Stats Menu"
        gbxRbSorting.ResumeLayout(False)
        gbxRbSorting.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbxNames As ListBox
    Friend WithEvents lbxBestTimes As ListBox
    Friend WithEvents gbxRbSorting As GroupBox
    Friend WithEvents rbSortByBestTimes As RadioButton
    Friend WithEvents rbSortByNames As RadioButton
    Friend WithEvents cbxNicknames As ComboBox
    Friend WithEvents btnDetailedStats As Button
End Class
