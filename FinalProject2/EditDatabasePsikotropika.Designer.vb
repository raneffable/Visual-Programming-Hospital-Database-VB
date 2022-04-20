<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDatabasePsikotropika
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
        Me.btnDeletePsikotropika = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditPsikotropika = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInputPsikotropika = New System.Windows.Forms.Button()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.DGVPsikotropika = New System.Windows.Forms.DataGridView()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemType = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVPsikotropika, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnDeletePsikotropika)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnEditPsikotropika)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnInputPsikotropika)
        Me.Panel1.Controls.Add(Me.txtItemCode)
        Me.Panel1.Controls.Add(Me.DGVPsikotropika)
        Me.Panel1.Controls.Add(Me.txtItemName)
        Me.Panel1.Controls.Add(Me.txtItemType)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1097, 633)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 24)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ItemCode"
        '
        'btnDeletePsikotropika
        '
        Me.btnDeletePsikotropika.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeletePsikotropika.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnDeletePsikotropika.Location = New System.Drawing.Point(316, 308)
        Me.btnDeletePsikotropika.Name = "btnDeletePsikotropika"
        Me.btnDeletePsikotropika.Size = New System.Drawing.Size(124, 48)
        Me.btnDeletePsikotropika.TabIndex = 46
        Me.btnDeletePsikotropika.Text = "Delete"
        Me.btnDeletePsikotropika.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "ItemName"
        '
        'btnEditPsikotropika
        '
        Me.btnEditPsikotropika.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditPsikotropika.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEditPsikotropika.Location = New System.Drawing.Point(167, 308)
        Me.btnEditPsikotropika.Name = "btnEditPsikotropika"
        Me.btnEditPsikotropika.Size = New System.Drawing.Size(124, 48)
        Me.btnEditPsikotropika.TabIndex = 47
        Me.btnEditPsikotropika.Text = "Edit"
        Me.btnEditPsikotropika.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "ItemType"
        '
        'btnInputPsikotropika
        '
        Me.btnInputPsikotropika.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInputPsikotropika.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnInputPsikotropika.Location = New System.Drawing.Point(16, 308)
        Me.btnInputPsikotropika.Name = "btnInputPsikotropika"
        Me.btnInputPsikotropika.Size = New System.Drawing.Size(124, 48)
        Me.btnInputPsikotropika.TabIndex = 48
        Me.btnInputPsikotropika.Text = "Input"
        Me.btnInputPsikotropika.UseVisualStyleBackColor = False
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(123, 19)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(261, 22)
        Me.txtItemCode.TabIndex = 42
        '
        'DGVPsikotropika
        '
        Me.DGVPsikotropika.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVPsikotropika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPsikotropika.Location = New System.Drawing.Point(16, 150)
        Me.DGVPsikotropika.Name = "DGVPsikotropika"
        Me.DGVPsikotropika.RowHeadersWidth = 51
        Me.DGVPsikotropika.RowTemplate.Height = 24
        Me.DGVPsikotropika.Size = New System.Drawing.Size(587, 138)
        Me.DGVPsikotropika.TabIndex = 45
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(123, 63)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(261, 22)
        Me.txtItemName.TabIndex = 43
        '
        'txtItemType
        '
        Me.txtItemType.Location = New System.Drawing.Point(123, 110)
        Me.txtItemType.Name = "txtItemType"
        Me.txtItemType.Size = New System.Drawing.Size(261, 22)
        Me.txtItemType.TabIndex = 44
        '
        'EditDatabasePsikotropika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 633)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditDatabasePsikotropika"
        Me.Text = "EditDatabasePsikotropika"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVPsikotropika, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDeletePsikotropika As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditPsikotropika As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInputPsikotropika As Button
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents DGVPsikotropika As DataGridView
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtItemType As TextBox
End Class
