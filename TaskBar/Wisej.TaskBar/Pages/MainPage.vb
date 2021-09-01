Imports System
Imports Wisej.Web

Public Class MainPage
    Private Sub btnSimpleWindow_Click(sender As Object, e As EventArgs) Handles btnSimpleWindow.Click
        Dim window = New SimpleWindow()
        window.Show()
    End Sub

    Private Sub btnFileExplorer_Click(sender As Object, e As EventArgs) Handles btnFileExplorer.Click
        Dim window = New FileExplorer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
        window.Show()
    End Sub
End Class
