Imports System

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Close()
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Dim degreePlan As String = ""
        If degreeBox1.Checked Then
            degreePlan = "Associates"
        ElseIf degreeBox2.Checked Then
            degreePlan = "Bachelors"
        ElseIf degreeBox3.Checked Then
            degreePlan = "Masters"
        ElseIf degreeBox4.Checked Then
            degreePlan = "Ph.D"
        End If
        MsgBox("You are going for a " + degreePlan + " degree in " + degreeList.SelectedItem.ToString + " and you have " + yearsRemaining.SelectedItem.ToString + " years remaining, keep up the good work!")

    End Sub

    Private Sub degreeBox1_Click(sender As Object, e As EventArgs) Handles degreeBox1.Click
        If degreeBox1.Checked Then
            degreeBox2.CheckState = CheckState.Unchecked
            degreeBox3.CheckState = CheckState.Unchecked
            degreeBox4.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub degreeBox2_Click(sender As Object, e As EventArgs) Handles degreeBox2.Click
        If degreeBox2.Checked Then
            degreeBox1.CheckState = CheckState.Unchecked
            degreeBox3.CheckState = CheckState.Unchecked
            degreeBox4.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub degreeBox3_Click(sender As Object, e As EventArgs) Handles degreeBox3.Click
        If degreeBox3.Checked Then
            degreeBox1.CheckState = CheckState.Unchecked
            degreeBox2.CheckState = CheckState.Unchecked
            degreeBox4.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub degreeBox4_Click(sender As Object, e As EventArgs) Handles degreeBox4.Click
        If degreeBox4.Checked Then
            degreeBox1.CheckState = CheckState.Unchecked
            degreeBox2.CheckState = CheckState.Unchecked
            degreeBox3.CheckState = CheckState.Unchecked
        End If
    End Sub
End Class
