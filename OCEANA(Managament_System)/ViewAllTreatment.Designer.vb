<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAllTreatment
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSearchName = New System.Windows.Forms.Button()
        Me.btnSearchID = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.lblPatientID = New System.Windows.Forms.Label()
        CType(Me.dgvTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTreatment
        '
        Me.dgvTreatment.AllowUserToAddRows = False
        Me.dgvTreatment.AllowUserToDeleteRows = False
        Me.dgvTreatment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTreatment.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTreatment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTreatment.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvTreatment.Location = New System.Drawing.Point(3, 24)
        Me.dgvTreatment.Name = "dgvTreatment"
        Me.dgvTreatment.ReadOnly = True
        Me.dgvTreatment.RowHeadersWidth = 51
        Me.dgvTreatment.RowTemplate.Height = 24
        Me.dgvTreatment.Size = New System.Drawing.Size(1991, 967)
        Me.dgvTreatment.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox3.Controls.Add(Me.dgvTreatment)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(53, 221)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(1997, 995)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Treatment Records"
        '
        'btnReset
        '
        Me.btnReset.AutoSize = True
        Me.btnReset.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(1110, 27)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 34)
        Me.btnReset.TabIndex = 38
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSearchName
        '
        Me.btnSearchName.Location = New System.Drawing.Point(704, 27)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(102, 31)
        Me.btnSearchName.TabIndex = 5
        Me.btnSearchName.Text = "Search"
        Me.btnSearchName.UseVisualStyleBackColor = True
        '
        'btnSearchID
        '
        Me.btnSearchID.Location = New System.Drawing.Point(274, 27)
        Me.btnSearchID.Name = "btnSearchID"
        Me.btnSearchID.Size = New System.Drawing.Size(102, 31)
        Me.btnSearchID.TabIndex = 4
        Me.btnSearchID.Text = "Search"
        Me.btnSearchID.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(588, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 31)
        Me.txtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(417, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PatientName"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(159, 27)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 31)
        Me.txtID.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchName)
        Me.GroupBox1.Controls.Add(Me.btnSearchID)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(102, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1283, 74)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " PatientID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("HP Simplified", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(394, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = " ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("HP Simplified", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Name"
        '
        'lblPatientName
        '
        Me.lblPatientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPatientName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPatientName.Font = New System.Drawing.Font("HP Simplified", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(224, 185)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(121, 27)
        Me.lblPatientName.TabIndex = 40
        '
        'lblPatientID
        '
        Me.lblPatientID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPatientID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPatientID.Font = New System.Drawing.Font("HP Simplified", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.Location = New System.Drawing.Point(469, 184)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(121, 27)
        Me.lblPatientID.TabIndex = 41
        '
        'ViewAllTreatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.lblPatientID)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "ViewAllTreatment"
        Me.Text = "ViewAllTreatment"
        CType(Me.dgvTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTreatment As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSearchName As Button
    Friend WithEvents btnSearchID As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPatientName As Label
    Friend WithEvents lblPatientID As Label
End Class
