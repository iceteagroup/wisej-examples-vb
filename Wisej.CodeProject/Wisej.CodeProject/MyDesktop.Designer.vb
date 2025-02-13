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
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.bingWallpaper = New Wisej.Web.Ext.BingWallpaper.BingWallpaper(Me.components)
        Me.desktopStart = New Wisej.Web.DesktopTaskBarItem()
        Me.desktopDateTime = New Wisej.Web.DesktopTaskBarItemDateTime()
        Me.justGage1 = New Wisej.Web.Ext.JustGage.JustGage()
        Me.desktopCPU = New Wisej.Web.DesktopTaskBarItemControl()
        Me.coolClock1 = New Wisej.Web.Ext.CoolClock.CoolClock()
        Me.speechSynthesis = New Wisej.Web.Ext.Speech.SpeechSynthesis()
        Me.SuspendLayout()
        '
        'desktopStart
        '
        Me.desktopStart.ImageSource = "icon-preview"
        Me.desktopStart.Name = "desktopStart"
        Me.desktopStart.ToolTipText = "Start"
        '
        'desktopDateTime
        '
        Me.desktopDateTime.Name = "desktopDateTime"
        '
        'justGage1
        '
        Me.justGage1.BackColor = System.Drawing.Color.FromArgb(244, 244, 244)
        Me.justGage1.ForeColor = System.Drawing.Color.White
        Me.justGage1.Label = ""
        Me.justGage1.Location = New System.Drawing.Point(3, 3)
        Me.justGage1.Name = "justGage1"
        Me.justGage1.ShowMinMax = False
        Me.justGage1.ShowPointer = True
        Me.justGage1.Size = New System.Drawing.Size(60, 34)
        Me.justGage1.Symbol = "%"
        Me.justGage1.TabIndex = 0
        Me.justGage1.Text = "CPU%"
        Me.justGage1.Value = 50.0!
        Me.justGage1.ValueColor = System.Drawing.Color.White
        '
        'desktopCPU
        '
        Me.desktopCPU.Control = Me.justGage1
        Me.desktopCPU.Name = "desktopCPU"
        Me.desktopCPU.Position = Wisej.Web.LeftRightAlignment.Right
        '
        'coolClock1
        '
        Me.coolClock1.BackColor = System.Drawing.Color.Transparent
        Me.coolClock1.Location = New System.Drawing.Point(33, 32)
        Me.coolClock1.Name = "coolClock1"
        Me.coolClock1.Size = New System.Drawing.Size(104, 103)
        Me.coolClock1.Skin = Wisej.Web.Ext.CoolClock.CoolClockSkin.Fancy
        Me.coolClock1.Text = "coolClock1"
        '
        'MyDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.coolClock1)
        Me.Items.AddRange(New Wisej.Web.DesktopTaskBarItem() {Me.desktopStart, Me.desktopCPU, Me.desktopDateTime})
        Me.Name = "MyDesktop"
        Me.Size = New System.Drawing.Size(944, 356)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents bingWallpaper As Web.Ext.BingWallpaper.BingWallpaper
    Friend WithEvents desktopStart As Web.DesktopTaskBarItem
    Friend WithEvents desktopDateTime As Web.DesktopTaskBarItemDateTime
    Friend WithEvents desktopCPU As Web.DesktopTaskBarItemControl
    Friend WithEvents justGage1 As Web.Ext.JustGage.JustGage
    Friend WithEvents coolClock1 As Web.Ext.CoolClock.CoolClock
    Friend WithEvents speechSynthesis As Web.Ext.Speech.SpeechSynthesis
End Class
