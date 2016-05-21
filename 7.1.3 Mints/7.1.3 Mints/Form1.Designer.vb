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
        Me.lblMintPrompt = New System.Windows.Forms.Label()
        Me.txtMints = New System.Windows.Forms.TextBox()
        Me.lblMintServings = New System.Windows.Forms.Label()
        Me.lblMintsLeft = New System.Windows.Forms.Label()
        Me.lblServings = New System.Windows.Forms.Label()
        Me.lblLeftOver = New System.Windows.Forms.Label()
        Me.lblCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMintPrompt
        '
        Me.lblMintPrompt.AutoSize = True
        Me.lblMintPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMintPrompt.Location = New System.Drawing.Point(12, 27)
        Me.lblMintPrompt.Name = "lblMintPrompt"
        Me.lblMintPrompt.Size = New System.Drawing.Size(175, 17)
        Me.lblMintPrompt.TabIndex = 0
        Me.lblMintPrompt.Text = "Enter the number of mints:"
        '
        'txtMints
        '
        Me.txtMints.Location = New System.Drawing.Point(193, 27)
        Me.txtMints.Name = "txtMints"
        Me.txtMints.Size = New System.Drawing.Size(45, 20)
        Me.txtMints.TabIndex = 1
        '
        'lblMintServings
        '
        Me.lblMintServings.AutoSize = True
        Me.lblMintServings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMintServings.Location = New System.Drawing.Point(66, 66)
        Me.lblMintServings.Name = "lblMintServings"
        Me.lblMintServings.Size = New System.Drawing.Size(0, 17)
        Me.lblMintServings.TabIndex = 2
        '
        'lblMintsLeft
        '
        Me.lblMintsLeft.AutoSize = True
        Me.lblMintsLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMintsLeft.Location = New System.Drawing.Point(66, 102)
        Me.lblMintsLeft.Name = "lblMintsLeft"
        Me.lblMintsLeft.Size = New System.Drawing.Size(0, 17)
        Me.lblMintsLeft.TabIndex = 3
        '
        'lblServings
        '
        Me.lblServings.AutoSize = True
        Me.lblServings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServings.Location = New System.Drawing.Point(91, 66)
        Me.lblServings.Name = "lblServings"
        Me.lblServings.Size = New System.Drawing.Size(184, 17)
        Me.lblServings.TabIndex = 4
        Me.lblServings.Text = "Number of servings per bag"
        '
        'lblLeftOver
        '
        Me.lblLeftOver.AutoSize = True
        Me.lblLeftOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeftOver.Location = New System.Drawing.Point(91, 102)
        Me.lblLeftOver.Name = "lblLeftOver"
        Me.lblLeftOver.Size = New System.Drawing.Size(96, 17)
        Me.lblLeftOver.TabIndex = 5
        Me.lblLeftOver.Text = "Mints left over"
        '
        'lblCalculate
        '
        Me.lblCalculate.Location = New System.Drawing.Point(69, 170)
        Me.lblCalculate.Name = "lblCalculate"
        Me.lblCalculate.Size = New System.Drawing.Size(136, 50)
        Me.lblCalculate.TabIndex = 6
        Me.lblCalculate.Text = "Calculate"
        Me.lblCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblCalculate)
        Me.Controls.Add(Me.lblLeftOver)
        Me.Controls.Add(Me.lblServings)
        Me.Controls.Add(Me.lblMintsLeft)
        Me.Controls.Add(Me.lblMintServings)
        Me.Controls.Add(Me.txtMints)
        Me.Controls.Add(Me.lblMintPrompt)
        Me.Name = "Form1"
        Me.Text = "Mints"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMintPrompt As System.Windows.Forms.Label
    Friend WithEvents txtMints As System.Windows.Forms.TextBox
    Friend WithEvents lblMintServings As System.Windows.Forms.Label
    Friend WithEvents lblMintsLeft As System.Windows.Forms.Label
    Friend WithEvents lblServings As System.Windows.Forms.Label
    Friend WithEvents lblLeftOver As System.Windows.Forms.Label
    Friend WithEvents lblCalculate As System.Windows.Forms.Button

End Class
