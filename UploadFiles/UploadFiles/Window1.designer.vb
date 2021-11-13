<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window1
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pictureBox = New Wisej.Web.PictureBox()
        Me.label1 = New Wisej.Web.Label()
        Me.upload1 = New Wisej.Web.Upload()
        Me.label2 = New Wisej.Web.Label()
        Me.flowLayoutPanel = New Wisej.Web.FlowLayoutPanel()
        Me.upload2 = New Wisej.Web.Upload()
        Me.buttonClear = New Wisej.Web.Button()
        Me.helpTip = New Wisej.Web.HelpTip(Me.components)
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox
        '
        Me.pictureBox.AllowDrop = True
        Me.pictureBox.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left), Wisej.Web.AnchorStyles)
        Me.pictureBox.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pictureBox.Location = New System.Drawing.Point(22, 53)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(258, 372)
        Me.pictureBox.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom
        '
        'label1
        '
        Me.label1.AllowHtml = True
        Me.label1.Location = New System.Drawing.Point(22, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(202, 18)
        Me.label1.TabIndex = 1
        Me.label1.Text = "PictureBox <b>(Drop Target)</b>"
        '
        'upload1
        '
        Me.upload1.AllowedFileTypes = "image/*"
        Me.upload1.Anchor = CType((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left), Wisej.Web.AnchorStyles)
        Me.upload1.HideValue = True
        Me.upload1.Location = New System.Drawing.Point(22, 441)
        Me.upload1.Name = "upload1"
        Me.upload1.Size = New System.Drawing.Size(258, 43)
        Me.upload1.TabIndex = 2
        Me.upload1.Text = "Click to upload a new image"
        '
        'label2
        '
        Me.label2.AllowHtml = True
        Me.label2.Location = New System.Drawing.Point(295, 19)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(322, 18)
        Me.label2.TabIndex = 3
        Me.label2.Text = "FlowLayoutPanel <b>(Multiple Files Drop Target)</b>"
        '
        'flowLayoutPanel
        '
        Me.flowLayoutPanel.AllowDrop = True
        Me.flowLayoutPanel.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.flowLayoutPanel.AutoScroll = True
        Me.flowLayoutPanel.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.helpTip.SetHelpTip(Me.flowLayoutPanel, "Click on an image to download it.")
        Me.flowLayoutPanel.Location = New System.Drawing.Point(295, 53)
        Me.flowLayoutPanel.Name = "flowLayoutPanel"
        Me.flowLayoutPanel.Size = New System.Drawing.Size(438, 372)
        Me.flowLayoutPanel.TabIndex = 4
        Me.flowLayoutPanel.TabStop = True
        '
        'upload2
        '
        Me.upload2.AllowMultipleFiles = True
        Me.upload2.Anchor = CType(((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.upload2.HideValue = True
        Me.upload2.Location = New System.Drawing.Point(295, 441)
        Me.upload2.Name = "upload2"
        Me.upload2.Size = New System.Drawing.Size(309, 43)
        Me.upload2.TabIndex = 5
        Me.upload2.Text = "Click to upload multiple images"
        '
        'buttonClear
        '
        Me.buttonClear.Anchor = CType((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.buttonClear.Location = New System.Drawing.Point(621, 441)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(112, 43)
        Me.buttonClear.TabIndex = 7
        Me.buttonClear.Text = "Clear"
        '
        'Window1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.buttonClear)
        Me.Controls.Add(Me.upload2)
        Me.Controls.Add(Me.flowLayoutPanel)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.upload1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox)
        Me.Name = "Window1"
        Me.StartPosition = Wisej.Web.FormStartPosition.CenterScreen
        Me.Text = "Window1"
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pictureBox As Wisej.Web.PictureBox
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents upload1 As Wisej.Web.Upload
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents flowLayoutPanel As Wisej.Web.FlowLayoutPanel
    Friend WithEvents upload2 As Wisej.Web.Upload
    Friend WithEvents buttonClear As Wisej.Web.Button
    Friend WithEvents helpTip As Wisej.Web.HelpTip
End Class
