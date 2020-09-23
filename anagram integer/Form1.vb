' **********************************  Important note ****************************************
' This code uses some advance features of array and list.. if you're unfamilier with it,
' please first try to understand those things !
Public Class Form1
    Dim arr() As Integer = {211, 324, 121, 567, 756, 976, 679}
    Dim arr_anagram As New List(Of String)
    Dim index As Integer

    Function Anagram(ByVal num1 As String, ByVal num2 As String)
        Dim num3 As Integer = num1
        Dim num4 As Integer = num2

        num1 = New String(num1.OrderBy(Function(s) s).ToArray())
        num2 = New String(num2.OrderBy(Function(s) s).ToArray())

        If (num1 = num2) Then
            ListBox2.Items.Add(CStr(num3) + " is anagram of " + CStr(num4))
            If Not arr_anagram.Contains(num1) Then
                arr_anagram.Add(num1)
            End If
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For index = 0 To (arr.Length - 1)
            ListBox1.Items.Add(arr(index))
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Nothing
        Label2.Text = Nothing
        ListBox1.Items.Add("                      (·_·)      ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim first As Integer = 0
        Dim second As Integer = first + 1

        While first < (arr.Length - 1)
            Anagram(arr(first), arr(second))
            second += 1

            If (second = arr.Length) Then
                first += 1
                second = first + 1
            End If
        End While

        If arr_anagram.Count > 0 Then
            Label1.Text = CStr(arr_anagram.Count) + " anagram number presents !"
        Else
            Label1.Text = "no anagram  (>_<) number presents !"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox1.Items.Add("                      \(o_o)/      ")
        ListBox2.Items.Clear()
        Label1.Text = Nothing
        arr_anagram.Clear()

        Dim size As Integer
        Dim count As Integer = 0

        size = InputBox("How many items you want to insert ?")
        Array.Clear(arr, 0, arr.Length)
        ReDim arr(size - 1)

        While count < size
            arr(count) = InputBox("Enter item number --> " + CStr(count + 1))
            count += 1
        End While
        Button1.Text = "Load List"
        Label2.Text = "Tap *load list* 
                        for view you list !"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Array.Clear(arr, 0, arr.Length)
        ReDim arr(6)
        arr = {211, 324, 121, 567, 756, 976, 679}
        Button1.Text = "Load Sample List"
        Label1.Text = Nothing
        Label2.Text = Nothing
        arr_anagram.Clear()
        ListBox1.Items.Clear()
        ListBox1.Items.Add("                      \(o_o)/      ")
        ListBox2.Items.Clear()
    End Sub
End Class
