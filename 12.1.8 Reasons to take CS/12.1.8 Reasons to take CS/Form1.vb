Public Class frmComputerScience
    'Columbus Dong
    'Reasons to take CS
    '11/12/2013
    Private Sub btnShowReasons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReasons.Click

        Call ShowReasons() 'calls the sub ShowReasons

    End Sub

    Sub ShowReasons() 'creates a new sub called ShowReasons

        lstReasons.Items.Add("Computer Science teaches critical thinking") 'Add item to the list box
        lstReasons.Items.Add("Computer Science touches everyone, everyday") 'Add item to the list box
        lstReasons.Items.Add("Computing jobs are in high demand") 'Add item to the list box

    End Sub
End Class
