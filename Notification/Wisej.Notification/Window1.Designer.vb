<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Window1
    Inherits Wisej.Web.Form

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

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.btnSimpleNotification = New Wisej.Web.Button()
        Me.GroupBox2 = New Wisej.Web.GroupBox()
        Me.GroupBox3 = New Wisej.Web.GroupBox()
        Me.btnNotificationAfterTask = New Wisej.Web.Button()
        Me.btnStartThread = New Wisej.Web.Button()
        Me.btnStopThread = New Wisej.Web.Button()
        Me.pgBar = New Wisej.Web.ProgressBar()
        Me.label2 = New Wisej.Web.Label()
        Me.label1 = New Wisej.Web.Label()
        Me.linkNotificationDetailGithub = New Wisej.Web.LinkLabel()
        Me.linkBrowserCompatibility = New Wisej.Web.LinkLabel()
        Me.notificationObj = New Wisej.Web.Ext.Notification.Notification(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSimpleNotification)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.Text = "Simple Click Notification"
        '
        'btnSimpleNotification
        '
        Me.btnSimpleNotification.Location = New System.Drawing.Point(7, 48)
        Me.btnSimpleNotification.Name = "btnSimpleNotification"
        Me.btnSimpleNotification.Size = New System.Drawing.Size(208, 27)
        Me.btnSimpleNotification.TabIndex = 0
        Me.btnSimpleNotification.Text = "Show Notification"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pgBar)
        Me.GroupBox2.Controls.Add(Me.btnNotificationAfterTask)
        Me.GroupBox2.Location = New System.Drawing.Point(292, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 118)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.Text = "Notification after task"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnStopThread)
        Me.GroupBox3.Controls.Add(Me.btnStartThread)
        Me.GroupBox3.Location = New System.Drawing.Point(560, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 118)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.Text = "Notification with thread"
        '
        'btnNotificationAfterTask
        '
        Me.btnNotificationAfterTask.Location = New System.Drawing.Point(10, 48)
        Me.btnNotificationAfterTask.Name = "btnNotificationAfterTask"
        Me.btnNotificationAfterTask.Size = New System.Drawing.Size(208, 27)
        Me.btnNotificationAfterTask.TabIndex = 1
        Me.btnNotificationAfterTask.Text = "Notification after task"
        '
        'btnStartThread
        '
        Me.btnStartThread.Location = New System.Drawing.Point(13, 48)
        Me.btnStartThread.Name = "btnStartThread"
        Me.btnStartThread.Size = New System.Drawing.Size(191, 27)
        Me.btnStartThread.TabIndex = 2
        Me.btnStartThread.Text = "Start with thread"
        '
        'btnStopThread
        '
        Me.btnStopThread.Location = New System.Drawing.Point(214, 48)
        Me.btnStopThread.Name = "btnStopThread"
        Me.btnStopThread.Size = New System.Drawing.Size(191, 27)
        Me.btnStopThread.TabIndex = 3
        Me.btnStopThread.Text = "Stop diffusion"
        '
        'pgBar
        '
        Me.pgBar.Location = New System.Drawing.Point(10, 85)
        Me.pgBar.Name = "pgBar"
        Me.pgBar.Size = New System.Drawing.Size(208, 24)
        Me.pgBar.TabIndex = 2
        Me.pgBar.Text = "0%"
        Me.pgBar.Value = 10
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(32, 219)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(264, 16)
        Me.label2.TabIndex = 11
        Me.label2.Text = "More details of Wisej.Web.Ext.Notification"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(32, 181)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(172, 16)
        Me.label1.TabIndex = 10
        Me.label1.Text = "More details for notification"
        '
        'linkNotificationDetailGithub
        '
        Me.linkNotificationDetailGithub.AutoSize = True
        Me.linkNotificationDetailGithub.Location = New System.Drawing.Point(302, 219)
        Me.linkNotificationDetailGithub.Name = "linkNotificationDetailGithub"
        Me.linkNotificationDetailGithub.Size = New System.Drawing.Size(39, 16)
        Me.linkNotificationDetailGithub.TabIndex = 13
        Me.linkNotificationDetailGithub.Text = "go to."
        '
        'linkBrowserCompatibility
        '
        Me.linkBrowserCompatibility.AutoSize = True
        Me.linkBrowserCompatibility.Location = New System.Drawing.Point(215, 181)
        Me.linkBrowserCompatibility.Name = "linkBrowserCompatibility"
        Me.linkBrowserCompatibility.Size = New System.Drawing.Size(39, 16)
        Me.linkBrowserCompatibility.TabIndex = 12
        Me.linkBrowserCompatibility.Text = "go to."
        '
        'Window1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 268)
        Me.Controls.Add(Me.linkNotificationDetailGithub)
        Me.Controls.Add(Me.linkBrowserCompatibility)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Window1"
        Me.Text = "Wisej Notification Sample VB"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSimpleNotification As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pgBar As ProgressBar
    Friend WithEvents btnNotificationAfterTask As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnStopThread As Button
    Friend WithEvents btnStartThread As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents linkNotificationDetailGithub As LinkLabel
    Private WithEvents linkBrowserCompatibility As LinkLabel
    Friend WithEvents notificationObj As Ext.Notification.Notification
End Class
