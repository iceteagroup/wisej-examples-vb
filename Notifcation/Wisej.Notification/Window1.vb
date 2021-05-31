Imports System
Imports System.Threading
Imports Wisej.Web

Public Class Window1
    Private _customThread As Thread
    Private _isRuning As Boolean

    Public Sub New()


        InitializeComponent()
        btnStopThread.Enabled = False
        _customThread = New Thread(AddressOf ExecuteCustomThread)


    End Sub

    Private Async Sub ExecuteCustomThread()
        While True
            If _isRuning Then
                Await Tasks.Task.Delay(1500)
                Application.Update(Me,
                               Sub()
                                   notificationObj.Show("Notification", "Notification with custom thread")
                               End Sub)
            End If
        End While
    End Sub

    Private Sub linkBrowserCompatibility_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkBrowserCompatibility.LinkClicked
        Application.Navigate("https://support.google.com/chrome/answer/3220216?co=GENIE.Platform%3DDesktop&hl=en", "_blank")
    End Sub

    Private Sub linkNotificationDetailGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkNotificationDetailGithub.LinkClicked
        Application.Navigate("https://github.com/iceteagroup/wisej-extensions/tree/2.2/Wisej.Web.Ext.Notification", "_blank")
    End Sub

    Private Sub btnSimpleNotification_Click(sender As Object, e As EventArgs) Handles btnSimpleNotification.Click
        If Wisej.Web.Ext.Notification.Notification.IsSupported Then
            notificationObj.Show("Notification", "Direct notification")
        Else
            AlertBox.Show("Notification is not supported on this browser")
        End If
    End Sub

    Private Async Sub btnNotificationAfterTask_Click(sender As Object, e As EventArgs) Handles btnNotificationAfterTask.Click
        If Wisej.Web.Ext.Notification.Notification.IsSupported.Equals(False) Then
            AlertBox.Show("Notification is not supported on this browser")
            Exit Sub
        Else
            Await Application.StartTask(Async Sub()

                                            btnNotificationAfterTask.Enabled = False
                                            Await LoadProgressBar()
                                            btnNotificationAfterTask.Enabled = True

                                            Application.Update(Me,
                                                               Sub()
                                                                   notificationObj.Show("Notification", "Notification after executing task")
                                                               End Sub)
                                        End Sub)

        End If
    End Sub

    Private Async Function LoadProgressBar() As System.Threading.Tasks.Task
        Dim progressVal As Integer = 0
        pgBar.Value = progressVal

        While True
            If progressVal > 100 Then
                Exit While
            End If
            pgBar.Text = progressVal.ToString() + "%"
            pgBar.Value = progressVal

            progressVal += 10

            Await Tasks.Task.Delay(900)

            Application.Update(Me)
        End While
    End Function

    Private Sub btnStartThread_Click(sender As Object, e As EventArgs) Handles btnStartThread.Click
        If Wisej.Web.Ext.Notification.Notification.IsSupported.Equals(False) Then
            AlertBox.Show("Notification is not supported on this browser")
            Exit Sub
        Else
            btnStartThread.Enabled = False
            btnStopThread.Enabled = True

            _isRuning = True
            If _customThread.ThreadState.Equals(ThreadState.Unstarted) Then
                _customThread.Start()
            End If
        End If
    End Sub

    Private Sub btnStopThread_Click(sender As Object, e As EventArgs) Handles btnStopThread.Click
        _isRuning = False
        btnStartThread.Enabled = True
        btnStopThread.Enabled = False
    End Sub
End Class
