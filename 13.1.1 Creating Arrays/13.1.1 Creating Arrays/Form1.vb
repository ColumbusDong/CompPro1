Public Class Form1
    'Columbus Dong
    'Creating Arrays
    '11/18/2013
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim strNames(4) As String 'Creates a string variable that can hold 5 values

        'Great Minds
        strNames(0) = "Ben Franklin"
        strNames(1) = "Albert Einstein"
        strNames(2) = "Nikolai Tesia"
        strNames(3) = "Madame Curie"
        strNames(4) = "Steven Hawking"

        'Show message with 3rd string
        MessageBox.Show(strNames(2))

        'Show messagebox with total number of values
        MessageBox.Show("There are " & strNames.Length & " elements.")
    End Sub

    Private Sub btnPopulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopulate.Click
        Dim strNames(4) As String 'Creates a string variable that can hold 5 values
        Dim intCounter As Integer 'Creates a integer called counter

        For intCounter = 0 To strNames.Length - 1 'Creates a For-Next Loop, loops until intCounter = 4
            strNames(intCounter) = InputBox("Enter a great mind in history", "Great Minds")
        Next
    End Sub
End Class
