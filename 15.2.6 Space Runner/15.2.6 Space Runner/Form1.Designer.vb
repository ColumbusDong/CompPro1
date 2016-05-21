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
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnJump = New System.Windows.Forms.Button()
        Me.tmrSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.PicSpaceRunner = New System.Windows.Forms.PictureBox()
        Me.tmrRun = New System.Windows.Forms.Timer(Me.components)
        Me.tmrJump = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicSpaceRunner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnRun.Location = New System.Drawing.Point(12, 12)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(150, 50)
        Me.btnRun.TabIndex = 1
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStop.Location = New System.Drawing.Point(422, 12)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(150, 50)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnJump
        '
        Me.btnJump.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnJump.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJump.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJump.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJump.Location = New System.Drawing.Point(220, 12)
        Me.btnJump.Name = "btnJump"
        Me.btnJump.Size = New System.Drawing.Size(150, 50)
        Me.btnJump.TabIndex = 3
        Me.btnJump.Text = "Jump"
        Me.btnJump.UseVisualStyleBackColor = False
        '
        'tmrSpeed
        '
        '
        'PicSpaceRunner
        '
        Me.PicSpaceRunner.Image = Global._15._2._6_Space_Runner.My.Resources.Resources.r0
        Me.PicSpaceRunner.Location = New System.Drawing.Point(0, 160)
        Me.PicSpaceRunner.Name = "PicSpaceRunner"
        Me.PicSpaceRunner.Size = New System.Drawing.Size(100, 100)
        Me.PicSpaceRunner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSpaceRunner.TabIndex = 0
        Me.PicSpaceRunner.TabStop = False
        '
        'tmrRun
        '
        Me.tmrRun.Interval = 200
        '
        'tmrJump
        '
        Me.tmrJump.Interval = 200
        '
        'frmSpaceRunner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.btnJump)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.PicSpaceRunner)
        Me.Name = "frmSpaceRunner"
        Me.Text = "Space Runner"
        CType(Me.PicSpaceRunner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicSpaceRunner As System.Windows.Forms.PictureBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnJump As System.Windows.Forms.Button
    Friend WithEvents tmrSpeed As System.Windows.Forms.Timer
    Friend WithEvents tmrRun As System.Windows.Forms.Timer
    Friend WithEvents tmrJump As System.Windows.Forms.Timer

End Class
