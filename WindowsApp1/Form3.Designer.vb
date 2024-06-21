<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtField1 = New System.Windows.Forms.TextBox()
        Me.txtField2 = New System.Windows.Forms.TextBox()
        Me.txtField3 = New System.Windows.Forms.TextBox()
        Me.txtField4 = New System.Windows.Forms.TextBox()
        Me.lblField1 = New System.Windows.Forms.Label()
        Me.lblField2 = New System.Windows.Forms.Label()
        Me.lblField3 = New System.Windows.Forms.Label()
        Me.lblField4 = New System.Windows.Forms.Label()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(50, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Varunav Singh, Slidely Task 2 - Create Submission"
        '
        'lblField1
        '
        Me.lblField1.Location = New System.Drawing.Point(50, 60)
        Me.lblField1.Name = "lblField1"
        Me.lblField1.Size = New System.Drawing.Size(100, 20)
        Me.lblField1.TabIndex = 1
        Me.lblField1.Text = "Name:"
        '
        'txtField1
        '
        Me.txtField1.Location = New System.Drawing.Point(150, 60)
        Me.txtField1.Name = "txtField1"
        Me.txtField1.Size = New System.Drawing.Size(200, 26)
        Me.txtField1.TabIndex = 2
        '
        'lblField2
        '
        Me.lblField2.Location = New System.Drawing.Point(50, 100)
        Me.lblField2.Name = "lblField2"
        Me.lblField2.Size = New System.Drawing.Size(100, 20)
        Me.lblField2.TabIndex = 3
        Me.lblField2.Text = "Email:"
        '
        'txtField2
        '
        Me.txtField2.Location = New System.Drawing.Point(150, 100)
        Me.txtField2.Name = "txtField2"
        Me.txtField2.Size = New System.Drawing.Size(200, 26)
        Me.txtField2.TabIndex = 4
        '
        'lblField3
        '
        Me.lblField3.Location = New System.Drawing.Point(50, 140)
        Me.lblField3.Name = "lblField3"
        Me.lblField3.Size = New System.Drawing.Size(100, 20)
        Me.lblField3.TabIndex = 5
        Me.lblField3.Text = "Phone Num:"
        '
        'txtField3
        '
        Me.txtField3.Location = New System.Drawing.Point(150, 140)
        Me.txtField3.Name = "txtField3"
        Me.txtField3.Size = New System.Drawing.Size(200, 26)
        Me.txtField3.TabIndex = 6
        '
        'lblField4
        '
        Me.lblField4.Location = New System.Drawing.Point(50, 180)
        Me.lblField4.Name = "lblField4"
        Me.lblField4.Size = New System.Drawing.Size(100, 40)
        Me.lblField4.TabIndex = 7
        Me.lblField4.Text = "Github Link For Task 2:"
        '
        'txtField4
        '
        Me.txtField4.Location = New System.Drawing.Point(150, 180)
        Me.txtField4.Name = "txtField4"
        Me.txtField4.Size = New System.Drawing.Size(200, 26)
        Me.txtField4.TabIndex = 8
        '
        'lblStopwatch
        '
        Me.lblStopwatch.Location = New System.Drawing.Point(210, 235)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(200, 20)
        Me.lblStopwatch.TabIndex = 9
        Me.lblStopwatch.Text = "00:00:00"
        '
        'btnStartStop
        '
        Me.btnStartStop.BackColor = System.Drawing.Color.Yellow
        Me.btnStartStop.Location = New System.Drawing.Point(30, 230)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(150, 75)
        Me.btnStartStop.TabIndex = 10
        Me.btnStartStop.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnStartStop.UseVisualStyleBackColor = False

        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Aqua
        Me.btnSubmit.Location = New System.Drawing.Point(150, 350)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(250, 100)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False


        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblField1)
        Me.Controls.Add(Me.txtField1)
        Me.Controls.Add(Me.lblField2)
        Me.Controls.Add(Me.txtField2)
        Me.Controls.Add(Me.lblField3)
        Me.Controls.Add(Me.txtField3)
        Me.Controls.Add(Me.lblField4)
        Me.Controls.Add(Me.txtField4)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

        ' Add KeyPreview property
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf Form3_KeyDown
    End Sub

    ' Event handler for KeyDown event to handle keyboard shortcuts
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnStartStop.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtField1 As TextBox
    Friend WithEvents txtField2 As TextBox
    Friend WithEvents txtField3 As TextBox
    Friend WithEvents txtField4 As TextBox
    Friend WithEvents lblField1 As Label
    Friend WithEvents lblField2 As Label
    Friend WithEvents lblField3 As Label
    Friend WithEvents lblField4 As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnStartStop As Button
    Friend WithEvents btnSubmit As Button
End Class
