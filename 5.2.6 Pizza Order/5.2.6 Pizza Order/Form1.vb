Public Class Form1
    'Create Variables
    Dim strCrust As String
    Dim strTopping1 As String
    Dim strTopping2 As String

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'End Application when clicked
        Application.Exit()
    End Sub

    Private Sub txtCrust_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrust.TextChanged
        'Clear text in order if text changed
        Me.lblOrder.Text = ""
    End Sub

    Private Sub txtTopping1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTopping1.TextChanged
        'Clear text in order if text changed
        Me.lblOrder.Text = ""
    End Sub

    Private Sub txtTopping2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTopping2.TextChanged
        'Clear text in order if text changed
        Me.lblOrder.Text = ""
    End Sub

    Private Sub btnYourOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYourOrder.Click
        'Create Variables
        Dim strOrder As String = Nothing
        'Assign Literals to the variables
        strCrust = Me.txtCrust.Text
        strTopping1 = Me.txtTopping1.Text
        strTopping2 = Me.txtTopping2.Text
        'Create the order
        MessageBox.Show("A" + " " + strTopping1 + " " + "and" + " " + strTopping2 + " " + "pizza" + " " + "with" + " " + strCrust + " " + "crust.")
        'Change the order label to the order
        Me.lblOrder.Text = strOrder
    End Sub
End Class
