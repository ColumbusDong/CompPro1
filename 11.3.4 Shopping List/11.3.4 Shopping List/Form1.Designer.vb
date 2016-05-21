<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShoppingList
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
        Me.lblItems = New System.Windows.Forms.Label()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.lstShoppingList = New System.Windows.Forms.ListBox()
        Me.lblShoppingList = New System.Windows.Forms.Label()
        Me.txtItems = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnToList = New System.Windows.Forms.Button()
        Me.btnToItems = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCoupon = New System.Windows.Forms.Button()
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(92, 44)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(66, 26)
        Me.lblItems.TabIndex = 0
        Me.lblItems.Text = "Items"
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(571, 24)
        Me.mnuMenu.TabIndex = 1
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lstItems
        '
        Me.lstItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.ItemHeight = 16
        Me.lstItems.Location = New System.Drawing.Point(25, 73)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(211, 276)
        Me.lstItems.TabIndex = 2
        '
        'lstShoppingList
        '
        Me.lstShoppingList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstShoppingList.FormattingEnabled = True
        Me.lstShoppingList.ItemHeight = 16
        Me.lstShoppingList.Location = New System.Drawing.Point(328, 73)
        Me.lstShoppingList.Name = "lstShoppingList"
        Me.lstShoppingList.Size = New System.Drawing.Size(211, 276)
        Me.lstShoppingList.TabIndex = 3
        '
        'lblShoppingList
        '
        Me.lblShoppingList.AutoSize = True
        Me.lblShoppingList.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShoppingList.Location = New System.Drawing.Point(366, 44)
        Me.lblShoppingList.Name = "lblShoppingList"
        Me.lblShoppingList.Size = New System.Drawing.Size(144, 26)
        Me.lblShoppingList.TabIndex = 4
        Me.lblShoppingList.Text = "Shopping List"
        '
        'txtItems
        '
        Me.txtItems.Location = New System.Drawing.Point(167, 356)
        Me.txtItems.Name = "txtItems"
        Me.txtItems.Size = New System.Drawing.Size(153, 20)
        Me.txtItems.TabIndex = 5
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(326, 353)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 6
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnToList
        '
        Me.btnToList.BackgroundImage = Global._11._3._4_Shopping_List.My.Resources.Resources.Right_Arrow
        Me.btnToList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToList.Location = New System.Drawing.Point(242, 126)
        Me.btnToList.Name = "btnToList"
        Me.btnToList.Size = New System.Drawing.Size(80, 53)
        Me.btnToList.TabIndex = 7
        Me.btnToList.UseVisualStyleBackColor = True
        '
        'btnToItems
        '
        Me.btnToItems.BackgroundImage = Global._11._3._4_Shopping_List.My.Resources.Resources.Left_Arrow
        Me.btnToItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToItems.Location = New System.Drawing.Point(242, 194)
        Me.btnToItems.Name = "btnToItems"
        Me.btnToItems.Size = New System.Drawing.Size(80, 53)
        Me.btnToItems.TabIndex = 8
        Me.btnToItems.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(25, 382)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(211, 31)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCoupon
        '
        Me.btnCoupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoupon.Location = New System.Drawing.Point(328, 382)
        Me.btnCoupon.Name = "btnCoupon"
        Me.btnCoupon.Size = New System.Drawing.Size(211, 31)
        Me.btnCoupon.TabIndex = 10
        Me.btnCoupon.Text = "Add Coupon"
        Me.btnCoupon.UseVisualStyleBackColor = True
        '
        'frmShoppingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 429)
        Me.Controls.Add(Me.btnCoupon)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnToItems)
        Me.Controls.Add(Me.btnToList)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtItems)
        Me.Controls.Add(Me.lblShoppingList)
        Me.Controls.Add(Me.lstShoppingList)
        Me.Controls.Add(Me.lstItems)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.mnuMenu)
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "frmShoppingList"
        Me.Text = "Shopping List"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents lstShoppingList As System.Windows.Forms.ListBox
    Friend WithEvents lblShoppingList As System.Windows.Forms.Label
    Friend WithEvents txtItems As System.Windows.Forms.TextBox
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnToList As System.Windows.Forms.Button
    Friend WithEvents btnToItems As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCoupon As System.Windows.Forms.Button

End Class
