Public Class Music

    'Code for Exit Button
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    'Code below to change the labels to popular songs by their respective bands
    Private Sub radBand1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBand1.CheckedChanged
        'Three Days Grace Songs
        Me.lblSong1.Text = "Never Too Late" 'Changes text in lblSong1 to whatever is in the quotations
        Me.lblSong2.Text = "Break"
        Me.lblSong3.Text = "World so Cold" & vbCrLf & "By TDG"
    End Sub

    Private Sub radBand2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBand2.CheckedChanged
        'Skillet Songs
        Me.lblSong1.Text = "Monster"
        Me.lblSong2.Text = "Lucy"
        Me.lblSong3.Text = "Awake And Alive"
    End Sub

    Private Sub radBand3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBand3.CheckedChanged
        'Linkin Park Songs
        Me.lblSong1.Text = "Castle of Glass"
        Me.lblSong2.Text = "Powerless"
        Me.lblSong3.Text = "Lost in the Echo"
    End Sub

    Private Sub radBand4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBand4.CheckedChanged
        'A Day to Remember Songs
        Me.lblSong1.Text = "All I Want"
        Me.lblSong2.Text = "If It Means a Lot to You"
        Me.lblSong3.Text = "My Life for Hire"
    End Sub

    Private Sub radBand5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBand5.CheckedChanged
        'My Darkest Days Songs
        Me.lblSong1.Text = "Like Nobody Else"
        Me.lblSong2.Text = "Perfect"
        Me.lblSong3.Text = "Without You"
    End Sub
End Class
