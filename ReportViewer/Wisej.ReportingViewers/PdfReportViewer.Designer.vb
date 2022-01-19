Imports System.IO
Imports System.ComponentModel
Imports System.Web
Imports Wisej.Core


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PdfReportViewer
    Inherits Wisej.Web.Form
    Implements IWisejHandler

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ReportPath As String

#Region "IWisejHandler"

    Private ReadOnly Property Compress As Boolean Implements IWisejHandler.Compress
        Get
            Return False
        End Get
    End Property

    Private Sub ProcessRequest(ByVal context As HttpContext) Implements IWisejHandler.ProcessRequest
        Dim request = context.Request
        Dim response = context.Response
        Dim export = request("export")

        ' preview
        If Equals(export, Nothing) Then
            Dim bytes = _report.Render("pdf")
            Dim filename = Path.GetFileNameWithoutExtension(_report.ReportPath)
            response.Expires = -1
            response.ContentType = $"application/pdf"
            response.AppendHeader("Access-Control-Allow-Origin", "*")
            response.AddHeader("Content-Disposition", $"inline; filename=""{filename}.pdf""")
            response.AddHeader("Content-Length", bytes.Length.ToString())
            response.OutputStream.Write(bytes, 0, bytes.Length)
        Else

            Select Case export
                Case "word", "excel"
                    Dim format = If(Equals(export, "word"), "doc", "xls")
                    Dim bytes = _report.Render(export)
                    Dim filename = Path.GetFileNameWithoutExtension(_report.ReportPath)
                    response.Expires = -1
                    response.ContentType = $"application/{format}"
                    response.AppendHeader("Access-Control-Allow-Origin", "*")
                    response.AddHeader("Content-Disposition", $"attachment; filename=""{filename}.{format}""")
                    response.AddHeader("Content-Length", bytes.Length.ToString())
                    response.OutputStream.Write(bytes, 0, bytes.Length)
            End Select
        End If

    End Sub

#End Region




    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.pdfViewer1 = New Wisej.Web.PdfViewer()
        Me.button1 = New Wisej.Web.Button()
        Me.button2 = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'pdfViewer1
        '
        Me.pdfViewer1.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.pdfViewer1.Location = New System.Drawing.Point(28, 53)
        Me.pdfViewer1.Name = "pdfViewer1"
        Me.pdfViewer1.Size = New System.Drawing.Size(511, 390)
        Me.pdfViewer1.TabIndex = 0
        Me.pdfViewer1.ViewerType = Wisej.Web.PdfViewerType.Mozilla
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(28, 3)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 44)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Word"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(134, 3)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(100, 44)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Excel"
        '
        'PdfReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 461)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.pdfViewer1)
        Me.Name = "PdfReportViewer"
        Me.Text = "PdfReportViewer"
        Me.ResumeLayout(False)

    End Sub

    WithEvents pdfViewer1 As Wisej.Web.PdfViewer
    WithEvents button1 As Wisej.Web.Button
    WithEvents button2 As Wisej.Web.Button

End Class
