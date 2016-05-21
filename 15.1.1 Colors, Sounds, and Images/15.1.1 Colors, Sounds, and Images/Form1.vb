Imports System.Media 'Use Media

Public Class frmColors
    'Columbus Dong
    'Colors
    '12/3/13

    Private Sub btnColors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColors.Click

        Me.BackColor = Color.DarkSlateBlue 'Change background to Dark Slate Blue
        Me.btnColors.BackColor = Color.Yellow 'Change button to Yellow

    End Sub

    Private Sub btnPalette_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPalette.Click
        Me.ColorDialog1.ShowDialog() 'Show the Palette
        Me.BackColor = ColorDialog1.Color 'Change background to chosen color

        Me.ColorDialog1.ShowDialog() 'Show the Palette
        Me.btnPalette.BackColor = ColorDialog1.Color 'Change button to chosen color

    End Sub


    Private Sub btnSounds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSounds.Click
        'Play Different sounds

        SystemSounds.Beep.Play()
        'SystemSounds.Asterisk.Play()
        'SystemSounds.Exclamation.Play()
        'SystemSounds.Hand.Play()
        'SystemSounds.Question.Play()
    End Sub

    Private Sub btnImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImages.Click
        Me.PicImage.Image = My.Resources.Smile 'Adds image to the picture box
    End Sub
End Class
