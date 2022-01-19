Imports System
Imports System.IO
Imports Wisej.Web

Public Class Page1
    Private Sub Page1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReports()
    End Sub

    Private Sub LoadReports()
        Dim path = Application.MapPath("Reports")

        For Each file In Directory.GetFiles(path, "*.rdlc")
            listBox1.Items.Add(IO.Path.GetFileName(file))
        Next
    End Sub

    Private Function GetReportPath() As String
        If listBox1.SelectedIndex = -1 Then Return Nothing
        Return Application.MapPath($"Reports\{listBox1.Text}")
    End Function

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim reportPath = GetReportPath()
        If Not Equals(reportPath, Nothing) Then Call New PdfReportViewer() With {
            .ReportPath = reportPath
        }.Show()
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        Dim reportPath = GetReportPath()
        If Not Equals(reportPath, Nothing) Then Call New AspNetReportViewer() With {
            .ReportPath = reportPath
        }.Show()
    End Sub

End Class
