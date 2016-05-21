<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFootBallScores
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
        Me.lbl1stQuarter = New System.Windows.Forms.Label()
        Me.lbl2ndQuarter = New System.Windows.Forms.Label()
        Me.lbl4thQuarter = New System.Windows.Forms.Label()
        Me.lbl3rdQuarter = New System.Windows.Forms.Label()
        Me.txtFirstQuarter = New System.Windows.Forms.TextBox()
        Me.txtSecondQuarter = New System.Windows.Forms.TextBox()
        Me.txtThirdQuarter = New System.Windows.Forms.TextBox()
        Me.txtFourthQuarter = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl1stQuarter
        '
        Me.lbl1stQuarter.AutoSize = True
        Me.lbl1stQuarter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1stQuarter.Location = New System.Drawing.Point(22, 40)
        Me.lbl1stQuarter.Name = "lbl1stQuarter"
        Me.lbl1stQuarter.Size = New System.Drawing.Size(227, 21)
        Me.lbl1stQuarter.TabIndex = 0
        Me.lbl1stQuarter.Text = "Enter the 1st Quarter Points:"
        '
        'lbl2ndQuarter
        '
        Me.lbl2ndQuarter.AutoSize = True
        Me.lbl2ndQuarter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2ndQuarter.Location = New System.Drawing.Point(22, 74)
        Me.lbl2ndQuarter.Name = "lbl2ndQuarter"
        Me.lbl2ndQuarter.Size = New System.Drawing.Size(235, 21)
        Me.lbl2ndQuarter.TabIndex = 1
        Me.lbl2ndQuarter.Text = "Enter the 2nd Quarter Points:"
        '
        'lbl4thQuarter
        '
        Me.lbl4thQuarter.AutoSize = True
        Me.lbl4thQuarter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4thQuarter.Location = New System.Drawing.Point(21, 143)
        Me.lbl4thQuarter.Name = "lbl4thQuarter"
        Me.lbl4thQuarter.Size = New System.Drawing.Size(231, 21)
        Me.lbl4thQuarter.TabIndex = 2
        Me.lbl4thQuarter.Text = "Enter the 4th Quarter Points:"
        '
        'lbl3rdQuarter
        '
        Me.lbl3rdQuarter.AutoSize = True
        Me.lbl3rdQuarter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3rdQuarter.Location = New System.Drawing.Point(21, 110)
        Me.lbl3rdQuarter.Name = "lbl3rdQuarter"
        Me.lbl3rdQuarter.Size = New System.Drawing.Size(230, 21)
        Me.lbl3rdQuarter.TabIndex = 3
        Me.lbl3rdQuarter.Text = "Enter the 3rd Quarter Points:"
        '
        'txtFirstQuarter
        '
        Me.txtFirstQuarter.Location = New System.Drawing.Point(284, 40)
        Me.txtFirstQuarter.Name = "txtFirstQuarter"
        Me.txtFirstQuarter.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstQuarter.TabIndex = 4
        '
        'txtSecondQuarter
        '
        Me.txtSecondQuarter.Location = New System.Drawing.Point(284, 75)
        Me.txtSecondQuarter.Name = "txtSecondQuarter"
        Me.txtSecondQuarter.Size = New System.Drawing.Size(100, 20)
        Me.txtSecondQuarter.TabIndex = 5
        '
        'txtThirdQuarter
        '
        Me.txtThirdQuarter.Location = New System.Drawing.Point(284, 110)
        Me.txtThirdQuarter.Name = "txtThirdQuarter"
        Me.txtThirdQuarter.Size = New System.Drawing.Size(100, 20)
        Me.txtThirdQuarter.TabIndex = 6
        '
        'txtFourthQuarter
        '
        Me.txtFourthQuarter.Location = New System.Drawing.Point(284, 143)
        Me.txtFourthQuarter.Name = "txtFourthQuarter"
        Me.txtFourthQuarter.Size = New System.Drawing.Size(100, 20)
        Me.txtFourthQuarter.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(25, 192)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(359, 85)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Compute the total number of points"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(22, 289)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(362, 60)
        Me.lblOutput.TabIndex = 9
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(408, 24)
        Me.mnuMenu.TabIndex = 10
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'frmFootBallScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 406)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtFourthQuarter)
        Me.Controls.Add(Me.txtThirdQuarter)
        Me.Controls.Add(Me.txtSecondQuarter)
        Me.Controls.Add(Me.txtFirstQuarter)
        Me.Controls.Add(Me.lbl3rdQuarter)
        Me.Controls.Add(Me.lbl4thQuarter)
        Me.Controls.Add(Me.lbl2ndQuarter)
        Me.Controls.Add(Me.lbl1stQuarter)
        Me.Controls.Add(Me.mnuMenu)
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "frmFootBallScores"
        Me.Text = "Football Game Scores"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1stQuarter As System.Windows.Forms.Label
    Friend WithEvents lbl2ndQuarter As System.Windows.Forms.Label
    Friend WithEvents lbl4thQuarter As System.Windows.Forms.Label
    Friend WithEvents lbl3rdQuarter As System.Windows.Forms.Label
    Friend WithEvents txtFirstQuarter As System.Windows.Forms.TextBox
    Friend WithEvents txtSecondQuarter As System.Windows.Forms.TextBox
    Friend WithEvents txtThirdQuarter As System.Windows.Forms.TextBox
    Friend WithEvents txtFourthQuarter As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem

End Class
