Public Class Home_Screen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Login_Screen.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
