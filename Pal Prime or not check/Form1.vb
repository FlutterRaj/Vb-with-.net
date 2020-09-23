Public Class Form1
    Function palindrome(ByVal num As Integer)
        Dim backup As Integer = num
        Dim reminder, sum As Integer

        While num > 0
            reminder = num Mod 10
            sum = sum * 10 + reminder
            num = Math.Floor(num / 10)
        End While
        If sum = backup Then
            palindrome = True
        End If
    End Function

    Function prime(ByVal num As Integer)
        Dim isPrime As Boolean = True

        For index = 2 To Math.Floor(num / 2)
            If num Mod index = 0 Then
                isPrime = False
                Exit For
            End If
        Next
        prime = isPrime
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userInput As Integer
        userInput = TextBox1.Text

        If palindrome(userInput) Then
            If prime(userInput) Then
                Label2.Text = CStr(userInput) + " is a Pal Prime number"
            Else
                Label2.Text = CStr(userInput) + " is not a Pal Prime number"
            End If
        Else
            Label2.Text = CStr(userInput) + " is a Prime number"
        End If
    End Sub
End Class
