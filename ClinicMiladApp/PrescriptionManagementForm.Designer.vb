<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrescriptionManagementForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrescriptionManagementForm))
        lblClinicMilad = New Label()
        PictureBox1 = New PictureBox()
        cboPatients = New ComboBox()
        lblSelectPatient = New Label()
        btnWritePrescription = New Button()
        txtPrescription = New TextBox()
        StatusStrip1 = New StatusStrip()
        lblLoggedUserName = New ToolStripStatusLabel()
        lblLoggedUserRole = New ToolStripStatusLabel()
        lblErrorForDoctor = New ToolStripStatusLabel()
        dgvPrescriptions = New DataGridView()
        btnEditPrescription = New Button()
        btnDeletePrescription = New Button()
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        CType(dgvPrescriptions, ComponentModel.ISupportInitialize).BeginInit()
        MainMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblClinicMilad
        ' 
        lblClinicMilad.AutoSize = True
        lblClinicMilad.Location = New Point(594, 41)
        lblClinicMilad.Name = "lblClinicMilad"
        lblClinicMilad.Size = New Size(140, 15)
        lblClinicMilad.TabIndex = 11
        lblClinicMilad.Text = "کلینیک میلاد - نسخه نویسی"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(740, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 47)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' cboPatients
        ' 
        cboPatients.FormattingEnabled = True
        cboPatients.Location = New Point(27, 41)
        cboPatients.Name = "cboPatients"
        cboPatients.Size = New Size(337, 23)
        cboPatients.TabIndex = 12
        ' 
        ' lblSelectPatient
        ' 
        lblSelectPatient.AutoSize = True
        lblSelectPatient.Location = New Point(383, 44)
        lblSelectPatient.Name = "lblSelectPatient"
        lblSelectPatient.RightToLeft = RightToLeft.Yes
        lblSelectPatient.Size = New Size(101, 15)
        lblSelectPatient.TabIndex = 13
        lblSelectPatient.Text = "بیمار را انتخاب کنید:"
        ' 
        ' btnWritePrescription
        ' 
        btnWritePrescription.Location = New Point(370, 402)
        btnWritePrescription.Name = "btnWritePrescription"
        btnWritePrescription.RightToLeft = RightToLeft.Yes
        btnWritePrescription.Size = New Size(418, 23)
        btnWritePrescription.TabIndex = 14
        btnWritePrescription.Text = "ذخیره نسخه"
        btnWritePrescription.UseVisualStyleBackColor = True
        ' 
        ' txtPrescription
        ' 
        txtPrescription.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPrescription.Location = New Point(27, 275)
        txtPrescription.Multiline = True
        txtPrescription.Name = "txtPrescription"
        txtPrescription.PlaceholderText = "نسخه را اینجا وارد کنید"
        txtPrescription.RightToLeft = RightToLeft.Yes
        txtPrescription.Size = New Size(761, 121)
        txtPrescription.TabIndex = 15
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblLoggedUserName, lblLoggedUserRole, lblErrorForDoctor})
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
        ' lblErrorForDoctor
        ' 
        lblErrorForDoctor.ForeColor = Color.Tomato
        lblErrorForDoctor.Name = "lblErrorForDoctor"
        lblErrorForDoctor.RightToLeft = RightToLeft.Yes
        lblErrorForDoctor.Size = New Size(0, 17)
        ' 
        ' dgvPrescriptions
        ' 
        dgvPrescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPrescriptions.Location = New Point(27, 77)
        dgvPrescriptions.Name = "dgvPrescriptions"
        dgvPrescriptions.Size = New Size(761, 192)
        dgvPrescriptions.TabIndex = 26
        ' 
        ' btnEditPrescription
        ' 
        btnEditPrescription.Location = New Point(204, 402)
        btnEditPrescription.Name = "btnEditPrescription"
        btnEditPrescription.RightToLeft = RightToLeft.Yes
        btnEditPrescription.Size = New Size(160, 23)
        btnEditPrescription.TabIndex = 27
        btnEditPrescription.Text = "ویرایش نسخه"
        btnEditPrescription.UseVisualStyleBackColor = True
        ' 
        ' btnDeletePrescription
        ' 
        btnDeletePrescription.Location = New Point(27, 402)
        btnDeletePrescription.Name = "btnDeletePrescription"
        btnDeletePrescription.RightToLeft = RightToLeft.Yes
        btnDeletePrescription.Size = New Size(167, 23)
        btnDeletePrescription.TabIndex = 28
        btnDeletePrescription.Text = "حذف نسخه"
        btnDeletePrescription.UseVisualStyleBackColor = True
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
        ' PrescriptionManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MainMenu)
        Controls.Add(btnDeletePrescription)
        Controls.Add(btnEditPrescription)
        Controls.Add(dgvPrescriptions)
        Controls.Add(StatusStrip1)
        Controls.Add(txtPrescription)
        Controls.Add(btnWritePrescription)
        Controls.Add(lblSelectPatient)
        Controls.Add(cboPatients)
        Controls.Add(lblClinicMilad)
        Controls.Add(PictureBox1)
        Name = "PrescriptionManagementForm"
        Text = "PrescriptionManagementForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(dgvPrescriptions, ComponentModel.ISupportInitialize).EndInit()
        MainMenu.ResumeLayout(False)
        MainMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblClinicMilad As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboPatients As ComboBox
    Friend WithEvents lblSelectPatient As Label
    Friend WithEvents btnWritePrescription As Button
    Friend WithEvents txtPrescription As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblLoggedUserName As ToolStripStatusLabel
    Friend WithEvents lblLoggedUserRole As ToolStripStatusLabel
    Friend WithEvents dgvPrescriptions As DataGridView
    Friend WithEvents btnEditPrescription As Button
    Friend WithEvents btnDeletePrescription As Button
    Friend WithEvents lblErrorForDoctor As ToolStripStatusLabel
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
End Class
