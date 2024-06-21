<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' Constructor for Form1
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateNewSubmission = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(50, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Varunav Singh, Slidely Task 2 - Slidely Form App"
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.Yellow
        Me.btnViewSubmissions.Location = New System.Drawing.Point(12, 60)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(376, 70)
        Me.btnViewSubmissions.TabIndex = 1
        Me.btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        'btnCreateNewSubmission
        '
        Me.btnCreateNewSubmission.BackColor = System.Drawing.Color.Aqua
        Me.btnCreateNewSubmission.Location = New System.Drawing.Point(12, 150)
        Me.btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        Me.btnCreateNewSubmission.Size = New System.Drawing.Size(376, 70)
        Me.btnCreateNewSubmission.TabIndex = 2
        Me.btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Me.btnCreateNewSubmission.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 240)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Controls.Add(Me.btnCreateNewSubmission)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

        ' Add KeyPreview property
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf Form1_KeyDown
    End Sub

    ' Event handler for KeyDown event to handle keyboard shortcuts
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateNewSubmission.PerformClick()
        End If
    End Sub

    ' Event handler for btnViewSubmissions click event
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim form2 As New Form2()
        form2.Show()
    End Sub

    ' Event handler for btnCreateNewSubmission click event
    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim form3 As New Form3()
        form3.Show()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateNewSubmission As Button
End Class
