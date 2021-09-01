<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Desktop1
    Inherits Wisej.Web.Desktop

    ''' <summary> 
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

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
        components = New System.ComponentModel.Container()
        customWallpaper = New Wisej.Web.Ext.CustomWallpaper.CustomWallpaper(components)
        checkBox2 = New Wisej.Web.CheckBox()
        btnFadingInterval = New Wisej.Web.Button()
        btnRotationInterval = New Wisej.Web.Button()
        nudFadingInterval = New Wisej.Web.NumericUpDown()
        nudRotationInterval = New Wisej.Web.NumericUpDown()
        CType(nudFadingInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(nudRotationInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' customWallpaper
        ' 
        customWallpaper.FadeTime = 3300
        customWallpaper.RotationInterval = 3000
        ' 
        ' checkBox2
        ' 
        checkBox2.Checked = True
        checkBox2.CheckState = Wisej.Web.CheckState.Checked
        checkBox2.Font = New System.Drawing.Font("default", 16.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        checkBox2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        checkBox2.Location = New System.Drawing.Point(26, 111)
        checkBox2.Name = "checkBox2"
        checkBox2.Size = New System.Drawing.Size(277, 26)
        checkBox2.TabIndex = 5
        checkBox2.Text = "Enable / Disable Fading Animation"
        ' 
        ' btnFadingInterval
        ' 
        btnFadingInterval.AutoSize = True
        btnFadingInterval.Location = New System.Drawing.Point(376, 60)
        btnFadingInterval.Name = "btnFadingInterval"
        btnFadingInterval.Size = New System.Drawing.Size(170, 27)
        btnFadingInterval.TabIndex = 8
        btnFadingInterval.Text = "Apply Fading Interval"
        ' 
        ' btnRotationInterval
        ' 
        btnRotationInterval.AutoSize = True
        btnRotationInterval.Location = New System.Drawing.Point(376, 13)
        btnRotationInterval.Name = "btnRotationInterval"
        btnRotationInterval.Size = New System.Drawing.Size(170, 27)
        btnRotationInterval.TabIndex = 9
        btnRotationInterval.Text = "Apply Rotation Interval"
        ' 
        ' nudFadingInterval
        ' 
        nudFadingInterval.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        nudFadingInterval.Location = New System.Drawing.Point(26, 62)
        nudFadingInterval.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudFadingInterval.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        nudFadingInterval.Name = "nudFadingInterval"
        nudFadingInterval.Size = New System.Drawing.Size(334, 22)
        nudFadingInterval.TabIndex = 6
        nudFadingInterval.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        ' 
        ' nudRotationInterval
        ' 
        nudRotationInterval.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        nudRotationInterval.Location = New System.Drawing.Point(26, 16)
        nudRotationInterval.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudRotationInterval.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        nudRotationInterval.Name = "nudRotationInterval"
        nudRotationInterval.Size = New System.Drawing.Size(334, 22)
        nudRotationInterval.TabIndex = 7
        nudRotationInterval.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        ' 
        ' Desktop1
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Controls.Add(btnFadingInterval)
        Controls.Add(btnRotationInterval)
        Controls.Add(nudFadingInterval)
        Controls.Add(nudRotationInterval)
        Controls.Add(checkBox2)
        Name = "Desktop1"
        Size = New System.Drawing.Size(1814, 710)
        Text = "Wisej Sample CustomWallpaper"
        CType(nudFadingInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(nudRotationInterval, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

#End Region

    Friend WithEvents customWallpaper As Wisej.Web.Ext.CustomWallpaper.CustomWallpaper
    Friend WithEvents checkBox2 As Wisej.Web.CheckBox
    Friend WithEvents btnFadingInterval As Wisej.Web.Button
    Friend WithEvents btnRotationInterval As Wisej.Web.Button
    Friend WithEvents nudFadingInterval As Wisej.Web.NumericUpDown
    Friend WithEvents nudRotationInterval As Wisej.Web.NumericUpDown
End Class
