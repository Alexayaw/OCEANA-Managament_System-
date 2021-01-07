<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Record_treatment_details
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dateTreat = New System.Windows.Forms.DateTimePicker()
        Me.lblTreatID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkMedE = New System.Windows.Forms.CheckBox()
        Me.chkMedD = New System.Windows.Forms.CheckBox()
        Me.ChkMedC = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkMedB = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkMedA = New System.Windows.Forms.CheckBox()
        Me.chkPartialCheck = New System.Windows.Forms.CheckBox()
        Me.chkFullcheck = New System.Windows.Forms.CheckBox()
        Me.chkXray = New System.Windows.Forms.CheckBox()
        Me.chkLab = New System.Windows.Forms.CheckBox()
        Me.chkConsult = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvTreatment = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(1377, 632)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(263, 41)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete previous record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dateTreat)
        Me.Panel1.Controls.Add(Me.lblTreatID)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtPatientID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(213, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1474, 51)
        Me.Panel1.TabIndex = 32
        '
        'dateTreat
        '
        Me.dateTreat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTreat.Location = New System.Drawing.Point(940, 17)
        Me.dateTreat.Name = "dateTreat"
        Me.dateTreat.Size = New System.Drawing.Size(200, 31)
        Me.dateTreat.TabIndex = 25
        '
        'lblTreatID
        '
        Me.lblTreatID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTreatID.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreatID.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblTreatID.Location = New System.Drawing.Point(168, 17)
        Me.lblTreatID.Name = "lblTreatID"
        Me.lblTreatID.Size = New System.Drawing.Size(162, 27)
        Me.lblTreatID.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(15, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Treatment ID:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(858, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Date"
        '
        'txtPatientID
        '
        Me.txtPatientID.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtPatientID.Location = New System.Drawing.Point(493, 17)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(162, 31)
        Me.txtPatientID.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(368, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Patient ID:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnSubmit.Location = New System.Drawing.Point(629, 127)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(226, 41)
        Me.btnSubmit.TabIndex = 31
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(392, 127)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(228, 41)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtComment
        '
        Me.txtComment.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtComment.Location = New System.Drawing.Point(21, 80)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(323, 118)
        Me.txtComment.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(17, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Comment:"
        '
        'chkMedE
        '
        Me.chkMedE.AutoSize = True
        Me.chkMedE.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMedE.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.chkMedE.Location = New System.Drawing.Point(37, 166)
        Me.chkMedE.Name = "chkMedE"
        Me.chkMedE.Size = New System.Drawing.Size(42, 28)
        Me.chkMedE.TabIndex = 10
        Me.chkMedE.Text = "E"
        Me.chkMedE.UseVisualStyleBackColor = True
        '
        'chkMedD
        '
        Me.chkMedD.AutoSize = True
        Me.chkMedD.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMedD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.chkMedD.Location = New System.Drawing.Point(37, 140)
        Me.chkMedD.Name = "chkMedD"
        Me.chkMedD.Size = New System.Drawing.Size(44, 28)
        Me.chkMedD.TabIndex = 9
        Me.chkMedD.Text = "D"
        Me.chkMedD.UseVisualStyleBackColor = True
        '
        'ChkMedC
        '
        Me.ChkMedC.AutoSize = True
        Me.ChkMedC.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMedC.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ChkMedC.Location = New System.Drawing.Point(37, 113)
        Me.ChkMedC.Name = "ChkMedC"
        Me.ChkMedC.Size = New System.Drawing.Size(42, 28)
        Me.ChkMedC.TabIndex = 8
        Me.ChkMedC.Text = "C"
        Me.ChkMedC.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox3.Controls.Add(Me.txtComment)
        Me.GroupBox3.Controls.Add(Me.btnSubmit)
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(1043, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(861, 285)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Additional treatment details"
        '
        'chkMedB
        '
        Me.chkMedB.AutoSize = True
        Me.chkMedB.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMedB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.chkMedB.Location = New System.Drawing.Point(37, 86)
        Me.chkMedB.Name = "chkMedB"
        Me.chkMedB.Size = New System.Drawing.Size(43, 28)
        Me.chkMedB.TabIndex = 7
        Me.chkMedB.Text = "B"
        Me.chkMedB.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.chkMedE)
        Me.GroupBox2.Controls.Add(Me.chkMedD)
        Me.GroupBox2.Controls.Add(Me.ChkMedC)
        Me.GroupBox2.Controls.Add(Me.chkMedB)
        Me.GroupBox2.Controls.Add(Me.chkMedA)
        Me.GroupBox2.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(687, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 285)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Medicine"
        '
        'chkMedA
        '
        Me.chkMedA.AutoSize = True
        Me.chkMedA.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMedA.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.chkMedA.Location = New System.Drawing.Point(36, 58)
        Me.chkMedA.Name = "chkMedA"
        Me.chkMedA.Size = New System.Drawing.Size(43, 28)
        Me.chkMedA.TabIndex = 6
        Me.chkMedA.Text = "A"
        Me.chkMedA.UseVisualStyleBackColor = True
        '
        'chkPartialCheck
        '
        Me.chkPartialCheck.AutoSize = True
        Me.chkPartialCheck.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPartialCheck.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.chkPartialCheck.Location = New System.Drawing.Point(42, 166)
        Me.chkPartialCheck.Name = "chkPartialCheck"
        Me.chkPartialCheck.Size = New System.Drawing.Size(193, 28)
        Me.chkPartialCheck.TabIndex = 5
        Me.chkPartialCheck.Text = "Partial Health Check"
        Me.chkPartialCheck.UseVisualStyleBackColor = True
        '
        'chkFullcheck
        '
        Me.chkFullcheck.AutoSize = True
        Me.chkFullcheck.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFullcheck.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.chkFullcheck.Location = New System.Drawing.Point(42, 140)
        Me.chkFullcheck.Name = "chkFullcheck"
        Me.chkFullcheck.Size = New System.Drawing.Size(262, 28)
        Me.chkFullcheck.TabIndex = 4
        Me.chkFullcheck.Text = "Comprehensive health check"
        Me.chkFullcheck.UseVisualStyleBackColor = True
        '
        'chkXray
        '
        Me.chkXray.AutoSize = True
        Me.chkXray.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkXray.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.chkXray.Location = New System.Drawing.Point(42, 113)
        Me.chkXray.Name = "chkXray"
        Me.chkXray.Size = New System.Drawing.Size(81, 28)
        Me.chkXray.TabIndex = 3
        Me.chkXray.Text = "X-Ray"
        Me.chkXray.UseVisualStyleBackColor = True
        '
        'chkLab
        '
        Me.chkLab.AutoSize = True
        Me.chkLab.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLab.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.chkLab.Location = New System.Drawing.Point(42, 86)
        Me.chkLab.Name = "chkLab"
        Me.chkLab.Size = New System.Drawing.Size(123, 28)
        Me.chkLab.TabIndex = 2
        Me.chkLab.Text = "Lab service"
        Me.chkLab.UseVisualStyleBackColor = True
        '
        'chkConsult
        '
        Me.chkConsult.AutoSize = True
        Me.chkConsult.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConsult.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.chkConsult.Location = New System.Drawing.Point(41, 58)
        Me.chkConsult.Name = "chkConsult"
        Me.chkConsult.Size = New System.Drawing.Size(197, 28)
        Me.chkConsult.TabIndex = 1
        Me.chkConsult.Text = "General consultation"
        Me.chkConsult.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.chkPartialCheck)
        Me.GroupBox1.Controls.Add(Me.chkFullcheck)
        Me.GroupBox1.Controls.Add(Me.chkXray)
        Me.GroupBox1.Controls.Add(Me.chkLab)
        Me.GroupBox1.Controls.Add(Me.chkConsult)
        Me.GroupBox1.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(213, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 285)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Services"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox4.Controls.Add(Me.btnRefresh)
        Me.GroupBox4.Controls.Add(Me.dgvTreatment)
        Me.GroupBox4.Controls.Add(Me.btnDelete)
        Me.GroupBox4.Font = New System.Drawing.Font("HP Simplified Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox4.Location = New System.Drawing.Point(213, 425)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1691, 692)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Previous Treatment record"
        '
        'dgvTreatment
        '
        Me.dgvTreatment.AllowUserToAddRows = False
        Me.dgvTreatment.AllowUserToDeleteRows = False
        Me.dgvTreatment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTreatment.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTreatment.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvTreatment.Location = New System.Drawing.Point(20, 52)
        Me.dgvTreatment.Name = "dgvTreatment"
        Me.dgvTreatment.ReadOnly = True
        Me.dgvTreatment.RowHeadersWidth = 51
        Me.dgvTreatment.RowTemplate.Height = 24
        Me.dgvTreatment.Size = New System.Drawing.Size(1665, 543)
        Me.dgvTreatment.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Font = New System.Drawing.Font("HP Simplified Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(20, 632)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(263, 41)
        Me.btnRefresh.TabIndex = 34
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Record_treatment_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1084)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Record_treatment_details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dateTreat As DateTimePicker
    Friend WithEvents lblTreatID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtComment As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkMedE As CheckBox
    Friend WithEvents chkMedD As CheckBox
    Friend WithEvents ChkMedC As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkMedB As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkMedA As CheckBox
    Friend WithEvents chkPartialCheck As CheckBox
    Friend WithEvents chkFullcheck As CheckBox
    Friend WithEvents chkXray As CheckBox
    Friend WithEvents chkLab As CheckBox
    Friend WithEvents chkConsult As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvTreatment As DataGridView
    Friend WithEvents btnRefresh As Button
End Class
