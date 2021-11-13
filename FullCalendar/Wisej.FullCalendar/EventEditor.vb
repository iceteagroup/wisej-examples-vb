Imports System
Imports System.Collections.Generic
Imports Wisej.Web

Partial Public Class EventEditor


    Public eventEntry As Web.Ext.FullCalendar.Event

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub buttonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOK.Click
        eventEntry.Id = eventID.Text

        If String.IsNullOrEmpty(eventEntry.Id) Then
            eventID.Invalid = True
            eventID.Focus()
            Return
        End If

        eventEntry.Start = eventStart.Value
        eventEntry.End = eventEnd.Value
        eventEntry.Title = eventText.Text
        If eventType.SelectedIndex > -1 Then eventEntry.ClassName = EventTypes(eventType.SelectedIndex)
        Close()
    End Sub

    Private Sub buttonClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

    Private Sub EventEditor_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        eventID.Text = eventEntry.Id
        eventStart.Value = eventEntry.Start
        eventEnd.Value = eventEntry.End
        eventText.Text = eventEntry.Title
        LoadEventTypes()
        Dim className = eventEntry.ClassName
        eventType.SelectedIndex = Array.IndexOf(EventTypes, className)
    End Sub

    Private Sub LoadEventTypes()

        For Each auxText In EventTypes
            eventType.Items.Add(String.Format("<div class=""event-item"" style=""height:28px""><div class=""event-item-color event-item-color-{0}""></div><div class=""event-item-text"">{0}</div>", auxText))
        Next

    End Sub

    Private Sub eventID_Validating(ByVal sender As Object, ByVal e As ComponentModel.CancelEventArgs)
        If Equals(eventID.Text, "") Then e.Cancel = True
    End Sub

    Private Shared EventTypes As String() = {"Appointment", "Meeting", "Vacation", "Other"}
End Class
