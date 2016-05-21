Public Class Form1
    'Columbus Dong
    'Test Data
    '10/19/2013

    Private Sub BtnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        'Create the parallel arrays and initialize them
        Dim testNameArr() As String = {"Test 1", "Test 2", "Test 3"}
        Dim testGradeArr() As Integer = {87, 91, 83}
        'Loop to add the values from the arrays to the text in the label
        For i As Integer = 0 To 2
            Me.lblTest.Text &= testNameArr(i) & " has a grade of " & testGradeArr(i) & vbCrLf
        Next i

    End Sub
End Class
