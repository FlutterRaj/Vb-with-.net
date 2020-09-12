Public Class Form1
    Dim str1 As String
    Dim str2 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str1 = TextBox1.Text
        str2 = TextBox2.Text

        Label1.Text = str1
        Label2.Text = str2
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Nothing
        Label2.Text = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        str1 = Label1.Text
        str2 = Label2.Text

        Label1.Text = str2
        Label2.Text = str1
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
