Public Class Form1
    'Columbus Dong
    'College Tuition Assignment
    'November 4, 2013

    'Declare variables
    Shared intCreditHourCost As Integer
    Shared intCreditHours As Integer
    Shared intOtherCosts As Integer = 0
    Private Sub lstCollege_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCollege.SelectedIndexChanged
        If lstCollege.SelectedIndex = 0 Then 'If MIT is selected, intCreditHourCost is 670
            intCreditHourCost = 670
        ElseIf lstCollege.SelectedIndex = 1 Then 'If Duke is selected, intCredHourCost is 1271
            intCreditHourCost = 1271
        ElseIf lstCollege.SelectedIndex = 2 Then 'If Appalachian is selected, intCreditHourCost is 557
            intCreditHourCost = 557
        End If
    End Sub

    Private Sub cboCreditHours_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCreditHours.SelectedIndexChanged
        intCreditHours = cboCreditHours.Text 'Set intCreditHours equal to the Text inside the combobox
    End Sub


    Private Sub chkLiving_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLiving.CheckedChanged
        If chkLiving.Checked = True Then
            intOtherCosts += 8000 'If checked, add 8000
        Else
            intOtherCosts -= 8000
        End If
    End Sub


    Private Sub chkBooks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBooks.CheckedChanged
        If chkBooks.Checked = True Then
            intOtherCosts += 1000 'if checked, add 1000
        Else
            intOtherCosts -= 1000
        End If
    End Sub

    Private Sub chkOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOther.CheckedChanged
        If chkOther.Checked = True Then
            intOtherCosts += 2000 'if checked, add 2000
        Else
            intOtherCosts -= 2000
        End If
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim intTuition As Integer 'Create a variable called Tuition

        intTuition = intCreditHours * intCreditHourCost + intOtherCosts'multiply the credit hours and the costs per credit then add intOthercosts
        lblOutput.Text = "$" & intTuition.ToString("##.00") ' Change lblOutput to intTuition
    End Sub

    Private Sub mnuChgBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChgBlue.Click
        BackColor = Color.Blue 'Change the background color to Blue
    End Sub

    Private Sub mnuChgRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChgRed.Click
        BackColor = Color.Red 'Change the background color to Red
    End Sub

    Private Sub mnuChgBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChgBlack.Click
        BackColor = Color.Black 'Change the background color to Black
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit() 'Exit the application when clicked 
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
