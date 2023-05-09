Imports System
Imports Wisej.Web

Partial Public Class MainPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MainPage_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        url.Text = $"URL {Application.Url}"
    End Sub
End Class
