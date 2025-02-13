<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartPopup
    Inherits Wisej.Web.UserPopup
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
        components = New ComponentModel.Container()
        label1 = New Web.Label()
        flowLayoutPanel1 = New Web.FlowLayoutPanel()
        btnBackgroundTasks = New Web.Button()
        imageList = New Web.ImageList(components)
        btnIntegration = New Web.Button()
        button1 = New Web.Button()
        button2 = New Web.Button()
        button3 = New Web.Button()
        button4 = New Web.Button()
        flowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.BackColor = Drawing.Color.Transparent
        label1.Font = New Drawing.Font("default", 30.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        label1.ForeColor = Drawing.Color.White
        label1.Location = New Drawing.Point(29, 18)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(337, 57)
        label1.TabIndex = 0
        label1.Text = "Examples"
        label1.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' flowLayoutPanel1
        ' 
        flowLayoutPanel1.BackColor = Drawing.Color.Transparent
        flowLayoutPanel1.Controls.Add(btnBackgroundTasks)
        flowLayoutPanel1.Controls.Add(btnIntegration)
        flowLayoutPanel1.Controls.Add(button1)
        flowLayoutPanel1.Controls.Add(button2)
        flowLayoutPanel1.Controls.Add(button3)
        flowLayoutPanel1.Controls.Add(button4)
        flowLayoutPanel1.Location = New Drawing.Point(29, 91)
        flowLayoutPanel1.Name = "flowLayoutPanel1"
        flowLayoutPanel1.Size = New Drawing.Size(451, 241)
        flowLayoutPanel1.TabIndex = 1
        ' 
        ' btnBackgroundTasks
        ' 
        btnBackgroundTasks.ImageAlign = Drawing.ContentAlignment.MiddleLeft
        btnBackgroundTasks.ImageList = imageList
        btnBackgroundTasks.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/settings-cogwheel-button.svg?color=#FFD700"
        btnBackgroundTasks.Location = New Drawing.Point(3, 3)
        btnBackgroundTasks.Name = "btnBackgroundTasks"
        btnBackgroundTasks.Padding = New Web.Padding(30, 0, 10, 0)
        btnBackgroundTasks.Size = New Drawing.Size(205, 68)
        btnBackgroundTasks.TabIndex = 0
        btnBackgroundTasks.Text = "Background Tasks"
        AddHandler btnBackgroundTasks.Click, New EventHandler(AddressOf btnBackgroundTasks_Click)
        ' 
        ' imageList
        ' 
        imageList.ImageSize = New Drawing.Size(38, 38)
        ' 
        ' btnIntegration
        ' 
        btnIntegration.ImageAlign = Drawing.ContentAlignment.MiddleLeft
        btnIntegration.ImageList = imageList
        btnIntegration.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/android-logo-1.svg?color=#BF3FB6"
        btnIntegration.Location = New Drawing.Point(214, 3)
        btnIntegration.Name = "btnIntegration"
        btnIntegration.Padding = New Web.Padding(30, 0, 10, 0)
        btnIntegration.Size = New Drawing.Size(205, 68)
        btnIntegration.TabIndex = 1
        btnIntegration.Text = "Widget Integration"
        AddHandler btnIntegration.Click, New EventHandler(AddressOf btnIntegration_Click)
        ' 
        ' button1
        ' 
        button1.ImageAlign = Drawing.ContentAlignment.MiddleLeft
        button1.ImageList = imageList
        button1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/film-roll.svg?color=#7FBF3F"
        button1.Location = New Drawing.Point(3, 77)
        button1.Name = "button1"
        button1.Padding = New Web.Padding(30, 0, 10, 0)
        button1.Size = New Drawing.Size(205, 68)
        button1.TabIndex = 2
        button1.Text = "Media"
        AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
        ' 
        ' button2
        ' 
        button2.ImageAlign = Drawing.ContentAlignment.MiddleLeft
        button2.ImageList = imageList
        button2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/server-rack-with-three-levels.svg?color=#BF3" & "F3F"
        button2.Location = New Drawing.Point(214, 77)
        button2.Name = "button2"
        button2.Padding = New Web.Padding(30, 0, 10, 0)
        button2.Size = New Drawing.Size(205, 68)
        button2.TabIndex = 3
        button2.Text = "Data Binding"
        AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
        ' 
        ' button3
        ' 
        button3.ImageAlign = Drawing.ContentAlignment.MiddleLeft
        button3.ImageList = imageList
        button3.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/painter-palette.svg?color=#00FDFF"
        button3.Location = New Drawing.Point(3, 151)
        button3.Name = "button3"
        button3.Padding = New Web.Padding(30, 0, 10, 0)
        button3.Size = New Drawing.Size(205, 68)
        button3.TabIndex = 4
        button3.Text = "Custom Painting"
        AddHandler button3.Click, New EventHandler(AddressOf button3_Click)
        ' 
        ' button4
        ' 
        button4.ImageAlign = Drawing.ContentAlignment.MiddleLeft
        button4.ImageList = imageList
        button4.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/warning-sign.svg?color=#FF7700"
        button4.Location = New Drawing.Point(214, 151)
        button4.Name = "button4"
        button4.Padding = New Web.Padding(30, 0, 10, 0)
        button4.Size = New Drawing.Size(205, 68)
        button4.TabIndex = 5
        button4.Text = "Alerts"
        AddHandler button4.Click, New EventHandler(AddressOf button4_Click)
        ' 
        ' StartPopup
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        BackColor = Drawing.Color.FromArgb(157, 0, 0, 0)
        Controls.Add(flowLayoutPanel1)
        Controls.Add(label1)
        Name = "StartPopup"
        Size = New Drawing.Size(507, 375)
        flowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents label1 As Web.Label
    Friend WithEvents flowLayoutPanel1 As Web.FlowLayoutPanel
    Friend WithEvents btnBackgroundTasks As Web.Button
    Friend WithEvents imageList As Web.ImageList
    Friend WithEvents btnIntegration As Web.Button
    Friend WithEvents button1 As Web.Button
    Friend WithEvents button2 As Web.Button
    Friend WithEvents button3 As Web.Button
    Friend WithEvents button4 As Web.Button
End Class
