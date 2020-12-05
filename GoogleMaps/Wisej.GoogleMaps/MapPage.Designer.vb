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
        groupBox1 = New Web.GroupBox()
        checkBoxStreetView = New Web.CheckBox()
        checkBoxFullScreen = New Web.CheckBox()
        checkBoxZoom = New Web.CheckBox()
        checkBoxMapType = New Web.CheckBox()
        groupBox2 = New Web.GroupBox()
        comboBoxMapType = New Web.ComboBox()
        checkedListBoxMapType = New Web.CheckedListBox()
        googleMap1 = New Web.Ext.GoogleMaps.GoogleMap()
        trackBar1 = New Web.TrackBar()
        groupBox3 = New Web.GroupBox()
        label2 = New Web.Label()
        numericUpDownMaxZoom = New Web.NumericUpDown()
        label1 = New Web.Label()
        numericUpDownMinZoom = New Web.NumericUpDown()
        groupBox4 = New Web.GroupBox()
        tableLayoutPanel1 = New Web.TableLayoutPanel()
        panel3 = New Web.Panel()
        buttonCenterMap = New Web.Button()
        buttonClearMarkers = New Web.Button()
        buttonAddMarker = New Web.Button()
        buttonRemoveMarker = New Web.Button()
        panel2 = New Web.Panel()
        label3 = New Web.Label()
        textBoxAddress = New Web.TextBox()
        panel1 = New Web.Panel()
        maskedTextBoxLng = New Web.MaskedTextBox()
        label4 = New Web.Label()
        label5 = New Web.Label()
        maskedTextBoxLat = New Web.MaskedTextBox()
        maskedTextBoxID = New Web.MaskedTextBox()
        label6 = New Web.Label()
        flowLayoutPanel1 = New Web.FlowLayoutPanel()
        button1 = New Web.Button()
        groupBox1.SuspendLayout()
        groupBox2.SuspendLayout()
        CType(trackBar1, ComponentModel.ISupportInitialize).BeginInit()
        groupBox3.SuspendLayout()
        CType(numericUpDownMaxZoom, ComponentModel.ISupportInitialize).BeginInit()
        CType(numericUpDownMinZoom, ComponentModel.ISupportInitialize).BeginInit()
        groupBox4.SuspendLayout()
        tableLayoutPanel1.SuspendLayout()
        panel3.SuspendLayout()
        panel2.SuspendLayout()
        panel1.SuspendLayout()
        flowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' groupBox1
        ' 
        groupBox1.Controls.Add(checkBoxStreetView)
        groupBox1.Controls.Add(checkBoxFullScreen)
        groupBox1.Controls.Add(checkBoxZoom)
        groupBox1.Controls.Add(checkBoxMapType)
        flowLayoutPanel1.SetFillWeight(groupBox1, 33)
        groupBox1.Location = New Drawing.Point(3, 3)
        groupBox1.MinimumSize = New Drawing.Size(150, 0)
        groupBox1.Name = "groupBox1"
        groupBox1.Size = New Drawing.Size(357, 172)
        groupBox1.TabIndex = 1
        groupBox1.Text = "Controls"
        groupBox1.UseMnemonic = False
        ' 
        ' checkBoxStreetView
        ' 
        checkBoxStreetView.Checked = True
        checkBoxStreetView.CheckState = Web.CheckState.Checked
        checkBoxStreetView.Location = New Drawing.Point(16, 115)
        checkBoxStreetView.Name = "checkBoxStreetView"
        checkBoxStreetView.Size = New Drawing.Size(94, 23)
        checkBoxStreetView.TabIndex = 3
        checkBoxStreetView.Text = "Street View"
        AddHandler checkBoxStreetView.CheckedChanged, New EventHandler(AddressOf StreetView_CheckedChanged)
        ' 
        ' checkBoxFullScreen
        ' 
        checkBoxFullScreen.Location = New Drawing.Point(16, 85)
        checkBoxFullScreen.Name = "checkBoxFullScreen"
        checkBoxFullScreen.Size = New Drawing.Size(94, 23)
        checkBoxFullScreen.TabIndex = 2
        checkBoxFullScreen.Text = "Full Screen"
        AddHandler checkBoxFullScreen.CheckedChanged, New EventHandler(AddressOf checkBoxFullScreen_CheckedChanged)
        ' 
        ' checkBoxZoom
        ' 
        checkBoxZoom.Checked = True
        checkBoxZoom.CheckState = Web.CheckState.Checked
        checkBoxZoom.Location = New Drawing.Point(16, 55)
        checkBoxZoom.Name = "checkBoxZoom"
        checkBoxZoom.Size = New Drawing.Size(60, 23)
        checkBoxZoom.TabIndex = 1
        checkBoxZoom.Text = "Zoom"
        AddHandler checkBoxZoom.CheckedChanged, New EventHandler(AddressOf checkBoxZoom_CheckedChanged)
        ' 
        ' checkBoxMapType
        ' 
        checkBoxMapType.Checked = True
        checkBoxMapType.CheckState = Web.CheckState.Checked
        checkBoxMapType.Location = New Drawing.Point(16, 25)
        checkBoxMapType.Name = "checkBoxMapType"
        checkBoxMapType.Size = New Drawing.Size(85, 23)
        checkBoxMapType.TabIndex = 0
        checkBoxMapType.Text = "Map Type"
        AddHandler checkBoxMapType.CheckedChanged, New EventHandler(AddressOf checkBoxMapType_CheckedChanged)
        ' 
        ' groupBox2
        ' 
        groupBox2.Controls.Add(comboBoxMapType)
        groupBox2.Controls.Add(checkedListBoxMapType)
        flowLayoutPanel1.SetFillWeight(groupBox2, 33)
        groupBox2.Location = New Drawing.Point(366, 3)
        groupBox2.MinimumSize = New Drawing.Size(150, 0)
        groupBox2.Name = "groupBox2"
        groupBox2.Size = New Drawing.Size(357, 172)
        groupBox2.TabIndex = 2
        groupBox2.Text = "Map Type"
        groupBox2.UseMnemonic = False
        ' 
        ' comboBoxMapType
        ' 
        comboBoxMapType.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        comboBoxMapType.DropDownStyle = Web.ComboBoxStyle.DropDownList
        comboBoxMapType.Items.AddRange(New Object() {"Roadmap", "Hybrid", "Satellite", "Terrain"})
        comboBoxMapType.Location = New Drawing.Point(18, 25)
        comboBoxMapType.Name = "comboBoxMapType"
        comboBoxMapType.Size = New Drawing.Size(91, 22)
        comboBoxMapType.TabIndex = 1
        AddHandler comboBoxMapType.SelectedIndexChanged, New EventHandler(AddressOf comboBoxMatType_SelectedIndexChanged)
        ' 
        ' checkedListBoxMapType
        ' 
        checkedListBoxMapType.BorderStyle = Web.BorderStyle.None
        checkedListBoxMapType.Items.AddRange(New Object() {"Roadmap", "Hybrid", "Satellite", "Terrain"})
        checkedListBoxMapType.Location = New Drawing.Point(18, 53)
        checkedListBoxMapType.Name = "checkedListBoxMapType"
        checkedListBoxMapType.Size = New Drawing.Size(139, 113)
        checkedListBoxMapType.TabIndex = 0
        AddHandler checkedListBoxMapType.AfterItemCheck, New Web.ItemCheckEventHandler(AddressOf checkedListBoxMapType_AfterItemCheck)
        ' 
        ' googleMap1
        ' 
        googleMap1.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Bottom Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        googleMap1.ApiKey = "AIzaSyDJ13giW35qbt9Qsznjy_CFqMJMQlAjoSw"
        googleMap1.Location = New Drawing.Point(48, 453)
        googleMap1.MinimumSize = New Drawing.Size(0, 400)
        googleMap1.Name = "googleMap1"
        googleMap1.Options = CType(Core.WisejSerializer.Parse("{""zoom"":4,""center"":{""lat"":0,""lng"":0},""mapTypeId"":""roadmap"",""mapTypeControlOptions" & """:{""style"":2,""mapTypeIds"":[""roadmap"",""hybrid"",""satellite"",""terrain""]}}"), Core.DynamicObject)
        googleMap1.Size = New Drawing.Size(1088, 441)
        googleMap1.Text = "googleMap1"
        AddHandler googleMap1.MapClick, New Web.Ext.GoogleMaps.MapMouseEventHandler(AddressOf googleMap1_MapClick)
        AddHandler googleMap1.MapPropertyChanged, New Web.Ext.GoogleMaps.MapPropertyChangedEventHandler(AddressOf googleMap1_MapPropertyChanged)
        ' 
        ' trackBar1
        ' 
        trackBar1.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        trackBar1.Location = New Drawing.Point(22, 105)
        trackBar1.Maximum = 20
        trackBar1.Name = "trackBar1"
        trackBar1.Size = New Drawing.Size(320, 34)
        trackBar1.TabIndex = 3
        trackBar1.TickStyle = Web.TickStyle.Both
        trackBar1.Value = 10
        AddHandler trackBar1.ValueChanged, New EventHandler(AddressOf trackBar1_ValueChanged)
        ' 
        ' groupBox3
        ' 
        groupBox3.Controls.Add(label2)
        groupBox3.Controls.Add(trackBar1)
        groupBox3.Controls.Add(numericUpDownMaxZoom)
        groupBox3.Controls.Add(label1)
        groupBox3.Controls.Add(numericUpDownMinZoom)
        flowLayoutPanel1.SetFillWeight(groupBox3, 33)
        flowLayoutPanel1.SetFlowBreak(groupBox3, True)
        groupBox3.Location = New Drawing.Point(729, 3)
        groupBox3.MinimumSize = New Drawing.Size(210, 0)
        groupBox3.Name = "groupBox3"
        groupBox3.Size = New Drawing.Size(357, 172)
        groupBox3.TabIndex = 4
        groupBox3.Text = "Zoom"
        groupBox3.UseMnemonic = False
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Drawing.Point(22, 59)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(37, 16)
        label2.TabIndex = 3
        label2.Text = "Max:"
        ' 
        ' numericUpDownMaxZoom
        ' 
        numericUpDownMaxZoom.Location = New Drawing.Point(71, 57)
        numericUpDownMaxZoom.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        numericUpDownMaxZoom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numericUpDownMaxZoom.Name = "numericUpDownMaxZoom"
        numericUpDownMaxZoom.Size = New Drawing.Size(104, 22)
        numericUpDownMaxZoom.TabIndex = 2
        numericUpDownMaxZoom.Value = New Decimal(New Integer() {20, 0, 0, 0})
        AddHandler numericUpDownMaxZoom.ValueChanged, New EventHandler(AddressOf numericUpDownMaxZoom_ValueChanged)
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Drawing.Point(22, 28)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(33, 16)
        label1.TabIndex = 1
        label1.Text = "Min:"
        ' 
        ' numericUpDownMinZoom
        ' 
        numericUpDownMinZoom.Location = New Drawing.Point(71, 26)
        numericUpDownMinZoom.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        numericUpDownMinZoom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numericUpDownMinZoom.Name = "numericUpDownMinZoom"
        numericUpDownMinZoom.Size = New Drawing.Size(104, 22)
        numericUpDownMinZoom.TabIndex = 0
        numericUpDownMinZoom.Value = New Decimal(New Integer() {1, 0, 0, 0})
        AddHandler numericUpDownMinZoom.ValueChanged, New EventHandler(AddressOf numericUpDownMinZoom_ValueChanged)
        ' 
        ' groupBox4
        ' 
        groupBox4.Controls.Add(tableLayoutPanel1)
        flowLayoutPanel1.SetFillWeight(groupBox4, 100)
        groupBox4.Location = New Drawing.Point(3, 181)
        groupBox4.Name = "groupBox4"
        groupBox4.Size = New Drawing.Size(1082, 207)
        groupBox4.TabIndex = 5
        groupBox4.Text = "Markers"
        groupBox4.UseMnemonic = False
        ' 
        ' tableLayoutPanel1
        ' 
        tableLayoutPanel1.ColumnCount = 2
        tableLayoutPanel1.ColumnStyles.Add(New Web.ColumnStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.ColumnStyles.Add(New Web.ColumnStyle(Web.SizeType.Percent, 50.0F))
        tableLayoutPanel1.Controls.Add(panel3, 1, 1)
        tableLayoutPanel1.Controls.Add(panel2, 1, 0)
        tableLayoutPanel1.Controls.Add(panel1, 0, 0)
        tableLayoutPanel1.Dock = Web.DockStyle.Fill
        tableLayoutPanel1.Location = New Drawing.Point(3, 18)
        tableLayoutPanel1.Name = "tableLayoutPanel1"
        tableLayoutPanel1.RowCount = 2
        tableLayoutPanel1.RowStyles.Add(New Web.RowStyle(Web.SizeType.Absolute, 115.0F))
        tableLayoutPanel1.RowStyles.Add(New Web.RowStyle(Web.SizeType.Absolute, 34.0F))
        tableLayoutPanel1.Size = New Drawing.Size(1076, 186)
        tableLayoutPanel1.TabIndex = 0
        tableLayoutPanel1.TabStop = True
        ' 
        ' panel3
        ' 
        panel3.Controls.Add(button1)
        panel3.Controls.Add(buttonCenterMap)
        panel3.Controls.Add(buttonClearMarkers)
        panel3.Controls.Add(buttonAddMarker)
        panel3.Controls.Add(buttonRemoveMarker)
        panel3.Dock = Web.DockStyle.Fill
        panel3.Location = New Drawing.Point(541, 118)
        panel3.Name = "panel3"
        panel3.Size = New Drawing.Size(532, 65)
        panel3.TabIndex = 2
        panel3.TabStop = True
        ' 
        ' buttonCenterMap
        ' 
        buttonCenterMap.Anchor = Web.AnchorStyles.Right
        buttonCenterMap.Location = New Drawing.Point(120, 11)
        buttonCenterMap.Name = "buttonCenterMap"
        buttonCenterMap.Size = New Drawing.Size(97, 43)
        buttonCenterMap.TabIndex = 11
        buttonCenterMap.Text = "Center Map"
        AddHandler buttonCenterMap.Click, New EventHandler(AddressOf buttonCenterMap_Click)
        ' 
        ' buttonClearMarkers
        ' 
        buttonClearMarkers.Anchor = Web.AnchorStyles.Right
        buttonClearMarkers.Location = New Drawing.Point(429, 11)
        buttonClearMarkers.Name = "buttonClearMarkers"
        buttonClearMarkers.Size = New Drawing.Size(97, 43)
        buttonClearMarkers.TabIndex = 10
        buttonClearMarkers.Text = "Clear"
        AddHandler buttonClearMarkers.Click, New EventHandler(AddressOf buttonClearMarkers_Click)
        ' 
        ' buttonAddMarker
        ' 
        buttonAddMarker.Anchor = Web.AnchorStyles.Right
        buttonAddMarker.Location = New Drawing.Point(223, 11)
        buttonAddMarker.Name = "buttonAddMarker"
        buttonAddMarker.Size = New Drawing.Size(97, 43)
        buttonAddMarker.TabIndex = 8
        buttonAddMarker.Text = "Add"
        AddHandler buttonAddMarker.Click, New EventHandler(AddressOf buttonAddMarker_Click)
        ' 
        ' buttonRemoveMarker
        ' 
        buttonRemoveMarker.Anchor = Web.AnchorStyles.Right
        buttonRemoveMarker.Location = New Drawing.Point(326, 11)
        buttonRemoveMarker.Name = "buttonRemoveMarker"
        buttonRemoveMarker.Size = New Drawing.Size(97, 43)
        buttonRemoveMarker.TabIndex = 9
        buttonRemoveMarker.Text = "Remove"
        AddHandler buttonRemoveMarker.Click, New EventHandler(AddressOf buttonRemoveMarker_Click)
        ' 
        ' panel2
        ' 
        panel2.Controls.Add(label3)
        panel2.Controls.Add(textBoxAddress)
        panel2.Dock = Web.DockStyle.Fill
        panel2.Location = New Drawing.Point(541, 3)
        panel2.Name = "panel2"
        panel2.Size = New Drawing.Size(532, 109)
        panel2.TabIndex = 1
        panel2.TabStop = True
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Drawing.Point(13, 11)
        label3.Name = "label3"
        label3.Size = New Drawing.Size(61, 16)
        label3.TabIndex = 0
        label3.Text = "Address:"
        ' 
        ' textBoxAddress
        ' 
        textBoxAddress.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Bottom Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        textBoxAddress.Location = New Drawing.Point(89, 11)
        textBoxAddress.Multiline = True
        textBoxAddress.Name = "textBoxAddress"
        textBoxAddress.Size = New Drawing.Size(434, 95)
        textBoxAddress.TabIndex = 1
        ' 
        ' panel1
        ' 
        panel1.Controls.Add(maskedTextBoxLng)
        panel1.Controls.Add(label4)
        panel1.Controls.Add(label5)
        panel1.Controls.Add(maskedTextBoxLat)
        panel1.Controls.Add(maskedTextBoxID)
        panel1.Controls.Add(label6)
        panel1.Dock = Web.DockStyle.Fill
        panel1.Location = New Drawing.Point(3, 3)
        panel1.Name = "panel1"
        panel1.Size = New Drawing.Size(532, 109)
        panel1.TabIndex = 0
        panel1.TabStop = True
        ' 
        ' maskedTextBoxLng
        ' 
        maskedTextBoxLng.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        maskedTextBoxLng.Location = New Drawing.Point(90, 65)
        maskedTextBoxLng.Name = "maskedTextBoxLng"
        maskedTextBoxLng.Size = New Drawing.Size(413, 22)
        maskedTextBoxLng.TabIndex = 5
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Drawing.Point(11, 39)
        label4.Name = "label4"
        label4.Size = New Drawing.Size(59, 16)
        label4.TabIndex = 2
        label4.Text = "Latitude:"
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Drawing.Point(10, 67)
        label5.Name = "label5"
        label5.Size = New Drawing.Size(70, 16)
        label5.TabIndex = 3
        label5.Text = "Longitude:"
        ' 
        ' maskedTextBoxLat
        ' 
        maskedTextBoxLat.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        maskedTextBoxLat.Location = New Drawing.Point(90, 37)
        maskedTextBoxLat.Name = "maskedTextBoxLat"
        maskedTextBoxLat.Size = New Drawing.Size(413, 22)
        maskedTextBoxLat.TabIndex = 4
        ' 
        ' maskedTextBoxID
        ' 
        maskedTextBoxID.Location = New Drawing.Point(90, 9)
        maskedTextBoxID.Name = "maskedTextBoxID"
        maskedTextBoxID.Size = New Drawing.Size(77, 22)
        maskedTextBoxID.TabIndex = 7
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Drawing.Point(11, 13)
        label6.Name = "label6"
        label6.Size = New Drawing.Size(25, 16)
        label6.TabIndex = 6
        label6.Text = "ID:"
        ' 
        ' flowLayoutPanel1
        ' 
        flowLayoutPanel1.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right
        flowLayoutPanel1.Controls.Add(groupBox1)
        flowLayoutPanel1.Controls.Add(groupBox2)
        flowLayoutPanel1.Controls.Add(groupBox3)
        flowLayoutPanel1.Controls.Add(groupBox4)
        flowLayoutPanel1.Location = New Drawing.Point(48, 46)
        flowLayoutPanel1.Name = "flowLayoutPanel1"
        flowLayoutPanel1.Size = New Drawing.Size(1088, 388)
        flowLayoutPanel1.TabIndex = 6
        flowLayoutPanel1.TabStop = True
        ' 
        ' button1
        ' 
        button1.Location = New Drawing.Point(11, 4)
        button1.Name = "button1"
        button1.Size = New Drawing.Size(100, 27)
        button1.TabIndex = 12
        button1.Text = "button1"
        AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
        ' 
        ' MapPage
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        AutoScroll = True
        Controls.Add(googleMap1)
        Controls.Add(flowLayoutPanel1)
        Name = "MapPage"
        Size = New Drawing.Size(1188, 862)
        AddHandler Load, New EventHandler(AddressOf MapPage_Load)
        groupBox1.ResumeLayout(False)
        groupBox1.PerformLayout()
        groupBox2.ResumeLayout(False)
        groupBox2.PerformLayout()
        CType(trackBar1, ComponentModel.ISupportInitialize).EndInit()
        groupBox3.ResumeLayout(False)
        groupBox3.PerformLayout()
        CType(numericUpDownMaxZoom, ComponentModel.ISupportInitialize).EndInit()
        CType(numericUpDownMinZoom, ComponentModel.ISupportInitialize).EndInit()
        groupBox4.ResumeLayout(False)
        tableLayoutPanel1.ResumeLayout(False)
        panel3.ResumeLayout(False)
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        flowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
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
