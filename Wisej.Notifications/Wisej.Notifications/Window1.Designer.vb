<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window1
    Inherits Wisej.Web.Form
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.notificationObj = New Wisej.Web.Ext.Notification.Notification(Me.components)
        Me.btnSimpleNotification = New Wisej.Web.Button()
        Me.btnNotificationAfterTask = New Wisej.Web.Button()
        Me.pgBar = New Wisej.Web.ProgressBar()
        Me.btnStartThread = New Wisej.Web.Button()
        Me.btnStopThread = New Wisej.Web.Button()
        Me.groupBox1 = New Wisej.Web.GroupBox()
        Me.groupBox2 = New Wisej.Web.GroupBox()
        Me.groupBox3 = New Wisej.Web.GroupBox()
        Me.label1 = New Wisej.Web.Label()
        Me.label2 = New Wisej.Web.Label()
        Me.linkBrowserCompatibility = New Wisej.Web.LinkLabel()
        Me.linkNotificationDetailGithub = New Wisej.Web.LinkLabel()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSimpleNotification
        '
        Me.btnSimpleNotification.Location = New System.Drawing.Point(5, 41)
        Me.btnSimpleNotification.Name = "btnSimpleNotification"
        Me.btnSimpleNotification.Size = New System.Drawing.Size(189, 31)
        Me.btnSimpleNotification.TabIndex = 0
        Me.btnSimpleNotification.Text = "Show Notification"
        '
        'btnNotificationAfterTask
        '
        Me.btnNotificationAfterTask.Location = New System.Drawing.Point(5, 41)
        Me.btnNotificationAfterTask.Name = "btnNotificationAfterTask"
        Me.btnNotificationAfterTask.Size = New System.Drawing.Size(189, 31)
        Me.btnNotificationAfterTask.TabIndex = 2
        Me.btnNotificationAfterTask.Text = "Notification aftter task"
        '
        'pgBar
        '
        Me.pgBar.Location = New System.Drawing.Point(15, 80)
        Me.pgBar.Name = "pgBar"
        Me.pgBar.Size = New System.Drawing.Size(174, 24)
        Me.pgBar.TabIndex = 1
        Me.pgBar.Text = "0%"
        '
        'btnStartThread
        '
        Me.btnStartThread.Location = New System.Drawing.Point(29, 39)
        Me.btnStartThread.Name = "btnStartThread"
        Me.btnStartThread.Size = New System.Drawing.Size(150, 33)
        Me.btnStartThread.TabIndex = 3
        Me.btnStartThread.Text = "Start with thread"
        '
        'btnStopThread
        '
        Me.btnStopThread.BackColor = System.Drawing.Color.FromName("@bubble-alert-background")
        Me.btnStopThread.Location = New System.Drawing.Point(233, 39)
        Me.btnStopThread.Name = "btnStopThread"
        Me.btnStopThread.Size = New System.Drawing.Size(150, 33)
        Me.btnStopThread.TabIndex = 4
        Me.btnStopThread.Text = "Stop diffusion"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnSimpleNotification)
        Me.groupBox1.Location = New System.Drawing.Point(40, 47)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.ShowCheckBox = True
        Me.groupBox1.ShowCloseButton = True
        Me.groupBox1.Size = New System.Drawing.Size(200, 112)
        Me.groupBox1.TabIndex = 5
        Me.groupBox1.Text = "Simple Click Notification"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.btnNotificationAfterTask)
        Me.groupBox2.Controls.Add(Me.pgBar)
        Me.groupBox2.Location = New System.Drawing.Point(287, 47)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.ShowCheckBox = True
        Me.groupBox2.ShowCloseButton = True
        Me.groupBox2.Size = New System.Drawing.Size(200, 112)
        Me.groupBox2.TabIndex = 6
        Me.groupBox2.Text = "Notification after task"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.btnStartThread)
        Me.groupBox3.Controls.Add(Me.btnStopThread)
        Me.groupBox3.Location = New System.Drawing.Point(550, 47)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.ShowCheckBox = True
        Me.groupBox3.ShowCloseButton = True
        Me.groupBox3.Size = New System.Drawing.Size(389, 112)
        Me.groupBox3.TabIndex = 7
        Me.groupBox3.Text = "Notification with thread"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(45, 185)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(160, 15)
        Me.label1.TabIndex = 8
        Me.label1.Text = "More details for notification"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(45, 223)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(246, 15)
        Me.label2.TabIndex = 9
        Me.label2.Text = "More details of Wisej.Web.Ext.Notification"
        '
        'linkBrowserCompatibility
        '
        Me.linkBrowserCompatibility.AutoSize = True
        Me.linkBrowserCompatibility.Location = New System.Drawing.Point(203, 185)
        Me.linkBrowserCompatibility.Name = "linkBrowserCompatibility"
        Me.linkBrowserCompatibility.Size = New System.Drawing.Size(37, 15)
        Me.linkBrowserCompatibility.TabIndex = 10
        Me.linkBrowserCompatibility.Text = "go to."
        '
        'linkNotificationDetailGithub
        '
        Me.linkNotificationDetailGithub.AutoSize = True
        Me.linkNotificationDetailGithub.Location = New System.Drawing.Point(290, 223)
        Me.linkNotificationDetailGithub.Name = "linkNotificationDetailGithub"
        Me.linkNotificationDetailGithub.Size = New System.Drawing.Size(37, 15)
        Me.linkNotificationDetailGithub.TabIndex = 11
        Me.linkNotificationDetailGithub.Text = "go to."
        '
        'Window1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 268)
        Me.Controls.Add(Me.linkNotificationDetailGithub)
        Me.Controls.Add(Me.linkBrowserCompatibility)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Window1"
        Me.Text = "Wisej Notification Sample"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private notificationObj As Web.Ext.Notification.Notification
    Private WithEvents btnSimpleNotification As Web.Button
    Private WithEvents btnNotificationAfterTask As Web.Button
    Private pgBar As Web.ProgressBar
    Private WithEvents btnStartThread As Web.Button
    Private WithEvents btnStopThread As Web.Button
    Private groupBox1 As Web.GroupBox
    Private groupBox2 As Web.GroupBox
    Private groupBox3 As Web.GroupBox
    Private label1 As Web.Label
    Private label2 As Web.Label
    Private WithEvents linkBrowserCompatibility As Web.LinkLabel
    Private WithEvents linkNotificationDetailGithub As Web.LinkLabel
End Class
