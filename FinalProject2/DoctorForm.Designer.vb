<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DoctorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGVDoctor = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbtnFemale = New System.Windows.Forms.RadioButton()
        Me.rdbtnMale = New System.Windows.Forms.RadioButton()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtDoctorName = New System.Windows.Forms.TextBox()
        Me.txtDoctorID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DGVDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVDoctor
        '
        Me.DGVDoctor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVDoctor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDoctor.Location = New System.Drawing.Point(12, 357)
        Me.DGVDoctor.Name = "DGVDoctor"
        Me.DGVDoctor.RowHeadersWidth = 51
        Me.DGVDoctor.RowTemplate.Height = 24
        Me.DGVDoctor.Size = New System.Drawing.Size(687, 227)
        Me.DGVDoctor.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rdbtnFemale)
        Me.GroupBox1.Controls.Add(Me.rdbtnMale)
        Me.GroupBox1.Controls.Add(Me.btnInput)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.txtDoctorName)
        Me.GroupBox1.Controls.Add(Me.txtDoctorID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 263)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doctor "
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnClose.Location = New System.Drawing.Point(530, 178)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(129, 48)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(45, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 26)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Doctor Gender   :"
        '
        'rdbtnFemale
        '
        Me.rdbtnFemale.AutoSize = True
        Me.rdbtnFemale.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnFemale.Location = New System.Drawing.Point(341, 117)
        Me.rdbtnFemale.Name = "rdbtnFemale"
        Me.rdbtnFemale.Size = New System.Drawing.Size(116, 39)
        Me.rdbtnFemale.TabIndex = 31
        Me.rdbtnFemale.TabStop = True
        Me.rdbtnFemale.Text = "Female"
        Me.rdbtnFemale.UseVisualStyleBackColor = True
        '
        'rdbtnMale
        '
        Me.rdbtnMale.AutoSize = True
        Me.rdbtnMale.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnMale.Location = New System.Drawing.Point(225, 117)
        Me.rdbtnMale.Name = "rdbtnMale"
        Me.rdbtnMale.Size = New System.Drawing.Size(90, 39)
        Me.rdbtnMale.TabIndex = 30
        Me.rdbtnMale.TabStop = True
        Me.rdbtnMale.Text = "Male"
        Me.rdbtnMale.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInput.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnInput.Location = New System.Drawing.Point(45, 178)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(124, 48)
        Me.btnInput.TabIndex = 24
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(49, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 26)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Doctor ID          :"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEdit.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEdit.Location = New System.Drawing.Point(367, 178)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(141, 48)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnDelete.Location = New System.Drawing.Point(200, 178)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 48)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtDoctorName
        '
        Me.txtDoctorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorName.Location = New System.Drawing.Point(225, 77)
        Me.txtDoctorName.Name = "txtDoctorName"
        Me.txtDoctorName.Size = New System.Drawing.Size(412, 27)
        Me.txtDoctorName.TabIndex = 21
        '
        'txtDoctorID
        '
        Me.txtDoctorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorID.Location = New System.Drawing.Point(225, 38)
        Me.txtDoctorID.Name = "txtDoctorID"
        Me.txtDoctorID.Size = New System.Drawing.Size(412, 27)
        Me.txtDoctorID.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(47, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 26)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Doctor Name     :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DGVDoctor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 669)
        Me.Panel1.TabIndex = 16
        '
        'DoctorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(950, 669)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DoctorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DoctorForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVDoctor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVDoctor As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbtnFemale As RadioButton
    Friend WithEvents rdbtnMale As RadioButton
    Friend WithEvents btnInput As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtDoctorName As TextBox
    Friend WithEvents txtDoctorID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
End Class
