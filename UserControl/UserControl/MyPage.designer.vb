
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyPage
    Inherits Wisej.Web.Page
    ''' <summary> 
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer


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
        Me.label1 = New Wisej.Web.Label()
        Me.colorPanel = New Wisej.Web.Panel()
        Me.label2 = New Wisej.Web.Label()
        Me.colorSlider = New UserControl.ColorSlider()
        Me.checkBoxShowValueBubble = New Wisej.Web.CheckBox()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(158, 61)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(76, 18)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Color Panel"
        '
        'colorPanel
        '
        Me.colorPanel.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.colorPanel.Location = New System.Drawing.Point(49, 112)
        Me.colorPanel.Name = "colorPanel"
        Me.colorPanel.Size = New System.Drawing.Size(295, 228)
        Me.colorPanel.TabIndex = 1
        Me.colorPanel.TabStop = True
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(492, 61)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(76, 18)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Color Slider"
        '
        'colorSlider
        '
        Me.colorSlider.Location = New System.Drawing.Point(383, 112)
        Me.colorSlider.Name = "colorSlider"
        Me.colorSlider.Size = New System.Drawing.Size(295, 228)
        Me.colorSlider.TabIndex = 4
        '
        'checkBoxShowValueBubble
        '
        Me.checkBoxShowValueBubble.Checked = True
        Me.checkBoxShowValueBubble.CheckState = Wisej.Web.CheckState.Checked
        Me.checkBoxShowValueBubble.Location = New System.Drawing.Point(459, 365)
        Me.checkBoxShowValueBubble.Name = "checkBoxShowValueBubble"
        Me.checkBoxShowValueBubble.Size = New System.Drawing.Size(146, 22)
        Me.checkBoxShowValueBubble.TabIndex = 5
        Me.checkBoxShowValueBubble.Text = "Show Value Bubble"
        '
        'MyPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.checkBoxShowValueBubble)
        Me.Controls.Add(Me.colorSlider)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.colorPanel)
        Me.Controls.Add(Me.label1)
        Me.Name = "MyPage"
        Me.Size = New System.Drawing.Size(865, 838)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


#End Region

    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents colorPanel As Wisej.Web.Panel
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents colorSlider As ColorSlider
    Friend WithEvents checkBoxShowValueBubble As Wisej.Web.CheckBox
End Class
