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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page1))
        Dim Package1 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package2 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Dim Package3 As Wisej.Web.Widget.Package = New Wisej.Web.Widget.Package()
        Me.javaScript1 = New Wisej.Web.JavaScript(Me.components)
        Me.widgetInput = New Wisej.Web.Widget()
        Me.widgetColorPicker = New Wisej.Web.Widget()
        Me.label1 = New Wisej.Web.Label()
        Me.widgetTreeMap = New Wisej.Web.Widget()
        Me.widgetTagCloud = New Wisej.Web.Widget()
        Me.SuspendLayout()
        '
        'widgetInput
        '
        Me.widgetInput.InitScript = resources.GetString("widgetInput.InitScript")
        Me.widgetInput.Location = New System.Drawing.Point(27, 45)
        Me.widgetInput.Name = "widgetInput"
        Me.widgetInput.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Package1.Integrity = Nothing
        Package1.Name = "jquery.min.js"
        Package1.Source = "https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"
        Package2.Integrity = Nothing
        Package2.Name = "jqx-all.js"
        Package2.Source = "https://jqwidgets.com/public/jqwidgets/jqx-all.js"
        Package3.Integrity = Nothing
        Package3.Name = "jqx.base.css"
        Package3.Source = "https://jqwidgets.com/public/jqwidgets/styles/jqx.base.css"
        Me.widgetInput.Packages.Add(Package1)
        Me.widgetInput.Packages.Add(Package2)
        Me.widgetInput.Packages.Add(Package3)
        Me.widgetInput.Size = New System.Drawing.Size(213, 45)
        Me.widgetInput.TabIndex = 0
        Me.widgetInput.Text = "widgetInput"
        '
        'widgetColorPicker
        '
        Me.widgetColorPicker.InitScript = resources.GetString("widgetColorPicker.InitScript")
        Me.widgetColorPicker.Location = New System.Drawing.Point(257, 20)
        Me.widgetColorPicker.Name = "widgetColorPicker"
        Me.widgetColorPicker.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Me.widgetColorPicker.Packages.Add(Package1)
        Me.widgetColorPicker.Packages.Add(Package2)
        Me.widgetColorPicker.Packages.Add(Package3)
        Me.widgetColorPicker.Size = New System.Drawing.Size(277, 256)
        Me.widgetColorPicker.TabIndex = 1
        Me.widgetColorPicker.Text = "widgetColorPicker"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(27, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(172, 15)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Type a dish name, e.g. Pizza"
        '
        'widgetTreeMap
        '
        Me.widgetTreeMap.InitScript = resources.GetString("widgetTreeMap.InitScript")
        Me.widgetTreeMap.Location = New System.Drawing.Point(27, 282)
        Me.widgetTreeMap.Name = "widgetTreeMap"
        Me.widgetTreeMap.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Me.widgetTreeMap.Packages.Add(Package1)
        Me.widgetTreeMap.Packages.Add(Package2)
        Me.widgetTreeMap.Packages.Add(Package3)
        Me.widgetTreeMap.Size = New System.Drawing.Size(900, 600)
        Me.widgetTreeMap.TabIndex = 3
        Me.widgetTreeMap.Text = "widgetTreeMap"
        '
        'widgetTagCloud
        '
        Me.widgetTagCloud.InitScript = resources.GetString("widgetTagCloud.InitScript")
        Me.widgetTagCloud.Location = New System.Drawing.Point(523, 22)
        Me.widgetTagCloud.Name = "widgetTagCloud"
        Me.widgetTagCloud.Options = CType(Wisej.Core.WisejSerializer.Parse("{}"), Wisej.Core.DynamicObject)
        Me.widgetTagCloud.Packages.Add(Package1)
        Me.widgetTagCloud.Packages.Add(Package2)
        Me.widgetTagCloud.Packages.Add(Package3)
        Me.widgetTagCloud.Size = New System.Drawing.Size(403, 254)
        Me.widgetTagCloud.TabIndex = 4
        Me.widgetTagCloud.Text = "widget1"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.widgetTagCloud)
        Me.Controls.Add(Me.widgetTreeMap)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.widgetColorPicker)
        Me.Controls.Add(Me.widgetInput)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(828, 731)
        Me.Text = "Integration 4 - jQWidgets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents javaScript1 As Wisej.Web.JavaScript
    Friend WithEvents widgetInput As Wisej.Web.Widget
    Friend WithEvents widgetColorPicker As Wisej.Web.Widget
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents widgetTreeMap As Wisej.Web.Widget
    Friend WithEvents widgetTagCloud As Wisej.Web.Widget
End Class
