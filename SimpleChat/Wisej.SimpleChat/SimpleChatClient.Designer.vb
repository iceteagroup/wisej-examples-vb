Imports System
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SimpleChatClient
    Inherits Page
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
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim ComponentTool2 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Dim ComponentTool3 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Me.textBoxName = New Wisej.Web.TextBox()
        Me.buttonJoin = New Wisej.Web.Button()
        Me.buttonLeave = New Wisej.Web.Button()
        Me.listBoxMessage = New Wisej.Web.ListBox()
        Me.textBoxMessage = New Wisej.Web.TextBox()
        Me.buttonSend = New Wisej.Web.Button()
        Me.errorProvider = New Wisej.Web.ErrorProvider(Me.components)
        Me.label1 = New Wisej.Web.Label()
        Me.updateTimer = New Wisej.Web.Timer(Me.components)
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBoxName
        '
        Me.textBoxName.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.textBoxName.AutoSize = False
        Me.textBoxName.Location = New System.Drawing.Point(88, 89)
        Me.textBoxName.Name = "textBoxName"
        Me.textBoxName.Size = New System.Drawing.Size(437, 46)
        Me.textBoxName.TabIndex = 1
        Me.textBoxName.Watermark = "Name"
        '
        'buttonJoin
        '
        Me.buttonJoin.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.buttonJoin.Location = New System.Drawing.Point(558, 89)
        Me.buttonJoin.Name = "buttonJoin"
        Me.buttonJoin.Size = New System.Drawing.Size(236, 46)
        Me.buttonJoin.TabIndex = 2
        Me.buttonJoin.Text = "Join"
        '
        'buttonLeave
        '
        Me.buttonLeave.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.buttonLeave.Enabled = False
        Me.buttonLeave.Location = New System.Drawing.Point(819, 89)
        Me.buttonLeave.Name = "buttonLeave"
        Me.buttonLeave.Size = New System.Drawing.Size(236, 46)
        Me.buttonLeave.TabIndex = 3
        Me.buttonLeave.Text = "Leave"
        '
        'listBoxMessage
        '
        Me.listBoxMessage.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.listBoxMessage.HorizontalScrollbar = True
        Me.listBoxMessage.Location = New System.Drawing.Point(88, 163)
        Me.listBoxMessage.Name = "listBoxMessage"
        Me.listBoxMessage.Size = New System.Drawing.Size(967, 272)
        Me.listBoxMessage.TabIndex = 4
        ComponentTool1.ImageSource = "tab-close"
        ComponentTool1.Name = "Clear"
        ComponentTool1.ToolTipText = "Clear all messages."
        ComponentTool2.ImageSource = "icon-save"
        ComponentTool2.Name = "Save"
        ComponentTool2.ToolTipText = "Save messages."
        Me.listBoxMessage.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1, ComponentTool2})
        '
        'textBoxMessage
        '
        Me.textBoxMessage.Anchor = CType(((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.textBoxMessage.AutoSize = False
        Me.textBoxMessage.Enabled = False
        Me.textBoxMessage.Location = New System.Drawing.Point(88, 464)
        Me.textBoxMessage.Name = "textBoxMessage"
        Me.textBoxMessage.Size = New System.Drawing.Size(706, 46)
        Me.textBoxMessage.TabIndex = 5
        ComponentTool3.ImageSource = "tab-close"
        ComponentTool3.Name = "Clear"
        ComponentTool3.ToolTipText = "Clear"
        Me.textBoxMessage.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool3})
        Me.textBoxMessage.Watermark = "Message"
        '
        'buttonSend
        '
        Me.buttonSend.Anchor = CType((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.buttonSend.Enabled = False
        Me.buttonSend.Location = New System.Drawing.Point(819, 464)
        Me.buttonSend.Name = "buttonSend"
        Me.buttonSend.Size = New System.Drawing.Size(236, 46)
        Me.buttonSend.TabIndex = 6
        Me.buttonSend.Text = "Send"
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label1.ForeColor = System.Drawing.Color.FromName("@activeCaption")
        Me.label1.Location = New System.Drawing.Point(88, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(306, 43)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Simple Chat"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SimpleChatClient
        '
        Me.Accelerators = New Wisej.Web.Keys() {Wisej.Web.Keys.Enter}
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.buttonSend)
        Me.Controls.Add(Me.textBoxMessage)
        Me.Controls.Add(Me.listBoxMessage)
        Me.Controls.Add(Me.buttonLeave)
        Me.Controls.Add(Me.buttonJoin)
        Me.Controls.Add(Me.textBoxName)
        Me.Name = "SimpleChatClient"
        Me.Size = New System.Drawing.Size(1143, 591)
        Me.Text = "SimpleChat"
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


#End Region

    Friend WithEvents textBoxName As Web.TextBox
    Friend WithEvents buttonJoin As Web.Button
    Friend WithEvents buttonLeave As Web.Button
    Friend WithEvents listBoxMessage As Web.ListBox
    Friend WithEvents textBoxMessage As Web.TextBox
    Friend WithEvents buttonSend As Web.Button
    Friend WithEvents errorProvider As Web.ErrorProvider
    Friend WithEvents label1 As Web.Label
    Friend WithEvents updateTimer As Web.Timer
End Class



