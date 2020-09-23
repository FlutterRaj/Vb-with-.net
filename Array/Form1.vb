Public Class Form1
    Dim range As Integer
    Dim array(0) As Integer
    Dim counter As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = True
        TextBox1.Visible = True
        Button1.Visible = False
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Then
            MessageBox.Show("Enter a integer value ..!")
        Else
            range = TextBox1.Text
            ReDim array(range)
            TextBox1.Clear()
            Label1.Visible = False
            TextBox1.Visible = False
            Button2.Visible = False
            Label2.Visible = True
            TextBox2.Visible = True
            Button3.Visible = True

            Label2.Text = "Add " + CStr(range) + " items .."
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If counter = (range - 1) Then
            Label2.Text = CStr(range) + " items added !"
            TextBox2.Visible = False
            Button3.Visible = False
            Button4.Visible = True
        End If

        array(counter) = TextBox2.Text
        TextBox2.Clear()
        counter += 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For index = 0 To (range - 1)
            ListBox1.Items.Add(array(index))
        Next
        Button5.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        ReDim array(0)
        counter = 0
        Button1.Visible = True
        Button4.Visible = False
        Label2.Visible = False
        Button5.Visible = False
    End Sub
End Class
