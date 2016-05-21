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
        Me.mnuMenuBar = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddFact = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveFact = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstFacts = New System.Windows.Forms.ListBox()
        Me.mnuMenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuBar
        '
        Me.mnuMenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu})
        Me.mnuMenuBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuBar.Name = "mnuMenuBar"
        Me.mnuMenuBar.Size = New System.Drawing.Size(439, 24)
        Me.mnuMenuBar.TabIndex = 0
        Me.mnuMenuBar.Text = "MenuStrip1"
        '
        'mnuMenu
        '
        Me.mnuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddFact, Me.mnuRemoveFact, Me.mnuClear, Me.mnuExit})
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(50, 20)
        Me.mnuMenu.Text = "Menu"
        '
        'mnuAddFact
        '
        Me.mnuAddFact.Name = "mnuAddFact"
        Me.mnuAddFact.Size = New System.Drawing.Size(152, 22)
        Me.mnuAddFact.Text = "Add Fact"
        '
        'mnuRemoveFact
        '
        Me.mnuRemoveFact.Name = "mnuRemoveFact"
        Me.mnuRemoveFact.Size = New System.Drawing.Size(152, 22)
        Me.mnuRemoveFact.Text = "Remove Fact"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuClear.Text = "Clear List"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lstFacts
        '
        Me.lstFacts.BackColor = System.Drawing.Color.Silver
        Me.lstFacts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstFacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFacts.FormattingEnabled = True
        Me.lstFacts.ItemHeight = 20
        Me.lstFacts.Location = New System.Drawing.Point(13, 41)
        Me.lstFacts.Name = "lstFacts"
        Me.lstFacts.Size = New System.Drawing.Size(414, 200)
        Me.lstFacts.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(439, 266)
        Me.Controls.Add(Me.lstFacts)
        Me.Controls.Add(Me.mnuMenuBar)
        Me.MainMenuStrip = Me.mnuMenuBar
        Me.Name = "Form1"
        Me.Text = "World War 2 Facts"
        Me.mnuMenuBar.ResumeLayout(False)
        Me.mnuMenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAddFact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRemoveFact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstFacts As System.Windows.Forms.ListBox

End Class
