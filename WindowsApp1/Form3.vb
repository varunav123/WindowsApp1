Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class Form3
    Private stopwatch As Stopwatch
    Private timer As Timer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        stopwatch = New Stopwatch()
        timer = New Timer()
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 1000 ' 1 second intervals
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        lblStopwatch.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
        Else
            stopwatch.Start()
            timer.Start()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtField1.Text
        Dim email As String = txtField2.Text
        Dim phone As String = txtField3.Text
        Dim githubLink As String = txtField4.Text
        Dim stopwatchTime As String = lblStopwatch.Text

        Dim httpClient As New HttpClient()
        Dim jsonBody = New With {
            .name = name,
            .email = email,
            .phone = phone,
            .github_link = githubLink,
            .stopwatch_time = stopwatchTime
        }
        Dim jsonBodyString As String = JsonConvert.SerializeObject(jsonBody)
        Dim content As New StringContent(jsonBodyString, Encoding.UTF8, "application/json")

        Try
            Dim response As HttpResponseMessage = Await httpClient.PostAsync("http://localhost:3000/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear form fields after successful submission
                txtField1.Text = String.Empty
                txtField2.Text = String.Empty
                txtField3.Text = String.Empty
                txtField4.Text = String.Empty
                stopwatch.Reset()
                lblStopwatch.Text = "00:00:00"

            Else
                Dim errorMessage As String = $"Server returned error: {response.StatusCode} {response.ReasonPhrase}"
                MessageBox.Show(errorMessage, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error submitting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




End Class
