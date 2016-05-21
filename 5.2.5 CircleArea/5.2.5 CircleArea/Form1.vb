Public Class frmCircleArea
    Dim intRadius As Integer
    Private Sub txtRadius_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRadius.TextChanged
        'Erases the text in the spot where the area is when text in text box is changed
        Me.lblCircleArea.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'End application when clicked
        Application.Exit()
    End Sub

    Private Sub btnCalcRadius_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcRadius.Click
        'Creating variables
        Const dblPi As Double = 3.14159
        Dim dblCircleArea As Double
        Try
            'Give the intRadius a literal from the textbox
            intRadius = Convert.ToDouble(txtRadius.Text)
            'Calculate the Area
            dblCircleArea = dblPi * intRadius * intRadius
            'Change the text in the lblCircleArea to the area of the circle
            Me.lblCircleArea.Text = dblCircleArea
        Catch ex As Exception
            MessageBox.Show("Enter a radius that is numeric")
        End Try
    End Sub
End Class
