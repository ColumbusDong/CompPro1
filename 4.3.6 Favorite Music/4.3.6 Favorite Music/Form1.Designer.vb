<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Music
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
        Me.grpMusicGroups = New System.Windows.Forms.GroupBox()
        Me.radBand5 = New System.Windows.Forms.RadioButton()
        Me.radBand4 = New System.Windows.Forms.RadioButton()
        Me.radBand3 = New System.Windows.Forms.RadioButton()
        Me.radBand2 = New System.Windows.Forms.RadioButton()
        Me.radBand1 = New System.Windows.Forms.RadioButton()
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFavMusic = New System.Windows.Forms.Label()
        Me.lblSongs = New System.Windows.Forms.Label()
        Me.lblSong1 = New System.Windows.Forms.Label()
        Me.lblSong2 = New System.Windows.Forms.Label()
        Me.lblSong3 = New System.Windows.Forms.Label()
        Me.grpMusicGroups.SuspendLayout()
        Me.mnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMusicGroups
        '
        Me.grpMusicGroups.Controls.Add(Me.radBand5)
        Me.grpMusicGroups.Controls.Add(Me.radBand4)
        Me.grpMusicGroups.Controls.Add(Me.radBand3)
        Me.grpMusicGroups.Controls.Add(Me.radBand2)
        Me.grpMusicGroups.Controls.Add(Me.radBand1)
        Me.grpMusicGroups.Location = New System.Drawing.Point(12, 63)
        Me.grpMusicGroups.Name = "grpMusicGroups"
        Me.grpMusicGroups.Size = New System.Drawing.Size(297, 84)
        Me.grpMusicGroups.TabIndex = 0
        Me.grpMusicGroups.TabStop = False
        Me.grpMusicGroups.Text = "Music Groups"
        '
        'radBand5
        '
        Me.radBand5.Location = New System.Drawing.Point(143, 52)
        Me.radBand5.Name = "radBand5"
        Me.radBand5.Size = New System.Drawing.Size(106, 17)
        Me.radBand5.TabIndex = 4
        Me.radBand5.TabStop = True
        Me.radBand5.Text = "My Darkest Days"
        Me.radBand5.UseVisualStyleBackColor = True
        '
        'radBand4
        '
        Me.radBand4.AutoSize = True
        Me.radBand4.Location = New System.Drawing.Point(17, 52)
        Me.radBand4.Name = "radBand4"
        Me.radBand4.Size = New System.Drawing.Size(120, 17)
        Me.radBand4.TabIndex = 3
        Me.radBand4.TabStop = True
        Me.radBand4.Text = "A Day to Remember"
        Me.radBand4.UseVisualStyleBackColor = True
        '
        'radBand3
        '
        Me.radBand3.AutoSize = True
        Me.radBand3.Location = New System.Drawing.Point(184, 29)
        Me.radBand3.Name = "radBand3"
        Me.radBand3.Size = New System.Drawing.Size(78, 17)
        Me.radBand3.TabIndex = 2
        Me.radBand3.TabStop = True
        Me.radBand3.Text = "Linkin Park"
        Me.radBand3.UseVisualStyleBackColor = True
        '
        'radBand2
        '
        Me.radBand2.AutoSize = True
        Me.radBand2.Location = New System.Drawing.Point(125, 29)
        Me.radBand2.Name = "radBand2"
        Me.radBand2.Size = New System.Drawing.Size(53, 17)
        Me.radBand2.TabIndex = 1
        Me.radBand2.TabStop = True
        Me.radBand2.Text = "Skillet"
        Me.radBand2.UseVisualStyleBackColor = True
        '
        'radBand1
        '
        Me.radBand1.AutoSize = True
        Me.radBand1.Location = New System.Drawing.Point(7, 29)
        Me.radBand1.Name = "radBand1"
        Me.radBand1.Size = New System.Drawing.Size(112, 17)
        Me.radBand1.TabIndex = 0
        Me.radBand1.TabStop = True
        Me.radBand1.Text = "Three Days Grace"
        Me.radBand1.UseVisualStyleBackColor = True
        '
        'mnu
        '
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(326, 24)
        Me.mnu.TabIndex = 1
        Me.mnu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblFavMusic
        '
        Me.lblFavMusic.AutoSize = True
        Me.lblFavMusic.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavMusic.Location = New System.Drawing.Point(12, 28)
        Me.lblFavMusic.Name = "lblFavMusic"
        Me.lblFavMusic.Size = New System.Drawing.Size(287, 31)
        Me.lblFavMusic.TabIndex = 2
        Me.lblFavMusic.Text = "Favorite Music Groups"
        '
        'lblSongs
        '
        Me.lblSongs.AutoSize = True
        Me.lblSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongs.Location = New System.Drawing.Point(12, 165)
        Me.lblSongs.Name = "lblSongs"
        Me.lblSongs.Size = New System.Drawing.Size(50, 16)
        Me.lblSongs.TabIndex = 3
        Me.lblSongs.Text = "Songs:"
        '
        'lblSong1
        '
        Me.lblSong1.AutoSize = True
        Me.lblSong1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSong1.Location = New System.Drawing.Point(64, 191)
        Me.lblSong1.Name = "lblSong1"
        Me.lblSong1.Size = New System.Drawing.Size(0, 15)
        Me.lblSong1.TabIndex = 4
        '
        'lblSong2
        '
        Me.lblSong2.AutoSize = True
        Me.lblSong2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSong2.Location = New System.Drawing.Point(64, 213)
        Me.lblSong2.Name = "lblSong2"
        Me.lblSong2.Size = New System.Drawing.Size(0, 15)
        Me.lblSong2.TabIndex = 5
        '
        'lblSong3
        '
        Me.lblSong3.AutoSize = True
        Me.lblSong3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSong3.Location = New System.Drawing.Point(64, 236)
        Me.lblSong3.Name = "lblSong3"
        Me.lblSong3.Size = New System.Drawing.Size(0, 15)
        Me.lblSong3.TabIndex = 6
        '
        'Music
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 298)
        Me.Controls.Add(Me.lblSong3)
        Me.Controls.Add(Me.lblSong2)
        Me.Controls.Add(Me.lblSong1)
        Me.Controls.Add(Me.lblSongs)
        Me.Controls.Add(Me.lblFavMusic)
        Me.Controls.Add(Me.grpMusicGroups)
        Me.Controls.Add(Me.mnu)
        Me.MainMenuStrip = Me.mnu
        Me.Name = "Music"
        Me.Text = "Music Groups"
        Me.grpMusicGroups.ResumeLayout(False)
        Me.grpMusicGroups.PerformLayout()
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpMusicGroups As System.Windows.Forms.GroupBox
    Friend WithEvents radBand4 As System.Windows.Forms.RadioButton
    Friend WithEvents radBand3 As System.Windows.Forms.RadioButton
    Friend WithEvents radBand2 As System.Windows.Forms.RadioButton
    Friend WithEvents radBand1 As System.Windows.Forms.RadioButton
    Friend WithEvents mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents radBand5 As System.Windows.Forms.RadioButton
    Friend WithEvents lblFavMusic As System.Windows.Forms.Label
    Friend WithEvents lblSongs As System.Windows.Forms.Label
    Friend WithEvents lblSong1 As System.Windows.Forms.Label
    Friend WithEvents lblSong2 As System.Windows.Forms.Label
    Friend WithEvents lblSong3 As System.Windows.Forms.Label

End Class
