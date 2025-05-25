Public Class AboutUsForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        DashboardForm.Show()
    End Sub

    Private Sub AboutUsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class