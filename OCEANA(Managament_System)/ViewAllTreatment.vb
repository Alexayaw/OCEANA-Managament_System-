Imports System.Data.OleDb
Public Class ViewAllTreatment
    Dim conOlEDB As New OleDbConnection
    'Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\user\Documents\OceanaClinic.accdb;"
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= OceanaClinic.accdb;"
    Private Sub ViewAllTreatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conOlEDB.ConnectionString = con
        conOlEDB.Open()

        Dim sql = "SELECT Treatment.Treatment_ID, Treatment_Date, Treatment.Patient_ID, Patient.PatientName ,Treatment,Medicine
         FROM Treatment INNER JOIN Patient 
        ON Treatment.Patient_ID = Patient.PatientID
        "
        Dim cmd As New OleDbCommand(sql, conOlEDB)
        Dim da As New OleDbDataAdapter(cmd)
        Dim Treatment, Patient As New DataTable()
        da.Fill(Treatment)
        da.Fill(Patient)
        dgvTreatment.DataSource = Treatment
        dgvTreatment.DataSource = Patient

    End Sub

    Private Sub btnSearchID_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click
        Dim PatientID As Integer
        If txtID.Text <> "" And Integer.TryParse(txtID.Text, PatientID) Then
            'PatientID = CInt(txtID.Text)
            Dim PatientName As String
            'Dim query1 = "SELECT Treatment.Treatment_ID, Patient.PatientName ,Patient.PatientID = @PatientID
            'FROM Treatment,Patient 
            'WHERE (Treatment.Patient_ID= @PatientID) = (SELECT PatientID FROM patient WHERE PatientID = @PatientID) ;"
            Dim query = "SELECT * FROM Patient WHERE PatientID = @PatientID"
            Dim cmdR As New OleDbCommand(query, conOlEDB)
            cmdR.Parameters.AddWithValue("@PatientID", PatientID)
            Dim dr As OleDbDataReader = cmdR.ExecuteReader()
            If dr.Read() = True Then
                PatientID = dr("PatientID")
                PatientName = dr("PatientName")
                lblPatientID.Text = PatientID
                lblPatientName.Text = PatientName
            Else
                MsgBox("Patient ID not found!")
            End If


            dr.Close()
            Dim query1 = "SELECT Treatment.Treatment_ID, Treatment_Date, Treatment.Patient_ID, Patient.PatientName ,Treatment,Medicine
         FROM Treatment INNER JOIN Patient 
        ON Treatment.Patient_ID = Patient.PatientID
        WHERE Treatment.Patient_ID = @PatientID;"
            Dim cmd As New OleDbCommand(query1, conOlEDB)
            cmd.Parameters.AddWithValue("@PatientID", PatientID)
            Dim da As New OleDbDataAdapter(cmd)

            Dim Treatment, Patient As New DataTable()
            da.Fill(Treatment)
            da.Fill(Patient)
            dgvTreatment.DataSource = Treatment
            dgvTreatment.DataSource = Patient
            Dim i = dgvTreatment.Rows.Count
            If i = 0 Then
                MsgBox("No treatment records found for patient: " & lblPatientName.Text)
            End If
        Else
            MsgBox("Please enter valid Patient ID")
        End If


    End Sub

    Private Sub btnSearchName_Click(sender As Object, e As EventArgs) Handles btnSearchName.Click
        If txtName.Text <> "" Then
            Dim PatientName = txtName.Text
            Dim PatientID As Integer
            Dim query = "SELECT PatientID FROM Patient WHERE PatientName = @PatientName"
            Dim cmd As New OleDbCommand(query, conOlEDB)
            cmd.Parameters.AddWithValue("@PatientName", PatientName)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            If dr.Read() = True Then
                PatientID = dr("PatientID")
                lblPatientID.Text = PatientID
                lblPatientName.Text = PatientName
                MsgBox("Found patient with name " & PatientName)
            Else
                MsgBox("Patient name not found!")
            End If
            dr.Close()
            conOlEDB.Close()
            conOlEDB.Open()
            Dim query1 = "SELECT Treatment.Treatment_ID, Treatment_Date, Treatment.Patient_ID, Patient.PatientName ,Treatment,Medicine
         FROM Treatment INNER JOIN Patient 
        ON Treatment.Patient_ID = Patient.PatientID 
        WHERE Treatment.Patient_ID = @PatientID;"
            Dim cmd2 As New OleDbCommand(query1, conOlEDB)
            cmd2.Parameters.AddWithValue("@PatientID", PatientID)
            Dim da As New OleDbDataAdapter(cmd2)
            Dim Treatment, Patient As New DataTable
            da.Fill(Treatment)
            da.Fill(Patient)
            dgvTreatment.DataSource = Treatment
            dgvTreatment.DataSource = Patient
            Dim i = dgvTreatment.Rows.Count
            If i = 0 Then
                MsgBox("No treatment records found for patient: " & lblPatientName.Text)
            End If
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        lblPatientID.Text = ""
        lblPatientName.Text = ""
        txtID.Clear()
        txtName.Clear()


        Dim sql = "SELECT Treatment.Treatment_ID, Treatment_Date, Treatment.Patient_ID, Patient.PatientName ,Treatment,Medicine
         FROM Treatment INNER JOIN Patient 
        ON Treatment.Patient_ID = Patient.PatientID
        "
        Dim cmd As New OleDbCommand(sql, conOlEDB)
        Dim da As New OleDbDataAdapter(cmd)
        Dim Treatment, Patient As New DataTable()
        da.Fill(Treatment)
        da.Fill(Patient)
        dgvTreatment.DataSource = Treatment
        dgvTreatment.DataSource = Patient
    End Sub
End Class