Imports System
Imports Wisej.Web

Partial Public Class MyDesktop

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Call New Window1().Show()
    End Sub

    Private Sub buttonTheme_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles buttonTheme8.CheckedChanged, buttonTheme7.CheckedChanged, buttonTheme6.CheckedChanged, buttonTheme5.CheckedChanged, buttonTheme4.CheckedChanged, buttonTheme3.CheckedChanged, buttonTheme2.CheckedChanged, buttonTheme1.CheckedChanged
        Dim button = CType(sender, RadioButton)
        If button.Checked Then Application.LoadTheme(button.Text)
    End Sub
End Class
