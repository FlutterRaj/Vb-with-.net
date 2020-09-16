Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lb, ub, intarval As Integer
        Dim sum As Integer
        sum = 0

        lb = CInt(TextBox1.Text)
        ub = CInt(TextBox2.Text)
        intarval = CInt(TextBox3.Text)

        For index = lb To ub Step intarval        'for negative steps--'
            sum += index
        Next

        Label4.Text = sum
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Nothing
    End Sub
End Class
