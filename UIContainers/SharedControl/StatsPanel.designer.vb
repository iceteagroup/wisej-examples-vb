<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StatsPanel
    Inherits Wisej.Web.UserControl
    ''' <summary> 
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        label1 = New Wisej.Web.Label()
        formActiveFormText = New Wisej.Web.Label()
        label2 = New Wisej.Web.Label()
        mainPageText = New Wisej.Web.Label()
        label3 = New Wisej.Web.Label()
        mainPageControlsCount = New Wisej.Web.Label()
        label4 = New Wisej.Web.Label()
        mainPageActiveControlText = New Wisej.Web.Label()
        label5 = New Wisej.Web.Label()
        desktopText = New Wisej.Web.Label()
        label6 = New Wisej.Web.Label()
        desktopControlsCount = New Wisej.Web.Label()
        label7 = New Wisej.Web.Label()
        desktopActiveControlText = New Wisej.Web.Label()
        label9 = New Wisej.Web.Label()
        applicationOpenForms = New Wisej.Web.Label()
        label8 = New Wisej.Web.Label()
        applicationOpenPages = New Wisej.Web.Label()
        button1 = New Wisej.Web.Button()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Drawing.Point(20, 20)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(110, 18)
        label1.TabIndex = 0
        label1.Text = "Form.ActiveForm"
        ' 
        ' formActiveFormText
        ' 
        formActiveFormText.AutoSize = True
        formActiveFormText.Location = New Drawing.Point(300, 20)
        formActiveFormText.Name = "formActiveFormText"
        formActiveFormText.Size = New Drawing.Size(76, 18)
        formActiveFormText.TabIndex = 1
        formActiveFormText.Text = "ActiveForm"
        ' 
        ' mainPageText
        ' 
        mainPageText.AutoSize = True
        mainPageText.Location = New Drawing.Point(300, 70)
        mainPageText.Name = "mainPageText"
        mainPageText.Size = New Drawing.Size(68, 18)
        mainPageText.TabIndex = 3
        mainPageText.Text = "MainPage"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Drawing.Point(20, 70)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(137, 18)
        label2.TabIndex = 2
        label2.Text = "Application.MainPage"
        ' 
        ' mainPageControlsCount
        ' 
        mainPageControlsCount.AutoSize = True
        mainPageControlsCount.Location = New Drawing.Point(300, 100)
        mainPageControlsCount.Name = "mainPageControlsCount"
        mainPageControlsCount.Size = New Drawing.Size(15, 18)
        mainPageControlsCount.TabIndex = 5
        mainPageControlsCount.Text = "0"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Drawing.Point(20, 100)
        label3.Name = "label3"
        label3.Size = New Drawing.Size(191, 18)
        label3.TabIndex = 4
        label3.Text = "Application.MainPage.Controls"
        ' 
        ' mainPageActiveControlText
        ' 
        mainPageActiveControlText.AutoSize = True
        mainPageActiveControlText.Location = New Drawing.Point(300, 130)
        mainPageActiveControlText.Name = "mainPageActiveControlText"
        mainPageActiveControlText.Size = New Drawing.Size(87, 18)
        mainPageActiveControlText.TabIndex = 7
        mainPageActiveControlText.Text = "ActiveControl"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Drawing.Point(20, 130)
        label4.Name = "label4"
        label4.Size = New Drawing.Size(221, 18)
        label4.TabIndex = 6
        label4.Text = "Application.MainPage.ActiveControl"
        ' 
        ' desktopText
        ' 
        desktopText.AutoSize = True
        desktopText.Location = New Drawing.Point(300, 180)
        desktopText.Name = "desktopText"
        desktopText.Size = New Drawing.Size(57, 18)
        desktopText.TabIndex = 9
        desktopText.Text = "Desktop"
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Drawing.Point(20, 180)
        label5.Name = "label5"
        label5.Size = New Drawing.Size(126, 18)
        label5.TabIndex = 8
        label5.Text = "Application.Desktop"
        ' 
        ' desktopControlsCount
        ' 
        desktopControlsCount.AutoSize = True
        desktopControlsCount.Location = New Drawing.Point(300, 210)
        desktopControlsCount.Name = "desktopControlsCount"
        desktopControlsCount.Size = New Drawing.Size(15, 18)
        desktopControlsCount.TabIndex = 11
        desktopControlsCount.Text = "0"
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Drawing.Point(20, 210)
        label6.Name = "label6"
        label6.Size = New Drawing.Size(180, 18)
        label6.TabIndex = 10
        label6.Text = "Application.Desktop.Controls"
        ' 
        ' desktopActiveControlText
        ' 
        desktopActiveControlText.AutoSize = True
        desktopActiveControlText.Location = New Drawing.Point(300, 240)
        desktopActiveControlText.Name = "desktopActiveControlText"
        desktopActiveControlText.Size = New Drawing.Size(87, 18)
        desktopActiveControlText.TabIndex = 13
        desktopActiveControlText.Text = "ActiveControl"
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Location = New Drawing.Point(20, 240)
        label7.Name = "label7"
        label7.Size = New Drawing.Size(210, 18)
        label7.TabIndex = 12
        label7.Text = "Application.Desktop.ActiveControl"
        ' 
        ' applicationOpenForms
        ' 
        applicationOpenForms.AutoSize = True
        applicationOpenForms.Location = New Drawing.Point(300, 290)
        applicationOpenForms.Name = "applicationOpenForms"
        applicationOpenForms.Size = New Drawing.Size(15, 18)
        applicationOpenForms.TabIndex = 16
        applicationOpenForms.Text = "0"
        ' 
        ' label8
        ' 
        label8.AutoSize = True
        label8.Location = New Drawing.Point(20, 290)
        label8.Name = "label8"
        label8.Size = New Drawing.Size(148, 18)
        label8.TabIndex = 15
        label8.Text = "Application.OpenForms"
        ' 
        ' applicationOpenPages
        ' 
        applicationOpenPages.AutoSize = True
        applicationOpenPages.Location = New Drawing.Point(300, 320)
        applicationOpenPages.Name = "applicationOpenPages"
        applicationOpenPages.Size = New Drawing.Size(15, 18)
        applicationOpenPages.TabIndex = 18
        applicationOpenPages.Text = "0"
        ' 
        ' label9
        ' 
        label9.AutoSize = True
        label9.Location = New Drawing.Point(20, 320)
        label9.Name = "label9"
        label9.Size = New Drawing.Size(148, 18)
        label9.TabIndex = 17
        label9.Text = "Application.OpenPages"
        ' 
        ' button1
        ' 
        button1.Location = New Drawing.Point(20, 376)
        button1.Name = "button1"
        button1.Size = New Drawing.Size(75, 26)
        button1.TabIndex = 14
        button1.Text = "Update"
        AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
        ' 
        ' StatsPanel
        ' 
        Controls.Add(button1)
        Controls.Add(applicationOpenPages)
        Controls.Add(label9)
        Controls.Add(applicationOpenForms)
        Controls.Add(label8)
        Controls.Add(desktopActiveControlText)
        Controls.Add(label7)
        Controls.Add(desktopControlsCount)
        Controls.Add(label6)
        Controls.Add(desktopText)
        Controls.Add(label5)
        Controls.Add(mainPageActiveControlText)
        Controls.Add(label4)
        Controls.Add(mainPageControlsCount)
        Controls.Add(label3)
        Controls.Add(mainPageText)
        Controls.Add(label2)
        Controls.Add(formActiveFormText)
        Controls.Add(label1)
        Name = "StatsPanel"
        Size = New Drawing.Size(612, 430)
        ResumeLayout(False)
        PerformLayout()
    End Sub

#End Region

    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents label3 As Wisej.Web.Label
    Friend WithEvents label4 As Wisej.Web.Label
    Friend WithEvents label5 As Wisej.Web.Label
    Friend WithEvents label6 As Wisej.Web.Label
    Friend WithEvents label7 As Wisej.Web.Label
    Friend WithEvents label8 As Wisej.Web.Label
    Friend WithEvents label9 As Wisej.Web.Label
    Public formActiveFormText As Wisej.Web.Label
    Public mainPageText As Wisej.Web.Label
    Public mainPageControlsCount As Wisej.Web.Label
    Public mainPageActiveControlText As Wisej.Web.Label
    Public desktopText As Wisej.Web.Label
    Public desktopControlsCount As Wisej.Web.Label
    Public desktopActiveControlText As Wisej.Web.Label
    Public applicationOpenForms As Wisej.Web.Label
    Public applicationOpenPages As Wisej.Web.Label
    Private button1 As Wisej.Web.Button
End Class
