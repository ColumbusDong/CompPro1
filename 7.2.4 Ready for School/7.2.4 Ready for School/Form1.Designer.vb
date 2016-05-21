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
        Me.chkHomework = New System.Windows.Forms.CheckBox()
        Me.chkBreakfast = New System.Windows.Forms.CheckBox()
        Me.chkTeeth = New System.Windows.Forms.CheckBox()
        Me.btnReady = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkHomework
        '
        Me.chkHomework.AutoSize = True
        Me.chkHomework.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHomework.Location = New System.Drawing.Point(54, 36)
        Me.chkHomework.Name = "chkHomework"
        Me.chkHomework.Size = New System.Drawing.Size(156, 24)
        Me.chkHomework.TabIndex = 0
        Me.chkHomework.Text = "Homework Done?"
        Me.chkHomework.UseVisualStyleBackColor = True
        '
        'chkBreakfast
        '
        Me.chkBreakfast.AutoSize = True
        Me.chkBreakfast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBreakfast.Location = New System.Drawing.Point(54, 81)
        Me.chkBreakfast.Name = "chkBreakfast"
        Me.chkBreakfast.Size = New System.Drawing.Size(126, 24)
        Me.chkBreakfast.TabIndex = 1
        Me.chkBreakfast.Text = "Eat Breakfast"
        Me.chkBreakfast.UseVisualStyleBackColor = True
        '
        'chkTeeth
        '
        Me.chkTeeth.AutoSize = True
        Me.chkTeeth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTeeth.Location = New System.Drawing.Point(54, 124)
        Me.chkTeeth.Name = "chkTeeth"
        Me.chkTeeth.Size = New System.Drawing.Size(115, 24)
        Me.chkTeeth.TabIndex = 2
        Me.chkTeeth.Text = "Brush Teeth"
        Me.chkTeeth.UseVisualStyleBackColor = True
        '
        'btnReady
        '
        Me.btnReady.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReady.Location = New System.Drawing.Point(54, 282)
        Me.btnReady.Name = "btnReady"
        Me.btnReady.Size = New System.Drawing.Size(156, 64)
        Me.btnReady.TabIndex = 3
        Me.btnReady.Text = "Ready"
        Me.btnReady.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 395)
        Me.Controls.Add(Me.btnReady)
        Me.Controls.Add(Me.chkTeeth)
        Me.Controls.Add(Me.chkBreakfast)
        Me.Controls.Add(Me.chkHomework)
        Me.Name = "Form1"
        Me.Text = "Ready for School"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkHomework As System.Windows.Forms.CheckBox
    Friend WithEvents chkBreakfast As System.Windows.Forms.CheckBox
    Friend WithEvents chkTeeth As System.Windows.Forms.CheckBox
    Friend WithEvents btnReady As System.Windows.Forms.Button

End Class
