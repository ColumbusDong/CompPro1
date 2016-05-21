Public Class Form1
    'Created by Columbus Dong
    'Beauty School Dropout Assignment
    'October 15, 2013
    Dim dblCost As Double = 0 'Declare a variable called dblCost
    Dim dblDiscount As Double
    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
    Private Sub chkHair_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHair.CheckedChanged
        If chkHair.Checked = True Then 'If Hair makeover is checked, add 60 to dblCost
            dblCost += 60
        End If

        If chkHair.Checked = False Then 'If Hair makeover is checkd, then uncheck subtract 60
            dblCost -= 60
        End If
    End Sub

    Private Sub chkMakeUp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMakeUp.CheckedChanged
        If chkMakeUp.Checked = True Then 'If Make Up make over is checked, then add 65 to dblCost
            dblCost += 65
        End If

        If chkMakeUp.Checked = False Then 'If Make up is checked,t hen unchecked, subtract 65
            dblCost -= 65
        End If
    End Sub

    Private Sub chkPhoto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPhoto.CheckedChanged
        If chkPhoto.Checked = True Then 'If Photo Session is checked, then add 125 to dblCost
            dblCost += 125
        End If

        If chkPhoto.Checked = False Then 'If Photo Session is checked, then unchecked, subtract 125
            dblCost -= 125
        End If
    End Sub
    Private Sub chkPackage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPackage.CheckedChanged
        If chkPackage.Checked = True Then 'Make it so when Package is clicked, the others are unselected
            chkHair.Checked = False
            chkMakeUp.Checked = False
            chkPhoto.Checked = False
        End If

        If chkPackage.Checked = True Then 'If Comprehensive package is checked, then add 195 to dblCost
            dblCost = 195.0
        End If
    End Sub
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Select Case True 'Check if any of the coupon options are checked and if they are, calculate the total with the discount
            Case radNoCoupon.Checked
                dblDiscount = dblCost
            Case radDiscount1.Checked
                dblDiscount = dblCost - (0.1 * dblCost)
            Case radDiscount2.Checked
                dblDiscount = dblCost - (0.15 * dblCost)
            Case Else
                MessageBox.Show("Please select one of the coupon options")
        End Select

        lblTotalBefore.Text = dblCost.ToString("##.00") 'Put dblCost in a currency format
        lblTotalAfter.Text = dblDiscount.ToString("##.00") 'Put dblDiscount in a currency format
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Set the values of the variables back to 0
        dblCost = 0
        dblDiscount = 0
        'Clear out the labels
        lblTotalBefore.Text = Nothing
        lblTotalAfter.Text = Nothing
        'Uncheck the coupon options
        radDiscount1.Checked = False
        radDiscount2.Checked = False
        radNoCoupon.Checked = False
        'Uncheck the modeling options
        chkHair.Checked = False
        chkMakeUp.Checked = False
        chkPackage.Checked = False
        chkPhoto.Checked = False
    End Sub
End Class
