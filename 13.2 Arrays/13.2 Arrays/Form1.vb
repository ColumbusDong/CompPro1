Public Class Form1
    'Columbus Dong
    'Arrays and List Boxes
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
            Me.lstNames.Items.Add(strNames(intCounter))
        Next
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim strNumbers(9) As String 'creates a string variable that can hold 9 values
        Dim intCounter As Integer 'creats a integer called counter 

        For intCounter = 0 To strNumbers.Length - 1 'Creates a For-Next Loop, and creates 10 random numbers
            strNumbers(intCounter) = CStr(Int((10 - 1 + 1) * Rnd()) + 1)
            Me.lstNames.Items.Add(strNumbers(intCounter))
        Next intCounter

        For intCounter = 0 To strNumbers.Length - 1 'For-Next Loop, if it finds 5, then show a messagebox
            If CDbl(strNumbers(intCounter)) = 5 Then
                MessageBox.Show("The number has been found")
            End If
        Next
    End Sub

    Private Sub btnDynamic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDynamic.Click

        Dim intNumbers(-1), intCounter As Integer 'Creates integer variables intNumbers and intCounter
        ReDim intNumbers(9)

        For intCounter = 0 To intNumbers.Length - 1 'Creates a For-Next Loop, and creates 10 random numbers
            intNumbers(intCounter) = CInt(Int((10 - 1 + 1) * Rnd()) + 1)
            Me.lstNames.Items.Add(intNumbers(intCounter))
        Next intCounter

        ReDim Preserve intNumbers(4) 'Preserve the first 4 numbers
        Me.lstNames.Items.Clear() 'Clear all items in the list box

        For intCounter = 0 To intNumbers.Length - 1 'Creates a For-Next Loop, and creates 10 random numbers
            intNumbers(intCounter) = CInt(Int((10 - 1 + 1) * Rnd()) + 1)
            Me.lstNames.Items.Add(intNumbers(intCounter))
        Next intCounter
    End Sub
End Class
