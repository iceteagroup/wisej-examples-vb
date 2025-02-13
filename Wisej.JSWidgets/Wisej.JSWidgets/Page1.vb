Imports System
Imports Wisej.Web

Partial Public Class Page1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnJQueryKnob_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnJQueryKnob.Click
        Dim window = New frmJQueryKnob()
        window.Show()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim window = New frmBubbles()
        window.Show()
    End Sub

    Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button5.Click
        Dim window = New frmCountUp()
        window.Show()
    End Sub
End Class
