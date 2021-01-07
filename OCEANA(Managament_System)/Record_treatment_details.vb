Imports System.Data.OleDb
Imports System.Text
Public Class Record_treatment_details
    Dim conOlEDB As New OleDbConnection
    Dim cmd, cmdInsert As New OleDbCommand
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=OceanaClinic.accdb;"
    Dim i As Integer


    Private Sub Record_treatment_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conOlEDB.ConnectionString = con
        conOlEDB.Open()
        'Diplay previous treatment record in data gridView
        Dim sql = "SELECT Treatment.Treatment_ID, Treatment_Date, Treatment.Patient_ID, Patient.PatientName ,Treatment,Medicine, comment
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
        'Increment Treatment ID by one based on number of records in the databse 
        Dim Maxrow = getcount()
        i = Maxrow + 1
        lblTreatID.Text = CStr(i)

    End Sub
    'Function for auto incrementing the Treatment ID
    Function getcount() As Integer

        'Open the connection string if not open
        If Not conOlEDB.State = ConnectionState.Open Then
            conOlEDB.Open()
        End If

        Dim sqlCountRow = "Select MAX(Treatment_ID) FROM Treatment"
        Dim cmd As New OleDbCommand(sqlCountRow, conOlEDB)
        Return cmd.ExecuteScalar

    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearChkBox(chkMedA)
        clearChkBox(chkMedB)
        clearChkBox(ChkMedC)
        clearChkBox(chkMedD)
        clearChkBox(chkMedE)
        chkConsult.Checked = False
        chkFullcheck.Checked = False
        chkPartialCheck.Checked = False
        chkLab.Checked = False
        chkXray.Checked = False
        txtPatientID.Clear()
        txtComment.Clear()
    End Sub

    'Delete previous record
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not conOlEDB.State = ConnectionState.Open Then
            conOlEDB.Open()
        End If

        Dim prevTreatID = CInt(lblTreatID.Text) - 1
        Dim sqlDelete = "DELETE * FROM [Treatment] WHERE [Treatment_ID]= @TreatmentID"
        Dim cmdDelete As New OleDbCommand(sqlDelete, conOlEDB)
        cmdDelete.Parameters.AddWithValue("TreatmentID", prevTreatID)
        Dim result = MessageBox.Show("Are you sure you want to delete previous treatment details?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = MsgBoxResult.Yes Then
            MsgBox("Treatment Record deleted succesfully")
            cmdDelete.ExecuteNonQuery()
            Dim count = CInt(lblTreatID.Text) - 1
            lblTreatID.Text = count.ToString
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim sql = "SELECT Treatment.Treatment_ID, Treatment_Date, Treatment.Patient_ID, Patient.PatientName ,Treatment,Medicine, comment
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

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Patient_ID As Integer
        Dim TotalPrice As Integer
        Dim comment = txtComment.Text

        'Open the connection string if not open
        If Not conOlEDB.State = ConnectionState.Open Then
            conOlEDB.Open()
        End If

        'Check if User enter  Patient ID and Date  
        If txtPatientID.Text <> "" And Integer.TryParse(txtPatientID.Text, Patient_ID) Then

            Dim sqlPatientID = "SELECT PatientID FROM [Patient] Where PatientID =" & txtPatientID.Text & ";"
            cmd = New OleDbCommand(sqlPatientID, conOlEDB)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()

            'Check IF patient ID is valid
            If (sdr.Read() = True) Then
                Patient_ID = sdr("PatientID")




                'Treatment 
                Dim sb = New StringBuilder()
                If chkConsult.Checked = True Then
                    TotalPrice += 30
                    sb.Append(chkConsult.Text + ", ")
                End If
                If chkLab.Checked = True Then
                    TotalPrice += 100
                    sb.Append(chkLab.Text + ", ")
                End If
                If chkXray.Checked = True Then
                    TotalPrice += 50
                    sb.Append(chkXray.Text + ", ")
                End If
                If chkFullcheck.Checked = True Then
                    TotalPrice += 120
                    sb.Append(chkFullcheck.Text + ", ")
                End If
                If chkPartialCheck.Checked = True Then
                    TotalPrice += 75
                    sb.Append(chkPartialCheck.Text + ", ")

                End If

                'Medicine 
                Dim sbMedicine = New StringBuilder()
                If chkMedA.Checked = True Then
                    TotalPrice += 10
                    sbMedicine.Append(chkMedA.Text + ", ")
                End If
                If chkMedB.Checked = True Then
                    TotalPrice += 10
                    sbMedicine.Append(chkMedB.Text + ", ")
                End If
                If ChkMedC.Checked = True Then
                    TotalPrice += 10
                    sbMedicine.Append(ChkMedC.Text + ", ")
                End If
                If chkMedD.Checked = True Then
                    TotalPrice += 10
                    sbMedicine.Append(chkMedD.Text + ", ")
                End If
                If chkMedE.Checked = True Then
                    TotalPrice += 10
                    sbMedicine.Append(chkMedE.Text + ", ")

                End If

                'check if at least one treatment is selected 
                Dim checkboxes = {chkXray, chkPartialCheck, chkLab, chkFullcheck, chkConsult, chkPartialCheck}
                If Not checkboxes.Any(Function(cb) cb.Checked) Then

                    MsgBox("Please Select At least one treatment")
                Else
                    'If all conditions has been validated , insert all values into database

                    'Insert Treatment ID and Patient ID first 
                    cmd = New OleDbCommand("INSERT INTO Treatment(Treatment_ID, Patient_ID) VALUES(@TreatmentID,@PatientID)", conOlEDB)
                    cmd.Parameters.AddWithValue("@TreatmentID", lblTreatID.Text)
                    cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text)
                    cmd.ExecuteNonQuery()
                    'Update Treatment Details into Database
                    Dim sqlQryTreatment = "UPDATE Treatment SET Treatment =@Treatment WHERE Treatment_ID =@TreatmentID  "
                    cmd = New OleDbCommand(sqlQryTreatment, conOlEDB)
                    cmd.Parameters.AddWithValue("@Treatment", sb.ToString)
                    cmd.Parameters.AddWithValue("@TreatmentID", lblTreatID.Text)
                    cmd.ExecuteNonQuery()
                    'Update Medicine Prescribed into Database
                    Dim sqlQryMedicine = "UPDATE Treatment SET Medicine =@Medicine WHERE Treatment_ID =@TreatmentID  "
                    cmd = New OleDbCommand(sqlQryMedicine, conOlEDB)
                    cmd.Parameters.AddWithValue("@Medicine", sbMedicine.ToString)
                    cmd.Parameters.AddWithValue("@TreatmentID", lblTreatID.Text)
                    cmd.ExecuteNonQuery()

                    'Update TotalFees for single treatment 
                    MsgBox("Total treatment Fees : " & TotalPrice.ToString)
                    Dim sqlPrice = "UPDATE Treatment SET TotalFees= @TotalPrice WHERE Treatment_ID =@TreatmentID  "
                    Dim cmdInsertPrice = New OleDbCommand(sqlPrice, conOlEDB)
                    cmdInsertPrice.Parameters.AddWithValue("@TotalPrice", TotalPrice.ToString)
                    cmdInsertPrice.Parameters.AddWithValue("@TreatmentID", lblTreatID.Text)
                    cmdInsertPrice.ExecuteNonQuery() 'This will request to change one row in Database 

                    'Update Date
                    Dim sqlDate = "UPDATE Treatment Set Treatment_Date =@Date WHERE Treatment_ID =@TreatmentID"
                    cmd = New OleDbCommand(sqlDate, conOlEDB)
                    cmd.Parameters.AddWithValue("Date", dateTreat.Text)
                    cmd.Parameters.AddWithValue("@TreatmentID", lblTreatID.Text)
                    cmd.ExecuteNonQuery()

                    'If user enters any comment, insert the comment into database, otherwise, skip this 
                    If txtComment.Text <> "" Then
                        Dim sqlComment = "UPDATE Treatment Set Comment = @Comment WHERE Treatment_ID =@TreatmentID"
                        cmd = New OleDbCommand(sqlComment, conOlEDB)
                        cmd.Parameters.AddWithValue("@Comment", comment)
                        cmd.Parameters.AddWithValue("@TreatmentID", lblTreatID.Text)
                        cmd.ExecuteNonQuery()
                    End If


                    'conOlEDB.Close()
                    'Auto increment treatment ID by 1 
                    Dim Maxrow = getcount()
                    i = Maxrow + 1
                    lblTreatID.Text = CStr(i)

                End If

            Else
                MsgBox("Unregistered Patient ID!")

            End If

        Else
            MsgBox("Invalid information.")
        End If


        conOlEDB.Close()

        'Clear previous treatment price 
        TotalPrice = 0
        'Uncheck all check box 
        clearChkBox(chkMedA)
        clearChkBox(chkMedB)
        clearChkBox(ChkMedC)
        clearChkBox(chkMedD)
        clearChkBox(chkMedE)
        chkConsult.Checked = False
        chkFullcheck.Checked = False
        chkPartialCheck.Checked = False
        chkLab.Checked = False
        chkXray.Checked = False
        txtPatientID.Clear()
        txtComment.Clear()


    End Sub




End Class