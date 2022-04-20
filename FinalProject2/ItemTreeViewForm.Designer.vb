<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemTreeViewForm
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("AntiBiotik")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Narkotika")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Psikotropika")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Medicine", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Syringe")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("XRay")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Thermometer")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Medical Devices", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemTreeViewForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvLeft = New System.Windows.Forms.TreeView()
        Me.ImageListTreeView = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvLeft)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1398, 752)
        Me.SplitContainer1.SplitterDistance = 464
        Me.SplitContainer1.TabIndex = 0
        '
        'tvLeft
        '
        Me.tvLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvLeft.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvLeft.ImageIndex = 0
        Me.tvLeft.ImageList = Me.ImageListTreeView
        Me.tvLeft.Location = New System.Drawing.Point(0, 0)
        Me.tvLeft.Name = "tvLeft"
        TreeNode1.ImageKey = "cute-happy-funny-strong-tablet-cute-happy-funny-strong-tablet-boxing-gloves-fight" &
    "-bacteria-microorganism-virus-vector-flat-133830726.jpg"
        TreeNode1.Name = "nodeAntiBiotik"
        TreeNode1.SelectedImageIndex = 2
        TreeNode1.Text = "AntiBiotik"
        TreeNode2.ImageKey = "download.png"
        TreeNode2.Name = "nodeNarkotika"
        TreeNode2.SelectedImageIndex = 3
        TreeNode2.Text = "Narkotika"
        TreeNode3.ImageKey = "051819.N.FF.FOSTERCAREweb.jpg"
        TreeNode3.Name = "nodePsikotropika"
        TreeNode3.SelectedImageIndex = 4
        TreeNode3.Text = "Psikotropika"
        TreeNode4.Name = "nodeMedicine"
        TreeNode4.Text = "Medicine"
        TreeNode5.ImageKey = "syringe-icon-cartoon-illustration-syringe-vector-icon-web-syringe-icon-cartoon-st" &
    "yle-106950845.jpg"
        TreeNode5.Name = "nodeSyringe"
        TreeNode5.SelectedImageIndex = 1
        TreeNode5.Text = "Syringe"
        TreeNode6.ImageKey = "xray-clipart-black-and-white-2.jpg"
        TreeNode6.Name = "nodeXRay"
        TreeNode6.SelectedImageIndex = 6
        TreeNode6.Text = "XRay"
        TreeNode7.ImageKey = "istockphoto-1201271074-640x640.jpg"
        TreeNode7.Name = "nodeThermometer"
        TreeNode7.SelectedImageIndex = 5
        TreeNode7.Text = "Thermometer"
        TreeNode8.ImageKey = "cartoon-collection-medical-devices-with-nurse_29190-3338.jpg"
        TreeNode8.Name = "nodeMedicalDevices"
        TreeNode8.SelectedImageIndex = 7
        TreeNode8.Text = "Medical Devices"
        Me.tvLeft.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode8})
        Me.tvLeft.SelectedImageIndex = 0
        Me.tvLeft.Size = New System.Drawing.Size(464, 752)
        Me.tvLeft.TabIndex = 0
        '
        'ImageListTreeView
        '
        Me.ImageListTreeView.ImageStream = CType(resources.GetObject("ImageListTreeView.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListTreeView.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListTreeView.Images.SetKeyName(0, "rsz_cute-happy-smiling-medicine-pill-capsule-bottle-flat-cartoon-character-illust" &
        "ration-icon-isolated-white-tablet-pill-capsule-antibiotic-healthcare-drug-medica" &
        "l_92289-526.jpg")
        Me.ImageListTreeView.Images.SetKeyName(1, "syringe-icon-cartoon-illustration-syringe-vector-icon-web-syringe-icon-cartoon-st" &
        "yle-106950845.jpg")
        Me.ImageListTreeView.Images.SetKeyName(2, "cute-happy-funny-strong-tablet-cute-happy-funny-strong-tablet-boxing-gloves-fight" &
        "-bacteria-microorganism-virus-vector-flat-133830726.jpg")
        Me.ImageListTreeView.Images.SetKeyName(3, "download.png")
        Me.ImageListTreeView.Images.SetKeyName(4, "051819.N.FF.FOSTERCAREweb.jpg")
        Me.ImageListTreeView.Images.SetKeyName(5, "istockphoto-1201271074-640x640.jpg")
        Me.ImageListTreeView.Images.SetKeyName(6, "xray-clipart-black-and-white-2.jpg")
        Me.ImageListTreeView.Images.SetKeyName(7, "cartoon-collection-medical-devices-with-nurse_29190-3338.jpg")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Table Medical Devices"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Table Medicine"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(39, 388)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(718, 170)
        Me.DataGridView2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(39, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(718, 210)
        Me.DataGridView1.TabIndex = 0
        '
        'ItemMasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1399, 752)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ItemMasterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ItemMasterForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tvLeft As TreeView
    Friend WithEvents ImageListTreeView As ImageList
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
