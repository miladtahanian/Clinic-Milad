<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        lblClinicMilad = New Label()
        PictureBox1 = New PictureBox()
        MainMenu = New MenuStrip()
        مدیریتسامانهToolStripMenuItem = New ToolStripMenuItem()
        DashboardOnMenu = New ToolStripMenuItem()
        UserManagementOnMenu = New ToolStripMenuItem()
        PatientsManagementOnMenu = New ToolStripMenuItem()
        PrescriptionsManagementOnMenu = New ToolStripMenuItem()
        LogoutOnMenu = New ToolStripMenuItem()
        برنامهToolStripMenuItem = New ToolStripMenuItem()
        AboutUsOnMenu = New ToolStripMenuItem()
        ExitAppOnMenu = New ToolStripMenuItem()
        Label1 = New Label()
        lblUserFullName = New Label()
        Label2 = New Label()
        lblUserRole = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MainMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblClinicMilad
        ' 
        lblClinicMilad.AutoSize = True
        lblClinicMilad.Location = New Point(349, 198)
        lblClinicMilad.Name = "lblClinicMilad"
        lblClinicMilad.Size = New Size(67, 15)
        lblClinicMilad.TabIndex = 26
        lblClinicMilad.Text = "کلینیک میلاد"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(297, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(163, 161)
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' MainMenu
        ' 
        MainMenu.Items.AddRange(New ToolStripItem() {مدیریتسامانهToolStripMenuItem, برنامهToolStripMenuItem})
        MainMenu.Location = New Point(0, 0)
        MainMenu.Name = "MainMenu"
        MainMenu.RightToLeft = RightToLeft.Yes
        MainMenu.Size = New Size(800, 24)
        MainMenu.TabIndex = 44
        MainMenu.Text = "MenuStrip1"
        ' 
        ' مدیریتسامانهToolStripMenuItem
        ' 
        مدیریتسامانهToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DashboardOnMenu, UserManagementOnMenu, PatientsManagementOnMenu, PrescriptionsManagementOnMenu, LogoutOnMenu})
        مدیریتسامانهToolStripMenuItem.Name = "مدیریتسامانهToolStripMenuItem"
        مدیریتسامانهToolStripMenuItem.Size = New Size(93, 20)
        مدیریتسامانهToolStripMenuItem.Text = "مدیریت سامانه"
        ' 
        ' DashboardOnMenu
        ' 
        DashboardOnMenu.Name = "DashboardOnMenu"
        DashboardOnMenu.Size = New Size(178, 22)
        DashboardOnMenu.Text = "داشبورد"
        ' 
        ' UserManagementOnMenu
        ' 
        UserManagementOnMenu.Name = "UserManagementOnMenu"
        UserManagementOnMenu.Size = New Size(178, 22)
        UserManagementOnMenu.Text = "مدیریت کاربران"
        ' 
        ' PatientsManagementOnMenu
        ' 
        PatientsManagementOnMenu.Name = "PatientsManagementOnMenu"
        PatientsManagementOnMenu.Size = New Size(178, 22)
        PatientsManagementOnMenu.Text = "مدیریت بیماران"
        ' 
        ' PrescriptionsManagementOnMenu
        ' 
        PrescriptionsManagementOnMenu.Name = "PrescriptionsManagementOnMenu"
        PrescriptionsManagementOnMenu.Size = New Size(178, 22)
        PrescriptionsManagementOnMenu.Text = "مدیریت نسخه ها"
        ' 
        ' LogoutOnMenu
        ' 
        LogoutOnMenu.Name = "LogoutOnMenu"
        LogoutOnMenu.Size = New Size(178, 22)
        LogoutOnMenu.Text = "خروج از حساب کاربری"
        ' 
        ' برنامهToolStripMenuItem
        ' 
        برنامهToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutUsOnMenu, ExitAppOnMenu})
        برنامهToolStripMenuItem.Name = "برنامهToolStripMenuItem"
        برنامهToolStripMenuItem.Size = New Size(47, 20)
        برنامهToolStripMenuItem.Text = "برنامه"
        ' 
        ' AboutUsOnMenu
        ' 
        AboutUsOnMenu.Name = "AboutUsOnMenu"
        AboutUsOnMenu.Size = New Size(129, 22)
        AboutUsOnMenu.Text = "درباره پروژه"
        ' 
        ' ExitAppOnMenu
        ' 
        ExitAppOnMenu.Name = "ExitAppOnMenu"
        ExitAppOnMenu.Size = New Size(129, 22)
        ExitAppOnMenu.Text = "خروج"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(443, 277)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.Yes
        Label1.Size = New Size(33, 15)
        Label1.TabIndex = 46
        Label1.Text = "کاربر:"
        ' 
        ' lblUserFullName
        ' 
        lblUserFullName.AutoSize = True
        lblUserFullName.Location = New Point(353, 276)
        lblUserFullName.Name = "lblUserFullName"
        lblUserFullName.Size = New Size(0, 15)
        lblUserFullName.TabIndex = 47
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(442, 328)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.Yes
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 48
        Label2.Text = "نقش:"
        ' 
        ' lblUserRole
        ' 
        lblUserRole.AutoSize = True
        lblUserRole.Location = New Point(349, 328)
        lblUserRole.Name = "lblUserRole"
        lblUserRole.Size = New Size(0, 15)
        lblUserRole.TabIndex = 49
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblUserRole)
        Controls.Add(Label2)
        Controls.Add(lblUserFullName)
        Controls.Add(Label1)
        Controls.Add(MainMenu)
        Controls.Add(lblClinicMilad)
        Controls.Add(PictureBox1)
        Name = "DashboardForm"
        Text = "DashboardForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MainMenu.ResumeLayout(False)
        MainMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblClinicMilad As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents مدیریتسامانهToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashboardOnMenu As ToolStripMenuItem
    Friend WithEvents UserManagementOnMenu As ToolStripMenuItem
    Friend WithEvents PatientsManagementOnMenu As ToolStripMenuItem
    Friend WithEvents PrescriptionsManagementOnMenu As ToolStripMenuItem
    Friend WithEvents LogoutOnMenu As ToolStripMenuItem
    Friend WithEvents برنامهToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsOnMenu As ToolStripMenuItem
    Friend WithEvents ExitAppOnMenu As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUserFullName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUserRole As Label
End Class
