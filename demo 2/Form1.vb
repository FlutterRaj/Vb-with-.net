Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uInput As Integer

        uInput = InputBox("Enter a value :: ")
        Label1.Text = uInput
        ListBox1.Items.Add(uInput)

    End Sub
End Class
