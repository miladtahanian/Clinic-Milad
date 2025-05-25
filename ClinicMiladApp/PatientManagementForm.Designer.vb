<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientManagementForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientManagementForm))
        lblClinicMilad = New Label()
        PictureBox1 = New PictureBox()
        dgvPatients = New DataGridView()
        lblFullName = New Label()
        lblBDate = New Label()
        lblPhone = New Label()
        Label5 = New Label()
        txtFullName = New TextBox()
        dtpBirthDate = New TextBox()
        txtPhoneNumber = New TextBox()
        txtAddress = New TextBox()
        btnAddPatient = New Button()
        btnEditPatient = New Button()
        btnDeletePatient = New Button()
        StatusStrip1 = New StatusStrip()
        lblLoggedUserName = New ToolStripStatusLabel()
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
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPatients, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        MainMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblClinicMilad
        ' 
        lblClinicMilad.AutoSize = True
        lblClinicMilad.Location = New Point(582, 44)
        lblClinicMilad.Name = "lblClinicMilad"
        lblClinicMilad.Size = New Size(152, 15)
        lblClinicMilad.TabIndex = 9
        lblClinicMilad.Text = "کلینیک میلاد - مدیریت بیماران"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(740, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 47)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' dgvPatients
        ' 
        dgvPatients.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dgvPatients.BackgroundColor = SystemColors.ControlDarkDark
        dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPatients.Location = New Point(12, 27)
        dgvPatients.Name = "dgvPatients"
        dgvPatients.RightToLeft = RightToLeft.Yes
        dgvPatients.Size = New Size(553, 398)
        dgvPatients.TabIndex = 10
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Location = New Point(693, 82)
        lblFullName.Name = "lblFullName"
        lblFullName.RightToLeft = RightToLeft.Yes
        lblFullName.Size = New Size(95, 15)
        lblFullName.TabIndex = 11
        lblFullName.Text = "نام و نام خانوادگی"
        lblFullName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblBDate
        ' 
        lblBDate.AutoSize = True
        lblBDate.Location = New Point(734, 144)
        lblBDate.Name = "lblBDate"
        lblBDate.RightToLeft = RightToLeft.Yes
        lblBDate.Size = New Size(54, 15)
        lblBDate.TabIndex = 12
        lblBDate.Text = "تاریخ تولد"
        lblBDate.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(720, 197)
        lblPhone.Name = "lblPhone"
        lblPhone.RightToLeft = RightToLeft.Yes
        lblPhone.Size = New Size(68, 15)
        lblPhone.TabIndex = 13
        lblPhone.Text = "شماره تماس"
        lblPhone.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(754, 244)
        Label5.Name = "Label5"
        Label5.RightToLeft = RightToLeft.Yes
        Label5.Size = New Size(34, 15)
        Label5.TabIndex = 14
        Label5.Text = "آدرس"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(581, 105)
        txtFullName.Name = "txtFullName"
        txtFullName.PlaceholderText = "نام و نام خانوادگی را اینجا وارد کنید"
        txtFullName.RightToLeft = RightToLeft.Yes
        txtFullName.Size = New Size(207, 23)
        txtFullName.TabIndex = 15
        txtFullName.TextAlign = HorizontalAlignment.Center
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.Location = New Point(581, 162)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.PlaceholderText = "تاریخ تولد را اینجا وارد کنید"
        dtpBirthDate.RightToLeft = RightToLeft.Yes
        dtpBirthDate.Size = New Size(207, 23)
        dtpBirthDate.TabIndex = 16
        dtpBirthDate.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(581, 215)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.PlaceholderText = "شماره تماس را اینجا وارد کنید"
        txtPhoneNumber.RightToLeft = RightToLeft.Yes
        txtPhoneNumber.Size = New Size(207, 23)
        txtPhoneNumber.TabIndex = 17
        txtPhoneNumber.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(581, 262)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.PlaceholderText = "آدرس محل سکونت را اینجا وارد کنید"
        txtAddress.RightToLeft = RightToLeft.Yes
        txtAddress.Size = New Size(207, 95)
        txtAddress.TabIndex = 18
        txtAddress.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnAddPatient
        ' 
        btnAddPatient.Location = New Point(662, 364)
        btnAddPatient.Name = "btnAddPatient"
        btnAddPatient.RightToLeft = RightToLeft.Yes
        btnAddPatient.Size = New Size(126, 52)
        btnAddPatient.TabIndex = 19
        btnAddPatient.Text = "افزودن بیمار"
        btnAddPatient.UseVisualStyleBackColor = True
        ' 
        ' btnEditPatient
        ' 
        btnEditPatient.Location = New Point(581, 364)
        btnEditPatient.Name = "btnEditPatient"
        btnEditPatient.RightToLeft = RightToLeft.Yes
        btnEditPatient.Size = New Size(75, 23)
        btnEditPatient.TabIndex = 20
        btnEditPatient.Text = "ویرایش"
        btnEditPatient.UseVisualStyleBackColor = True
        ' 
        ' btnDeletePatient
        ' 
        btnDeletePatient.Location = New Point(581, 393)
        btnDeletePatient.Name = "btnDeletePatient"
        btnDeletePatient.Size = New Size(75, 23)
        btnDeletePatient.TabIndex = 21
        btnDeletePatient.Text = "حذف بیمار"
        btnDeletePatient.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, lblLoggedUserName, ToolStripStatusLabel2, lblLoggedUserRole})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.RightToLeft = RightToLeft.Yes
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 25
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblLoggedUserName
        ' 
        lblLoggedUserName.Name = "lblLoggedUserName"
        lblLoggedUserName.Size = New Size(94, 17)
        lblLoggedUserName.Text = "نام کاربر وارد شده"
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
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(60, 17)
        ToolStripStatusLabel2.Text = "نقش کاربر:"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(80, 17)
        ToolStripStatusLabel1.Text = "کاربر وارد شده:"
        ' 
        ' PatientManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MainMenu)
        Controls.Add(StatusStrip1)
        Controls.Add(btnDeletePatient)
        Controls.Add(btnEditPatient)
        Controls.Add(btnAddPatient)
        Controls.Add(txtAddress)
        Controls.Add(txtPhoneNumber)
        Controls.Add(dtpBirthDate)
        Controls.Add(txtFullName)
        Controls.Add(Label5)
        Controls.Add(lblPhone)
        Controls.Add(lblBDate)
        Controls.Add(lblFullName)
        Controls.Add(dgvPatients)
        Controls.Add(lblClinicMilad)
        Controls.Add(PictureBox1)
        Name = "PatientManagementForm"
        Text = "PatientManagementForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPatients, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        MainMenu.ResumeLayout(False)
        MainMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblClinicMilad As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvPatients As DataGridView
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblBDate As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents dtpBirthDate As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents btnEditPatient As Button
    Friend WithEvents btnDeletePatient As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblLoggedUserName As ToolStripStatusLabel
    Friend WithEvents lblLoggedUserRole As ToolStripStatusLabel
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
