Imports System.Data.OleDb
Public Class ViewAllUser
    Dim conOlEDB As New OleDbConnection
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=OceanaClinic.accdb;"
    Private Sub ViewAllUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conOlEDB.ConnectionString = con
        conOlEDB.Open()

        Dim sql = "SELECT [FullName], [UserID],[UserType],[MobileNo],[Email] FROM [User]  "
        Dim cmd As New OleDbCommand(sql, conOlEDB)
        Dim da As New OleDbDataAdapter(cmd)
        Dim User As New DataTable
        da.Fill(User)
        dgvUser.DataSource = User

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If Not conOlEDB.State = ConnectionState.Open Then
            conOlEDB.Open()
        End If
        Dim sql = "SELECT [FullName], [UserID],[UserType],[MobileNo],[Email] FROM [User]  "
        Dim cmd As New OleDbCommand(sql, conOlEDB)
        Dim da As New OleDbDataAdapter(cmd)
        Dim User As New DataTable
        da.Fill(User)
        dgvUser.DataSource = User
    End Sub
End Class