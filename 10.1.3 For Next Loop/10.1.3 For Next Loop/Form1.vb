Public Class Form1
    'Columbus Dong
    '10/24/13
    'For Loop Assignment
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim sum As Integer = 0
        Const MAX_ROWS As Integer = 7
        Const MAX_COLS As Integer = 5
        Dim rows As Integer
        Dim columns As Integer
        For rows = 0 To MAX_ROWS
            For columns = 0 To MAX_COLS
                sum += rows + columns
            Next columns
        Next rows
        lblOutput.Text = ("Value of sum is " & sum)
    End Sub
End Class
