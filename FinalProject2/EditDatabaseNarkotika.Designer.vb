<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDatabaseNarkotika
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
        Me.btnDeleteNarkotika = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditNarkotika = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInputNarkotika = New System.Windows.Forms.Button()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.DGVNarkotika = New System.Windows.Forms.DataGridView()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemType = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVNarkotika, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnDeleteNarkotika)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnEditNarkotika)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnInputNarkotika)
        Me.Panel1.Controls.Add(Me.txtItemCode)
        Me.Panel1.Controls.Add(Me.DGVNarkotika)
        Me.Panel1.Controls.Add(Me.txtItemName)
        Me.Panel1.Controls.Add(Me.txtItemType)
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
        Me.Label4.Size = New System.Drawing.Size(83, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "ItemCode"
        '
        'btnDeleteNarkotika
        '
        Me.btnDeleteNarkotika.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeleteNarkotika.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnDeleteNarkotika.Location = New System.Drawing.Point(316, 299)
        Me.btnDeleteNarkotika.Name = "btnDeleteNarkotika"
        Me.btnDeleteNarkotika.Size = New System.Drawing.Size(124, 48)
        Me.btnDeleteNarkotika.TabIndex = 36
        Me.btnDeleteNarkotika.Text = "Delete"
        Me.btnDeleteNarkotika.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ItemName"
        '
        'btnEditNarkotika
        '
        Me.btnEditNarkotika.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditNarkotika.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEditNarkotika.Location = New System.Drawing.Point(167, 299)
        Me.btnEditNarkotika.Name = "btnEditNarkotika"
        Me.btnEditNarkotika.Size = New System.Drawing.Size(124, 48)
        Me.btnEditNarkotika.TabIndex = 37
        Me.btnEditNarkotika.Text = "Edit"
        Me.btnEditNarkotika.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "ItemType"
        '
        'btnInputNarkotika
        '
        Me.btnInputNarkotika.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInputNarkotika.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnInputNarkotika.Location = New System.Drawing.Point(16, 299)
        Me.btnInputNarkotika.Name = "btnInputNarkotika"
        Me.btnInputNarkotika.Size = New System.Drawing.Size(124, 48)
        Me.btnInputNarkotika.TabIndex = 38
        Me.btnInputNarkotika.Text = "Input"
        Me.btnInputNarkotika.UseVisualStyleBackColor = False
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(123, 10)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(261, 22)
        Me.txtItemCode.TabIndex = 32
        '
        'DGVNarkotika
        '
        Me.DGVNarkotika.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVNarkotika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNarkotika.Location = New System.Drawing.Point(16, 141)
        Me.DGVNarkotika.Name = "DGVNarkotika"
        Me.DGVNarkotika.RowHeadersWidth = 51
        Me.DGVNarkotika.RowTemplate.Height = 24
        Me.DGVNarkotika.Size = New System.Drawing.Size(587, 138)
        Me.DGVNarkotika.TabIndex = 35
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(123, 54)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(261, 22)
        Me.txtItemName.TabIndex = 33
        '
        'txtItemType
        '
        Me.txtItemType.Location = New System.Drawing.Point(123, 101)
        Me.txtItemType.Name = "txtItemType"
        Me.txtItemType.Size = New System.Drawing.Size(261, 22)
        Me.txtItemType.TabIndex = 34
        '
        'EditDatabaseNarkotika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditDatabaseNarkotika"
        Me.Text = "EditDatabaseNarkotika"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVNarkotika, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDeleteNarkotika As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditNarkotika As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInputNarkotika As Button
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents DGVNarkotika As DataGridView
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtItemType As TextBox
End Class
