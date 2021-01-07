Imports System.Data.OleDb
Public Class Edit_Screen
    Dim conOLEDB As New OleDbConnection
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=OceanaClinic.accdb;"


    Private Sub Edit_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conOLEDB.ConnectionString = con
        conOLEDB.Open()

    End Sub



    Private Sub btnSearchID_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click

        txtPatientIC.Clear()

        Dim PatientID As Integer
        Dim PatientIC, PatientName, MobileNo, gender, email, unit_street, zipcode, state, country, weight, height, blood, allergies As String
        Dim DOB As Date

        If txtPatientID.Text <> "" And Integer.TryParse(txtPatientID.Text, PatientID) Then
            PatientID = CInt(txtPatientID.Text)
            Dim sqlSearchID = "SELECT * FROM [Patient] WHERE [PatientID] = @PatientID "
            Dim cmdSearchID As New OleDbCommand(sqlSearchID, conOLEDB)
            cmdSearchID.Parameters.AddWithValue("@PatientID", PatientID)
            Dim IDdr As OleDbDataReader = cmdSearchID.ExecuteReader()
            If IDdr.Read() = True Then

                PatientIC = IDdr("IC/Passport")
                PatientName = IDdr("PatientName")
                MobileNo = IDdr("Mobile_no")
                gender = IDdr("gender")
                DOB = IDdr("DOB")
                email = IDdr("Email")
                unit_street = IDdr("Unit_Street")
                zipcode = IDdr("ZipCode")
                state = IDdr("State")
                country = IDdr("Country")
                weight = IDdr("weight")
                height = IDdr("height")
                blood = IDdr("bloodtype")
                allergies = IDdr("allergies")

                lblPatientID.Text = PatientID
                txtIC.Text = PatientIC
                txtName.Text = PatientName
                txtMobileNo.Text = MobileNo
                cboGender.Text = gender
                dateDOB.Text = DOB
                txtEmail.Text = email
                txtUnit_Street.Text = unit_street
                txtZip.Text = zipcode
                txtState.Text = state
                txtCountry.Text = country
                txtWeight.Text = weight
                txtHeight.Text = height
                cboBlood.Text = blood
                txtAllergies.Text = allergies

            Else
                MsgBox("Invalid Patient ID")

            End If

        Else
            MsgBox("Please Enter Valid Patient ID")

        End If
    End Sub

    Private Sub btnSearchIC_Click(sender As Object, e As EventArgs) Handles btnSearchIC.Click
        txtPatientID.Clear()
        Dim PatientIC = txtPatientIC.Text
        Dim PatientName, MobileNo, gender, email, unit_street, zipcode, state, country, weight, height, blood, allergies As String
        Dim PatientID As Integer
        Dim DOB As Date
        If PatientIC <> "" Then

            Dim sqlSearchIC = "SELECT * FROM [Patient] WHERE [IC/Passport] = @PatientIC "
            Dim cmdSearchIC As New OleDbCommand(sqlSearchIC, conOLEDB)
            cmdSearchIC.Parameters.AddWithValue("@PatientIC", PatientIC)
            Dim ICdr As OleDbDataReader = cmdSearchIC.ExecuteReader()
            If ICdr.Read() = True Then
                PatientID = ICdr("PatientID")
                PatientIC = ICdr("IC/Passport")
                PatientName = ICdr("PatientName")
                MobileNo = ICdr("Mobile_no")
                gender = ICdr("gender")
                DOB = ICdr("DOB")
                email = ICdr("Email")
                unit_street = ICdr("Unit_Street")
                zipcode = ICdr("ZipCode")
                state = ICdr("State")
                country = ICdr("Country")
                weight = ICdr("weight")
                height = ICdr("height")
                blood = ICdr("bloodtype")
                allergies = ICdr("allergies")



                lblPatientID.Text = PatientID
                txtIC.Text = PatientIC
                txtName.Text = PatientName
                txtMobileNo.Text = MobileNo
                cboGender.Text = gender
                dateDOB.Text = DOB
                txtEmail.Text = email
                txtUnit_Street.Text = unit_street
                txtZip.Text = zipcode
                txtState.Text = state
                txtCountry.Text = country
                txtWeight.Text = weight
                txtHeight.Text = height
                cboBlood.Text = blood
                txtAllergies.Text = allergies

            Else
                MsgBox("Invalid Patient IC")

            End If

        Else
            MsgBox("Please Enter Patient IC")

        End If
    End Sub



    'check if user turn on edit function 
    Private Sub chkEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chkEdit.CheckedChanged
        Dim alltextbox() = {txtName, txtAllergies, txtHeight, txtIC, txtWeight}
        Dim allmasktextbox() = {txtCountry, txtEmail, txtMobileNo, txtState, txtZip, txtUnit_Street}

        If chkEdit.Checked = True Then

            btnUpdate.Visible = True
            'btnDelete.Visible = True
            cboBlood.Enabled = True
            cboGender.Enabled = True
            dateDOB.Enabled = True

            'Make all the textbox editable 
            For Each textbox As TextBox In alltextbox
                textbox.ReadOnly = False
            Next
            For Each masktextbox As MaskedTextBox In allmasktextbox
                masktextbox.ReadOnly = False
            Next


        Else
            btnUpdate.Visible = False
            'btnDelete.Visible = False
            cboBlood.Enabled = False
            cboGender.Enabled = False
            dateDOB.Enabled = False
            For Each textbox As TextBox In alltextbox
                textbox.ReadOnly = True
            Next
            For Each masktextbox As MaskedTextBox In allmasktextbox
                masktextbox.ReadOnly = True
            Next

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim a, b, c As Boolean
        If lblPatientID.Text <> "" Then


            Dim patientID = CInt(lblPatientID.Text)
            Dim patientName = txtName.Text
            Dim gender = cboGender.Text
            Dim IC_PASS = txtIC.Text
            Dim DOB = dateDOB.Text
            Dim mobileNo = txtMobileNo.Text
            Dim email = txtEmail.Text
            Dim unit_street = txtUnit_Street.Text
            Dim state = txtState.Text
            Dim zipCode = txtZip.Text
            Dim country = txtCountry.Text
            Dim weight = txtWeight.Text
            Dim height = txtHeight.Text
            Dim bloodType = cboBlood.Text
            Dim allergies = txtAllergies.Text

            'Got problem with date format here [solved using datetimepicker]
            'cmdPersonal 
            Dim sqlPersonalDetails = "UPDATE [Patient] SET [PatientName] =@Name , [gender] =@gender , [IC/Passport] =@IC_PASS , [Mobile_no] =@mobileNo , [Email]= @email, [DOB] =@dob WHERE [PatientID] =@patientID "
            Dim cmdPersonal As New OleDbCommand(sqlPersonalDetails, conOLEDB)
            cmdPersonal.Parameters.AddWithValue("@Name", patientName)
            cmdPersonal.Parameters.AddWithValue("@gender", gender)
            cmdPersonal.Parameters.AddWithValue("@IC_PASS", IC_PASS)
            cmdPersonal.Parameters.AddWithValue("@mobileNo", mobileNo)
            cmdPersonal.Parameters.AddWithValue("@email", email)
            cmdPersonal.Parameters.AddWithValue("@dob", DOB)

            cmdPersonal.Parameters.AddWithValue("@patientID", patientID)
            'cmdAddress
            Dim sqlAddress = "UPDATE [Patient] SET [Unit_Street] = @unit_street, [ZipCode] = @zipCode, [State]=@state, [Country] = @country WHERE [PatientID] =@patientID "
            Dim cmdAddress As New OleDbCommand(sqlAddress, conOLEDB)
            cmdAddress.Parameters.AddWithValue("@unit_street", unit_street)
            cmdAddress.Parameters.AddWithValue("@zipCode", zipCode)
            cmdAddress.Parameters.AddWithValue("@state", state)
            cmdAddress.Parameters.AddWithValue("@country", country)
            cmdAddress.Parameters.AddWithValue("@patientID", patientID)
            'cmdHealth
            Dim sqlHealth = "UPDATE [Patient] SET [weight]=@weight, [height]=@height, [bloodtype]=@bloodType, [allergies] =@allergies WHERE [PatientID]=@patientID "
            Dim cmdHealth As New OleDbCommand(sqlHealth, conOLEDB)
            cmdHealth.Parameters.AddWithValue("@weight", weight)
            cmdHealth.Parameters.AddWithValue("@height", height)
            cmdHealth.Parameters.AddWithValue("@bloodType", bloodType)
            cmdHealth.Parameters.AddWithValue("@allergies", allergies)
            cmdHealth.Parameters.AddWithValue("@patientID", patientID)

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

                cmdPersonal.ExecuteNonQuery() 'Update Personal Details
                cmdAddress.ExecuteNonQuery() ' Update Address
                cmdHealth.ExecuteNonQuery() 'Update Health info 
                MsgBox("Succesfully updated patient profilr for patient: " & patientName & vbNewLine & "Patient ID: " & patientID)




            End If
        Else
            MsgBox("Please enter patient ID")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim alltextbox() = {txtName, txtAllergies, txtHeight, txtIC, txtWeight, txtPatientIC, txtPatientID}
        Dim allmasktextbox() = {txtZip, txtCountry, txtEmail, txtMobileNo, txtState, txtUnit_Street}
        cboBlood.ResetText()
        cboGender.ResetText()

        lblPatientID.Text = ""

        For Each textbox As TextBox In alltextbox
            textbox.Clear()
        Next
        For Each masktxtbox As MaskedTextBox In allmasktextbox
            masktxtbox.Clear()
        Next
    End Sub



    'Delete patient profile will resulting in treatment records being deleted 
    'Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    '    Dim sqlDelete = "DELETE * FROM [Patient] WHERE [PatientID]=@PatientID"
    '    Dim cmdDelete As New OleDbCommand(sqlDelete, conOLEDB)
    '    cmdDelete.Parameters.AddWithValue("PatientID", lblPatientID.Text)
    '    Dim result = MessageBox.Show("Are you sure you want to delete " & lblPatientID.Text & " from the system?" & vbNewLine & "Please note that this action is irreversible", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    '    If result = MsgBoxResult.Yes Then
    '        MsgBox("Patient ID: " & lblPatientID.Text & " has been succesfully deleted from the system.")
    '        cmdDelete.ExecuteNonQuery()

    '    End If
    'End Sub
End Class