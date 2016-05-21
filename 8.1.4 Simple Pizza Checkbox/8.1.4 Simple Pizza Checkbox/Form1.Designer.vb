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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblPizzaPrompt = New System.Windows.Forms.Label()
        Me.chkAddPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkAddMushroom = New System.Windows.Forms.CheckBox()
        Me.chkAddOnion = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(250, 44)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(126, 29)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(12, 48)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 25)
        Me.lblOutput.TabIndex = 1
        '
        'lblPizzaPrompt
        '
        Me.lblPizzaPrompt.AutoSize = True
        Me.lblPizzaPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizzaPrompt.Location = New System.Drawing.Point(6, 95)
        Me.lblPizzaPrompt.Name = "lblPizzaPrompt"
        Me.lblPizzaPrompt.Size = New System.Drawing.Size(370, 20)
        Me.lblPizzaPrompt.TabIndex = 2
        Me.lblPizzaPrompt.Text = "Pizzas are $6.00 each. What would you like to add?"
        '
        'chkAddPepperoni
        '
        Me.chkAddPepperoni.AutoSize = True
        Me.chkAddPepperoni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAddPepperoni.Location = New System.Drawing.Point(17, 129)
        Me.chkAddPepperoni.Name = "chkAddPepperoni"
        Me.chkAddPepperoni.Size = New System.Drawing.Size(171, 21)
        Me.chkAddPepperoni.TabIndex = 3
        Me.chkAddPepperoni.Text = "Add Pepperoni ($1.50)"
        Me.chkAddPepperoni.UseVisualStyleBackColor = True
        '
        'chkAddMushroom
        '
        Me.chkAddMushroom.AutoSize = True
        Me.chkAddMushroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAddMushroom.Location = New System.Drawing.Point(17, 165)
        Me.chkAddMushroom.Name = "chkAddMushroom"
        Me.chkAddMushroom.Size = New System.Drawing.Size(172, 21)
        Me.chkAddMushroom.TabIndex = 4
        Me.chkAddMushroom.Text = "Add Mushroom ($0.75)"
        Me.chkAddMushroom.UseVisualStyleBackColor = True
        '
        'chkAddOnion
        '
        Me.chkAddOnion.AutoSize = True
        Me.chkAddOnion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAddOnion.Location = New System.Drawing.Point(17, 202)
        Me.chkAddOnion.Name = "chkAddOnion"
        Me.chkAddOnion.Size = New System.Drawing.Size(155, 21)
        Me.chkAddOnion.TabIndex = 5
        Me.chkAddOnion.Text = "Add Onions ($1.00) "
        Me.chkAddOnion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 347)
        Me.Controls.Add(Me.chkAddOnion)
        Me.Controls.Add(Me.chkAddMushroom)
        Me.Controls.Add(Me.chkAddPepperoni)
        Me.Controls.Add(Me.lblPizzaPrompt)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Pizza Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblPizzaPrompt As System.Windows.Forms.Label
    Friend WithEvents chkAddPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents chkAddMushroom As System.Windows.Forms.CheckBox
    Friend WithEvents chkAddOnion As System.Windows.Forms.CheckBox

End Class
