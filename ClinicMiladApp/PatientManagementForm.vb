Imports System.Data.SqlClient

Public Class PatientManagementForm
    Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=ClinicMilad;Integrated Security=True;"

    Private Sub PatientManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
        lblLoggedUserName.Text = LoggedInUserFullName
        lblLoggedUserRole.Text = LoggedInRole

    End Sub

    Private Sub LoadPatients()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM Patients"
                Using cmd As New SqlCommand(query, conn)
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())
                    dgvPatients.DataSource = dt
                End Using
            Catch ex As Exception
                MessageBox.Show("خطا در بارگذاری بیماران: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        Dim fullName As String = txtFullName.Text
        Dim birthDate As String = dtpBirthDate.Text
        Dim phoneNumber As String = txtPhoneNumber.Text
        Dim address As String = txtAddress.Text

        If fullName = "" Or phoneNumber = "" Then
            MessageBox.Show("لطفاً همه فیلدها را پر کنید.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO Patients (FullName, BirthDate, PhoneNumber, Address) VALUES (@FullName, @BirthDate, @PhoneNumber, @Address)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FullName", fullName)
                    cmd.Parameters.AddWithValue("@BirthDate", birthDate)
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                    cmd.Parameters.AddWithValue("@Address", address)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("بیمار با موفقیت اضافه شد.")
                    LoadPatients()
                End Using
            Catch ex As Exception
                MessageBox.Show("خطا در افزودن بیمار: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnEditPatient_Click(sender As Object, e As EventArgs) Handles btnEditPatient.Click
        Dim patientId As Integer = dgvPatients.SelectedRows(0).Cells(0).Value
        Dim fullName As String = txtFullName.Text
        Dim birthDate As String = dtpBirthDate.Text
        Dim phoneNumber As String = txtPhoneNumber.Text
        Dim address As String = txtAddress.Text

        If fullName = "" Or phoneNumber = "" Then
            MessageBox.Show("لطفاً همه فیلدها را پر کنید.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "UPDATE Patients SET FullName = @FullName, BirthDate = @BirthDate, PhoneNumber = @PhoneNumber, Address = @Address WHERE PatientID = @PatientID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FullName", fullName)
                    cmd.Parameters.AddWithValue("@BirthDate", birthDate)
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                    cmd.Parameters.AddWithValue("@Address", address)
                    cmd.Parameters.AddWithValue("@PatientID", patientId)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("بیمار با موفقیت ویرایش شد.")
                    LoadPatients()
                End Using
            Catch ex As Exception
                MessageBox.Show("خطا در ویرایش بیمار: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnDeletePatient_Click(sender As Object, e As EventArgs) Handles btnDeletePatient.Click
        Dim patientId As Integer = dgvPatients.SelectedRows(0).Cells(0).Value

        If MessageBox.Show("آیا مطمئن هستید که این بیمار را حذف می‌کنید؟", "حذف بیمار", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As New SqlConnection(connectionString)
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM Patients WHERE PatientID = @PatientID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@PatientID", patientId)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("بیمار با موفقیت حذف شد.")
                        LoadPatients()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("خطا در حذف بیمار: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Close

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
        MessageBox.Show("شما در صفحه مدیریت بیماران می باشید.")
    End Sub

    Private Sub PrescriptionsManagementOnMenu_Click(sender As Object, e As EventArgs) Handles PrescriptionsManagementOnMenu.Click
        Me.Hide()
        PrescriptionManagementForm.Show()
    End Sub

    Private Sub AboutUsOnMenu_Click(sender As Object, e As EventArgs) Handles AboutUsOnMenu.Click
        Me.Hide()
        AboutUsForm.Show()
    End Sub
End Class
