Public Class Form1
    Function Qube(ByVal num As Integer)
        Dim result As Integer = 1
        result = num * num * num
        Qube = result
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum, re, backup As Integer
        Dim num As Integer
        num = TextBox1.Text
        backup = num

        While num > 0
            re = num Mod 10
            sum += Qube(re)
            num = Math.Floor(num / 10)
        End While

        If sum = backup Then
            Label1.Text = CStr(backup) + " is a amstrong number"
        Else
            Label1.Text = CStr(backup) + " is not a amstrong number"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Nothing
    End Sub
End Class
