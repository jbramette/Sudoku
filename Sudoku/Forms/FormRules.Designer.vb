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
        lblPageText = New Label()
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
        ' lblPageText
        ' 
        lblPageText.AutoSize = True
        lblPageText.Location = New Point(118, 165)
        lblPageText.Name = "lblPageText"
        lblPageText.Size = New Size(0, 15)
        lblPageText.TabIndex = 2
        lblPageText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormRules
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(377, 354)
        Controls.Add(lblPageText)
        Controls.Add(btnPreviousPage)
        Controls.Add(btnNextPage)
        Name = "FormRules"
        Text = "Rules"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNextPage As Button
    Friend WithEvents btnPreviousPage As Button
    Friend WithEvents lblPageText As Label
End Class
