Imports System
Imports System.IO
Imports Wisej.Web


Partial Public Class SimpleChatClient

        Private joined As Boolean

        Public Sub New()
            InitializeComponent()
        End Sub

    Private Sub buttonJoin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonJoin.Click
        Dim name = textBoxName.Text

        If Equals(name, "") Then
            errorProvider.SetError(textBoxName, "Please enter your name.")
        Else
            AddHandler IncomingMessage, AddressOf SimpleChatServer_IncomingMessage

            Try
                Join(name)
                joined = True
                UpdateUIState()
                textBoxMessage.Focus()
                errorProvider.SetError(textBoxName, Nothing)

                ' when joining from a browser that doesn't support WebSocket, enable the update timer.
                If Not Application.IsWebSocket Then updateTimer.Start()
            Catch
                RemoveHandler IncomingMessage, AddressOf SimpleChatServer_IncomingMessage
                Throw
            End Try
        End If
    End Sub

    Private Sub SimpleChatServer_IncomingMessage(ByVal e As SimpleChatServerEventArgs)
        ' important to run in context and push the update since the
        ' message may come in from a different thread.
        Application.Update(Me, Sub()
                                   Dim index As Integer = listBoxMessage.Items.Add($"{e.TimeStamp}: {e.From} => {e.Message}")


                                   ' remove the top message, after reaching 100.
                                   If index >= 100 Then
                                       listBoxMessage.Items.RemoveAt(0)
                                   End If

                                   listBoxMessage.SelectedIndex = index
                               End Sub)
    End Sub

    Private Sub buttonLeave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonLeave.Click
        Dim name = textBoxName.Text
        SimpleChatServer.Leave(name)
        RemoveHandler IncomingMessage, AddressOf SimpleChatServer_IncomingMessage
        joined = False
        UpdateUIState()

        ' when leaving from a browser that doesn't support WebSocket, stop the update timer.
        If updateTimer.Enabled Then updateTimer.Stop()
    End Sub

    Private Sub buttonSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSend.Click
        Dim text = textBoxMessage.Text

        If Equals(text, "") Then
            errorProvider.SetError(textBoxMessage, "Please enter a message.")
        Else
            textBoxMessage.Text = ""
            Dim name = textBoxName.Text
            SendMessage(name, text)
            errorProvider.SetError(textBoxMessage, Nothing)
        End If
    End Sub

    Private Sub textBoxMessage_ToolClick(ByVal sender As Object, ByVal e As ToolClickEventArgs) Handles textBoxMessage.ToolClick
        If Equals(e.Tool.Name, "Clear") Then textBoxMessage.Text = ""
    End Sub

    Private Sub listBoxMessage_ToolClick(ByVal sender As Object, ByVal e As ToolClickEventArgs) Handles listBoxMessage.ToolClick
        Select Case e.Tool.Name
            Case "Clear"
                listBoxMessage.Items.Clear()
            Case "Save"

                If listBoxMessage.Items.Count > 0 Then
                    SaveMessages()
                Else
                    MessageBox.Show("The list is empty, there is nothing to save.", icon:=MessageBoxIcon.Information, modal:=False)
                End If
        End Select
    End Sub

    Private Sub UpdateUIState()
            buttonJoin.Enabled = Not joined
            buttonLeave.Enabled = joined
            buttonSend.Enabled = joined
            textBoxName.Enabled = Not joined
            textBoxMessage.Enabled = joined
        End Sub

        Private Sub SaveMessages()
            Dim stream As MemoryStream = New MemoryStream()
            Dim writer As StreamWriter = New StreamWriter(stream)

            For Each item In listBoxMessage.Items
                writer.WriteLine(item.ToString())
            Next

            Application.Download(stream, "ChatLog.txt")
        End Sub

        Private Sub SimpleChatClient_Load(ByVal sender As Object, ByVal e As EventArgs)
            UpdateUIState()
            textBoxName.Focus()
        End Sub

        Private Sub SimpleChatClient_Accelerator(ByVal sender As Object, ByVal e As AcceleratorEventArgs)
            If textBoxName.Focused Then
                buttonJoin.PerformClick()
            ElseIf textBoxMessage.Focused Then
                buttonSend.PerformClick()
            End If
        End Sub

        Private Sub updateTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            ' do nothing, Wisej will update everything that was pending.
        End Sub
    End Class
