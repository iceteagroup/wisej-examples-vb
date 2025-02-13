Imports Wisej.Web
Imports Wisej.Ext.ClientClipboard

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page1
    Inherits Wisej.Web.Page

    'Overrides dispose to clean up the component list.
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

    'NOTE: The following procedure is required by the Wisej Form Designer
    'It can be modified using the Wisej Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page1))
        Me.label1 = New Wisej.Web.Label()
        Me.pictureBox1 = New Wisej.Web.PictureBox()
        Me.btnCopyImageToClipboardAsync = New Wisej.Web.Button()
        Me.btnCopyImageAsPNG = New Wisej.Web.Button()
        Me.btnCopyImageToClipboard = New Wisej.Web.Button()
        Me.btnReadImageFromClipboardAsync = New Wisej.Web.Button()
        Me.btnReadImageFromClipboard = New Wisej.Web.Button()
        Me.btnLoadImageFile = New Wisej.Web.Button()
        Me.textBox1 = New Wisej.Web.TextBox()
        Me.btnReadTxtAsyncFromClip = New Wisej.Web.Button()
        Me.btnReadTxtFromClip = New Wisej.Web.Button()
        Me.btnWriteTxtToClip = New Wisej.Web.Button()
        Me.btnWriteTxtAsyncToClip = New Wisej.Web.Button()
        Me.dlgBackgroundPicture = New Wisej.Web.OpenFileDialog(Me.components)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(28, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 18)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Image"
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.pictureBox1.Location = New System.Drawing.Point(28, 49)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(316, 524)
        Me.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage
        '
        'btnCopyImageToClipboardAsync
        '
        Me.btnCopyImageToClipboardAsync.Location = New System.Drawing.Point(350, 82)
        Me.btnCopyImageToClipboardAsync.Name = "btnCopyImageToClipboardAsync"
        Me.btnCopyImageToClipboardAsync.Size = New System.Drawing.Size(166, 27)
        Me.btnCopyImageToClipboardAsync.TabIndex = 19
        Me.btnCopyImageToClipboardAsync.Text = "Copy to clip Async"
        '
        'btnCopyImageAsPNG
        '
        Me.btnCopyImageAsPNG.Location = New System.Drawing.Point(350, 148)
        Me.btnCopyImageAsPNG.Name = "btnCopyImageAsPNG"
        Me.btnCopyImageAsPNG.Size = New System.Drawing.Size(166, 27)
        Me.btnCopyImageAsPNG.TabIndex = 16
        Me.btnCopyImageAsPNG.Text = "Copy to clip as Png"
        '
        'btnCopyImageToClipboard
        '
        Me.btnCopyImageToClipboard.Anchor = Wisej.Web.AnchorStyles.Left
        Me.btnCopyImageToClipboard.Location = New System.Drawing.Point(350, 87)
        Me.btnCopyImageToClipboard.Name = "btnCopyImageToClipboard"
        Me.btnCopyImageToClipboard.Size = New System.Drawing.Size(166, 27)
        Me.btnCopyImageToClipboard.TabIndex = 15
        Me.btnCopyImageToClipboard.Text = "Copy to clip Callback"
        '
        'btnReadImageFromClipboardAsync
        '
        Me.btnReadImageFromClipboardAsync.Location = New System.Drawing.Point(350, 352)
        Me.btnReadImageFromClipboardAsync.Name = "btnReadImageFromClipboardAsync"
        Me.btnReadImageFromClipboardAsync.Size = New System.Drawing.Size(166, 27)
        Me.btnReadImageFromClipboardAsync.TabIndex = 18
        Me.btnReadImageFromClipboardAsync.Text = "Read from clip Async"
        '
        'btnReadImageFromClipboard
        '
        Me.btnReadImageFromClipboard.Location = New System.Drawing.Point(350, 223)
        Me.btnReadImageFromClipboard.Name = "btnReadImageFromClipboard"
        Me.btnReadImageFromClipboard.Size = New System.Drawing.Size(166, 27)
        Me.btnReadImageFromClipboard.TabIndex = 17
        Me.btnReadImageFromClipboard.Text = "Read  from clip"
        '
        'btnLoadImageFile
        '
        Me.btnLoadImageFile.Location = New System.Drawing.Point(350, 49)
        Me.btnLoadImageFile.Name = "btnLoadImageFile"
        Me.btnLoadImageFile.Size = New System.Drawing.Size(166, 27)
        Me.btnLoadImageFile.TabIndex = 14
        Me.btnLoadImageFile.Text = "Load Image"
        '
        'textBox1
        '
        Me.textBox1.LabelText = "Text"
        Me.textBox1.Location = New System.Drawing.Point(544, 33)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(285, 540)
        Me.textBox1.TabIndex = 20
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'btnReadTxtAsyncFromClip
        '
        Me.btnReadTxtAsyncFromClip.Location = New System.Drawing.Point(835, 352)
        Me.btnReadTxtAsyncFromClip.Name = "btnReadTxtAsyncFromClip"
        Me.btnReadTxtAsyncFromClip.Size = New System.Drawing.Size(164, 27)
        Me.btnReadTxtAsyncFromClip.TabIndex = 23
        Me.btnReadTxtAsyncFromClip.Text = "Read txt from clip Async"
        '
        'btnReadTxtFromClip
        '
        Me.btnReadTxtFromClip.Location = New System.Drawing.Point(835, 223)
        Me.btnReadTxtFromClip.Name = "btnReadTxtFromClip"
        Me.btnReadTxtFromClip.Size = New System.Drawing.Size(164, 27)
        Me.btnReadTxtFromClip.TabIndex = 24
        Me.btnReadTxtFromClip.Text = "Read txt from clip"
        '
        'btnWriteTxtToClip
        '
        Me.btnWriteTxtToClip.Location = New System.Drawing.Point(835, 115)
        Me.btnWriteTxtToClip.Name = "btnWriteTxtToClip"
        Me.btnWriteTxtToClip.Size = New System.Drawing.Size(164, 27)
        Me.btnWriteTxtToClip.TabIndex = 22
        Me.btnWriteTxtToClip.Text = "Write txt to Clip"
        '
        'btnWriteTxtAsyncToClip
        '
        Me.btnWriteTxtAsyncToClip.Location = New System.Drawing.Point(835, 82)
        Me.btnWriteTxtAsyncToClip.Name = "btnWriteTxtAsyncToClip"
        Me.btnWriteTxtAsyncToClip.Size = New System.Drawing.Size(164, 27)
        Me.btnWriteTxtAsyncToClip.TabIndex = 21
        Me.btnWriteTxtAsyncToClip.Text = "Write txt to clip Async"
        '
        'dlgBackgroundPicture
        '
        Me.dlgBackgroundPicture.Title = "openFileDialog1"
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.btnReadTxtAsyncFromClip)
        Me.Controls.Add(Me.btnReadTxtFromClip)
        Me.Controls.Add(Me.btnWriteTxtToClip)
        Me.Controls.Add(Me.btnWriteTxtAsyncToClip)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.btnCopyImageToClipboardAsync)
        Me.Controls.Add(Me.btnCopyImageAsPNG)
        Me.Controls.Add(Me.btnCopyImageToClipboard)
        Me.Controls.Add(Me.btnReadImageFromClipboardAsync)
        Me.Controls.Add(Me.btnReadImageFromClipboard)
        Me.Controls.Add(Me.btnLoadImageFile)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(1165, 484)
        Me.Text = "Page1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnCopyImageToClipboardAsync As Button
    Private WithEvents btnCopyImageAsPNG As Button
    Private WithEvents btnCopyImageToClipboard As Button
    Private WithEvents btnReadImageFromClipboardAsync As Button
    Private WithEvents btnReadImageFromClipboard As Button
    Private WithEvents btnLoadImageFile As Button
    Private WithEvents textBox1 As TextBox
    Private WithEvents btnReadTxtAsyncFromClip As Button
    Private WithEvents btnReadTxtFromClip As Button
    Private WithEvents btnWriteTxtToClip As Button
    Private WithEvents btnWriteTxtAsyncToClip As Button
    Private WithEvents dlgBackgroundPicture As OpenFileDialog
End Class
