<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShakespeareanInsult
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGenerateInsult = New System.Windows.Forms.Button()
        Me.lblInsult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerateInsult
        '
        Me.btnGenerateInsult.Font = New System.Drawing.Font("Old English Text MT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateInsult.Location = New System.Drawing.Point(13, 13)
        Me.btnGenerateInsult.Name = "btnGenerateInsult"
        Me.btnGenerateInsult.Size = New System.Drawing.Size(368, 53)
        Me.btnGenerateInsult.TabIndex = 0
        Me.btnGenerateInsult.Text = "Generate an Insult"
        Me.btnGenerateInsult.UseVisualStyleBackColor = True
        '
        'lblInsult
        '
        Me.lblInsult.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsult.Location = New System.Drawing.Point(13, 86)
        Me.lblInsult.Name = "lblInsult"
        Me.lblInsult.Size = New System.Drawing.Size(368, 66)
        Me.lblInsult.TabIndex = 1
        '
        'frmShakespeareanInsult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 284)
        Me.Controls.Add(Me.lblInsult)
        Me.Controls.Add(Me.btnGenerateInsult)
        Me.Name = "frmShakespeareanInsult"
        Me.Text = "Shakespearean Insult"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGenerateInsult As System.Windows.Forms.Button
    Friend WithEvents lblInsult As System.Windows.Forms.Label

End Class
