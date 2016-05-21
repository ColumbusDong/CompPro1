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
        Me.lblHairPrice = New System.Windows.Forms.Label()
        Me.lblMakeUpPrice = New System.Windows.Forms.Label()
        Me.lblPhotoPrice = New System.Windows.Forms.Label()
        Me.lblPackagePrice = New System.Windows.Forms.Label()
        Me.lblPrices = New System.Windows.Forms.Label()
        Me.lblServicePrompt = New System.Windows.Forms.Label()
        Me.chkHair = New System.Windows.Forms.CheckBox()
        Me.chkMakeUp = New System.Windows.Forms.CheckBox()
        Me.chkPhoto = New System.Windows.Forms.CheckBox()
        Me.chkPackage = New System.Windows.Forms.CheckBox()
        Me.pnlAdvertisedPrices = New System.Windows.Forms.Panel()
        Me.lblDiscountPrompt = New System.Windows.Forms.Label()
        Me.lblTotalBeforePrompt = New System.Windows.Forms.Label()
        Me.lblTotalAfterPrompt = New System.Windows.Forms.Label()
        Me.lblTotalBefore = New System.Windows.Forms.Label()
        Me.lblTotalAfter = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpDiscounts = New System.Windows.Forms.GroupBox()
        Me.radDiscount2 = New System.Windows.Forms.RadioButton()
        Me.radDiscount1 = New System.Windows.Forms.RadioButton()
        Me.radNoCoupon = New System.Windows.Forms.RadioButton()
        Me.pnlAdvertisedPrices.SuspendLayout()
        Me.grpDiscounts.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHairPrice
        '
        Me.lblHairPrice.AutoSize = True
        Me.lblHairPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHairPrice.Location = New System.Drawing.Point(283, 47)
        Me.lblHairPrice.Name = "lblHairPrice"
        Me.lblHairPrice.Size = New System.Drawing.Size(57, 18)
        Me.lblHairPrice.TabIndex = 4
        Me.lblHairPrice.Text = "$60.00"
        '
        'lblMakeUpPrice
        '
        Me.lblMakeUpPrice.AutoSize = True
        Me.lblMakeUpPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMakeUpPrice.Location = New System.Drawing.Point(283, 76)
        Me.lblMakeUpPrice.Name = "lblMakeUpPrice"
        Me.lblMakeUpPrice.Size = New System.Drawing.Size(57, 18)
        Me.lblMakeUpPrice.TabIndex = 5
        Me.lblMakeUpPrice.Text = "$65.00"
        '
        'lblPhotoPrice
        '
        Me.lblPhotoPrice.AutoSize = True
        Me.lblPhotoPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhotoPrice.Location = New System.Drawing.Point(283, 104)
        Me.lblPhotoPrice.Name = "lblPhotoPrice"
        Me.lblPhotoPrice.Size = New System.Drawing.Size(66, 18)
        Me.lblPhotoPrice.TabIndex = 6
        Me.lblPhotoPrice.Text = "$125.00"
        '
        'lblPackagePrice
        '
        Me.lblPackagePrice.AutoSize = True
        Me.lblPackagePrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackagePrice.Location = New System.Drawing.Point(283, 129)
        Me.lblPackagePrice.Name = "lblPackagePrice"
        Me.lblPackagePrice.Size = New System.Drawing.Size(66, 18)
        Me.lblPackagePrice.TabIndex = 8
        Me.lblPackagePrice.Text = "$195.00"
        '
        'lblPrices
        '
        Me.lblPrices.AutoSize = True
        Me.lblPrices.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrices.Location = New System.Drawing.Point(288, 11)
        Me.lblPrices.Name = "lblPrices"
        Me.lblPrices.Size = New System.Drawing.Size(61, 25)
        Me.lblPrices.TabIndex = 9
        Me.lblPrices.Text = "Price"
        '
        'lblServicePrompt
        '
        Me.lblServicePrompt.AutoSize = True
        Me.lblServicePrompt.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicePrompt.Location = New System.Drawing.Point(4, 11)
        Me.lblServicePrompt.Name = "lblServicePrompt"
        Me.lblServicePrompt.Size = New System.Drawing.Size(98, 24)
        Me.lblServicePrompt.TabIndex = 0
        Me.lblServicePrompt.Text = "Services:"
        '
        'chkHair
        '
        Me.chkHair.AutoSize = True
        Me.chkHair.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHair.Location = New System.Drawing.Point(8, 46)
        Me.chkHair.Name = "chkHair"
        Me.chkHair.Size = New System.Drawing.Size(129, 22)
        Me.chkHair.TabIndex = 10
        Me.chkHair.Text = "Hair makeover"
        Me.chkHair.UseVisualStyleBackColor = True
        '
        'chkMakeUp
        '
        Me.chkMakeUp.AutoSize = True
        Me.chkMakeUp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMakeUp.Location = New System.Drawing.Point(8, 72)
        Me.chkMakeUp.Name = "chkMakeUp"
        Me.chkMakeUp.Size = New System.Drawing.Size(161, 22)
        Me.chkMakeUp.TabIndex = 11
        Me.chkMakeUp.Text = "Make-up makeover"
        Me.chkMakeUp.UseVisualStyleBackColor = True
        '
        'chkPhoto
        '
        Me.chkPhoto.AutoSize = True
        Me.chkPhoto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPhoto.Location = New System.Drawing.Point(8, 100)
        Me.chkPhoto.Name = "chkPhoto"
        Me.chkPhoto.Size = New System.Drawing.Size(176, 22)
        Me.chkPhoto.TabIndex = 12
        Me.chkPhoto.Text = "Model Photo Session"
        Me.chkPhoto.UseVisualStyleBackColor = True
        '
        'chkPackage
        '
        Me.chkPackage.AutoSize = True
        Me.chkPackage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPackage.Location = New System.Drawing.Point(8, 128)
        Me.chkPackage.Name = "chkPackage"
        Me.chkPackage.Size = New System.Drawing.Size(204, 22)
        Me.chkPackage.TabIndex = 13
        Me.chkPackage.Text = "Comprehensive Package"
        Me.chkPackage.UseVisualStyleBackColor = True
        '
        'pnlAdvertisedPrices
        '
        Me.pnlAdvertisedPrices.BackColor = System.Drawing.Color.Transparent
        Me.pnlAdvertisedPrices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAdvertisedPrices.Controls.Add(Me.lblPackagePrice)
        Me.pnlAdvertisedPrices.Controls.Add(Me.lblHairPrice)
        Me.pnlAdvertisedPrices.Controls.Add(Me.lblPrices)
        Me.pnlAdvertisedPrices.Controls.Add(Me.lblMakeUpPrice)
        Me.pnlAdvertisedPrices.Controls.Add(Me.lblPhotoPrice)
        Me.pnlAdvertisedPrices.Controls.Add(Me.chkPackage)
        Me.pnlAdvertisedPrices.Controls.Add(Me.chkHair)
        Me.pnlAdvertisedPrices.Controls.Add(Me.chkPhoto)
        Me.pnlAdvertisedPrices.Controls.Add(Me.lblServicePrompt)
        Me.pnlAdvertisedPrices.Controls.Add(Me.chkMakeUp)
        Me.pnlAdvertisedPrices.Location = New System.Drawing.Point(15, 12)
        Me.pnlAdvertisedPrices.Name = "pnlAdvertisedPrices"
        Me.pnlAdvertisedPrices.Size = New System.Drawing.Size(393, 168)
        Me.pnlAdvertisedPrices.TabIndex = 14
        '
        'lblDiscountPrompt
        '
        Me.lblDiscountPrompt.AutoSize = True
        Me.lblDiscountPrompt.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountPrompt.Location = New System.Drawing.Point(11, 194)
        Me.lblDiscountPrompt.Name = "lblDiscountPrompt"
        Me.lblDiscountPrompt.Size = New System.Drawing.Size(84, 22)
        Me.lblDiscountPrompt.TabIndex = 15
        Me.lblDiscountPrompt.Text = "Discount"
        '
        'lblTotalBeforePrompt
        '
        Me.lblTotalBeforePrompt.AutoSize = True
        Me.lblTotalBeforePrompt.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBeforePrompt.Location = New System.Drawing.Point(43, 263)
        Me.lblTotalBeforePrompt.Name = "lblTotalBeforePrompt"
        Me.lblTotalBeforePrompt.Size = New System.Drawing.Size(182, 21)
        Me.lblTotalBeforePrompt.TabIndex = 19
        Me.lblTotalBeforePrompt.Text = "Total before discount:"
        '
        'lblTotalAfterPrompt
        '
        Me.lblTotalAfterPrompt.AutoSize = True
        Me.lblTotalAfterPrompt.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAfterPrompt.Location = New System.Drawing.Point(43, 297)
        Me.lblTotalAfterPrompt.Name = "lblTotalAfterPrompt"
        Me.lblTotalAfterPrompt.Size = New System.Drawing.Size(167, 21)
        Me.lblTotalAfterPrompt.TabIndex = 20
        Me.lblTotalAfterPrompt.Text = "Total after discount:"
        '
        'lblTotalBefore
        '
        Me.lblTotalBefore.AutoSize = True
        Me.lblTotalBefore.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBefore.Location = New System.Drawing.Point(228, 266)
        Me.lblTotalBefore.Name = "lblTotalBefore"
        Me.lblTotalBefore.Size = New System.Drawing.Size(0, 18)
        Me.lblTotalBefore.TabIndex = 21
        '
        'lblTotalAfter
        '
        Me.lblTotalAfter.AutoSize = True
        Me.lblTotalAfter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAfter.Location = New System.Drawing.Point(228, 300)
        Me.lblTotalAfter.Name = "lblTotalAfter"
        Me.lblTotalAfter.Size = New System.Drawing.Size(0, 18)
        Me.lblTotalAfter.TabIndex = 22
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(24, 365)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(111, 50)
        Me.btnCalculate.TabIndex = 23
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(297, 365)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(111, 50)
        Me.btnQuit.TabIndex = 24
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(163, 365)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 50)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'grpDiscounts
        '
        Me.grpDiscounts.BackColor = System.Drawing.Color.Transparent
        Me.grpDiscounts.Controls.Add(Me.radDiscount2)
        Me.grpDiscounts.Controls.Add(Me.radDiscount1)
        Me.grpDiscounts.Controls.Add(Me.radNoCoupon)
        Me.grpDiscounts.Location = New System.Drawing.Point(101, 186)
        Me.grpDiscounts.Name = "grpDiscounts"
        Me.grpDiscounts.Size = New System.Drawing.Size(285, 37)
        Me.grpDiscounts.TabIndex = 26
        Me.grpDiscounts.TabStop = False
        '
        'radDiscount2
        '
        Me.radDiscount2.AutoSize = True
        Me.radDiscount2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDiscount2.Location = New System.Drawing.Point(197, 10)
        Me.radDiscount2.Name = "radDiscount2"
        Me.radDiscount2.Size = New System.Drawing.Size(79, 21)
        Me.radDiscount2.TabIndex = 2
        Me.radDiscount2.TabStop = True
        Me.radDiscount2.Text = "15% Off"
        Me.radDiscount2.UseVisualStyleBackColor = True
        '
        'radDiscount1
        '
        Me.radDiscount1.AutoSize = True
        Me.radDiscount1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDiscount1.Location = New System.Drawing.Point(112, 12)
        Me.radDiscount1.Name = "radDiscount1"
        Me.radDiscount1.Size = New System.Drawing.Size(79, 21)
        Me.radDiscount1.TabIndex = 1
        Me.radDiscount1.TabStop = True
        Me.radDiscount1.Text = "10% Off"
        Me.radDiscount1.UseVisualStyleBackColor = True
        '
        'radNoCoupon
        '
        Me.radNoCoupon.AutoSize = True
        Me.radNoCoupon.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNoCoupon.Location = New System.Drawing.Point(6, 10)
        Me.radNoCoupon.Name = "radNoCoupon"
        Me.radNoCoupon.Size = New System.Drawing.Size(99, 21)
        Me.radNoCoupon.TabIndex = 0
        Me.radNoCoupon.TabStop = True
        Me.radNoCoupon.Text = "No Coupon"
        Me.radNoCoupon.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(437, 483)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalAfter)
        Me.Controls.Add(Me.lblTotalBefore)
        Me.Controls.Add(Me.lblTotalAfterPrompt)
        Me.Controls.Add(Me.lblTotalBeforePrompt)
        Me.Controls.Add(Me.lblDiscountPrompt)
        Me.Controls.Add(Me.pnlAdvertisedPrices)
        Me.Controls.Add(Me.grpDiscounts)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Beauty School Dropout"
        Me.pnlAdvertisedPrices.ResumeLayout(False)
        Me.pnlAdvertisedPrices.PerformLayout()
        Me.grpDiscounts.ResumeLayout(False)
        Me.grpDiscounts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHairPrice As System.Windows.Forms.Label
    Friend WithEvents lblMakeUpPrice As System.Windows.Forms.Label
    Friend WithEvents lblPhotoPrice As System.Windows.Forms.Label
    Friend WithEvents lblPackagePrice As System.Windows.Forms.Label
    Friend WithEvents lblPrices As System.Windows.Forms.Label
    Friend WithEvents lblServicePrompt As System.Windows.Forms.Label
    Friend WithEvents chkHair As System.Windows.Forms.CheckBox
    Friend WithEvents chkMakeUp As System.Windows.Forms.CheckBox
    Friend WithEvents chkPhoto As System.Windows.Forms.CheckBox
    Friend WithEvents chkPackage As System.Windows.Forms.CheckBox
    Friend WithEvents pnlAdvertisedPrices As System.Windows.Forms.Panel
    Friend WithEvents lblDiscountPrompt As System.Windows.Forms.Label
    Friend WithEvents lblTotalBeforePrompt As System.Windows.Forms.Label
    Friend WithEvents lblTotalAfterPrompt As System.Windows.Forms.Label
    Friend WithEvents lblTotalBefore As System.Windows.Forms.Label
    Friend WithEvents lblTotalAfter As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents grpDiscounts As System.Windows.Forms.GroupBox
    Friend WithEvents radDiscount2 As System.Windows.Forms.RadioButton
    Friend WithEvents radDiscount1 As System.Windows.Forms.RadioButton
    Friend WithEvents radNoCoupon As System.Windows.Forms.RadioButton

End Class
