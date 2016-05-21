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
        Me.btnPopulate = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDynamic = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPopulate
        '
        Me.btnPopulate.Location = New System.Drawing.Point(170, 51)
        Me.btnPopulate.Name = "btnPopulate"
        Me.btnPopulate.Size = New System.Drawing.Size(134, 33)
        Me.btnPopulate.TabIndex = 4
        Me.btnPopulate.Text = "Populate Array"
        Me.btnPopulate.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(170, 12)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(134, 33)
        Me.btnCreate.TabIndex = 3
        Me.btnCreate.Text = "Create Array"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.Location = New System.Drawing.Point(12, 12)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(152, 251)
        Me.lstNames.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(170, 90)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(134, 33)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search Array"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDynamic
        '
        Me.btnDynamic.Location = New System.Drawing.Point(170, 129)
        Me.btnDynamic.Name = "btnDynamic"
        Me.btnDynamic.Size = New System.Drawing.Size(134, 33)
        Me.btnDynamic.TabIndex = 7
        Me.btnDynamic.Text = "Dynamic Array"
        Me.btnDynamic.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 293)
        Me.Controls.Add(Me.btnDynamic)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.btnPopulate)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "Form1"
        Me.Text = "Arrays and List Boxes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPopulate As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDynamic As System.Windows.Forms.Button

End Class
