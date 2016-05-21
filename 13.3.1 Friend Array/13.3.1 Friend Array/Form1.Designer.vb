<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnFriends = New System.Windows.Forms.Button()
        Me.lblFriends = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFriends
        '
        Me.btnFriends.Location = New System.Drawing.Point(66, 32)
        Me.btnFriends.Name = "btnFriends"
        Me.btnFriends.Size = New System.Drawing.Size(159, 39)
        Me.btnFriends.TabIndex = 0
        Me.btnFriends.Text = "Show Your Top 5 Friends"
        Me.btnFriends.UseVisualStyleBackColor = True
        '
        'lblFriends
        '
        Me.lblFriends.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFriends.Location = New System.Drawing.Point(66, 85)
        Me.lblFriends.Name = "lblFriends"
        Me.lblFriends.Size = New System.Drawing.Size(159, 178)
        Me.lblFriends.TabIndex = 1
        Me.lblFriends.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 301)
        Me.Controls.Add(Me.lblFriends)
        Me.Controls.Add(Me.btnFriends)
        Me.Name = "Form1"
        Me.Text = "Best Friends"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFriends As System.Windows.Forms.Button
    Friend WithEvents lblFriends As System.Windows.Forms.Label

End Class
