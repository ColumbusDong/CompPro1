Public Class frmFootBallScores
    'Columbus Dong
    'Football Game Scores
    '11/13/2013

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim intFirstScore, intSecondScore, intThirdScore, intFourthScore, intTotalScore As Integer 'Declare a variables

        'Test to see if all the textbox are numeric values
        Try
            intFirstScore = Convert.ToInt16(txtFirstQuarter.Text) 'Obtains a Literal
            intSecondScore = Convert.ToInt16(txtSecondQuarter.Text) 'Obtains a Literal
            intThirdScore = Convert.ToInt16(txtThirdQuarter.Text) 'Obtains a Literal
            intFourthScore = Convert.ToInt16(txtFourthQuarter.Text) 'Obtains a Literal

            intTotalScore = calcTotal(intFirstScore, intSecondScore, intThirdScore, intFourthScore) 'Sets intTotalScore equal to the returned value of the function

            lblOutput.Text = "The total number of points is: " + CStr(intTotalScore) 'Converts intTotalScore into a string
        Catch ex As Exception
            MessageBox.Show("Please enter numeric values")
        End Try
    End Sub

    Function calcTotal(ByVal intFirstScore As Integer, ByVal intSecondScore As Integer, ByVal intThirdScore As Integer, ByVal intFourthScore As Integer) As Integer

        Return intFirstScore + intSecondScore + intThirdScore + intFourthScore 'Return the total of all the scores

    End Function

    Private Sub mnuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClear.Click
        'When pressed clears out all info
        txtFirstQuarter.Text = ""
        txtSecondQuarter.Text = ""
        txtThirdQuarter.Text = ""
        txtThirdQuarter.Text = ""
        lblOutput.Text = ""
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub
End Class
