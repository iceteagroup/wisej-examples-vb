Imports System
Imports System.Drawing
Imports Wisej.Web
Imports System.IO

Public Class Window1

    Private Sub upload1_Uploaded(ByVal sender As Object, ByVal e As UploadedEventArgs) Handles upload1.Uploaded
        LoadFile(e.Files)
    End Sub

    Private Sub upload2_Uploaded(ByVal sender As Object, ByVal e As UploadedEventArgs) Handles upload2.Uploaded
        LoadFiles(e.Files)
    End Sub
    Private Sub pictureBox_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles pictureBox.DragEnter, flowLayoutPanel.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub pictureBox_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles pictureBox.DragDrop
        LoadFile(CType(e.Data.GetData(DataFormats.Files), HttpFileCollection))
    End Sub
    Private Sub flowLayoutPanel_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.AllowedFileTypes = "image.*"
            Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

            If files IsNot Nothing Then

                For Each type As String In files

                    If type.IndexOf("/png") > -1 OrElse type.IndexOf("/jpg") > -1 OrElse type.IndexOf("/jpeg") > -1 OrElse type.IndexOf("/gif") > -1 Then
                        e.Effect = DragDropEffects.Copy
                        Return
                    End If
                Next
            End If
        End If

        e.Effect = DragDropEffects.None
    End Sub
    Private Sub flowLayoutPanel_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles flowLayoutPanel.DragDrop
        LoadFiles(CType(e.Data.GetData(DataFormats.Files), HttpFileCollection))
    End Sub

    Private Sub buttonClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonClear.Click
        flowLayoutPanel.Controls.Clear(True)
    End Sub

    Private Sub LoadFile(ByVal files As HttpFileCollection)
        If files Is Nothing Then Return

        If files.Count = 0 Then
            pictureBox.Image = Nothing
        Else
            pictureBox.Image = GetImageFromStream(files(0).InputStream)
        End If
    End Sub

    ' Process multiple files and create a new child PictureBox inside
    ' the flow layout panel. Each PictureBox handles the click event to trigger the download of the
    ' uploaded file.
    Private Sub LoadFiles(ByVal files As HttpFileCollection)
        If files Is Nothing Then Return
        Dim count As Integer = files.Count

        If count > 0 Then

            For i As Integer = 0 To count - 1
                Dim box As PictureBox = New PictureBox() With {
                    .Name = files(i).FileName,
                    .Width = 64,
                    .Height = 64,
                    .SizeMode = PictureBoxSizeMode.Zoom,
                    .BorderStyle = BorderStyle.Solid,
                    .Margin = New Padding(5),
                    .Cursor = Cursors.Hand
                }
                box.Image = GetImageFromStream(files(i).InputStream)
                AddHandler box.MouseClick, Sub(se, ev)
                                               Dim result As DialogResult = MessageBox.Show("You clicked " & box.Name & "<br/><br/>Would you like to download this file?", "Download", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                                               If result = DialogResult.Yes Then
                                                   Application.Download(box.Image, box.Name)
                                               End If
                                           End Sub

                flowLayoutPanel.Controls.Add(box)
            Next
        End If
    End Sub

    ' Reads the image from the uploaded stream and preserves the stream
    ' in case it's an animated gif.
    Private Function GetImageFromStream(ByVal stream As Stream) As Image
        Dim mem As MemoryStream = New MemoryStream()
        stream.CopyTo(mem, 1024)
        mem.Position = 0
        Return Image.FromStream(mem)
    End Function
End Class
