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
        Me.lblMovieSelectorTitle = New System.Windows.Forms.Label()
        Me.grpMovies = New System.Windows.Forms.GroupBox()
        Me.radMovieType3 = New System.Windows.Forms.RadioButton()
        Me.radMovieType2 = New System.Windows.Forms.RadioButton()
        Me.radMovieType1 = New System.Windows.Forms.RadioButton()
        Me.lblMovieTitle = New System.Windows.Forms.Label()
        Me.lblRentMovies = New System.Windows.Forms.Label()
        Me.btnQuantity1 = New System.Windows.Forms.Button()
        Me.btnQuantity2 = New System.Windows.Forms.Button()
        Me.btnQuantity3 = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpMovies.SuspendLayout()
        Me.mnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMovieSelectorTitle
        '
        Me.lblMovieSelectorTitle.AutoSize = True
        Me.lblMovieSelectorTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieSelectorTitle.Location = New System.Drawing.Point(12, 33)
        Me.lblMovieSelectorTitle.Name = "lblMovieSelectorTitle"
        Me.lblMovieSelectorTitle.Size = New System.Drawing.Size(193, 31)
        Me.lblMovieSelectorTitle.TabIndex = 0
        Me.lblMovieSelectorTitle.Text = "Movie Selector"
        '
        'grpMovies
        '
        Me.grpMovies.Controls.Add(Me.radMovieType3)
        Me.grpMovies.Controls.Add(Me.radMovieType2)
        Me.grpMovies.Controls.Add(Me.radMovieType1)
        Me.grpMovies.Location = New System.Drawing.Point(18, 67)
        Me.grpMovies.Name = "grpMovies"
        Me.grpMovies.Size = New System.Drawing.Size(321, 77)
        Me.grpMovies.TabIndex = 1
        Me.grpMovies.TabStop = False
        Me.grpMovies.Text = "Select the type of movie that you wish to see"
        '
        'radMovieType3
        '
        Me.radMovieType3.AutoSize = True
        Me.radMovieType3.Location = New System.Drawing.Point(227, 40)
        Me.radMovieType3.Name = "radMovieType3"
        Me.radMovieType3.Size = New System.Drawing.Size(88, 17)
        Me.radMovieType3.TabIndex = 2
        Me.radMovieType3.TabStop = True
        Me.radMovieType3.Text = "Documentary"
        Me.radMovieType3.UseVisualStyleBackColor = True
        '
        'radMovieType2
        '
        Me.radMovieType2.AutoSize = True
        Me.radMovieType2.Location = New System.Drawing.Point(114, 40)
        Me.radMovieType2.Name = "radMovieType2"
        Me.radMovieType2.Size = New System.Drawing.Size(55, 17)
        Me.radMovieType2.TabIndex = 1
        Me.radMovieType2.TabStop = True
        Me.radMovieType2.Text = "Action"
        Me.radMovieType2.UseVisualStyleBackColor = True
        '
        'radMovieType1
        '
        Me.radMovieType1.AutoSize = True
        Me.radMovieType1.Location = New System.Drawing.Point(6, 40)
        Me.radMovieType1.Name = "radMovieType1"
        Me.radMovieType1.Size = New System.Drawing.Size(63, 17)
        Me.radMovieType1.TabIndex = 0
        Me.radMovieType1.TabStop = True
        Me.radMovieType1.Text = "Comedy"
        Me.radMovieType1.UseVisualStyleBackColor = True
        '
        'lblMovieTitle
        '
        Me.lblMovieTitle.AutoSize = True
        Me.lblMovieTitle.Location = New System.Drawing.Point(15, 147)
        Me.lblMovieTitle.Name = "lblMovieTitle"
        Me.lblMovieTitle.Size = New System.Drawing.Size(0, 13)
        Me.lblMovieTitle.TabIndex = 2
        '
        'lblRentMovies
        '
        Me.lblRentMovies.AutoSize = True
        Me.lblRentMovies.Location = New System.Drawing.Point(21, 172)
        Me.lblRentMovies.Name = "lblRentMovies"
        Me.lblRentMovies.Size = New System.Drawing.Size(186, 13)
        Me.lblRentMovies.TabIndex = 3
        Me.lblRentMovies.Text = "How many movies will you be renting?"
        '
        'btnQuantity1
        '
        Me.btnQuantity1.Location = New System.Drawing.Point(24, 198)
        Me.btnQuantity1.Name = "btnQuantity1"
        Me.btnQuantity1.Size = New System.Drawing.Size(75, 23)
        Me.btnQuantity1.TabIndex = 4
        Me.btnQuantity1.Text = "1"
        Me.btnQuantity1.UseVisualStyleBackColor = True
        '
        'btnQuantity2
        '
        Me.btnQuantity2.Location = New System.Drawing.Point(132, 198)
        Me.btnQuantity2.Name = "btnQuantity2"
        Me.btnQuantity2.Size = New System.Drawing.Size(75, 23)
        Me.btnQuantity2.TabIndex = 5
        Me.btnQuantity2.Text = "2"
        Me.btnQuantity2.UseVisualStyleBackColor = True
        '
        'btnQuantity3
        '
        Me.btnQuantity3.Location = New System.Drawing.Point(245, 197)
        Me.btnQuantity3.Name = "btnQuantity3"
        Me.btnQuantity3.Size = New System.Drawing.Size(75, 23)
        Me.btnQuantity3.TabIndex = 6
        Me.btnQuantity3.Text = "3"
        Me.btnQuantity3.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(21, 228)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(43, 13)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total: $"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(73, 228)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalCost.TabIndex = 8
        '
        'mnu
        '
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(351, 24)
        Me.mnu.TabIndex = 9
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 262)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnQuantity3)
        Me.Controls.Add(Me.btnQuantity2)
        Me.Controls.Add(Me.btnQuantity1)
        Me.Controls.Add(Me.lblRentMovies)
        Me.Controls.Add(Me.lblMovieTitle)
        Me.Controls.Add(Me.grpMovies)
        Me.Controls.Add(Me.lblMovieSelectorTitle)
        Me.Controls.Add(Me.mnu)
        Me.MainMenuStrip = Me.mnu
        Me.Name = "Form1"
        Me.Text = "Movie Selector"
        Me.grpMovies.ResumeLayout(False)
        Me.grpMovies.PerformLayout()
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMovieSelectorTitle As System.Windows.Forms.Label
    Friend WithEvents grpMovies As System.Windows.Forms.GroupBox
    Friend WithEvents radMovieType3 As System.Windows.Forms.RadioButton
    Friend WithEvents radMovieType2 As System.Windows.Forms.RadioButton
    Friend WithEvents radMovieType1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblMovieTitle As System.Windows.Forms.Label
    Friend WithEvents lblRentMovies As System.Windows.Forms.Label
    Friend WithEvents btnQuantity1 As System.Windows.Forms.Button
    Friend WithEvents btnQuantity2 As System.Windows.Forms.Button
    Friend WithEvents btnQuantity3 As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
