<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MediaExample
    Inherits Wisej.Web.Form
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer

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
        tableLayoutPanel1 = New Web.TableLayoutPanel()
        panel1 = New Web.Panel()
        label2 = New Web.Label()
        label1 = New Web.Label()
        button2 = New Web.Button()
        button1 = New Web.Button()
        audio1 = New Web.Audio()
        video1 = New Web.Video()
        pdfViewer1 = New Web.PdfViewer()
        tableLayoutPanel1.SuspendLayout()
        panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tableLayoutPanel1
        ' 
        tableLayoutPanel1.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Bottom Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        tableLayoutPanel1.ColumnCount = 2
        tableLayoutPanel1.ColumnStyles.Add(New Web.ColumnStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.ColumnStyles.Add(New Web.ColumnStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.Controls.Add(panel1, 1, 1)
        tableLayoutPanel1.Controls.Add(video1, 1, 0)
        tableLayoutPanel1.Controls.Add(pdfViewer1, 0, 0)
        tableLayoutPanel1.Location = New Drawing.Point(23, 24)
        tableLayoutPanel1.Name = "tableLayoutPanel1"
        tableLayoutPanel1.RowCount = 2
        tableLayoutPanel1.RowStyles.Add(New Web.RowStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.RowStyles.Add(New Web.RowStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.Size = New Drawing.Size(899, 599)
        tableLayoutPanel1.TabIndex = 0
        ' 
        ' panel1
        ' 
        panel1.CollapseSide = Web.HeaderPosition.Left
        panel1.Controls.Add(label2)
        panel1.Controls.Add(label1)
        panel1.Controls.Add(button2)
        panel1.Controls.Add(button1)
        panel1.Controls.Add(audio1)
        panel1.Dock = Web.DockStyle.Fill
        panel1.HeaderPosition = Web.HeaderPosition.Left
        panel1.Location = New Drawing.Point(452, 302)
        panel1.Name = "panel1"
        panel1.ShowCloseButton = False
        panel1.ShowHeader = True
        panel1.Size = New Drawing.Size(444, 294)
        panel1.TabIndex = 2
        panel1.Text = "Audio Sample"
        ' 
        ' label2
        ' 
        label2.AllowHtml = True
        label2.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        label2.Location = New Drawing.Point(186, 81)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(213, 51)
        label2.TabIndex = 4
        label2.Text = "Position:"
        label2.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' label1
        ' 
        label1.AllowHtml = True
        label1.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        label1.Location = New Drawing.Point(186, 24)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(213, 51)
        label1.TabIndex = 3
        label1.Text = "Audio Status: Paused"
        label1.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' button2
        ' 
        button2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/stop-button.svg"
        button2.Location = New Drawing.Point(16, 81)
        button2.Name = "button2"
        button2.Size = New Drawing.Size(154, 51)
        button2.TabIndex = 2
        button2.Text = "Stop"
        button2.Enabled = False
        button2.TextImageRelation = Web.TextImageRelation.TextBeforeImage
        AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
        ' 
        ' button1
        ' 
        button1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/play-slideshow-button.svg"
        button1.Location = New Drawing.Point(16, 24)
        button1.Name = "button1"
        button1.Size = New Drawing.Size(154, 51)
        button1.TabIndex = 1
        button1.Text = "Play"
        button1.TextImageRelation = Web.TextImageRelation.TextBeforeImage
        AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
        ' 
        ' audio1
        ' 
        audio1.Anchor = Web.AnchorStyles.Bottom Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        audio1.AutoPlay = False
        audio1.Location = New Drawing.Point(16, 205)
        audio1.Name = "audio1"
        audio1.Size = New Drawing.Size(383, 74)
        audio1.SourceURL = "http://www.thesoundarchive.com/starwars/imperial_march.mp3"
        audio1.TabIndex = 0
        audio1.Volume = 0.5R
        AddHandler audio1.CurrentTimeChanged, New EventHandler(AddressOf audio1_CurrentTimeChanged)
        AddHandler audio1.Paused, New EventHandler(AddressOf audio1_Paused)
        AddHandler audio1.Playing, New EventHandler(AddressOf audio1_Playing)
        ' 
        ' video1
        ' 
        video1.Dock = Web.DockStyle.Fill
        video1.Location = New Drawing.Point(452, 3)
        video1.Name = "video1"
        video1.Size = New Drawing.Size(444, 293)
        video1.SourceURL = "Files/sample-mp4-file.mp4"
        video1.TabIndex = 1
        video1.Volume = 0.5R
        video1.AutoPlay = True
        ' 
        ' pdfViewer1
        ' 
        pdfViewer1.Dock = Web.DockStyle.Fill
        pdfViewer1.Location = New Drawing.Point(3, 3)
        pdfViewer1.Name = "pdfViewer1"
        pdfViewer1.PdfSource = "Files\Wisej-Datasheet-V2.3.pdf"
        tableLayoutPanel1.SetRowSpan(pdfViewer1, 2)
        pdfViewer1.Size = New Drawing.Size(443, 593)
        pdfViewer1.TabIndex = 0
        pdfViewer1.ViewerType = Web.PdfViewerType.Mozilla
        ' 
        ' MediaExample
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(953, 653)
        Controls.Add(tableLayoutPanel1)
        IconSource = "resource.wx/Wisej.Ext.MaterialDesign/film-roll.svg?color=#7FBF3F"
        Name = "MediaExample"
        Text = "Media Example"
        tableLayoutPanel1.ResumeLayout(False)
        panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents tableLayoutPanel1 As Web.TableLayoutPanel
    Friend WithEvents pdfViewer1 As Web.PdfViewer
    Friend WithEvents video1 As Web.Video
    Friend WithEvents panel1 As Web.Panel
    Friend WithEvents button2 As Web.Button
    Friend WithEvents button1 As Web.Button
    Friend WithEvents label2 As Web.Label
    Friend WithEvents label1 As Web.Label
    Friend WithEvents audio1 As Web.Audio
End Class
