Imports System
Imports System.IO
Imports System.IO.Compression
Imports System.Net.Mime
Imports System.Web
Imports Wisej.Core
Imports Wisej.Web

Partial Public Class Page1
    Implements IWisejHandler

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        ' provide normal download
        Application.Download("Wisej-Datasheet-V2.2.pdf")
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        ' provide download and open the file right away
        ' use "_blank" to open in new tab - mostly blocked by modern browsers
        Application.DownloadAndOpen("_self", "Wisej-Datasheet-V2.2.pdf")
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
        ' provide download based on a FileStream
        Using stream As Stream = New FileStream(Path.Combine(Application.StartupPath, "Wisej-Datasheet-V2.2.pdf"), FileMode.Open)
            Application.Download(stream, "PDF-FileStream-Download.pdf")
        End Using
    End Sub

    Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
        ' provide dynamic downloads fully handled in memory without temporary files
        ' full control over what is returned to the browser
        ' the GetPostbackURL is provided by the IWisejHandler interface
        Application.Navigate(GetPostbackURL())
    End Sub

    Private Sub ProcessRequest(ByVal context As HttpContext) Implements IWisejHandler.ProcessRequest
        ' create a ZIP file in memory
        Dim memStream = New MemoryStream()

        Using zip = New ZipArchive(memStream, ZipArchiveMode.Create, True)
            zip.CreateEntryFromFile(Path.Combine(Application.StartupPath, "Wisej-Datasheet-V2.2.pdf"), "TestFile.pdf", CompressionLevel.Fastest)
        End Using


        ' reset the position in the stream
        memStream.Position = 0

        ' now that we have the ZIP, handle the request individually
        Dim response = context.Response
        response.AppendHeader("Content-Type", "application/zip")

        Dim oAux As ContentDisposition = New ContentDisposition()
        oAux.FileName = "test.zip"
        oAux.DispositionType = "inline"
        response.AppendHeader("Content-Disposition", oAux.ToString())

        'TODO Comment code not transpose automaticly from C#
        'response.AppendHeader("Content-Disposition", New ContentDisposition(
        '        ' provide a filename to use
        '.FileName = "test.zip", 
        '        ' DispositionType can be "inline" or "attachment"
        '        .DispositionType = "inline"
        ').ToString())

        ' now copy the stream with our ZIP file to the response output
        memStream.CopyTo(response.OutputStream)
    End Sub

    Private ReadOnly Property Compress As Boolean Implements IWisejHandler.Compress
        ' required for the IWisejHandler interface
        Get
            Return False
        End Get
    End Property
End Class
