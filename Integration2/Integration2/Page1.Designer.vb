Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page1
    Inherits Wisej.Web.Page

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page1))
        Dim Package1 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package2 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package3 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package4 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package5 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package6 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package7 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package8 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Me.tabControl1 = New Wisej.Web.TabControl()
        Me.tabPage1 = New Wisej.Web.TabPage()
        Me.dataGridViewSearchEngines = New Wisej.Web.DataGridView()
        Me.colText = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colURL = New Wisej.Web.DataGridViewLinkColumn()
        Me.colFrequency = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSlider = New Wisej.Web.DataGridViewColumn()
        Me.widgetTagCloud = New Wisej.Web.Widget()
        Me.tabPage2 = New Wisej.Web.TabPage()
        Me.pictureBox1 = New Wisej.Web.PictureBox()
        Me.widgetSignature = New Wisej.Web.Widget()
        Me.label1 = New Wisej.Web.Label()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        CType(Me.dataGridViewSearchEngines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Location = New System.Drawing.Point(26, 19)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.PageInsets = New Wisej.Web.Padding(1, 30, 1, 1)
        Me.tabControl1.Size = New System.Drawing.Size(1024, 525)
        Me.tabControl1.TabIndex = 0
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.dataGridViewSearchEngines)
        Me.tabPage1.Controls.Add(Me.widgetTagCloud)
        Me.tabPage1.Location = New System.Drawing.Point(1, 30)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Size = New System.Drawing.Size(1022, 494)
        Me.tabPage1.Text = "TagCloud and Slider"
        '
        'dataGridViewSearchEngines
        '
        Me.dataGridViewSearchEngines.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colText, Me.colURL, Me.colFrequency, Me.colSlider})
        Me.dataGridViewSearchEngines.Location = New System.Drawing.Point(8, 11)
        Me.dataGridViewSearchEngines.Name = "dataGridViewSearchEngines"
        Me.dataGridViewSearchEngines.Size = New System.Drawing.Size(658, 443)
        Me.dataGridViewSearchEngines.TabIndex = 1
        '
        'colText
        '
        Me.colText.HeaderText = "SearchEngine"
        Me.colText.Name = "colText"
        Me.colText.ReadOnly = True
        '
        'colURL
        '
        Me.colURL.HeaderText = "URL"
        Me.colURL.Name = "colURL"
        Me.colURL.Text = ""
        Me.colURL.Width = 200
        '
        'colFrequency
        '
        Me.colFrequency.HeaderText = "Frequency"
        Me.colFrequency.Name = "colFrequency"
        '
        'colSlider
        '
        Me.colSlider.HeaderText = "Slider"
        Me.colSlider.Name = "colSlider"
        Me.colSlider.Width = 200
        '
        'widgetTagCloud
        '
        Me.widgetTagCloud.BackColor = System.Drawing.Color.Silver
        Me.widgetTagCloud.InitScript = resources.GetString("widgetTagCloud.InitScript")
        Me.widgetTagCloud.Location = New System.Drawing.Point(684, 11)
        Me.widgetTagCloud.Name = "widgetTagCloud"
		Me.widgetTagCloud.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
		Package1.Name = "ej.web.all.min.css"
		Package1.Source = "http://cdn.syncfusion.com/15.1.0.41/js/web/flat-azure/ej.web.all.min.css"
		Package2.Name = "jquery-1.10.2.min.js"
		Package2.Source = "http://cdn.syncfusion.com/js/assets/external/jquery-1.10.2.min.js"
		Package3.Name = "jquery.easing.1.3.min.js"
		Package3.Source = "http://cdn.syncfusion.com/js/assets/external/jquery.easing.1.3.min.js"
		Package4.Name = "ej.web.all.min.js"
        Package4.Source = "http://cdn.syncfusion.com/15.1.0.41/js/web/ej.web.all.min.js"
        Me.widgetTagCloud.Packages.Add(Package1)
        Me.widgetTagCloud.Packages.Add(Package2)
        Me.widgetTagCloud.Packages.Add(Package3)
        Me.widgetTagCloud.Packages.Add(Package4)
        Me.widgetTagCloud.Size = New System.Drawing.Size(322, 314)
        Me.widgetTagCloud.TabIndex = 0
        Me.widgetTagCloud.Text = "widgetTagCloud"
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.pictureBox1)
        Me.tabPage2.Controls.Add(Me.widgetSignature)
        Me.tabPage2.Controls.Add(Me.label1)
        Me.tabPage2.Location = New System.Drawing.Point(1, 30)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Size = New System.Drawing.Size(1022, 494)
        Me.tabPage2.Text = "Signature"
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pictureBox1.Location = New System.Drawing.Point(692, 37)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(309, 157)
        Me.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom
        '
        'widgetSignature
        '
        Me.widgetSignature.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.widgetSignature.InitScript = resources.GetString("widgetSignature.InitScript")
        Me.widgetSignature.Location = New System.Drawing.Point(15, 37)
        Me.widgetSignature.Name = "widgetSignature"
		Me.widgetSignature.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
		Package5.Name = "ej.web.all.min.css"
		Package5.Source = "http://cdn.syncfusion.com/15.1.0.41/js/web/flat-azure/ej.web.all.min.css"
		Package6.Name = "jquery-1.10.2.min.js"
		Package6.Source = "http://cdn.syncfusion.com/js/assets/external/jquery-1.10.2.min.js"
		Package7.Name = "jquery.easing.1.3.min.js"
		Package7.Source = "http://cdn.syncfusion.com/js/assets/external/jquery.easing.1.3.min.js"
		Package8.Name = "ej.web.all.min.js"
        Package8.Source = "http://cdn.syncfusion.com/15.1.0.41/js/web/ej.web.all.min.js"
        Me.widgetSignature.Packages.Add(Package5)
        Me.widgetSignature.Packages.Add(Package6)
        Me.widgetSignature.Packages.Add(Package7)
        Me.widgetSignature.Packages.Add(Package8)
        Me.widgetSignature.Size = New System.Drawing.Size(671, 429)
        Me.widgetSignature.TabIndex = 3
        Me.widgetSignature.Text = "widgetSignature"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(65, 15)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Sign Here:"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.tabControl1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(916, 742)
        Me.Text = "Page1"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        CType(Me.dataGridViewSearchEngines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents tabControl1 As Wisej.Web.TabControl
    Friend WithEvents tabPage1 As Wisej.Web.TabPage
    Friend WithEvents dataGridViewSearchEngines As Wisej.Web.DataGridView
    Friend WithEvents widgetTagCloud As Wisej.Web.Widget
    Friend WithEvents tabPage2 As Wisej.Web.TabPage
    Friend WithEvents colText As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colURL As Wisej.Web.DataGridViewLinkColumn
    Friend WithEvents colFrequency As Wisej.Web.DataGridViewTextBoxColumn
    Friend WithEvents colSlider As Wisej.Web.DataGridViewColumn
    Friend WithEvents pictureBox1 As Wisej.Web.PictureBox
    Friend WithEvents widgetSignature As Wisej.Web.Widget
    Friend WithEvents label1 As Wisej.Web.Label
End Class
