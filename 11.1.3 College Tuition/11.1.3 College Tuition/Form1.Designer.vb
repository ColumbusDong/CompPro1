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
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChgClr = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChgBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChgRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChgBlack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstCollege = New System.Windows.Forms.ListBox()
        Me.lblCreditHourPrompt = New System.Windows.Forms.Label()
        Me.cboCreditHours = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.chkLiving = New System.Windows.Forms.CheckBox()
        Me.chkBooks = New System.Windows.Forms.CheckBox()
        Me.chkOther = New System.Windows.Forms.CheckBox()
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(381, 24)
        Me.mnuMenu.TabIndex = 0
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChgClr, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuChgClr
        '
        Me.mnuChgClr.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChgBlue, Me.mnuChgRed, Me.mnuChgBlack})
        Me.mnuChgClr.Name = "mnuChgClr"
        Me.mnuChgClr.Size = New System.Drawing.Size(170, 22)
        Me.mnuChgClr.Text = "Background Color"
        '
        'mnuChgBlue
        '
        Me.mnuChgBlue.Name = "mnuChgBlue"
        Me.mnuChgBlue.Size = New System.Drawing.Size(152, 22)
        Me.mnuChgBlue.Text = "Blue"
        '
        'mnuChgRed
        '
        Me.mnuChgRed.Name = "mnuChgRed"
        Me.mnuChgRed.Size = New System.Drawing.Size(152, 22)
        Me.mnuChgRed.Text = "Red"
        '
        'mnuChgBlack
        '
        Me.mnuChgBlack.Name = "mnuChgBlack"
        Me.mnuChgBlack.Size = New System.Drawing.Size(152, 22)
        Me.mnuChgBlack.Text = "Black"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(170, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lstCollege
        '
        Me.lstCollege.BackColor = System.Drawing.Color.LightGray
        Me.lstCollege.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCollege.ForeColor = System.Drawing.Color.Black
        Me.lstCollege.FormattingEnabled = True
        Me.lstCollege.ItemHeight = 24
        Me.lstCollege.Items.AddRange(New Object() {"Massachusetts Institute of Technology (MIT)", "Duke University", "Appalachian State University"})
        Me.lstCollege.Location = New System.Drawing.Point(0, 38)
        Me.lstCollege.Name = "lstCollege"
        Me.lstCollege.Size = New System.Drawing.Size(381, 100)
        Me.lstCollege.TabIndex = 1
        '
        'lblCreditHourPrompt
        '
        Me.lblCreditHourPrompt.AutoSize = True
        Me.lblCreditHourPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditHourPrompt.ForeColor = System.Drawing.Color.Silver
        Me.lblCreditHourPrompt.Location = New System.Drawing.Point(58, 167)
        Me.lblCreditHourPrompt.Name = "lblCreditHourPrompt"
        Me.lblCreditHourPrompt.Size = New System.Drawing.Size(120, 24)
        Me.lblCreditHourPrompt.TabIndex = 2
        Me.lblCreditHourPrompt.Text = "Credit Hours:"
        '
        'cboCreditHours
        '
        Me.cboCreditHours.FormattingEnabled = True
        Me.cboCreditHours.Items.AddRange(New Object() {"3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.cboCreditHours.Location = New System.Drawing.Point(203, 170)
        Me.cboCreditHours.Name = "cboCreditHours"
        Me.cboCreditHours.Size = New System.Drawing.Size(121, 21)
        Me.cboCreditHours.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(62, 322)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(262, 46)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.Silver
        Me.lblTotalCost.Location = New System.Drawing.Point(58, 397)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(165, 24)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.Text = "Your total tuition is:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.Color.Silver
        Me.lblOutput.Location = New System.Drawing.Point(234, 397)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 24)
        Me.lblOutput.TabIndex = 6
        '
        'chkLiving
        '
        Me.chkLiving.AutoSize = True
        Me.chkLiving.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLiving.ForeColor = System.Drawing.Color.Silver
        Me.chkLiving.Location = New System.Drawing.Point(62, 207)
        Me.chkLiving.Name = "chkLiving"
        Me.chkLiving.Size = New System.Drawing.Size(172, 28)
        Me.chkLiving.TabIndex = 7
        Me.chkLiving.Text = "Room and Board"
        Me.chkLiving.UseVisualStyleBackColor = True
        '
        'chkBooks
        '
        Me.chkBooks.AutoSize = True
        Me.chkBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBooks.ForeColor = System.Drawing.Color.Silver
        Me.chkBooks.Location = New System.Drawing.Point(62, 242)
        Me.chkBooks.Name = "chkBooks"
        Me.chkBooks.Size = New System.Drawing.Size(81, 28)
        Me.chkBooks.TabIndex = 8
        Me.chkBooks.Text = "Books"
        Me.chkBooks.UseVisualStyleBackColor = True
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOther.ForeColor = System.Drawing.Color.Silver
        Me.chkOther.Location = New System.Drawing.Point(62, 277)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(224, 28)
        Me.chkOther.TabIndex = 9
        Me.chkOther.Text = "Other (food, travel, etc.)"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(381, 502)
        Me.Controls.Add(Me.chkOther)
        Me.Controls.Add(Me.chkBooks)
        Me.Controls.Add(Me.chkLiving)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.cboCreditHours)
        Me.Controls.Add(Me.lblCreditHourPrompt)
        Me.Controls.Add(Me.lstCollege)
        Me.Controls.Add(Me.mnuMenu)
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "Form1"
        Me.Text = "College Tuition"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChgClr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChgBlue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChgRed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChgBlack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstCollege As System.Windows.Forms.ListBox
    Friend WithEvents lblCreditHourPrompt As System.Windows.Forms.Label
    Friend WithEvents cboCreditHours As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents chkLiving As System.Windows.Forms.CheckBox
    Friend WithEvents chkBooks As System.Windows.Forms.CheckBox
    Friend WithEvents chkOther As System.Windows.Forms.CheckBox

End Class
