Imports System.Data.OleDb
Public Class addProfile_Admin
    Dim conOlEDB As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= OceanaClinic.accdb;"

    'Create user profile 
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim UserID = txtUserID.Text
        Dim UserName = txtName.Text
        Dim NewPass = txtNewPass.Text
        Dim ComPass = txtComPass.Text
        Dim UserType = cmbUserType.Text
        Dim MobileNo = txtMobile.Text
        Dim Email = txtEmail.Text

        'check if textbox is empty
        If UserID <> "" And UserName <> "" And NewPass <> "" And ComPass <> "" And MobileNo <> "" And Email <> "" Then
            'Check if UserID is already existed 
            Dim sqlCheckUserID = "SELECT UserID FROM [User] WHERE UserID =@UserID"
            cmd = New OleDbCommand(sqlCheckUserID, conOlEDB)
            cmd.Parameters.AddWithValue("@UserID", UserID)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = False) Then
                'Check if new password same with comfirmed password 
                If NewPass = ComPass Then
                    Dim result = MessageBox.Show("Create New profile ? " & vbNewLine & "User Full Name: " & UserName & vbNewLine & "User ID: " & UserID & vbNewLine & "Password: " & NewPass, "User Profile Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If result = MsgBoxResult.Yes Then
                        'If all conditions has been met then perform the following action : 
                        'Insert UserID 
                        Dim sqlinsertUserID_Name = "INSERT INTO [User](UserID,FullName) VALUES(@UserID, @UserName)"
                        cmd = New OleDbCommand(sqlinsertUserID_Name, conOlEDB)
                        cmd.Parameters.AddWithValue("@UserID", UserID)
                        cmd.Parameters.AddWithValue("@UserName", UserName)
                        cmd.ExecuteNonQuery()

                        'Update password and userType ,mobileNo,Email based on the UserID that had just been inserted
                        Dim sqlInsertPass_Type = "UPDATE [User] SET [Password] =@NewPass , [UserType] =@UserType , [MobileNo]= @MobileNo , [Email] = @Email WHERE UserID =@UserID "
                        cmd = New OleDbCommand(sqlInsertPass_Type, conOlEDB)

                        cmd.Parameters.AddWithValue("@NewPass", NewPass)
                        cmd.Parameters.AddWithValue("@UserType", UserType)
                        cmd.Parameters.AddWithValue("@MobileNo", MobileNo)
                        cmd.Parameters.AddWithValue("@Email", Email)
                        cmd.Parameters.AddWithValue("@UserID", UserID)
                        cmd.ExecuteNonQuery()

                        MsgBox("Succesfully created new profile for user: " & UserName)
                        txtComPass.Clear()
                        txtName.Clear()
                        txtNewPass.Clear()
                        txtUserID.Clear()
                        txtEmail.Clear()
                        txtMobile.Clear()

                        cmbUserType.ResetText()
                    End If
                Else
                    MsgBox("New password does not match confirmed password.")
                    txtNewPass.Clear()
                    txtComPass.Clear()
                End If
            Else
                MsgBox("UserID already existed, please try again.")
            End If
        Else
            MsgBox("Missing required information.")

        End If



    End Sub

    'form load event 
    Private Sub addProfile_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conOlEDB.ConnectionString = con
        conOlEDB.Open()

    End Sub

    'clear all controls
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtComPass.Clear()
        txtName.Clear()
        txtNewPass.Clear()
        txtUserID.Clear()
        txtMobile.Clear()
        txtEmail.Clear()

        cmbUserType.ResetText()

    End Sub
End Class