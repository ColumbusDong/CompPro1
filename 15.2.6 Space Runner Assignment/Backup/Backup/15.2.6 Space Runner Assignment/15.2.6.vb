Public Class frmSpaceRunner
    'Program Name: 15.2.6 Space Runner
    'Author: Christopher James (C.J.) Roberts
    'Date: December 10th, 2013



    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        tmr1Second.Enabled = True
        tmrJump.Enabled = False


    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        tmr1Second.Stop()
    End Sub

    Private Sub tmr1Second_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr1Second.Tick
        Static intCounter As Integer
        If picSpaceRunner.Left < 960 Then
            Select Case intCounter 'Changes the image according to the value of the timer
                Case 0
                    Me.picSpaceRunner.Image = My.Resources.r0
                    picSpaceRunner.Left += 30
                Case 1
                    Me.picSpaceRunner.Image = My.Resources.r1
                    picSpaceRunner.Left += 30
                Case 2
                    Me.picSpaceRunner.Image = My.Resources.r2
                    picSpaceRunner.Left += 30
                Case 3
                    Me.picSpaceRunner.Image = My.Resources.r3
                    picSpaceRunner.Left += 30
                Case 4
                    Me.picSpaceRunner.Image = My.Resources.r4
                    picSpaceRunner.Left += 30
                Case 5
                    Me.picSpaceRunner.Image = My.Resources.r5
                    picSpaceRunner.Left += 30
                Case 6
                    Me.picSpaceRunner.Image = My.Resources.r6
                    picSpaceRunner.Left += 30
                Case 7
                    Me.picSpaceRunner.Image = My.Resources.r7
                    picSpaceRunner.Left += 30
                Case 8
                    Me.picSpaceRunner.Image = My.Resources.r8
                    picSpaceRunner.Left += 30
                Case 9
                    Me.picSpaceRunner.Image = My.Resources.r9
                    picSpaceRunner.Left += 30
            End Select


            intCounter += 1

            If intCounter = 10 Then
                intCounter = 0
            End If

            If picSpaceRunner.Left >= 960 Then
                picSpaceRunner.Left = 1
            End If
        End If


    End Sub


    Public Sub btnJump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJump.Click, tmr1Second.Tick
        tmrJump.Enabled = True
        tmrJump.Start()
    End Sub

    Private Sub tmrJump_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrJump.Tick
        Static intJump As Integer = 0
        If picSpaceRunner.Top = 13 Then
            picSpaceRunner.Top -= 20

        Else
            picSpaceRunner.Top += 20
            tmrJump.Enabled = False

        End If

    End Sub
End Class