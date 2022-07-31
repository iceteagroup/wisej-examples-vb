Imports Wisej.Web

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
        Me.components = New System.ComponentModel.Container()
        Me.animation1 = New Wisej.Web.Animation(Me.components)
        Me.flexLayoutPanel1 = New Wisej.Web.FlexLayoutPanel()
        Me.pictureBox1 = New Wisej.Web.PictureBox()
        Me.pictureBox2 = New Wisej.Web.PictureBox()
        Me.animation2 = New Wisej.Web.Animation(Me.components)
        Me.button1 = New Wisej.Web.Ext.SideButton.SideButton()
        Me.label1 = New Wisej.Web.Label()
        Me.navigationBarItem5 = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.navigationBarItem2 = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.navigationBarItem3 = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.navigationBarItem4 = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.navigationBarItem1 = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.panel1 = New Wisej.Web.Ext.NavigationBar.NavigationBar()
        Me.flexLayoutPanel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flexLayoutPanel1
        '
        Me.animation1.GetAnimation(Me.flexLayoutPanel1).Event = "appear"
        Me.animation1.GetAnimation(Me.flexLayoutPanel1).Name = "slideRightIn"
        Me.animation2.GetAnimation(Me.flexLayoutPanel1).Event = "disappear"
        Me.animation2.GetAnimation(Me.flexLayoutPanel1).Name = "slideRightOut"
        Me.flexLayoutPanel1.Controls.Add(Me.pictureBox1)
        Me.flexLayoutPanel1.Controls.Add(Me.pictureBox2)
        Me.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Right
        Me.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical
        Me.flexLayoutPanel1.Location = New System.Drawing.Point(964, 0)
        Me.flexLayoutPanel1.Name = "flexLayoutPanel1"
        Me.flexLayoutPanel1.Padding = New Wisej.Web.Padding(5, 40, 5, 0)
        Me.flexLayoutPanel1.Size = New System.Drawing.Size(42, 363)
        Me.flexLayoutPanel1.TabIndex = 4
        Me.flexLayoutPanel1.TabStop = True
        Me.flexLayoutPanel1.Visible = False
        '
        'pictureBox1
        '
        Me.pictureBox1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/settings-cogwheel-button.svg?color=#BF3F62"
        Me.pictureBox1.Location = New System.Drawing.Point(8, 43)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(26, 40)
        '
        'pictureBox2
        '
        Me.pictureBox2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/set-alarm.svg?color=#3F52BF"
        Me.pictureBox2.Location = New System.Drawing.Point(8, 99)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(26, 40)
        '
        'button1
        '
        Me.button1.Alignment = Wisej.Web.LeftRightAlignment.Right
        Me.button1.Anchor = CType((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.button1.Collapsed = True
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.ImageSource = "icon-left"
        Me.button1.Location = New System.Drawing.Point(964, 322)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(42, 40)
        Me.button1.TabIndex = 5
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("default", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label1.Location = New System.Drawing.Point(237, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(90, 37)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Home"
        '
        'navigationBarItem5
        '
        Me.navigationBarItem5.Icon = "resource.wx/Wisej.Ext.MaterialDesign/user-shape.svg?color=#00CEFF"
        Me.navigationBarItem5.Name = "navigationBarItem5"
        Me.navigationBarItem5.Text = "Users"
        '
        'navigationBarItem2
        '
        Me.navigationBarItem2.Expanded = True
        Me.navigationBarItem2.Icon = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-file.svg?color=#4E3FBF"
        Me.navigationBarItem2.Items.AddRange(New Wisej.Web.Ext.NavigationBar.NavigationBarItem() {Me.navigationBarItem3, Me.navigationBarItem4})
        Me.navigationBarItem2.Name = "navigationBarItem2"
        Me.navigationBarItem2.Text = "Projects"
        '
        'navigationBarItem3
        '
        Me.navigationBarItem3.Icon = "resource.wx/Wisej.Ext.MaterialDesign/high-signal-indicator.svg?color=#00FF3E"
        Me.navigationBarItem3.InfoText = "3"
        Me.navigationBarItem3.Name = "navigationBarItem3"
        Me.navigationBarItem3.Text = "Priority"
        '
        'navigationBarItem4
        '
        Me.navigationBarItem4.Icon = "resource.wx/Wisej.Ext.MaterialDesign/exit-to-app-button.svg?color=#DFFF00"
        Me.navigationBarItem4.Name = "navigationBarItem4"
        Me.navigationBarItem4.Text = "External"
        '
        'navigationBarItem1
        '
        Me.navigationBarItem1.ForeColor = System.Drawing.Color.AliceBlue
        Me.navigationBarItem1.Icon = "resource.wx/Wisej.Ext.ElegantIcons/3x3-grid.svg?color=#3FBF77"
        Me.navigationBarItem1.InfoText = "new"
        Me.navigationBarItem1.InfoTextBackColor = System.Drawing.Color.Salmon
        Me.navigationBarItem1.Name = "navigationBarItem1"
        Me.navigationBarItem1.Text = "Dashboard"
        '
        'panel1
        '
        Me.panel1.Dock = Wisej.Web.DockStyle.Left
        Me.panel1.Indentation = 20
        Me.panel1.Items.AddRange(New Wisej.Web.Ext.NavigationBar.NavigationBarItem() {Me.navigationBarItem1, Me.navigationBarItem2, Me.navigationBarItem5})
        Me.panel1.Logo = "Images\itg-128x128.png"
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(203, 363)
        Me.panel1.TabIndex = 8
        Me.panel1.Text = "Nav App"
        Me.panel1.UserAvatar = "https://www.gravatar.com/avatar/00000000000000000000000000000000"
        Me.panel1.UserName = "Some User"
        Me.panel1.UserStatus = "Online"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.flexLayoutPanel1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(1006, 363)
        Me.Text = "Page1"
        Me.flexLayoutPanel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents animation1 As Animation
    Friend WithEvents animation2 As Animation
    Friend WithEvents pictureBox1 As PictureBox
    Friend WithEvents pictureBox2 As PictureBox
    Friend WithEvents flexLayoutPanel1 As FlexLayoutPanel
    Friend WithEvents button1 As Web.Ext.SideButton.SideButton
    Friend WithEvents label1 As Label
    Friend WithEvents navigationBarItem5 As Web.Ext.NavigationBar.NavigationBarItem
    Friend WithEvents navigationBarItem2 As Web.Ext.NavigationBar.NavigationBarItem
    Friend WithEvents navigationBarItem3 As Web.Ext.NavigationBar.NavigationBarItem
    Friend WithEvents navigationBarItem4 As Web.Ext.NavigationBar.NavigationBarItem
    Friend WithEvents navigationBarItem1 As Web.Ext.NavigationBar.NavigationBarItem
    Friend WithEvents panel1 As Web.Ext.NavigationBar.NavigationBar
End Class
