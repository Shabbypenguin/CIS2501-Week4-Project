<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.degreeBox1 = New System.Windows.Forms.CheckBox()
        Me.degreeBox2 = New System.Windows.Forms.CheckBox()
        Me.degreeBox4 = New System.Windows.Forms.CheckBox()
        Me.degreeBox3 = New System.Windows.Forms.CheckBox()
        Me.degreeList = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.startButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'degreeBox1
        '
        Me.degreeBox1.AutoSize = True
        Me.degreeBox1.Location = New System.Drawing.Point(12, 45)
        Me.degreeBox1.Name = "degreeBox1"
        Me.degreeBox1.Size = New System.Drawing.Size(77, 17)
        Me.degreeBox1.TabIndex = 0
        Me.degreeBox1.Text = "Associates"
        Me.degreeBox1.UseVisualStyleBackColor = True
        '
        'degreeBox2
        '
        Me.degreeBox2.AutoSize = True
        Me.degreeBox2.Location = New System.Drawing.Point(12, 68)
        Me.degreeBox2.Name = "degreeBox2"
        Me.degreeBox2.Size = New System.Drawing.Size(73, 17)
        Me.degreeBox2.TabIndex = 4
        Me.degreeBox2.Text = "Bachelors"
        Me.degreeBox2.UseVisualStyleBackColor = True
        '
        'degreeBox4
        '
        Me.degreeBox4.AutoSize = True
        Me.degreeBox4.Location = New System.Drawing.Point(12, 114)
        Me.degreeBox4.Name = "degreeBox4"
        Me.degreeBox4.Size = New System.Drawing.Size(50, 17)
        Me.degreeBox4.TabIndex = 6
        Me.degreeBox4.Text = "Ph.D"
        Me.degreeBox4.UseVisualStyleBackColor = True
        '
        'degreeBox3
        '
        Me.degreeBox3.AutoSize = True
        Me.degreeBox3.Location = New System.Drawing.Point(12, 91)
        Me.degreeBox3.Name = "degreeBox3"
        Me.degreeBox3.Size = New System.Drawing.Size(63, 17)
        Me.degreeBox3.TabIndex = 5
        Me.degreeBox3.Text = "Masters"
        Me.degreeBox3.UseVisualStyleBackColor = True
        '
        'degreeList
        '
        Me.degreeList.FormattingEnabled = True
        Me.degreeList.Items.AddRange(New Object() {"Aeronautics", "Business", "Communication", "Computing", "Education", "Engineering", "Liberal Arts", "Premedical", "Psycology", "Science"})
        Me.degreeList.Location = New System.Drawing.Point(153, 45)
        Me.degreeList.Name = "degreeList"
        Me.degreeList.Size = New System.Drawing.Size(138, 69)
        Me.degreeList.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Year", "month", "date"})
        Me.ComboBox1.Location = New System.Drawing.Point(153, 135)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(138, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Choose your major"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Degree type:"
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(15, 175)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(114, 48)
        Me.startButton.TabIndex = 13
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(165, 175)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(114, 48)
        Me.exitButton.TabIndex = 14
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 243)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.degreeList)
        Me.Controls.Add(Me.degreeBox4)
        Me.Controls.Add(Me.degreeBox3)
        Me.Controls.Add(Me.degreeBox2)
        Me.Controls.Add(Me.degreeBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents degreeBox1 As CheckBox
    Friend WithEvents degreeBox2 As CheckBox
    Friend WithEvents degreeBox4 As CheckBox
    Friend WithEvents degreeBox3 As CheckBox
    Friend WithEvents degreeList As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents startButton As Button
    Friend WithEvents exitButton As Button
End Class
