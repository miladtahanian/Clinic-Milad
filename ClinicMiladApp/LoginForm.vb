Imports System.Data.SqlClient

Public Class LoginForm
    Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=ClinicMilad;Integrated Security=True;"

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMessage.Text = ""
        LoggedInRole = ""
        LoggedInUserID = 0
        LoggedInUsername = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username = "" Or password = "" Then
            lblMessage.Text = "لطفاً نام کاربری و رمز عبور را وارد کنید."
            lblMessage.ForeColor = Color.Red
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        reader.Read()
                        Dim role As String = reader("Role").ToString()
                        LoggedInUsername = reader("Username")
                        LoggedInUserID = reader("UserID")
                        LoggedInRole = reader("Role")
                        LoggedInUserFullName = reader("FullName")
                        If role = "مدیر" Then
                            MessageBox.Show("خوش آمدید مدیر سیستم!")
                        ElseIf role = "دکتر" Then
                            MessageBox.Show("خوش آمدید دکتر!")
                        ElseIf role = "پرستار" Then
                            MessageBox.Show("خوش آمدید پرستار!")
                        End If
                        DashboardForm.Show()
                        Me.Hide()

                    Else
                        lblMessage.Text = "نام کاربری یا رمز عبور اشتباه است."
                        lblMessage.ForeColor = Color.Red
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("خطا در اتصال به دیتابیس: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
