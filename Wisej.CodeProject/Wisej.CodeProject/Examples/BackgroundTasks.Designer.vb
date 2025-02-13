<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BackgroundTasks
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
        button1 = New Web.Button()
        button2 = New Web.Button()
        progressBar1 = New Web.ProgressBar()
        progressCircle1 = New Web.Ext.ProgressCircle.ProgressCircle()
        label1 = New Web.Label()
        SuspendLayout()
        ' 
        ' button1
        ' 
        button1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/play-arrow.svg"
        button1.Location = New Drawing.Point(25, 29)
        button1.Name = "button1"
        button1.Size = New Drawing.Size(164, 50)
        button1.TabIndex = 0
        button1.Text = "Start"
        button1.TextImageRelation = Web.TextImageRelation.TextBeforeImage
        AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
        ' 
        ' button2
        ' 
        button2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/stop-button.svg"
        button2.Location = New Drawing.Point(25, 96)
        button2.Name = "button2"
        button2.Size = New Drawing.Size(164, 50)
        button2.TabIndex = 1
        button2.Text = "Stop"
        button2.TextImageRelation = Web.TextImageRelation.TextBeforeImage
        AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
        ' 
        ' progressBar1
        ' 
        progressBar1.ForeColor = Drawing.Color.FromArgb(255, 143, 0)
        progressBar1.Location = New Drawing.Point(234, 30)
        progressBar1.Name = "progressBar1"
        progressBar1.Size = New Drawing.Size(349, 49)
        progressBar1.TabIndex = 2
        progressBar1.Text = "0%"
        ' 
        ' progressCircle1
        ' 
        progressCircle1.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Bottom Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        progressCircle1.Font = New Drawing.Font("default", 30.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        progressCircle1.ForeColor = Drawing.Color.Coral
        progressCircle1.LineWidth = 20
        progressCircle1.Location = New Drawing.Point(234, 241)
        progressCircle1.Name = "progressCircle1"
        progressCircle1.Size = New Drawing.Size(349, 233)
        progressCircle1.TabIndex = 3
        progressCircle1.Value = 20
        ' 
        ' label1
        ' 
        label1.AllowHtml = True
        label1.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        label1.BorderStyle = Web.BorderStyle.Solid
        label1.Location = New Drawing.Point(234, 99)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(349, 123)
        label1.TabIndex = 4
        label1.Text = "label1"
        ' 
        ' BackgroundTasks
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(605, 502)
        Controls.Add(label1)
        Controls.Add(progressCircle1)
        Controls.Add(progressBar1)
        Controls.Add(button2)
        Controls.Add(button1)
        IconSource = "resource.wx/Wisej.Ext.MaterialDesign/settings-cogwheel-button.svg?color=#FFD700"
        Name = "BackgroundTasks"
        Text = "Background Tasks Example"
        ResumeLayout(False)
    End Sub

#End Region

    Friend WithEvents button1 As Web.Button
    Friend WithEvents button2 As Web.Button
    Friend WithEvents progressBar1 As Web.ProgressBar
    Friend WithEvents progressCircle1 As Web.Ext.ProgressCircle.ProgressCircle
    Friend WithEvents label1 As Web.Label
End Class
