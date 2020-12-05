Imports System
Imports Wisej.Web
Imports System.Web
Imports System.IO

Partial Public Class Page1

    Private fileStream As Stream

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        OpenFileDialog.Roots(0).Root = Application.MapPath("~\Samples")
        MyBase.OnLoad(e)
    End Sub

    Private Async Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        If Equals(Application.Browser.Device, "Mobile") Then openFileDialog.WindowState = FormWindowState.Maximized

        If Await openFileDialog.ShowDialogAsync() = DialogResult.OK Then
            ' The widget will issue a request to download the file using the special postback url 
            ' to route the request bacck to the specific instance of the widget.
            widget1.Call("loadFile", openFileDialog.FileName)
        End If
    End Sub

    Private Sub widget1_WebRequest(ByVal sender As Object, ByVal e As WebRequestEventArgs)
        ' Wisej.Web.Widget is able to act as a request handler and return any content.
        Select Case e.Request("action")
            Case "load"
                Dim file = e.Request("file")

                If Equals(file, "*") Then

                    ' return the stream.
                    If fileStream IsNot Nothing Then
                        fileStream.CopyTo(e.Response.OutputStream)
                        e.Response.Flush()
                        fileStream = Nothing
                    End If
                Else
                    ' map the path on the server so we don't send unsafe full paths to the browser.
                    Dim path = openFileDialog.MapPath(file)
                    e.Response.TransmitFile(path)
                End If
        End Select
    End Sub

    Private Async Sub widget1_WidgetEvent(ByVal sender As Object, ByVal e As WidgetEventArgs)
        Select Case e.Type
            Case "loaded"

                ' load the procedures in the combobox once the file is loaded.
                'Dim list As Dynamic() = Await widget1.CallAsync("readProcedures")
                Dim list As Object = Await widget1.CallAsync("readProcedures")

                comboBox1.Enabled = True
                comboBox1.Items.Clear()
                comboBox1.Items.AddRange(list)
                If list.Length > 0 Then comboBox1.SelectedIndex = 0
            Case "nodeSelected"
                AlertBox.Show($"Selected Node: {e.Data}")
        End Select
    End Sub

    Private Async Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        comboBox2.Items.Clear()

        If comboBox1.SelectedIndex > -1 Then
            ' load the steps in the combobox when a procedure is selected.
            'Dim list As Dynamic() = Await widget1.CallAsync("readSteps", CType(comboBox1.SelectedItem, Dynamic).id)
            Dim list As Object = Await widget1.CallAsync("readSteps", CType(comboBox1.SelectedItem, Object).id)

            button2.Enabled = True
            comboBox2.Enabled = True
            comboBox2.Items.AddRange(list)
        End If
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        'If comboBox2.SelectedIndex > -1 Then widget1.Call("playStep", CType(comboBox2.SelectedItem, Dynamic).id)
        If comboBox2.SelectedIndex > -1 Then widget1.Call("playStep", CType(comboBox2.SelectedItem, Object).id)
    End Sub

    Private Sub widget1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
        e.AllowedFileTypes = ".vds"
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub widget1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
        Dim files = CType(e.Data.GetData(DataFormats.Files), HttpFileCollection)
        If files?.Count > 0 Then LoadFileStream(files(0).InputStream)
    End Sub

    Private Sub upload1_Uploaded(ByVal sender As Object, ByVal e As UploadedEventArgs) Handles upload1.Uploaded
        If e.Files.Count > 0 Then LoadFileStream(e.Files(0).InputStream)
    End Sub

    Private Sub LoadFileStream(ByVal stream As Stream)
        fileStream = New MemoryStream()
        stream.CopyTo(fileStream)
        fileStream.Position = 0
        widget1.Call("loadFile", "*")
    End Sub
End Class
