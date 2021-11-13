
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
        Me.panel1 = New Wisej.Web.FlexLayoutPanel()
        Me.flexLayoutPanel1 = New Wisej.Web.FlexLayoutPanel()
        Me.label1 = New Wisej.Web.Label()
        Me.label2 = New Wisej.Web.Label()
        Me.flexLayoutPanel2 = New Wisej.Web.FlexLayoutPanel()
        Me.label3 = New Wisej.Web.Label()
        Me.tagTextBox1 = New Wisej.Web.TagTextBox()
        Me.flexLayoutPanel3 = New Wisej.Web.FlexLayoutPanel()
        Me.checkBox1 = New Wisej.Web.CheckBox()
        Me.separator1 = New Wisej.Web.Spacer()
        Me.button1 = New Wisej.Web.Button()
        Me.button2 = New Wisej.Web.Button()
        Me.panel1.SuspendLayout()
        Me.flexLayoutPanel1.SuspendLayout()
        Me.flexLayoutPanel2.SuspendLayout()
        Me.flexLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Anchor = Wisej.Web.AnchorStyles.None
        Me.panel1.AppearanceKey = "states-panel"
        Me.panel1.AutoSize = True
        Me.panel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.panel1.Controls.Add(Me.flexLayoutPanel1)
        Me.panel1.Controls.Add(Me.flexLayoutPanel2)
        Me.panel1.Controls.Add(Me.flexLayoutPanel3)
        Me.panel1.HeaderBackColor = System.Drawing.Color.FromArgb(87, 159, 218)
        Me.panel1.HeaderForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.panel1.HeaderSize = 40
        Me.panel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical
        Me.panel1.Location = New System.Drawing.Point(482, 208)
        Me.panel1.Name = "panel1"
        Me.panel1.ShowCloseButton = False
        Me.panel1.ShowHeader = True
        Me.panel1.Size = New System.Drawing.Size(542, 199)
        Me.panel1.TabIndex = 0
        Me.panel1.TabStop = True
        Me.panel1.Text = "Select States"
        '
        'flexLayoutPanel1
        '
        Me.flexLayoutPanel1.AutoSize = True
        Me.flexLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.flexLayoutPanel1.Controls.Add(Me.label1)
        Me.flexLayoutPanel1.Controls.Add(Me.label2)
        Me.flexLayoutPanel1.HeaderSize = 40
        Me.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal
        Me.flexLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.flexLayoutPanel1.Margin = New Wisej.Web.Padding(10, 10, 10, 5)
        Me.flexLayoutPanel1.Name = "flexLayoutPanel1"
        Me.flexLayoutPanel1.ShowCloseButton = False
        Me.flexLayoutPanel1.Size = New System.Drawing.Size(522, 19)
        Me.flexLayoutPanel1.TabIndex = 1
        Me.flexLayoutPanel1.TabStop = True
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(3, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(135, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Selected States:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label2
        '
        Me.flexLayoutPanel1.SetAlignY(Me.label2, Wisej.Web.VerticalAlignment.Middle)
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(154, 3)
        Me.label2.MaximumSize = New System.Drawing.Size(365, 0)
        Me.label2.MinimumSize = New System.Drawing.Size(365, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(365, 13)
        Me.label2.TabIndex = 1
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'flexLayoutPanel2
        '
        Me.flexLayoutPanel2.AutoSize = True
        Me.flexLayoutPanel2.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.flexLayoutPanel2.Controls.Add(Me.label3)
        Me.flexLayoutPanel2.Controls.Add(Me.tagTextBox1)
        Me.flexLayoutPanel2.HeaderSize = 40
        Me.flexLayoutPanel2.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal
        Me.flexLayoutPanel2.Location = New System.Drawing.Point(10, 49)
        Me.flexLayoutPanel2.Margin = New Wisej.Web.Padding(10, 5, 10, 10)
        Me.flexLayoutPanel2.Name = "flexLayoutPanel2"
        Me.flexLayoutPanel2.ShowCloseButton = False
        Me.flexLayoutPanel2.Size = New System.Drawing.Size(522, 43)
        Me.flexLayoutPanel2.TabIndex = 2
        Me.flexLayoutPanel2.TabStop = True
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(3, 15)
        Me.label3.Margin = New Wisej.Web.Padding(3, 15, 3, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(135, 13)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Select a State:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tagTextBox1
        '
        Me.tagTextBox1.AutoComplete = Wisej.Web.AutoComplete.[On]
        Me.tagTextBox1.AutoCompleteList = New String() {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming", "District of Columbia", "Puerto Rico", "Guam", "American Samoa", "U.S. Virgin Islands", "Northern Mariana Islands"}
        Me.tagTextBox1.Location = New System.Drawing.Point(154, 15)
        Me.tagTextBox1.Margin = New Wisej.Web.Padding(3, 15, 3, 15)
        Me.tagTextBox1.MaxTagWidth = 200
        Me.tagTextBox1.Name = "tagTextBox1"
        Me.tagTextBox1.Size = New System.Drawing.Size(365, 13)
        Me.tagTextBox1.TabIndex = 1
        '
        'flexLayoutPanel3
        '
        Me.flexLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(180, 207, 221)
        Me.flexLayoutPanel3.Controls.Add(Me.checkBox1)
        Me.flexLayoutPanel3.Controls.Add(Me.separator1)
        Me.flexLayoutPanel3.Controls.Add(Me.button1)
        Me.flexLayoutPanel3.Controls.Add(Me.button2)
        Me.flexLayoutPanel3.HeaderSize = 40
        Me.flexLayoutPanel3.HorizontalAlign = Wisej.Web.HorizontalAlignment.Right
        Me.flexLayoutPanel3.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal
        Me.flexLayoutPanel3.Location = New System.Drawing.Point(0, 112)
        Me.flexLayoutPanel3.Margin = New Wisej.Web.Padding(0)
        Me.flexLayoutPanel3.Name = "flexLayoutPanel3"
        Me.flexLayoutPanel3.Padding = New Wisej.Web.Padding(5)
        Me.flexLayoutPanel3.ShowCloseButton = False
        Me.flexLayoutPanel3.Size = New System.Drawing.Size(542, 47)
        Me.flexLayoutPanel3.TabIndex = 3
        Me.flexLayoutPanel3.TabStop = True
        '
        'checkBox1
        '
        Me.checkBox1.Appearance = Wisej.Web.Appearance.Switch
        Me.checkBox1.AutoSize = False
        Me.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = Wisej.Web.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(6, 8)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(142, 31)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "Auto Center"
        '
        'separator1
        '
        Me.flexLayoutPanel3.SetFillWeight(Me.separator1, 1)
        Me.separator1.Location = New System.Drawing.Point(164, 8)
        Me.separator1.Name = "separator1"
        Me.separator1.Size = New System.Drawing.Size(175, 31)
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(355, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(74, 31)
        Me.button1.TabIndex = 0
        Me.button1.Text = "OK"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(445, 8)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(87, 31)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Cancel"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.panel1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(1511, 669)
        Me.Text = "Page1"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.flexLayoutPanel1.ResumeLayout(False)
        Me.flexLayoutPanel1.PerformLayout()
        Me.flexLayoutPanel2.ResumeLayout(False)
        Me.flexLayoutPanel2.PerformLayout()
        Me.flexLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


#End Region

    Friend WithEvents panel1 As Web.FlexLayoutPanel
    Friend WithEvents flexLayoutPanel2 As Web.FlexLayoutPanel
    Friend WithEvents label3 As Web.Label
    Friend WithEvents tagTextBox1 As Web.TagTextBox
    Friend WithEvents flexLayoutPanel3 As Web.FlexLayoutPanel
    Friend WithEvents button1 As Web.Button
    Friend WithEvents button2 As Web.Button
    Friend WithEvents flexLayoutPanel1 As Web.FlexLayoutPanel
    Friend WithEvents label1 As Web.Label
    Friend WithEvents label2 As Web.Label
    Friend WithEvents checkBox1 As Web.CheckBox
    Friend WithEvents separator1 As Web.Spacer
End Class
