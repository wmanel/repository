Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Default Textbox1 Value
        TextBox1.Text = "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        'Pull value from Textbox1
        num1 = Val(TextBox1.Text)
        'Calculate
        TextBox1.Text = (num1 ^ 2)
    End Sub

    'Reset Textbox1 Value
    Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
        TextBox1.Text = "0"
    End Sub

End Class
