Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window1
    Inherits Wisej.Web.Form
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer


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


#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        panel1 = New Wisej.Web.Panel()
        button1 = New Wisej.Web.Button()
        mandelbrotPanel1 = New MandelbrotPanel()
        panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' panel1
        ' 
        panel1.Anchor = Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left Or Wisej.Web.AnchorStyles.Right
        panel1.BorderStyle = Wisej.Web.BorderStyle.Double
        panel1.Controls.Add(mandelbrotPanel1)
        panel1.Location = New Drawing.Point(30, 30)
        panel1.Name = "panel1"
        panel1.ShowCloseButton = False
        panel1.ShowHeader = True
        panel1.Size = New Drawing.Size(599, 324)
        panel1.TabIndex = 2
        panel1.Text = "Mandelbrot Panel (resize the window to see the redraw)"
        ' 
        ' button1
        ' 
        button1.Anchor = Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left Or Wisej.Web.AnchorStyles.Right
        button1.Location = New Drawing.Point(30, 373)
        button1.Name = "button1"
        button1.Size = New Drawing.Size(599, 72)
        button1.TabIndex = 1
        button1.Text = "Yes, you can paint here too!"
        AddHandler button1.Paint, New Wisej.Web.PaintEventHandler(AddressOf button1_Paint)
        ' 
        ' mandelbrotPanel1
        ' 
        mandelbrotPanel1.Dock = Wisej.Web.DockStyle.Fill
        mandelbrotPanel1.Location = New Drawing.Point(0, 0)
        mandelbrotPanel1.Name = "mandelbrotPanel1"
        mandelbrotPanel1.Size = New Drawing.Size(597, 294)
        mandelbrotPanel1.TabIndex = 3
        ' 
        ' Window1
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6.0F, 17.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(650, 461)
        ControlBox = False
        Controls.Add(button1)
        Controls.Add(panel1)
        MinimizeBox = False
        Name = "Window1"
        Text = "Window1"
        panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub


#End Region

    Friend WithEvents panel1 As Wisej.Web.Panel
    Friend WithEvents button1 As Wisej.Web.Button
    Friend WithEvents mandelbrotPanel1 As MandelbrotPanel
End Class
