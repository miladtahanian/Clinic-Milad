<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        btnLogin = New Button()
        btnExit = New Button()
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        lblMessage = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(160, 326)
        btnLogin.Name = "btnLogin"
        btnLogin.RightToLeft = RightToLeft.Yes
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 0
        btnLogin.Text = "ورود"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(79, 326)
        btnExit.Name = "btnExit"
        btnExit.RightToLeft = RightToLeft.Yes
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 1
        btnExit.Text = "خروج"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(133, 192)
        lblUsername.Name = "lblUsername"
        lblUsername.RightToLeft = RightToLeft.Yes
        lblUsername.Size = New Size(55, 15)
        lblUsername.TabIndex = 2
        lblUsername.Text = "نام کاربری"
        lblUsername.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(133, 254)
        lblPassword.Name = "lblPassword"
        lblPassword.RightToLeft = RightToLeft.Yes
        lblPassword.Size = New Size(55, 15)
        lblPassword.TabIndex = 3
        lblPassword.Text = "کلمه عبور"
        lblPassword.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(89, 210)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "نام کاربری را اینجا وارد کنید"
        txtUsername.RightToLeft = RightToLeft.Yes
        txtUsername.Size = New Size(142, 23)
        txtUsername.TabIndex = 4
        txtUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(89, 272)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "کلمه عبور را اینجا وارد کنید"
        txtPassword.RightToLeft = RightToLeft.Yes
        txtPassword.Size = New Size(142, 23)
        txtPassword.TabIndex = 5
        txtPassword.TextAlign = HorizontalAlignment.Center
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(109, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(103, 103)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(129, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 15)
        Label1.TabIndex = 7
        Label1.Text = "کلینیک پزشکی"
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(36, 157)
        lblMessage.Name = "lblMessage"
        lblMessage.RightToLeft = RightToLeft.Yes
        lblMessage.Size = New Size(66, 15)
        lblMessage.TabIndex = 8
        lblMessage.Text = "lblMessage"
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(314, 361)
        Controls.Add(lblMessage)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Name = "LoginForm"
        Text = "ورود به سیستم"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMessage As Label

End Class
