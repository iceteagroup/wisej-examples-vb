Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ThemePicker
    Inherits UserControl
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
        flowLayoutPanel1 = New Web.FlowLayoutPanel()
        pictureBox1 = New Web.PictureBox()
        pictureBox2 = New Web.PictureBox()
        pictureBox3 = New Web.PictureBox()
        pictureBox4 = New Web.PictureBox()
        flowLayoutPanel1.SuspendLayout()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' flowLayoutPanel1
        ' 
        flowLayoutPanel1.AutoScroll = True
        flowLayoutPanel1.Controls.Add(pictureBox1)
        flowLayoutPanel1.Controls.Add(pictureBox2)
        flowLayoutPanel1.Controls.Add(pictureBox3)
        flowLayoutPanel1.Controls.Add(pictureBox4)
        flowLayoutPanel1.Dock = Web.DockStyle.Fill
        flowLayoutPanel1.Location = New Drawing.Point(0, 0)
        flowLayoutPanel1.Name = "flowLayoutPanel1"
        flowLayoutPanel1.Size = New Drawing.Size(340, 70)
        flowLayoutPanel1.TabIndex = 0
        ' 
        ' pictureBox1
        ' 
        pictureBox1.Cursor = Web.Cursors.Hand
        pictureBox1.ImageSource = "Images/Blue-1.png"
        pictureBox1.Location = New Drawing.Point(10, 10)
        pictureBox1.Margin = New Web.Padding(10)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Drawing.Size(64, 45)
        pictureBox1.SizeMode = Web.PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 0
        AddHandler pictureBox1.Click, New EventHandler(AddressOf pictureBox_Click)
        ' 
        ' pictureBox2
        ' 
        pictureBox2.Cursor = Web.Cursors.Hand
        pictureBox2.ImageSource = "Images/Clear-2.png"
        pictureBox2.Location = New Drawing.Point(94, 10)
        pictureBox2.Margin = New Web.Padding(10)
        pictureBox2.Name = "pictureBox2"
        pictureBox2.Size = New Drawing.Size(64, 45)
        pictureBox2.SizeMode = Web.PictureBoxSizeMode.Zoom
        pictureBox2.TabIndex = 1
        AddHandler pictureBox2.Click, New EventHandler(AddressOf pictureBox_Click)
        ' 
        ' pictureBox3
        ' 
        pictureBox3.Cursor = Web.Cursors.Hand
        pictureBox3.ImageSource = "Images/Material-3.png"
        pictureBox3.Location = New Drawing.Point(178, 10)
        pictureBox3.Margin = New Web.Padding(10)
        pictureBox3.Name = "pictureBox3"
        pictureBox3.Size = New Drawing.Size(64, 45)
        pictureBox3.SizeMode = Web.PictureBoxSizeMode.Zoom
        pictureBox3.TabIndex = 2
        AddHandler pictureBox3.Click, New EventHandler(AddressOf pictureBox_Click)
        ' 
        ' pictureBox4
        ' 
        pictureBox4.Cursor = Web.Cursors.Hand
        pictureBox4.ImageSource = "Images/Classic-2.png"
        pictureBox4.Location = New Drawing.Point(262, 10)
        pictureBox4.Margin = New Web.Padding(10)
        pictureBox4.Name = "pictureBox4"
        pictureBox4.Size = New Drawing.Size(64, 45)
        pictureBox4.SizeMode = Web.PictureBoxSizeMode.Zoom
        pictureBox4.TabIndex = 3
        AddHandler pictureBox4.Click, New EventHandler(AddressOf pictureBox_Click)
        ' 
        ' ThemePicker
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        Controls.Add(flowLayoutPanel1)
        Name = "ThemePicker"
        Size = New Drawing.Size(340, 70)
        flowLayoutPanel1.ResumeLayout(False)
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub


#End Region

    Friend WithEvents flowLayoutPanel1 As Web.FlowLayoutPanel
    Friend WithEvents pictureBox1 As Web.PictureBox
    Friend WithEvents pictureBox2 As Web.PictureBox
    Friend WithEvents pictureBox3 As Web.PictureBox
    Friend WithEvents pictureBox4 As Web.PictureBox
End Class
