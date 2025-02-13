<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page1
    Inherits Wisej.Web.Page
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer = Nothing

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
        Me.menuBar1 = New Wisej.Web.MenuBar()
        Me.menuItem1 = New Wisej.Web.MenuItem()
        Me.menuItem2 = New Wisej.Web.MenuItem()
        Me.lblWisejExtention = New Wisej.Web.Label()
        Me.lblMicrosoftRepo = New Wisej.Web.Label()
        Me.label1 = New Wisej.Web.Label()
        Me.SuspendLayout()
        '
        'menuBar1
        '
        Me.menuBar1.Dock = Wisej.Web.DockStyle.Top
        Me.menuBar1.Font = New System.Drawing.Font("menu", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.menuBar1.Location = New System.Drawing.Point(0, 0)
        Me.menuBar1.MenuItems.AddRange(New Wisej.Web.MenuItem() {Me.menuItem1, Me.menuItem2})
        Me.menuBar1.Name = "menuBar1"
        Me.menuBar1.Size = New System.Drawing.Size(1325, 28)
        Me.menuBar1.TabIndex = 0
        Me.menuBar1.TabStop = False
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.Name = "menuItem1"
        Me.menuItem1.Text = "Command Line"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 1
        Me.menuItem2.Name = "menuItem2"
        Me.menuItem2.Text = "Events"
        '
        'lblWisejExtention
        '
        Me.lblWisejExtention.AllowHtml = True
        Me.lblWisejExtention.AutoSize = True
        Me.lblWisejExtention.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblWisejExtention.Location = New System.Drawing.Point(12, 45)
        Me.lblWisejExtention.Name = "lblWisejExtention"
        Me.lblWisejExtention.Size = New System.Drawing.Size(977, 19)
        Me.lblWisejExtention.TabIndex = 1
        Me.lblWisejExtention.Text = "<a href=""https://github.com/iceteagroup/wisej-extensions/tree/2.2/Wisej.Ext.Clear" &
    "Script"" target=""_blank"">Wisej ClearScript Extension</a>"
        '
        'lblMicrosoftRepo
        '
        Me.lblMicrosoftRepo.AllowHtml = True
        Me.lblMicrosoftRepo.AutoSize = True
        Me.lblMicrosoftRepo.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMicrosoftRepo.Location = New System.Drawing.Point(12, 93)
        Me.lblMicrosoftRepo.Name = "lblMicrosoftRepo"
        Me.lblMicrosoftRepo.Size = New System.Drawing.Size(1057, 19)
        Me.lblMicrosoftRepo.TabIndex = 3
        Me.lblMicrosoftRepo.Text = "For additional information, <a href=""https://microsoft.github.io/ClearScript/Refe" &
    "rence/html/R_Project_Reference.htm"" target=""_blank"">Click here!</a>"
        '
        'label1
        '
        Me.label1.AllowHtml = True
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.label1.Location = New System.Drawing.Point(12, 118)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(1053, 19)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Watch a sample video, <a href=""https://wisej.s3.amazonaws.com/downloads/Examples/" &
    "clearscript%20sample.mp4"" target=""_blank"">Click here!</a>"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.BackgroundImageSource = "Resources/bg.png"
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblMicrosoftRepo)
        Me.Controls.Add(Me.lblWisejExtention)
        Me.Controls.Add(Me.menuBar1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(1325, 642)
        Me.Text = " Wisej ClearScript Sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private menuBar1 As Web.MenuBar
    Friend WithEvents menuItem1 As Web.MenuItem
    Friend WithEvents menuItem2 As Web.MenuItem
    Private lblWisejExtention As Web.Label
    Private lblMicrosoftRepo As Web.Label
    Private label1 As Web.Label
End Class
