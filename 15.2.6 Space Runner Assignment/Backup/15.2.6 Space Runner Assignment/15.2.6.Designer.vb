<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpaceRunner
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
        Me.picSpaceRunner = New System.Windows.Forms.PictureBox()
        Me.btnJump = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.tmrJump = New System.Windows.Forms.Timer(Me.components)
        Me.tmr1Second = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picSpaceRunner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSpaceRunner
        '
        Me.picSpaceRunner.Location = New System.Drawing.Point(28, 13)
        Me.picSpaceRunner.Name = "picSpaceRunner"
        Me.picSpaceRunner.Size = New System.Drawing.Size(156, 182)
        Me.picSpaceRunner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpaceRunner.TabIndex = 7
        Me.picSpaceRunner.TabStop = False
        '
        'btnJump
        '
        Me.btnJump.Location = New System.Drawing.Point(109, 201)
        Me.btnJump.Name = "btnJump"
        Me.btnJump.Size = New System.Drawing.Size(75, 23)
        Me.btnJump.TabIndex = 6
        Me.btnJump.Text = "Jump"
        Me.btnJump.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(190, 201)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(28, 201)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'tmrJump
        '
        '
        'tmr1Second
        '
        '
        'frmSpaceRunner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 228)
        Me.Controls.Add(Me.picSpaceRunner)
        Me.Controls.Add(Me.btnJump)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnRun)
        Me.Name = "frmSpaceRunner"
        Me.Text = "Space Runner"
        CType(Me.picSpaceRunner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picSpaceRunner As System.Windows.Forms.PictureBox
    Friend WithEvents btnJump As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents tmrJump As System.Windows.Forms.Timer
    Friend WithEvents tmr1Second As System.Windows.Forms.Timer

End Class
