Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserFullName.Text = LoggedInUserFullName
        lblUserRole.Text = LoggedInRole
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
        Me.Hide()
        PrescriptionManagementForm.Show()
    End Sub

    Private Sub AboutUsOnMenu_Click(sender As Object, e As EventArgs) Handles AboutUsOnMenu.Click
        Me.Hide()
        AboutUsForm.Show()
    End Sub

End Class