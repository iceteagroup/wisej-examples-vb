<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCountUp
    Inherits Wisej.Web.Form
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
        countUp1 = New Web.Ext.CountUp.CountUp()
        nudNewValue = New Web.NumericUpDown()
        chkGrouping = New Web.CheckBox()
        chkEasing = New Web.CheckBox()
        btnApplyValue = New Web.Button()
        nudDuration = New Web.NumericUpDown()
        btnNewDuration = New Web.Button()
        CType(nudNewValue, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudDuration, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' countUp1
        ' 
        countUp1.Font = New Drawing.Font("default", 44.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        countUp1.Location = New Drawing.Point(28, 28)
        countUp1.Name = "countUp1"
        countUp1.Size = New Drawing.Size(716, 60)
        countUp1.TabIndex = 0
        countUp1.TextAlign = Web.HorizontalAlignment.Center
        countUp1.Value = 9550.0F
        ' 
        ' nudNewValue
        ' 
        nudNewValue.Font = New Drawing.Font("Microsoft Sans Serif", 20.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        nudNewValue.LabelText = "Value"
        nudNewValue.Location = New Drawing.Point(14, 128)
        nudNewValue.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        nudNewValue.Name = "nudNewValue"
        nudNewValue.Size = New Drawing.Size(228, 53)
        nudNewValue.TabIndex = 1
        nudNewValue.Value = New Decimal(New Integer() {9550, 0, 0, 0})
        ' 
        ' chkGrouping
        ' 
        chkGrouping.Checked = True
        chkGrouping.CheckState = Web.CheckState.Checked
        chkGrouping.Font = New Drawing.Font("Microsoft Sans Serif", 20.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        chkGrouping.Location = New Drawing.Point(14, 307)
        chkGrouping.Name = "chkGrouping"
        chkGrouping.Size = New Drawing.Size(155, 30)
        chkGrouping.TabIndex = 2
        chkGrouping.Text = "Use Grouping"
        AddHandler chkGrouping.CheckedChanged, New EventHandler(AddressOf chkGrouping_CheckedChanged)
        ' 
        ' chkEasing
        ' 
        chkEasing.Checked = True
        chkEasing.CheckState = Web.CheckState.Checked
        chkEasing.Font = New Drawing.Font("Microsoft Sans Serif", 20.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        chkEasing.Location = New Drawing.Point(14, 358)
        chkEasing.Name = "chkEasing"
        chkEasing.Size = New Drawing.Size(134, 30)
        chkEasing.TabIndex = 3
        chkEasing.Text = "Use Easing"
        AddHandler chkEasing.CheckedChanged, New EventHandler(AddressOf chkEasing_CheckedChanged)
        ' 
        ' btnApplyValue
        ' 
        btnApplyValue.Font = New Drawing.Font("Microsoft Sans Serif", 20.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        btnApplyValue.Location = New Drawing.Point(282, 154)
        btnApplyValue.Name = "btnApplyValue"
        btnApplyValue.Size = New Drawing.Size(191, 27)
        btnApplyValue.TabIndex = 4
        btnApplyValue.Text = "Apply New Value"
        AddHandler btnApplyValue.Click, New EventHandler(AddressOf btnApplyValue_Click)
        ' 
        ' nudDuration
        ' 
        nudDuration.Font = New Drawing.Font("Microsoft Sans Serif", 20.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        nudDuration.LabelText = "Duration"
        nudDuration.Location = New Drawing.Point(14, 222)
        nudDuration.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        nudDuration.Name = "nudDuration"
        nudDuration.Size = New Drawing.Size(228, 53)
        nudDuration.TabIndex = 5
        nudDuration.Value = New Decimal(New Integer() {2500, 0, 0, 0})
        ' 
        ' btnNewDuration
        ' 
        btnNewDuration.Font = New Drawing.Font("Microsoft Sans Serif", 20.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Pixel)
        btnNewDuration.Location = New Drawing.Point(282, 248)
        btnNewDuration.Name = "btnNewDuration"
        btnNewDuration.Size = New Drawing.Size(191, 27)
        btnNewDuration.TabIndex = 4
        btnNewDuration.Text = "Apply Duration"
        AddHandler btnNewDuration.Click, New EventHandler(AddressOf btnNewDuration_Click)
        ' 
        ' frmCountUp
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(774, 528)
        Controls.Add(nudDuration)
        Controls.Add(btnNewDuration)
        Controls.Add(btnApplyValue)
        Controls.Add(chkEasing)
        Controls.Add(chkGrouping)
        Controls.Add(nudNewValue)
        Controls.Add(countUp1)
        Name = "frmCountUp"
        Text = "CountUp"
        CType(nudNewValue, ComponentModel.ISupportInitialize).EndInit()
        CType(nudDuration, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Private countUp1 As Web.Ext.CountUp.CountUp
    Private nudNewValue As Web.NumericUpDown
    Private chkGrouping As Web.CheckBox
    Private chkEasing As Web.CheckBox
    Private btnApplyValue As Web.Button
    Private nudDuration As Web.NumericUpDown
    Private btnNewDuration As Web.Button
End Class
