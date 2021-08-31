Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJQueryKnob
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
        Me.components = New System.ComponentModel.Container()
        Me.groupBox1 = New Wisej.Web.GroupBox()
        Me.label4 = New Wisej.Web.Label()
        Me.lblCurrentTime = New Wisej.Web.Label()
        Me.label3 = New Wisej.Web.Label()
        Me.label2 = New Wisej.Web.Label()
        Me.label1 = New Wisej.Web.Label()
        Me.shape3 = New Wisej.Web.Shape()
        Me.shape2 = New Wisej.Web.Shape()
        Me.shape1 = New Wisej.Web.Shape()
        Me.knobSecond = New Wisej.Web.Ext.jQueryKnob.Knob()
        Me.knobMinute = New Wisej.Web.Ext.jQueryKnob.Knob()
        Me.knobHour = New Wisej.Web.Ext.jQueryKnob.Knob()
        Me.timerCurrentTime = New Wisej.Web.Timer(Me.components)
        Me.groupBox2 = New Wisej.Web.GroupBox()
        Me.knobRandom = New Wisej.Web.Ext.jQueryKnob.Knob()
        Me.groupBox3 = New Wisej.Web.GroupBox()
        Me.cmbBorderStyle = New Wisej.Web.ComboBox()
        Me.cmbKnobStyle = New Wisej.Web.ComboBox()
        Me.cmbLineStyle = New Wisej.Web.ComboBox()
        Me.knobCustom = New Wisej.Web.Ext.jQueryKnob.Knob()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.lblCurrentTime)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.shape3)
        Me.groupBox1.Controls.Add(Me.shape2)
        Me.groupBox1.Controls.Add(Me.shape1)
        Me.groupBox1.Controls.Add(Me.knobSecond)
        Me.groupBox1.Controls.Add(Me.knobMinute)
        Me.groupBox1.Controls.Add(Me.knobHour)
        Me.groupBox1.Location = New System.Drawing.Point(29, 48)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.ShowCloseButton = True
        Me.groupBox1.Size = New System.Drawing.Size(394, 500)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.Text = "KnobClock"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(172, 432)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(84, 15)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Current Time: "
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.Location = New System.Drawing.Point(256, 432)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(9, 15)
        Me.lblCurrentTime.TabIndex = 4
        Me.lblCurrentTime.Text = "-"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(70, 471)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(49, 15)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Second"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(70, 434)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(50, 15)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Minutes"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(70, 394)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(39, 15)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Hours"
        '
        'shape3
        '
        Me.shape3.BackColor = System.Drawing.Color.SlateBlue
        Me.shape3.BorderStyle.Size = 0
        Me.shape3.BorderStyleBottom.Size = 0
        Me.shape3.BorderStyleLeft.Size = 0
        Me.shape3.BorderStyleRight.Size = 0
        Me.shape3.BorderStyleTop.Size = 0
        Me.shape3.Location = New System.Drawing.Point(27, 429)
        Me.shape3.Name = "shape3"
        Me.shape3.Size = New System.Drawing.Size(19, 20)
        '
        'shape2
        '
        Me.shape2.BackColor = System.Drawing.Color.Green
        Me.shape2.BorderStyle.Size = 0
        Me.shape2.BorderStyleBottom.Size = 0
        Me.shape2.BorderStyleLeft.Size = 0
        Me.shape2.BorderStyleRight.Size = 0
        Me.shape2.BorderStyleTop.Size = 0
        Me.shape2.Location = New System.Drawing.Point(27, 467)
        Me.shape2.Name = "shape2"
        Me.shape2.Size = New System.Drawing.Size(19, 20)
        '
        'shape1
        '
        Me.shape1.BackColor = System.Drawing.Color.OrangeRed
        Me.shape1.BorderStyle.Size = 0
        Me.shape1.BorderStyleBottom.Size = 0
        Me.shape1.BorderStyleLeft.Size = 0
        Me.shape1.BorderStyleRight.Size = 0
        Me.shape1.BorderStyleTop.Size = 0
        Me.shape1.Location = New System.Drawing.Point(27, 392)
        Me.shape1.Name = "shape1"
        Me.shape1.Size = New System.Drawing.Size(19, 20)
        '
        'knobSecond
        '
        Me.knobSecond.BackColor = System.Drawing.Color.FromArgb(2, 255, 255, 255)
        Me.knobSecond.ForeColor = System.Drawing.Color.Green
        Me.knobSecond.LineCapStyle = Wisej.Web.Ext.jQueryKnob.LineCapType.Round
        Me.knobSecond.Location = New System.Drawing.Point(133, 151)
        Me.knobSecond.MaxValue = 60
        Me.knobSecond.Name = "knobSecond"
        Me.knobSecond.ShowInput = False
        Me.knobSecond.Size = New System.Drawing.Size(120, 115)
        Me.knobSecond.TabIndex = 2
        Me.knobSecond.Text = "knob3"
        Me.knobSecond.Value = 80
        '
        'knobMinute
        '
        Me.knobMinute.BackColor = System.Drawing.Color.FromArgb(2, 255, 255, 255)
        Me.knobMinute.ForeColor = System.Drawing.Color.SlateBlue
        Me.knobMinute.LineCapStyle = Wisej.Web.Ext.jQueryKnob.LineCapType.Round
        Me.knobMinute.Location = New System.Drawing.Point(83, 100)
        Me.knobMinute.MaxValue = 60
        Me.knobMinute.Name = "knobMinute"
        Me.knobMinute.ShowInput = False
        Me.knobMinute.Size = New System.Drawing.Size(224, 218)
        Me.knobMinute.TabIndex = 1
        Me.knobMinute.Text = "knob2"
        Me.knobMinute.Value = 80
        '
        'knobHour
        '
        Me.knobHour.ForeColor = System.Drawing.Color.OrangeRed
        Me.knobHour.LineCapStyle = Wisej.Web.Ext.jQueryKnob.LineCapType.Round
        Me.knobHour.Location = New System.Drawing.Point(27, 42)
        Me.knobHour.MaxValue = 24
        Me.knobHour.Name = "knobHour"
        Me.knobHour.ShowInput = False
        Me.knobHour.Size = New System.Drawing.Size(336, 335)
        Me.knobHour.TabIndex = 0
        Me.knobHour.Text = "knob1"
        Me.knobHour.Value = 24
        '
        'timerCurrentTime
        '
        Me.timerCurrentTime.Interval = 800
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.knobRandom)
        Me.groupBox2.Location = New System.Drawing.Point(451, 48)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.ShowCloseButton = True
        Me.groupBox2.Size = New System.Drawing.Size(402, 251)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.Text = "Random position"
        '
        'knobRandom
        '
        Me.knobRandom.AngleArc = 230
        Me.knobRandom.AngleOffset = 255
        Me.knobRandom.Location = New System.Drawing.Point(97, 42)
        Me.knobRandom.MinValue = 10
        Me.knobRandom.Name = "knobRandom"
        Me.knobRandom.Size = New System.Drawing.Size(212, 190)
        Me.knobRandom.TabIndex = 0
        Me.knobRandom.Text = "knob1"
        Me.knobRandom.Value = 90
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.cmbBorderStyle)
        Me.groupBox3.Controls.Add(Me.cmbKnobStyle)
        Me.groupBox3.Controls.Add(Me.cmbLineStyle)
        Me.groupBox3.Controls.Add(Me.knobCustom)
        Me.groupBox3.Location = New System.Drawing.Point(451, 316)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.ShowCloseButton = True
        Me.groupBox3.Size = New System.Drawing.Size(402, 232)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.Text = "Properties"
        '
        'cmbBorderStyle
        '
        Me.cmbBorderStyle.LabelText = "Border Style"
        Me.cmbBorderStyle.Location = New System.Drawing.Point(238, 175)
        Me.cmbBorderStyle.Name = "cmbBorderStyle"
        Me.cmbBorderStyle.Size = New System.Drawing.Size(158, 42)
        Me.cmbBorderStyle.TabIndex = 4
        '
        'cmbKnobStyle
        '
        Me.cmbKnobStyle.LabelText = "Knob Style"
        Me.cmbKnobStyle.Location = New System.Drawing.Point(238, 99)
        Me.cmbKnobStyle.Name = "cmbKnobStyle"
        Me.cmbKnobStyle.Size = New System.Drawing.Size(158, 42)
        Me.cmbKnobStyle.TabIndex = 3
        '
        'cmbLineStyle
        '
        Me.cmbLineStyle.LabelText = "Lyne Style"
        Me.cmbLineStyle.Location = New System.Drawing.Point(238, 21)
        Me.cmbLineStyle.Name = "cmbLineStyle"
        Me.cmbLineStyle.Size = New System.Drawing.Size(158, 42)
        Me.cmbLineStyle.TabIndex = 2
        '
        'knobCustom
        '
        Me.knobCustom.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.knobCustom.LineCapStyle = Wisej.Web.Ext.jQueryKnob.LineCapType.Round
        Me.knobCustom.Location = New System.Drawing.Point(6, 21)
        Me.knobCustom.Name = "knobCustom"
        Me.knobCustom.Size = New System.Drawing.Size(226, 196)
        Me.knobCustom.TabIndex = 1
        Me.knobCustom.Text = "knob1"
        Me.knobCustom.Value = 5
        '
        'frmJQueryKnob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 619)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "frmJQueryKnob"
        Me.Text = "frmJQueryKnob"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents groupBox1 As Wisej.Web.GroupBox
    Friend WithEvents knobSecond As Wisej.Web.Ext.jQueryKnob.Knob
    Friend WithEvents knobMinute As Wisej.Web.Ext.jQueryKnob.Knob
    Friend WithEvents knobHour As Wisej.Web.Ext.jQueryKnob.Knob
    Friend WithEvents timerCurrentTime As Wisej.Web.Timer
    Friend WithEvents lblCurrentTime As Wisej.Web.Label
    Friend WithEvents label3 As Wisej.Web.Label
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents shape3 As Wisej.Web.Shape
    Friend WithEvents shape2 As Wisej.Web.Shape
    Friend WithEvents shape1 As Wisej.Web.Shape
    Friend WithEvents label4 As Wisej.Web.Label
    Friend WithEvents groupBox2 As Wisej.Web.GroupBox
    Friend WithEvents knobRandom As Wisej.Web.Ext.jQueryKnob.Knob
    Friend WithEvents groupBox3 As Wisej.Web.GroupBox
    Friend WithEvents cmbBorderStyle As Wisej.Web.ComboBox
    Friend WithEvents cmbKnobStyle As Wisej.Web.ComboBox
    Friend WithEvents cmbLineStyle As Wisej.Web.ComboBox
    Friend WithEvents knobCustom As Wisej.Web.Ext.jQueryKnob.Knob
End Class
