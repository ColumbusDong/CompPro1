Public Class Form1


    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtUnits.Text = Nothing
        Me.lblClassification.Text = Nothing
        PictureBox.Image = My.Resources.teacher
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Declare variable
        Dim decUnits As Decimal
        'set decUnits equal to the text in the textbox
        decUnits = Me.txtUnits.Text
        'setting the classification
        If decUnits < 30 Then 'If the decUnit is under 30
            Me.lblClassification.Text = "Freshman"
            PictureBox.Image = My.Resources.freshman
        ElseIf decUnits >= 30 AndAlso decUnits < 70 Then 'If the decUnit is anywhere from 30-69
            Me.lblClassification.Text = "Sophomore"
            PictureBox.Image = My.Resources.sophomore
        ElseIf decUnits >= 70 AndAlso decUnits < 90 Then 'If the decUnit is anywhere from 70-89
            Me.lblClassification.Text = "Junior"
            PictureBox.Image = My.Resources.junior
        ElseIf decUnits >= 90 Then                      'If the decUnit is 90 and above
            Me.lblClassification.Text = "Senior"
            PictureBox.Image = My.Resources.senior
        End If
    End Sub

End Class
