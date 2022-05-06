'Carson Bogart
'RCET 0265
'Spring 22
'Stan's Grocery
'


Option Explicit On
Option Strict On
Public Class StansGrocery
    Dim food(255, 2) As String
    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Filename As String = "C:\Users\clbog\OneDrive\Desktop\VisualBasic\StansGrocery_CB\StansGrocery_CB\bin\Grocery.txt"
        Dim record As String
        Dim Row As Integer
        Dim temp() As String



        Try
            FileOpen(1, Filename, OpenMode.Input)
        Catch ex As Exception

        End Try

        Do Until EOF(1)

            'grab item name
            Input(1, record)
            temp = Split(record, "$$ITM")
            food(Row, 0) = temp(1)


            'grab item location
            Input(1, record)
            temp = Split(record, "##LOC")
            food(Row, 1) = temp(1)


            'grab item category
            Input(1, record)
            temp = Split(record, "%%CAT")
            food(Row, 2) = temp(1)

            Row += 1
        Loop
        FileClose(1)

        'load the items in the displaybox
        LoadItemsCategory("")

        'add show all to the combobox
        FilterComboBox.Items.Add("Show All")
        FilterComboBox.SelectedIndex = 0
        FilterComboBox.Items.Clear()

        If AisleRadioButton.Checked = True Then

            'change combo box to have the aisles from food array
            For i = 0 To 255

                'no aisles added if blank
                If food(i, 1) = "" Then
                Else
                    If FilterComboBox.Items.Contains(food(i, 1).ToString.PadLeft(2)) Then
                    Else
                        FilterComboBox.Items.Add((food(i, 1).ToString.PadLeft(2)))
                    End If
                End If
            Next
            'sorts combo box numeric
            FilterComboBox.Sorted = True
            FilterComboBox.Sorted = False
            FilterComboBox.Items.Insert(0, "Show All")
            FilterComboBox.SelectedIndex = 0
        End If

        AisleRadioButton.Checked = True
        DisplayLabel.Text = "No Item Selected"

    End Sub
    Sub LoadItemsCategory(ByVal categoryName As String)
        DisplayListBox.Items.Clear()
        'looks through array for category
        For i = 0 To 255

            'adds not blank fields
            If food(i, 0).ToString = "" Then
            Else

                If DisplayListBox.Items.Contains(food(i, 0).ToString) Then
                Else

                    If food(i, 2).ToString = categoryName Then
                        DisplayListBox.Items.Add(food(i, 0).ToString)
                    ElseIf categoryName = "" Then
                        DisplayListBox.Items.Add((i, 0).ToString)
                    End If

                End If
            End If
        Next
    End Sub
    Sub ListBoxDisplay()
        For i = Me.food.GetLowerBound(0) To Me.food.GetUpperBound(0)
            DisplayListBox.Items.Add($"{Me.food(i, 0)} : {Me.food(i, 1)} : {Me.food(i, 2)}")
        Next
    End Sub
    Sub LoadItemsLocation(ByVal locationName As String)
        DisplayListBox.Items.Clear()
        'look through array for location
        For i = 0 To 255

            If food(i, 0).ToString = "" Then
            Else
                If DisplayListBox.Items.Contains(food(i, 0).ToString) Then
                Else
                    If food(i, 1).ToString = locationName Then
                        DisplayListBox.Items.Add(food(i, 0).ToString)
                    ElseIf locationName = "" Then
                        DisplayListBox.Items.Add(food(i, 0).ToString)
                    End If
                End If
            End If
        Next
    End Sub
    Function FindName(ByVal itemName As String) As Integer
        Dim indexValue As Integer = -1

        'check all values to see if itemname matches one in array
        For i = 0 To 255
            If itemName = (food(i, 0).ToString) Then
                Return i
            End If
        Next
        'if no values equal itemName return -1
        Return -1
    End Function
    Private Sub DisplayListBoxChange(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        Dim selectedItemName As String = DisplayListBox.SelectedItem.ToString
        Dim selectedItemLocation As String = food(FindName(selectedItemName), 1)
        Dim selectedItemCategory As String = food(FindName(selectedItemName), 2)
        'TODO
        'on startup when displaylistbox clicked program crashes
        'select combo box "Show All" to show and filter correctly
        '------------------------------------------------------

        'display the item selected in the displaylistbox
        DisplayLabel.Text = "You will find " & selectedItemName & " on aisle " & selectedItemLocation & " with the " & selectedItemCategory
    End Sub
    Sub DisplayAll(ByVal itemName As String)
        DisplayListBox.Items.Clear()

        'check if name is blank
        If itemName = "" Then
        Else
            'cycle through food array
            For i = 0 To 255
                'add items that contain the itemName
                If food(i, 0).Contains(itemName) Then
                    If DisplayListBox.Items.Contains(food(i, 0).ToString) Then
                    Else
                        'add the item to displaybox
                        DisplayListBox.Items.Add(food(i, 0))
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchToolStripMenuItem.Click, SearchToolStripMenuItem1.Click
        'display the items that match search
        DisplayAll(SearchTextBox.Text)

        If DisplayListBox.Items.Count = 0 Then
            DisplayLabel.Text = ($"Sorry no matches for {SearchTextBox.Text}")
            SearchTextBox.Text = ""
            AisleRadioButton.Checked = True
            LoadItemsLocation("")
        End If


        FilterComboBox.SelectedItem = "Show All"

        'set filter back to default
        AisleRadioButton.Checked = True


    End Sub
    Private Sub AisleRadioButton_CheckChanged(sender As Object, e As EventArgs) Handles AisleRadioButton.Click
        FilterComboBox.Items.Clear()

        If AisleRadioButton.Checked = True Then

            'change combo box to have all aisles
            For i = 0 To 255

                'no aisles if blank
                If food(i, 1) = "" Then
                Else
                    If FilterComboBox.Items.Contains(food(i, 1).ToString.PadLeft(2)) Then
                    Else
                        FilterComboBox.Items.Add((food(i, 1).ToString.PadLeft(2)))
                    End If
                End If
            Next

            'sort the items numerically 
            FilterComboBox.Sorted = True
            FilterComboBox.Sorted = False
            FilterComboBox.Items.Insert(0, "Show All")
            FilterComboBox.SelectedIndex = 0

            'display items
            LoadItemsCategory("")
        End If

    End Sub
    Private Sub CategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CategoryRadioButton.CheckedChanged
        FilterComboBox.Items.Clear()

        If CategoryRadioButton.Checked = True Then

            'combo box to show all categories from food array
            For i = 0 To 255
                'no blank fields added
                If (food(i, 2).ToString) = "" Then
                Else
                    If FilterComboBox.Items.Contains(food(i, 2)) Then
                    Else
                        FilterComboBox.Items.Add((food(i, 2).ToString))
                    End If
                End If
            Next

            'sorts alphabetically
            FilterComboBox.Sorted = True
            FilterComboBox.Sorted = False
            FilterComboBox.Items.Insert(0, "Show All")
            FilterComboBox.SelectedIndex = 0

            'display items
            LoadItemsCategory("")
        End If
    End Sub
    Private Sub FilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterComboBox.SelectedIndexChanged
        If FilterComboBox.Items.Count > 0 Then
            If CategoryRadioButton.Checked Then
                If FilterComboBox.SelectedItem.ToString = "Show All" Then
                    'load all items if show all is selected
                    LoadItemsCategory("")
                Else
                    LoadItemsCategory(FilterComboBox.SelectedItem.ToString)
                End If
            ElseIf AisleRadioButton.Checked Then
                If FilterComboBox.SelectedItem.ToString = "Show All" Then
                    LoadItemsLocation("")
                Else
                    LoadItemsLocation(FilterComboBox.SelectedItem.ToString.Trim)
                End If
            End If
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
        Me.Hide()
    End Sub
End Class
