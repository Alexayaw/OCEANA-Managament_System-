Public Class Admin_Main
    Dim f1 As New addProfile_Admin
    Dim f2 As New View_User_Profile
    Dim f3 As New Reset_Paaword

    Private Sub Admin_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Max(Me)
    End Sub


    Private Sub btnAddNewProfile_Click(sender As Object, e As EventArgs) Handles btnAddNewProfile.Click
        f1.MdiParent = Me
        Max(f1)
        f1.Show()
        f2.Hide()
        f3.Hide()
    End Sub

    Private Sub btnViewProfile_Click(sender As Object, e As EventArgs) Handles btnViewProfile.Click
        f2.MdiParent = Me
        Max(f2)
        f2.Show()
        f1.Hide()
        f3.Hide()
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        f3.MdiParent = Me
        Max(f3)
        f3.Show()
        f1.Hide()
        f2.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to log out?", "log out confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = MsgBoxResult.Yes Then
            Me.Hide()
            Home_Screen.Show()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        f1.Hide()
        f2.Hide()
        f3.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        f1.MdiParent = Me
        Max(f1)
        f1.Show()
        f2.Hide()
        f3.Hide()
    End Sub
End Class