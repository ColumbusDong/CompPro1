Public Class Form1
    'Columbus Dong
    '10/21/13
    'Crazy Loop Assignment
    Dim intTotal As Integer = 0 'Declare variables and give them a value
    Dim intCounter As Integer = 2
    Private Sub btnDoWhileLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoWhileLoop.Click
        'When clicked, clear out the variables
        intCounter = Nothing
        intTotal = Nothing
        'Keep looping until int counter is 50
        Do While intCounter < 52
            intTotal += intCounter
            intCounter += 2
        Loop
        lblOutput.Text = intTotal
    End Sub

    Private Sub btnDoLoopWhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoLoopWhile.Click
        'When clicked, clear out the variables
        intCounter = Nothing
        intTotal = Nothing
        'Evaluate if intCounter is less than 52, if it is, then run the do statement
        If intCounter < 52 Then
            Do
                intTotal += intCounter
                intCounter += 2
            Loop While intCounter < 52
            lblOutput.Text = intTotal
        End If

    End Sub

End Class
