<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window1
    Inherits Wisej.Web.Form
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


#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        pictureBox = New Wisej.Web.PictureBox()
        label1 = New Wisej.Web.Label()
        upload1 = New Wisej.Web.Upload()
        label2 = New Wisej.Web.Label()
        flowLayoutPanel = New Wisej.Web.FlowLayoutPanel()
        upload2 = New Wisej.Web.Upload()
        buttonClear = New Wisej.Web.Button()
        helpTip = New Wisej.Web.HelpTip(components)
        CType(pictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBox
        ' 
        pictureBox.AllowDrop = True
        pictureBox.Anchor = Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left
        pictureBox.BorderStyle = Wisej.Web.BorderStyle.Solid
        helpTip.SetHelpTip(pictureBox, Nothing)
        pictureBox.Location = New Drawing.Point(22, 53)
        pictureBox.Name = "pictureBox"
        pictureBox.Size = New Drawing.Size(258, 372)
        pictureBox.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom
        pictureBox.TabIndex = 6
        pictureBox.TabStop = False
        AddHandler pictureBox.DragDrop, New Wisej.Web.DragEventHandler(AddressOf pictureBox_DragDrop)
        AddHandler pictureBox.DragEnter, New Wisej.Web.DragEventHandler(AddressOf pictureBox_DragEnter)
        ' 
        ' label1
        ' 
        label1.AllowHtml = True
        helpTip.SetHelpTip(label1, Nothing)
        label1.Location = New Drawing.Point(22, 19)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(202, 18)
        label1.TabIndex = 1
        label1.Text = "PictureBox <b>(Drop Target)</b>"
        ' 
        ' upload1
        ' 
        upload1.Anchor = Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left
        helpTip.SetHelpTip(upload1, Nothing)
        upload1.HideValue = True
        upload1.Location = New Drawing.Point(22, 441)
        upload1.Name = "upload1"
        upload1.Size = New Drawing.Size(258, 43)
        upload1.TabIndex = 2
        upload1.AllowedFileTypes = "image/*"
        upload1.Text = "Click to upload a new image"
        AddHandler upload1.Uploaded, New Wisej.Web.UploadedEventHandler(AddressOf upload1_Uploaded)
        ' 
        ' label2
        ' 
        label2.AllowHtml = True
        helpTip.SetHelpTip(label2, Nothing)
        label2.Location = New Drawing.Point(295, 19)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(322, 18)
        label2.TabIndex = 3
        label2.Text = "FlowLayoutPanel <b>(Multiple Files Drop Target)</b>"
        ' 
        ' flowLayoutPanel
        ' 
        flowLayoutPanel.AllowDrop = True
        flowLayoutPanel.Anchor = Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left Or Wisej.Web.AnchorStyles.Right
        flowLayoutPanel.AutoScroll = True
        flowLayoutPanel.BorderStyle = Wisej.Web.BorderStyle.Solid
        helpTip.SetHelpTip(flowLayoutPanel, "Click on an image to download it.")
        flowLayoutPanel.Location = New Drawing.Point(295, 53)
        flowLayoutPanel.Name = "flowLayoutPanel"
        flowLayoutPanel.Size = New Drawing.Size(438, 372)
        flowLayoutPanel.TabIndex = 4
        AddHandler flowLayoutPanel.DragDrop, New Wisej.Web.DragEventHandler(AddressOf flowLayoutPanel_DragDrop)
        AddHandler flowLayoutPanel.DragEnter, New Wisej.Web.DragEventHandler(AddressOf flowLayoutPanel_DragEnter)
        ' 
        ' upload2
        ' 
        upload2.AllowMultipleFiles = True
        upload2.Anchor = Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left Or Wisej.Web.AnchorStyles.Right
        helpTip.SetHelpTip(upload2, Nothing)
        upload2.HideValue = True
        upload2.Location = New Drawing.Point(295, 441)
        upload2.Name = "upload2"
        upload2.Size = New Drawing.Size(309, 43)
        upload2.TabIndex = 5
        upload2.Text = "Click to upload multiple images"
        AddHandler upload2.Uploaded, New Wisej.Web.UploadedEventHandler(AddressOf upload2_Uploaded)
        ' 
        ' buttonClear
        ' 
        buttonClear.Anchor = Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Right
        helpTip.SetHelpTip(buttonClear, Nothing)
        buttonClear.Location = New Drawing.Point(621, 441)
        buttonClear.Name = "buttonClear"
        buttonClear.Size = New Drawing.Size(112, 43)
        buttonClear.TabIndex = 7
        buttonClear.Text = "Clear"
        AddHandler buttonClear.Click, New EventHandler(AddressOf buttonClear_Click)
        ' 
        ' Window1
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6.0F, 17.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        ClientSize = New Drawing.Size(755, 505)
        ControlBox = False
        Controls.Add(buttonClear)
        Controls.Add(upload2)
        Controls.Add(flowLayoutPanel)
        Controls.Add(label2)
        Controls.Add(upload1)
        Controls.Add(label1)
        Controls.Add(pictureBox)
        helpTip.SetHelpTip(Me, Nothing)
        Name = "Window1"
        StartPosition = Wisej.Web.FormStartPosition.CenterScreen
        Text = "Window1"
        CType(pictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub


#End Region

    Friend WithEvents pictureBox As Wisej.Web.PictureBox
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents upload1 As Wisej.Web.Upload
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents flowLayoutPanel As Wisej.Web.FlowLayoutPanel
    Friend WithEvents upload2 As Wisej.Web.Upload
    Friend WithEvents buttonClear As Wisej.Web.Button
    Friend WithEvents helpTip As Wisej.Web.HelpTip
End Class
