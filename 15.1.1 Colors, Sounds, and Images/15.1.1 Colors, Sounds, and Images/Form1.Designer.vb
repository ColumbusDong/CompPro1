<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColors
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
        Me.btnColors = New System.Windows.Forms.Button()
        Me.btnPalette = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnSounds = New System.Windows.Forms.Button()
        Me.btnImages = New System.Windows.Forms.Button()
        Me.PicImage = New System.Windows.Forms.PictureBox()
        CType(Me.PicImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnColors
        '
        Me.btnColors.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColors.Location = New System.Drawing.Point(279, 21)
        Me.btnColors.Name = "btnColors"
        Me.btnColors.Size = New System.Drawing.Size(92, 27)
        Me.btnColors.TabIndex = 0
        Me.btnColors.Text = "Colors"
        Me.btnColors.UseVisualStyleBackColor = True
        '
        'btnPalette
        '
        Me.btnPalette.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPalette.Location = New System.Drawing.Point(279, 54)
        Me.btnPalette.Name = "btnPalette"
        Me.btnPalette.Size = New System.Drawing.Size(92, 27)
        Me.btnPalette.TabIndex = 1
        Me.btnPalette.Text = "Palette"
        Me.btnPalette.UseVisualStyleBackColor = True
        '
        'btnSounds
        '
        Me.btnSounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSounds.Location = New System.Drawing.Point(279, 87)
        Me.btnSounds.Name = "btnSounds"
        Me.btnSounds.Size = New System.Drawing.Size(92, 27)
        Me.btnSounds.TabIndex = 2
        Me.btnSounds.Text = "Sounds"
        Me.btnSounds.UseVisualStyleBackColor = True
        '
        'btnImages
        '
        Me.btnImages.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImages.Location = New System.Drawing.Point(279, 120)
        Me.btnImages.Name = "btnImages"
        Me.btnImages.Size = New System.Drawing.Size(92, 27)
        Me.btnImages.TabIndex = 3
        Me.btnImages.Text = "Images"
        Me.btnImages.UseVisualStyleBackColor = True
        '
        'PicImage
        '
        Me.PicImage.Location = New System.Drawing.Point(14, 20)
        Me.PicImage.Name = "PicImage"
        Me.PicImage.Size = New System.Drawing.Size(259, 127)
        Me.PicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicImage.TabIndex = 4
        Me.PicImage.TabStop = False
        '
        'frmColors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 175)
        Me.Controls.Add(Me.PicImage)
        Me.Controls.Add(Me.btnImages)
        Me.Controls.Add(Me.btnSounds)
        Me.Controls.Add(Me.btnPalette)
        Me.Controls.Add(Me.btnColors)
        Me.Name = "frmColors"
        Me.Text = "Colors"
        CType(Me.PicImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnColors As System.Windows.Forms.Button
    Friend WithEvents btnPalette As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents btnSounds As System.Windows.Forms.Button
    Friend WithEvents btnImages As System.Windows.Forms.Button
    Friend WithEvents PicImage As System.Windows.Forms.PictureBox

End Class
