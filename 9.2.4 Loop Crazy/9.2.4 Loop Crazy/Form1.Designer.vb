﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnDoLoopWhile = New System.Windows.Forms.Button()
        Me.btnDoWhileLoop = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDoLoopWhile
        '
        Me.btnDoLoopWhile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoLoopWhile.Location = New System.Drawing.Point(12, 102)
        Me.btnDoLoopWhile.Name = "btnDoLoopWhile"
        Me.btnDoLoopWhile.Size = New System.Drawing.Size(124, 62)
        Me.btnDoLoopWhile.TabIndex = 0
        Me.btnDoLoopWhile.Text = "Do Loop While"
        Me.btnDoLoopWhile.UseVisualStyleBackColor = True
        '
        'btnDoWhileLoop
        '
        Me.btnDoWhileLoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoWhileLoop.Location = New System.Drawing.Point(12, 12)
        Me.btnDoWhileLoop.Name = "btnDoWhileLoop"
        Me.btnDoWhileLoop.Size = New System.Drawing.Size(124, 62)
        Me.btnDoWhileLoop.TabIndex = 1
        Me.btnDoWhileLoop.Text = "Do While Loop"
        Me.btnDoWhileLoop.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(255, 72)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 25)
        Me.lblOutput.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 176)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnDoWhileLoop)
        Me.Controls.Add(Me.btnDoLoopWhile)
        Me.Name = "Form1"
        Me.Text = "Loop Crazy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDoLoopWhile As System.Windows.Forms.Button
    Friend WithEvents btnDoWhileLoop As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label

End Class
