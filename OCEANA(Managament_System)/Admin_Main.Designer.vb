<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Main
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
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.btnHome = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.btnViewProfile = New System.Windows.Forms.Button()
        Me.btnAddNewProfile = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnResetPassword)
        Me.Panel1.Controls.Add(Me.btnViewProfile)
        Me.Panel1.Controls.Add(Me.btnAddNewProfile)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 1055)
        Me.Panel1.TabIndex = 13
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Image = Global.OCEANA_Managament_System_.My.Resources.Resources.math_add_icon
        Me.btnAdd.Location = New System.Drawing.Point(121, 231)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(45, 45)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.TabStop = False
        '
        'btnHome
        '
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.Image = Global.OCEANA_Managament_System_.My.Resources.Resources.home_icon
        Me.btnHome.Location = New System.Drawing.Point(51, 231)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(42, 44)
        Me.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHome.TabIndex = 9
        Me.btnHome.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(-2, 527)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(284, 75)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome back, Admin!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnResetPassword
        '
        Me.btnResetPassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnResetPassword.FlatAppearance.BorderSize = 0
        Me.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetPassword.Location = New System.Drawing.Point(-2, 462)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(284, 75)
        Me.btnResetPassword.TabIndex = 3
        Me.btnResetPassword.Text = "Reset User Password"
        Me.btnResetPassword.UseVisualStyleBackColor = False
        '
        'btnViewProfile
        '
        Me.btnViewProfile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnViewProfile.FlatAppearance.BorderSize = 0
        Me.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewProfile.Location = New System.Drawing.Point(-2, 400)
        Me.btnViewProfile.Name = "btnViewProfile"
        Me.btnViewProfile.Size = New System.Drawing.Size(284, 75)
        Me.btnViewProfile.TabIndex = 2
        Me.btnViewProfile.Text = "View Profile"
        Me.btnViewProfile.UseVisualStyleBackColor = False
        '
        'btnAddNewProfile
        '
        Me.btnAddNewProfile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAddNewProfile.FlatAppearance.BorderSize = 0
        Me.btnAddNewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewProfile.Location = New System.Drawing.Point(0, 334)
        Me.btnAddNewProfile.Name = "btnAddNewProfile"
        Me.btnAddNewProfile.Size = New System.Drawing.Size(284, 75)
        Me.btnAddNewProfile.TabIndex = 1
        Me.btnAddNewProfile.Text = "Add new profile"
        Me.btnAddNewProfile.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OCEANA_Managament_System_.My.Resources.Resources.Admin_icon
        Me.PictureBox1.Location = New System.Drawing.Point(51, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Admin_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.OCEANA_Managament_System_.My.Resources.Resources.Untitled_picture
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "Admin_Main"
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
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents btnViewProfile As Button
    Friend WithEvents btnAddNewProfile As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
