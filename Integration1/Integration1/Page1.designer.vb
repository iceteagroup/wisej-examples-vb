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
        Dim Package9 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package10 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package11 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package12 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package13 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package14 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package15 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package16 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package17 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package18 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package19 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package20 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package21 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package22 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package23 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package24 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Me.widgetPivotGrid = New Wisej.Web.Widget()
        Me.tabControl1 = New Wisej.Web.TabControl()
        Me.tabPage1 = New Wisej.Web.TabPage()
        Me.tabPage2 = New Wisej.Web.TabPage()
        Me.tableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
        Me.widgetCircularGage = New Wisej.Web.Widget()
        Me.btnHeatUp = New Wisej.Web.Button()
        Me.btnCoolDown = New Wisej.Web.Button()
        Me.tabPage3 = New Wisej.Web.TabPage()
        Me.widgetGallery = New Wisej.Web.Widget()
        Me.tabPage4 = New Wisej.Web.TabPage()
        Me.tableLayoutPanel2 = New Wisej.Web.TableLayoutPanel()
        Me.widgetBarGauge = New Wisej.Web.Widget()
        Me.comboBox1 = New Wisej.Web.ComboBox()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.tabPage4.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'widgetPivotGrid
        '
        Me.widgetPivotGrid.Dock = Wisej.Web.DockStyle.Fill
        Me.widgetPivotGrid.InitScript = resources.GetString("widgetPivotGrid.InitScript")
        Me.widgetPivotGrid.Location = New System.Drawing.Point(0, 0)
        Me.widgetPivotGrid.Name = "widgetPivotGrid"
        Me.widgetPivotGrid.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Package1.Name = "jquery.js"
        Package1.Source = "https://code.jquery.com/jquery-3.1.0.min.js"
        Package2.Name = "jszip.js"
        Package2.Source = "https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js"
        Package3.Name = "dxall.js"
        Package3.Source = "https://cdn3.devexpress.com/jslib/16.2.6/js/dx.all.js"
        Package4.Name = "dxspa.css"
        Package4.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.spa.css"
        Package5.Name = "dxcommon.css"
        Package5.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.common.css"
        Package6.Name = "dxlight.css"
        Package6.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.light.css"
        Me.widgetPivotGrid.Packages.Add(Package1)
        Me.widgetPivotGrid.Packages.Add(Package2)
        Me.widgetPivotGrid.Packages.Add(Package3)
        Me.widgetPivotGrid.Packages.Add(Package4)
        Me.widgetPivotGrid.Packages.Add(Package5)
        Me.widgetPivotGrid.Packages.Add(Package6)
        Me.widgetPivotGrid.Size = New System.Drawing.Size(949, 606)
        Me.widgetPivotGrid.TabIndex = 0
        Me.widgetPivotGrid.Text = "widget1"
        '
        'tabControl1
        '
        Me.tabControl1.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Controls.Add(Me.tabPage4)
        Me.tabControl1.Location = New System.Drawing.Point(89, 77)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.PageInsets = New Wisej.Web.Padding(1, 30, 1, 1)
        Me.tabControl1.Size = New System.Drawing.Size(951, 637)
        Me.tabControl1.TabIndex = 1
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.widgetPivotGrid)
        Me.tabPage1.Location = New System.Drawing.Point(1, 30)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Size = New System.Drawing.Size(949, 606)
        Me.tabPage1.Text = "dxPivotGrid"
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.tableLayoutPanel1)
        Me.tabPage2.Location = New System.Drawing.Point(1, 30)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Size = New System.Drawing.Size(949, 606)
        Me.tabPage2.Text = "dxCircularGauge"
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 3
        Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 80.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.widgetCircularGage, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.btnHeatUp, 2, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.btnCoolDown, 1, 0)
        Me.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(949, 606)
        Me.tableLayoutPanel1.TabIndex = 1
        Me.tableLayoutPanel1.TabStop = True
        '
        'widgetCircularGage
        '
        Me.widgetCircularGage.Dock = Wisej.Web.DockStyle.Fill
        Me.widgetCircularGage.InitScript = resources.GetString("widgetCircularGage.InitScript")
        Me.widgetCircularGage.Location = New System.Drawing.Point(3, 3)
        Me.widgetCircularGage.Name = "widgetCircularGage"
        Me.widgetCircularGage.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Package7.Name = "jquery.js"
        Package7.Source = "https://code.jquery.com/jquery-3.1.0.min.js"
        Package8.Name = "jszip.js"
        Package8.Source = "https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js"
        Package9.Name = "dxall.js"
        Package9.Source = "https://cdn3.devexpress.com/jslib/16.2.6/js/dx.all.js"
        Package10.Name = "dxspa.css"
        Package10.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.spa.css"
        Package11.Name = "dxcommon.css"
        Package11.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.common.css"
        Package12.Name = "dxlight.css"
        Package12.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.light.css"
        Me.widgetCircularGage.Packages.Add(Package7)
        Me.widgetCircularGage.Packages.Add(Package8)
        Me.widgetCircularGage.Packages.Add(Package9)
        Me.widgetCircularGage.Packages.Add(Package10)
        Me.widgetCircularGage.Packages.Add(Package11)
        Me.widgetCircularGage.Packages.Add(Package12)
        Me.widgetCircularGage.Size = New System.Drawing.Size(753, 600)
        Me.widgetCircularGage.TabIndex = 0
        Me.widgetCircularGage.Text = "widget2"
        '
        'btnHeatUp
        '
        Me.btnHeatUp.Anchor = Wisej.Web.AnchorStyles.Top
        Me.btnHeatUp.ImageSource = "window-maximize"
        Me.btnHeatUp.Location = New System.Drawing.Point(892, 15)
        Me.btnHeatUp.Margin = New Wisej.Web.Padding(15)
        Me.btnHeatUp.Name = "btnHeatUp"
        Me.btnHeatUp.Repeat = True
        Me.btnHeatUp.Size = New System.Drawing.Size(18, 32)
        Me.btnHeatUp.TabIndex = 1
        '
        'btnCoolDown
        '
        Me.btnCoolDown.Anchor = Wisej.Web.AnchorStyles.Top
        Me.btnCoolDown.ImageSource = "window-minimize"
        Me.btnCoolDown.Location = New System.Drawing.Point(798, 15)
        Me.btnCoolDown.Margin = New Wisej.Web.Padding(15)
        Me.btnCoolDown.Name = "btnCoolDown"
        Me.btnCoolDown.Repeat = True
        Me.btnCoolDown.Size = New System.Drawing.Size(16, 32)
        Me.btnCoolDown.TabIndex = 2
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.widgetGallery)
        Me.tabPage3.Location = New System.Drawing.Point(1, 30)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New Wisej.Web.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(949, 606)
        Me.tabPage3.Text = "dxGallery"
        '
        'widgetGallery
        '
        Me.widgetGallery.Dock = Wisej.Web.DockStyle.Fill
        Me.widgetGallery.InitScript = resources.GetString("widgetGallery.InitScript")
        Me.widgetGallery.Location = New System.Drawing.Point(3, 3)
        Me.widgetGallery.Name = "widgetGallery"
        Me.widgetGallery.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Package13.Name = "jquery.js"
        Package13.Source = "https://code.jquery.com/jquery-3.1.0.min.js"
        Package14.Name = "jszip.js"
        Package14.Source = "https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js"
        Package15.Name = "dxall.js"
        Package15.Source = "https://cdn3.devexpress.com/jslib/16.2.6/js/dx.all.js"
        Package16.Name = "dxspa.css"
        Package16.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.spa.css"
        Package17.Name = "dxcommon.css"
        Package17.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.common.css"
        Package18.Name = "dxlight.css"
        Package18.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.light.css"
        Me.widgetGallery.Packages.Add(Package13)
        Me.widgetGallery.Packages.Add(Package14)
        Me.widgetGallery.Packages.Add(Package15)
        Me.widgetGallery.Packages.Add(Package16)
        Me.widgetGallery.Packages.Add(Package17)
        Me.widgetGallery.Packages.Add(Package18)
        Me.widgetGallery.Size = New System.Drawing.Size(943, 600)
        Me.widgetGallery.TabIndex = 0
        Me.widgetGallery.Text = "widget1"
        '
        'tabPage4
        '
        Me.tabPage4.Controls.Add(Me.tableLayoutPanel2)
        Me.tabPage4.Location = New System.Drawing.Point(1, 30)
        Me.tabPage4.Name = "tabPage4"
        Me.tabPage4.Padding = New Wisej.Web.Padding(3)
        Me.tabPage4.Size = New System.Drawing.Size(949, 606)
        Me.tabPage4.Text = "dxBarGauge"
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel2.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 80.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.widgetBarGauge, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.comboBox1, 1, 0)
        Me.tableLayoutPanel2.Dock = Wisej.Web.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(943, 600)
        Me.tableLayoutPanel2.TabIndex = 1
        Me.tableLayoutPanel2.TabStop = True
        '
        'widgetBarGauge
        '
        Me.widgetBarGauge.Dock = Wisej.Web.DockStyle.Fill
        Me.widgetBarGauge.InitScript = resources.GetString("widgetBarGauge.InitScript")
        Me.widgetBarGauge.Location = New System.Drawing.Point(3, 3)
        Me.widgetBarGauge.Name = "widgetBarGauge"
        Me.widgetBarGauge.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Package19.Name = "jquery.js"
        Package19.Source = "https://code.jquery.com/jquery-3.1.0.min.js"
        Package20.Name = "jszip.js"
        Package20.Source = "https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js"
        Package21.Name = "dxall.js"
        Package21.Source = "https://cdn3.devexpress.com/jslib/16.2.6/js/dx.all.js"
        Package22.Name = "dxspa.css"
        Package22.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.spa.css"
        Package23.Name = "dxcommon.css"
        Package23.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.common.css"
        Package24.Name = "dxlight.css"
        Package24.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.light.css"
        Me.widgetBarGauge.Packages.Add(Package19)
        Me.widgetBarGauge.Packages.Add(Package20)
        Me.widgetBarGauge.Packages.Add(Package21)
        Me.widgetBarGauge.Packages.Add(Package22)
        Me.widgetBarGauge.Packages.Add(Package23)
        Me.widgetBarGauge.Packages.Add(Package24)
        Me.widgetBarGauge.Size = New System.Drawing.Size(748, 594)
        Me.widgetBarGauge.TabIndex = 0
        Me.widgetBarGauge.Text = "widget1"
        '
        'comboBox1
        '
        Me.comboBox1.AutoSize = False
        Me.comboBox1.Items.AddRange(New Object() {"Default", "Soft Pastel", "Harmony Light", "Pastel", "Bright", "Soft", "Ocean", "Vintage", "Violet"})
        Me.comboBox1.Location = New System.Drawing.Point(769, 15)
        Me.comboBox1.Margin = New Wisej.Web.Padding(15)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(62, 34)
        Me.comboBox1.TabIndex = 1
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.tabControl1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(1135, 796)
        Me.Text = "Page1"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tabPage3.ResumeLayout(False)
        Me.tabPage4.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents widgetPivotGrid As Wisej.Web.Widget
    Friend WithEvents tabControl1 As Wisej.Web.TabControl
    Friend WithEvents tabPage1 As Wisej.Web.TabPage
    Friend WithEvents tabPage2 As Wisej.Web.TabPage
    Friend WithEvents widgetCircularGage As Wisej.Web.Widget
    Friend WithEvents tableLayoutPanel1 As Wisej.Web.TableLayoutPanel
    Friend WithEvents btnHeatUp As Wisej.Web.Button
    Friend WithEvents btnCoolDown As Wisej.Web.Button
    Friend WithEvents tabPage3 As Wisej.Web.TabPage
    Friend WithEvents widgetGallery As Wisej.Web.Widget
    Friend WithEvents tabPage4 As Wisej.Web.TabPage
    Friend WithEvents widgetBarGauge As Wisej.Web.Widget
    Friend WithEvents tableLayoutPanel2 As Wisej.Web.TableLayoutPanel
    Friend WithEvents comboBox1 As Wisej.Web.ComboBox
End Class
