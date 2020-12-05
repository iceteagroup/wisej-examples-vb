<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page1))
        Me.polymerWidget1 = New Wisej.Web.Ext.Polymer.PolymerWidget()
        Me.label1 = New Wisej.Web.Label()
        Me.label2 = New Wisej.Web.Label()
        Me.button1 = New Wisej.Web.Button()
        Me.button2 = New Wisej.Web.Button()
        Me.label3 = New Wisej.Web.Label()
        Me.label4 = New Wisej.Web.Label()
        Me.styleSheet = New Wisej.Web.StyleSheet(Me.components)
        Me.paperButton1 = New Wisej.PolymerExample.PaperButton()
        Me.polymerComponent1 = New Wisej.Web.Ext.Polymer.PolymerComponent(Me.components)
        Me.googleChart1 = New Wisej.PolymerExample.GoogleChart()
        Me.paperRadioButton2 = New Wisej.PolymerExample.PaperRadioButton()
        Me.paperRadioButton1 = New Wisej.PolymerExample.PaperRadioButton()
        Me.paperRadioGroup1 = New Wisej.PolymerExample.PaperRadioGroup()
        Me.ironIcon1 = New Wisej.PolymerExample.IronIcon()
        Me.paperProgress1 = New Wisej.PolymerExample.PaperProgress()
        Me.paperSlider1 = New Wisej.PolymerExample.PaperSlider()
        Me.paperCheckBox1 = New Wisej.PolymerExample.PaperCheckBox()
        Me.SuspendLayout()
        '
        'polymerWidget1
        '
        Me.polymerWidget1.ElementType = "paper-slider"
        Me.polymerWidget1.Events = New String() {"change"}
        Me.polymerWidget1.Location = New System.Drawing.Point(43, 83)
        Me.polymerWidget1.Name = "polymerWidget1"
        Me.polymerWidget1.Properties = CType(Wisej.Core.WisejSerializer.Parse("{""value"":10}"), Wisej.Core.DynamicObject)
        Me.polymerWidget1.Size = New System.Drawing.Size(184, 47)
        Me.polymerWidget1.TabIndex = 4
        Me.polymerWidget1.Text = "polymerWidget1"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(43, 48)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(175, 15)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Polymer Created on the Page"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(43, 172)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(172, 15)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Specialized Polymer Classes"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(300, 285)
        Me.button1.Name = "button1"
        Me.button1.Repeat = True
        Me.button1.Size = New System.Drawing.Size(36, 23)
        Me.button1.TabIndex = 9
        Me.button1.Text = "+"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(342, 285)
        Me.button2.Name = "button2"
        Me.button2.Repeat = True
        Me.button2.Size = New System.Drawing.Size(36, 23)
        Me.button2.TabIndex = 10
        Me.button2.Text = "-"
        '
        'label3
        '
        Me.label3.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.label3.Location = New System.Drawing.Point(394, 287)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(49, 23)
        Me.label3.TabIndex = 11
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label4
        '
        Me.label4.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.label4.Location = New System.Drawing.Point(300, 225)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(143, 23)
        Me.label4.TabIndex = 12
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'styleSheet
        '
        Me.styleSheet.Styles = resources.GetString("styleSheet.Styles")
        '
        'paperButton1
        '
        Me.styleSheet.SetCssClass(Me.paperButton1, "paper")
        Me.paperButton1.ElementClassName = "circle red"
        Me.paperButton1.Location = New System.Drawing.Point(43, 408)
        Me.paperButton1.Name = "paperButton1"
        Me.paperButton1.Size = New System.Drawing.Size(115, 115)
        Me.paperButton1.TabIndex = 14
        Me.paperButton1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<div style=""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    text-align:center;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    position:relative;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    top:50%;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   " &
    " transform:translateY(-50%)"">" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<iron-icon icon=""file-download""></iron-icon>Click" &
    " Me" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</div>"
        '
        'polymerComponent1
        '
        Me.polymerComponent1.Imports = New String() {"iron-icons/iron-icons.html", "iron-icons/maps-icons.html"}
        '
        'googleChart1
        '
        Me.googleChart1.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.googleChart1.Location = New System.Drawing.Point(537, 109)
        Me.googleChart1.Name = "googleChart1"
        Me.googleChart1.Properties = CType(Wisej.Core.WisejSerializer.Parse("{""selection"":[{""row"":0,""column"":0}],""options"":{}}"), Wisej.Core.DynamicObject)
        Me.googleChart1.Size = New System.Drawing.Size(294, 201)
        Me.googleChart1.TabIndex = 19
        Me.googleChart1.Text = "googleChart1"
        '
        'paperRadioButton2
        '
        Me.paperRadioButton2.Location = New System.Drawing.Point(415, 433)
        Me.paperRadioButton2.Name = "paperRadioButton2"
        Me.paperRadioButton2.Size = New System.Drawing.Size(160, 23)
        Me.paperRadioButton2.TabIndex = 18
        Me.paperRadioButton2.Text = "paperRadioButton2"
        '
        'paperRadioButton1
        '
        Me.paperRadioButton1.Location = New System.Drawing.Point(226, 433)
        Me.paperRadioButton1.Name = "paperRadioButton1"
        Me.paperRadioButton1.Size = New System.Drawing.Size(152, 23)
        Me.paperRadioButton1.TabIndex = 17
        Me.paperRadioButton1.Text = "paperRadioButton1"
        '
        'paperRadioGroup1
        '
        Me.paperRadioGroup1.Location = New System.Drawing.Point(291, 48)
        Me.paperRadioGroup1.Name = "paperRadioGroup1"
        Me.paperRadioGroup1.Size = New System.Drawing.Size(308, 45)
        Me.paperRadioGroup1.TabIndex = 16
        Me.paperRadioGroup1.Text = "<paper-radio-button name=""small"">Small</paper-radio-button>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  <paper-radio-butto" &
    "n name=""medium"">Medium</paper-radio-button>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  <paper-radio-button name=""large"">" &
    "Large</paper-radio-button>"
        '
        'ironIcon1
        '
        Me.ironIcon1.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.ironIcon1.Location = New System.Drawing.Point(43, 581)
        Me.ironIcon1.Name = "ironIcon1"
        Me.ironIcon1.Properties = CType(Wisej.Core.WisejSerializer.Parse("{""icon"":""face""}"), Wisej.Core.DynamicObject)
        Me.ironIcon1.Size = New System.Drawing.Size(115, 82)
        Me.ironIcon1.TabIndex = 15
        '
        'paperProgress1
        '
        Me.paperProgress1.ElementClassName = "green"
        Me.paperProgress1.Location = New System.Drawing.Point(43, 365)
        Me.paperProgress1.Name = "paperProgress1"
        Me.paperProgress1.Size = New System.Drawing.Size(400, 23)
        Me.paperProgress1.TabIndex = 13
        Me.paperProgress1.Text = "paperProgress1"
        '
        'paperSlider1
        '
        Me.paperSlider1.Location = New System.Drawing.Point(43, 285)
        Me.paperSlider1.Name = "paperSlider1"
        Me.paperSlider1.Size = New System.Drawing.Size(180, 23)
        Me.paperSlider1.TabIndex = 8
        Me.paperSlider1.Text = "polymerSlider1"
        '
        'paperCheckBox1
        '
        Me.paperCheckBox1.Location = New System.Drawing.Point(43, 225)
        Me.paperCheckBox1.Name = "paperCheckBox1"
        Me.paperCheckBox1.Size = New System.Drawing.Size(105, 23)
        Me.paperCheckBox1.TabIndex = 7
        Me.paperCheckBox1.Text = "CheckBox"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.googleChart1)
        Me.Controls.Add(Me.paperRadioButton2)
        Me.Controls.Add(Me.paperRadioButton1)
        Me.Controls.Add(Me.paperRadioGroup1)
        Me.Controls.Add(Me.ironIcon1)
        Me.Controls.Add(Me.paperButton1)
        Me.Controls.Add(Me.paperProgress1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.paperSlider1)
        Me.Controls.Add(Me.paperCheckBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.polymerWidget1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(893, 569)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


#End Region

    Friend WithEvents polymerWidget1 As Web.Ext.Polymer.PolymerWidget
    Friend WithEvents label1 As Web.Label
    Friend WithEvents label2 As Web.Label
    Friend WithEvents paperCheckBox1 As PaperCheckBox
    Friend WithEvents paperSlider1 As PaperSlider
    Friend WithEvents button1 As Web.Button
    Friend WithEvents button2 As Web.Button
    Friend WithEvents label3 As Web.Label
    Friend WithEvents label4 As Web.Label
    Friend WithEvents paperProgress1 As PaperProgress
    Friend WithEvents paperButton1 As PaperButton
    Friend WithEvents styleSheet As Web.StyleSheet
    Friend WithEvents ironIcon1 As IronIcon
    Friend WithEvents polymerComponent1 As Web.Ext.Polymer.PolymerComponent
    Friend WithEvents paperRadioGroup1 As PaperRadioGroup
    Friend WithEvents paperRadioButton1 As PaperRadioButton
    Friend WithEvents paperRadioButton2 As PaperRadioButton
    Friend WithEvents googleChart1 As GoogleChart
End Class
