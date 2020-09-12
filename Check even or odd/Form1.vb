Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        num = CInt(TextBox1.Text)
        If num Mod 2 = 0 Then
            Label2.Text = "Number is even"
        Else
            Label2.Text = "Number is odd"
        End If
    End Sub
End Class