Public Class Form1
    'Columbus Dong
    'WWII Facts Assignment
    'November 5,2013
    Dim strFact As String
    Dim strRemoveFact As String
    Private Sub mnuAddFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddFact.Click
        'Prompts the user if he/she would like to add another fact, if yes clicked then show the inputbox
        If MessageBox.Show("Would you like to enter another fact?", "WWII Facts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            strFact = InputBox("Enter your fact", "World War 2 Facts") 'Creates a inputbox and the string entered become sthe literal for strFact
            Me.lstFacts.Items.Add(strFact) 'Enters strFact in the ListBox
        End If
    End Sub

    Private Sub mnuRemoveFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRemoveFact.Click
        strRemoveFact = InputBox("Enter the fact you would like to remove", "WWII Fact Remover") 'Remove facts
        Me.lstFacts.Items.Remove(strRemoveFact)
    End Sub

    Private Sub mnuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClear.Click
        Me.lstFacts.Items.Clear() 'Clear all the facts inside the listbox
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit() 'Close the application
    End Sub
End Class
