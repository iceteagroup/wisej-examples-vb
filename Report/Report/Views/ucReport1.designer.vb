Imports System
Imports Wisej.Web

Namespace Views
    Partial Class ucReport1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Wisej Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.flpTop = New Wisej.Web.FlexLayoutPanel()
            Me.btnReportFromFile = New Wisej.Web.Button()
            Me.btnReport = New Wisej.Web.Button()
            Me.flpContent = New Wisej.Web.FlexLayoutPanel()
            Me.pdfViewer1 = New Wisej.Web.PdfViewer()
            Me.flpTop.SuspendLayout()
            Me.flpContent.SuspendLayout()
            Me.SuspendLayout()
            '
            'flpTop
            '
            Me.flpTop.Controls.Add(Me.btnReportFromFile)
            Me.flpTop.Controls.Add(Me.btnReport)
            Me.flpTop.Dock = Wisej.Web.DockStyle.Top
            Me.flpTop.Location = New System.Drawing.Point(0, 0)
            Me.flpTop.Name = "flpTop"
            Me.flpTop.Size = New System.Drawing.Size(773, 62)
            Me.flpTop.TabIndex = 0
            Me.flpTop.TabStop = True
            '
            'btnReportFromFile
            '
            Me.btnReportFromFile.Dock = Wisej.Web.DockStyle.Left
            Me.btnReportFromFile.Location = New System.Drawing.Point(143, 0)
            Me.btnReportFromFile.Name = "btnReportFromFile"
            Me.btnReportFromFile.Size = New System.Drawing.Size(143, 62)
            Me.btnReportFromFile.TabIndex = 1
            Me.btnReportFromFile.Text = "Report from file"
            '
            'btnReport
            '
            Me.btnReport.Dock = Wisej.Web.DockStyle.Left
            Me.btnReport.Location = New System.Drawing.Point(0, 0)
            Me.btnReport.Name = "btnReport"
            Me.btnReport.Size = New System.Drawing.Size(143, 62)
            Me.btnReport.TabIndex = 0
            Me.btnReport.Text = "Report from RDLC"
            '
            'flpContent
            '
            Me.flpContent.Controls.Add(Me.pdfViewer1)
            Me.flpContent.Dock = Wisej.Web.DockStyle.Fill
            Me.flpContent.Location = New System.Drawing.Point(0, 62)
            Me.flpContent.Name = "flpContent"
            Me.flpContent.Size = New System.Drawing.Size(773, 468)
            Me.flpContent.TabIndex = 1
            Me.flpContent.TabStop = True
            '
            'pdfViewer1
            '
            Me.pdfViewer1.Dock = Wisej.Web.DockStyle.Fill
            Me.pdfViewer1.Location = New System.Drawing.Point(0, 0)
            Me.pdfViewer1.Name = "pdfViewer1"
            Me.pdfViewer1.Size = New System.Drawing.Size(773, 468)
            Me.pdfViewer1.TabIndex = 0
            '
            'ucReport1
            '
            Me.Controls.Add(Me.flpContent)
            Me.Controls.Add(Me.flpTop)
            Me.Name = "ucReport1"
            Me.Size = New System.Drawing.Size(773, 530)
            Me.flpTop.ResumeLayout(False)
            Me.flpContent.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private flpTop As FlexLayoutPanel
        Public WithEvents btnReport As Button
        Private flpContent As FlexLayoutPanel
        Private pdfViewer1 As PdfViewer
        Public WithEvents btnReportFromFile As Button
    End Class
End Namespace
