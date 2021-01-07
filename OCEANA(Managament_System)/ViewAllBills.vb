Imports System.Data.OleDb
Public Class ViewAllBills
    Dim conOlEDB As New OleDbConnection
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=OceanaClinic.accdb;"
    Private Sub ViewAllBills_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conOlEDB.ConnectionString = con
        conOlEDB.Open()
        Dim sql = "SELECT [Treatment_ID] AS [Bill ID] ,[Treatment_Date] AS [Payment Date] ,[Patient_ID],[Treatment],[Medicine],[TotalFees] AS [Amount Paid(RM)] FROM [Treatment]"
        Dim cmd As New OleDbCommand(sql, conOlEDB)
        Dim da As New OleDbDataAdapter(cmd)
        Dim Treatment As New DataTable()
        da.Fill(Treatment)
        dgvBill.DataSource = Treatment
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Dim sql = "SELECT [Treatment_ID] AS [Bill ID] ,[Treatment_Date] AS [Payment Date] ,[Patient_ID],[Treatment],[Medicine],[TotalFees] AS [Amount Paid(RM)] FROM [Treatment]"
        Dim cmd As New OleDbCommand(sql, conOlEDB)
        Dim da As New OleDbDataAdapter(cmd)
        Dim Treatment As New DataTable()
        da.Fill(Treatment)
        dgvBill.DataSource = Treatment
    End Sub
End Class