Public Class frmAnimation
    'Columbus Dong
    'Animation and Timers
    '12/3/13

    Dim intCounter As Integer 'Create Variable
    Private Sub tmrSpeed_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSpeed.Tick

        intCounter += 1 'Make it a counter

        Select Case intCounter 'Change image depending on value
            Case 0
                Me.PicSpaceRunner.Image = My.Resources.r0
            Case 1
                Me.PicSpaceRunner.Image = My.Resources.r1
            Case 2
                Me.PicSpaceRunner.Image = My.Resources.r2
            Case 3
                Me.PicSpaceRunner.Image = My.Resources.r3
            Case 4
                Me.PicSpaceRunner.Image = My.Resources.r4
            Case 5
                Me.PicSpaceRunner.Image = My.Resources.r5
            Case 6
                Me.PicSpaceRunner.Image = My.Resources.r6
            Case 7
                Me.PicSpaceRunner.Image = My.Resources.r7
            Case 8
                Me.PicSpaceRunner.Image = My.Resources.r8
            Case 9
                Me.PicSpaceRunner.Image = My.Resources.r9
        End Select

        If intCounter = 10 Then 'Reset once it gets to 10
            intCounter = 0
        End If

    End Sub

    Private Sub btnFaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFaster.Click
        If Me.tmrSpeed.Interval > 10 Then
            Me.tmrSpeed.Interval = Me.tmrSpeed.Interval - 10 'Make the Image Faster
        Else
            MessageBox.Show("It can not go any faster")
        End If

    End Sub

    Private Sub btnSlower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSlower.Click
        Me.tmrSpeed.Interval = Me.tmrSpeed.Interval + 10 'Make the Image Slower
    End Sub
End Class
