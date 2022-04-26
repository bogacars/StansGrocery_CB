Option Explicit On
Option Strict On
Public Class StansGrocery
    Dim food(255, 2) As String

    Sub LoadDataFile()
        Dim fileName As String = "C:\Users\clbog\OneDrive\Desktop\VisualBasic\StansGrocery_CB\StansGrocery_CB"
        Dim record As String
        Dim row As Integer
        Dim temp() As String

        FileOpen(1, fileName, OpenMode.Input)

        Do Until EOF(1)

            'grab item name
            Input(1, record)
            temp = Split(record, "$$ITM")
            food(row, 0) = temp(1)

            'grab location 
            Input(1, record)
            food(row, 1) = record

            'grab category
            Input(1, record)
            food(row, 2) = record

            row += 1
        Loop

        FileClose(1)
    End Sub

    Sub ListBoxDisplay()
        For i = Me.food.GetLowerBound(0) To Me.food.GetUpperBound(0)
            ListBox1.Items.Add($"{Me.food(i, 0)} : {Me.food(i, 1)} : {Me.food(i, 2)}")

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadDataFile()
    End Sub
End Class
