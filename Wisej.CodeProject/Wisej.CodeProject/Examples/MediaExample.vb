Imports System
Imports Wisej.Web

Partial Class MediaExample

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub audio1_CurrentTimeChanged(ByVal sender As Object, ByVal e As EventArgs)
        label2.Text = "Position: <span style='color:red'>" & audio1.CurrentTime & "</span>"
    End Sub

    Private Sub audio1_Paused(ByVal sender As Object, ByVal e As EventArgs)
        label1.Text = "Audio Status: Paused"
        button1.Enabled = True
        button2.Enabled = False
    End Sub

    Private Sub audio1_Playing(ByVal sender As Object, ByVal e As EventArgs)
        label1.Text = "Audio Status: Playing"
        button1.Enabled = False
        button2.Enabled = True
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        audio1.Play()
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        audio1.Pause()
    End Sub
End Class
