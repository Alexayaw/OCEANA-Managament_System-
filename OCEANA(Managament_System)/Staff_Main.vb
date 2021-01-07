Public Class Staff_Main
    Dim f1 As New CreatePatient_Screen
    Dim f2 As New Edit_Screen
    Dim f3 As New Billing
    Dim f4 As New ViewAllPatient

    'A function to maximize all form 
    Sub Max(ByVal f As Form)
        f.WindowState = FormWindowState.Maximized

    End Sub

    Sub Logout()
        Dim result = MessageBox.Show("Are you sure you want to log out?", "log out confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = MsgBoxResult.Yes Then
            Me.Hide()
            Home_Screen.Show()
        End If
    End Sub


    Private Sub btnAddTreatment_Click(sender As Object, e As EventArgs) Handles btnViewPatientProfile.Click
        f2.MdiParent = Me
        Max(f2)
        f1.Hide()
        f2.Show()
        f3.Hide()
        f4.Hide()
    End Sub

    Private Sub btnAddPatientProfile_Click(sender As Object, e As EventArgs) Handles btnAddPatientProfile.Click
        f1.MdiParent = Me
        Max(f1)
        f1.Show()
        f2.Hide()
        f3.Hide()
        f4.Hide()
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        f3.MdiParent = Me
        Max(f3)
        f3.Show()
        f1.Hide()
        f2.Hide()
        f4.Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        f1.Hide()
        f2.Hide()
        f3.Hide()
        f4.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        f1.MdiParent = Me
        Max(f1)
        f1.Show()
        f2.Hide()
        f3.Hide()
        f4.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Logout()
    End Sub

    Private Sub Staff_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        f4.MdiParent = Me
        Max(f4)
        f4.Show()
        f1.Hide()
        f2.Hide()
        f3.Hide()
    End Sub
End Class