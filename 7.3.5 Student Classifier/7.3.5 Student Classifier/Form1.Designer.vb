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
        Me.lblCreditPrompt = New System.Windows.Forms.Label()
        Me.lblClassificationPrompt = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.lblClassification = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCreditPrompt
        '
        Me.lblCreditPrompt.AutoSize = True
        Me.lblCreditPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditPrompt.Location = New System.Drawing.Point(46, 41)
        Me.lblCreditPrompt.Name = "lblCreditPrompt"
        Me.lblCreditPrompt.Size = New System.Drawing.Size(74, 25)
        Me.lblCreditPrompt.TabIndex = 0
        Me.lblCreditPrompt.Text = "Credits"
        '
        'lblClassificationPrompt
        '
        Me.lblClassificationPrompt.AutoSize = True
        Me.lblClassificationPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassificationPrompt.Location = New System.Drawing.Point(46, 94)
        Me.lblClassificationPrompt.Name = "lblClassificationPrompt"
        Me.lblClassificationPrompt.Size = New System.Drawing.Size(127, 25)
        Me.lblClassificationPrompt.TabIndex = 1
        Me.lblClassificationPrompt.Text = "Classification"
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(307, 47)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(63, 20)
        Me.txtUnits.TabIndex = 2
        '
        'lblClassification
        '
        Me.lblClassification.AutoSize = True
        Me.lblClassification.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassification.Location = New System.Drawing.Point(302, 94)
        Me.lblClassification.Name = "lblClassification"
        Me.lblClassification.Size = New System.Drawing.Size(0, 25)
        Me.lblClassification.TabIndex = 3
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(51, 155)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(91, 49)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(176, 155)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 49)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(298, 155)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(98, 49)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox.Image = Global._7._3._5_Student_Classifier.My.Resources.Resources.teacher1
        Me.PictureBox.Location = New System.Drawing.Point(127, 250)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox.TabIndex = 7
        Me.PictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(430, 495)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblClassification)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.lblClassificationPrompt)
        Me.Controls.Add(Me.lblCreditPrompt)
        Me.Name = "Form1"
        Me.Text = "Student Classifier"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCreditPrompt As System.Windows.Forms.Label
    Friend WithEvents lblClassificationPrompt As System.Windows.Forms.Label
    Friend WithEvents txtUnits As System.Windows.Forms.TextBox
    Friend WithEvents lblClassification As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox

End Class
