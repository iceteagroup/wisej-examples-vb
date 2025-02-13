Imports System
Imports System.ComponentModel
Imports Microsoft.Reporting.WebForms
Imports Wisej.Web

Public Class AspNetReportViewer

    Private _data As Object

    Private Sub AspNetReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load the data.
        Dim data = CreateDataSource()

        ' load the report.
        _data = CreateDataSource()
        reportViewer1.ReportPath = ReportPath
    End Sub

    Private Sub reportViewer1_Load_1(sender As Object, e As EventArgs) Handles reportViewer1.Load
        If Not reportViewer1.IsPostBack Then
            Dim report = reportViewer1.WrappedControl.LocalReport
            report.DataSources.Add(New ReportDataSource("Report1", _data))
        End If
    End Sub

    Private Sub reportViewer1_Toggle_1(sender As Object, e As CancelEventArgs) Handles reportViewer1.Toggle

    End Sub

    Private Sub reportViewer1_BookmarkNavigation_1(sender As Object, e As BookmarkNavigationEventArgs)

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

        'var data = new DataTable();
        'data.Columns.Add("Name");
        'data.Columns.Add("LastName");
        'data.Rows.Add("Jack", "White");
        'data.Rows.Add("Joe", "Black");

        Return data
    End Function


End Class
