Option Explicit On
Option Strict On
Public Class StansGrocery
    Dim food(255, 2) As String

    Sub LoadDataFile()
        Dim fileName As String = "C:\Users\clbog\OneDrive\Desktop\VisualBasic\StansGrocery_CB\Grocery.txt"
        Dim record As String
        Dim row As Integer
        Dim temp() As String



        Try
            FileOpen(1, fileName, OpenMode.Input)
        Catch ex As Exception

        End Try



        Do Until EOF(1)

            'grab item name
            Input(1, record)
            temp = Split(record, "$$ITM")
            food(row, 0) = temp(1)

            'grab location 
            Input(1, record)
            temp = Split(record, "##LOC")
            food(row, 1) = temp(1)

            'grab category
            Input(1, record)
            temp = Split(record, "%%CAT")
            food(row, 2) = temp(1)


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
        ListBoxDisplay()
    End Sub
End Class
