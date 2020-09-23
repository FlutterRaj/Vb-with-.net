Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspont.com"
        ' creating multi-column and multiselect list box
        ListBox1.MultiColumn = True
        ListBox1.SelectionMode = SelectionMode.MultiExtended
    End Sub

    'populates the list
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) _
       Handles Button1.Click
        ListBox1.Items.Add("Safety")
        ListBox1.Items.Add("Security")
        ListBox1.Items.Add("Governance")
        ListBox1.Items.Add("Good Music")
        ListBox1.Items.Add("Good Movies")
        ListBox1.Items.Add("Good Books")
        ListBox1.Items.Add("Education")
        ListBox1.Items.Add("Roads")
        ListBox1.Items.Add("Health")
        ListBox1.Items.Add("Food for all")
        ListBox1.Items.Add("Shelter for all")
        ListBox1.Items.Add("Industrialisation")
        ListBox1.Items.Add("Peace")
        ListBox1.Items.Add("Liberty")
        ListBox1.Items.Add("Freedom of Speech")
    End Sub
    'sorting the list
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
       Handles Button2.Click
        ListBox1.Sorted = True
    End Sub

    'clears the list
    Private Sub Button3_Click(sender As Object, e As EventArgs) _
       Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    'removing the selected item
    Private Sub Button4_Click(sender As Object, e As EventArgs) _
           Handles Button4.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem.ToString)
    End Sub

    'counting the numer of items
    Private Sub Button5_Click(sender As Object, e As EventArgs) _
       Handles Button5.Click
        Label1.Text = ListBox1.Items.Count
    End Sub

    'displaying the selected item on the third label
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) _
       Handles ListBox1.SelectedIndexChanged
        Label3.Text = ListBox1.SelectedItem.ToString()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class