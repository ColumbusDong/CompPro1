Public Class frmShoppingList
    'Columbus Dong
    'Grocery/Shopping List Assignment
    'November 6,2013

    'Variables
    Shared strItem As String
    Shared strItemtoList As String
    Shared strListtoItem As String

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click

        strItem = txtItems.Text 'Takes the text within the textbox and sets it as strItem
        Me.lstItems.Items.Add(strItem) 'Add strItem into the listbox under Items
        txtItems.Text = "" 'Clear out the textbox text afterwords
    End Sub

    Private Sub btnToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToList.Click

        If lstItems.SelectedItems.Count = Nothing Then 'Check if there is something selected
            MessageBox.Show("Please choose an item to move")
        Else
            'set the variable equal to the selected item, 
            'then add it to the other list box, and remove it from the current one
            strItemtoList = lstItems.SelectedItem
            Me.lstShoppingList.Items.Add(strItemtoList)
            Me.lstItems.Items.Remove(strItemtoList)
        End If
    End Sub

    Private Sub btnToItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToItems.Click

        If lstShoppingList.SelectedItems.Count = Nothing Then 'Check if there is something selected
            MessageBox.Show("Please choose an item to move")
        Else
            'set the variable equal to the selected item, 
            'then add it to the other list box, and remove it from the current one
            strListtoItem = lstShoppingList.SelectedItem
            Me.lstItems.Items.Add(strListtoItem)
            Me.lstShoppingList.Items.Remove(strListtoItem)
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lstItems.SelectedItem.Count = Nothing Then
            MessageBox.Show("Please choose an item to delete")
        Else
            lstItems.Items.Remove(lstItems.SelectedItem) 'Remove the currently selected item
        End If

    End Sub

    Private Sub btnCoupon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCoupon.Click

        Dim strCoupon As String 'create a string variable
        strCoupon = lstShoppingList.SelectedItem + " *" 'set the string variable to the currently selected item and add a *
        lstShoppingList.Items.Remove(lstShoppingList.SelectedItem) 'Remove the selected item
        lstShoppingList.Items.Add(strCoupon) 'add back in the item that the variable was holding
    End Sub

    Private Sub mnuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClear.Click
        'Clear both listboxes when clicked
        lstItems.Items.Clear()
        lstShoppingList.Items.Clear()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub
End Class
