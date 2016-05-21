Public Class Form1
    'Columbus Dong
    '10/17/2013
    'Select Case Assignment
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim intGrade As Integer 'Define the variable and and set a literal
        intGrade = txtGrade.Text
        Dim strLetter As String
        strLetter = Nothing

        Select Case intGrade 'Decide what is the letter grade depending on the numerical grade
            Case 93 To 100
                strLetter = "A!"
            Case 85 To 92
                strLetter = "B!"
            Case 77 To 84
                strLetter = "C!"
            Case 70 To 76
                strLetter = "D!"
            Case 0 To 69
                strLetter = "F!"
            Case Else
                MessageBox.Show("Please enter a valid grade from 1 to 100")
        End Select

        lblOutput.Text = "Your letter grade is a " + strLetter 'Show the output
    End Sub
End Class
