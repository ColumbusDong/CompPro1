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
        Me.lblEnterGuess = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblNumTriesPrompt = New System.Windows.Forms.Label()
        Me.lblNumOfTries = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblEnterGuess
        '
        Me.lblEnterGuess.AutoSize = True
        Me.lblEnterGuess.Location = New System.Drawing.Point(12, 42)
        Me.lblEnterGuess.Name = "lblEnterGuess"
        Me.lblEnterGuess.Size = New System.Drawing.Size(120, 13)
        Me.lblEnterGuess.TabIndex = 0
        Me.lblEnterGuess.Text = "Please enter your guess"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(138, 42)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(52, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(197, 42)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(75, 23)
        Me.btnGuess.TabIndex = 2
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(94, 104)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 17)
        Me.lblOutput.TabIndex = 3
        '
        'lblNumTriesPrompt
        '
        Me.lblNumTriesPrompt.AutoSize = True
        Me.lblNumTriesPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumTriesPrompt.Location = New System.Drawing.Point(15, 136)
        Me.lblNumTriesPrompt.Name = "lblNumTriesPrompt"
        Me.lblNumTriesPrompt.Size = New System.Drawing.Size(94, 15)
        Me.lblNumTriesPrompt.TabIndex = 4
        Me.lblNumTriesPrompt.Text = "Number of tries:"
        '
        'lblNumOfTries
        '
        Me.lblNumOfTries.AutoSize = True
        Me.lblNumOfTries.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfTries.Location = New System.Drawing.Point(115, 136)
        Me.lblNumOfTries.Name = "lblNumOfTries"
        Me.lblNumOfTries.Size = New System.Drawing.Size(0, 15)
        Me.lblNumOfTries.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblNumOfTries)
        Me.Controls.Add(Me.lblNumTriesPrompt)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblEnterGuess)
        Me.Name = "Form1"
        Me.Text = "Guess"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterGuess As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblNumTriesPrompt As System.Windows.Forms.Label
    Friend WithEvents lblNumOfTries As System.Windows.Forms.Label

End Class
