<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDatabaseThermometer
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemType = New System.Windows.Forms.TextBox()
        Me.btnDeleteThermometer = New System.Windows.Forms.Button()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVThermometer = New System.Windows.Forms.DataGridView()
        Me.btnEditThermometer = New System.Windows.Forms.Button()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInputThermometer = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtItemType)
        Me.Panel1.Controls.Add(Me.btnDeleteThermometer)
        Me.Panel1.Controls.Add(Me.txtItemName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DGVThermometer)
        Me.Panel1.Controls.Add(Me.btnEditThermometer)
        Me.Panel1.Controls.Add(Me.txtItemCode)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnInputThermometer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 24)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Medical Devices Code"
        '
        'txtItemType
        '
        Me.txtItemType.Location = New System.Drawing.Point(248, 106)
        Me.txtItemType.Name = "txtItemType"
        Me.txtItemType.Size = New System.Drawing.Size(261, 22)
        Me.txtItemType.TabIndex = 44
        '
        'btnDeleteThermometer
        '
        Me.btnDeleteThermometer.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeleteThermometer.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnDeleteThermometer.Location = New System.Drawing.Point(312, 304)
        Me.btnDeleteThermometer.Name = "btnDeleteThermometer"
        Me.btnDeleteThermometer.Size = New System.Drawing.Size(124, 48)
        Me.btnDeleteThermometer.TabIndex = 46
        Me.btnDeleteThermometer.Text = "Delete"
        Me.btnDeleteThermometer.UseVisualStyleBackColor = False
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(248, 59)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(261, 22)
        Me.txtItemName.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Medical Devices Name"
        '
        'DGVThermometer
        '
        Me.DGVThermometer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVThermometer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVThermometer.Location = New System.Drawing.Point(12, 146)
        Me.DGVThermometer.Name = "DGVThermometer"
        Me.DGVThermometer.RowHeadersWidth = 51
        Me.DGVThermometer.RowTemplate.Height = 24
        Me.DGVThermometer.Size = New System.Drawing.Size(587, 138)
        Me.DGVThermometer.TabIndex = 45
        '
        'btnEditThermometer
        '
        Me.btnEditThermometer.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditThermometer.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEditThermometer.Location = New System.Drawing.Point(163, 304)
        Me.btnEditThermometer.Name = "btnEditThermometer"
        Me.btnEditThermometer.Size = New System.Drawing.Size(124, 48)
        Me.btnEditThermometer.TabIndex = 47
        Me.btnEditThermometer.Text = "Edit"
        Me.btnEditThermometer.UseVisualStyleBackColor = False
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(248, 14)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(261, 22)
        Me.txtItemCode.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 24)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Medical Devices Type"
        '
        'btnInputThermometer
        '
        Me.btnInputThermometer.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInputThermometer.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnInputThermometer.Location = New System.Drawing.Point(12, 304)
        Me.btnInputThermometer.Name = "btnInputThermometer"
        Me.btnInputThermometer.Size = New System.Drawing.Size(124, 48)
        Me.btnInputThermometer.TabIndex = 48
        Me.btnInputThermometer.Text = "Input"
        Me.btnInputThermometer.UseVisualStyleBackColor = False
        '
        'EditDatabaseThermometer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditDatabaseThermometer"
        Me.Text = "EditDatabaseThermometer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItemType As TextBox
    Friend WithEvents btnDeleteThermometer As Button
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVThermometer As DataGridView
    Friend WithEvents btnEditThermometer As Button
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInputThermometer As Button
End Class
