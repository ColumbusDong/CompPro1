Public Class frmDiceRolls
    'Columbus Dong
    'Roll of the Dice
    '10/19/2013

    Private Sub btnRolls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRolls.Click

        Dim intNumRolls, intRandomNumbers(-1), intRollCounter As Integer 'Create integer varibles
        Dim intTwos, intThrees, intFours, intFives, intSixs, intSevens, intEights, intNines, intTens, intElevens, intTwelves As Integer 'Create variables for the counters
        Dim dblTwoPercent, dblThreePrecent, dblFourPrecent, dblFivePrecent, dblSixPrecent, dblSevenPrecent, dblEigthPrecent, dblNinePrecent, dblTenPrecent, dblElevenPrecent, dblTwelvePrecent As Double 'Create variables for precents
        Dim RandomNum As New Random 'Random Number

        lstRolls.Items.Clear() 'Clear out the list
        lstRolls.Items.Add("Possible Rolls" & ControlChars.Tab & "Times Rolled" & ControlChars.Tab & "Percent of times rolled") 'Add Column Titles

        Try 'Test to see if there is a correct value within the textbox

            intNumRolls = CInt(txtRolls.Text) 'Set intNumRolls equal to the amount in txtRolls

            ReDim intRandomNumbers(intNumRolls) 'Sets the array length depending on value from intNumRolls

            For intRollCounter = 0 To intRandomNumbers.Length - 2 'Loop until Array is finsihed

                intRandomNumbers(intNumRolls) = RandomNum.Next(2, 13) 'Random number between 2 and 12

                Select Case intRandomNumbers(intNumRolls) 'Select case for different situations
                    Case 2 'If intRandomNumbers equal 2, then add 1 to intTwos
                        intTwos += 1
                    Case 3 'if intRandomNumbers equal 3, then add 1 to intThrees
                        intThrees += 1
                    Case 4 'if intRandomNumbers equal 4, then add 1 to intThrees
                        intFours += 1
                    Case 5 'if intRandomNumbers equal 5, then add 1 to intFives
                        intFives += 1
                    Case 6 'if intRandomNumbers equal 6, then add 1 to intSixs
                        intSixs += 1
                    Case 7 'if intRandomNumbers equal 7, then add 1 to intSevens
                        intSevens += 1
                    Case 8 'if intRandomNumbers equal 8, then add 1 to intEights
                        intEights += 1
                    Case 9 'if intRandomNumbers equal 9, then add 1 to intNines
                        intNines += 1
                    Case 10 'if intRandomNumbers equal 10, then add 1 to intTens
                        intTens += 1
                    Case 11 'if intRandomNumbers equal 11, then add 1 to intElevens
                        intElevens += 1
                    Case 12 'if intRandomNumbers equal 12, then add 1 to intTwelves
                        intTwelves += 1
                End Select 'End the select case

            Next

            'Find the Precents
            dblTwoPercent = (intTwos / intNumRolls)
            dblThreePrecent = (intThrees / intNumRolls)
            dblFourPrecent = (intFours / intNumRolls)
            dblFivePrecent = (intFives / intNumRolls)
            dblSixPrecent = (intSixs / intNumRolls)
            dblSevenPrecent = (intSevens / intNumRolls)
            dblEigthPrecent = (intEights / intNumRolls)
            dblNinePrecent = (intNines / intNumRolls)
            dblTenPrecent = (intTens / intNumRolls)
            dblElevenPrecent = (intElevens / intNumRolls)
            dblTwelvePrecent = (intElevens / intNumRolls)

            'Enter in the values within the list box
            lstRolls.Items.Add("2" & ControlChars.Tab & ControlChars.Tab & intTwos & ControlChars.Tab & ControlChars.Tab & dblTwoPercent.ToString("##.## %"))
            lstRolls.Items.Add("3" & ControlChars.Tab & ControlChars.Tab & intThrees & ControlChars.Tab & ControlChars.Tab & dblThreePrecent.ToString("##.## %"))
            lstRolls.Items.Add("4" & ControlChars.Tab & ControlChars.Tab & intFours & ControlChars.Tab & ControlChars.Tab & dblFourPrecent.ToString("##.## %"))
            lstRolls.Items.Add("5" & ControlChars.Tab & ControlChars.Tab & intFives & ControlChars.Tab & ControlChars.Tab & dblFivePrecent.ToString("##.## %"))
            lstRolls.Items.Add("6" & ControlChars.Tab & ControlChars.Tab & intSixs & ControlChars.Tab & ControlChars.Tab & dblSixPrecent.ToString("##.## %"))
            lstRolls.Items.Add("7" & ControlChars.Tab & ControlChars.Tab & intSevens & ControlChars.Tab & ControlChars.Tab & dblSevenPrecent.ToString("##.## %"))
            lstRolls.Items.Add("8" & ControlChars.Tab & ControlChars.Tab & intEights & ControlChars.Tab & ControlChars.Tab & dblEigthPrecent.ToString("##.## %"))
            lstRolls.Items.Add("9" & ControlChars.Tab & ControlChars.Tab & intNines & ControlChars.Tab & ControlChars.Tab & dblNinePrecent.ToString("##.## %"))
            lstRolls.Items.Add("10" & ControlChars.Tab & ControlChars.Tab & intTens & ControlChars.Tab & ControlChars.Tab & dblTenPrecent.ToString("##.## %"))
            lstRolls.Items.Add("11" & ControlChars.Tab & ControlChars.Tab & intElevens & ControlChars.Tab & ControlChars.Tab & dblElevenPrecent.ToString("##.## %"))
            lstRolls.Items.Add("12" & ControlChars.Tab & ControlChars.Tab & intTwelves & ControlChars.Tab & ControlChars.Tab & dblTwelvePrecent.ToString("##.## %"))
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value")
        End Try


    End Sub

End Class
