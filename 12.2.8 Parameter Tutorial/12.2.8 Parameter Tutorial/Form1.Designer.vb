<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParameters
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
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblNumbersPrompt = New System.Windows.Forms.Label()
        Me.lblTotalPrompt = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(272, 120)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 17)
        Me.lblTotal.TabIndex = 11
        '
        'lblNumbersPrompt
        '
        Me.lblNumbersPrompt.AutoSize = True
        Me.lblNumbersPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumbersPrompt.Location = New System.Drawing.Point(12, 25)
        Me.lblNumbersPrompt.Name = "lblNumbersPrompt"
        Me.lblNumbersPrompt.Size = New System.Drawing.Size(231, 17)
        Me.lblNumbersPrompt.TabIndex = 10
        Me.lblNumbersPrompt.Text = "Enter two numbers to add together:"
        '
        'lblTotalPrompt
        '
        Me.lblTotalPrompt.AutoSize = True
        Me.lblTotalPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrompt.Location = New System.Drawing.Point(12, 120)
        Me.lblTotalPrompt.Name = "lblTotalPrompt"
        Me.lblTotalPrompt.Size = New System.Drawing.Size(236, 17)
        Me.lblTotalPrompt.TabIndex = 9
        Me.lblTotalPrompt.Text = "The two numbers added together is:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(275, 59)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(145, 62)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 7
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(15, 62)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 6
        '
        'frmParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 284)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblNumbersPrompt)
        Me.Controls.Add(Me.lblTotalPrompt)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Name = "frmParameters"
        Me.Text = "Parameter Tutorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblNumbersPrompt As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrompt As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox

End Class
