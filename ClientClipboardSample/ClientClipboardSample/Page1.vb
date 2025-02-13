Imports System.IO
Imports System.Drawing
Imports Wisej.Web
Imports Wisej.Core


Public Class Page1

    Private Sub btnLoadImageFile_Click(sender As Object, e As EventArgs) Handles btnLoadImageFile.Click

        'Full path
        Dim sPath As String = Path.Combine(Application.StartupPath)
        dlgBackgroundPicture.Roots.Add(New FileSystemProvider(sPath, "My Files"))

        'Data files path 
        sPath = Path.Combine(Application.StartupPath, "images")
        dlgBackgroundPicture.Roots.Add(New FileSystemProvider(sPath, "Image Files"))

        'Initial directory to show at user. 
        dlgBackgroundPicture.InitialDirectory = "Image Files"

        dlgBackgroundPicture.Filter = "png files (*.png)|*.png|All files (*.*)|*.*"
        dlgBackgroundPicture.FilterIndex = 2

        If (dlgBackgroundPicture.ShowDialog() = DialogResult.OK) Then

            'Read the contents of the file into a stream
            Dim FileStream As Stream = dlgBackgroundPicture.OpenFile()

            pictureBox1.Image = Bitmap.FromStream(FileStream)
        End If
    End Sub

    Private Sub btnCopyImageToClipboardAsync_Click(sender As Object, e As EventArgs) Handles btnCopyImageToClipboardAsync.Click
        Wisej.Ext.ClientClipboard.ClientClipboard.WriteImageAsync(pictureBox1.Image)
    End Sub

    Private Sub btnCopyImageToClipboard_Click(sender As Object, e As EventArgs) Handles btnCopyImageToClipboard.Click

        Wisej.Ext.ClientClipboard.ClientClipboard.WriteImage(pictureBox1.Image, Sub() ImageToClipBoard())

    End Sub

    Private Sub ImageToClipBoard()
        MessageBox.Show("Image copied to Clipboard")
    End Sub

    Private Sub btnCopyImageAsPNG_Click(sender As Object, e As EventArgs) Handles btnCopyImageAsPNG.Click

        Dim Format As Imaging.ImageFormat = Imaging.ImageFormat.Png

        Wisej.Ext.ClientClipboard.ClientClipboard.WriteImageAsync(pictureBox1.Image, Format)

    End Sub

    Private Sub btnReadImageFromClipboard_Click(sender As Object, e As EventArgs) Handles btnReadImageFromClipboard.Click

        Call Wisej.Ext.ClientClipboard.ClientClipboard.ReadImage(New Action(Of Image)(AddressOf ImageFromClipboard))
    End Sub

    Private Sub ImageFromClipboard(ByVal _image As Image)
        pictureBox1.Image = _image
    End Sub

    Private Async Sub btnReadImageFromClipboardAsync_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReadImageFromClipboardAsync.Click

        pictureBox1.Image = Await Wisej.Ext.ClientClipboard.ClientClipboard.ReadImageAsync()

    End Sub

    Private Sub btnWriteTxtAsyncToClip_Click(sender As Object, e As EventArgs) Handles btnWriteTxtAsyncToClip.Click
        Wisej.Ext.ClientClipboard.ClientClipboard.WriteTextAsync(textBox1.Text)
    End Sub

    Private Sub btnWriteTxtToClip_Click(sender As Object, e As EventArgs) Handles btnWriteTxtToClip.Click
        Call Wisej.Ext.ClientClipboard.ClientClipboard.WriteText(textBox1.Text, New Action(AddressOf TextCopied))
    End Sub

    Private Sub TextCopied()
        MessageBox.Show("Text copied to clipboard")
    End Sub

    Private Sub btnReadTxtFromClip_Click(sender As Object, e As EventArgs) Handles btnReadTxtFromClip.Click
        Call Wisej.Ext.ClientClipboard.ClientClipboard.ReadText(New Action(Of String)(AddressOf TextReaded))
    End Sub

    Private Sub TextReaded(ByVal text As String)
        textBox1.Text = text
    End Sub

    Private Async Sub btnReadTxtAsyncFromClip_Click(sender As Object, e As EventArgs) Handles btnReadTxtAsyncFromClip.Click
        textBox1.Text = Await Wisej.Ext.ClientClipboard.ClientClipboard.ReadTextAsync()
    End Sub

End Class
