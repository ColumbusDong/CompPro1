Public Class frmAverageGrades
    'Columbus Dong
    '10/24/13
    'Average Grade Assignment

    'Varaibles for each score
    Dim intScore1 As Integer
    Dim intScore2 As Integer
    Dim intScore3 As Integer
    Dim intScore4 As Integer
    Dim intScore5 As Integer
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Declare Variables and Literals
        Dim intAverage As Integer
        Dim intGrades As Integer
        Dim intTotal As Integer
        'For Next Loop
        For intCounter As Integer = 1 To 5
            intGrades = InputBox("Enter your grades below", "Find your average")
            intTotal += intGrades
            If intCounter = 1 Then
                intScore1 = intGrades
                lblGrade1.Text = "Your score is: " & intScore1
            ElseIf intCounter = 2 Then
                intScore2 = intGrades
                lblGrade2.Text = "Your score is: " & intScore2
            ElseIf intCounter = 3 Then
                intScore3 = intGrades
                lblGrade3.Text = "Your score is: " & intScore3
            ElseIf intCounter = 4 Then
                intScore4 = intGrades
                lblGrade4.Text = "Your score is: " & intScore4
            ElseIf intCounter = 5 Then
                intScore5 = intGrades
                lblGrade5.Text = "Your score is: " & intScore5
            End If
            intAverage = intTotal / intCounter 'Get the average from diving the intTotal by the intCounter
            lblAverage.Text = "Your average is: " & intAverage
        Next

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'Clear out labels when clicked
        lblGrade1.Text = ""
        lblGrade2.Text = ""
        lblGrade3.Text = ""
        lblGrade4.Text = ""
        lblGrade5.Text = ""
        lblAverage.Text = ""
    End Sub
End Class
