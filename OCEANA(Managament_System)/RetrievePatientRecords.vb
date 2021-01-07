Imports System.Data.OleDb
Public Class RetrievePatientRecords

    Dim conOlEDB As New OleDbConnection
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=OceanaClinic.accdb;"
    Private Sub RetrievePatientRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.WindowState = FormWindowState.Maximized
        conOlEDB.ConnectionString = con
        conOlEDB.Open()
    End Sub


    Private Sub btnSearchID_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click
        Dim PatientID As Integer
        If txtID.Text <> "" And Integer.TryParse(txtID.Text, PatientID) Then


            'Use data reader to search Patient ID in database
            Dim sqlSearchID = "SELECT * FROM [Patient] WHERE [PatientID]=@PatientID"
            Dim cmdSearchID As New OleDbCommand(sqlSearchID, conOlEDB)
            cmdSearchID.Parameters.AddWithValue("PatientID", PatientID)
            Dim dr As OleDbDataReader = cmdSearchID.ExecuteReader()
            If dr.Read() = True Then
                'Assign value from database into each textbox 
                txtPatientName.Text = dr("PatientName")
                txtPatientID.Text = dr("PatientID")
                txtWeight.Text = dr("weight")
                txtHeight.Text = dr("height")
                txtAllergies.Text = dr("allergies")
                txtBlood.Text = dr("bloodtype")
                'close the OledbReader first in order to perform another reader 
                dr.Close()
                'Display data in data grid view 
                Dim sql = "SELECT [Treatment_Date],[Treatment],[Medicine],[Comment],[TotalFees] FROM [Treatment] WHERE [Patient_ID] =@PatientID"
                Dim cmd As New OleDbCommand(sql, conOlEDB)
                cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text)
                Dim myDA As New OleDbDataAdapter(cmd)
                'Dim myDataSet As New DataSet
                'myDA.Fill(myDataSet, "Treatment")
                'dgvTreatment.DataSource = myDataSet.Tables("Treatment").DefaultView

                Dim Treatment As New DataTable()
                myDA.Fill(Treatment)
                dgvTreatment.DataSource = Treatment

                Dim i = dgvTreatment.Rows.Count
                If i = 1 Then
                    MsgBox("No treatment records found for patient: " & txtPatientName.Text)
                End If





            Else
                MsgBox("Patient ID not found.")
            End If

        Else
            MsgBox("Please enter valid patient ID")


        End If
    End Sub

    Private Sub btnSearchName_Click(sender As Object, e As EventArgs) Handles btnSearchName.Click
        If txtName.Text <> "" Then
            Dim sqlSearchName = "SELECT * FROM [Patient] WHERE [PatientName]=@PatientName"
            Dim cmdSearchName As New OleDbCommand(sqlSearchName, conOlEDB)
            cmdSearchName.Parameters.AddWithValue("PatientName", txtName.Text)
            Dim dr As OleDbDataReader = cmdSearchName.ExecuteReader()
            If dr.Read() = True Then
                'assign value from database to each textbox 
                txtPatientName.Text = dr("PatientName")
                txtPatientID.Text = dr("PatientID")
                txtWeight.Text = dr("weight")
                txtHeight.Text = dr("height")
                txtAllergies.Text = dr("allergies")
                txtBlood.Text = dr("bloodtype")
                'close the datareader 
                dr.Close()
                'open another reader to insert data into data grid view 
                Dim sql = "SELECT [Treatment_Date],[Treatment],[Medicine],[Comment],[TotalFees] FROM [Treatment] WHERE [Patient_ID] =@PatientID"
                Dim cmd As New OleDbCommand(sql, conOlEDB)
                cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text)
                Dim myDA As New OleDbDataAdapter(cmd)
                Dim myDataSet As New DataSet
                myDA.Fill(myDataSet, "Treatment")
                dgvTreatment.DataSource = myDataSet.Tables("Treatment").DefaultView

                Dim i = dgvTreatment.Rows.Count
                If i = 1 Then
                    MsgBox("No treatment records found for patient: " & txtPatientName.Text)
                End If
            Else
                MsgBox("Patient with name " & txtName.Text & " not found.")
            End If
        Else
            MsgBox("Please enter patient name.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim AllTextbox() = {txtAllergies, txtBlood, txtHeight, txtID, txtName, txtPatientID, txtPatientName, txtWeight, txtWeight}
        For Each Textbox As TextBox In AllTextbox
            Textbox.Clear()
        Next

        'clear data grid view

        dgvTreatment.Columns.Clear()



    End Sub
End Class