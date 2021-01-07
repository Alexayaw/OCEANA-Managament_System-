<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor_Main_Screen
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnViewAllPatient = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.btnHome = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddTreatment = New System.Windows.Forms.Button()
        Me.btnRerievePatientRecord = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnViewAllPatient)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAddTreatment)
        Me.Panel1.Controls.Add(Me.btnRerievePatientRecord)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 924)
        Me.Panel1.TabIndex = 12
        '
        'btnViewAllPatient
        '
        Me.btnViewAllPatient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnViewAllPatient.FlatAppearance.BorderSize = 0
        Me.btnViewAllPatient.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnViewAllPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAllPatient.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAllPatient.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnViewAllPatient.Location = New System.Drawing.Point(-2, 445)
        Me.btnViewAllPatient.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnViewAllPatient.Name = "btnViewAllPatient"
        Me.btnViewAllPatient.Size = New System.Drawing.Size(334, 105)
        Me.btnViewAllPatient.TabIndex = 9
        Me.btnViewAllPatient.Text = "View All Patient"
        Me.btnViewAllPatient.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Image = Global.OCEANA_Managament_System_.My.Resources.Resources.math_add_icon
        Me.btnAdd.Location = New System.Drawing.Point(158, 340)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 59)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.TabStop = False
        '
        'btnHome
        '
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.Image = Global.OCEANA_Managament_System_.My.Resources.Resources.home_icon
        Me.btnHome.Location = New System.Drawing.Point(80, 340)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(54, 58)
        Me.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHome.TabIndex = 7
        Me.btnHome.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnLogout.Location = New System.Drawing.Point(0, 749)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(334, 106)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label1.Location = New System.Drawing.Point(25, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome back, Doctor!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddTreatment
        '
        Me.btnAddTreatment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAddTreatment.FlatAppearance.BorderSize = 0
        Me.btnAddTreatment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAddTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTreatment.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTreatment.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnAddTreatment.Location = New System.Drawing.Point(-2, 646)
        Me.btnAddTreatment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddTreatment.Name = "btnAddTreatment"
        Me.btnAddTreatment.Size = New System.Drawing.Size(334, 105)
        Me.btnAddTreatment.TabIndex = 2
        Me.btnAddTreatment.Text = "Add new treatment"
        Me.btnAddTreatment.UseVisualStyleBackColor = False
        '
        'btnRerievePatientRecord
        '
        Me.btnRerievePatientRecord.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnRerievePatientRecord.FlatAppearance.BorderSize = 0
        Me.btnRerievePatientRecord.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnRerievePatientRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRerievePatientRecord.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRerievePatientRecord.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnRerievePatientRecord.Location = New System.Drawing.Point(-2, 542)
        Me.btnRerievePatientRecord.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRerievePatientRecord.Name = "btnRerievePatientRecord"
        Me.btnRerievePatientRecord.Size = New System.Drawing.Size(334, 109)
        Me.btnRerievePatientRecord.TabIndex = 1
        Me.btnRerievePatientRecord.Text = "Retrieve patient record"
        Me.btnRerievePatientRecord.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OCEANA_Managament_System_.My.Resources.Resources.People_Doctor_Male_icon__2_
        Me.PictureBox1.Location = New System.Drawing.Point(71, 128)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Doctor_Main_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OCEANA_Managament_System_.My.Resources.Resources.Untitled_picture
        Me.ClientSize = New System.Drawing.Size(1539, 924)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "Doctor_Main_Screen"
        Me.Text = "Doctor_Main_Screen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As PictureBox
    Friend WithEvents btnHome As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddTreatment As Button
    Friend WithEvents btnRerievePatientRecord As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnViewAllPatient As Button
End Class
