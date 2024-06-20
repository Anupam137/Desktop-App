Partial Class MainForm1
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateNewSubmission = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.Location = New System.Drawing.Point(12, 12)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(156, 23)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "View Submissions (&V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = True
        '
        'btnCreateNewSubmission
        '
        Me.btnCreateNewSubmission.Location = New System.Drawing.Point(12, 41)
        Me.btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        Me.btnCreateNewSubmission.Size = New System.Drawing.Size(156, 23)
        Me.btnCreateNewSubmission.TabIndex = 1
        Me.btnCreateNewSubmission.Text = "Create New Submission (&C)"
        Me.btnCreateNewSubmission.UseVisualStyleBackColor = True
        '
        'MainForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 81)
        Me.Controls.Add(Me.btnCreateNewSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Name = "MainForm1"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateNewSubmission As Button
End Class
