Public Class frmTrafficLight
    'Columbus Dong
    'Traffic Light
    '12/3/13


    Private Sub btnGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGreen.Click

        Me.TrafficLight.Image = My.Resources.GreenLight 'Show Green Light

    End Sub

    Private Sub btnYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYellow.Click

        Me.TrafficLight.Image = My.Resources.YellowLight 'Show Yellow Light

    End Sub

    Private Sub btnRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRed.Click

        Me.TrafficLight.Image = My.Resources.RedLight 'Show Red Light

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        Me.TrafficLight.Image = My.Resources.TrafficLight 'Show Regular Version

    End Sub
End Class
