Imports System
Imports Wisej.Web
Imports Report.Views

Partial Public Class Window1
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReport.Click
        Dim fReport As frmReport = New frmReport()
        fReport.ShowDialog()
    End Sub
End Class
