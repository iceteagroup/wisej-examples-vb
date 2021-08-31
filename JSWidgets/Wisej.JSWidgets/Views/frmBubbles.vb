Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports Wisej.Web
Imports Wisej.Web.Ext
Imports Wisej.JSWidgets

Public Class frmBubbles

    Private _maxTags As Integer = 4
    Private _click As Integer = 0
    Private Property CurrentUser As Models.User
    Private ReadOnly _notification As Ext.Notification.Notification
    Private _comboBoxData As List(Of Object)

    Public Sub New()
        InitializeComponent()
        _notification = New Ext.Notification.Notification()
        _comboBoxData = New List(Of Object)()
        lvMsgs.DataSource = AppData.Messages
        AddHandler AppData.RaiseNewMessage, AddressOf AppData_RaiseNewMessage
        bubble.SetBubbleStyle(lblCurrentUser, Ext.Bubbles.BubbleStyle.Alert)
        IniliazizeComboBox()
    End Sub

    Private Sub IniliazizeComboBox()
        For i = 1 To 10
            _comboBoxData.Add(New With {
                .Id = i,
                .Item = $"Item - {i}"
            })
        Next

        cbx.ValueMember = "Id"
        cbx.DisplayMember = "Item"
        cbx.DataSource = _comboBoxData
    End Sub

    Private Sub btnConfirmUsername_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirmUsername.Click
        Try
            If String.IsNullOrEmpty(txtbxUsername.Text) OrElse String.IsNullOrWhiteSpace(txtbxUsername.Text) Then Throw New Exception("Username is required")
            Call Application.RunInContext(Me, Sub()
                                                  CurrentUser = New Models.User With {
                                                      .SessionId = Application.SessionId,
                                                      .Username = txtbxUsername.Text
                                                  }
                                                  AppData.AddUser(CurrentUser)
                                                  lblCurrentUser.Text = CurrentUser.Username
                                              End Sub)
            txtbxUsername.Enabled = False
            btnConfirmUsername.Enabled = False
            txtbxMessage.Enabled = True
            btnSendMessage.Enabled = True
        Catch ex As Exception
            AlertBox.Show(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmBubbles_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        bubble.SetBubbleValue(tagtxtbx, _maxTags)
    End Sub

    Private Sub btnSendMessage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSendMessage.Click
        Try
            If String.IsNullOrEmpty(txtbxMessage.Text) OrElse String.IsNullOrWhiteSpace(txtbxMessage.Text) Then Throw New Exception("Message must have a value")
            Call AppData.AddMessage(New Models.Message With {
                .Content = txtbxMessage.Text,
                .Date = Date.Now,
                .Id = Guid.NewGuid().ToString(),
                .Sender = CurrentUser
            })
        Catch ex As Exception
            AlertBox.Show(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AppData_RaiseNewMessage(ByVal sender As Object, ByVal e As Models.MessageEventArgs)
        If Not Equals(CurrentUser.SessionId, CType(sender, Models.User).SessionId) Then
            Application.Update(Me, Sub()
                                       Dim bubbleValue = bubble.GetBubbleValue(lblCurrentUser)

                                       If bubbleValue = 0 Then
                                           bubble.SetBubbleValue(lblCurrentUser, 1)
                                       Else
                                           bubble.SetBubbleValue(lblCurrentUser, bubbleValue + 1)
                                       End If

                                       _notification.Show("New message", "New message from " & CType(sender, Models.User).Username)
                                   End Sub)
        End If
    End Sub

    Private Sub tagtxtbx_TagAdded(ByVal sender As Object, ByVal e As TagTextBoxEventArgs)
        If _maxTags <= 1 Then
            Dim lists = tagtxtbx.Text.Split(","c).ToList()
            lists.Remove(e.Text)
            tagtxtbx.Text = String.Join(",", lists)
            AlertBox.Show("Max tag is arrived", MessageBoxIcon.Hand, True)
            Application.Update(Me)
            Return
        Else
            _maxTags -= 1
            bubble.SetBubbleValue(tagtxtbx, _maxTags)
        End If

        Application.Update(Me)
    End Sub

    Private Sub cbx_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbx.SelectedIndexChanged
        bubble.SetBubbleValue(cbx, Convert.ToInt32(cbx.SelectedIndex) + 1)
    End Sub

    Private Sub numUpDwn_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numUpDwn.ValueChanged
        bubble.SetBubbleValue(numUpDwn, Convert.ToInt32(numUpDwn.Value))
    End Sub

    Private Sub txtbx_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbx.TextChanged
        bubble.SetBubbleValue(txtbx, txtbx.Text.Length)
    End Sub

    Private Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn.Click
        _click += 1
        bubble.SetBubbleValue(btn, _click)
    End Sub
End Class
