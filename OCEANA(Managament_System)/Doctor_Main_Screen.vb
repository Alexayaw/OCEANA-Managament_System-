Public Class Doctor_Main_Screen
    Dim f1 As New RetrievePatientRecords
    Dim f2 As New Record_treatment_details
    Dim f3 As New Home_Screen
    Dim f4 As New ViewAllPatient


    Private Sub Doctor_Main_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Max(Me)
    End Sub

    Private Sub btnRerievePatientRecord_Click(sender As Object, e As EventArgs) Handles btnRerievePatientRecord.Click
        f1.MdiParent = Me
        f1.WindowState = FormWindowState.Maximized
        f1.Show()
        f2.Hide()
        f4.Hide()
    End Sub

    Private Sub btnAddTreatment_Click(sender As Object, e As EventArgs) Handles btnAddTreatment.Click
        f2.MdiParent = Me
        f2.WindowState = FormWindowState.Maximized
        f2.Show()
        f1.Hide()
        f4.Hide()
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
        f4.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        f2.MdiParent = Me
        f2.WindowState = FormWindowState.Maximized
        f2.Show()
        f1.Hide()
        f4.Hide()
    End Sub

    Private Sub btnViewAllPatient_Click(sender As Object, e As EventArgs) Handles btnViewAllPatient.Click
        f4.MdiParent = Me
        Max(f4)
        f4.Show()
        f1.Hide()
        f2.Hide()


    End Sub
End Class