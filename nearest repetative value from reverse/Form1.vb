Public Class Form1
    Dim arr(0) As Integer
    Dim dictionary As New Dictionary(Of Integer, Integer)
    Dim list As New List(Of Integer)

    Function CreateDict()
        list.Clear()
        dictionary.Clear()

        For Each value As Integer In arr
            If dictionary.ContainsKey(value) Then
                dictionary(value) += 1
            Else
                dictionary.Add(value, 1)
            End If
        Next

        For Each key As Integer In dictionary.Keys
            If dictionary(key) > 1 Then
                list.Add(key)
            End If
        Next
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim range As String
        Dim user_input As Integer
        Dim count As Integer = 0

        range = InputBox("How many items you want to add ?")
        If range = "" Then
            MessageBox.Show("Enter a integer !! ")
        ElseIf CInt(range) < 2 Then
            MessageBox.Show("Enter more than 1 char ..!")
        Else
            range = CInt(range)
            ReDim arr(range - 1)

            While (count < range)
                user_input = CInt(InputBox("Enter Item " + CStr(count + 1)))
                arr(count) = user_input
                count += 1
            End While
            CreateDict()
        End If
        Button3.Visible = True
        ListBox1.Items.Clear()
        Label1.Text = Nothing
        Label2.Text = Nothing
        Label3.Text = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim last_ele As Integer = arr.Length - 1

        If list.Count = 0 Then
            Label1.Text = "NO repetative value !"
        Else
            For index = last_ele To 0 Step -1
                If list.Contains(arr(index)) Then
                    Label1.Text = "Nearest Repetative value"
                    Label2.Text = " from reverse is "
                    Label3.Text = arr(index)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each value As Integer In arr
            ListBox1.Items.Add(value)
        Next
        Button2.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Nothing
        Label2.Text = Nothing
        Label3.Text = Nothing
        Button2.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        ReDim arr(9)
        For index = 1 To 9
            Dim value As Integer = Int((10 * Rnd()) + 1)
            arr(index) = value
        Next

        CreateDict()
        Label1.Text = "Click on "
        Label2.Text = "Show Items "
        Label3.Text = Nothing
        Button2.Visible = True
        Button3.Visible = True
    End Sub
End Class
