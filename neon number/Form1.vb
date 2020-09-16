Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user_input, sum, re, neon As Integer

        user_input = TextBox1.Text
        neon = user_input * user_input

        While neon <> 1
            re = neon Mod 10
            sum += re
            neon /= 10
        End While

        If sum = user_input Then
            Label2.Text = CStr(user_input) + " is a neon number"
        Else
            Label2.Text = CStr(user_input) + " is not a neon number"
        End If

    End Sub
End Class
