<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBubbles
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
        cbx = New Web.ComboBox()
        btn = New Web.Button()
        numUpDwn = New Web.NumericUpDown()
        txtbx = New Web.TextBox()
        tagtxtbx = New Web.TagTextBox()
        groupBox2 = New Web.GroupBox()
        lblCurrentUser = New Web.Label()
        pannelMsgs = New Web.Panel()
        lvMsgs = New Web.ListBox()
        btnConfirmUsername = New Web.Button()
        txtbxUsername = New Web.TextBox()
        btnSendMessage = New Web.Button()
        txtbxMessage = New Web.TextBox()
        bubble = New Web.Ext.Bubbles.BubbleNotification(components)
        groupBox1.SuspendLayout()
        CType(numUpDwn, ComponentModel.ISupportInitialize).BeginInit()
        groupBox2.SuspendLayout()
        pannelMsgs.SuspendLayout()
        SuspendLayout()
        ' 
        ' groupBox1
        ' 
        groupBox1.Controls.Add(cbx)
        groupBox1.Controls.Add(btn)
        groupBox1.Controls.Add(numUpDwn)
        groupBox1.Controls.Add(txtbx)
        groupBox1.Controls.Add(tagtxtbx)
        groupBox1.Location = New Drawing.Point(40, 47)
        groupBox1.Name = "groupBox1"
        groupBox1.Size = New Drawing.Size(398, 263)
        groupBox1.TabIndex = 0
        groupBox1.Text = "Forms"
        ' 
        ' cbx
        ' 
        cbx.Location = New Drawing.Point(14, 220)
        cbx.Name = "cbx"
        cbx.Size = New Drawing.Size(351, 22)
        cbx.TabIndex = 4
        AddHandler cbx.SelectedValueChanged, New EventHandler(AddressOf cbx_SelectedValueChanged)
        ' 
        ' btn
        ' 
        btn.Location = New Drawing.Point(14, 170)
        btn.Name = "btn"
        btn.Size = New Drawing.Size(155, 27)
        btn.TabIndex = 3
        btn.Text = "Increment"
        AddHandler btn.Click, New EventHandler(AddressOf btn_Click)
        ' 
        ' numUpDwn
        ' 
        numUpDwn.Location = New Drawing.Point(14, 122)
        numUpDwn.Name = "numUpDwn"
        numUpDwn.Size = New Drawing.Size(351, 22)
        numUpDwn.TabIndex = 2
        AddHandler numUpDwn.ValueChanged, New EventHandler(AddressOf numUpDwn_ValueChanged)
        ' 
        ' txtbx
        ' 
        txtbx.Location = New Drawing.Point(14, 75)
        txtbx.Name = "txtbx"
        txtbx.Size = New Drawing.Size(351, 22)
        txtbx.TabIndex = 1
        AddHandler txtbx.TextChanged, New EventHandler(AddressOf txtbx_TextChanged)
        ' 
        ' tagtxtbx
        ' 
        tagtxtbx.Location = New Drawing.Point(14, 23)
        tagtxtbx.Name = "tagtxtbx"
        tagtxtbx.Size = New Drawing.Size(351, 28)
        tagtxtbx.TabIndex = 0
        AddHandler tagtxtbx.TagAdded, New Web.TagTextBoxEventHandler(AddressOf tagtxtbx_TagAdded)
        ' 
        ' groupBox2
        ' 
        groupBox2.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Bottom Or Web.AnchorStyles.Right
        groupBox2.Controls.Add(lblCurrentUser)
        groupBox2.Controls.Add(pannelMsgs)
        groupBox2.Controls.Add(btnConfirmUsername)
        groupBox2.Controls.Add(txtbxUsername)
        groupBox2.Controls.Add(btnSendMessage)
        groupBox2.Controls.Add(txtbxMessage)
        groupBox2.Location = New Drawing.Point(473, 47)
        groupBox2.Name = "groupBox2"
        groupBox2.Size = New Drawing.Size(586, 521)
        groupBox2.TabIndex = 1
        groupBox2.Text = "Simple chat"
        ' 
        ' lblCurrentUser
        ' 
        lblCurrentUser.AutoSize = True
        lblCurrentUser.Location = New Drawing.Point(8, 52)
        lblCurrentUser.Name = "lblCurrentUser"
        lblCurrentUser.Size = New Drawing.Size(8, 15)
        lblCurrentUser.TabIndex = 5
        lblCurrentUser.Text = "-"
        ' 
        ' pannelMsgs
        ' 
        pannelMsgs.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Bottom Or Web.AnchorStyles.Left Or Web.AnchorStyles.Right

        pannelMsgs.Controls.Add(lvMsgs)
        pannelMsgs.Location = New Drawing.Point(8, 75)
        pannelMsgs.Name = "pannelMsgs"
        pannelMsgs.Size = New Drawing.Size(569, 361)
        pannelMsgs.TabIndex = 4
        pannelMsgs.TabStop = True
        ' 
        ' lvMsgs
        ' 
        lvMsgs.Dock = Web.DockStyle.Fill
        lvMsgs.Location = New Drawing.Point(0, 0)
        lvMsgs.Name = "lvMsgs"
        lvMsgs.Size = New Drawing.Size(569, 361)
        lvMsgs.TabIndex = 0
        ' 
        ' btnConfirmUsername
        ' 
        btnConfirmUsername.Location = New Drawing.Point(486, 20)
        btnConfirmUsername.Name = "btnConfirmUsername"
        btnConfirmUsername.Size = New Drawing.Size(91, 27)
        btnConfirmUsername.TabIndex = 3
        btnConfirmUsername.Text = "Confirm"
        AddHandler btnConfirmUsername.Click, New EventHandler(AddressOf btnConfirmUsername_Click)
        ' 
        ' txtbxUsername
        ' 
        txtbxUsername.Location = New Drawing.Point(8, 22)
        txtbxUsername.Name = "txtbxUsername"
        txtbxUsername.Size = New Drawing.Size(454, 22)
        txtbxUsername.TabIndex = 2
        txtbxUsername.Watermark = "Set your username"
        ' 
        ' btnSendMessage
        ' 
        btnSendMessage.Anchor = Web.AnchorStyles.Bottom Or Web.AnchorStyles.Right
        btnSendMessage.Enabled = False
        btnSendMessage.Location = New Drawing.Point(486, 486)
        btnSendMessage.Name = "btnSendMessage"
        btnSendMessage.Size = New Drawing.Size(91, 27)
        btnSendMessage.TabIndex = 1
        btnSendMessage.Text = "Send"
        AddHandler btnSendMessage.Click, New EventHandler(AddressOf btnSendMessage_Click)
        ' 
        ' txtbxMessage
        ' 
        txtbxMessage.Anchor = Web.AnchorStyles.Top Or Web.AnchorStyles.Bottom Or Web.AnchorStyles.Left
        txtbxMessage.Enabled = False
        txtbxMessage.Location = New Drawing.Point(8, 453)
        txtbxMessage.Multiline = True
        txtbxMessage.Name = "txtbxMessage"
        txtbxMessage.Size = New Drawing.Size(470, 61)
        txtbxMessage.TabIndex = 0
        txtbxMessage.Watermark = "Type your message"
        ' 
        ' bubble
        ' 
        bubble.Alignment = Drawing.ContentAlignment.MiddleRight
        ' 
        ' frmBubbles
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 16.0F)
        AutoScaleMode = Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(1108, 607)
        Controls.Add(groupBox2)
        Controls.Add(groupBox1)
        Name = "frmBubbles"
        Text = "Bubbles"
        AddHandler Load, New EventHandler(AddressOf frmBubbles_Load)
        groupBox1.ResumeLayout(False)
        groupBox1.PerformLayout()
        CType(numUpDwn, ComponentModel.ISupportInitialize).EndInit()
        groupBox2.ResumeLayout(False)
        groupBox2.PerformLayout()
        pannelMsgs.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

#End Region

    Private groupBox1 As Web.GroupBox
    Private groupBox2 As Web.GroupBox
    Private pannelMsgs As Web.Panel
    Private btnConfirmUsername As Web.Button
    Private txtbxUsername As Web.TextBox
    Private btnSendMessage As Web.Button
    Private txtbxMessage As Web.TextBox
    Private lblCurrentUser As Web.Label
    Private lvMsgs As Web.ListBox
    Private bubble As Web.Ext.Bubbles.BubbleNotification
    Private cbx As Web.ComboBox
    Private btn As Web.Button
    Private numUpDwn As Web.NumericUpDown
    Private txtbx As Web.TextBox
    Private tagtxtbx As Web.TagTextBox
End Class
