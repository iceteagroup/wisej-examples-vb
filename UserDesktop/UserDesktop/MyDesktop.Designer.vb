<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyDesktop
    Inherits Wisej.Web.Desktop
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyDesktop))
        Me.button1 = New Wisej.Web.Button()
        Me.imageList1 = New Wisej.Web.ImageList(Me.components)
        Me.bingWallpaper = New Wisej.Web.Ext.BingWallpaper.BingWallpaper(Me.components)
        Me.themesPanel = New Wisej.Web.Panel()
        Me.buttonTheme8 = New Wisej.Web.RadioButton()
        Me.buttonTheme7 = New Wisej.Web.RadioButton()
        Me.buttonTheme6 = New Wisej.Web.RadioButton()
        Me.buttonTheme5 = New Wisej.Web.RadioButton()
        Me.buttonTheme4 = New Wisej.Web.RadioButton()
        Me.buttonTheme3 = New Wisej.Web.RadioButton()
        Me.buttonTheme2 = New Wisej.Web.RadioButton()
        Me.buttonTheme1 = New Wisej.Web.RadioButton()
        Me.javaScript1 = New Wisej.Web.JavaScript(Me.components)
        Me.themesPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.AppearanceKey = "button-ok"
        Me.button1.ImageList = Me.imageList1
        Me.button1.ImageSource = "Images/Edit-File-32.png"
        Me.button1.Location = New System.Drawing.Point(226, 39)
        Me.button1.Movable = True
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(151, 112)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Notepad"
        Me.button1.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText
        '
        'imageList1
        '
        Me.imageList1.ImageSize = New System.Drawing.Size(32, 32)
        '
        'themesPanel
        '
        Me.themesPanel.BackColor = System.Drawing.Color.FromArgb(99, 0, 0, 0)
        Me.themesPanel.Controls.Add(Me.buttonTheme8)
        Me.themesPanel.Controls.Add(Me.buttonTheme7)
        Me.themesPanel.Controls.Add(Me.buttonTheme6)
        Me.themesPanel.Controls.Add(Me.buttonTheme5)
        Me.themesPanel.Controls.Add(Me.buttonTheme4)
        Me.themesPanel.Controls.Add(Me.buttonTheme3)
        Me.themesPanel.Controls.Add(Me.buttonTheme2)
        Me.themesPanel.Controls.Add(Me.buttonTheme1)
        Me.themesPanel.Dock = Wisej.Web.DockStyle.Left
        Me.themesPanel.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center
        Me.themesPanel.Location = New System.Drawing.Point(0, 0)
        Me.themesPanel.Name = "themesPanel"
        Me.themesPanel.ShowCloseButton = False
        Me.themesPanel.ShowHeader = True
        Me.themesPanel.Size = New System.Drawing.Size(165, 495)
        Me.themesPanel.TabIndex = 1
        Me.themesPanel.TabStop = True
        Me.themesPanel.Text = "Select Theme"
        '
        'buttonTheme8
        '
        Me.buttonTheme8.AppearanceKey = "theme-button"
        Me.buttonTheme8.AutoSize = False
        Me.buttonTheme8.Dock = Wisej.Web.DockStyle.Top
        Me.buttonTheme8.Location = New System.Drawing.Point(0, 280)
        Me.buttonTheme8.Name = "buttonTheme8"
        Me.buttonTheme8.Size = New System.Drawing.Size(165, 40)
        Me.buttonTheme8.TabIndex = 7
        Me.buttonTheme8.Text = "Material-3"
        Me.buttonTheme8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonTheme7
        '
        Me.buttonTheme7.AppearanceKey = "theme-button"
        Me.buttonTheme7.AutoSize = False
        Me.buttonTheme7.Dock = Wisej.Web.DockStyle.Top
        Me.buttonTheme7.Location = New System.Drawing.Point(0, 240)
        Me.buttonTheme7.Name = "buttonTheme7"
        Me.buttonTheme7.Size = New System.Drawing.Size(165, 40)
        Me.buttonTheme7.TabIndex = 6
        Me.buttonTheme7.Text = "Classic-2"
        Me.buttonTheme7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonTheme6
        '
        Me.buttonTheme6.AppearanceKey = "theme-button"
        Me.buttonTheme6.AutoSize = False
        Me.buttonTheme6.Dock = Wisej.Web.DockStyle.Top
        Me.buttonTheme6.Location = New System.Drawing.Point(0, 200)
        Me.buttonTheme6.Name = "buttonTheme6"
        Me.buttonTheme6.Size = New System.Drawing.Size(165, 40)
        Me.buttonTheme6.TabIndex = 5
        Me.buttonTheme6.Text = "Clear-3"
        Me.buttonTheme6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonTheme5
        '
        Me.buttonTheme5.AppearanceKey = "theme-button"
        Me.buttonTheme5.AutoSize = False
        Me.buttonTheme5.Dock = Wisej.Web.DockStyle.Top
        Me.buttonTheme5.Location = New System.Drawing.Point(0, 160)
        Me.buttonTheme5.Name = "buttonTheme5"
        Me.buttonTheme5.Size = New System.Drawing.Size(165, 40)
        Me.buttonTheme5.TabIndex = 4
        Me.buttonTheme5.Text = "Clear-2"
        Me.buttonTheme5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonTheme4
        '
        Me.buttonTheme4.AppearanceKey = "theme-button"
        Me.buttonTheme4.AutoSize = False
        Me.buttonTheme4.Dock = Wisej.Web.DockStyle.Top
        Me.buttonTheme4.Location = New System.Drawing.Point(0, 120)
        Me.buttonTheme4.Name = "buttonTheme4"
        Me.buttonTheme4.Size = New System.Drawing.Size(165, 40)
        Me.buttonTheme4.TabIndex = 3
        Me.buttonTheme4.Text = "Clear-1"
        Me.buttonTheme4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonTheme3
        '
        Me.buttonTheme3.AppearanceKey = "theme-button"
        Me.buttonTheme3.AutoSize = False
        Me.buttonTheme3.Dock = Wisej.Web.DockStyle.Top
        Me.buttonTheme3.Location = New System.Drawing.Point(0, 80)
        Me.buttonTheme3.Name = "buttonTheme3"
        Me.buttonTheme3.Size = New System.Drawing.Size(165, 40)
        Me.buttonTheme3.TabIndex = 2
        Me.buttonTheme3.Text = "Blue-3"
        Me.buttonTheme3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonTheme2
        '
        Me.buttonTheme2.AppearanceKey = "theme-button"
        Me.buttonTheme2.AutoSize = False
        Me.buttonTheme2.Dock = Wisej.Web.DockStyle.Top
        Me.buttonTheme2.Location = New System.Drawing.Point(0, 40)
        Me.buttonTheme2.Name = "buttonTheme2"
        Me.buttonTheme2.Size = New System.Drawing.Size(165, 40)
        Me.buttonTheme2.TabIndex = 1
        Me.buttonTheme2.Text = "Blue-2"
        Me.buttonTheme2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonTheme1
        '
        Me.buttonTheme1.AppearanceKey = "theme-button"
        Me.buttonTheme1.AutoSize = False
        Me.buttonTheme1.Dock = Wisej.Web.DockStyle.Top
        Me.buttonTheme1.Location = New System.Drawing.Point(0, 0)
        Me.buttonTheme1.Name = "buttonTheme1"
        Me.buttonTheme1.Size = New System.Drawing.Size(165, 40)
        Me.buttonTheme1.TabIndex = 0
        Me.buttonTheme1.Text = "Blue-1"
        Me.buttonTheme1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MyDesktop
        '
        Me.Controls.Add(Me.themesPanel)
        Me.Controls.Add(Me.button1)
        Me.javaScript1.SetJavaScript(Me, resources.GetString("$this.JavaScript"))
        Me.Name = "MyDesktop"
        Me.Size = New System.Drawing.Size(945, 543)
        Me.themesPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents button1 As Wisej.Web.Button
    Friend WithEvents bingWallpaper As Wisej.Web.Ext.BingWallpaper.BingWallpaper
    Friend WithEvents themesPanel As Wisej.Web.Panel
    Friend WithEvents buttonTheme8 As Wisej.Web.RadioButton
    Friend WithEvents buttonTheme7 As Wisej.Web.RadioButton
    Friend WithEvents buttonTheme6 As Wisej.Web.RadioButton
    Friend WithEvents buttonTheme5 As Wisej.Web.RadioButton
    Friend WithEvents buttonTheme4 As Wisej.Web.RadioButton
    Friend WithEvents buttonTheme3 As Wisej.Web.RadioButton
    Friend WithEvents buttonTheme2 As Wisej.Web.RadioButton
    Friend WithEvents buttonTheme1 As Wisej.Web.RadioButton
    Friend WithEvents imageList1 As Wisej.Web.ImageList
    Friend WithEvents javaScript1 As Wisej.Web.JavaScript
End Class
