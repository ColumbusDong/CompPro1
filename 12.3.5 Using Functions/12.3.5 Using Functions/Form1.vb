Public Class frmFunctions
    'Columbus Dong
    'Using Functions
    '11/13/2013

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim intNum1, intNum2, intAnswer As Integer 'Creates 3 integer variables

        intNum1 = CInt(Me.txtNum1.Text) 'Obtains a literal
        intNum2 = CInt(Me.txtNum2.Text) 'Obtains a literal

        Call Calculate(intNum1, intNum2, intAnswer) 'Calls the sub Calculate and gets the values

        'MessageBox.Show("The answer is: " & intAnswer) 'Shows message box with the answer from the returned answer
        MessageBox.Show("The answer is: " & Add(intNum1, intNum2)) 'Shows message box with answer from function
    End Sub

    Function Add(ByVal intNum1 As Integer, ByVal intNum2 As Integer) As Integer
        Return intNum1 + intNum2
    End Function

    Sub Calculate(ByVal intNum1 As Integer, ByVal intNum2 As Integer, ByRef intAnswer As Integer) 'Creates a sub called Calculate

        intAnswer = intNum1 + intNum2 'Adds together intNum1 and itNum2
        lblTotal.Text = CStr(intAnswer) 'Changes lblTotal text to the intAnswer

        'MessageBox.Show("The answer is: " & intAnswer) 'Shows message box with the answer

    End Sub
End Class
