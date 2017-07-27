Public Class CustomDialog

    Public Sub ShowForm(OutputText As String)
        output.Text = OutputText
        Show()
    End Sub

    Private Sub confirmationButton_Click(sender As Object, e As EventArgs) Handles confirmationButton.Click
        Close()
    End Sub
End Class