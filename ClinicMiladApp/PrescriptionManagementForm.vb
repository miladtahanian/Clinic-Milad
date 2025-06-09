Imports System.Data.SqlClient

Public Class PrescriptionManagementForm
    Private Sub PrescriptionManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
        LoadPrescriptions()
        lblLoggedUserName.Text = LoggedInUserFullName
        lblLoggedUserRole.Text = LoggedInRole
    End Sub

    Private Sub LoadPatients()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT PatientID, FullName FROM Patients"
                Using cmd As New SqlCommand(query, conn)
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())
                    cboPatients.DataSource = dt
                    cboPatients.DisplayMember = "FullName"
                    cboPatients.ValueMember = "PatientID"
                End Using
            Catch ex As Exception
                MessageBox.Show("خطا در بارگذاری بیماران: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadPrescriptions()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT Prescriptions.PrescriptionID AS 'شناسه نسخه',Patients.PatientID AS 'شناسه بیمار',Patients.FullName AS 'نام بیمار', Prescriptions.DoctorID AS 'شناسه دکتر',Users.FullName AS 'نام دکتر', PrescriptionText AS 'نسخه'  FROM Prescriptions,Patients,Users WHERE Prescriptions.DoctorID = Users.UserID and Patients.PatientID = Prescriptions.PatientID"
                Using cmd As New SqlCommand(query, conn)
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())
                    dgvPrescriptions.DataSource = dt
                End Using
            Catch ex As Exception
                MessageBox.Show("خطا در بارگذاری نسخه‌ها: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnWritePrescription_Click(sender As Object, e As EventArgs) Handles btnWritePrescription.Click
        Dim patientId As Integer = cboPatients.SelectedValue
        Dim doctorId As Integer = LoggedInUserID
        Dim prescriptionText = txtPrescription.Text

        If prescriptionText = "" Then
            MessageBox.Show("لطفاً نسخه را وارد کنید.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query = "INSERT INTO Prescriptions (PatientID, DoctorID, PrescriptionText) VALUES (@PatientID, @DoctorID, @PrescriptionText)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@PatientID", patientId)
                    cmd.Parameters.AddWithValue("@DoctorID", doctorId)
                    cmd.Parameters.AddWithValue("@PrescriptionText", prescriptionText)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("نسخه با موفقیت ثبت شد.")
                    LoadPrescriptions()
                End Using
            Catch ex As Exception
                MessageBox.Show("خطا در نوشتن نسخه: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub dgvPrescriptions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrescriptions.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedDoctorID As Integer = dgvPrescriptions.Rows(e.RowIndex).Cells("شناسه دکتر").Value.ToString()
            Dim selectedText As String = dgvPrescriptions.Rows(e.RowIndex).Cells("نسخه").Value.ToString()

            txtPrescription.Text = selectedText

            If LoggedInRole = "مدیر" Or LoggedInUserID = selectedDoctorID Then
                btnEditPrescription.Enabled = True
                btnDeletePrescription.Enabled = True
                lblErrorForDoctor.Text = ""
            Else
                btnEditPrescription.Enabled = False
                btnDeletePrescription.Enabled = False
                lblErrorForDoctor.Text = "شما مجاز به ویرایش یا حذف این نسخه نیستید."
            End If
        End If
    End Sub

    Private Sub btnEditPrescription_Click(sender As Object, e As EventArgs) Handles btnEditPrescription.Click
        If dgvPrescriptions.SelectedRows.Count > 0 Then
            Dim prescriptionId As Integer = CInt(dgvPrescriptions.SelectedRows(0).Cells("نام بیمار").Value)
            Dim newText As String = txtPrescription.Text

            Using conn As New SqlConnection(connectionString)
                Try
                    conn.Open()
                    Dim query = "UPDATE Prescriptions SET PrescriptionText = @PrescriptionText WHERE PrescriptionID = @PrescriptionID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@PrescriptionText", newText)
                        cmd.Parameters.AddWithValue("@PrescriptionID", prescriptionId)

                        cmd.ExecuteNonQuery()
                        MessageBox.Show("نسخه با موفقیت ویرایش شد.")
                        LoadPrescriptions()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("خطا در ویرایش نسخه: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnDeletePrescription_Click(sender As Object, e As EventArgs) Handles btnDeletePrescription.Click
        If dgvPrescriptions.SelectedRows.Count > 0 Then
            Dim prescriptionId As Integer = CInt(dgvPrescriptions.SelectedRows(0).Cells("PrescriptionID").Value)

            Dim result As DialogResult = MessageBox.Show("آیا مطمئن هستید که می‌خواهید این نسخه را حذف کنید؟", "حذف نسخه", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Using conn As New SqlConnection(connectionString)
                    Try
                        conn.Open()
                        Dim query = "DELETE FROM Prescriptions WHERE PrescriptionID = @PrescriptionID"
                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@PrescriptionID", prescriptionId)

                            cmd.ExecuteNonQuery()
                            MessageBox.Show("نسخه با موفقیت حذف شد.")
                            LoadPrescriptions()
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("خطا در حذف نسخه: " & ex.Message)
                    End Try
                End Using
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Hide
        LoginForm.Show
    End Sub

    Private Sub LogoutOnMenu_Click(sender As Object, e As EventArgs) Handles LogoutOnMenu.Click
        Application.Restart()
    End Sub

    Private Sub ExitAppOnMenu_Click(sender As Object, e As EventArgs) Handles ExitAppOnMenu.Click
        Application.Exit()
    End Sub

    Private Sub UserManagementOnMenu_Click(sender As Object, e As EventArgs) Handles UserManagementOnMenu.Click
        Me.Hide()
        UserManagementForm.Show()
    End Sub

    Private Sub PatientsManagementOnMenu_Click(sender As Object, e As EventArgs) Handles PatientsManagementOnMenu.Click
        Me.Hide()
        PatientManagementForm.Show()
    End Sub

    Private Sub PrescriptionsManagementOnMenu_Click(sender As Object, e As EventArgs) Handles PrescriptionsManagementOnMenu.Click
        MessageBox.Show("شما در صفحه مدیریت نسخه ها می باشید.")
    End Sub

    Private Sub AboutUsOnMenu_Click(sender As Object, e As EventArgs) Handles AboutUsOnMenu.Click
        Me.Hide()
        AboutUsForm.Show()
    End Sub

End Class
