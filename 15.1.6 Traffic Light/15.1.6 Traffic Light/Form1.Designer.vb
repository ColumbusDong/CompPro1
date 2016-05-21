<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrafficLight
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
        Me.TrafficLight = New System.Windows.Forms.PictureBox()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnYellow = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.TrafficLight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrafficLight
        '
        Me.TrafficLight.Image = Global._15._1._6_Traffic_Light.My.Resources.Resources.TrafficLight
        Me.TrafficLight.Location = New System.Drawing.Point(132, 12)
        Me.TrafficLight.Name = "TrafficLight"
        Me.TrafficLight.Size = New System.Drawing.Size(165, 305)
        Me.TrafficLight.TabIndex = 0
        Me.TrafficLight.TabStop = False
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGreen.Location = New System.Drawing.Point(12, 144)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(114, 27)
        Me.btnGreen.TabIndex = 1
        Me.btnGreen.Text = "Green"
        Me.btnGreen.UseVisualStyleBackColor = False
        '
        'btnYellow
        '
        Me.btnYellow.BackColor = System.Drawing.Color.Yellow
        Me.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYellow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYellow.Location = New System.Drawing.Point(12, 78)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(114, 27)
        Me.btnYellow.TabIndex = 2
        Me.btnYellow.Text = "Yellow"
        Me.btnYellow.UseVisualStyleBackColor = False
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.Color.Red
        Me.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRed.Location = New System.Drawing.Point(12, 12)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(114, 27)
        Me.btnRed.TabIndex = 3
        Me.btnRed.Text = "Red"
        Me.btnRed.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(12, 207)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(114, 27)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmTrafficLight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 329)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.btnYellow)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.TrafficLight)
        Me.Name = "frmTrafficLight"
        Me.Text = "Traffic Light"
        CType(Me.TrafficLight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TrafficLight As System.Windows.Forms.PictureBox
    Friend WithEvents btnGreen As System.Windows.Forms.Button
    Friend WithEvents btnYellow As System.Windows.Forms.Button
    Friend WithEvents btnRed As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
