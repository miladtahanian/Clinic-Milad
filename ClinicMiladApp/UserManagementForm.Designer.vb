<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagementForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserManagementForm))
        btnExit = New Button()
        btnAddUser = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblPhone = New Label()
        lblBDate = New Label()
        lblFullName = New Label()
        dgvUsers = New DataGridView()
        lblClinicMilad = New Label()
        PictureBox1 = New PictureBox()
        btnEditUser = New Button()
        btnDeleteUser = New Button()
        cboRole = New ComboBox()
        btnLogout = New Button()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        lblLoggedUserName = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        lblLoggedUserRole = New ToolStripStatusLabel()
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
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        MainMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(12, 391)
        btnExit.Name = "btnExit"
        btnExit.RightToLeft = RightToLeft.Yes
        btnExit.Size = New Size(126, 23)
        btnExit.TabIndex = 37
        btnExit.Text = "خروج از برنامه"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnAddUser
        ' 
        btnAddUser.Location = New Point(606, 391)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.RightToLeft = RightToLeft.Yes
        btnAddUser.Size = New Size(182, 23)
        btnAddUser.TabIndex = 34
        btnAddUser.Text = "افزودن کاربر"
        btnAddUser.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(301, 98)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "کلمه عبور"
        txtPassword.Size = New Size(207, 23)
        txtPassword.TabIndex = 31
        txtPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtUsername.Location = New Point(580, 98)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "نام کاربری"
        txtUsername.RightToLeft = RightToLeft.Yes
        txtUsername.Size = New Size(207, 23)
        txtUsername.TabIndex = 30
        txtUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(188, 80)
        lblPhone.Name = "lblPhone"
        lblPhone.RightToLeft = RightToLeft.Yes
        lblPhone.Size = New Size(31, 15)
        lblPhone.TabIndex = 28
        lblPhone.Text = "نقش"
        lblPhone.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblBDate
        ' 
        lblBDate.AutoSize = True
        lblBDate.Location = New Point(453, 80)
        lblBDate.Name = "lblBDate"
        lblBDate.RightToLeft = RightToLeft.Yes
        lblBDate.Size = New Size(55, 15)
        lblBDate.TabIndex = 27
        lblBDate.Text = "کلمه عبور"
        lblBDate.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Location = New Point(732, 80)
        lblFullName.Name = "lblFullName"
        lblFullName.RightToLeft = RightToLeft.Yes
        lblFullName.Size = New Size(55, 15)
        lblFullName.TabIndex = 26
        lblFullName.Text = "نام کاربری"
        lblFullName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' dgvUsers
        ' 
        dgvUsers.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dgvUsers.BackgroundColor = SystemColors.ControlDarkDark
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Location = New Point(12, 127)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.RightToLeft = RightToLeft.Yes
        dgvUsers.Size = New Size(775, 258)
        dgvUsers.TabIndex = 25
        ' 
        ' lblClinicMilad
        ' 
        lblClinicMilad.AutoSize = True
        lblClinicMilad.Location = New Point(572, 44)
        lblClinicMilad.Name = "lblClinicMilad"
        lblClinicMilad.Size = New Size(162, 15)
        lblClinicMilad.TabIndex = 24
        lblClinicMilad.Text = "کلینیک پزشکی - مدیریت کاربران"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(740, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 47)
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' btnEditUser
        ' 
        btnEditUser.Location = New Point(443, 391)
        btnEditUser.Name = "btnEditUser"
        btnEditUser.RightToLeft = RightToLeft.Yes
        btnEditUser.Size = New Size(157, 23)
        btnEditUser.TabIndex = 38
        btnEditUser.Text = "ویرایش کاربر"
        btnEditUser.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteUser
        ' 
        btnDeleteUser.Location = New Point(287, 391)
        btnDeleteUser.Name = "btnDeleteUser"
        btnDeleteUser.RightToLeft = RightToLeft.Yes
        btnDeleteUser.Size = New Size(150, 23)
        btnDeleteUser.TabIndex = 39
        btnDeleteUser.Text = "حذف کاربر"
        btnDeleteUser.UseVisualStyleBackColor = True
        ' 
        ' cboRole
        ' 
        cboRole.FormattingEnabled = True
        cboRole.Items.AddRange(New Object() {"مدیر", "دکتر", "پرستار"})
        cboRole.Location = New Point(12, 98)
        cboRole.Name = "cboRole"
        cboRole.RightToLeft = RightToLeft.Yes
        cboRole.Size = New Size(207, 23)
        cboRole.TabIndex = 40
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(144, 391)
        btnLogout.Name = "btnLogout"
        btnLogout.RightToLeft = RightToLeft.Yes
        btnLogout.Size = New Size(137, 23)
        btnLogout.TabIndex = 41
        btnLogout.Text = "خروج از حساب کاربری"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, lblLoggedUserName, ToolStripStatusLabel2, lblLoggedUserRole})
        StatusStrip1.Location = New Point(0, 422)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 42
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(80, 17)
        ToolStripStatusLabel1.Text = "کاربر وارد شده:"
        ' 
        ' lblLoggedUserName
        ' 
        lblLoggedUserName.Name = "lblLoggedUserName"
        lblLoggedUserName.Size = New Size(94, 17)
        lblLoggedUserName.Text = "نام کاربر وارد شده"
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(60, 17)
        ToolStripStatusLabel2.Text = "نقش کاربر:"
        ' 
        ' lblLoggedUserRole
        ' 
        lblLoggedUserRole.Name = "lblLoggedUserRole"
        lblLoggedUserRole.Size = New Size(57, 17)
        lblLoggedUserRole.Text = "نقش کاربر"
        ' 
        ' MainMenu
        ' 
        MainMenu.Items.AddRange(New ToolStripItem() {مدیریتسامانهToolStripMenuItem, برنامهToolStripMenuItem})
        MainMenu.Location = New Point(0, 0)
        MainMenu.Name = "MainMenu"
        MainMenu.RightToLeft = RightToLeft.Yes
        MainMenu.Size = New Size(800, 24)
        MainMenu.TabIndex = 45
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
        ' UserManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 444)
        Controls.Add(MainMenu)
        Controls.Add(StatusStrip1)
        Controls.Add(btnLogout)
        Controls.Add(cboRole)
        Controls.Add(btnDeleteUser)
        Controls.Add(btnEditUser)
        Controls.Add(btnExit)
        Controls.Add(btnAddUser)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPhone)
        Controls.Add(lblBDate)
        Controls.Add(lblFullName)
        Controls.Add(dgvUsers)
        Controls.Add(lblClinicMilad)
        Controls.Add(PictureBox1)
        Name = "UserManagementForm"
        RightToLeft = RightToLeft.Yes
        Text = "UserManagementForm"
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        MainMenu.ResumeLayout(False)
        MainMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblBDate As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents lblClinicMilad As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEditUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblLoggedUserRole As ToolStripStatusLabel
    Friend WithEvents lblLoggedUserName As ToolStripStatusLabel
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
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
End Class
