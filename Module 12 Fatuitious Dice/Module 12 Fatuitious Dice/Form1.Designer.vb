<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatuitiousDice
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
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Dice1 = New System.Windows.Forms.PictureBox()
        Me.Dice2 = New System.Windows.Forms.PictureBox()
        Me.lblRoll1Value = New System.Windows.Forms.Label()
        Me.lblRoll2Value = New System.Windows.Forms.Label()
        Me.Dice1Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Dice2Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnRollDice = New System.Windows.Forms.Button()
        Me.btnStopDice = New System.Windows.Forms.Button()
        Me.lblRollValue = New System.Windows.Forms.Label()
        Me.lblFirstRollPrompt = New System.Windows.Forms.Label()
        Me.lblSecondRollPrompt = New System.Windows.Forms.Label()
        Me.lblSecondRoll = New System.Windows.Forms.Label()
        Me.lblFirstRoll = New System.Windows.Forms.Label()
        Me.mnuMenu.SuspendLayout()
        CType(Me.Dice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(500, 24)
        Me.mnuMenu.TabIndex = 0
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReset, Me.mnuExit})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(61, 20)
        Me.mnuProgram.Text = "Progam"
        '
        'mnuReset
        '
        Me.mnuReset.Name = "mnuReset"
        Me.mnuReset.Size = New System.Drawing.Size(152, 22)
        Me.mnuReset.Text = "Reset"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'Dice1
        '
        Me.Dice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dice1.Location = New System.Drawing.Point(100, 50)
        Me.Dice1.Name = "Dice1"
        Me.Dice1.Size = New System.Drawing.Size(100, 100)
        Me.Dice1.TabIndex = 1
        Me.Dice1.TabStop = False
        '
        'Dice2
        '
        Me.Dice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dice2.Location = New System.Drawing.Point(300, 50)
        Me.Dice2.Name = "Dice2"
        Me.Dice2.Size = New System.Drawing.Size(100, 100)
        Me.Dice2.TabIndex = 2
        Me.Dice2.TabStop = False
        '
        'lblRoll1Value
        '
        Me.lblRoll1Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoll1Value.Location = New System.Drawing.Point(100, 150)
        Me.lblRoll1Value.Name = "lblRoll1Value"
        Me.lblRoll1Value.Size = New System.Drawing.Size(100, 25)
        Me.lblRoll1Value.TabIndex = 3
        Me.lblRoll1Value.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRoll2Value
        '
        Me.lblRoll2Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoll2Value.Location = New System.Drawing.Point(300, 150)
        Me.lblRoll2Value.Name = "lblRoll2Value"
        Me.lblRoll2Value.Size = New System.Drawing.Size(100, 25)
        Me.lblRoll2Value.TabIndex = 4
        Me.lblRoll2Value.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Dice1Timer
        '
        '
        'Dice2Timer
        '
        '
        'btnRollDice
        '
        Me.btnRollDice.BackColor = System.Drawing.Color.SkyBlue
        Me.btnRollDice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRollDice.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRollDice.Location = New System.Drawing.Point(100, 200)
        Me.btnRollDice.Name = "btnRollDice"
        Me.btnRollDice.Size = New System.Drawing.Size(300, 50)
        Me.btnRollDice.TabIndex = 5
        Me.btnRollDice.Text = "Roll Dice"
        Me.btnRollDice.UseVisualStyleBackColor = False
        '
        'btnStopDice
        '
        Me.btnStopDice.BackColor = System.Drawing.Color.SkyBlue
        Me.btnStopDice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStopDice.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopDice.Location = New System.Drawing.Point(100, 260)
        Me.btnStopDice.Name = "btnStopDice"
        Me.btnStopDice.Size = New System.Drawing.Size(300, 50)
        Me.btnStopDice.TabIndex = 6
        Me.btnStopDice.Text = "Stop Dice"
        Me.btnStopDice.UseVisualStyleBackColor = False
        '
        'lblRollValue
        '
        Me.lblRollValue.Font = New System.Drawing.Font("Goudy Old Style", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRollValue.Location = New System.Drawing.Point(100, 407)
        Me.lblRollValue.Name = "lblRollValue"
        Me.lblRollValue.Size = New System.Drawing.Size(300, 31)
        Me.lblRollValue.TabIndex = 7
        Me.lblRollValue.Text = "The value of the roll is: "
        '
        'lblFirstRollPrompt
        '
        Me.lblFirstRollPrompt.Font = New System.Drawing.Font("Goudy Old Style", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstRollPrompt.Location = New System.Drawing.Point(100, 337)
        Me.lblFirstRollPrompt.Name = "lblFirstRollPrompt"
        Me.lblFirstRollPrompt.Size = New System.Drawing.Size(270, 31)
        Me.lblFirstRollPrompt.TabIndex = 8
        Me.lblFirstRollPrompt.Text = "Your First Roll Was:"
        '
        'lblSecondRollPrompt
        '
        Me.lblSecondRollPrompt.Font = New System.Drawing.Font("Goudy Old Style", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondRollPrompt.Location = New System.Drawing.Point(100, 367)
        Me.lblSecondRollPrompt.Name = "lblSecondRollPrompt"
        Me.lblSecondRollPrompt.Size = New System.Drawing.Size(270, 31)
        Me.lblSecondRollPrompt.TabIndex = 9
        Me.lblSecondRollPrompt.Text = "Your Second Roll Was:"
        '
        'lblSecondRoll
        '
        Me.lblSecondRoll.Font = New System.Drawing.Font("Goudy Old Style", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondRoll.Location = New System.Drawing.Point(370, 367)
        Me.lblSecondRoll.Name = "lblSecondRoll"
        Me.lblSecondRoll.Size = New System.Drawing.Size(30, 31)
        Me.lblSecondRoll.TabIndex = 10
        '
        'lblFirstRoll
        '
        Me.lblFirstRoll.Font = New System.Drawing.Font("Goudy Old Style", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstRoll.Location = New System.Drawing.Point(370, 337)
        Me.lblFirstRoll.Name = "lblFirstRoll"
        Me.lblFirstRoll.Size = New System.Drawing.Size(30, 31)
        Me.lblFirstRoll.TabIndex = 11
        '
        'frmFatuitiousDice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(500, 487)
        Me.Controls.Add(Me.lblFirstRoll)
        Me.Controls.Add(Me.lblSecondRoll)
        Me.Controls.Add(Me.lblSecondRollPrompt)
        Me.Controls.Add(Me.lblFirstRollPrompt)
        Me.Controls.Add(Me.lblRollValue)
        Me.Controls.Add(Me.btnStopDice)
        Me.Controls.Add(Me.btnRollDice)
        Me.Controls.Add(Me.lblRoll2Value)
        Me.Controls.Add(Me.lblRoll1Value)
        Me.Controls.Add(Me.Dice2)
        Me.Controls.Add(Me.Dice1)
        Me.Controls.Add(Me.mnuMenu)
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "frmFatuitiousDice"
        Me.Text = "Fatuitious Dice"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        CType(Me.Dice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Dice1 As System.Windows.Forms.PictureBox
    Friend WithEvents Dice2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRoll1Value As System.Windows.Forms.Label
    Friend WithEvents lblRoll2Value As System.Windows.Forms.Label
    Friend WithEvents Dice1Timer As System.Windows.Forms.Timer
    Friend WithEvents Dice2Timer As System.Windows.Forms.Timer
    Friend WithEvents btnRollDice As System.Windows.Forms.Button
    Friend WithEvents btnStopDice As System.Windows.Forms.Button
    Friend WithEvents lblRollValue As System.Windows.Forms.Label
    Friend WithEvents lblFirstRollPrompt As System.Windows.Forms.Label
    Friend WithEvents lblSecondRollPrompt As System.Windows.Forms.Label
    Friend WithEvents lblSecondRoll As System.Windows.Forms.Label
    Friend WithEvents lblFirstRoll As System.Windows.Forms.Label

End Class
