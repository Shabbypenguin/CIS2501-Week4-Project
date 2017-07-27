<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomDialog
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
        Me.output = New System.Windows.Forms.Label()
        Me.confirmationButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'output
        '
        Me.output.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.output.AutoSize = True
        Me.output.Location = New System.Drawing.Point(74, 38)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(39, 13)
        Me.output.TabIndex = 0
        Me.output.Text = "Label1"
        Me.output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'confirmationButton
        '
        Me.confirmationButton.Location = New System.Drawing.Point(276, 74)
        Me.confirmationButton.Name = "confirmationButton"
        Me.confirmationButton.Size = New System.Drawing.Size(119, 24)
        Me.confirmationButton.TabIndex = 1
        Me.confirmationButton.Text = "Ok"
        Me.confirmationButton.UseVisualStyleBackColor = True
        '
        'CustomDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 110)
        Me.Controls.Add(Me.confirmationButton)
        Me.Controls.Add(Me.output)
        Me.Name = "CustomDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents output As Label
    Friend WithEvents confirmationButton As Button
End Class
