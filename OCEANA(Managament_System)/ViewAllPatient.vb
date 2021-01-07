Imports System.Data.OleDb
Public Class ViewAllPatient
    Dim conOlEDB As New OleDbConnection
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=OceanaClinic.accdb;"
    Private Sub ViewAllPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Max(Me)
        conOlEDB.ConnectionString = con
        conOlEDB.Open()

        Dim sql = "SELECT * FROM [Patient] "
        Dim cmd As New OleDbCommand(sql, conOlEDB)
        Dim da As New OleDbDataAdapter(cmd)
        Dim Patient As New DataTable()
        da.Fill(Patient)
        dgvAllpatients.DataSource = Patient

        conOlEDB.Close()
    End Sub



    Private Sub btnSearchID_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click
        If Not conOlEDB.State = ConnectionState.Open Then
            conOlEDB.Open()
        End If
        Dim PatientID As Integer
        If txtID.Text <> "" Then
            If Integer.TryParse(txtID.Text, PatientID) Then
                PatientID = CInt(txtID.Text)
                Dim qry = "SELECT * FROM Patient WHERE PatientID =@PatientID"
                Dim cmd As New OleDbCommand(qry, conOlEDB)
                cmd.Parameters.AddWithValue("@PatientID", PatientID)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()
                If dr.Read() = True Then
                    Dim qry2 = "SELECT * FROM Patient WHERE PatientID =@PatientID"
                    Dim cmd2 As New OleDbCommand(qry, conOlEDB)
                    cmd2.Parameters.AddWithValue("@PatientID", PatientID)
                    Dim da As New OleDbDataAdapter(cmd2)
                    Dim Patient As New DataTable
                    da.Fill(Patient)
                    dgvAllpatients.DataSource = Patient
                Else
                    MsgBox("Patient ID not found")
                End If
            Else
                MsgBox("Please enter valid ID.")
            End If
        End If

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If Not conOlEDB.State = ConnectionState.Open Then
            conOlEDB.Open()
        End If
        Dim sql = "SELECT * FROM [Patient] "
        Dim cmd As New OleDbCommand(sql, conOlEDB)
        Dim da As New OleDbDataAdapter(cmd)
        Dim Patient As New DataTable()
        da.Fill(Patient)
        dgvAllpatients.DataSource = Patient
        txtName.Clear()
        txtID.Clear()
        conOlEDB.Close()
    End Sub

    Private Sub btnSearchName_Click(sender As Object, e As EventArgs) Handles btnSearchName.Click
        If Not conOlEDB.State = ConnectionState.Open Then
            conOlEDB.Open()
        End If
        If txtName.Text <> "" Then
            Dim PatientName = txtName.Text
            Dim qry = "SELECT * FROM Patient WHERE PatientName =@PatientName"
            Dim cmd As New OleDbCommand(qry, conOlEDB)
            cmd.Parameters.AddWithValue("@PatientName", PatientName)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            If dr.Read() = True Then
                Dim qry2 = "SELECT * FROM Patient WHERE PatientName =@PatientID"
                Dim cmd2 As New OleDbCommand(qry, conOlEDB)
                cmd2.Parameters.AddWithValue("@PatientName", PatientName)
                Dim da As New OleDbDataAdapter(cmd2)
                Dim Patient As New DataTable
                da.Fill(Patient)
                dgvAllpatients.DataSource = Patient
            Else
                MsgBox("Patient Name Not found.")
            End If
        Else
            MsgBox("Please enter patient name.")
        End If
    End Sub
End Class