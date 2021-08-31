Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCountUp
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
        Me.countUp1 = New Wisej.Web.Ext.CountUp.CountUp()
        Me.nudNewValue = New Wisej.Web.NumericUpDown()
        Me.chkGrouping = New Wisej.Web.CheckBox()
        Me.chkEasing = New Wisej.Web.CheckBox()
        Me.btnApplyValue = New Wisej.Web.Button()
        Me.nudDuration = New Wisej.Web.NumericUpDown()
        Me.btnNewDuration = New Wisej.Web.Button()
        CType(Me.nudNewValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'countUp1
        '
        Me.countUp1.Font = New System.Drawing.Font("default", 44.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.countUp1.Location = New System.Drawing.Point(28, 28)
        Me.countUp1.Name = "countUp1"
        Me.countUp1.Size = New System.Drawing.Size(716, 60)
        Me.countUp1.TabIndex = 0
        Me.countUp1.TextAlign = Wisej.Web.HorizontalAlignment.Center
        Me.countUp1.Value = 9550.0!
        '
        'nudNewValue
        '
        Me.nudNewValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.nudNewValue.LabelText = "Value"
        Me.nudNewValue.Location = New System.Drawing.Point(14, 128)
        Me.nudNewValue.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudNewValue.Name = "nudNewValue"
        Me.nudNewValue.Size = New System.Drawing.Size(228, 53)
        Me.nudNewValue.TabIndex = 1
        Me.nudNewValue.Value = New Decimal(New Integer() {9550, 0, 0, 0})
        '
        'chkGrouping
        '
        Me.chkGrouping.Checked = True
        Me.chkGrouping.CheckState = Wisej.Web.CheckState.Checked
        Me.chkGrouping.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.chkGrouping.Location = New System.Drawing.Point(14, 307)
        Me.chkGrouping.Name = "chkGrouping"
        Me.chkGrouping.Size = New System.Drawing.Size(156, 30)
        Me.chkGrouping.TabIndex = 2
        Me.chkGrouping.Text = "Use Grouping"
        '
        'chkEasing
        '
        Me.chkEasing.Checked = True
        Me.chkEasing.CheckState = Wisej.Web.CheckState.Checked
        Me.chkEasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.chkEasing.Location = New System.Drawing.Point(14, 358)
        Me.chkEasing.Name = "chkEasing"
        Me.chkEasing.Size = New System.Drawing.Size(135, 30)
        Me.chkEasing.TabIndex = 3
        Me.chkEasing.Text = "Use Easing"
        '
        'btnApplyValue
        '
        Me.btnApplyValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnApplyValue.Location = New System.Drawing.Point(282, 154)
        Me.btnApplyValue.Name = "btnApplyValue"
        Me.btnApplyValue.Size = New System.Drawing.Size(191, 27)
        Me.btnApplyValue.TabIndex = 4
        Me.btnApplyValue.Text = "Apply New Value"
        '
        'nudDuration
        '
        Me.nudDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.nudDuration.LabelText = "Duration"
        Me.nudDuration.Location = New System.Drawing.Point(14, 222)
        Me.nudDuration.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudDuration.Name = "nudDuration"
        Me.nudDuration.Size = New System.Drawing.Size(228, 53)
        Me.nudDuration.TabIndex = 5
        Me.nudDuration.Value = New Decimal(New Integer() {2500, 0, 0, 0})
        '
        'btnNewDuration
        '
        Me.btnNewDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnNewDuration.Location = New System.Drawing.Point(282, 248)
        Me.btnNewDuration.Name = "btnNewDuration"
        Me.btnNewDuration.Size = New System.Drawing.Size(191, 27)
        Me.btnNewDuration.TabIndex = 4
        Me.btnNewDuration.Text = "Apply Duration"
        '
        'frmCountUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 528)
        Me.Controls.Add(Me.nudDuration)
        Me.Controls.Add(Me.btnNewDuration)
        Me.Controls.Add(Me.btnApplyValue)
        Me.Controls.Add(Me.chkEasing)
        Me.Controls.Add(Me.chkGrouping)
        Me.Controls.Add(Me.nudNewValue)
        Me.Controls.Add(Me.countUp1)
        Me.Name = "frmCountUp"
        Me.Text = "CountUp"
        CType(Me.nudNewValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents countUp1 As Wisej.Web.Ext.CountUp.CountUp
    Friend WithEvents nudNewValue As Wisej.Web.NumericUpDown
    Friend WithEvents chkGrouping As Wisej.Web.CheckBox
    Friend WithEvents chkEasing As Wisej.Web.CheckBox
    Friend WithEvents btnApplyValue As Wisej.Web.Button
    Friend WithEvents nudDuration As Wisej.Web.NumericUpDown
    Friend WithEvents btnNewDuration As Wisej.Web.Button
End Class
