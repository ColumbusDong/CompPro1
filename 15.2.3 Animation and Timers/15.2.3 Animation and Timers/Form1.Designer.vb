<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnimation
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
        Me.components = New System.ComponentModel.Container()
        Me.PicSpaceRunner = New System.Windows.Forms.PictureBox()
        Me.btnFaster = New System.Windows.Forms.Button()
        Me.btnSlower = New System.Windows.Forms.Button()
        Me.tmrSpeed = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicSpaceRunner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicSpaceRunner
        '
        Me.PicSpaceRunner.BackColor = System.Drawing.Color.Transparent
        Me.PicSpaceRunner.Location = New System.Drawing.Point(12, 12)
        Me.PicSpaceRunner.Name = "PicSpaceRunner"
        Me.PicSpaceRunner.Size = New System.Drawing.Size(200, 200)
        Me.PicSpaceRunner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSpaceRunner.TabIndex = 0
        Me.PicSpaceRunner.TabStop = False
        '
        'btnFaster
        '
        Me.btnFaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaster.Location = New System.Drawing.Point(219, 27)
        Me.btnFaster.Name = "btnFaster"
        Me.btnFaster.Size = New System.Drawing.Size(112, 32)
        Me.btnFaster.TabIndex = 1
        Me.btnFaster.Text = "Faster"
        Me.btnFaster.UseVisualStyleBackColor = True
        '
        'btnSlower
        '
        Me.btnSlower.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlower.Location = New System.Drawing.Point(219, 120)
        Me.btnSlower.Name = "btnSlower"
        Me.btnSlower.Size = New System.Drawing.Size(112, 32)
        Me.btnSlower.TabIndex = 2
        Me.btnSlower.Text = "Slower"
        Me.btnSlower.UseVisualStyleBackColor = True
        '
        'tmrSpeed
        '
        Me.tmrSpeed.Enabled = True
        '
        'frmAnimation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(343, 225)
        Me.Controls.Add(Me.btnSlower)
        Me.Controls.Add(Me.btnFaster)
        Me.Controls.Add(Me.PicSpaceRunner)
        Me.Name = "frmAnimation"
        Me.Text = "Animation and Timers"
        CType(Me.PicSpaceRunner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicSpaceRunner As System.Windows.Forms.PictureBox
    Friend WithEvents btnFaster As System.Windows.Forms.Button
    Friend WithEvents btnSlower As System.Windows.Forms.Button
    Friend WithEvents tmrSpeed As System.Windows.Forms.Timer

End Class
