Public Class frmShakespeareanInsult
    'Columbus Dong
    'Shakespearean Insult
    '11/12/2013
    Private Sub btnGenerateInsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateInsult.Click

        'Declare the variable
        Dim intInsultNum As Integer
        Dim strInsult As String
        Dim randomNum As New Random
        intInsultNum = randomNum.Next(1, 6) 'set intInsult as a random number between 1 and 5

        Call showInsult(intInsultNum, strInsult)

        lblInsult.Text = strInsult
    End Sub

    Sub showInsult(ByVal intInsultNum As Integer, ByRef strInsult As String)

        Select Case intInsultNum
            Case 1
                strInsult = "I think he be transformed into a beast; for I can nowhere find him like a man"
            Case 2
                strInsult = "Lets meet as little as we can"
            Case 3
                strInsult = "I desire that we be better strangers"
            Case 4
                strInsult = "Boys, apes, braggarts, jacks, milksops!"
            Case 5
                strInsult = "This is the silliest stuff that I ever heard"
        End Select

    End Sub
End Class
