Imports System

Public Class Form1
    Dim year As Integer = 1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Close()
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Dim degreePlan As String = ""
        If IsNothing(yearsRemaining.SelectedItem) = True Then
            MsgBox("Please select years remaining")
            Exit Sub
        Else
            If degreeBox1.Checked Then
                degreePlan = "Associates"
            ElseIf degreeBox2.Checked Then
                degreePlan = "Bachelors"
            ElseIf degreeBox3.Checked Then
                degreePlan = "Masters"
            ElseIf degreeBox4.Checked Then
                degreePlan = "Ph.D"
            ElseIf degreeBox1.CheckState = 0 AndAlso degreeBox2.CheckState = 0 AndAlso degreeBox3.CheckState = 0 AndAlso degreeBox4.CheckState = 0 Then
                MsgBox("Please select a degree type")
                Exit Sub
            End If
            CustomDialog.ShowForm("You are going For a " + degreePlan + " degree In " + degreeList.SelectedItem.ToString + " and you have " + yearsRemaining.SelectedItem.ToString + " remaining, keep up the good work!")
        End If
    End Sub

    Private Sub degreeBox1_Click(sender As Object, e As EventArgs) Handles degreeBox1.Click
        If degreeBox1.Checked Then
            Dim i As Integer
            yearsRemaining.Items.Clear()
            degreeBox2.CheckState = CheckState.Unchecked
            degreeBox3.CheckState = CheckState.Unchecked
            degreeBox4.CheckState = CheckState.Unchecked
            Do Until i = 2
                yearsRemaining.Items.Add(year + i & " years")
                i += 1
            Loop
        End If
    End Sub

    Private Sub degreeBox2_Click(sender As Object, e As EventArgs) Handles degreeBox2.Click
        If degreeBox2.Checked Then
            Dim i As Integer
            yearsRemaining.Items.Clear()
            degreeBox1.CheckState = CheckState.Unchecked
            degreeBox3.CheckState = CheckState.Unchecked
            degreeBox4.CheckState = CheckState.Unchecked
            Do Until i = 4
                yearsRemaining.Items.Add(year + i & " years")
                i += 1
            Loop
        End If
    End Sub

    Private Sub degreeBox3_Click(sender As Object, e As EventArgs) Handles degreeBox3.Click
        If degreeBox3.Checked Then
            Dim i As Integer
            yearsRemaining.Items.Clear()
            degreeBox1.CheckState = CheckState.Unchecked
            degreeBox2.CheckState = CheckState.Unchecked
            degreeBox4.CheckState = CheckState.Unchecked
            Do Until i = 7
                yearsRemaining.Items.Add(year + i & " years")
                i += 1
            Loop
        End If
    End Sub

    Private Sub degreeBox4_Click(sender As Object, e As EventArgs) Handles degreeBox4.Click
        If degreeBox4.Checked Then
            Dim i As Integer
            yearsRemaining.Items.Clear()
            degreeBox1.CheckState = CheckState.Unchecked
            degreeBox2.CheckState = CheckState.Unchecked
            degreeBox3.CheckState = CheckState.Unchecked
            Do Until i = 9
                yearsRemaining.Items.Add(year + i & " years")
                i += 1
            Loop
        End If
    End Sub
End Class
