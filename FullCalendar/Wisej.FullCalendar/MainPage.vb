Imports System
Imports System.Drawing
Imports Wisej.Web
Imports Wisej.Web.Ext.FullCalendar

Partial Public Class MainPage
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MainPage_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        fullCalendar1.CurrentDate = Date.Now.Date
        fullCalendar1.View = ViewType.AgendaWeek
        fullCalendar1.Events.Add(New [Event]() With {
            .Id = "Event1",
            .Start = Date.Now,
            .[End] = Date.Now.AddHours(1),
            .Title = "Try Wisej!",
            .ClassName = "Other"
        })
        fullCalendar1.Events.Add(New [Event]() With {
            .Id = "Event2",
            .Start = Date.Now.Date.AddHours(12),
            .[End] = Date.Now.Date.AddHours(13),
            .Title = "Lunch",
            .ClassName = "Appointment"
        })
        fullCalendar1.Events.Add(New [Event]() With {
            .Id = "Event3",
            .Start = Date.Now.Date.AddDays(-1).AddHours(10.5),
            .[End] = Date.Now.Date.AddDays(-1).AddHours(11.75),
            .Title = "Meeting",
            .ClassName = "Meeting"
        })
        fullCalendar1.Events.Add(New [Event]() With {
            .Id = "Event4",
            .Start = Date.Now.Date.AddDays(2),
            .[End] = Date.Now.Date.AddDays(4),
            .AllDay = True,
            .Title = "Holidays :-)",
            .ClassName = "Vacation"
        })
    End Sub

    Private Sub monthCalendar1_DateSelected(ByVal sender As Object, ByVal e As DateRangeEventArgs) Handles monthCalendar1.DateSelected
        fullCalendar1.CurrentDate = e.Start
    End Sub

    Private Sub toolBar1_ButtonClick(ByVal sender As Object, ByVal e As ToolBarButtonClickEventArgs) Handles toolBar1.ButtonClick
        If e.Button Is tbNew Then
            ' create an empty event
            Dim ev As [Event] = New [Event]()
            ev.Start = Date.Now
            ev.End = Date.Now.AddHours(0.5)


            ' show the editor
            Using editor As Wisej.FullCalendar.EventEditor = New Wisej.FullCalendar.EventEditor()
                editor.eventEntry = ev
                If editor.ShowDialog(FindForm()) = DialogResult.OK Then fullCalendar1.Events.Add(ev)
            End Using

            Return
        End If

        If e.Button.Tag IsNot Nothing Then

            For Each button As ToolBarButton In toolBar1.Buttons
                button.Pushed = False
            Next

            e.Button.Pushed = True

            ' change the calendar view
            Dim calendarView As ViewType
            If [Enum].TryParse(e.Button.Tag.ToString(), calendarView) Then fullCalendar1.View = calendarView
        End If
    End Sub

    Private Sub fullCalendar1_EventDoubleClick(ByVal sender As Object, ByVal e As EventClickEventArgs) Handles fullCalendar1.EventDoubleClick
        ' edit the event
        Using editor As Wisej.FullCalendar.EventEditor = New Wisej.FullCalendar.EventEditor()
            editor.eventEntry = e.Event
            editor.ShowDialog(FindForm())
        End Using
    End Sub

End Class
