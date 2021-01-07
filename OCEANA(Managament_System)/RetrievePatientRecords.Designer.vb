<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetrievePatientRecords
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
        Me.dgvTreatment = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtBlood = New System.Windows.Forms.TextBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpHealth = New System.Windows.Forms.GroupBox()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAllergies = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSearchName = New System.Windows.Forms.Button()
        Me.btnSearchID = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.grpHealth.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTreatment
        '
        Me.dgvTreatment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTreatment.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTreatment.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvTreatment.Location = New System.Drawing.Point(38, 51)
        Me.dgvTreatment.Name = "dgvTreatment"
        Me.dgvTreatment.ReadOnly = True
        Me.dgvTreatment.RowHeadersWidth = 51
        Me.dgvTreatment.RowTemplate.Height = 24
        Me.dgvTreatment.Size = New System.Drawing.Size(1381, 335)
        Me.dgvTreatment.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox3.Controls.Add(Me.dgvTreatment)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(181, 486)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(1459, 426)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Treatment Records"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(884, 30)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 33)
        Me.btnClear.TabIndex = 29
        Me.btnClear.Text = "Clear" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtBlood
        '
        Me.txtBlood.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBlood.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlood.Location = New System.Drawing.Point(940, 101)
        Me.txtBlood.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBlood.Name = "txtBlood"
        Me.txtBlood.ReadOnly = True
        Me.txtBlood.Size = New System.Drawing.Size(162, 27)
        Me.txtBlood.TabIndex = 23
        '
        'txtPatientID
        '
        Me.txtPatientID.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPatientID.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(587, 38)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(100, 27)
        Me.txtPatientID.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = " ID"
        '
        'grpHealth
        '
        Me.grpHealth.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grpHealth.Controls.Add(Me.txtBlood)
        Me.grpHealth.Controls.Add(Me.txtPatientID)
        Me.grpHealth.Controls.Add(Me.Label4)
        Me.grpHealth.Controls.Add(Me.txtPatientName)
        Me.grpHealth.Controls.Add(Me.Label3)
        Me.grpHealth.Controls.Add(Me.txtAllergies)
        Me.grpHealth.Controls.Add(Me.Label6)
        Me.grpHealth.Controls.Add(Me.txtHeight)
        Me.grpHealth.Controls.Add(Me.txtWeight)
        Me.grpHealth.Controls.Add(Me.Label7)
        Me.grpHealth.Controls.Add(Me.Label8)
        Me.grpHealth.Controls.Add(Me.Label9)
        Me.grpHealth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpHealth.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHealth.Location = New System.Drawing.Point(181, 229)
        Me.grpHealth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpHealth.Name = "grpHealth"
        Me.grpHealth.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpHealth.Size = New System.Drawing.Size(1459, 265)
        Me.grpHealth.TabIndex = 30
        Me.grpHealth.TabStop = False
        Me.grpHealth.Text = "Health Information"
        '
        'txtPatientName
        '
        Me.txtPatientName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPatientName.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(205, 38)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.ReadOnly = True
        Me.txtPatientName.Size = New System.Drawing.Size(162, 27)
        Me.txtPatientName.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Name"
        '
        'txtAllergies
        '
        Me.txtAllergies.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAllergies.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllergies.Location = New System.Drawing.Point(205, 151)
        Me.txtAllergies.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAllergies.Multiline = True
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.ReadOnly = True
        Me.txtAllergies.Size = New System.Drawing.Size(389, 84)
        Me.txtAllergies.TabIndex = 19
        Me.txtAllergies.Text = "None"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Allergies:"
        '
        'txtHeight
        '
        Me.txtHeight.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtHeight.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(587, 98)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = True
        Me.txtHeight.Size = New System.Drawing.Size(162, 27)
        Me.txtHeight.TabIndex = 17
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtWeight.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(205, 94)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(162, 27)
        Me.txtWeight.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(822, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Blood Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(425, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Height:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Weight:"
        '
        'btnSearchName
        '
        Me.btnSearchName.Location = New System.Drawing.Point(684, 30)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(102, 31)
        Me.btnSearchName.TabIndex = 5
        Me.btnSearchName.Text = "Search"
        Me.btnSearchName.UseVisualStyleBackColor = True
        '
        'btnSearchID
        '
        Me.btnSearchID.Location = New System.Drawing.Point(255, 27)
        Me.btnSearchID.Name = "btnSearchID"
        Me.btnSearchID.Size = New System.Drawing.Size(102, 31)
        Me.btnSearchID.TabIndex = 4
        Me.btnSearchID.Text = "Search"
        Me.btnSearchID.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(568, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 31)
        Me.txtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(417, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(140, 27)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 31)
        Me.txtID.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchName)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnSearchID)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(191, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1289, 74)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " ID"
        '
        'RetrievePatientRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpHealth)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RetrievePatientRecords"
        CType(Me.dgvTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.grpHealth.ResumeLayout(False)
        Me.grpHealth.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTreatment As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtBlood As TextBox
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents grpHealth As GroupBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAllergies As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSearchName As Button
    Friend WithEvents btnSearchID As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
End Class
