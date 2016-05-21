Public Class frmParameters
    'Columbus Dong
    'Parameter Tutorial
    '11/12/2013


    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim intNum1, intNum2, intAnswer As Integer 'Creates 3 integer variables

        intNum1 = CInt(Me.txtNum1.Text) 'Obtains a literal
        intNum2 = CInt(Me.txtNum2.Text) 'Obtains a literal

        Call Calculate(intNum1, intNum2, intAnswer) 'Calls the sub Calculate and gets the values

        MessageBox.Show("The answer is: " & intAnswer) 'Shows message box with the answer
    End Sub

    Sub Calculate(ByVal intNum1 As Integer, ByVal intNum2 As Integer, ByRef intAnswer As Integer)

        intAnswer = intNum1 + intNum2 'Adds together intNum1 and itNum2
        lblTotal.Text = CStr(intAnswer) 'Changes lblTotal text to the intAnswer

        MessageBox.Show("The answer is: " & intAnswer) 'Shows message box with the answer

    End Sub
End Class
