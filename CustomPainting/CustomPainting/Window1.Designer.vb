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
        Me.panel1 = New Wisej.Web.Panel()
        Me.mandelbrotPanel1 = New CustomPainting.MandelbrotPanel()
        Me.button1 = New Wisej.Web.Button()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.panel1.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.panel1.Controls.Add(Me.mandelbrotPanel1)
        Me.panel1.Location = New System.Drawing.Point(30, 30)
        Me.panel1.Name = "panel1"
        Me.panel1.ShowCloseButton = False
        Me.panel1.ShowHeader = True
        Me.panel1.Size = New System.Drawing.Size(599, 324)
        Me.panel1.TabIndex = 2
        Me.panel1.TabStop = True
        Me.panel1.Text = "Mandelbrot Panel (resize the window to see the redraw)"
        '
        'mandelbrotPanel1
        '
        Me.mandelbrotPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.mandelbrotPanel1.Name = "mandelbrotPanel1"
        Me.mandelbrotPanel1.Size = New System.Drawing.Size(593, 290)
        Me.mandelbrotPanel1.TabIndex = 3
        '
        'button1
        '
        Me.button1.Anchor = CType(((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.button1.Location = New System.Drawing.Point(30, 373)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(599, 72)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Yes, you can paint here too!"
        '
        'Window1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.panel1)
        Me.MinimizeBox = False
        Me.Name = "Window1"
        Me.Text = "Window1"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents panel1 As Wisej.Web.Panel
    Friend WithEvents button1 As Wisej.Web.Button
    Friend WithEvents mandelbrotPanel1 As MandelbrotPanel
End Class
