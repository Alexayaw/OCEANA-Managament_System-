<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboBlood = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dateDOB = New System.Windows.Forms.DateTimePicker()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMobileNo = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAllergies = New System.Windows.Forms.TextBox()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.chkEdit = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearchIC = New System.Windows.Forms.Button()
        Me.btnSearchID = New System.Windows.Forms.Button()
        Me.txtPatientIC = New System.Windows.Forms.TextBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCountry = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUnit_Street = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboBlood
        '
        Me.cboBlood.Enabled = False
        Me.cboBlood.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBlood.FormattingEnabled = True
        Me.cboBlood.Items.AddRange(New Object() {"O", "A", "B", "AB"})
        Me.cboBlood.Location = New System.Drawing.Point(182, 116)
        Me.cboBlood.Name = "cboBlood"
        Me.cboBlood.Size = New System.Drawing.Size(144, 29)
        Me.cboBlood.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.dateDOB)
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtIC)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtMobileNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(333, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1335, 208)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Details"
        '
        'dateDOB
        '
        Me.dateDOB.Enabled = False
        Me.dateDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDOB.Location = New System.Drawing.Point(829, 109)
        Me.dateDOB.Name = "dateDOB"
        Me.dateDOB.Size = New System.Drawing.Size(200, 28)
        Me.dateDOB.TabIndex = 49
        '
        'cboGender
        '
        Me.cboGender.Enabled = False
        Me.cboGender.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(829, 56)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(121, 29)
        Me.cboGender.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(685, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 22)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Gender"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(685, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 22)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Birth Date"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(829, 149)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(292, 28)
        Me.txtEmail.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(685, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Email:"
        '
        'txtIC
        '
        Me.txtIC.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIC.Location = New System.Drawing.Point(292, 103)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.ReadOnly = True
        Me.txtIC.Size = New System.Drawing.Size(292, 28)
        Me.txtIC.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(292, 58)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(292, 28)
        Me.txtName.TabIndex = 4
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.Location = New System.Drawing.Point(292, 149)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.ReadOnly = True
        Me.txtMobileNo.Size = New System.Drawing.Size(292, 28)
        Me.txtMobileNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mobile No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IC/Passport Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'txtAllergies
        '
        Me.txtAllergies.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllergies.Location = New System.Drawing.Point(182, 180)
        Me.txtAllergies.Multiline = True
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.ReadOnly = True
        Me.txtAllergies.Size = New System.Drawing.Size(346, 65)
        Me.txtAllergies.TabIndex = 19
        '
        'lblPatientID
        '
        Me.lblPatientID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPatientID.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.Location = New System.Drawing.Point(367, 158)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(122, 25)
        Me.lblPatientID.TabIndex = 57
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(227, 158)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 22)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = " Patient ID"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnClear.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(337, 989)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(263, 38)
        Me.btnClear.TabIndex = 59
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 22)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Allergies:"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnUpdate.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(1401, 989)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(263, 38)
        Me.btnUpdate.TabIndex = 51
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        Me.btnUpdate.Visible = False
        '
        'chkEdit
        '
        Me.chkEdit.AutoSize = True
        Me.chkEdit.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEdit.Location = New System.Drawing.Point(1190, 21)
        Me.chkEdit.Name = "chkEdit"
        Me.chkEdit.Size = New System.Drawing.Size(118, 26)
        Me.chkEdit.TabIndex = 34
        Me.chkEdit.Text = "Enable Edit"
        Me.chkEdit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearchIC)
        Me.Panel1.Controls.Add(Me.btnSearchID)
        Me.Panel1.Controls.Add(Me.txtPatientIC)
        Me.Panel1.Controls.Add(Me.txtPatientID)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.chkEdit)
        Me.Panel1.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(211, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1453, 59)
        Me.Panel1.TabIndex = 55
        '
        'btnSearchIC
        '
        Me.btnSearchIC.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchIC.Location = New System.Drawing.Point(960, 17)
        Me.btnSearchIC.Name = "btnSearchIC"
        Me.btnSearchIC.Size = New System.Drawing.Size(103, 33)
        Me.btnSearchIC.TabIndex = 46
        Me.btnSearchIC.Text = "Search"
        Me.btnSearchIC.UseVisualStyleBackColor = True
        '
        'btnSearchID
        '
        Me.btnSearchID.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchID.Location = New System.Drawing.Point(381, 17)
        Me.btnSearchID.Name = "btnSearchID"
        Me.btnSearchID.Size = New System.Drawing.Size(108, 30)
        Me.btnSearchID.TabIndex = 42
        Me.btnSearchID.Text = "Search"
        Me.btnSearchID.UseVisualStyleBackColor = True
        '
        'txtPatientIC
        '
        Me.txtPatientIC.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientIC.Location = New System.Drawing.Point(788, 20)
        Me.txtPatientIC.Name = "txtPatientIC"
        Me.txtPatientIC.Size = New System.Drawing.Size(144, 28)
        Me.txtPatientIC.TabIndex = 45
        '
        'txtPatientID
        '
        Me.txtPatientID.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(203, 19)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(163, 28)
        Me.txtPatientID.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(521, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(181, 22)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Patient IC/PassportNo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(27, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 22)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = " Patient ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox3.Controls.Add(Me.txtCountry)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtState)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtZip)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtUnit_Street)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(330, 437)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1334, 195)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Address"
        '
        'txtCountry
        '
        Me.txtCountry.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(800, 109)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.ReadOnly = True
        Me.txtCountry.Size = New System.Drawing.Size(292, 28)
        Me.txtCountry.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(688, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 22)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Country"
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(800, 59)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(292, 28)
        Me.txtState.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(688, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 22)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "State"
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(295, 109)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New System.Drawing.Size(292, 28)
        Me.txtZip.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 22)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Zip Code"
        '
        'txtUnit_Street
        '
        Me.txtUnit_Street.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit_Street.Location = New System.Drawing.Point(295, 59)
        Me.txtUnit_Street.Name = "txtUnit_Street"
        Me.txtUnit_Street.ReadOnly = True
        Me.txtUnit_Street.Size = New System.Drawing.Size(292, 28)
        Me.txtUnit_Street.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Address (Unit,Street)"
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(522, 60)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = True
        Me.txtHeight.Size = New System.Drawing.Size(144, 28)
        Me.txtHeight.TabIndex = 17
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(182, 57)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(144, 28)
        Me.txtWeight.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Blood Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(378, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 22)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Height:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 22)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Weight:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.cboBlood)
        Me.GroupBox2.Controls.Add(Me.txtAllergies)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtHeight)
        Me.GroupBox2.Controls.Add(Me.txtWeight)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(330, 649)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1338, 293)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Health Information"
        '
        'Edit_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1084)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPatientID)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Edit_Screen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboBlood As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dateDOB As DateTimePicker
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEmail As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIC As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtMobileNo As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAllergies As TextBox
    Friend WithEvents lblPatientID As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents chkEdit As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearchIC As Button
    Friend WithEvents btnSearchID As Button
    Friend WithEvents txtPatientIC As TextBox
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCountry As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtState As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtZip As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtUnit_Street As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
