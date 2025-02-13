<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomPainting
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
        mandelbrotPanel1 = New MandelbrotPanel()
        panel1 = New Web.Panel()
        panel2 = New Web.Panel()
        canvas1 = New Web.Canvas()
        panel1.SuspendLayout()
        panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' mandelbrotPanel1
        ' 
        mandelbrotPanel1.Dock = Web.DockStyle.Fill
        mandelbrotPanel1.Focusable = False
        mandelbrotPanel1.Location = New Drawing.Point(0, 0)
        mandelbrotPanel1.Name = "mandelbrotPanel1"
        mandelbrotPanel1.Size = New Drawing.Size(369, 373)
        mandelbrotPanel1.TabIndex = 0
        ' 
        ' panel1
        ' 
        panel1.CollapseSide = Web.HeaderPosition.Left
        panel1.Controls.Add(mandelbrotPanel1)
        panel1.HeaderBackColor = Drawing.Color.FromArgb(102, 63, 191)
        panel1.HeaderSize = 38
        panel1.Location = New Drawing.Point(24, 33)
        panel1.Name = "panel1"
        panel1.ShowCloseButton = False
        panel1.ShowHeader = True
        panel1.Size = New Drawing.Size(369, 411)
        panel1.TabIndex = 1
        panel1.Text = "Mandelbrot"
        ' 
        ' panel2
        ' 
        panel2.CollapseSide = Web.HeaderPosition.Left
        panel2.Controls.Add(canvas1)
        panel2.HeaderBackColor = Drawing.Color.FromArgb(79, 191, 63)
        panel2.HeaderSize = 38
        panel2.Location = New Drawing.Point(425, 33)
        panel2.Name = "panel2"
        panel2.ShowCloseButton = False
        panel2.ShowHeader = True
        panel2.Size = New Drawing.Size(369, 411)
        panel2.TabIndex = 2
        panel2.Text = "Canvas"
        ' 
        ' canvas1
        ' 
        canvas1.Dock = Web.DockStyle.Fill
        canvas1.Location = New Drawing.Point(0, 0)
        canvas1.Name = "canvas1"
        canvas1.Size = New Drawing.Size(369, 373)
        AddHandler canvas1.Redraw, New EventHandler(AddressOf canvas1_Redraw)
        ' 
        ' CustomPainting
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(821, 477)
        Controls.Add(panel2)
        Controls.Add(panel1)
        FormBorderStyle = Web.FormBorderStyle.Fixed
        IconSource = "resource.wx/Wisej.Ext.MaterialDesign/painter-palette.svg?color=#00FCFF"
        Name = "CustomPainting"
        Text = "Custom Painting Example"
        panel1.ResumeLayout(False)
        panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

#End Region

    Private mandelbrotPanel1 As MandelbrotPanel
    Private panel1 As Web.Panel
    Private panel2 As Web.Panel
    Private canvas1 As Web.Canvas
End Class
