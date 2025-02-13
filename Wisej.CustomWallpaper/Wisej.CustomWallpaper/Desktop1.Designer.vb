
Partial Class Desktop1
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
        Me.customWallpaper = New Wisej.Web.Ext.CustomWallpaper.CustomWallpaper(Me.components)
        Me.checkBox2 = New Wisej.Web.CheckBox()
        Me.btnFadingInterval = New Wisej.Web.Button()
        Me.btnRotationInterval = New Wisej.Web.Button()
        Me.nudFadingInterval = New Wisej.Web.NumericUpDown()
        Me.nudRotationInterval = New Wisej.Web.NumericUpDown()
        CType(Me.nudFadingInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRotationInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customWallpaper
        '
        Me.customWallpaper.FadeTime = 3300
        Me.customWallpaper.RotationInterval = 3000
        '
        'checkBox2
        '
        Me.checkBox2.Checked = True
        Me.checkBox2.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.checkBox2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Me.checkBox2.Location = New System.Drawing.Point(26, 111)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(273, 27)
        Me.checkBox2.TabIndex = 5
        Me.checkBox2.Text = "Enable / Disable Fading Animation"
        '
        'btnFadingInterval
        '
        Me.btnFadingInterval.AutoSize = True
        Me.btnFadingInterval.Location = New System.Drawing.Point(376, 60)
        Me.btnFadingInterval.Name = "btnFadingInterval"
        Me.btnFadingInterval.Size = New System.Drawing.Size(170, 37)
        Me.btnFadingInterval.TabIndex = 8
        Me.btnFadingInterval.Text = "Apply Fading Interval"
        '
        'btnRotationInterval
        '
        Me.btnRotationInterval.AutoSize = True
        Me.btnRotationInterval.Location = New System.Drawing.Point(376, 13)
        Me.btnRotationInterval.Name = "btnRotationInterval"
        Me.btnRotationInterval.Size = New System.Drawing.Size(170, 37)
        Me.btnRotationInterval.TabIndex = 9
        Me.btnRotationInterval.Text = "Apply Rotation Interval"
        '
        'nudFadingInterval
        '
        Me.nudFadingInterval.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudFadingInterval.Location = New System.Drawing.Point(26, 62)
        Me.nudFadingInterval.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudFadingInterval.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudFadingInterval.Name = "nudFadingInterval"
        Me.nudFadingInterval.Size = New System.Drawing.Size(334, 30)
        Me.nudFadingInterval.TabIndex = 6
        Me.nudFadingInterval.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'nudRotationInterval
        '
        Me.nudRotationInterval.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudRotationInterval.Location = New System.Drawing.Point(26, 16)
        Me.nudRotationInterval.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudRotationInterval.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudRotationInterval.Name = "nudRotationInterval"
        Me.nudRotationInterval.Size = New System.Drawing.Size(334, 30)
        Me.nudRotationInterval.TabIndex = 7
        Me.nudRotationInterval.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Desktop1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.btnFadingInterval)
        Me.Controls.Add(Me.btnRotationInterval)
        Me.Controls.Add(Me.nudFadingInterval)
        Me.Controls.Add(Me.nudRotationInterval)
        Me.Controls.Add(Me.checkBox2)
        Me.Name = "Desktop1"
        Me.Size = New System.Drawing.Size(914, 475)
        Me.Text = "Wisej Sample CustomWallpaper"
        CType(Me.nudFadingInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRotationInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private customWallpaper As Web.Ext.CustomWallpaper.CustomWallpaper
    Private WithEvents checkBox2 As Web.CheckBox
    Private WithEvents btnFadingInterval As Web.Button
    Private WithEvents btnRotationInterval As Web.Button
    Private nudFadingInterval As Web.NumericUpDown
    Private nudRotationInterval As Web.NumericUpDown
End Class
