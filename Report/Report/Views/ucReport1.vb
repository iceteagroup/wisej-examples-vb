Imports System
Imports System.IO
Imports Wisej.Web

Namespace Views
    Partial Public Class ucReport1
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReport.Click
            Dim oRepo As repoUtilityRDLC = New repoUtilityRDLC()
            oRepo.ReportPath = Path.Combine(Application.StartupPath, "Report")
            oRepo.ReportFile = "Report.rdlc"
            oRepo.ReportPathFileXML = Path.Combine(Application.StartupPath, "Report")
            oRepo.ReportDataFileXML = "Data.xml"
            'oRepo.DataSetName = "";
            'oRepo.DataSaource = "";

            pdfViewer1.PdfStream = oRepo.ExportPDF()
        End Sub

        Private Sub btnReportFromFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReportFromFile.Click
            pdfViewer1.PdfSource = "Files\Wisej-Datasheet-V2.3.pdf"
        End Sub
    End Class
End Namespace
