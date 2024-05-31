<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRules
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
        btnNextPage = New Button()
        btnPreviousPage = New Button()
        gbxPage = New GroupBox()
        lblPageText = New Label()
        gbxPage.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnNextPage
        ' 
        btnNextPage.Location = New Point(295, 300)
        btnNextPage.Name = "btnNextPage"
        btnNextPage.Size = New Size(70, 42)
        btnNextPage.TabIndex = 0
        btnNextPage.Text = "Next"
        btnNextPage.UseVisualStyleBackColor = True
        ' 
        ' btnPreviousPage
        ' 
        btnPreviousPage.Location = New Point(219, 300)
        btnPreviousPage.Name = "btnPreviousPage"
        btnPreviousPage.Size = New Size(70, 42)
        btnPreviousPage.TabIndex = 1
        btnPreviousPage.Text = "Previous"
        btnPreviousPage.UseVisualStyleBackColor = True
        ' 
        ' gbxPage
        ' 
        gbxPage.Controls.Add(lblPageText)
        gbxPage.Location = New Point(12, 137)
        gbxPage.Name = "gbxPage"
        gbxPage.Size = New Size(353, 157)
        gbxPage.TabIndex = 3
        gbxPage.TabStop = False
        ' 
        ' lblPageText
        ' 
        lblPageText.AutoSize = True
        lblPageText.Dock = DockStyle.Fill
        lblPageText.Location = New Point(3, 19)
        lblPageText.MaximumSize = New Size(300, 0)
        lblPageText.Name = "lblPageText"
        lblPageText.Size = New Size(41, 15)
        lblPageText.TabIndex = 0
        lblPageText.Text = "Label1"
        lblPageText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormRules
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(377, 354)
        Controls.Add(gbxPage)
        Controls.Add(btnPreviousPage)
        Controls.Add(btnNextPage)
        MaximizeBox = False
        Name = "FormRules"
        Text = "Rules"
        gbxPage.ResumeLayout(False)
        gbxPage.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnNextPage As Button
    Friend WithEvents btnPreviousPage As Button
    Friend WithEvents gbxPage As GroupBox
    Friend WithEvents lblPageText As Label
End Class
