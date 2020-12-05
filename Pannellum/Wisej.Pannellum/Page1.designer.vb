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
        Me.panel1 = New Wisej.Web.Panel()
        Me.button5 = New Wisej.Web.Button()
        Me.button4 = New Wisej.Web.Button()
        Me.button3 = New Wisej.Web.Button()
        Me.button2 = New Wisej.Web.Button()
        Me.button1 = New Wisej.Web.Button()
        Me.pannellum1 = New Wisej.Web.Ext.Pannellum.Pannellum()
        Me.panel2 = New Wisej.Web.Panel()
        Me.panel3 = New Wisej.Web.Panel()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.AutoShow = Wisej.Web.PanelAutoShowMode.OnPointerOver
        Me.panel1.AutoSize = True
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(124, 91, 91, 91)
        Me.panel1.Collapsed = True
        Me.panel1.CollapseSide = Wisej.Web.HeaderPosition.Left
        Me.panel1.Controls.Add(Me.button5)
        Me.panel1.Controls.Add(Me.button4)
        Me.panel1.Controls.Add(Me.button3)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center
        Me.panel1.HeaderBackColor = System.Drawing.Color.FromArgb(61, 61, 61)
        Me.panel1.HeaderForeColor = System.Drawing.Color.FromArgb(244, 244, 244)
        Me.panel1.HeaderSize = 48
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.ShowHeader = True
        Me.panel1.Size = New System.Drawing.Size(48, 874)
        Me.panel1.TabIndex = 0
        Me.panel1.TabStop = True
        Me.panel1.Text = "Examples"
        '
        'button5
        '
        Me.button5.Dock = Wisej.Web.DockStyle.Top
        Me.button5.Location = New System.Drawing.Point(0, 256)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(0, 64)
        Me.button5.TabIndex = 4
        Me.button5.Text = "Mutlires"
        '
        'button4
        '
        Me.button4.Dock = Wisej.Web.DockStyle.Top
        Me.button4.Location = New System.Drawing.Point(0, 192)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(0, 64)
        Me.button4.TabIndex = 3
        Me.button4.Text = "Hot spots"
        '
        'button3
        '
        Me.button3.Dock = Wisej.Web.DockStyle.Top
        Me.button3.Location = New System.Drawing.Point(0, 128)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(0, 64)
        Me.button3.TabIndex = 2
        Me.button3.Text = "Cube Map"
        '
        'button2
        '
        Me.button2.Dock = Wisej.Web.DockStyle.Top
        Me.button2.Location = New System.Drawing.Point(0, 64)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(0, 64)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Auto Rotate"
        '
        'button1
        '
        Me.button1.Dock = Wisej.Web.DockStyle.Top
        Me.button1.Location = New System.Drawing.Point(0, 0)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(0, 64)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Simple"
        '
        'pannellum1
        '
        Me.pannellum1.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pannellum1.Dock = Wisej.Web.DockStyle.Fill
        Me.pannellum1.Location = New System.Drawing.Point(5, 5)
        Me.pannellum1.Name = "pannellum1"
        Me.pannellum1.Options = CType(Wisej.Core.WisejSerializer.Parse(resources.GetString("pannellum1.Options")), Wisej.Core.DynamicObject)
        Me.pannellum1.Size = New System.Drawing.Size(1220, 613)
        Me.pannellum1.TabIndex = 1
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.panel1)
        Me.panel2.Controls.Add(Me.panel3)
        Me.panel2.Dock = Wisej.Web.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1230, 623)
        Me.panel2.TabIndex = 4
        Me.panel2.TabStop = True
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.pannellum1)
        Me.panel3.Dock = Wisej.Web.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(0, 0)
        Me.panel3.Name = "panel3"
        Me.panel3.Padding = New Wisej.Web.Padding(5)
        Me.panel3.Size = New System.Drawing.Size(1230, 623)
        Me.panel3.TabIndex = 1
        Me.panel3.TabStop = True
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.panel2)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(1230, 623)
        Me.Text = "Page1"
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents panel1 As Web.Panel
    Friend WithEvents button1 As Web.Button
    Friend WithEvents pannellum1 As Web.Ext.Pannellum.Pannellum
    Friend WithEvents button4 As Web.Button
    Friend WithEvents button3 As Web.Button
    Friend WithEvents button2 As Web.Button
    Friend WithEvents button5 As Web.Button
    Friend WithEvents panel2 As Web.Panel
    Friend WithEvents panel3 As Web.Panel
End Class
