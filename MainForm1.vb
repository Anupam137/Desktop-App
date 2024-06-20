Public Class MainForm1
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ' Open the ViewSubmissionsForm
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        ' Open the CreateSubmissionForm
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub
End Class
