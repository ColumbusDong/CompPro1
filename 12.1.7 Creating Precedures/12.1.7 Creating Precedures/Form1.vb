Public Class Form1
    'Columbus Dong
    'Creating Precedures assignment
    '11/12/2013
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Call Calculate()

    End Sub

    Sub Calculate()
        Dim intNum1, intNum2, intAnswer As Integer 'Creates 3 integer variables

        intNum1 = CInt(Me.txtNum1.Text) 'Obtains a literal
        intNum2 = CInt(Me.txtNum2.Text) 'Obtains a literal

        intAnswer = intNum1 + intNum2 'Adds together intNum1 and itNum2
        lblTotal.Text = CStr(intAnswer) 'Changes lblTotal text to the intAnswer
    End Sub
End Class
