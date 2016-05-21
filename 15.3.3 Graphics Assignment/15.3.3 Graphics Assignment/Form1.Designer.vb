<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraphics
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
        Me.btnLine = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnArc = New System.Windows.Forms.Button()
        Me.btnEllipse = New System.Windows.Forms.Button()
        Me.btnRectangle = New System.Windows.Forms.Button()
        Me.LineColor1 = New System.Windows.Forms.ColorDialog()
        Me.LineColor2 = New System.Windows.Forms.ColorDialog()
        Me.btnOther = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLine
        '
        Me.btnLine.BackColor = System.Drawing.Color.Maroon
        Me.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLine.ForeColor = System.Drawing.Color.White
        Me.btnLine.Location = New System.Drawing.Point(12, 58)
        Me.btnLine.Name = "btnLine"
        Me.btnLine.Size = New System.Drawing.Size(120, 40)
        Me.btnLine.TabIndex = 0
        Me.btnLine.Text = "Draw Line"
        Me.btnLine.UseVisualStyleBackColor = False
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.Color.Maroon
        Me.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColor.ForeColor = System.Drawing.Color.White
        Me.btnColor.Location = New System.Drawing.Point(12, 12)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(120, 40)
        Me.btnColor.TabIndex = 1
        Me.btnColor.Text = "Choose Color"
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'btnArc
        '
        Me.btnArc.BackColor = System.Drawing.Color.Maroon
        Me.btnArc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArc.ForeColor = System.Drawing.Color.White
        Me.btnArc.Location = New System.Drawing.Point(12, 104)
        Me.btnArc.Name = "btnArc"
        Me.btnArc.Size = New System.Drawing.Size(120, 40)
        Me.btnArc.TabIndex = 2
        Me.btnArc.Text = "Draw Arc"
        Me.btnArc.UseVisualStyleBackColor = False
        '
        'btnEllipse
        '
        Me.btnEllipse.BackColor = System.Drawing.Color.Maroon
        Me.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEllipse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEllipse.ForeColor = System.Drawing.Color.White
        Me.btnEllipse.Location = New System.Drawing.Point(12, 196)
        Me.btnEllipse.Name = "btnEllipse"
        Me.btnEllipse.Size = New System.Drawing.Size(120, 40)
        Me.btnEllipse.TabIndex = 3
        Me.btnEllipse.Text = "Draw Ellipse"
        Me.btnEllipse.UseVisualStyleBackColor = False
        '
        'btnRectangle
        '
        Me.btnRectangle.BackColor = System.Drawing.Color.Maroon
        Me.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRectangle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRectangle.ForeColor = System.Drawing.Color.White
        Me.btnRectangle.Location = New System.Drawing.Point(12, 150)
        Me.btnRectangle.Name = "btnRectangle"
        Me.btnRectangle.Size = New System.Drawing.Size(120, 40)
        Me.btnRectangle.TabIndex = 4
        Me.btnRectangle.Text = "Draw Rectangle"
        Me.btnRectangle.UseVisualStyleBackColor = False
        '
        'btnOther
        '
        Me.btnOther.BackColor = System.Drawing.Color.Maroon
        Me.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOther.ForeColor = System.Drawing.Color.White
        Me.btnOther.Location = New System.Drawing.Point(12, 242)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(120, 40)
        Me.btnOther.TabIndex = 5
        Me.btnOther.Text = "Draw Shapes"
        Me.btnOther.UseVisualStyleBackColor = False
        '
        'frmGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.btnOther)
        Me.Controls.Add(Me.btnRectangle)
        Me.Controls.Add(Me.btnEllipse)
        Me.Controls.Add(Me.btnArc)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnLine)
        Me.Name = "frmGraphics"
        Me.Text = "Graphics"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLine As System.Windows.Forms.Button
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents btnArc As System.Windows.Forms.Button
    Friend WithEvents btnEllipse As System.Windows.Forms.Button
    Friend WithEvents btnRectangle As System.Windows.Forms.Button
    Friend WithEvents LineColor1 As System.Windows.Forms.ColorDialog
    Friend WithEvents LineColor2 As System.Windows.Forms.ColorDialog
    Friend WithEvents btnOther As System.Windows.Forms.Button

End Class
