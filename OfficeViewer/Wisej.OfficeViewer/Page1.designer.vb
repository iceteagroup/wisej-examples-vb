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
        Me.panel1 = New Wisej.Web.Panel()
        Me.button3 = New Wisej.Web.Button()
        Me.button2 = New Wisej.Web.Button()
        Me.button1 = New Wisej.Web.Button()
        Me.docViewer = New Wisej.Web.Ext.OfficeViewer.OfficeViewer()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.DimGray
        Me.panel1.Controls.Add(Me.button3)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Dock = Wisej.Web.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New Wisej.Web.Padding(10)
        Me.panel1.Size = New System.Drawing.Size(166, 626)
        Me.panel1.TabIndex = 0
        Me.panel1.TabStop = True
        '
        'button3
        '
        Me.button3.Dock = Wisej.Web.DockStyle.Top
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.ImageSource = "Images/powerpoint.svg"
        Me.button3.Location = New System.Drawing.Point(10, 150)
        Me.button3.Name = "button3"
        Me.button3.Padding = New Wisej.Web.Padding(20, 0, 10, 0)
        Me.button3.Size = New System.Drawing.Size(146, 70)
        Me.button3.TabIndex = 2
        Me.button3.Text = "PowerPoint"
        '
        'button2
        '
        Me.button2.Dock = Wisej.Web.DockStyle.Top
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.ImageSource = "Images/excel.svg"
        Me.button2.Location = New System.Drawing.Point(10, 80)
        Me.button2.Name = "button2"
        Me.button2.Padding = New Wisej.Web.Padding(20, 0, 10, 0)
        Me.button2.Size = New System.Drawing.Size(146, 70)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Excel"
        '
        'button1
        '
        Me.button1.Dock = Wisej.Web.DockStyle.Top
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.ImageSource = "Images/word.svg"
        Me.button1.Location = New System.Drawing.Point(10, 10)
        Me.button1.Name = "button1"
        Me.button1.Padding = New Wisej.Web.Padding(20, 0, 10, 0)
        Me.button1.Size = New System.Drawing.Size(146, 70)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Word"
        '
        'docViewer
        '
        Me.docViewer.Dock = Wisej.Web.DockStyle.Fill
        Me.docViewer.Location = New System.Drawing.Point(166, 0)
        Me.docViewer.Name = "docViewer"
        Me.docViewer.Size = New System.Drawing.Size(766, 626)
        Me.docViewer.TabIndex = 1
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.docViewer)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(932, 626)
        Me.Text = "Page1"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents panel1 As Web.Panel
    Friend WithEvents docViewer As Web.Ext.OfficeViewer.OfficeViewer
    Friend WithEvents button3 As Web.Button
    Friend WithEvents button2 As Web.Button
    Friend WithEvents button1 As Web.Button
End Class
