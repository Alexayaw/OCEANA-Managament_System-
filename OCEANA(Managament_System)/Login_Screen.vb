Imports System.Data
Imports System.Data.OleDb

Public Class Login_Screen
    Dim conOLEDB As New OleDbConnection
    Dim cmd, cmdSelect As New OleDbCommand

    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=OceanaClinic.accdb;"


    Private Sub Login_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Max(Me)

    End Sub
    'clear all textbox 
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtID.Clear()
        txtPassword.Clear()
        cmbType.ResetText()
        chkShowPassword.Checked = False

    End Sub

    'show password or hide password option 
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged

        If chkShowPassword.Checked = True Then
            'show password
            txtPassword.PasswordChar = ""
        Else
            'hide password 
            txtPassword.PasswordChar = "*"

        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Home_Screen.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conOLEDB.ConnectionString = con
            conOLEDB.Open()

            'Use data reader to Search for userID and verify password and userType
            Dim sql = "SELECT UserID, UserType , Password FROM [User] Where UserID ='" & txtID.Text & "' AND Password = '" & txtPassword.Text & "' AND UserType= '" & cmbType.Text & "' "
            cmd = New OleDbCommand(sql, conOLEDB)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()

            'If the datareader are able to match the input given by user to the data in database, allow user to log in to the system
            If (sdr.Read() = True) Then
                MessageBox.Show("Login Successfully!")

                'Load and open respective home screen for each user type 
                If cmbType.Text = "Doctor" Then
                    Doctor_Main_Screen.Show()

                ElseIf cmbType.Text = "Admin" Then
                    Admin_Main.Show()

                ElseIf cmbType.Text = "Staff" Then
                    Staff_Main.Show()

                End If

                'Clear all textbox after user had succesfully login.
                txtID.Clear()
                txtPassword.Clear()
                cmbType.ResetText()
                chkShowPassword.Checked = False
                Me.Hide()

            Else
                'If the input given by the user does not match the data in database then :

                MessageBox.Show("Invalid username or password!")

            End If
        Catch
            MsgBox("Error logging in, please try again", MsgBoxStyle.Exclamation)
        End Try

        conOLEDB.Close()
        'close the connection so that different user can log in again 
    End Sub
End Class