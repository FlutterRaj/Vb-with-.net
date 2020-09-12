Public Class Prime
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user_input As Integer
        Dim is_prime As Boolean
        is_prime = True

        user_input = CInt(TextBox1.Text)

        If user_input = 1 Then
            Label2.Text = (CStr(user_input) + " is neither prime nor composite")
        Else
            For x = 2 To user_input / 2
                If user_input Mod x = 0 Then
                    is_prime = False
                    Exit For
                End If
            Next
            If is_prime = True Then
                Label2.Text = (CStr(user_input) + " is a Prime Number ")
            Else
                Label2.Text = (CStr(user_input) + " is not a Prime Number ")
            End If
        End If
    End Sub
End Class
