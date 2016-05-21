Public Class Form1
    'Columbus Dong
    'Arranging Friends
    '10/19/2013
    Private Sub btnFriends_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFriends.Click
        Dim FriendArr(4) As String  'declare the array - size 5

        'Loop to add strings from InputBoxes to the array
        For i As Integer = 0 To FriendArr.Length - 1
            FriendArr(i) = InputBox("Enter a friend's name.", "BFF")
        Next i

        'Sort the array, ascending
        Array.Sort(FriendArr)

        'Loop to add the values from the array to the label using 
        'concatenation
        For i As Integer = 0 To FriendArr.Length - 1
            Me.lblFriends.Text &= FriendArr(i) & vbCrLf
        Next i

    End Sub
End Class
