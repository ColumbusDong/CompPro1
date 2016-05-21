<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageGrades
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblGrade1 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblGrade4 = New System.Windows.Forms.Label()
        Me.lblGrade3 = New System.Windows.Forms.Label()
        Me.lblGrade5 = New System.Windows.Forms.Label()
        Me.lblGrade2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(13, 13)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(274, 60)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate your Average"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblGrade1
        '
        Me.lblGrade1.AutoSize = True
        Me.lblGrade1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade1.Location = New System.Drawing.Point(25, 13)
        Me.lblGrade1.Name = "lblGrade1"
        Me.lblGrade1.Size = New System.Drawing.Size(0, 20)
        Me.lblGrade1.TabIndex = 1
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(25, 124)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(0, 20)
        Me.lblAverage.TabIndex = 2
        '
        'lblGrade4
        '
        Me.lblGrade4.AutoSize = True
        Me.lblGrade4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade4.Location = New System.Drawing.Point(25, 73)
        Me.lblGrade4.Name = "lblGrade4"
        Me.lblGrade4.Size = New System.Drawing.Size(0, 20)
        Me.lblGrade4.TabIndex = 3
        '
        'lblGrade3
        '
        Me.lblGrade3.AutoSize = True
        Me.lblGrade3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade3.Location = New System.Drawing.Point(25, 53)
        Me.lblGrade3.Name = "lblGrade3"
        Me.lblGrade3.Size = New System.Drawing.Size(0, 20)
        Me.lblGrade3.TabIndex = 4
        '
        'lblGrade5
        '
        Me.lblGrade5.AutoSize = True
        Me.lblGrade5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade5.Location = New System.Drawing.Point(25, 93)
        Me.lblGrade5.Name = "lblGrade5"
        Me.lblGrade5.Size = New System.Drawing.Size(0, 20)
        Me.lblGrade5.TabIndex = 5
        '
        'lblGrade2
        '
        Me.lblGrade2.AutoSize = True
        Me.lblGrade2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade2.Location = New System.Drawing.Point(25, 33)
        Me.lblGrade2.Name = "lblGrade2"
        Me.lblGrade2.Size = New System.Drawing.Size(0, 20)
        Me.lblGrade2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblGrade5)
        Me.Panel1.Controls.Add(Me.lblGrade2)
        Me.Panel1.Controls.Add(Me.lblGrade1)
        Me.Panel1.Controls.Add(Me.lblAverage)
        Me.Panel1.Controls.Add(Me.lblGrade3)
        Me.Panel1.Controls.Add(Me.lblGrade4)
        Me.Panel1.Location = New System.Drawing.Point(13, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(274, 193)
        Me.Panel1.TabIndex = 7
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(42, 290)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(220, 52)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmAverageGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 417)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmAverageGrades"
        Me.Text = "Average Grades"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblGrade1 As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblGrade4 As System.Windows.Forms.Label
    Friend WithEvents lblGrade3 As System.Windows.Forms.Label
    Friend WithEvents lblGrade5 As System.Windows.Forms.Label
    Friend WithEvents lblGrade2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
