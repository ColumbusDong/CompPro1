Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Declare variable
        Dim dblTotal As Double = 6
        'If/Then Statement, The program uses a if/then decision making statement
        If chkAddPepperoni.Checked Then 'If Add Pepperoni is checked, then add 1.5 to dblTotal
            dblTotal += 1.5
        End If

        If chkAddMushroom.Checked Then ' If Add Pepperoni is checked, then add .75 to dblTotal
            dblTotal += 0.75
        End If

        If chkAddOnion.Checked Then 'If Add Onion is chcked, then add 1 to dbltotal
            dblTotal += 1.0
        End If

        lblOutput.Text = "Your total is " & "$" & dblTotal 'Produces the Written text in the program
    End Sub
End Class
