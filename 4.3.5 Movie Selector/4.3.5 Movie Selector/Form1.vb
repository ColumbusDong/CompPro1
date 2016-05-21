Public Class Form1

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpMovies.Enter

    End Sub
    'Below are the Radio Buttons within the Group Box

    Private Sub radMovieType1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMovieType1.CheckedChanged
        Me.lblMovieTitle.Text = "Cheaper By the Dozen" 'Change text in a specific label when button clicked
    End Sub

    Private Sub radMovieType2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMovieType2.CheckedChanged
        Me.lblMovieTitle.Text = "Doom"
    End Sub

    Private Sub radMovieType3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radMovieType3.Click
        Me.lblMovieTitle.Text = "Super Size Me"
    End Sub
    'Below is the code for the buttons to do the math
    Private Sub btnQuantity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuantity1.Click
        Me.lblTotalCost.Text = 1 * 5 'Math for one times five
    End Sub

    Private Sub btnQuantity2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuantity2.Click
        Me.lblTotalCost.Text = 2 * 5
    End Sub

    Private Sub btnQuantity3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuantity3.Click
        Me.lblTotalCost.Text = 3 * 5
    End Sub
    'Below is the code for the exit menu
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
