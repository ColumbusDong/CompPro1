<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTutorial_4_Rectangle
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblEnterLength = New System.Windows.Forms.Label()
        Me.lblEnterWidth = New System.Windows.Forms.Label()
        Me.lblAreaStatement = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnCalcArea = New System.Windows.Forms.Button()
        Me.lblPerimeterStatement = New System.Windows.Forms.Label()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.btnCalcPerimeter = New System.Windows.Forms.Button()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(320, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "mnu"
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
        'lblEnterLength
        '
        Me.lblEnterLength.AutoSize = True
        Me.lblEnterLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterLength.Location = New System.Drawing.Point(12, 55)
        Me.lblEnterLength.Name = "lblEnterLength"
        Me.lblEnterLength.Size = New System.Drawing.Size(126, 16)
        Me.lblEnterLength.TabIndex = 1
        Me.lblEnterLength.Text = "Please enter length:"
        '
        'lblEnterWidth
        '
        Me.lblEnterWidth.AutoSize = True
        Me.lblEnterWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterWidth.Location = New System.Drawing.Point(12, 89)
        Me.lblEnterWidth.Name = "lblEnterWidth"
        Me.lblEnterWidth.Size = New System.Drawing.Size(120, 16)
        Me.lblEnterWidth.TabIndex = 2
        Me.lblEnterWidth.Text = "Please enter width:"
        '
        'lblAreaStatement
        '
        Me.lblAreaStatement.AutoSize = True
        Me.lblAreaStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaStatement.Location = New System.Drawing.Point(12, 133)
        Me.lblAreaStatement.Name = "lblAreaStatement"
        Me.lblAreaStatement.Size = New System.Drawing.Size(107, 16)
        Me.lblAreaStatement.TabIndex = 5
        Me.lblAreaStatement.Text = "The total area is:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(177, 133)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(0, 16)
        Me.lblArea.TabIndex = 6
        '
        'btnCalcArea
        '
        Me.btnCalcArea.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalcArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcArea.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalcArea.Location = New System.Drawing.Point(39, 225)
        Me.btnCalcArea.Name = "btnCalcArea"
        Me.btnCalcArea.Size = New System.Drawing.Size(93, 43)
        Me.btnCalcArea.TabIndex = 7
        Me.btnCalcArea.Text = "Calculate Area"
        Me.btnCalcArea.UseVisualStyleBackColor = False
        '
        'lblPerimeterStatement
        '
        Me.lblPerimeterStatement.AutoSize = True
        Me.lblPerimeterStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerimeterStatement.Location = New System.Drawing.Point(12, 167)
        Me.lblPerimeterStatement.Name = "lblPerimeterStatement"
        Me.lblPerimeterStatement.Size = New System.Drawing.Size(136, 16)
        Me.lblPerimeterStatement.TabIndex = 8
        Me.lblPerimeterStatement.Text = "The total perimeter is:"
        '
        'lblPerimeter
        '
        Me.lblPerimeter.AutoSize = True
        Me.lblPerimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerimeter.Location = New System.Drawing.Point(177, 167)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(0, 16)
        Me.lblPerimeter.TabIndex = 9
        '
        'btnCalcPerimeter
        '
        Me.btnCalcPerimeter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalcPerimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcPerimeter.Location = New System.Drawing.Point(180, 225)
        Me.btnCalcPerimeter.Name = "btnCalcPerimeter"
        Me.btnCalcPerimeter.Size = New System.Drawing.Size(91, 43)
        Me.btnCalcPerimeter.TabIndex = 10
        Me.btnCalcPerimeter.Text = "Calculate Perimeter"
        Me.btnCalcPerimeter.UseVisualStyleBackColor = False
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(184, 55)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 11
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(184, 84)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 12
        '
        'frmTutorial_4_Rectangle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 325)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.btnCalcPerimeter)
        Me.Controls.Add(Me.lblPerimeter)
        Me.Controls.Add(Me.lblPerimeterStatement)
        Me.Controls.Add(Me.btnCalcArea)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblAreaStatement)
        Me.Controls.Add(Me.lblEnterWidth)
        Me.Controls.Add(Me.lblEnterLength)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTutorial_4_Rectangle"
        Me.Text = "Tutorial 4 Rectangle"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEnterLength As System.Windows.Forms.Label
    Friend WithEvents lblEnterWidth As System.Windows.Forms.Label
    Friend WithEvents lblAreaStatement As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents btnCalcArea As System.Windows.Forms.Button
    Friend WithEvents lblPerimeterStatement As System.Windows.Forms.Label
    Friend WithEvents lblPerimeter As System.Windows.Forms.Label
    Friend WithEvents btnCalcPerimeter As System.Windows.Forms.Button
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox

End Class
