Public Class Form1
    Dim arr(0) As Integer
    Dim edge_case As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Nothing
        Label2.Text = Nothing
        ListBox1.Items.Clear()

        Dim size As Integer
        Dim count As Integer = 0

        edge_case = InputBox("How many value you want to add ? ")
        If edge_case = "" Then
            MessageBox.Show("Enter a valid integer")
        ElseIf CInt(edge_case) < 1 Then
            MessageBox.Show("Enter a positive integer")
        Else
            size = CInt(edge_case)
            ReDim arr(size - 1)
        End If

        While count < size
            edge_case = InputBox("Enter value " + Str(count + 1))
            If edge_case = "" Then
                MessageBox.Show("Enter a valid integer")
            ElseIf CInt(edge_case) > 0 Then
                arr(count) = CInt(edge_case)
                count += 1
            End If
        End While
        Label1.Text = CStr(size) + " values added !"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim start As Integer = 0
        Dim last As Integer = arr.Length - 1
        Dim count As Integer = 0
        Dim sortest As New List(Of Integer)
        Dim min As Integer = Integer.MaxValue

        While start < last
            If arr(start) = arr(last) Then
                sortest.Add(count)
            End If
            count += 1
            last -= 1

            If start = last Then
                start += 1
                last = arr.Length - 1
                count = 0
            End If
        End While

        For Each element As Integer In sortest
            min = Math.Min(min, element)
        Next

        If min < arr.Length Then
            Array.Reverse(arr)
            Label1.Text = "Nearest Repeated value"
            Label2.Text = "from Reverse is " + CStr(arr(min))
        Else
            Label1.Text = "No Repeated value found "
            ListBox1.Items.Add("             (˚Δ˚)b    ")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Nothing
        Label2.Text = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If arr.Length > 1 Then
            For Each element As Integer In arr
                ListBox1.Items.Add(element)
            Next
        Else
            Label1.Text = "Add more than one value !! "
            Label2.Text = "(≥o≤)"
        End If
    End Sub
End Class
