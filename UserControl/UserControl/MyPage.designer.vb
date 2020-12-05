
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
        label1 = New Wisej.Web.Label()
        colorPanel = New Wisej.Web.Panel()
        label2 = New Wisej.Web.Label()
        colorSlider = New ColorSlider()
        checkBoxShowValueBubble = New Wisej.Web.CheckBox()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.Location = New Drawing.Point(158, 61)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(76, 18)
        label1.TabIndex = 2
        label1.Text = "Color Panel"
        ' 
        ' colorPanel
        ' 
        colorPanel.BorderStyle = Wisej.Web.BorderStyle.Solid
        colorPanel.Location = New Drawing.Point(49, 112)
        colorPanel.Name = "colorPanel"
        colorPanel.Size = New Drawing.Size(295, 228)
        colorPanel.TabIndex = 1
        colorPanel.TabStop = True
        ' 
        ' label2
        ' 
        label2.Location = New Drawing.Point(492, 61)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(76, 18)
        label2.TabIndex = 3
        label2.Text = "Color Slider"
        ' 
        ' colorSlider
        ' 
        colorSlider.Location = New Drawing.Point(383, 112)
        colorSlider.Name = "colorSlider"
        colorSlider.Size = New Drawing.Size(295, 228)
        colorSlider.TabIndex = 4
        AddHandler colorSlider.ValueChanged, New EventHandler(AddressOf colorSlider_ValueChanged)
        ' 
        ' checkBoxShowValueBubble
        ' 
        checkBoxShowValueBubble.Checked = True
        checkBoxShowValueBubble.CheckState = Wisej.Web.CheckState.Checked
        checkBoxShowValueBubble.Location = New Drawing.Point(459, 365)
        checkBoxShowValueBubble.Name = "checkBoxShowValueBubble"
        checkBoxShowValueBubble.Size = New Drawing.Size(145, 22)
        checkBoxShowValueBubble.TabIndex = 5
        checkBoxShowValueBubble.Text = "Show Value Bubble"
        AddHandler checkBoxShowValueBubble.CheckedChanged, New EventHandler(AddressOf checkBoxShowValueBubble_CheckedChanged)
        ' 
        ' MyPage
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Controls.Add(checkBoxShowValueBubble)
        Controls.Add(colorSlider)
        Controls.Add(label2)
        Controls.Add(colorPanel)
        Controls.Add(label1)
        Name = "MyPage"
        Size = New Drawing.Size(629, 585)
        AddHandler Load, New EventHandler(AddressOf MyPage_Load)
        ResumeLayout(False)
        PerformLayout()
    End Sub


#End Region

    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents colorPanel As Wisej.Web.Panel
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents colorSlider As ColorSlider
    Friend WithEvents checkBoxShowValueBubble As Wisej.Web.CheckBox
End Class
