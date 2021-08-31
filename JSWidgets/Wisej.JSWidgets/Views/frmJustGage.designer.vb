Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJustGaje
    Inherits Wisej.Web.Form
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

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
        Me.justGageTest = New Wisej.Web.Ext.JustGage.JustGage()
        Me.numericUpDown1 = New Wisej.Web.NumericUpDown()
        Me.numericUpDown2 = New Wisej.Web.NumericUpDown()
        Me.trackBarGageChange = New Wisej.Web.TrackBar()
        Me.chkDonut = New Wisej.Web.CheckBox()
        Me.chkHumanFriendly = New Wisej.Web.CheckBox()
        Me.cbAnimationType = New Wisej.Web.ComboBox()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBarGageChange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'justGageTest
        '
        Me.justGageTest.Location = New System.Drawing.Point(127, 3)
        Me.justGageTest.Maximum = 1001.0!
        Me.justGageTest.Name = "justGageTest"
        Me.justGageTest.Size = New System.Drawing.Size(365, 241)
        Me.justGageTest.TabIndex = 0
        Me.justGageTest.Text = "justGage Test"
        Me.justGageTest.Value = 12.0!
        '
        'numericUpDown1
        '
        Me.numericUpDown1.LabelText = "Minimun"
        Me.numericUpDown1.Location = New System.Drawing.Point(127, 271)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(120, 42)
        Me.numericUpDown1.TabIndex = 1
        '
        'numericUpDown2
        '
        Me.numericUpDown2.LabelText = "Maximun"
        Me.numericUpDown2.Location = New System.Drawing.Point(310, 271)
        Me.numericUpDown2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numericUpDown2.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(120, 42)
        Me.numericUpDown2.TabIndex = 2
        Me.numericUpDown2.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'trackBarGageChange
        '
        Me.trackBarGageChange.Location = New System.Drawing.Point(127, 473)
        Me.trackBarGageChange.Name = "trackBarGageChange"
        Me.trackBarGageChange.Size = New System.Drawing.Size(365, 34)
        Me.trackBarGageChange.TabIndex = 3
        '
        'chkDonut
        '
        Me.chkDonut.Location = New System.Drawing.Point(127, 345)
        Me.chkDonut.Name = "chkDonut"
        Me.chkDonut.Size = New System.Drawing.Size(67, 22)
        Me.chkDonut.TabIndex = 4
        Me.chkDonut.Text = "Donut"
        '
        'chkHumanFriendly
        '
        Me.chkHumanFriendly.Location = New System.Drawing.Point(310, 345)
        Me.chkHumanFriendly.Name = "chkHumanFriendly"
        Me.chkHumanFriendly.Size = New System.Drawing.Size(124, 22)
        Me.chkHumanFriendly.TabIndex = 6
        Me.chkHumanFriendly.Text = "Human Friendly"
        '
        'cbAnimationType
        '
        Me.cbAnimationType.LabelText = "Animation Type"
        Me.cbAnimationType.Location = New System.Drawing.Point(127, 392)
        Me.cbAnimationType.Name = "cbAnimationType"
        Me.cbAnimationType.Size = New System.Drawing.Size(156, 42)
        Me.cbAnimationType.TabIndex = 7
        '
        'frmJustGaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 546)
        Me.Controls.Add(Me.cbAnimationType)
        Me.Controls.Add(Me.chkHumanFriendly)
        Me.Controls.Add(Me.chkDonut)
        Me.Controls.Add(Me.trackBarGageChange)
        Me.Controls.Add(Me.numericUpDown2)
        Me.Controls.Add(Me.numericUpDown1)
        Me.Controls.Add(Me.justGageTest)
        Me.Name = "frmJustGaje"
        Me.Text = "frmJustGaje"
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBarGageChange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents justGageTest As Wisej.Web.Ext.JustGage.JustGage
    Friend WithEvents numericUpDown1 As Wisej.Web.NumericUpDown
    Friend WithEvents numericUpDown2 As Wisej.Web.NumericUpDown
    Friend WithEvents trackBarGageChange As Wisej.Web.TrackBar
    Friend WithEvents chkDonut As Wisej.Web.CheckBox
    Friend WithEvents chkHumanFriendly As Wisej.Web.CheckBox
    Friend WithEvents cbAnimationType As Wisej.Web.ComboBox
End Class
