Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String

        str = TextBox1.Text

        If str = StrReverse(str) Then
            Label2.Text = str + " is Palindrome"
        Else
            Label2.Text = str + " is not palindrome"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Nothing
    End Sub
End Class
