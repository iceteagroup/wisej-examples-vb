Imports System

Partial Class Page1
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
        Me.components = New System.ComponentModel.Container()
        Dim ImageListEntry3 As Wisej.Web.ImageListEntry = New Wisej.Web.ImageListEntry("https://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/96/MetroUI-Apps-Ca" &
    "lculator-Alt-icon.png", "MetroUI-Calculator")
        Dim ImageListEntry4 As Wisej.Web.ImageListEntry = New Wisej.Web.ImageListEntry("https://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/96/MetroUI-Apps-Bl" &
    "uetooth-icon.png", "MetroUI-Apps-Bluetooth-icon")
        Me.groupBox1 = New Wisej.Web.GroupBox()
        Me.button3 = New Wisej.Web.Button()
        Me.button2 = New Wisej.Web.Button()
        Me.button1 = New Wisej.Web.Button()
        Me.groupBox2 = New Wisej.Web.GroupBox()
        Me.button5 = New Wisej.Web.Button()
        Me.button4 = New Wisej.Web.Button()
        Me.flowLayoutPanel1 = New Wisej.Web.FlowLayoutPanel()
        Me.groupBox4 = New Wisej.Web.GroupBox()
        Me.button9 = New Wisej.Web.Button()
        Me.button10 = New Wisej.Web.Button()
        Me.groupBox5 = New Wisej.Web.GroupBox()
        Me.button11 = New Wisej.Web.Button()
        Me.imageList1 = New Wisej.Web.ImageList(Me.components)
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.button3)
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Location = New System.Drawing.Point(40, 40)
        Me.groupBox1.Margin = New Wisej.Web.Padding(40)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(412, 191)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.Text = "Buttons with Image Resources (png)"
        Me.groupBox1.UseMnemonic = False
        '
        'button3
        '
        Me.button3.Image = My.Resources.Resources.Error_64
        Me.button3.Location = New System.Drawing.Point(146, 32)
        Me.button3.Name = "button3"
        Me.button3.Padding = New Wisej.Web.Padding(0, 0, 0, 30)
        Me.button3.Size = New System.Drawing.Size(238, 132)
        Me.button3.TabIndex = 2
        Me.button3.Text = "ERROR"
        Me.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button3.TextImageRelation = Wisej.Web.TextImageRelation.Overlay
        '
        'button2
        '
        Me.button2.Image = My.Resources.rss
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button2.Location = New System.Drawing.Point(17, 89)
        Me.button2.Name = "button2"
        Me.button2.Padding = New Wisej.Web.Padding(10, 10, 10, 11)
        Me.button2.Size = New System.Drawing.Size(110, 75)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Subscribe"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button2.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText
        '
        'button1
        '
        Me.button1.Image = My.Resources.Resources.Ok_24
        Me.button1.Location = New System.Drawing.Point(17, 32)
        Me.button1.Name = "button1"
        Me.button1.Padding = New Wisej.Web.Padding(10, 0, 10, 0)
        Me.button1.Size = New System.Drawing.Size(110, 40)
        Me.button1.TabIndex = 0
        Me.button1.Text = "OK"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.button5)
        Me.groupBox2.Controls.Add(Me.button4)
        Me.groupBox2.Location = New System.Drawing.Point(532, 40)
        Me.groupBox2.Margin = New Wisej.Web.Padding(40)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(411, 191)
        Me.groupBox2.TabIndex = 2
        Me.groupBox2.Text = "Buttons with Background"
        Me.groupBox2.UseMnemonic = False
        '
        'button5
        '
        Me.button5.AllowHtml = True
        Me.button5.BackColor = System.Drawing.Color.Transparent
        Me.button5.BackgroundImage = My.Resources.Resources.oval_background
        Me.button5.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.button5.Location = New System.Drawing.Point(176, 36)
        Me.button5.Name = "button5"
        Me.button5.Padding = New Wisej.Web.Padding(10, 0, 10, 0)
        Me.button5.Size = New System.Drawing.Size(218, 136)
        Me.button5.TabIndex = 4
        Me.button5.Text = "<b>THIS IS</b><br/>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<i>HTML TEXT</i>"
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.Color.Transparent
        Me.button4.BackgroundImage = My.Resources.Resources.blank_glossy_round_button_pv
        Me.button4.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.button4.ForeColor = System.Drawing.Color.Black
        Me.button4.Location = New System.Drawing.Point(17, 36)
        Me.button4.Name = "button4"
        Me.button4.Padding = New Wisej.Web.Padding(10, 0, 10, 0)
        Me.button4.Size = New System.Drawing.Size(142, 136)
        Me.button4.TabIndex = 3
        Me.button4.Text = "OK"
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.Controls.Add(Me.groupBox1)
        Me.flowLayoutPanel1.Controls.Add(Me.groupBox2)
        Me.flowLayoutPanel1.Controls.Add(Me.groupBox4)
        Me.flowLayoutPanel1.Controls.Add(Me.groupBox5)
        Me.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(1049, 737)
        Me.flowLayoutPanel1.TabIndex = 3
        Me.flowLayoutPanel1.TabStop = True
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.button9)
        Me.groupBox4.Controls.Add(Me.button10)
        Me.groupBox4.Location = New System.Drawing.Point(40, 311)
        Me.groupBox4.Margin = New Wisej.Web.Padding(40)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(411, 191)
        Me.groupBox4.TabIndex = 5
        Me.groupBox4.Text = "Buttons with Double Images"
        Me.groupBox4.UseMnemonic = False
        '
        'button9
        '
        Me.button9.AllowHtml = True
        Me.button9.BackColor = System.Drawing.Color.Transparent
        Me.button9.BackgroundImage = My.Resources.Resources.oval_background
        Me.button9.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button9.ImageSource = "icon-comment"
        Me.button9.Location = New System.Drawing.Point(176, 36)
        Me.button9.Name = "button9"
        Me.button9.Padding = New Wisej.Web.Padding(10, 0, 30, 0)
        Me.button9.Size = New System.Drawing.Size(218, 136)
        Me.button9.TabIndex = 4
        Me.button9.Text = "<b>THIS IS</b><br/>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<i>HTML TEXT</i>"
        Me.button9.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage
        '
        'button10
        '
        Me.button10.BackColor = System.Drawing.Color.Transparent
        Me.button10.BackgroundImage = My.Resources.Resources.blank_glossy_round_button_pv
        Me.button10.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom
        Me.button10.Font = New System.Drawing.Font("default", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.button10.ForeColor = System.Drawing.Color.Black
        Me.button10.ImageSource = "ajax-loader"
        Me.button10.Location = New System.Drawing.Point(17, 36)
        Me.button10.Name = "button10"
        Me.button10.Padding = New Wisej.Web.Padding(10, 0, 10, 0)
        Me.button10.Size = New System.Drawing.Size(142, 136)
        Me.button10.TabIndex = 3
        Me.button10.Text = "Load"
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.button11)
        Me.groupBox5.Location = New System.Drawing.Point(531, 311)
        Me.groupBox5.Margin = New Wisej.Web.Padding(40)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(412, 191)
        Me.groupBox5.TabIndex = 4
        Me.groupBox5.Text = "Buttons with Image List"
        Me.groupBox5.UseMnemonic = False
        '
        'button11
        '
        Me.button11.AppearanceKey = "button-alert"
        Me.button11.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.button11.ImageKey = "MetroUI-Calculator"
        Me.button11.ImageList = Me.imageList1
        Me.button11.Location = New System.Drawing.Point(18, 36)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(377, 132)
        Me.button11.TabIndex = 2
        Me.button11.Text = "Image Size Set in Image List"
        Me.button11.ToolTipText = "Click to change icon..."
        '
        'imageList1
        '
        Me.imageList1.Images.AddRange(New Wisej.Web.ImageListEntry() {ImageListEntry3, ImageListEntry4})
        Me.imageList1.ImageSize = New System.Drawing.Size(96, 96)
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.flowLayoutPanel1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(1049, 737)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub


#End Region

    Private button1 As Web.Button
    Private groupBox1 As Web.GroupBox
    Private button2 As Web.Button
    Private button3 As Web.Button
    Private groupBox2 As Web.GroupBox
    Private button4 As Web.Button
    Private button5 As Web.Button
    Private flowLayoutPanel1 As Web.FlowLayoutPanel
    Private groupBox4 As Web.GroupBox
    Private button9 As Web.Button
    Private button10 As Web.Button
    Private groupBox5 As Web.GroupBox
    Private WithEvents button11 As Web.Button
    Private imageList1 As Web.ImageList
End Class
