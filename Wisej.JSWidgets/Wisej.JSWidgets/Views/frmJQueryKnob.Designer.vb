<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJQueryKnob
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
        components = New ComponentModel.Container()
        groupBox1 = New Web.GroupBox()
        label4 = New Web.Label()
        lblCurrentTime = New Web.Label()
        label3 = New Web.Label()
        label2 = New Web.Label()
        label1 = New Web.Label()
        shape3 = New Web.Shape()
        shape2 = New Web.Shape()
        shape1 = New Web.Shape()
        knobSecond = New Web.Ext.jQueryKnob.Knob()
        knobMinute = New Web.Ext.jQueryKnob.Knob()
        knobHour = New Web.Ext.jQueryKnob.Knob()
        timerCurrentTime = New Web.Timer(components)
        groupBox2 = New Web.GroupBox()
        knobRandom = New Web.Ext.jQueryKnob.Knob()
        groupBox3 = New Web.GroupBox()
        knobCustom = New Web.Ext.jQueryKnob.Knob()
        cmbLineStyle = New Web.ComboBox()
        cmbKnobStyle = New Web.ComboBox()
        cmbBorderStyle = New Web.ComboBox()
        groupBox1.SuspendLayout()
        groupBox2.SuspendLayout()
        groupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' groupBox1
        ' 
        groupBox1.Controls.Add(label4)
        groupBox1.Controls.Add(lblCurrentTime)
        groupBox1.Controls.Add(label3)
        groupBox1.Controls.Add(label2)
        groupBox1.Controls.Add(label1)
        groupBox1.Controls.Add(shape3)
        groupBox1.Controls.Add(shape2)
        groupBox1.Controls.Add(shape1)
        groupBox1.Controls.Add(knobSecond)
        groupBox1.Controls.Add(knobMinute)
        groupBox1.Controls.Add(knobHour)
        groupBox1.Location = New Drawing.Point(29, 48)
        groupBox1.Name = "groupBox1"
        groupBox1.ShowCloseButton = True
        groupBox1.Size = New Drawing.Size(394, 500)
        groupBox1.TabIndex = 0
        groupBox1.Text = "KnobClock"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Drawing.Point(172, 432)
        label4.Name = "label4"
        label4.Size = New Drawing.Size(83, 15)
        label4.TabIndex = 6
        label4.Text = "Current Time: "
        ' 
        ' lblCurrentTime
        ' 
        lblCurrentTime.AutoSize = True
        lblCurrentTime.Location = New Drawing.Point(256, 432)
        lblCurrentTime.Name = "lblCurrentTime"
        lblCurrentTime.Size = New Drawing.Size(8, 15)
        lblCurrentTime.TabIndex = 4
        lblCurrentTime.Text = "-"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Drawing.Point(70, 471)
        label3.Name = "label3"
        label3.Size = New Drawing.Size(48, 15)
        label3.TabIndex = 5
        label3.Text = "Second"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Drawing.Point(70, 434)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(50, 15)
        label2.TabIndex = 4
        label2.Text = "Minutes"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Drawing.Point(70, 394)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(39, 15)
        label1.TabIndex = 3
        label1.Text = "Hours"
        ' 
        ' shape3
        ' 
        shape3.BackColor = Drawing.Color.SlateBlue
        shape3.BorderStyle.Size = 0
        shape3.BorderStyleBottom.Size = 0
        shape3.BorderStyleLeft.Size = 0
        shape3.BorderStyleRight.Size = 0
        shape3.BorderStyleTop.Size = 0
        shape3.Location = New Drawing.Point(27, 429)
        shape3.Name = "shape3"
        shape3.Size = New Drawing.Size(19, 20)
        ' 
        ' shape2
        ' 
        shape2.BackColor = Drawing.Color.Green
        shape2.BorderStyle.Size = 0
        shape2.BorderStyleBottom.Size = 0
        shape2.BorderStyleLeft.Size = 0
        shape2.BorderStyleRight.Size = 0
        shape2.BorderStyleTop.Size = 0
        shape2.Location = New Drawing.Point(27, 467)
        shape2.Name = "shape2"
        shape2.Size = New Drawing.Size(19, 20)
        ' 
        ' shape1
        ' 
        shape1.BackColor = Drawing.Color.OrangeRed
        shape1.BorderStyle.Size = 0
        shape1.BorderStyleBottom.Size = 0
        shape1.BorderStyleLeft.Size = 0
        shape1.BorderStyleRight.Size = 0
        shape1.BorderStyleTop.Size = 0
        shape1.Location = New Drawing.Point(27, 392)
        shape1.Name = "shape1"
        shape1.Size = New Drawing.Size(19, 20)
        ' 
        ' knobSecond
        ' 
        knobSecond.BackColor = Drawing.Color.FromArgb(2, 255, 255, 255)
        knobSecond.ForeColor = Drawing.Color.Green
        knobSecond.LineCapStyle = Web.Ext.jQueryKnob.LineCapType.Round
        knobSecond.Location = New Drawing.Point(133, 151)
        knobSecond.MaxValue = 60
        knobSecond.Name = "knobSecond"
        knobSecond.ShowInput = False
        knobSecond.Size = New Drawing.Size(120, 115)
        knobSecond.TabIndex = 2
        knobSecond.Text = "knob3"
        knobSecond.Value = 80
        ' 
        ' knobMinute
        ' 
        knobMinute.BackColor = Drawing.Color.FromArgb(2, 255, 255, 255)
        knobMinute.ForeColor = Drawing.Color.SlateBlue
        knobMinute.LineCapStyle = Web.Ext.jQueryKnob.LineCapType.Round
        knobMinute.Location = New Drawing.Point(83, 100)
        knobMinute.MaxValue = 60
        knobMinute.Name = "knobMinute"
        knobMinute.ShowInput = False
        knobMinute.Size = New Drawing.Size(224, 218)
        knobMinute.TabIndex = 1
        knobMinute.Text = "knob2"
        knobMinute.Value = 80
        ' 
        ' knobHour
        ' 
        knobHour.ForeColor = Drawing.Color.OrangeRed
        knobHour.LineCapStyle = Web.Ext.jQueryKnob.LineCapType.Round
        knobHour.Location = New Drawing.Point(27, 42)
        knobHour.MaxValue = 24
        knobHour.Name = "knobHour"
        knobHour.ShowInput = False
        knobHour.Size = New Drawing.Size(336, 335)
        knobHour.TabIndex = 0
        knobHour.Text = "knob1"
        knobHour.Value = 24
        ' 
        ' timerCurrentTime
        ' 
        timerCurrentTime.Interval = 800
        AddHandler timerCurrentTime.Tick, New EventHandler(AddressOf timerCurrentTime_Tick)
        ' 
        ' groupBox2
        ' 
        groupBox2.Controls.Add(knobRandom)
        groupBox2.Location = New Drawing.Point(451, 48)
        groupBox2.Name = "groupBox2"
        groupBox2.ShowCloseButton = True
        groupBox2.Size = New Drawing.Size(402, 251)
        groupBox2.TabIndex = 1
        groupBox2.Text = "Random position"
        ' 
        ' knobRandom
        ' 
        knobRandom.AngleArc = 230
        knobRandom.AngleOffset = 255
        knobRandom.Location = New Drawing.Point(97, 42)
        knobRandom.MinValue = 10
        knobRandom.Name = "knobRandom"
        knobRandom.Size = New Drawing.Size(212, 190)
        knobRandom.TabIndex = 0
        knobRandom.Text = "knob1"
        knobRandom.Value = 90
        ' 
        ' groupBox3
        ' 
        groupBox3.Controls.Add(cmbBorderStyle)
        groupBox3.Controls.Add(cmbKnobStyle)
        groupBox3.Controls.Add(cmbLineStyle)
        groupBox3.Controls.Add(knobCustom)
        groupBox3.Location = New Drawing.Point(451, 316)
        groupBox3.Name = "groupBox3"
        groupBox3.ShowCloseButton = True
        groupBox3.Size = New Drawing.Size(402, 232)
        groupBox3.TabIndex = 2
        groupBox3.Text = "Properties"
        ' 
        ' knobCustom
        ' 
        knobCustom.BorderStyle = Web.BorderStyle.Double
        knobCustom.LineCapStyle = Web.Ext.jQueryKnob.LineCapType.Round
        knobCustom.Location = New Drawing.Point(6, 21)
        knobCustom.Name = "knobCustom"
        knobCustom.Size = New Drawing.Size(226, 196)
        knobCustom.TabIndex = 1
        knobCustom.Text = "knob1"
        knobCustom.Value = 5
        ' 
        ' cmbLineStyle
        ' 
        cmbLineStyle.LabelText = "Lyne Style"
        cmbLineStyle.Location = New Drawing.Point(238, 21)
        cmbLineStyle.Name = "cmbLineStyle"
        cmbLineStyle.Size = New Drawing.Size(158, 42)
        cmbLineStyle.TabIndex = 2
        AddHandler cmbLineStyle.SelectedIndexChanged, New EventHandler(AddressOf cmbLineStyle_SelectedIndexChanged)
        ' 
        ' cmbKnobStyle
        ' 
        cmbKnobStyle.LabelText = "Knob Style"
        cmbKnobStyle.Location = New Drawing.Point(238, 99)
        cmbKnobStyle.Name = "cmbKnobStyle"
        cmbKnobStyle.Size = New Drawing.Size(158, 42)
        cmbKnobStyle.TabIndex = 3
        AddHandler cmbKnobStyle.SelectedIndexChanged, New EventHandler(AddressOf cmbKnobStyle_SelectedIndexChanged)
        ' 
        ' cmbBorderStyle
        ' 
        cmbBorderStyle.LabelText = "Border Style"
        cmbBorderStyle.Location = New Drawing.Point(238, 175)
        cmbBorderStyle.Name = "cmbBorderStyle"
        cmbBorderStyle.Size = New Drawing.Size(158, 42)
        cmbBorderStyle.TabIndex = 4
        AddHandler cmbBorderStyle.SelectedIndexChanged, New EventHandler(AddressOf cmbBorderStyle_SelectedIndexChanged)
        ' 
        ' frmJQueryKnob
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(888, 619)
        Controls.Add(groupBox3)
        Controls.Add(groupBox2)
        Controls.Add(groupBox1)
        Name = "frmJQueryKnob"
        Text = "frmJQueryKnob"
        AddHandler Load, New EventHandler(AddressOf frmJQueryKnob_Load)
        groupBox1.ResumeLayout(False)
        groupBox1.PerformLayout()
        groupBox2.ResumeLayout(False)
        groupBox3.ResumeLayout(False)
        groupBox3.PerformLayout()
        ResumeLayout(False)

    End Sub

#End Region

    Private groupBox1 As Web.GroupBox
    Private knobSecond As Web.Ext.jQueryKnob.Knob
    Private knobMinute As Web.Ext.jQueryKnob.Knob
    Private knobHour As Web.Ext.jQueryKnob.Knob
    Private timerCurrentTime As Web.Timer
    Private lblCurrentTime As Web.Label
    Private label3 As Web.Label
    Private label2 As Web.Label
    Private label1 As Web.Label
    Private shape3 As Web.Shape
    Private shape2 As Web.Shape
    Private shape1 As Web.Shape
    Private label4 As Web.Label
    Private groupBox2 As Web.GroupBox
    Private knobRandom As Web.Ext.jQueryKnob.Knob
    Private groupBox3 As Web.GroupBox
    Private cmbBorderStyle As Web.ComboBox
    Private cmbKnobStyle As Web.ComboBox
    Private cmbLineStyle As Web.ComboBox
    Private knobCustom As Web.Ext.jQueryKnob.Knob
End Class
