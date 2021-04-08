<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyDesktop
    Inherits Wisej.Web.Desktop
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

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.bingWallpaper = New Wisej.Web.Ext.BingWallpaper.BingWallpaper(Me.components)
        Me.nudPictureCount = New Wisej.Web.NumericUpDown()
        Me.btnPictureCount = New Wisej.Web.Button()
        Me.nudRotationInterval = New Wisej.Web.NumericUpDown()
        Me.btnRotationInterval = New Wisej.Web.Button()
        Me.nudFadingInterval = New Wisej.Web.NumericUpDown()
        Me.btnFadingInterval = New Wisej.Web.Button()
        Me.checkBox1 = New Wisej.Web.CheckBox()
        CType(Me.nudPictureCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRotationInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFadingInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bingWallpaper
        '
        Me.bingWallpaper.Control = Me
        Me.bingWallpaper.EnableAnimation = False
        Me.bingWallpaper.RotationInterval = 2000
        '
        'nudPictureCount
        '
        Me.nudPictureCount.Location = New System.Drawing.Point(3, 46)
        Me.nudPictureCount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudPictureCount.Name = "nudPictureCount"
        Me.nudPictureCount.Size = New System.Drawing.Size(334, 22)
        Me.nudPictureCount.TabIndex = 0
        '
        'btnPictureCount
        '
        Me.btnPictureCount.AutoSize = True
        Me.btnPictureCount.Location = New System.Drawing.Point(353, 43)
        Me.btnPictureCount.Name = "btnPictureCount"
        Me.btnPictureCount.Size = New System.Drawing.Size(170, 27)
        Me.btnPictureCount.TabIndex = 1
        Me.btnPictureCount.Text = "Apply Picture Count"
        '
        'nudRotationInterval
        '
        Me.nudRotationInterval.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudRotationInterval.Location = New System.Drawing.Point(3, 89)
        Me.nudRotationInterval.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudRotationInterval.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudRotationInterval.Name = "nudRotationInterval"
        Me.nudRotationInterval.Size = New System.Drawing.Size(334, 22)
        Me.nudRotationInterval.TabIndex = 0
        Me.nudRotationInterval.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'btnRotationInterval
        '
        Me.btnRotationInterval.AutoSize = True
        Me.btnRotationInterval.Location = New System.Drawing.Point(353, 86)
        Me.btnRotationInterval.Name = "btnRotationInterval"
        Me.btnRotationInterval.Size = New System.Drawing.Size(170, 27)
        Me.btnRotationInterval.TabIndex = 1
        Me.btnRotationInterval.Text = "Apply Rotation Interval"
        '
        'nudFadingInterval
        '
        Me.nudFadingInterval.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudFadingInterval.Location = New System.Drawing.Point(3, 135)
        Me.nudFadingInterval.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudFadingInterval.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudFadingInterval.Name = "nudFadingInterval"
        Me.nudFadingInterval.Size = New System.Drawing.Size(334, 22)
        Me.nudFadingInterval.TabIndex = 0
        Me.nudFadingInterval.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'btnFadingInterval
        '
        Me.btnFadingInterval.AutoSize = True
        Me.btnFadingInterval.Location = New System.Drawing.Point(353, 133)
        Me.btnFadingInterval.Name = "btnFadingInterval"
        Me.btnFadingInterval.Size = New System.Drawing.Size(170, 27)
        Me.btnFadingInterval.TabIndex = 1
        Me.btnFadingInterval.Text = "Apply Fading Interval"
        '
        'checkBox1
        '
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = Wisej.Web.CheckState.Checked
        Me.checkBox1.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.checkBox1.ForeColor = System.Drawing.Color.FromArgb(199, 203, 107)
        Me.checkBox1.Location = New System.Drawing.Point(3, 178)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(277, 26)
        Me.checkBox1.TabIndex = 4
        Me.checkBox1.Text = "Enable / Disable Fading Animation"
        '
        'MyDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.btnFadingInterval)
        Me.Controls.Add(Me.btnRotationInterval)
        Me.Controls.Add(Me.btnPictureCount)
        Me.Controls.Add(Me.nudFadingInterval)
        Me.Controls.Add(Me.nudRotationInterval)
        Me.Controls.Add(Me.nudPictureCount)
        Me.Name = "MyDesktop"
        Me.Size = New System.Drawing.Size(1124, 528)
        Me.Text = "Wisej BingWallpaper Sample"
        CType(Me.nudPictureCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRotationInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFadingInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private bingWallpaper As Web.Ext.BingWallpaper.BingWallpaper
    Friend WithEvents btnFadingInterval As Web.Button
    Friend WithEvents btnRotationInterval As Web.Button
    Friend WithEvents btnPictureCount As Web.Button
    Private nudFadingInterval As Web.NumericUpDown
    Private nudRotationInterval As Web.NumericUpDown
    Private nudPictureCount As Web.NumericUpDown
    Friend WithEvents checkBox1 As Web.CheckBox
End Class

