
Imports System
Imports System.Threading
Imports System.Threading.Tasks
Imports Wisej.Web

Partial Public Class Window1
    Private _customThread As Thread
    Private isRunning As Boolean
    Public Sub New()
        InitializeComponent()
        btnStopThread.Enabled = False
        _customThread = New Thread(AddressOf ExcuteCustomThread)
    End Sub

    Private Async Sub ExcuteCustomThread()
        While True
            If isRunning Then
                Await Task.Delay(1500)
                notificationObj.Show("title", "With another thread")
                Application.Update(Me)
            End If

        End While
    End Sub

    Private Async Function LoadProgessBar() As Task

        Dim progressVal = 0
        pgBar.Value = progressVal
        While True
            If progressVal > 100 Then Exit While
            pgBar.Text = progressVal.ToString() & "%"
            pgBar.Value = progressVal
            progressVal += 10

            Await Task.Delay(900)
            Application.Update(Me)
        End While
    End Function

    Private Sub btnSimpleNotification_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSimpleNotification.Click
        If Ext.Notification.Notification.IsSupported Then
            notificationObj.Show("Notification", "Direct notification")
        Else
            AlertBox.Show("Notification is not supported on this Browser")
        End If
    End Sub

    Private Async Sub btnNotificationAfterTask_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNotificationAfterTask.Click
        If Not Ext.Notification.Notification.IsSupported Then
            AlertBox.Show("Notification is not supported on this Browser")
            Return
        End If
        Await Application.StartTask(Async Function()
                                        btnNotificationAfterTask.Enabled = False
                                        Await LoadProgessBar()
                                        btnNotificationAfterTask.Enabled = True
                                        Application.Update(Me)
                                        notificationObj.Show("Notification", "Notification after executing task")
                                        Application.Update(Me)
                                    End Function)
    End Sub

    Private Sub btnStartThread_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStartThread.Click
        If Not Ext.Notification.Notification.IsSupported Then
            AlertBox.Show("Notification is not supported on this Browser")
            Return
        End If
        btnStartThread.Enabled = False
        btnStopThread.Enabled = True
        isRunning = True
        If _customThread.ThreadState = ThreadState.Unstarted Then _customThread.Start()
    End Sub

    Private Sub btnStopThread_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStopThread.Click
        isRunning = False
        btnStartThread.Enabled = True
        btnStopThread.Enabled = False
    End Sub

    Private Sub linkBrowserCompatibility_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkBrowserCompatibility.LinkClicked
        Application.Navigate("https://support.google.com/chrome/answer/3220216?co=GENIE.Platform%3DDesktop&hl=en", "_blank")
    End Sub

    Private Sub linkNotificationDetailGithub_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkNotificationDetailGithub.LinkClicked
        Application.Navigate("https://github.com/iceteagroup/wisej-extensions/tree/2.2/Wisej.Web.Ext.Notification", "_blank")
    End Sub
End Class
