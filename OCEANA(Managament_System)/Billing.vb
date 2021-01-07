Imports System.Data.OleDb
Public Class Billing
    Dim conOlEDB As New OleDbConnection
    Dim cmd As New OleDbCommand
    ' Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\user\Documents\OceanaClinic.accdb;"
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= OceanaClinic.accdb;"
    Dim TreatmentID As Integer
    Dim TotalFees, PatientID As Integer
    Dim Services, Medicine, PatientName As String
    'Dim BillNo As Integer

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstBill.Items.Clear()
        txtTreatmentID.Clear()
        lblPatientID.Text = ""
        lblName.Text = ""
        lblServices.Text = ""
        lblMedicine.Text = ""
        lblFees.Text = ""
        lblChange.Text = ""
        txtFeesPaid.Clear()
        btnBill.Visible = False
        btnSave.Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MsgBox("Succesfully save bill records to database!")
    End Sub

    Private Sub btnViewAllTreatment_Click(sender As Object, e As EventArgs) Handles btnViewAllTreatment.Click
        ViewAllTreatment.Show()
    End Sub


    Private Sub btnViewAllBill_Click(sender As Object, e As EventArgs) Handles btnViewAllBill.Click
        ViewAllBills.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click


        If txtTreatmentID.Text <> "" And Integer.TryParse(txtTreatmentID.Text, TreatmentID) Then
            TreatmentID = CInt(txtTreatmentID.Text)
            Dim sqlSearchID = "SELECT * FROM [Treatment] WHERE [Treatment_ID] = @TreatmentID "
            Dim cmdSearchID As New OleDbCommand(sqlSearchID, conOlEDB)
            cmdSearchID.Parameters.AddWithValue("@TreatmentID", TreatmentID)

            Dim dr As OleDbDataReader = cmdSearchID.ExecuteReader()


            If dr.Read() = True Then
                'Assign the value stored in the database to the declared variables
                TotalFees = dr("TotalFees")
                Services = dr("Treatment")
                Medicine = dr("Medicine")
                PatientID = dr("Patient_ID")

                'Search for patient name after finding patient ID
                Dim sqlSearchName = "SELECT * FROM [Patient] WHERE [PatientID] = @PatientID"
                Dim cmdSearchName As New OleDbCommand(sqlSearchName, conOlEDB)
                cmdSearchName.Parameters.AddWithValue("@PatientID", PatientID)

                Dim namedr As OleDbDataReader = cmdSearchName.ExecuteReader()
                If namedr.Read() = True Then
                    PatientName = namedr("PatientName")


                End If
                btnBill.Visible = True

                'Assign variables values into labels , in order to display the values
                lblFees.Text = TotalFees
                lblMedicine.Text = Medicine
                lblPatientID.Text = PatientID
                lblServices.Text = Services
                lblName.Text = PatientName


            Else

                MsgBox("Treatment ID Not found")


            End If
        Else
            MessageBox.Show("Please enter valid Treatment ID.")
        End If
    End Sub

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conOlEDB.ConnectionString = con
        conOlEDB.Open()

    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        Dim feesPaid As Integer
        If txtFeesPaid.Text <> "" And Integer.TryParse(txtFeesPaid.Text, feesPaid) Then

            Dim TotalFees, change As Integer
            Dim treatmentDate As Date

            'Assign value to services,medicine and patient ID
            Dim sqlSearchID = "SELECT * FROM [Treatment] WHERE [Treatment_ID] = @TreatmentID "
            Dim cmdSearchID As New OleDbCommand(sqlSearchID, conOlEDB)
            cmdSearchID.Parameters.AddWithValue("@TreatmentID", TreatmentID)
            Dim dr As OleDbDataReader = cmdSearchID.ExecuteReader()

            If dr.Read() = True Then
                'Assign the value stored in the database to the declared variables
                Services = dr("Treatment")
                Medicine = dr("Medicine")
                PatientID = dr("Patient_ID")
                TotalFees = dr("TotalFees")
                treatmentDate = dr("Treatment_Date")


            End If
            'Search for patient name after finding patient ID
            Dim sqlSearchName = "SELECT * FROM [Patient] WHERE [PatientID] = @PatientID"
            Dim cmdSearchName As New OleDbCommand(sqlSearchName, conOlEDB)
            cmdSearchName.Parameters.AddWithValue("@PatientID", PatientID)
            Dim namedr As OleDbDataReader = cmdSearchName.ExecuteReader()
            If namedr.Read() = True Then
                PatientName = namedr("PatientName")
            End If
            'Display receipt if fees paid is sufficient
            If feesPaid > TotalFees Or feesPaid = TotalFees Then
                change = feesPaid - TotalFees
                lblChange.Text = change.ToString
                lstBill.Items.Add("Oceana Clinic")
                lstBill.Items.Add(vbTab)
                lstBill.Items.Add("TreatmentID: " & TreatmentID.ToString & vbTab & "Treatment Date: " & treatmentDate.ToString)
                lstBill.Items.Add(vbTab)
                lstBill.Items.Add("Patient Info")
                lstBill.Items.Add("Patient ID: " & PatientID.ToString)
                lstBill.Items.Add("Patient Name: " & PatientName)
                lstBill.Items.Add(vbTab)
                lstBill.Items.Add("Treatment Details")
                lstBill.Items.Add("Treatment undergone: " & vbVerticalTab & Services)
                lstBill.Items.Add("Medicine prescribed: " & Medicine)
                lstBill.Items.Add(vbTab)
                lstBill.Items.Add("Payment Details")
                lstBill.Items.Add("Total Treatment Fees: RM" & TotalFees.ToString)
                lstBill.Items.Add("Total Paid RM: " & feesPaid.ToString)
                lstBill.Items.Add("Change RM: " & change.ToString)

                MsgBox("Succesfully Complete payment!")
                btnSave.Visible = True
            Else
                MsgBox("Insufficient payment.Unable to generate bill.")

            End If


        Else
            MsgBox("Invalid payment.")
        End If

    End Sub
End Class