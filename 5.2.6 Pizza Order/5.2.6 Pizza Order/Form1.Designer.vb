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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCrustPrompt = New System.Windows.Forms.Label()
        Me.txtCrust = New System.Windows.Forms.TextBox()
        Me.lblCrustChoices = New System.Windows.Forms.Label()
        Me.lblTopping1Prompt = New System.Windows.Forms.Label()
        Me.txtTopping1 = New System.Windows.Forms.TextBox()
        Me.txtTopping2 = New System.Windows.Forms.TextBox()
        Me.lblTopping2Prompt = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.btnYourOrder = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(358, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnu
        '
        Me.mnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(37, 20)
        Me.mnu.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblCrustPrompt
        '
        Me.lblCrustPrompt.AutoSize = True
        Me.lblCrustPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrustPrompt.Location = New System.Drawing.Point(12, 83)
        Me.lblCrustPrompt.Name = "lblCrustPrompt"
        Me.lblCrustPrompt.Size = New System.Drawing.Size(193, 20)
        Me.lblCrustPrompt.TabIndex = 1
        Me.lblCrustPrompt.Text = "Enter your choice of crust:"
        '
        'txtCrust
        '
        Me.txtCrust.Location = New System.Drawing.Point(243, 85)
        Me.txtCrust.Name = "txtCrust"
        Me.txtCrust.Size = New System.Drawing.Size(100, 20)
        Me.txtCrust.TabIndex = 2
        '
        'lblCrustChoices
        '
        Me.lblCrustChoices.AutoSize = True
        Me.lblCrustChoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrustChoices.Location = New System.Drawing.Point(22, 103)
        Me.lblCrustChoices.Name = "lblCrustChoices"
        Me.lblCrustChoices.Size = New System.Drawing.Size(165, 20)
        Me.lblCrustChoices.TabIndex = 3
        Me.lblCrustChoices.Text = " (thin, thick, or regular)"
        '
        'lblTopping1Prompt
        '
        Me.lblTopping1Prompt.AutoSize = True
        Me.lblTopping1Prompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopping1Prompt.Location = New System.Drawing.Point(12, 149)
        Me.lblTopping1Prompt.Name = "lblTopping1Prompt"
        Me.lblTopping1Prompt.Size = New System.Drawing.Size(211, 20)
        Me.lblTopping1Prompt.TabIndex = 4
        Me.lblTopping1Prompt.Text = "Enter your choice of topping:"
        '
        'txtTopping1
        '
        Me.txtTopping1.Location = New System.Drawing.Point(243, 149)
        Me.txtTopping1.Name = "txtTopping1"
        Me.txtTopping1.Size = New System.Drawing.Size(100, 20)
        Me.txtTopping1.TabIndex = 5
        '
        'txtTopping2
        '
        Me.txtTopping2.Location = New System.Drawing.Point(243, 199)
        Me.txtTopping2.Name = "txtTopping2"
        Me.txtTopping2.Size = New System.Drawing.Size(100, 20)
        Me.txtTopping2.TabIndex = 7
        '
        'lblTopping2Prompt
        '
        Me.lblTopping2Prompt.AutoSize = True
        Me.lblTopping2Prompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopping2Prompt.Location = New System.Drawing.Point(12, 199)
        Me.lblTopping2Prompt.Name = "lblTopping2Prompt"
        Me.lblTopping2Prompt.Size = New System.Drawing.Size(211, 20)
        Me.lblTopping2Prompt.TabIndex = 6
        Me.lblTopping2Prompt.Text = "Enter your choice of topping:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(86, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(186, 37)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Pizza Order"
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(23, 257)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(0, 18)
        Me.lblOrder.TabIndex = 9
        '
        'btnYourOrder
        '
        Me.btnYourOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYourOrder.Location = New System.Drawing.Point(16, 311)
        Me.btnYourOrder.Name = "btnYourOrder"
        Me.btnYourOrder.Size = New System.Drawing.Size(327, 50)
        Me.btnYourOrder.TabIndex = 10
        Me.btnYourOrder.Text = "Your Order"
        Me.btnYourOrder.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 387)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnYourOrder)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtTopping2)
        Me.Controls.Add(Me.lblTopping2Prompt)
        Me.Controls.Add(Me.txtTopping1)
        Me.Controls.Add(Me.lblTopping1Prompt)
        Me.Controls.Add(Me.lblCrustChoices)
        Me.Controls.Add(Me.txtCrust)
        Me.Controls.Add(Me.lblCrustPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Pizza"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCrustPrompt As System.Windows.Forms.Label
    Friend WithEvents txtCrust As System.Windows.Forms.TextBox
    Friend WithEvents lblCrustChoices As System.Windows.Forms.Label
    Friend WithEvents lblTopping1Prompt As System.Windows.Forms.Label
    Friend WithEvents txtTopping1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTopping2 As System.Windows.Forms.TextBox
    Friend WithEvents lblTopping2Prompt As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents btnYourOrder As System.Windows.Forms.Button

End Class
