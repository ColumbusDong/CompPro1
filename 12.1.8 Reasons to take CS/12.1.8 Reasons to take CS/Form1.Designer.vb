<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputerScience
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
        Me.btnShowReasons = New System.Windows.Forms.Button()
        Me.lstReasons = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnShowReasons
        '
        Me.btnShowReasons.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowReasons.Location = New System.Drawing.Point(12, 21)
        Me.btnShowReasons.Name = "btnShowReasons"
        Me.btnShowReasons.Size = New System.Drawing.Size(367, 39)
        Me.btnShowReasons.TabIndex = 0
        Me.btnShowReasons.Text = "Why take Computer Science?"
        Me.btnShowReasons.UseVisualStyleBackColor = True
        '
        'lstReasons
        '
        Me.lstReasons.BackColor = System.Drawing.SystemColors.Menu
        Me.lstReasons.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstReasons.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReasons.FormattingEnabled = True
        Me.lstReasons.ItemHeight = 23
        Me.lstReasons.Location = New System.Drawing.Point(12, 81)
        Me.lstReasons.Name = "lstReasons"
        Me.lstReasons.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstReasons.Size = New System.Drawing.Size(367, 161)
        Me.lstReasons.TabIndex = 1
        '
        'frmComputerScience
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 293)
        Me.Controls.Add(Me.lstReasons)
        Me.Controls.Add(Me.btnShowReasons)
        Me.Name = "frmComputerScience"
        Me.Text = "Why take Computer Science?"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShowReasons As System.Windows.Forms.Button
    Friend WithEvents lstReasons As System.Windows.Forms.ListBox

End Class
