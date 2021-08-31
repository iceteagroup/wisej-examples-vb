Imports System
Imports System.Web
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBubbles
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
        Me.cbx = New Wisej.Web.ComboBox()
        Me.btn = New Wisej.Web.Button()
        Me.numUpDwn = New Wisej.Web.NumericUpDown()
        Me.txtbx = New Wisej.Web.TextBox()
        Me.tagtxtbx = New Wisej.Web.TagTextBox()
        Me.groupBox2 = New Wisej.Web.GroupBox()
        Me.lblCurrentUser = New Wisej.Web.Label()
        Me.pannelMsgs = New Wisej.Web.Panel()
        Me.lvMsgs = New Wisej.Web.ListBox()
        Me.btnConfirmUsername = New Wisej.Web.Button()
        Me.txtbxUsername = New Wisej.Web.TextBox()
        Me.btnSendMessage = New Wisej.Web.Button()
        Me.txtbxMessage = New Wisej.Web.TextBox()
        Me.bubble = New Wisej.Web.Ext.Bubbles.BubbleNotification(Me.components)
        Me.groupBox1.SuspendLayout()
        CType(Me.numUpDwn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.pannelMsgs.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cbx)
        Me.groupBox1.Controls.Add(Me.btn)
        Me.groupBox1.Controls.Add(Me.numUpDwn)
        Me.groupBox1.Controls.Add(Me.txtbx)
        Me.groupBox1.Controls.Add(Me.tagtxtbx)
        Me.groupBox1.Location = New System.Drawing.Point(40, 47)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(398, 263)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.Text = "Forms"
        '
        'cbx
        '
        Me.cbx.Location = New System.Drawing.Point(14, 220)
        Me.cbx.Name = "cbx"
        Me.cbx.Size = New System.Drawing.Size(351, 22)
        Me.cbx.TabIndex = 4
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(14, 170)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(155, 27)
        Me.btn.TabIndex = 3
        Me.btn.Text = "Increment"
        '
        'numUpDwn
        '
        Me.numUpDwn.Location = New System.Drawing.Point(14, 122)
        Me.numUpDwn.Name = "numUpDwn"
        Me.numUpDwn.Size = New System.Drawing.Size(351, 22)
        Me.numUpDwn.TabIndex = 2
        '
        'txtbx
        '
        Me.txtbx.Location = New System.Drawing.Point(14, 75)
        Me.txtbx.Name = "txtbx"
        Me.txtbx.Size = New System.Drawing.Size(351, 22)
        Me.txtbx.TabIndex = 1
        '
        'tagtxtbx
        '
        Me.tagtxtbx.Location = New System.Drawing.Point(14, 23)
        Me.tagtxtbx.Name = "tagtxtbx"
        Me.tagtxtbx.Size = New System.Drawing.Size(351, 28)
        Me.tagtxtbx.TabIndex = 0
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.groupBox2.Controls.Add(Me.lblCurrentUser)
        Me.groupBox2.Controls.Add(Me.pannelMsgs)
        Me.groupBox2.Controls.Add(Me.btnConfirmUsername)
        Me.groupBox2.Controls.Add(Me.txtbxUsername)
        Me.groupBox2.Controls.Add(Me.btnSendMessage)
        Me.groupBox2.Controls.Add(Me.txtbxMessage)
        Me.groupBox2.Location = New System.Drawing.Point(473, 47)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(586, 521)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.Text = "Simple chat"
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.AutoSize = True
        Me.lblCurrentUser.Location = New System.Drawing.Point(8, 52)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(9, 15)
        Me.lblCurrentUser.TabIndex = 5
        Me.lblCurrentUser.Text = "-"
        '
        'pannelMsgs
        '
        Me.pannelMsgs.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.pannelMsgs.Controls.Add(Me.lvMsgs)
        Me.pannelMsgs.Location = New System.Drawing.Point(8, 75)
        Me.pannelMsgs.Name = "pannelMsgs"
        Me.pannelMsgs.Size = New System.Drawing.Size(569, 361)
        Me.pannelMsgs.TabIndex = 4
        Me.pannelMsgs.TabStop = True
        '
        'lvMsgs
        '
        Me.lvMsgs.Dock = Wisej.Web.DockStyle.Fill
        Me.lvMsgs.Location = New System.Drawing.Point(0, 0)
        Me.lvMsgs.Name = "lvMsgs"
        Me.lvMsgs.Size = New System.Drawing.Size(569, 361)
        Me.lvMsgs.TabIndex = 0
        '
        'btnConfirmUsername
        '
        Me.btnConfirmUsername.Location = New System.Drawing.Point(486, 20)
        Me.btnConfirmUsername.Name = "btnConfirmUsername"
        Me.btnConfirmUsername.Size = New System.Drawing.Size(91, 27)
        Me.btnConfirmUsername.TabIndex = 3
        Me.btnConfirmUsername.Text = "Confirm"
        '
        'txtbxUsername
        '
        Me.txtbxUsername.Location = New System.Drawing.Point(8, 22)
        Me.txtbxUsername.Name = "txtbxUsername"
        Me.txtbxUsername.Size = New System.Drawing.Size(454, 22)
        Me.txtbxUsername.TabIndex = 2
        Me.txtbxUsername.Watermark = "Set your username"
        '
        'btnSendMessage
        '
        Me.btnSendMessage.Anchor = CType((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.btnSendMessage.Enabled = False
        Me.btnSendMessage.Location = New System.Drawing.Point(486, 486)
        Me.btnSendMessage.Name = "btnSendMessage"
        Me.btnSendMessage.Size = New System.Drawing.Size(91, 27)
        Me.btnSendMessage.TabIndex = 1
        Me.btnSendMessage.Text = "Send"
        '
        'txtbxMessage
        '
        Me.txtbxMessage.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left), Wisej.Web.AnchorStyles)
        Me.txtbxMessage.Enabled = False
        Me.txtbxMessage.Location = New System.Drawing.Point(8, 453)
        Me.txtbxMessage.Multiline = True
        Me.txtbxMessage.Name = "txtbxMessage"
        Me.txtbxMessage.Size = New System.Drawing.Size(470, 61)
        Me.txtbxMessage.TabIndex = 0
        Me.txtbxMessage.Watermark = "Type your message"
        '
        'bubble
        '
        Me.bubble.Alignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmBubbles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 607)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "frmBubbles"
        Me.Text = "Bubbles"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.numUpDwn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.pannelMsgs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents groupBox1 As Wisej.Web.GroupBox
    Friend WithEvents groupBox2 As Wisej.Web.GroupBox
    Friend WithEvents pannelMsgs As Wisej.Web.Panel
    Friend WithEvents btnConfirmUsername As Wisej.Web.Button
    Friend WithEvents txtbxUsername As Wisej.Web.TextBox
    Friend WithEvents btnSendMessage As Wisej.Web.Button
    Friend WithEvents txtbxMessage As Wisej.Web.TextBox
    Friend WithEvents lblCurrentUser As Wisej.Web.Label
    Friend WithEvents lvMsgs As Wisej.Web.ListBox
    Friend WithEvents bubble As Wisej.Web.Ext.Bubbles.BubbleNotification
    Friend WithEvents cbx As Wisej.Web.ComboBox
    Friend WithEvents btn As Wisej.Web.Button
    Friend WithEvents numUpDwn As Wisej.Web.NumericUpDown
    Friend WithEvents txtbx As Wisej.Web.TextBox
    Friend WithEvents tagtxtbx As Wisej.Web.TagTextBox
End Class
