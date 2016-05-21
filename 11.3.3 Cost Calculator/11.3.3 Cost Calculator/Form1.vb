Public Class Form1
    'Columbus Dong
    'Cost Calculator Assignment
    'November 6,2013
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Declare Variables
        Dim strCost, strItems As String
        Dim dblCost, dblTotal As Double
        Dim intItems As Integer

        'Assign strCost and strItems to their respective textbox
        strCost = Me.txtCost.Text
        strItems = Me.txtItems.Text
        'TryParse
        If Double.TryParse(strCost, dblCost) And Int32.TryParse(strItems, intItems) Then
            dblTotal = dblCost * intItems
            lblOutput.Text = "The total cost of your items is $" + dblTotal.ToString("##.00")
        Else
            lblOutput.Text = "Please enter correct numeric values"
        End If
    End Sub

    Private Sub mnuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClear.Click
        'Clear empty out the txtboxes and label when clicked
        txtCost.Text = ""
        txtItems.Text = ""
        lblOutput.Text = ""
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit() 'Close application when clicked
    End Sub
End Class
