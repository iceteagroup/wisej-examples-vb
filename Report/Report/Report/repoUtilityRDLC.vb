Imports System
Imports System.Collections.Generic

'using System;
Imports System.IO
Imports System.Data
Imports System.Text
Imports Microsoft.Reporting.NETCore


Public Class repoUtilityRDLC
    Implements IDisposable
    'private int m_currentPageIndex;
    Private m_streams As IList(Of Stream)
    Private _reportPath As String
    Private _reportFile As String
    Private _reportPathFileXML As String
    Private _reportDataFileXML As String

    Private Function LoadSalesData() As DataTable
        ' Create a new DataSet and read sales data file 
        '    data.xml into the first DataTable.
        Dim dataSet As DataSet = New DataSet()
        _reportPath = Path.Combine(_reportPathFileXML, _reportDataFileXML)
        dataSet.ReadXml(_reportPath)
        Return dataSet.Tables(0)
    End Function

    ' Routine to provide to the report renderer, in order to
    '    save an image for each page of the report.
    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New MemoryStream()
        m_streams.Add(stream)
        Return stream
    End Function

    ' Export the given report as an PDF (Portable Document Format) file.
    Public Function ExportPDF() As Stream
        Const reportType = "PDF"
        Dim encoding As String
        Dim fileNameExtension As String
        Dim mimeType As String
        Dim streams As String()
        Dim warnings As Warning()

        _reportPath = Path.Combine(_reportPath, _reportFile)
        'Dim report As LocalReport = New  LocalReport()
        Dim report As LocalReport = New LocalReport()

        report.ReportPath = _reportPath
        report.DataSources.Add(New ReportDataSource("Sales", LoadSalesData()))

        Dim deviceInfo = "<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0.25in</MarginTop>
                <MarginLeft>0.25in</MarginLeft>
                <MarginRight>0.25in</MarginRight>
                <MarginBottom>0.25in</MarginBottom>
            </DeviceInfo>"

        'Render the report

        'Dim bytes = report.Render(reportType, deviceInfo, mimeType, encoding, fileNameExtension, streams, warnings)
        Dim bytes = report.Render(reportType, deviceInfo)
        Return New MemoryStream(bytes)
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        If m_streams IsNot Nothing Then
            For Each stream In m_streams
                stream.Close()
            Next

            m_streams = Nothing
        End If
    End Sub

    Public Property ReportPath As String
        Get
            Return _reportPath
        End Get
        Set(ByVal value As String)
            _reportPath = value
        End Set
    End Property

    Public Property ReportFile As String
        Get
            Return _reportFile
        End Get
        Set(ByVal value As String)
            _reportFile = value
        End Set
    End Property

    Public Property ReportDataFileXML As String
        Get
            Return _reportDataFileXML
        End Get
        Set(ByVal value As String)
            _reportDataFileXML = value
        End Set
    End Property

    Public Property ReportPathFileXML As String
        Get
            Return _reportPathFileXML
        End Get
        Set(ByVal value As String)
            _reportPathFileXML = value
        End Set
    End Property

    Public Shared Sub Main(ByVal args As String())
    End Sub
End Class
