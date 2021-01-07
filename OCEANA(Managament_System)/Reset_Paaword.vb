Imports System.Data.OleDb
Public Class Reset_Paaword
    Dim conOlEDB As New OleDbConnection
    Dim cmd, cmdInsert As New OleDbCommand
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=OceanaClinic.accdb;"
    Dim Mainform As New View_User_Profile

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim UserName = txtUserName.Text
        Dim OldPass = txtOldPass.Text
        Dim NewPass = txtNewPass.Text
        Dim ComPass = txtComPass.Text
        'To do : pass the value from view profile to reset password 


        'Check if textbox is empty 
        If UserName <> "" And OldPass <> "" And NewPass <> "" And ComPass <> "" Then
            'Check if UserName is valid
            Dim sqlUserName = "SELECT UserID FROM [User] WHERE UserID =@UserID"
            cmd = New OleDbCommand(sqlUserName, conOlEDB)
            cmd.Parameters.AddWithValue("@UserID", UserName)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()


            If (sdr.Read() = True) Then
                UserName = sdr("UserID")

                'Check If oldpassword match 
                Dim sqlOldPass = "SELECT Password FROM [User] Where Password =@OldPass"
                cmd = New OleDbCommand(sqlOldPass, conOlEDB)
                cmd.Parameters.AddWithValue("@OldPass", OldPass)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()
                If (dr.Read() = True) Then
                    'Check if new password same with comfirmed password
                    If NewPass = ComPass Then
                        'Update password for specified user
                        Dim sqlUpdatePass = "UPDATE [User] SET [Password] = @NewPass WHERE UserID = @UserID "
                        cmd = New OleDbCommand(sqlUpdatePass, conOlEDB)
                        cmd.Parameters.AddWithValue("@NewPass", NewPass)
                        cmd.Parameters.AddWithValue("@UserID", UserName)
                        cmd.ExecuteNonQuery()
                        MsgBox("Succesfully reset password for user: " & UserName)
                    Else
                        MsgBox("New password does not match confirmed password.")
                        txtNewPass.Clear()
                        txtComPass.Clear()
                    End If

                Else
                    MsgBox("Old password does not match UserID.")
                End If


            Else
                MsgBox("Invalid username.")
                txtUserName.Clear()
            End If
        End If

    End Sub

    'clear all textbox 
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserName.Clear()
        txtOldPass.Clear()
        txtNewPass.Clear()
        txtComPass.Clear()
    End Sub

    'show/hide password option
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtOldPass.PasswordChar = ""
            txtNewPass.PasswordChar = ""
            txtComPass.PasswordChar = ""
        Else

            txtOldPass.PasswordChar = "*"
            txtNewPass.PasswordChar = "*"
            txtComPass.PasswordChar = "*"

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()

    End Sub


    Private Sub Reset_Paaword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conOlEDB.ConnectionString = con
        conOlEDB.Open()


    End Sub

End Class