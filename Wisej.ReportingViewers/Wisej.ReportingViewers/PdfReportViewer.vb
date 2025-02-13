Imports System
Imports Microsoft.Reporting.WebForms
Imports Wisej.Core
Imports Wisej.Web

Public Class PdfReportViewer

    Private _report As LocalReport

    Private Sub PdfReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load the data.
        Dim data = CreateDataSource()

        ' load the report.
        Dim report = New LocalReport()
        report.ReportPath = ReportPath
        report.DataSources.Add(New ReportDataSource("Report1", data))
        _report = report
        pdfViewer1.PdfSource = Application.StartupUrl & "/" & GetPostbackURL()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        If _report Is Nothing Then Return
        Application.Navigate(GetPostbackURL("export=word"))
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        If _report Is Nothing Then Return
        Application.Navigate(GetPostbackURL("export=excel"))
    End Sub

    Private Function CreateDataSource() As Object
        Dim data = New List(Of Model)()
        data.Add(New Model With {
            .Name = "Jack",
            .LastName = "White"
        })
        data.Add(New Model With {
            .Name = "Joe",
            .LastName = "Black"
        })

        Return data
    End Function

End Class
