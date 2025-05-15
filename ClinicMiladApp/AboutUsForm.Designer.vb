<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutUsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutUsForm))
        lblClinicMilad = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        btnBack = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblClinicMilad
        ' 
        lblClinicMilad.AutoSize = True
        lblClinicMilad.Location = New Point(123, 176)
        lblClinicMilad.Name = "lblClinicMilad"
        lblClinicMilad.Size = New Size(67, 15)
        lblClinicMilad.TabIndex = 28
        lblClinicMilad.Text = "کلینیک میلاد"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(71, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(163, 161)
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 202)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 105)
        Label1.TabIndex = 29
        Label1.Text = "طراحی و توسعه" & vbCrLf & "میلاد طحانیان" & vbCrLf & vbCrLf & "دانشجوی رشته کارشناسی ناپیوسته مهندسی نرم افزار" & vbCrLf & "دانشگاه شهید رجایی کاشان" & vbCrLf & vbCrLf & "بهار 1403" & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(115, 333)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 30
        btnBack.Text = "بازگشت"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' AboutUs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(304, 368)
        Controls.Add(btnBack)
        Controls.Add(Label1)
        Controls.Add(lblClinicMilad)
        Controls.Add(PictureBox1)
        Name = "AboutUs"
        Text = "AboutUs"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblClinicMilad As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
End Class
