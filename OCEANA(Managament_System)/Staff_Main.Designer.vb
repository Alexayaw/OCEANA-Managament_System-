<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Main
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
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.btnBilling = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.btnHome = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewPatientProfile = New System.Windows.Forms.Button()
        Me.btnAddPatientProfile = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnViewAll)
        Me.Panel1.Controls.Add(Me.btnBilling)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnViewPatientProfile)
        Me.Panel1.Controls.Add(Me.btnAddPatientProfile)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 1055)
        Me.Panel1.TabIndex = 13
        '
        'btnViewAll
        '
        Me.btnViewAll.AutoSize = True
        Me.btnViewAll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnViewAll.FlatAppearance.BorderSize = 0
        Me.btnViewAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAll.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewAll.Location = New System.Drawing.Point(-13, 581)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(286, 72)
        Me.btnViewAll.TabIndex = 11
        Me.btnViewAll.Text = "View All Patient Profile"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'btnBilling
        '
        Me.btnBilling.AutoSize = True
        Me.btnBilling.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnBilling.FlatAppearance.BorderSize = 0
        Me.btnBilling.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBilling.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBilling.Location = New System.Drawing.Point(-3, 653)
        Me.btnBilling.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(273, 72)
        Me.btnBilling.TabIndex = 10
        Me.btnBilling.Text = "Billing"
        Me.btnBilling.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.OCEANA_Managament_System_.My.Resources.Resources.medical_nurse_female_icon_14__2_
        Me.PictureBox1.Location = New System.Drawing.Point(42, 87)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Image = Global.OCEANA_Managament_System_.My.Resources.Resources.math_add_icon
        Me.btnAdd.Location = New System.Drawing.Point(132, 272)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(55, 53)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.TabStop = False
        '
        'btnHome
        '
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.Image = Global.OCEANA_Managament_System_.My.Resources.Resources.home_icon
        Me.btnHome.Location = New System.Drawing.Point(62, 272)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(52, 52)
        Me.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHome.TabIndex = 7
        Me.btnHome.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.AutoSize = True
        Me.btnLogout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(-3, 725)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(273, 72)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 44)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome back, Nurse!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnViewPatientProfile
        '
        Me.btnViewPatientProfile.AutoSize = True
        Me.btnViewPatientProfile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnViewPatientProfile.FlatAppearance.BorderSize = 0
        Me.btnViewPatientProfile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnViewPatientProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPatientProfile.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPatientProfile.Location = New System.Drawing.Point(-3, 509)
        Me.btnViewPatientProfile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnViewPatientProfile.Name = "btnViewPatientProfile"
        Me.btnViewPatientProfile.Size = New System.Drawing.Size(273, 72)
        Me.btnViewPatientProfile.TabIndex = 2
        Me.btnViewPatientProfile.Text = "Edit Patient Profile"
        Me.btnViewPatientProfile.UseVisualStyleBackColor = False
        '
        'btnAddPatientProfile
        '
        Me.btnAddPatientProfile.AutoSize = True
        Me.btnAddPatientProfile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAddPatientProfile.FlatAppearance.BorderSize = 0
        Me.btnAddPatientProfile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAddPatientProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPatientProfile.Font = New System.Drawing.Font("HP Simplified Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPatientProfile.Location = New System.Drawing.Point(-3, 437)
        Me.btnAddPatientProfile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddPatientProfile.Name = "btnAddPatientProfile"
        Me.btnAddPatientProfile.Size = New System.Drawing.Size(273, 72)
        Me.btnAddPatientProfile.TabIndex = 1
        Me.btnAddPatientProfile.Text = "Add patient profile"
        Me.btnAddPatientProfile.UseVisualStyleBackColor = False
        '
        'Staff_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OCEANA_Managament_System_.My.Resources.Resources.Untitled_picture
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "Staff_Main"
        Me.Text = "Staff_Main"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnViewAll As Button
    Friend WithEvents btnBilling As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAdd As PictureBox
    Friend WithEvents btnHome As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnViewPatientProfile As Button
    Friend WithEvents btnAddPatientProfile As Button
End Class
