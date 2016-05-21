Public Class frmFatuitiousDice
    'Columbus Dong
    'Fatuitious Dice
    '11/15/2013

    Dim intRoll1, intRoll2, intRollValue As Integer 'Declare variables for the Rolls
    Dim intTimer1, intTimer2 As Integer 'Declar variables for the Timers

    Private Sub Dice1Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dice1Timer.Tick

        intTimer1 += 3 'Let intTimer keep counting on by 3

        If intTimer1 < 9000 Then

            intRoll1 = CInt(Int(1 + Rnd() * 6)) 'Gives intRoll1 a random value from 1 to 6

            Select Case intRoll1
                Case 1
                    Dice1.Image = My.Resources.Dice1 'If intRoll1 is 1, then show Dice 1 image
                Case 2
                    Dice1.Image = My.Resources.Dice2 'If intRoll1 is 2, then show Dice 2 image
                Case 3
                    Dice1.Image = My.Resources.Dice3 'If intRoll1 is 3, then show Dice 3 image
                Case 4
                    Dice1.Image = My.Resources.Dice4 'If intRoll1 is 4, then show Dice 4 image
                Case 5
                    Dice1.Image = My.Resources.Dice5 'if intRoll1 is 5, then show Dice 5 image
                Case 6
                    Dice1.Image = My.Resources.Dice6 'if intRoll1 is 6, then show Dice 6 image
            End Select

        Else
            Dice1Timer.Enabled = False
            intTimer1 = 0
        End If
    End Sub

    Private Sub Dice2Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dice2Timer.Tick

        intTimer2 += 3 'Let intTimer keep counting on by 3

        If intTimer2 < 9000 Then

            intRoll2 = CInt(Int(1 + Rnd() * 6)) 'Gives intRoll1 a random value from 1 to 6

            Select Case intRoll2
                Case 1
                    Dice2.Image = My.Resources.Dice1 'If intRoll2 is 1, then show Dice 1 image
                Case 2
                    Dice2.Image = My.Resources.Dice2 'If intRoll2 is 2, then show Dice 2 image
                Case 3
                    Dice2.Image = My.Resources.Dice3 'If intRoll2 is 3, then show Dice 3 image
                Case 4
                    Dice2.Image = My.Resources.Dice4 'If intRoll2 is 4, then show Dice 4 image
                Case 5
                    Dice2.Image = My.Resources.Dice5 'if intRoll2 is 5, then show Dice 5 image
                Case 6
                    Dice2.Image = My.Resources.Dice6 'if intRoll2 is 6, then show Dice 6 image
            End Select

        Else
            Dice2Timer.Enabled = False
            intTimer2 = 0
        End If
    End Sub

    Private Sub btnRollDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollDice.Click
        'When the button is clicked, run the timer
        Dice1Timer.Enabled = True
        Dice2Timer.Enabled = True

        'Clear the labels with the integers inside
        lblRoll1Value.Text = Nothing
        lblRoll2Value.Text = Nothing
        lblFirstRoll.Text = Nothing
        lblSecondRoll.Text = Nothing
        lblRollValue.Text = Nothing
    End Sub

    Private Sub btnStopDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopDice.Click
        'When the button is clicked, stop the timer
        Dice1Timer.Enabled = False
        Dice2Timer.Enabled = False

        'When the timer is stopped, the labels are set to the current value of thier respective integers
        lblRoll1Value.Text = CStr(intRoll1)
        lblFirstRoll.Text = CStr(intRoll1)

        lblRoll2Value.Text = CStr(intRoll2)
        lblSecondRoll.Text = CStr(intRoll2)

        'Deciding the Value

        If intRoll1 = 2 Or intRoll1 = 4 Or intRoll1 = 6 Then 'If the first number is even

            If intRoll2 = 1 Or intRoll2 = 3 Or intRoll2 = 5 Then

                intRollValue = EvenOdd(intRoll1, intRoll2) 'Sets intRollValue equal to the returned value of function EvenOdd

            ElseIf intRoll1 = intRoll2 Then

                intRollValue = intRoll1 'Sets intRollValue to intRoll1

            ElseIf intRoll2 = 2 Or intRoll2 = 4 Or intRoll2 = 6 And intRoll1 <> intRoll2 Then

                intRollValue = EvenEven(intRoll1, intRoll2) 'Sets intRollValue equal to the returned value of function EvenEven
            End If

        End If

        '-----------------------------------------------------------------------------------------


        If intRoll1 = 1 Or intRoll1 = 3 Or intRoll1 = 5 Then 'If the first number is odd

            If intRoll2 = 2 Or intRoll2 = 4 Or intRoll2 = 6 Then

                intRollValue = OddEven(intRoll1, intRoll2) 'Sets intRollEqual to the the returned value of function OddEven

            ElseIf intRoll1 = intRoll2 Then

                intRollValue = 3 * intRoll2 'Sets intRollValue to 3 times intRoll2

            ElseIf intRoll2 = 1 Or intRoll2 = 3 Or intRoll2 = 5 And intRoll1 <> intRoll2 Then

                intRollValue = OddOdd(intRoll1, intRoll2) 'Sets intRollValue equal to the returned value of function OddOdd

            End If
        End If

        lblRollValue.Text = "The value of the roll is: " + intRollValue.ToString

    End Sub

    'Even - Odd Rule
    Function EvenOdd(ByVal intRoll1 As Integer, ByVal intRoll2 As Integer) As Integer
        Return (2 * intRoll1) + intRoll2
    End Function

    'Even - Even Rule 
    Function EvenEven(ByVal intRoll1 As Integer, ByVal intRoll2 As Integer) As Integer
        Return intRoll1 + intRoll2
    End Function

    'Odd - Even Rule
    Function OddEven(ByVal intRoll1 As Integer, ByVal intRoll2 As Integer) As Integer
        Return intRoll1 + (2 * intRoll2)
    End Function

    'Odd - Odd Rule
    Function OddOdd(ByVal intRoll1 As Integer, ByVal intRoll2 As Integer) As Integer
        Return intRoll1 + intRoll2
    End Function

    'Clear everything when clicked
    Private Sub mnuReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReset.Click
        Dice1.Image = Nothing
        Dice2.Image = Nothing
        lblFirstRoll.Text = ""
        lblRollValue.Text = ""
        lblSecondRoll.Text = ""
        lblRoll1Value.Text = ""
        lblRoll2Value.Text = ""
    End Sub

    'End the application when clicked
    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub
End Class
