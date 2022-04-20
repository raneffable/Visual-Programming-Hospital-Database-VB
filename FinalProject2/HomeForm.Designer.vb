<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.MenuStripHome = New System.Windows.Forms.MenuStrip()
        Me.menuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDoctor = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInfoItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemTree = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFeedback = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTipHome = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripHome = New System.Windows.Forms.ToolStrip()
        Me.tsbtnDoctor = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnPatient = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnItem = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnPayment = New System.Windows.Forms.ToolStripButton()
        Me.lblcubo = New System.Windows.Forms.Label()
        Me.ContextMenuStripHome = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHome.SuspendLayout()
        Me.ToolStripHome.SuspendLayout()
        Me.ContextMenuStripHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripHome
        '
        Me.MenuStripHome.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOpen, Me.menuItemTree, Me.menuHistory, Me.menuFeedback, Me.menuQuit})
        Me.MenuStripHome.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripHome.Name = "MenuStripHome"
        Me.MenuStripHome.Size = New System.Drawing.Size(826, 28)
        Me.MenuStripHome.TabIndex = 0
        Me.MenuStripHome.Text = "MenuStrip1"
        '
        'menuOpen
        '
        Me.menuOpen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDoctor, Me.menuPatient, Me.menuItem, Me.menuPayment})
        Me.menuOpen.Name = "menuOpen"
        Me.menuOpen.Size = New System.Drawing.Size(59, 24)
        Me.menuOpen.Text = "Open"
        Me.menuOpen.ToolTipText = "Open Form"
        '
        'menuDoctor
        '
        Me.menuDoctor.Image = CType(resources.GetObject("menuDoctor.Image"), System.Drawing.Image)
        Me.menuDoctor.Name = "menuDoctor"
        Me.menuDoctor.Size = New System.Drawing.Size(175, 26)
        Me.menuDoctor.Text = "Doctor"
        Me.menuDoctor.ToolTipText = "Open Doctor Form"
        '
        'menuPatient
        '
        Me.menuPatient.Image = CType(resources.GetObject("menuPatient.Image"), System.Drawing.Image)
        Me.menuPatient.Name = "menuPatient"
        Me.menuPatient.Size = New System.Drawing.Size(175, 26)
        Me.menuPatient.Text = "Patient"
        Me.menuPatient.ToolTipText = "Open Patient Form"
        '
        'menuItem
        '
        Me.menuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuInfoItem})
        Me.menuItem.Image = CType(resources.GetObject("menuItem.Image"), System.Drawing.Image)
        Me.menuItem.Name = "menuItem"
        Me.menuItem.Size = New System.Drawing.Size(175, 26)
        Me.menuItem.Text = "Full Item List"
        Me.menuItem.ToolTipText = "Open Item Form"
        '
        'menuInfoItem
        '
        Me.menuInfoItem.Image = CType(resources.GetObject("menuInfoItem.Image"), System.Drawing.Image)
        Me.menuInfoItem.Name = "menuInfoItem"
        Me.menuInfoItem.Size = New System.Drawing.Size(148, 26)
        Me.menuInfoItem.Text = "InfoItem"
        Me.menuInfoItem.ToolTipText = "Open Info Item Form"
        '
        'menuPayment
        '
        Me.menuPayment.Image = CType(resources.GetObject("menuPayment.Image"), System.Drawing.Image)
        Me.menuPayment.Name = "menuPayment"
        Me.menuPayment.Size = New System.Drawing.Size(175, 26)
        Me.menuPayment.Text = "Payment"
        Me.menuPayment.ToolTipText = "Open Payment Form"
        '
        'menuItemTree
        '
        Me.menuItemTree.Name = "menuItemTree"
        Me.menuItemTree.Size = New System.Drawing.Size(85, 24)
        Me.menuItemTree.Text = "Item Tree"
        Me.menuItemTree.ToolTipText = "Item TreeView"
        '
        'menuHistory
        '
        Me.menuHistory.Name = "menuHistory"
        Me.menuHistory.Size = New System.Drawing.Size(110, 24)
        Me.menuHistory.Text = "History Stock"
        Me.menuHistory.ToolTipText = "History Stocking Item"
        '
        'menuFeedback
        '
        Me.menuFeedback.Name = "menuFeedback"
        Me.menuFeedback.Size = New System.Drawing.Size(86, 24)
        Me.menuFeedback.Text = "Feedback"
        '
        'menuQuit
        '
        Me.menuQuit.Name = "menuQuit"
        Me.menuQuit.Size = New System.Drawing.Size(51, 24)
        Me.menuQuit.Text = "Quit"
        Me.menuQuit.ToolTipText = "For Quit App"
        '
        'ToolStripHome
        '
        Me.ToolStripHome.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnDoctor, Me.tsbtnPatient, Me.tsbtnItem, Me.tsbtnPayment})
        Me.ToolStripHome.Location = New System.Drawing.Point(0, 28)
        Me.ToolStripHome.Name = "ToolStripHome"
        Me.ToolStripHome.Size = New System.Drawing.Size(826, 68)
        Me.ToolStripHome.TabIndex = 2
        Me.ToolStripHome.Text = "ToolStrip1"
        '
        'tsbtnDoctor
        '
        Me.tsbtnDoctor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnDoctor.Image = CType(resources.GetObject("tsbtnDoctor.Image"), System.Drawing.Image)
        Me.tsbtnDoctor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnDoctor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDoctor.Name = "tsbtnDoctor"
        Me.tsbtnDoctor.Size = New System.Drawing.Size(65, 65)
        Me.tsbtnDoctor.Text = "Doctor"
        '
        'tsbtnPatient
        '
        Me.tsbtnPatient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnPatient.Image = CType(resources.GetObject("tsbtnPatient.Image"), System.Drawing.Image)
        Me.tsbtnPatient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnPatient.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnPatient.Name = "tsbtnPatient"
        Me.tsbtnPatient.Size = New System.Drawing.Size(65, 65)
        Me.tsbtnPatient.Text = "Patient"
        '
        'tsbtnItem
        '
        Me.tsbtnItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnItem.Image = CType(resources.GetObject("tsbtnItem.Image"), System.Drawing.Image)
        Me.tsbtnItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnItem.Name = "tsbtnItem"
        Me.tsbtnItem.Size = New System.Drawing.Size(75, 65)
        Me.tsbtnItem.Text = "Item"
        '
        'tsbtnPayment
        '
        Me.tsbtnPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnPayment.Image = CType(resources.GetObject("tsbtnPayment.Image"), System.Drawing.Image)
        Me.tsbtnPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnPayment.Name = "tsbtnPayment"
        Me.tsbtnPayment.Size = New System.Drawing.Size(65, 65)
        Me.tsbtnPayment.Text = "Payment"
        '
        'lblcubo
        '
        Me.lblcubo.AutoSize = True
        Me.lblcubo.Location = New System.Drawing.Point(577, 54)
        Me.lblcubo.Name = "lblcubo"
        Me.lblcubo.Size = New System.Drawing.Size(0, 17)
        Me.lblcubo.TabIndex = 4
        '
        'ContextMenuStripHome
        '
        Me.ContextMenuStripHome.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStripHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToolStripMenuItem})
        Me.ContextMenuStripHome.Name = "ContextMenuStripHome"
        Me.ContextMenuStripHome.Size = New System.Drawing.Size(107, 28)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(826, 447)
        Me.ContextMenuStrip = Me.ContextMenuStripHome
        Me.Controls.Add(Me.lblcubo)
        Me.Controls.Add(Me.ToolStripHome)
        Me.Controls.Add(Me.MenuStripHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStripHome
        Me.Name = "HomeForm"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStripHome.ResumeLayout(False)
        Me.MenuStripHome.PerformLayout()
        Me.ToolStripHome.ResumeLayout(False)
        Me.ToolStripHome.PerformLayout()
        Me.ContextMenuStripHome.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripHome As MenuStrip
    Friend WithEvents menuOpen As ToolStripMenuItem
    Friend WithEvents menuDoctor As ToolStripMenuItem
    Friend WithEvents menuPatient As ToolStripMenuItem
    Friend WithEvents menuItem As ToolStripMenuItem
    Friend WithEvents menuInfoItem As ToolStripMenuItem
    Friend WithEvents menuQuit As ToolStripMenuItem
    Friend WithEvents ToolTipHome As ToolTip
    Friend WithEvents ToolStripHome As ToolStrip
    Friend WithEvents tsbtnDoctor As ToolStripButton
    Friend WithEvents tsbtnPatient As ToolStripButton
    Friend WithEvents tsbtnItem As ToolStripButton
    Friend WithEvents tsbtnPayment As ToolStripButton
    Friend WithEvents lblcubo As Label
    Friend WithEvents menuItemTree As ToolStripMenuItem
    Friend WithEvents menuPayment As ToolStripMenuItem
    Friend WithEvents menuHistory As ToolStripMenuItem
    Friend WithEvents menuFeedback As ToolStripMenuItem
    Friend WithEvents ContextMenuStripHome As ContextMenuStrip
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
End Class
