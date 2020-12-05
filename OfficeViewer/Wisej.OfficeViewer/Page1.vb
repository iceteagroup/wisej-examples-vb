Imports System
Imports System.IO
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        docViewer.FileSource = "Files/word_sample.doc"
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        ' this.docViewer.FileSource = "Files/excel_sample.xls";
        docViewer.FileName = "excel_sample.xls"
        docViewer.FileStream = File.OpenRead(Application.MapPath("Files/excel_sample.xls"))
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
        docViewer.FileSource = "Files/powerpoint_sample.ppt"
    End Sub
End Class
