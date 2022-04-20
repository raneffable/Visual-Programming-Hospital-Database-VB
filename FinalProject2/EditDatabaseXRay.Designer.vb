<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDatabaseXRay
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
        Me.btnDeleteXRay = New System.Windows.Forms.Button()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVXRay = New System.Windows.Forms.DataGridView()
        Me.btnEditXRay = New System.Windows.Forms.Button()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInputXRay = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVXRay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtItemType)
        Me.Panel1.Controls.Add(Me.btnDeleteXRay)
        Me.Panel1.Controls.Add(Me.txtItemName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DGVXRay)
        Me.Panel1.Controls.Add(Me.btnEditXRay)
        Me.Panel1.Controls.Add(Me.txtItemCode)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnInputXRay)
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
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 24)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Medical Devices Code"
        '
        'txtItemType
        '
        Me.txtItemType.Location = New System.Drawing.Point(252, 101)
        Me.txtItemType.Name = "txtItemType"
        Me.txtItemType.Size = New System.Drawing.Size(261, 22)
        Me.txtItemType.TabIndex = 44
        '
        'btnDeleteXRay
        '
        Me.btnDeleteXRay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeleteXRay.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnDeleteXRay.Location = New System.Drawing.Point(316, 299)
        Me.btnDeleteXRay.Name = "btnDeleteXRay"
        Me.btnDeleteXRay.Size = New System.Drawing.Size(124, 48)
        Me.btnDeleteXRay.TabIndex = 46
        Me.btnDeleteXRay.Text = "Delete"
        Me.btnDeleteXRay.UseVisualStyleBackColor = False
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(252, 54)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(261, 22)
        Me.txtItemName.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Medical Devices Name"
        '
        'DGVXRay
        '
        Me.DGVXRay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVXRay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVXRay.Location = New System.Drawing.Point(16, 141)
        Me.DGVXRay.Name = "DGVXRay"
        Me.DGVXRay.RowHeadersWidth = 51
        Me.DGVXRay.RowTemplate.Height = 24
        Me.DGVXRay.Size = New System.Drawing.Size(587, 138)
        Me.DGVXRay.TabIndex = 45
        '
        'btnEditXRay
        '
        Me.btnEditXRay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditXRay.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEditXRay.Location = New System.Drawing.Point(167, 299)
        Me.btnEditXRay.Name = "btnEditXRay"
        Me.btnEditXRay.Size = New System.Drawing.Size(124, 48)
        Me.btnEditXRay.TabIndex = 47
        Me.btnEditXRay.Text = "Edit"
        Me.btnEditXRay.UseVisualStyleBackColor = False
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(252, 9)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(261, 22)
        Me.txtItemCode.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 24)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Medical Devices Type"
        '
        'btnInputXRay
        '
        Me.btnInputXRay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInputXRay.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnInputXRay.Location = New System.Drawing.Point(16, 299)
        Me.btnInputXRay.Name = "btnInputXRay"
        Me.btnInputXRay.Size = New System.Drawing.Size(124, 48)
        Me.btnInputXRay.TabIndex = 48
        Me.btnInputXRay.Text = "Input"
        Me.btnInputXRay.UseVisualStyleBackColor = False
        '
        'EditDatabaseXRay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditDatabaseXRay"
        Me.Text = "EditDatabaseXRay"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVXRay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItemType As TextBox
    Friend WithEvents btnDeleteXRay As Button
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVXRay As DataGridView
    Friend WithEvents btnEditXRay As Button
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInputXRay As Button
End Class
