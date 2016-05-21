Public Class Form1

    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        'Declare Variables
        Static intMagicNumber As Integer = Int((10 - 1 + 1) * Rnd()) + 1 ' Chooses a random number 1 to 10
        Dim intGuess As Integer
        Static IntCounter As Integer = 0
        'Dim randomGenerator As New Random
        'Assign Literals
        'intMagicNumber = 5
        'intMagicNumber = randomGenerator.Next(1, 10) 'Generate a random number 
        intGuess = txtInput.Text
        'The Math
        If intMagicNumber = intGuess Then
            lblOutput.Text = "You guessed right"
        Else
            If intGuess < intMagicNumber Then
                lblOutput.Text = "You guessed to low!"
            Else
                lblOutput.Text = "You guessed to high!"
            End If
        End If
        IntCounter = IntCounter + 1 'Count how many times they guess
        lblNumOfTries.Text = IntCounter
    End Sub
End Class
