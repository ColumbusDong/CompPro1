Public Class Form1

    Private Sub chkHomework_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHomework.CheckedChanged
        If Me.chkHomework.Checked Then
            MessageBox.Show("Great Job") 'If homework is completed, show a message box that says Great Job
        End If
    End Sub

    Private Sub chkBreakfast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBreakfast.CheckedChanged
        If Me.chkBreakfast.Checked Then
            MessageBox.Show("Great Job")
        End If
    End Sub

    Private Sub chkTeeth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTeeth.CheckedChanged
        If Me.chkTeeth.Checked Then
            MessageBox.Show("Great Job")
        End If
    End Sub

    Private Sub btnReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReady.Click
        'Check if chkBreakfast, chkHomework, and chkTeeth are all checked if they are not, then show a messagebox
        If Me.chkBreakfast.Checked = True And Me.chkHomework.Checked = True And Me.chkTeeth.Checked = True Then
            Application.Exit()
        Else
            MessageBox.Show("Are you sure you are ready for school?")
        End If

    End Sub
End Class
