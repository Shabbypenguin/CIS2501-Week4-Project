Public Class CustomDialog
    Private Sub CustomDialog_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'output.Text = "You are going for a " + Form1.degreePlan + " degree in " + degreeList.SelectedItem.ToString + " and you have " + yearsRemaining.SelectedItem.ToString + " years remaining, keep up the good work!"
        'output.Text = ""
    End Sub

    Public Sub ShowForm(OutputText As String)
        output.Text = OutputText
        Me.Show()
    End Sub
End Class