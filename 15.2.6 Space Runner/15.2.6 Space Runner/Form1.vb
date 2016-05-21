Public Class frmSpaceRunner
    'Columbus Dong
    'Space Runner
    '12/4/13
    Dim intCounter As Integer 'Create a variable

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

    Private Sub tmrRun_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRun.Tick
        If Me.PicSpaceRunner.Left < 500 Then
            Me.PicSpaceRunner.Left += 10
        Else
            tmrRun.Enabled = False
            tmrSpeed.Enabled = False
        End If
    End Sub

    'Make the Space Runner Run
    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Me.tmrSpeed.Enabled = True 'Enable the Timer
        Me.tmrRun.Enabled = True
        'Make Picture Box Move

    End Sub

    'Make the Space Runner Jump
    Private Sub btnJump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJump.Click
        tmrJump.Enabled = True 'Enable Jump Timer

    End Sub

    Private Sub tmrJump_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrJump.Tick

        If Me.PicSpaceRunner.Top = 160 Then
            Me.PicSpaceRunner.Top -= 30 'Make it go up
            tmrSpeed.Enabled = False
        Else
            Me.PicSpaceRunner.Top += 30 'Make it go down
            tmrSpeed.Enabled = True
            tmrJump.Enabled = False
        End If
    End Sub

    'Make the Space Runner Stop
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        'Disable the Timers
        Me.tmrSpeed.Enabled = False
        Me.tmrRun.Enabled = False
    End Sub
End Class
