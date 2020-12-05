Imports System
Imports Wisej.Web

Partial Public Class PrimaryPage
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PrimaryPage_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim switchForm = Application.Session.switchWindow
        switchForm.Show()
        Dim primaryForm = Application.Session.primaryWindow
        primaryForm.Show()
        Dim secondaryForm = Application.Session.secondaryWindow
        secondaryForm.Show()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim primaryForm = Application.Session.primaryWindow
        primaryForm.WindowState = FormWindowState.Normal
        Dim secondaryForm = Application.Session.secondaryWindow
        secondaryForm.WindowState = FormWindowState.Normal
    End Sub
End Class
