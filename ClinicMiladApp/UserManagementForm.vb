Imports System.Data.SqlClient

Public Class UserManagementForm
    Private Sub UserManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        lblLoggedUserName.Text = LoggedInUserFullName
        lblLoggedUserRole.Text = LoggedInRole
    End Sub

    Private Sub LoadUsers()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM Users"
                Using cmd As New SqlCommand(query, conn)
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())
                    dgvUsers.DataSource = dt
                End Using
            Catch ex As Exception
                MessageBox.Show("خطا در بارگذاری کاربران: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim role As String = cboRole.SelectedItem.ToString()

        If username = "" Or password = "" Then
            MessageBox.Show("لطفاً همه فیلدها را پر کنید.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)
                    cmd.Parameters.AddWithValue("@Role", role)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("کاربر با موفقیت اضافه شد.")
                    LoadUsers()
                End Using
            Catch ex As Exception
                MessageBox.Show("خطا در افزودن کاربر: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        Dim userId As Integer = dgvUsers.SelectedRows(0).Cells(0).Value
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim role As String = cboRole.SelectedItem.ToString()

        If username = "" Or password = "" Then
            MessageBox.Show("لطفاً همه فیلدها را پر کنید.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "UPDATE Users SET Username = @Username, Password = @Password, Role = @Role WHERE UserID = @UserID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)
                    cmd.Parameters.AddWithValue("@Role", role)
                    cmd.Parameters.AddWithValue("@UserID", userId)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("کاربر با موفقیت ویرایش شد.")
                    LoadUsers()
                End Using
            Catch ex As Exception
                MessageBox.Show("خطا در ویرایش کاربر: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim userId As Integer = dgvUsers.SelectedRows(0).Cells(0).Value

        If MessageBox.Show("آیا مطمئن هستید که این کاربر را حذف می‌کنید؟", "حذف کاربر", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As New SqlConnection(connectionString)
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM Users WHERE UserID = @UserID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@UserID", userId)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("کاربر با موفقیت حذف شد.")
                        LoadUsers()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("خطا در حذف کاربر: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub UserManagementOnMenu_Click(sender As Object, e As EventArgs) Handles UserManagementOnMenu.Click
    End Sub

    Private Sub PatientsManagementOnMenu_Click(sender As Object, e As EventArgs) Handles PatientsManagementOnMenu.Click
        Me.Hide()
        PatientManagementForm.Show()
    End Sub

    Private Sub PrescriptionsManagementOnMenu_Click(sender As Object, e As EventArgs) Handles PrescriptionsManagementOnMenu.Click
        PrescriptionManagementForm.Show()
    End Sub

    Private Sub LogoutOnMenu_Click(sender As Object, e As EventArgs) Handles LogoutOnMenu.Click
        Application.Restart()
    End Sub

    Private Sub AboutUsOnMenu_Click(sender As Object, e As EventArgs) Handles AboutUsOnMenu.Click
        Me.Hide()
        AboutUsForm.Show()
    End Sub

    Private Sub ExitAppOnMenu_Click(sender As Object, e As EventArgs) Handles ExitAppOnMenu.Click
        Application.Exit()

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub
End Class
