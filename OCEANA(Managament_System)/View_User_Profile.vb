Imports System.Data.OleDb
Public Class View_User_Profile
    Dim conOlEDB As New OleDbConnection
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=OceanaClinic.accdb;"
    Private Sub View_User_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conOlEDB.ConnectionString = con
        conOlEDB.Open()
    End Sub

    'search user by ID
    Private Sub btnSearchID_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click
        txtUserName.Clear()
        If txtUser_ID.Text <> "" Then
            Dim sqlSearchID = "SELECT * FROM [User] Where [UserID] =@UserID"
            Dim cmdSearchID As New OleDbCommand(sqlSearchID, conOlEDB)
            cmdSearchID.Parameters.AddWithValue("UserID", txtUser_ID.Text)
            Dim IDdr As OleDbDataReader = cmdSearchID.ExecuteReader()
            If IDdr.Read() = True Then
                txtUserID.Text = IDdr("UserID")
                txtName.Text = IDdr("FullName")
                cboUserType.Text = IDdr("UserType")
                txtEmail.Text = IDdr("Email")
                txtMobileNo.Text = IDdr("MobileNo")
            Else
                MsgBox("Invalid User ID")
            End If
        Else
            MsgBox("Please enter user ID")
        End If
    End Sub

    'search user by name
    Private Sub btnSearchName_Click(sender As Object, e As EventArgs) Handles btnSearchName.Click
        txtUser_ID.Clear()
        If txtUserName.Text <> "" Then
            Dim sqlSearchName = "SELECT * FROM [User] Where [FullName] =@FullName"
            Dim cmdSearchName As New OleDbCommand(sqlSearchName, conOlEDB)
            cmdSearchName.Parameters.AddWithValue("FullName", txtUserName.Text)
            Dim Namedr As OleDbDataReader = cmdSearchName.ExecuteReader()
            If Namedr.Read() = True Then
                txtUserID.Text = Namedr("UserID")
                txtName.Text = Namedr("FullName")
                cboUserType.Text = Namedr("UserType")
                txtEmail.Text = Namedr("Email")
                txtMobileNo.Text = Namedr("MobileNo")
            Else
                MsgBox("User with name: " & txtUserName.Text & " not found.")
            End If
        Else
            MsgBox("Please enter user full name")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all textbox 
        txtUser_ID.Clear()
        txtUserID.Clear()
        txtUserName.Clear()
        txtName.Clear()
        txtEmail.Clear()
        txtMobileNo.Clear()
        cboUserType.ResetText()

    End Sub

    'Check if user enabled edit function 
    Private Sub chkEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chkEdit.CheckedChanged
        If chkEdit.Checked = True Then
            btnUpdate.Visible = True
            btnDelete.Visible = True
            btnResetPass.Visible = True
            txtName.ReadOnly = False
            txtEmail.ReadOnly = False
            txtMobileNo.ReadOnly = False
            cboUserType.Enabled = True
        Else
            btnUpdate.Visible = False
            btnDelete.Visible = False
            btnResetPass.Visible = False
            txtName.ReadOnly = True
            txtEmail.ReadOnly = True
            txtMobileNo.ReadOnly = True
            cboUserType.Enabled = False
        End If
    End Sub

    'Update user info 
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim UserID = txtUserID.Text
        Dim FullName = txtName.Text
        Dim MobileNo = txtMobileNo.Text
        Dim Email = txtEmail.Text
        Dim UserType = cboUserType.Text

        Dim sqlUpdate = "UPDATE [User] Set [FullName] = @FullName, [MobileNo] =@MobileNo , [Email]=@Email, [UserType] = @UserType Where [UserID] =@UserID"
        Dim cmdUpdate As New OleDbCommand(sqlUpdate, conOlEDB)
        cmdUpdate.Parameters.AddWithValue("FullNamw", FullName)
        cmdUpdate.Parameters.AddWithValue("MobileNo", MobileNo)
        cmdUpdate.Parameters.AddWithValue("Email", Email)
        cmdUpdate.Parameters.AddWithValue("UserType", UserType)
        cmdUpdate.Parameters.AddWithValue("UserID", UserID)

        If txtUserID.Text <> "" And FullName <> "" And MobileNo <> "" And Email <> "" And UserType <> "" Then
            cmdUpdate.ExecuteNonQuery()
            MsgBox("Succesfully updated.")
        Else
            MsgBox("Incomplete information, update unsuccesful.")
        End If
    End Sub

    'Delete user from system
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtUserID.Text <> "" Then
            Dim sqlDelete = "DELETE * FROM [User] WHERE [UserID]=@UserID"
            Dim cmdDelete As New OleDbCommand(sqlDelete, conOlEDB)
            cmdDelete.Parameters.AddWithValue("UserID", txtUserID.Text)
            Dim result = MessageBox.Show("Are you sure you want to delete " & txtUserID.Text & " from the system?" & vbNewLine & "Please note that this action is irreversible", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = MsgBoxResult.Yes Then
                MsgBox("User: " & txtUserID.Text & " has been succesfully deleted from the system.")
                cmdDelete.ExecuteNonQuery()

            End If
        Else
            MsgBox("No profile selected.")
        End If
    End Sub

    Private Sub btnResetPass_Click(sender As Object, e As EventArgs) Handles btnResetPass.Click
        Reset_Paaword.txtUserName.Text = txtUserID.Text
        Reset_Paaword.Show()

    End Sub

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged

    End Sub

    Private Sub btnViewAllUser_Click(sender As Object, e As EventArgs) Handles btnViewAllUser.Click
        ViewAllUser.Show()

    End Sub
End Class