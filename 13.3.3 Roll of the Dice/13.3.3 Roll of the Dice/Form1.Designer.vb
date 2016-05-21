<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiceRolls
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
        Me.lblRollPrompt = New System.Windows.Forms.Label()
        Me.txtRolls = New System.Windows.Forms.TextBox()
        Me.btnRolls = New System.Windows.Forms.Button()
        Me.lstRolls = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblRollPrompt
        '
        Me.lblRollPrompt.AutoSize = True
        Me.lblRollPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRollPrompt.ForeColor = System.Drawing.Color.White
        Me.lblRollPrompt.Location = New System.Drawing.Point(25, 37)
        Me.lblRollPrompt.Name = "lblRollPrompt"
        Me.lblRollPrompt.Size = New System.Drawing.Size(229, 24)
        Me.lblRollPrompt.TabIndex = 0
        Me.lblRollPrompt.Text = "How many rolls are there?"
        '
        'txtRolls
        '
        Me.txtRolls.Location = New System.Drawing.Point(261, 40)
        Me.txtRolls.Name = "txtRolls"
        Me.txtRolls.Size = New System.Drawing.Size(100, 20)
        Me.txtRolls.TabIndex = 1
        '
        'btnRolls
        '
        Me.btnRolls.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRolls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRolls.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRolls.Location = New System.Drawing.Point(367, 26)
        Me.btnRolls.Name = "btnRolls"
        Me.btnRolls.Size = New System.Drawing.Size(151, 47)
        Me.btnRolls.TabIndex = 2
        Me.btnRolls.Text = "Roll the Dice"
        Me.btnRolls.UseVisualStyleBackColor = False
        '
        'lstRolls
        '
        Me.lstRolls.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRolls.FormattingEnabled = True
        Me.lstRolls.ItemHeight = 20
        Me.lstRolls.Location = New System.Drawing.Point(29, 88)
        Me.lstRolls.Name = "lstRolls"
        Me.lstRolls.Size = New System.Drawing.Size(489, 244)
        Me.lstRolls.TabIndex = 3
        '
        'frmDiceRolls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(541, 383)
        Me.Controls.Add(Me.lstRolls)
        Me.Controls.Add(Me.btnRolls)
        Me.Controls.Add(Me.txtRolls)
        Me.Controls.Add(Me.lblRollPrompt)
        Me.Name = "frmDiceRolls"
        Me.Text = "Roll of the Dice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRollPrompt As System.Windows.Forms.Label
    Friend WithEvents txtRolls As System.Windows.Forms.TextBox
    Friend WithEvents btnRolls As System.Windows.Forms.Button
    Friend WithEvents lstRolls As System.Windows.Forms.ListBox

End Class
