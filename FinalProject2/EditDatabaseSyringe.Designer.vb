<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDatabaseSyringe
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDeleteSyringe = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditSyringe = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInputSyringe = New System.Windows.Forms.Button()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.DGVSyringe = New System.Windows.Forms.DataGridView()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemType = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DGVSyringe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Medical Devices Code"
        '
        'btnDeleteSyringe
        '
        Me.btnDeleteSyringe.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeleteSyringe.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnDeleteSyringe.Location = New System.Drawing.Point(320, 312)
        Me.btnDeleteSyringe.Name = "btnDeleteSyringe"
        Me.btnDeleteSyringe.Size = New System.Drawing.Size(124, 48)
        Me.btnDeleteSyringe.TabIndex = 36
        Me.btnDeleteSyringe.Text = "Delete"
        Me.btnDeleteSyringe.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Medical Devices Name"
        '
        'btnEditSyringe
        '
        Me.btnEditSyringe.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditSyringe.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEditSyringe.Location = New System.Drawing.Point(171, 312)
        Me.btnEditSyringe.Name = "btnEditSyringe"
        Me.btnEditSyringe.Size = New System.Drawing.Size(124, 48)
        Me.btnEditSyringe.TabIndex = 37
        Me.btnEditSyringe.Text = "Edit"
        Me.btnEditSyringe.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Medical Devices Type"
        '
        'btnInputSyringe
        '
        Me.btnInputSyringe.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInputSyringe.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnInputSyringe.Location = New System.Drawing.Point(20, 312)
        Me.btnInputSyringe.Name = "btnInputSyringe"
        Me.btnInputSyringe.Size = New System.Drawing.Size(124, 48)
        Me.btnInputSyringe.TabIndex = 38
        Me.btnInputSyringe.Text = "Input"
        Me.btnInputSyringe.UseVisualStyleBackColor = False
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(239, 22)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(261, 22)
        Me.txtItemCode.TabIndex = 32
        '
        'DGVSyringe
        '
        Me.DGVSyringe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVSyringe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSyringe.Location = New System.Drawing.Point(20, 154)
        Me.DGVSyringe.Name = "DGVSyringe"
        Me.DGVSyringe.RowHeadersWidth = 51
        Me.DGVSyringe.RowTemplate.Height = 24
        Me.DGVSyringe.Size = New System.Drawing.Size(587, 138)
        Me.DGVSyringe.TabIndex = 35
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(239, 67)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(261, 22)
        Me.txtItemName.TabIndex = 33
        '
        'txtItemType
        '
        Me.txtItemType.Location = New System.Drawing.Point(239, 114)
        Me.txtItemType.Name = "txtItemType"
        Me.txtItemType.Size = New System.Drawing.Size(261, 22)
        Me.txtItemType.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtItemType)
        Me.Panel1.Controls.Add(Me.btnDeleteSyringe)
        Me.Panel1.Controls.Add(Me.txtItemName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DGVSyringe)
        Me.Panel1.Controls.Add(Me.btnEditSyringe)
        Me.Panel1.Controls.Add(Me.txtItemCode)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnInputSyringe)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 731)
        Me.Panel1.TabIndex = 39
        '
        'EditDatabaseSyringe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 731)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditDatabaseSyringe"
        Me.Text = "EditDatabaseSyringe"
        CType(Me.DGVSyringe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnDeleteSyringe As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditSyringe As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInputSyringe As Button
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents DGVSyringe As DataGridView
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtItemType As TextBox
    Friend WithEvents Panel1 As Panel
End Class
