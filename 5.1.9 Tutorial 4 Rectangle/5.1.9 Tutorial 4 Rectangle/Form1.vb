Public Class frmTutorial_4_Rectangle
    'Globally declare variables
    Dim intWidth As Integer
    Dim intLength As Integer
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'To end application when exit is clicked
    End Sub

    Private Sub btnCalcArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcArea.Click
        'Creating Variable
        Dim intTotal As Integer
        'Giving variables a literal from text in text boxes
        Try
            intWidth = Me.txtWidth.Text
            intLength = Me.txtLength.Text
            'Calculate the area
        Catch ex As Exception
            MessageBox.Show("Be sure you are entering numbers rather than words")
        Finally
            intTotal = intWidth * intLength
            Me.lblArea.Text = intTotal
        End Try
    End Sub

    Private Sub btnCalcPerimeter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcPerimeter.Click
        'Create variable for perimeter
        Dim intTotalPerimeter As Integer
        Try
            intWidth = Me.txtWidth.Text
            intLength = Me.txtLength.Text
        Catch ex As Exception
            MessageBox.Show("Be sure to enter numbers rather than words")
        Finally
            'Calculate the perimeter
            intTotalPerimeter = (2 * intWidth) + (2 * intLength)
            Me.lblPerimeter.Text = intTotalPerimeter
        End Try

    End Sub
End Class
