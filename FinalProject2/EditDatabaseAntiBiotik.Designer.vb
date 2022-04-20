<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDatabaseAntiBiotik
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemType = New System.Windows.Forms.TextBox()
        Me.DGVAntiBiotik = New System.Windows.Forms.DataGridView()
        Me.btnDeleteAntiBiotik = New System.Windows.Forms.Button()
        Me.btnEditAntiBiotik = New System.Windows.Forms.Button()
        Me.btnInputAntiBiotik = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DGVAntiBiotik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ItemCode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ItemName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ItemType"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(134, 40)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(261, 22)
        Me.txtItemCode.TabIndex = 3
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(134, 84)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(261, 22)
        Me.txtItemName.TabIndex = 3
        '
        'txtItemType
        '
        Me.txtItemType.Location = New System.Drawing.Point(134, 131)
        Me.txtItemType.Name = "txtItemType"
        Me.txtItemType.Size = New System.Drawing.Size(261, 22)
        Me.txtItemType.TabIndex = 3
        '
        'DGVAntiBiotik
        '
        Me.DGVAntiBiotik.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVAntiBiotik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAntiBiotik.Location = New System.Drawing.Point(27, 171)
        Me.DGVAntiBiotik.Name = "DGVAntiBiotik"
        Me.DGVAntiBiotik.RowHeadersWidth = 51
        Me.DGVAntiBiotik.RowTemplate.Height = 24
        Me.DGVAntiBiotik.Size = New System.Drawing.Size(587, 138)
        Me.DGVAntiBiotik.TabIndex = 4
        '
        'btnDeleteAntiBiotik
        '
        Me.btnDeleteAntiBiotik.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeleteAntiBiotik.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnDeleteAntiBiotik.Location = New System.Drawing.Point(327, 329)
        Me.btnDeleteAntiBiotik.Name = "btnDeleteAntiBiotik"
        Me.btnDeleteAntiBiotik.Size = New System.Drawing.Size(124, 48)
        Me.btnDeleteAntiBiotik.TabIndex = 26
        Me.btnDeleteAntiBiotik.Text = "Delete"
        Me.btnDeleteAntiBiotik.UseVisualStyleBackColor = False
        '
        'btnEditAntiBiotik
        '
        Me.btnEditAntiBiotik.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditAntiBiotik.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEditAntiBiotik.Location = New System.Drawing.Point(178, 329)
        Me.btnEditAntiBiotik.Name = "btnEditAntiBiotik"
        Me.btnEditAntiBiotik.Size = New System.Drawing.Size(124, 48)
        Me.btnEditAntiBiotik.TabIndex = 27
        Me.btnEditAntiBiotik.Text = "Edit"
        Me.btnEditAntiBiotik.UseVisualStyleBackColor = False
        '
        'btnInputAntiBiotik
        '
        Me.btnInputAntiBiotik.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInputAntiBiotik.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnInputAntiBiotik.Location = New System.Drawing.Point(27, 329)
        Me.btnInputAntiBiotik.Name = "btnInputAntiBiotik"
        Me.btnInputAntiBiotik.Size = New System.Drawing.Size(124, 48)
        Me.btnInputAntiBiotik.TabIndex = 28
        Me.btnInputAntiBiotik.Text = "Input"
        Me.btnInputAntiBiotik.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnDeleteAntiBiotik)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnEditAntiBiotik)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnInputAntiBiotik)
        Me.Panel1.Controls.Add(Me.txtItemCode)
        Me.Panel1.Controls.Add(Me.DGVAntiBiotik)
        Me.Panel1.Controls.Add(Me.txtItemName)
        Me.Panel1.Controls.Add(Me.txtItemType)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 29
        '
        'EditDatabaseAntiBiotik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditDatabaseAntiBiotik"
        Me.Text = "EditDatabaseAntiBiotik"
        CType(Me.DGVAntiBiotik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtItemType As TextBox
    Friend WithEvents DGVAntiBiotik As DataGridView
    Friend WithEvents btnDeleteAntiBiotik As Button
    Friend WithEvents btnEditAntiBiotik As Button
    Friend WithEvents btnInputAntiBiotik As Button
    Friend WithEvents Panel1 As Panel
End Class
