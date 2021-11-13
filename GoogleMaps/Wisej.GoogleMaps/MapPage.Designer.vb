Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MapPage
    Inherits Wisej.Web.Page
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
        Me.groupBox1 = New Wisej.Web.GroupBox()
        Me.checkBoxStreetView = New Wisej.Web.CheckBox()
        Me.checkBoxFullScreen = New Wisej.Web.CheckBox()
        Me.checkBoxZoom = New Wisej.Web.CheckBox()
        Me.checkBoxMapType = New Wisej.Web.CheckBox()
        Me.groupBox2 = New Wisej.Web.GroupBox()
        Me.comboBoxMapType = New Wisej.Web.ComboBox()
        Me.checkedListBoxMapType = New Wisej.Web.CheckedListBox()
        Me.googleMap1 = New Wisej.Web.Ext.GoogleMaps.GoogleMap()
        Me.trackBar1 = New Wisej.Web.TrackBar()
        Me.groupBox3 = New Wisej.Web.GroupBox()
        Me.label2 = New Wisej.Web.Label()
        Me.numericUpDownMaxZoom = New Wisej.Web.NumericUpDown()
        Me.label1 = New Wisej.Web.Label()
        Me.numericUpDownMinZoom = New Wisej.Web.NumericUpDown()
        Me.groupBox4 = New Wisej.Web.GroupBox()
        Me.tableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
        Me.panel3 = New Wisej.Web.Panel()
        Me.button1 = New Wisej.Web.Button()
        Me.buttonCenterMap = New Wisej.Web.Button()
        Me.buttonClearMarkers = New Wisej.Web.Button()
        Me.buttonAddMarker = New Wisej.Web.Button()
        Me.buttonRemoveMarker = New Wisej.Web.Button()
        Me.panel2 = New Wisej.Web.Panel()
        Me.label3 = New Wisej.Web.Label()
        Me.textBoxAddress = New Wisej.Web.TextBox()
        Me.panel1 = New Wisej.Web.Panel()
        Me.maskedTextBoxLng = New Wisej.Web.MaskedTextBox()
        Me.label4 = New Wisej.Web.Label()
        Me.label5 = New Wisej.Web.Label()
        Me.maskedTextBoxLat = New Wisej.Web.MaskedTextBox()
        Me.maskedTextBoxID = New Wisej.Web.MaskedTextBox()
        Me.label6 = New Wisej.Web.Label()
        Me.flowLayoutPanel1 = New Wisej.Web.FlowLayoutPanel()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        CType(Me.numericUpDownMaxZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDownMinZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox4.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.checkBoxStreetView)
        Me.groupBox1.Controls.Add(Me.checkBoxFullScreen)
        Me.groupBox1.Controls.Add(Me.checkBoxZoom)
        Me.groupBox1.Controls.Add(Me.checkBoxMapType)
        Me.flowLayoutPanel1.SetFillWeight(Me.groupBox1, 33)
        Me.groupBox1.Location = New System.Drawing.Point(3, 3)
        Me.groupBox1.MinimumSize = New System.Drawing.Size(150, 0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(354, 172)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.Text = "Controls"
        Me.groupBox1.UseMnemonic = False
        '
        'checkBoxStreetView
        '
        Me.checkBoxStreetView.Checked = True
        Me.checkBoxStreetView.CheckState = Wisej.Web.CheckState.Checked
        Me.checkBoxStreetView.Location = New System.Drawing.Point(16, 115)
        Me.checkBoxStreetView.Name = "checkBoxStreetView"
        Me.checkBoxStreetView.Size = New System.Drawing.Size(99, 22)
        Me.checkBoxStreetView.TabIndex = 3
        Me.checkBoxStreetView.Text = "Street View"
        '
        'checkBoxFullScreen
        '
        Me.checkBoxFullScreen.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left), Wisej.Web.AnchorStyles)
        Me.checkBoxFullScreen.Location = New System.Drawing.Point(16, 85)
        Me.checkBoxFullScreen.Name = "checkBoxFullScreen"
        Me.checkBoxFullScreen.Size = New System.Drawing.Size(98, 22)
        Me.checkBoxFullScreen.TabIndex = 2
        Me.checkBoxFullScreen.Text = "Full Screen"
        '
        'checkBoxZoom
        '
        Me.checkBoxZoom.Checked = True
        Me.checkBoxZoom.CheckState = Wisej.Web.CheckState.Checked
        Me.checkBoxZoom.Location = New System.Drawing.Point(16, 55)
        Me.checkBoxZoom.Name = "checkBoxZoom"
        Me.checkBoxZoom.Size = New System.Drawing.Size(66, 22)
        Me.checkBoxZoom.TabIndex = 1
        Me.checkBoxZoom.Text = "Zoom"
        '
        'checkBoxMapType
        '
        Me.checkBoxMapType.Checked = True
        Me.checkBoxMapType.CheckState = Wisej.Web.CheckState.Checked
        Me.checkBoxMapType.Location = New System.Drawing.Point(16, 25)
        Me.checkBoxMapType.Name = "checkBoxMapType"
        Me.checkBoxMapType.Size = New System.Drawing.Size(90, 22)
        Me.checkBoxMapType.TabIndex = 0
        Me.checkBoxMapType.Text = "Map Type"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.comboBoxMapType)
        Me.groupBox2.Controls.Add(Me.checkedListBoxMapType)
        Me.flowLayoutPanel1.SetFillWeight(Me.groupBox2, 33)
        Me.groupBox2.Location = New System.Drawing.Point(363, 3)
        Me.groupBox2.MinimumSize = New System.Drawing.Size(150, 0)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(354, 172)
        Me.groupBox2.TabIndex = 2
        Me.groupBox2.Text = "Map Type"
        Me.groupBox2.UseMnemonic = False
        '
        'comboBoxMapType
        '
        Me.comboBoxMapType.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.comboBoxMapType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.comboBoxMapType.Items.AddRange(New Object() {"Roadmap", "Hybrid", "Satellite", "Terrain"})
        Me.comboBoxMapType.Location = New System.Drawing.Point(18, 25)
        Me.comboBoxMapType.Name = "comboBoxMapType"
        Me.comboBoxMapType.Size = New System.Drawing.Size(88, 22)
        Me.comboBoxMapType.TabIndex = 1
        '
        'checkedListBoxMapType
        '
        Me.checkedListBoxMapType.BorderStyle = Wisej.Web.BorderStyle.None
        Me.checkedListBoxMapType.Items.AddRange(New Object() {"Roadmap", "Hybrid", "Satellite", "Terrain"})
        Me.checkedListBoxMapType.Location = New System.Drawing.Point(18, 53)
        Me.checkedListBoxMapType.Name = "checkedListBoxMapType"
        Me.checkedListBoxMapType.Size = New System.Drawing.Size(139, 113)
        Me.checkedListBoxMapType.TabIndex = 0
        '
        'googleMap1
        '
        Me.googleMap1.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.googleMap1.ApiKey = "AIzaSyDJ13giW35qbt9Qsznjy_CFqMJMQlAjoSw"
        Me.googleMap1.Location = New System.Drawing.Point(48, 453)
        Me.googleMap1.MinimumSize = New System.Drawing.Size(0, 400)
        Me.googleMap1.Name = "googleMap1"
        Me.googleMap1.Options = CType(Wisej.Core.WisejSerializer.Parse("{""zoom"":4,""center"":{""lat"":0,""lng"":0},""mapTypeId"":""roadmap"",""mapTypeControlOptions" &
        """:{""style"":2,""mapTypeIds"":[""roadmap"",""hybrid"",""satellite"",""terrain""]}}"), Wisej.Core.DynamicObject)
        Me.googleMap1.Size = New System.Drawing.Size(1080, 527)
        Me.googleMap1.TabIndex = 0
        Me.googleMap1.Text = "googleMap1"
        '
        'trackBar1
        '
        Me.trackBar1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.trackBar1.Location = New System.Drawing.Point(22, 105)
        Me.trackBar1.Maximum = 20
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(317, 34)
        Me.trackBar1.TabIndex = 3
        Me.trackBar1.TickStyle = Wisej.Web.TickStyle.Both
        Me.trackBar1.Value = 10
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.label2)
        Me.groupBox3.Controls.Add(Me.trackBar1)
        Me.groupBox3.Controls.Add(Me.numericUpDownMaxZoom)
        Me.groupBox3.Controls.Add(Me.label1)
        Me.groupBox3.Controls.Add(Me.numericUpDownMinZoom)
        Me.flowLayoutPanel1.SetFillWeight(Me.groupBox3, 33)
        Me.flowLayoutPanel1.SetFlowBreak(Me.groupBox3, True)
        Me.groupBox3.Location = New System.Drawing.Point(723, 3)
        Me.groupBox3.MinimumSize = New System.Drawing.Size(210, 0)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(354, 172)
        Me.groupBox3.TabIndex = 4
        Me.groupBox3.Text = "Zoom"
        Me.groupBox3.UseMnemonic = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 59)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(33, 15)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Max:"
        '
        'numericUpDownMaxZoom
        '
        Me.numericUpDownMaxZoom.Location = New System.Drawing.Point(71, 57)
        Me.numericUpDownMaxZoom.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numericUpDownMaxZoom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDownMaxZoom.Name = "numericUpDownMaxZoom"
        Me.numericUpDownMaxZoom.Size = New System.Drawing.Size(104, 22)
        Me.numericUpDownMaxZoom.TabIndex = 2
        Me.numericUpDownMaxZoom.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(22, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(29, 15)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Min:"
        '
        'numericUpDownMinZoom
        '
        Me.numericUpDownMinZoom.Location = New System.Drawing.Point(71, 26)
        Me.numericUpDownMinZoom.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numericUpDownMinZoom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDownMinZoom.Name = "numericUpDownMinZoom"
        Me.numericUpDownMinZoom.Size = New System.Drawing.Size(104, 22)
        Me.numericUpDownMinZoom.TabIndex = 0
        Me.numericUpDownMinZoom.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.tableLayoutPanel1)
        Me.flowLayoutPanel1.SetFillWeight(Me.groupBox4, 100)
        Me.groupBox4.Location = New System.Drawing.Point(3, 181)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(1074, 207)
        Me.groupBox4.TabIndex = 5
        Me.groupBox4.Text = "Markers"
        Me.groupBox4.UseMnemonic = False
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.panel3, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.panel2, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 115.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 34.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(1068, 186)
        Me.tableLayoutPanel1.TabIndex = 0
        Me.tableLayoutPanel1.TabStop = True
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.button1)
        Me.panel3.Controls.Add(Me.buttonCenterMap)
        Me.panel3.Controls.Add(Me.buttonClearMarkers)
        Me.panel3.Controls.Add(Me.buttonAddMarker)
        Me.panel3.Controls.Add(Me.buttonRemoveMarker)
        Me.panel3.Dock = Wisej.Web.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(537, 118)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(528, 65)
        Me.panel3.TabIndex = 2
        Me.panel3.TabStop = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(11, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 27)
        Me.button1.TabIndex = 12
        Me.button1.Text = "button1"
        '
        'buttonCenterMap
        '
        Me.buttonCenterMap.Anchor = Wisej.Web.AnchorStyles.Right
        Me.buttonCenterMap.Location = New System.Drawing.Point(116, 11)
        Me.buttonCenterMap.Name = "buttonCenterMap"
        Me.buttonCenterMap.Size = New System.Drawing.Size(97, 43)
        Me.buttonCenterMap.TabIndex = 11
        Me.buttonCenterMap.Text = "Center Map"
        '
        'buttonClearMarkers
        '
        Me.buttonClearMarkers.Anchor = Wisej.Web.AnchorStyles.Right
        Me.buttonClearMarkers.Location = New System.Drawing.Point(425, 11)
        Me.buttonClearMarkers.Name = "buttonClearMarkers"
        Me.buttonClearMarkers.Size = New System.Drawing.Size(97, 43)
        Me.buttonClearMarkers.TabIndex = 10
        Me.buttonClearMarkers.Text = "Clear"
        '
        'buttonAddMarker
        '
        Me.buttonAddMarker.Anchor = Wisej.Web.AnchorStyles.Right
        Me.buttonAddMarker.Location = New System.Drawing.Point(219, 11)
        Me.buttonAddMarker.Name = "buttonAddMarker"
        Me.buttonAddMarker.Size = New System.Drawing.Size(97, 43)
        Me.buttonAddMarker.TabIndex = 8
        Me.buttonAddMarker.Text = "Add"
        '
        'buttonRemoveMarker
        '
        Me.buttonRemoveMarker.Anchor = Wisej.Web.AnchorStyles.Right
        Me.buttonRemoveMarker.Location = New System.Drawing.Point(322, 11)
        Me.buttonRemoveMarker.Name = "buttonRemoveMarker"
        Me.buttonRemoveMarker.Size = New System.Drawing.Size(97, 43)
        Me.buttonRemoveMarker.TabIndex = 9
        Me.buttonRemoveMarker.Text = "Remove"
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.label3)
        Me.panel2.Controls.Add(Me.textBoxAddress)
        Me.panel2.Dock = Wisej.Web.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(537, 3)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(528, 109)
        Me.panel2.TabIndex = 1
        Me.panel2.TabStop = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(13, 11)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 15)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Address:"
        '
        'textBoxAddress
        '
        Me.textBoxAddress.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.textBoxAddress.Location = New System.Drawing.Point(89, 11)
        Me.textBoxAddress.Multiline = True
        Me.textBoxAddress.Name = "textBoxAddress"
        Me.textBoxAddress.Size = New System.Drawing.Size(430, 95)
        Me.textBoxAddress.TabIndex = 1
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.maskedTextBoxLng)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Controls.Add(Me.maskedTextBoxLat)
        Me.panel1.Controls.Add(Me.maskedTextBoxID)
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(528, 109)
        Me.panel1.TabIndex = 0
        Me.panel1.TabStop = True
        '
        'maskedTextBoxLng
        '
        Me.maskedTextBoxLng.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.maskedTextBoxLng.Location = New System.Drawing.Point(90, 65)
        Me.maskedTextBoxLng.Name = "maskedTextBoxLng"
        Me.maskedTextBoxLng.Size = New System.Drawing.Size(409, 22)
        Me.maskedTextBoxLng.TabIndex = 5
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(11, 39)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(54, 15)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Latitude:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(10, 67)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(65, 15)
        Me.label5.TabIndex = 3
        Me.label5.Text = "Longitude:"
        '
        'maskedTextBoxLat
        '
        Me.maskedTextBoxLat.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.maskedTextBoxLat.Location = New System.Drawing.Point(90, 37)
        Me.maskedTextBoxLat.Name = "maskedTextBoxLat"
        Me.maskedTextBoxLat.Size = New System.Drawing.Size(409, 22)
        Me.maskedTextBoxLat.TabIndex = 4
        '
        'maskedTextBoxID
        '
        Me.maskedTextBoxID.Location = New System.Drawing.Point(90, 9)
        Me.maskedTextBoxID.Name = "maskedTextBoxID"
        Me.maskedTextBoxID.Size = New System.Drawing.Size(77, 22)
        Me.maskedTextBoxID.TabIndex = 7
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(11, 13)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(21, 15)
        Me.label6.TabIndex = 6
        Me.label6.Text = "ID:"
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.flowLayoutPanel1.Controls.Add(Me.groupBox1)
        Me.flowLayoutPanel1.Controls.Add(Me.groupBox2)
        Me.flowLayoutPanel1.Controls.Add(Me.groupBox3)
        Me.flowLayoutPanel1.Controls.Add(Me.groupBox4)
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(48, 46)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(1080, 388)
        Me.flowLayoutPanel1.TabIndex = 6
        Me.flowLayoutPanel1.TabStop = True
        '
        'MapPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.googleMap1)
        Me.Controls.Add(Me.flowLayoutPanel1)
        Me.Name = "MapPage"
        Me.Size = New System.Drawing.Size(1180, 796)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.numericUpDownMaxZoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDownMinZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox4.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents googleMap1 As Web.Ext.GoogleMaps.GoogleMap
    Friend WithEvents groupBox1 As Web.GroupBox
    Friend WithEvents checkBoxFullScreen As Web.CheckBox
    Friend WithEvents checkBoxZoom As Web.CheckBox
    Friend WithEvents checkBoxMapType As Web.CheckBox
    Friend WithEvents groupBox2 As Web.GroupBox
    Friend WithEvents checkedListBoxMapType As Web.CheckedListBox
    Friend WithEvents checkBoxStreetView As Web.CheckBox
    Friend WithEvents trackBar1 As Web.TrackBar
    Friend WithEvents groupBox3 As Web.GroupBox
    Friend WithEvents label2 As Web.Label
    Friend WithEvents numericUpDownMaxZoom As Web.NumericUpDown
    Friend WithEvents label1 As Web.Label
    Friend WithEvents numericUpDownMinZoom As Web.NumericUpDown
    Friend WithEvents groupBox4 As Web.GroupBox
    Friend WithEvents maskedTextBoxLat As Web.MaskedTextBox
    Friend WithEvents label5 As Web.Label
    Friend WithEvents label4 As Web.Label
    Friend WithEvents textBoxAddress As Web.TextBox
    Friend WithEvents label3 As Web.Label
    Friend WithEvents maskedTextBoxID As Web.MaskedTextBox
    Friend WithEvents label6 As Web.Label
    Friend WithEvents maskedTextBoxLng As Web.MaskedTextBox
    Friend WithEvents buttonClearMarkers As Web.Button
    Friend WithEvents buttonRemoveMarker As Web.Button
    Friend WithEvents buttonAddMarker As Web.Button
    Friend WithEvents flowLayoutPanel1 As Web.FlowLayoutPanel
    Friend WithEvents tableLayoutPanel1 As Web.TableLayoutPanel
    Friend WithEvents panel3 As Web.Panel
    Friend WithEvents panel2 As Web.Panel
    Friend WithEvents panel1 As Web.Panel
    Friend WithEvents comboBoxMapType As Web.ComboBox
    Friend WithEvents buttonCenterMap As Web.Button
    Friend WithEvents button1 As Web.Button
End Class
