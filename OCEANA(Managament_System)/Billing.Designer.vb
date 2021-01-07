<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
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
        Me.btnViewAllTreatment = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpboxTreatment = New System.Windows.Forms.GroupBox()
        Me.lblMedicine = New System.Windows.Forms.Label()
        Me.lblFees = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBill = New System.Windows.Forms.Button()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFeesPaid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSearchID = New System.Windows.Forms.Button()
        Me.txtTreatmentID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnViewAllBill = New System.Windows.Forms.Button()
        Me.grpboxTreatment.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnViewAllTreatment
        '
        Me.btnViewAllTreatment.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnViewAllTreatment.FlatAppearance.BorderSize = 0
        Me.btnViewAllTreatment.Font = New System.Drawing.Font("HP Simplified Light", 8.799999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAllTreatment.Location = New System.Drawing.Point(32, 74)
        Me.btnViewAllTreatment.Name = "btnViewAllTreatment"
        Me.btnViewAllTreatment.Size = New System.Drawing.Size(501, 42)
        Me.btnViewAllTreatment.TabIndex = 45
        Me.btnViewAllTreatment.Text = "View All Treatment Records"
        Me.btnViewAllTreatment.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblName.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(817, 84)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(146, 22)
        Me.lblName.TabIndex = 43
        '
        'lblPatientID
        '
        Me.lblPatientID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPatientID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPatientID.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.Location = New System.Drawing.Point(817, 41)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(146, 22)
        Me.lblPatientID.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(621, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 19)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Patient ID"
        '
        'lblServices
        '
        Me.lblServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServices.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblServices.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServices.Location = New System.Drawing.Point(344, 71)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(441, 134)
        Me.lblServices.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(45, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 19)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Services selected:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(621, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 19)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Patient Name"
        '
        'grpboxTreatment
        '
        Me.grpboxTreatment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grpboxTreatment.Controls.Add(Me.lblServices)
        Me.grpboxTreatment.Controls.Add(Me.Label12)
        Me.grpboxTreatment.Controls.Add(Me.lblMedicine)
        Me.grpboxTreatment.Controls.Add(Me.lblFees)
        Me.grpboxTreatment.Controls.Add(Me.Label1)
        Me.grpboxTreatment.Controls.Add(Me.Label4)
        Me.grpboxTreatment.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxTreatment.Location = New System.Drawing.Point(96, 248)
        Me.grpboxTreatment.Name = "grpboxTreatment"
        Me.grpboxTreatment.Size = New System.Drawing.Size(1147, 505)
        Me.grpboxTreatment.TabIndex = 40
        Me.grpboxTreatment.TabStop = False
        Me.grpboxTreatment.Text = "Treatment"
        '
        'lblMedicine
        '
        Me.lblMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblMedicine.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicine.Location = New System.Drawing.Point(344, 241)
        Me.lblMedicine.Name = "lblMedicine"
        Me.lblMedicine.Size = New System.Drawing.Size(374, 28)
        Me.lblMedicine.TabIndex = 8
        '
        'lblFees
        '
        Me.lblFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblFees.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFees.Location = New System.Drawing.Point(344, 337)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(112, 31)
        Me.lblFees.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type of medicine prescribed:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total Fees"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox3.Controls.Add(Me.btnBill)
        Me.GroupBox3.Controls.Add(Me.lblChange)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtFeesPaid)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(96, 754)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1147, 251)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bill Generator"
        '
        'btnBill
        '
        Me.btnBill.BackColor = System.Drawing.SystemColors.Control
        Me.btnBill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBill.FlatAppearance.BorderSize = 0
        Me.btnBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBill.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBill.Location = New System.Drawing.Point(434, 80)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(396, 76)
        Me.btnBill.TabIndex = 21
        Me.btnBill.Text = "Generate Bill"
        Me.btnBill.UseVisualStyleBackColor = False
        Me.btnBill.Visible = False
        '
        'lblChange
        '
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblChange.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(184, 123)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(112, 22)
        Me.lblChange.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(80, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Change"
        '
        'txtFeesPaid
        '
        Me.txtFeesPaid.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeesPaid.Location = New System.Drawing.Point(184, 79)
        Me.txtFeesPaid.Name = "txtFeesPaid"
        Me.txtFeesPaid.Size = New System.Drawing.Size(112, 27)
        Me.txtFeesPaid.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Fees Paid"
        '
        'btnSearchID
        '
        Me.btnSearchID.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearchID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchID.FlatAppearance.BorderSize = 0
        Me.btnSearchID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearchID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchID.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchID.Location = New System.Drawing.Point(398, 37)
        Me.btnSearchID.Name = "btnSearchID"
        Me.btnSearchID.Size = New System.Drawing.Size(135, 31)
        Me.btnSearchID.TabIndex = 38
        Me.btnSearchID.Text = "Search"
        Me.btnSearchID.UseVisualStyleBackColor = False
        '
        'txtTreatmentID
        '
        Me.txtTreatmentID.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTreatmentID.Location = New System.Drawing.Point(184, 37)
        Me.txtTreatmentID.Name = "txtTreatmentID"
        Me.txtTreatmentID.Size = New System.Drawing.Size(180, 27)
        Me.txtTreatmentID.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Treatment ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1289, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 24)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Bill"
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1404, 974)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 31)
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(1293, 974)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(96, 31)
        Me.btnReset.TabIndex = 33
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lstBill
        '
        Me.lstBill.BackColor = System.Drawing.Color.White
        Me.lstBill.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.ItemHeight = 24
        Me.lstBill.Location = New System.Drawing.Point(1276, 287)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(695, 652)
        Me.lstBill.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnViewAllTreatment)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblPatientID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnSearchID)
        Me.GroupBox1.Controls.Add(Me.txtTreatmentID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1147, 132)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'btnViewAllBill
        '
        Me.btnViewAllBill.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnViewAllBill.FlatAppearance.BorderSize = 0
        Me.btnViewAllBill.Font = New System.Drawing.Font("HP Simplified Light", 8.799999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAllBill.Location = New System.Drawing.Point(1360, 249)
        Me.btnViewAllBill.Name = "btnViewAllBill"
        Me.btnViewAllBill.Size = New System.Drawing.Size(423, 32)
        Me.btnViewAllBill.TabIndex = 46
        Me.btnViewAllBill.Text = "View All Bill" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnViewAllBill.UseVisualStyleBackColor = False
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1924, 1084)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnViewAllBill)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpboxTreatment)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lstBill)
        Me.Name = "Billing"
        Me.grpboxTreatment.ResumeLayout(False)
        Me.grpboxTreatment.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewAllTreatment As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblPatientID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblServices As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents grpboxTreatment As GroupBox
    Friend WithEvents lblMedicine As Label
    Friend WithEvents lblFees As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnBill As Button
    Friend WithEvents lblChange As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFeesPaid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSearchID As Button
    Friend WithEvents txtTreatmentID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lstBill As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnViewAllBill As Button
End Class
