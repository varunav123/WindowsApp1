Imports System.IO
Imports Newtonsoft.Json
Imports System.Net.Http

Partial Public Class Form2
    Inherits System.Windows.Forms.Form

    Private lblTitle As System.Windows.Forms.Label
    Private keyValueLabels As List(Of System.Windows.Forms.Label)
    Private WithEvents btnPrevious As System.Windows.Forms.Button
    Private WithEvents btnNext As System.Windows.Forms.Button

    Private submissions As IEnumerable(Of Object)
    Private currentIndex As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize form components and load data
        InitializeForm()
    End Sub

    Private Sub InitializeForm()
        ' Initialize UI controls
        InitializeControls()

        ' Fetch data from API and display
        FetchDataAndDisplay()
    End Sub

    Private Sub InitializeControls()
        ' Initialize lblTitle
        lblTitle = New System.Windows.Forms.Label()
        lblTitle.Location = New System.Drawing.Point(50, 20)
        lblTitle.Size = New System.Drawing.Size(300, 20)
        lblTitle.Text = "Submissions Viewer"
        Me.Controls.Add(lblTitle)

        ' Initialize labels for key-value pairs dynamically
        keyValueLabels = New List(Of System.Windows.Forms.Label)()

        Dim startY As Integer = 60
        Dim labelHeight As Integer = 20

        For i As Integer = 0 To 4 ' Displaying 5 key-value pairs
            Dim label As New System.Windows.Forms.Label()
            label.Location = New System.Drawing.Point(50, startY + i * labelHeight)
            label.Size = New System.Drawing.Size(300, labelHeight)
            Me.Controls.Add(label)
            keyValueLabels.Add(label)
        Next

        ' Initialize btnPrevious
        btnPrevious = New System.Windows.Forms.Button()
        btnPrevious.BackColor = System.Drawing.Color.Yellow
        btnPrevious.Location = New System.Drawing.Point(50, 200) ' Adjusted position
        btnPrevious.Size = New System.Drawing.Size(150, 30)
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        Me.Controls.Add(btnPrevious)

        ' Initialize btnNext
        btnNext = New System.Windows.Forms.Button()
        btnNext.BackColor = System.Drawing.Color.Green
        btnNext.Location = New System.Drawing.Point(220, 200) ' Adjusted position
        btnNext.Size = New System.Drawing.Size(150, 30)
        btnNext.Text = "NEXT (CTRL + N)"
        Me.Controls.Add(btnNext)

        ' Add KeyPreview property
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf Form2_KeyDown
    End Sub

    Private Async Sub FetchDataAndDisplay()
        Try
            Dim httpClient As New HttpClient()
            Dim response As HttpResponseMessage = Await httpClient.GetAsync("http://localhost:3000/read?index=0")

            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(json)
                currentIndex = 0 ' Start with the first item
                DisplayData()
            Else
                Dim errorMessage As String = $"Failed to fetch data: {response.StatusCode} - {response.ReasonPhrase}"
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplayData()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim currentData = submissions(currentIndex)

            ' Display key-value pairs dynamically
            Dim i As Integer = 0
            For Each kvp As KeyValuePair(Of String, Object) In currentData
                If i >= 5 Then Exit For ' Display up to 5 key-value pairs
                keyValueLabels(i).Text = $"{kvp.Key}: {kvp.Value}"
                i += 1
            Next
        Else
            MessageBox.Show("No data loaded.")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplayData()
        Else
            MessageBox.Show("Already at the first item.")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If submissions IsNot Nothing AndAlso currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplayData()
        Else
            MessageBox.Show("Already at the last item.")
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    ' Manually defined InitializeComponent method (generated by Visual Studio)
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Form2
        '
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(50, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Submissions Viewer"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Yellow
        Me.btnPrevious.Location = New System.Drawing.Point(50, 200)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(150, 30)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "PREVIOUS (CTRL + P)"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Green
        Me.btnNext.Location = New System.Drawing.Point(220, 200)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(150, 30)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "NEXT (CTRL + N)"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 240)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
    End Sub
End Class
