Public Class Form1
    'Decalare the variables for the numerator and denominator
    Dim intNumerator As Integer
    Dim intDenominator As Integer
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim dblAnswer As Double
        Try
            'Give the integers declared globally a literal
            intNumerator = Convert.ToDouble(txtNumerator.Text)
            intDenominator = Convert.ToDouble(txtDenominator.Text)
            'Calculate the Fraction/Decimal
            dblAnswer = intNumerator / intDenominator
            'Change answer label to the answer
            Me.lblAnswer.Text = dblAnswer
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric either numerator or denominator")
        End Try

    End Sub

    Private Sub txtNumerator_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumerator.TextChanged
        Me.lblAnswer.Text = ""
    End Sub

    Private Sub txtDenominator_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDenominator.TextChanged
        Me.lblAnswer.Text = ""
    End Sub
End Class
