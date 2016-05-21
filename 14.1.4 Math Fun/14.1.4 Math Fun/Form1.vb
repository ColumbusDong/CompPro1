Public Class frmMath
    'Columbus Dong
    'Math Fun
    '11/25/2013

    Private Sub mnuAbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbs.Click

        'Declare Variables
        Dim dblNum As Double
        Dim input As String

        Try 'Test to see if value is numeric
            input = txtInput.Text
            dblNum = Convert.ToDouble(input)

            lblAnswer.Text = "The abolsute value of the number is " & Math.Abs(dblNum) 'Absolute value the number

        Catch ex As Exception

            MessageBox.Show("Enter numeric values") 'show messagebox when value isn't numeric
        End Try

    End Sub

    Private Sub mnuSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSqrt.Click
        'Declare Variables
        Dim dblNum As Double
        Dim input As String

        Try 'Test to see if value is numeric
            input = txtInput.Text
            dblNum = Convert.ToDouble(input)

            lblAnswer.Text = "The square root of the number is " & Math.Sqrt(dblNum) 'Square the number

        Catch ex As Exception

            MessageBox.Show("Enter numeric values") 'show messagebox when value isnt numeric

        End Try

    End Sub

    Private Sub mnuSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSign.Click
        'Declare Variables
        Dim dblNum As Double
        Dim input As String

        Try 'Test to see if value is numeric
            input = txtInput.Text
            dblNum = Convert.ToDouble(input)

            If (Math.Sign(dblNum) > 0) Then 'if the value is above 0
                lblAnswer.Text = dblNum & " is a  positive number."
            ElseIf (Math.Sign(dblNum) < 0) Then 'if the value is below 0
                lblAnswer.Text = dblNum & " is a negative number."
            Else 'if the value is at 0
                lblAnswer.Text = dblNum & " is a zero."
            End If

        Catch ex As Exception
            MessageBox.Show("Enter numeric values") 'Show messagebox if the value isn't numeric
        End Try

    End Sub

    Private Sub mnuRound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRound.Click

        'Create Variables
        Dim dblNum As Double
        Dim input As String
        Dim intPlaces As Integer

        Try 'Test to see if numeric

            input = txtInput.Text
            dblNum = Convert.ToDouble(input)

            intPlaces = Convert.ToInt16(InputBox("Enter the number of places", "Places to round")) 'Prompt user to enter in a place value

            lblAnswer.Text = input & " rounded to the " & intPlaces & " place is " & Math.Round(dblNum, intPlaces)

        Catch ex As Exception

            MessageBox.Show("Enter numeric values") 'Show message box if value isn't number

        End Try
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit() 'End program when clicked
    End Sub
End Class
