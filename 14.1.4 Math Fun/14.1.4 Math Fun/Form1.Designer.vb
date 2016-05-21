<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMath
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.mnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.MathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSqrt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSign = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRound = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(64, 50)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(144, 20)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter your number:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(215, 49)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 1
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMain})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(380, 24)
        Me.mnuMenu.TabIndex = 2
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'lblAnswer
        '
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(68, 100)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(247, 68)
        Me.lblAnswer.TabIndex = 3
        '
        'mnuMain
        '
        Me.mnuMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MathToolStripMenuItem, Me.mnuExit})
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(46, 20)
        Me.mnuMain.Text = "Main"
        '
        'MathToolStripMenuItem
        '
        Me.MathToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbs, Me.mnuSqrt, Me.mnuSign, Me.mnuRound})
        Me.MathToolStripMenuItem.Name = "MathToolStripMenuItem"
        Me.MathToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MathToolStripMenuItem.Text = "Math"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuAbs
        '
        Me.mnuAbs.Name = "mnuAbs"
        Me.mnuAbs.Size = New System.Drawing.Size(153, 22)
        Me.mnuAbs.Text = "Abolsute Value"
        '
        'mnuSqrt
        '
        Me.mnuSqrt.Name = "mnuSqrt"
        Me.mnuSqrt.Size = New System.Drawing.Size(153, 22)
        Me.mnuSqrt.Text = "Square Root"
        '
        'mnuSign
        '
        Me.mnuSign.Name = "mnuSign"
        Me.mnuSign.Size = New System.Drawing.Size(153, 22)
        Me.mnuSign.Text = "Sign"
        '
        'mnuRound
        '
        Me.mnuRound.Name = "mnuRound"
        Me.mnuRound.Size = New System.Drawing.Size(153, 22)
        Me.mnuRound.Text = "Round"
        '
        'frmMath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 322)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.mnuMenu)
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "frmMath"
        Me.Text = "Math Fun"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSqrt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSign As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRound As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
