Public Class Form1

    Private Sub lblCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCalculate.Click
        'Declare Variables
        Dim dblMints As Double
        Dim dblServings As Double
        Dim dblLeftOver As Double
        'Give Variable a literal
        dblMints = txtMints.Text
        'Do the Math
        dblServings = dblMints \ 3 'So dbl Servings is equal to the number of mints divided by three, but only shows an integer
        dblLeftOver = dblMints Mod 3 ' So dbl Left Over shows the number of mints remainder similar to javascripts %
        'Changes labels to the variables
        lblMintServings.Text = dblServings
        lblMintsLeft.Text = dblLeftOver
    End Sub
End Class
