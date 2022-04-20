<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FullItemListForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FullItemListForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVAntiBiotik = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.ImageListRefresh = New System.Windows.Forms.ImageList(Me.components)
        Me.btnEditDatabaseThermometer = New System.Windows.Forms.Button()
        Me.btnEditDatabasePsikotropika = New System.Windows.Forms.Button()
        Me.btnEditDatabaseXRay = New System.Windows.Forms.Button()
        Me.btnEditDatabaseNarkotika = New System.Windows.Forms.Button()
        Me.btnEditDatabaseSyringe = New System.Windows.Forms.Button()
        Me.btnEditDatabaseAntiBiotik = New System.Windows.Forms.Button()
        Me.DGVThermometer = New System.Windows.Forms.DataGridView()
        Me.DGVPsikotropika = New System.Windows.Forms.DataGridView()
        Me.DGVXRay = New System.Windows.Forms.DataGridView()
        Me.DGVNarkotika = New System.Windows.Forms.DataGridView()
        Me.DGVSyringe = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DGVAntiBiotik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVPsikotropika, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVXRay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVNarkotika, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSyringe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Medicine"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1035, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MedicalDevices"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "AntiBiotik"
        '
        'DGVAntiBiotik
        '
        Me.DGVAntiBiotik.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVAntiBiotik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAntiBiotik.Location = New System.Drawing.Point(17, 143)
        Me.DGVAntiBiotik.Name = "DGVAntiBiotik"
        Me.DGVAntiBiotik.RowHeadersWidth = 51
        Me.DGVAntiBiotik.RowTemplate.Height = 24
        Me.DGVAntiBiotik.Size = New System.Drawing.Size(584, 102)
        Me.DGVAntiBiotik.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnEditDatabaseThermometer)
        Me.Panel1.Controls.Add(Me.btnEditDatabasePsikotropika)
        Me.Panel1.Controls.Add(Me.btnEditDatabaseXRay)
        Me.Panel1.Controls.Add(Me.btnEditDatabaseNarkotika)
        Me.Panel1.Controls.Add(Me.btnEditDatabaseSyringe)
        Me.Panel1.Controls.Add(Me.btnEditDatabaseAntiBiotik)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DGVThermometer)
        Me.Panel1.Controls.Add(Me.DGVPsikotropika)
        Me.Panel1.Controls.Add(Me.DGVXRay)
        Me.Panel1.Controls.Add(Me.DGVNarkotika)
        Me.Panel1.Controls.Add(Me.DGVSyringe)
        Me.Panel1.Controls.Add(Me.DGVAntiBiotik)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1866, 958)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1866, 52)
        Me.Panel2.TabIndex = 27
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRefresh.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnRefresh.ImageList = Me.ImageListRefresh
        Me.btnRefresh.Location = New System.Drawing.Point(3, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(136, 36)
        Me.btnRefresh.TabIndex = 26
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'ImageListRefresh
        '
        Me.ImageListRefresh.ImageStream = CType(resources.GetObject("ImageListRefresh.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListRefresh.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListRefresh.Images.SetKeyName(0, "Muat_Ulang.png")
        '
        'btnEditDatabaseThermometer
        '
        Me.btnEditDatabaseThermometer.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditDatabaseThermometer.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEditDatabaseThermometer.Location = New System.Drawing.Point(1040, 756)
        Me.btnEditDatabaseThermometer.Name = "btnEditDatabaseThermometer"
        Me.btnEditDatabaseThermometer.Size = New System.Drawing.Size(206, 48)
        Me.btnEditDatabaseThermometer.TabIndex = 25
        Me.btnEditDatabaseThermometer.Text = "Edit Database Thermometer"
        Me.btnEditDatabaseThermometer.UseVisualStyleBackColor = False
        '
        'btnEditDatabasePsikotropika
        '
        Me.btnEditDatabasePsikotropika.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditDatabasePsikotropika.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEditDatabasePsikotropika.Location = New System.Drawing.Point(17, 756)
        Me.btnEditDatabasePsikotropika.Name = "btnEditDatabasePsikotropika"
        Me.btnEditDatabasePsikotropika.Size = New System.Drawing.Size(206, 48)
        Me.btnEditDatabasePsikotropika.TabIndex = 25
        Me.btnEditDatabasePsikotropika.Text = "Edit Database Psikotropika"
        Me.btnEditDatabasePsikotropika.UseVisualStyleBackColor = False
        '
        'btnEditDatabaseXRay
        '
        Me.btnEditDatabaseXRay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditDatabaseXRay.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEditDatabaseXRay.Location = New System.Drawing.Point(1040, 485)
        Me.btnEditDatabaseXRay.Name = "btnEditDatabaseXRay"
        Me.btnEditDatabaseXRay.Size = New System.Drawing.Size(206, 48)
        Me.btnEditDatabaseXRay.TabIndex = 25
        Me.btnEditDatabaseXRay.Text = "Edit Database XRay"
        Me.btnEditDatabaseXRay.UseVisualStyleBackColor = False
        '
        'btnEditDatabaseNarkotika
        '
        Me.btnEditDatabaseNarkotika.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditDatabaseNarkotika.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEditDatabaseNarkotika.Location = New System.Drawing.Point(17, 485)
        Me.btnEditDatabaseNarkotika.Name = "btnEditDatabaseNarkotika"
        Me.btnEditDatabaseNarkotika.Size = New System.Drawing.Size(206, 48)
        Me.btnEditDatabaseNarkotika.TabIndex = 25
        Me.btnEditDatabaseNarkotika.Text = "Edit Database Narkotika"
        Me.btnEditDatabaseNarkotika.UseVisualStyleBackColor = False
        '
        'btnEditDatabaseSyringe
        '
        Me.btnEditDatabaseSyringe.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditDatabaseSyringe.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEditDatabaseSyringe.Location = New System.Drawing.Point(1040, 261)
        Me.btnEditDatabaseSyringe.Name = "btnEditDatabaseSyringe"
        Me.btnEditDatabaseSyringe.Size = New System.Drawing.Size(206, 48)
        Me.btnEditDatabaseSyringe.TabIndex = 25
        Me.btnEditDatabaseSyringe.Text = "Edit Database Syringe"
        Me.btnEditDatabaseSyringe.UseVisualStyleBackColor = False
        '
        'btnEditDatabaseAntiBiotik
        '
        Me.btnEditDatabaseAntiBiotik.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditDatabaseAntiBiotik.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnEditDatabaseAntiBiotik.Location = New System.Drawing.Point(17, 251)
        Me.btnEditDatabaseAntiBiotik.Name = "btnEditDatabaseAntiBiotik"
        Me.btnEditDatabaseAntiBiotik.Size = New System.Drawing.Size(206, 48)
        Me.btnEditDatabaseAntiBiotik.TabIndex = 25
        Me.btnEditDatabaseAntiBiotik.Text = "Edit Database AntiBiotik"
        Me.btnEditDatabaseAntiBiotik.UseVisualStyleBackColor = False
        '
        'DGVThermometer
        '
        Me.DGVThermometer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVThermometer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVThermometer.Location = New System.Drawing.Point(1040, 637)
        Me.DGVThermometer.Name = "DGVThermometer"
        Me.DGVThermometer.RowHeadersWidth = 51
        Me.DGVThermometer.RowTemplate.Height = 24
        Me.DGVThermometer.Size = New System.Drawing.Size(584, 102)
        Me.DGVThermometer.TabIndex = 3
        '
        'DGVPsikotropika
        '
        Me.DGVPsikotropika.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVPsikotropika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPsikotropika.Location = New System.Drawing.Point(17, 637)
        Me.DGVPsikotropika.Name = "DGVPsikotropika"
        Me.DGVPsikotropika.RowHeadersWidth = 51
        Me.DGVPsikotropika.RowTemplate.Height = 24
        Me.DGVPsikotropika.Size = New System.Drawing.Size(584, 102)
        Me.DGVPsikotropika.TabIndex = 3
        '
        'DGVXRay
        '
        Me.DGVXRay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVXRay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVXRay.Location = New System.Drawing.Point(1040, 377)
        Me.DGVXRay.Name = "DGVXRay"
        Me.DGVXRay.RowHeadersWidth = 51
        Me.DGVXRay.RowTemplate.Height = 24
        Me.DGVXRay.Size = New System.Drawing.Size(584, 102)
        Me.DGVXRay.TabIndex = 3
        '
        'DGVNarkotika
        '
        Me.DGVNarkotika.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVNarkotika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNarkotika.Location = New System.Drawing.Point(17, 377)
        Me.DGVNarkotika.Name = "DGVNarkotika"
        Me.DGVNarkotika.RowHeadersWidth = 51
        Me.DGVNarkotika.RowTemplate.Height = 24
        Me.DGVNarkotika.Size = New System.Drawing.Size(584, 102)
        Me.DGVNarkotika.TabIndex = 3
        '
        'DGVSyringe
        '
        Me.DGVSyringe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVSyringe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSyringe.Location = New System.Drawing.Point(1040, 143)
        Me.DGVSyringe.Name = "DGVSyringe"
        Me.DGVSyringe.RowHeadersWidth = 51
        Me.DGVSyringe.RowTemplate.Height = 24
        Me.DGVSyringe.Size = New System.Drawing.Size(584, 102)
        Me.DGVSyringe.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1035, 594)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 29)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Thermometer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1035, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 29)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "XRay"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 594)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 29)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Psikotropika"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Narkotika"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1035, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 29)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Syringe"
        '
        'FullItemListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1866, 958)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FullItemListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FullItemListForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVAntiBiotik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVPsikotropika, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVXRay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVNarkotika, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSyringe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVAntiBiotik As DataGridView
    Friend WithEvents btnEditDatabaseAntiBiotik As Button
    Friend WithEvents DGVPsikotropika As DataGridView
    Friend WithEvents DGVNarkotika As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEditDatabaseNarkotika As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents ImageListRefresh As ImageList
    Friend WithEvents btnEditDatabasePsikotropika As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGVSyringe As DataGridView
    Friend WithEvents btnEditDatabaseThermometer As Button
    Friend WithEvents btnEditDatabaseXRay As Button
    Friend WithEvents btnEditDatabaseSyringe As Button
    Friend WithEvents DGVThermometer As DataGridView
    Friend WithEvents DGVXRay As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
