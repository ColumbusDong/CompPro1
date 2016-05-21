Public Class frmMath
    'Columbus Dong
    'Math Form
    '11/25/2013
    Private Sub btnAbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbs.Click
        'Declare Variables
        Dim dblNum As Double
        Dim input As String

        Try 'Test to see if value is numeric
            input = txtInput.Text
            dblNum = Convert.ToDouble(input)
            lblAnswer.Text = "The Absolute Value is " & Math.Abs(dblNum) '

        Catch ex As Exception

            MessageBox.Show("Enter numeric values") 'show messagebox when number isn't numeric
        End Try

    End Sub

    Private Sub btnSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSqrt.Click
        'Declare Variables
        Dim dblNum As Double
        Dim input As String

        Try 'Test to see if value is numeric
            input = txtInput.Text
            dblNum = Convert.ToDouble(input)
            lblAnswer.Text = "The Square Root Value is " & Math.Sqrt(dblNum)

        Catch ex As Exception

            MessageBox.Show("Enter numeric values") 'show messagebox when number isnt numeric
        End Try

    End Sub

    Private Sub btnSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSign.Click
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
            MessageBox.Show("Enter numeric values") 'Show messagebox if the number isn't numeric
        End Try

    End Sub

    Private Sub btnRound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRound.Click
        'Create Variables
        Dim dblNum As Double
        Dim input As String
        Dim intPlaces As Integer

        Try 'Test to see if numeric

            input = txtInput.Text
            dblNum = Convert.ToDouble(input)

            intPlaces = Convert.ToInt16(InputBox("Enter the number of places", "Places to round")) 'Prompt user to enter in a place value

            lblAnswer.Text = "The Rounded Value is " & Math.Round(dblNum, intPlaces)
        Catch ex As Exception
            MessageBox.Show("Enter numeric values")
        End Try
    End Sub
End Class
