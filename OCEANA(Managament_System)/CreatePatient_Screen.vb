Imports System.Data.OleDb
Public Class CreatePatient_Screen
    Dim conOlEDB As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=OceanaClinic.accdb;"
    Dim a, b, c As Boolean
    Private Sub CreatePatient_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conOlEDB.ConnectionString = con
        conOlEDB.Open()

        'Increment Patient ID 
        Dim i As Integer
        Dim Maxrow = getcount()
        i = Maxrow + 1
        lblPatientID.Text = CStr(i)

    End Sub
    Function getcount() As Integer

        'Open the connection string if not open
        If Not conOlEDB.State = ConnectionState.Open Then
            conOlEDB.Open()
        End If

        Dim sqlCountRow = "Select MAX(PatientID) FROM Patient"
        Dim cmd As New OleDbCommand(sqlCountRow, conOlEDB)
        Return cmd.ExecuteScalar

    End Function



    Private Sub btnSubmit1_Click(sender As Object, e As EventArgs) Handles btnSubmit1.Click

        Dim patientID = CInt(lblPatientID.Text)

        Dim patientName = txtName.Text
        Dim gender = cmbGender.Text
        Dim IC_PASS = txtIC.Text
        Dim DOB = dateDOB.Text
        Dim mobileNo = txtMobileNo.Text
        Dim email = txtEmail.Text
        Dim unit_street = txtUnitStreet.Text
        Dim state = txtState.Text
        Dim zipCode = txtZipCode.Text
        Dim country = txtCountry.Text
        Dim weight = txtWeight.Text
        Dim height = txtHeight.Text
        Dim bloodType = cmbBlood.Text
        Dim allergies = txtAllergies.Text
        'Got problem with this cmdPersonal, date format problem [solved using date time picker]
        'cmdPersonal 
        Dim sqlPersonalDetails = "UPDATE [Patient] SET [PatientName] =@Name , [gender] =@gender , [IC/Passport] =@IC_PASS , [Mobile_no] =@mobileNo , [Email]= @email, [DOB] =@dob WHERE [PatientID] =@patientID "
        Dim cmdPersonal As New OleDbCommand(sqlPersonalDetails, conOlEDB)
        cmdPersonal.Parameters.AddWithValue("@Name", patientName)
        cmdPersonal.Parameters.AddWithValue("@gender", gender)
        cmdPersonal.Parameters.AddWithValue("@IC_PASS", IC_PASS)
        cmdPersonal.Parameters.AddWithValue("@mobileNo", mobileNo)
        cmdPersonal.Parameters.AddWithValue("@email", email)
        cmdPersonal.Parameters.AddWithValue("@dob", DOB)
        cmdPersonal.Parameters.AddWithValue("@patientID", patientID)
        'cmdAddress
        Dim sqlAddress = "UPDATE [Patient] SET [Unit_Street] = @unit_street, [ZipCode] = @zipCode, [State]=@state, [Country] = @country WHERE [PatientID] =@patientID "
        Dim cmdAddress As New OleDbCommand(sqlAddress, conOlEDB)
        cmdAddress.Parameters.AddWithValue("@unit_street", unit_street)
        cmdAddress.Parameters.AddWithValue("@zipCode", zipCode)
        cmdAddress.Parameters.AddWithValue("@state", state)
        cmdAddress.Parameters.AddWithValue("@country", country)
        cmdAddress.Parameters.AddWithValue("@patientID", patientID)
        'cmdHealth
        Dim sqlHealth = "UPDATE [Patient] SET [weight]=@weight, [height]=@height, [bloodtype]=@bloodType, [allergies] =@allergies WHERE [PatientID]=@patientID "
        Dim cmdHealth As New OleDbCommand(sqlHealth, conOlEDB)
        cmdHealth.Parameters.AddWithValue("@weight", weight)
        cmdHealth.Parameters.AddWithValue("@height", height)
        cmdHealth.Parameters.AddWithValue("@bloodType", bloodType)
        cmdHealth.Parameters.AddWithValue("@allergies", allergies)
        cmdHealth.Parameters.AddWithValue("@patientID", patientID)
        'cmdInsertID
        Dim sqlInsertID = "INSERT INTO [Patient] (PatientID) VALUES (@patientID) "
        Dim cmdInsertID As New OleDbCommand(sqlInsertID, conOlEDB)
        cmdInsertID.Parameters.AddWithValue("@patientID", patientID)

        'Personal Details
        If patientName <> "" And gender <> "" And IC_PASS <> "" And Not (DOB = "  /  /") And mobileNo <> "" And email <> "" Then
            a = True
        Else
            MessageBox.Show("Incomplete personal details")
        End If

        'Insert Address
        If unit_street <> "" And state <> "" And zipCode <> "" And country <> "" Then
            b = True
        Else
            MsgBox("Incomplete address")
        End If

        'Insert Health Info 
        If weight <> "" And height <> "" And bloodType <> "" And allergies <> "" Then
            c = True
        Else
            MsgBox("Incomplete health information")
        End If

        'If all the conditions are validated , then insert all data into database. 
        If a = True And b = True And c = True Then
            cmdInsertID.ExecuteNonQuery() 'Insert Patient ID
            cmdPersonal.ExecuteNonQuery() 'Update Personal Details
            cmdAddress.ExecuteNonQuery() ' Update Address
            cmdHealth.ExecuteNonQuery() 'Update Health info 
            MsgBox("Succesfully created patient profilr for patient: " & patientName & vbNewLine & "Patient ID: " & patientID)


            'Increment Patient ID 
            Dim i As Integer
            Dim Maxrow = getcount()
            i = Maxrow + 1
            lblPatientID.Text = CStr(i)

            'Clear all textbox
            txtName.Clear()
            txtIC.Clear()
            txtMobileNo.Clear()
            cmbGender.ResetText()
            dateDOB.ResetText()
            txtEmail.Clear()
            txtUnitStreet.Clear()
            txtState.Clear()
            txtZipCode.Clear()
            txtCountry.Clear()
            txtWeight.Clear()
            txtHeight.Clear()
            txtAllergies.Clear()
            cmbBlood.ResetText()


        End If
    End Sub
    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        'Clear all textbox
        txtName.Clear()
        txtIC.Clear()
        txtMobileNo.Clear()
        cmbGender.ResetText()
        dateDOB.ResetText()
        txtEmail.Clear()
        txtUnitStreet.Clear()
        txtState.Clear()
        txtZipCode.Clear()
        txtCountry.Clear()
        txtWeight.Clear()
        txtHeight.Clear()
        txtAllergies.Clear()
        cmbBlood.ResetText()
    End Sub

    Private Sub txtWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeight.KeyPress
        'prevent user from entering alphabet 

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class