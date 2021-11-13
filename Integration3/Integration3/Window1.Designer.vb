<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Window1))
        Dim Package1 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package2 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package3 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package4 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package5 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Me.tabControl1 = New Wisej.Web.TabControl()
        Me.tabPage2 = New Wisej.Web.TabPage()
        Me.widgetDonut = New Wisej.Web.Widget()
        Me.tabPage1 = New Wisej.Web.TabPage()
        Me.tableLayoutPanel2 = New Wisej.Web.TableLayoutPanel()
        Me.flowLayoutPanel1 = New Wisej.Web.FlowLayoutPanel()
        Me.label1 = New Wisej.Web.Label()
        Me.comboBox1 = New Wisej.Web.ComboBox()
        Me.widgetPie = New Wisej.Web.Widget()
        Me.tabPage3 = New Wisej.Web.TabPage()
        Me.tableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
        Me.panel4 = New Wisej.Web.Panel()
        Me.tableLayoutPanel3 = New Wisej.Web.TableLayoutPanel()
        Me.button1 = New Wisej.Web.Button()
        Me.textBoxQRfreeText = New Wisej.Web.TextBox()
        Me.widgetQRfreeText = New Wisej.Web.Widget()
        Me.panel3 = New Wisej.Web.Panel()
        Me.widgetQRurl = New Wisej.Web.Widget()
        Me.panel2 = New Wisej.Web.Panel()
        Me.widgetQRgeo = New Wisej.Web.Widget()
        Me.panel1 = New Wisej.Web.Panel()
        Me.widgetQRemail = New Wisej.Web.Widget()
        Me.tabControl1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.tableLayoutPanel3.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Dock = Wisej.Web.DockStyle.Fill
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.PageInsets = New Wisej.Web.Padding(1, 35, 1, 1)
        Me.tabControl1.Size = New System.Drawing.Size(986, 661)
        Me.tabControl1.TabIndex = 0
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.widgetDonut)
        Me.tabPage2.Location = New System.Drawing.Point(1, 35)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Size = New System.Drawing.Size(984, 625)
        Me.tabPage2.Text = "Donut"
        '
        'widgetDonut
        '
        Me.widgetDonut.Dock = Wisej.Web.DockStyle.Fill
        Me.widgetDonut.InitScript = resources.GetString("widgetDonut.InitScript")
        Me.widgetDonut.Location = New System.Drawing.Point(0, 0)
        Me.widgetDonut.Name = "widgetDonut"
        Me.widgetDonut.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Package1.Name = "jquery-1.12.3.min.js"
        Package1.Source = "https://code.jquery.com/jquery-1.12.3.min.js"
        Package2.Name = "kendo.all.min.js"
        Package2.Source = "https://kendo.cdn.telerik.com/2017.2.621/js/kendo.all.min.js"
        Package3.Name = "kendo.common.min.css"
        Package3.Source = "https://kendo.cdn.telerik.com/2017.2.621/styles/kendo.common.min.css"
        Package4.Name = "kendo.default.min.css"
        Package4.Source = "https://kendo.cdn.telerik.com/2017.2.621/styles/kendo.default.min.css"
        Package5.Name = "kendo.default.mobile.min.css"
        Package5.Source = "https://kendo.cdn.telerik.com/2017.2.621/styles/kendo.default.mobile.min.css"
        Me.widgetDonut.Packages.Add(Package1)
        Me.widgetDonut.Packages.Add(Package2)
        Me.widgetDonut.Packages.Add(Package3)
        Me.widgetDonut.Packages.Add(Package4)
        Me.widgetDonut.Packages.Add(Package5)
        Me.widgetDonut.Size = New System.Drawing.Size(984, 625)
        Me.widgetDonut.TabIndex = 0
        Me.widgetDonut.Text = "widget1"
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.tableLayoutPanel2)
        Me.tabPage1.Location = New System.Drawing.Point(1, 35)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Size = New System.Drawing.Size(984, 625)
        Me.tabPage1.Text = "Pie"
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel2.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 80.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.flowLayoutPanel1, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.widgetPie, 1, 0)
        Me.tableLayoutPanel2.Dock = Wisej.Web.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(984, 625)
        Me.tableLayoutPanel2.TabIndex = 1
        Me.tableLayoutPanel2.TabStop = True
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.Controls.Add(Me.label1)
        Me.flowLayoutPanel1.Controls.Add(Me.comboBox1)
        Me.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Padding = New Wisej.Web.Padding(20)
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(190, 619)
        Me.flowLayoutPanel1.TabIndex = 1
        Me.flowLayoutPanel1.TabStop = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(23, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(70, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Select year"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'comboBox1
        '
        Me.flowLayoutPanel1.SetFillWeight(Me.comboBox1, 1)
        Me.comboBox1.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016"})
        Me.comboBox1.Location = New System.Drawing.Point(23, 44)
        Me.comboBox1.MinimumSize = New System.Drawing.Size(80, 0)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(144, 22)
        Me.comboBox1.TabIndex = 1
        '
        'widgetPie
        '
        Me.widgetPie.Dock = Wisej.Web.DockStyle.Fill
        Me.widgetPie.InitScript = resources.GetString("widgetPie.InitScript")
        Me.widgetPie.Location = New System.Drawing.Point(199, 3)
        Me.widgetPie.Name = "widgetPie"
        Me.widgetPie.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Me.widgetPie.Size = New System.Drawing.Size(782, 619)
        Me.widgetPie.TabIndex = 0
        Me.widgetPie.Text = "widget1"
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.tableLayoutPanel1)
        Me.tabPage3.Location = New System.Drawing.Point(1, 35)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Size = New System.Drawing.Size(984, 625)
        Me.tabPage3.Text = "QRCodes"
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.panel4, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.panel3, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.panel2, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(984, 625)
        Me.tableLayoutPanel1.TabIndex = 0
        Me.tableLayoutPanel1.TabStop = True
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.tableLayoutPanel3)
        Me.panel4.Controls.Add(Me.widgetQRfreeText)
        Me.panel4.Dock = Wisej.Web.DockStyle.Fill
        Me.panel4.Location = New System.Drawing.Point(495, 315)
        Me.panel4.Name = "panel4"
        Me.panel4.ShowHeader = True
        Me.panel4.Size = New System.Drawing.Size(486, 307)
        Me.panel4.TabIndex = 3
        Me.panel4.TabStop = True
        Me.panel4.Text = "free text"
        '
        'tableLayoutPanel3
        '
        Me.tableLayoutPanel3.ColumnCount = 2
        Me.tableLayoutPanel3.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 60.0!))
        Me.tableLayoutPanel3.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 40.0!))
        Me.tableLayoutPanel3.Controls.Add(Me.button1, 1, 0)
        Me.tableLayoutPanel3.Controls.Add(Me.textBoxQRfreeText, 0, 0)
        Me.tableLayoutPanel3.Location = New System.Drawing.Point(16, 3)
        Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
        Me.tableLayoutPanel3.RowCount = 1
        Me.tableLayoutPanel3.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel3.Size = New System.Drawing.Size(467, 37)
        Me.tableLayoutPanel3.TabIndex = 3
        Me.tableLayoutPanel3.TabStop = True
        '
        'button1
        '
        Me.button1.Anchor = Wisej.Web.AnchorStyles.None
        Me.button1.Location = New System.Drawing.Point(294, 3)
        Me.button1.MinimumSize = New System.Drawing.Size(80, 0)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(158, 31)
        Me.button1.TabIndex = 2
        Me.button1.Text = "create QR"
        '
        'textBoxQRfreeText
        '
        Me.textBoxQRfreeText.Dock = Wisej.Web.DockStyle.Fill
        Me.textBoxQRfreeText.Location = New System.Drawing.Point(3, 3)
        Me.textBoxQRfreeText.Multiline = True
        Me.textBoxQRfreeText.Name = "textBoxQRfreeText"
        Me.textBoxQRfreeText.Size = New System.Drawing.Size(274, 31)
        Me.textBoxQRfreeText.TabIndex = 1
        '
        'widgetQRfreeText
        '
        Me.widgetQRfreeText.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.widgetQRfreeText.InitScript = resources.GetString("widgetQRfreeText.InitScript")
        Me.widgetQRfreeText.Location = New System.Drawing.Point(122, 45)
        Me.widgetQRfreeText.Name = "widgetQRfreeText"
        Me.widgetQRfreeText.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Me.widgetQRfreeText.Size = New System.Drawing.Size(262, 191)
        Me.widgetQRfreeText.TabIndex = 0
        Me.widgetQRfreeText.Text = "widget1"
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.widgetQRurl)
        Me.panel3.Dock = Wisej.Web.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(3, 315)
        Me.panel3.Name = "panel3"
        Me.panel3.ShowHeader = True
        Me.panel3.Size = New System.Drawing.Size(486, 307)
        Me.panel3.TabIndex = 2
        Me.panel3.TabStop = True
        Me.panel3.Text = "url"
        '
        'widgetQRurl
        '
        Me.widgetQRurl.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.widgetQRurl.InitScript = resources.GetString("widgetQRurl.InitScript")
        Me.widgetQRurl.Location = New System.Drawing.Point(99, 45)
        Me.widgetQRurl.Name = "widgetQRurl"
        Me.widgetQRurl.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Me.widgetQRurl.Size = New System.Drawing.Size(263, 191)
        Me.widgetQRurl.TabIndex = 0
        Me.widgetQRurl.Text = "widget1"
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.widgetQRgeo)
        Me.panel2.Dock = Wisej.Web.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(495, 3)
        Me.panel2.Name = "panel2"
        Me.panel2.ShowHeader = True
        Me.panel2.Size = New System.Drawing.Size(486, 306)
        Me.panel2.TabIndex = 1
        Me.panel2.TabStop = True
        Me.panel2.Text = "geo"
        '
        'widgetQRgeo
        '
        Me.widgetQRgeo.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.widgetQRgeo.InitScript = resources.GetString("widgetQRgeo.InitScript")
        Me.widgetQRgeo.Location = New System.Drawing.Point(122, 42)
        Me.widgetQRgeo.Name = "widgetQRgeo"
        Me.widgetQRgeo.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Me.widgetQRgeo.Size = New System.Drawing.Size(262, 191)
        Me.widgetQRgeo.TabIndex = 0
        Me.widgetQRgeo.Text = "widget1"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.widgetQRemail)
        Me.panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.ShowHeader = True
        Me.panel1.Size = New System.Drawing.Size(486, 306)
        Me.panel1.TabIndex = 0
        Me.panel1.TabStop = True
        Me.panel1.Text = "email"
        '
        'widgetQRemail
        '
        Me.widgetQRemail.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.widgetQRemail.InitScript = resources.GetString("widgetQRemail.InitScript")
        Me.widgetQRemail.Location = New System.Drawing.Point(99, 42)
        Me.widgetQRemail.Name = "widgetQRemail"
        Me.widgetQRemail.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Me.widgetQRemail.Size = New System.Drawing.Size(263, 191)
        Me.widgetQRemail.TabIndex = 0
        Me.widgetQRemail.Text = "widget1"
        '
        'Window1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 661)
        Me.CloseBox = False
        Me.Controls.Add(Me.tabControl1)
        Me.MinimizeBox = False
        Me.Name = "Window1"
        Me.Text = "Integration 3 - Telerik Kendo UI"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.flowLayoutPanel1.PerformLayout()
        Me.tabPage3.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.panel4.ResumeLayout(False)
        Me.tableLayoutPanel3.ResumeLayout(False)
        Me.tableLayoutPanel3.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents tabControl1 As Wisej.Web.TabControl
    Friend WithEvents tabPage1 As Wisej.Web.TabPage
    Friend WithEvents widgetPie As Wisej.Web.Widget
    Friend WithEvents tabPage2 As Wisej.Web.TabPage
    Friend WithEvents tabPage3 As Wisej.Web.TabPage
    Friend WithEvents tableLayoutPanel1 As Wisej.Web.TableLayoutPanel
    Friend WithEvents panel4 As Wisej.Web.Panel
    Friend WithEvents panel3 As Wisej.Web.Panel
    Friend WithEvents panel2 As Wisej.Web.Panel
    Friend WithEvents panel1 As Wisej.Web.Panel
    Friend WithEvents textBoxQRfreeText As Wisej.Web.TextBox
    Friend WithEvents widgetQRfreeText As Wisej.Web.Widget
    Friend WithEvents widgetQRurl As Wisej.Web.Widget
    Friend WithEvents widgetQRgeo As Wisej.Web.Widget
    Friend WithEvents widgetQRemail As Wisej.Web.Widget
    Friend WithEvents button1 As Wisej.Web.Button
    Friend WithEvents tableLayoutPanel2 As Wisej.Web.TableLayoutPanel
    Friend WithEvents flowLayoutPanel1 As Wisej.Web.FlowLayoutPanel
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents comboBox1 As Wisej.Web.ComboBox
    Friend WithEvents tableLayoutPanel3 As Wisej.Web.TableLayoutPanel
    Private WithEvents widgetDonut As Widget
End Class
