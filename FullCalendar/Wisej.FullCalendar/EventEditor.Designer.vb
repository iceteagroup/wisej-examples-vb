Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EventEditor
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
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


#Region "Wisej Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EventEditor))
        Me.buttonOK = New Wisej.Web.Button()
        Me.buttonClose = New Wisej.Web.Button()
        Me.label4 = New Wisej.Web.Label()
        Me.label3 = New Wisej.Web.Label()
        Me.label2 = New Wisej.Web.Label()
        Me.label1 = New Wisej.Web.Label()
        Me.eventID = New Wisej.Web.TextBox()
        Me.eventStart = New Wisej.Web.DateTimePicker()
        Me.eventEnd = New Wisej.Web.DateTimePicker()
        Me.eventText = New Wisej.Web.TextBox()
        Me.eventType = New Wisej.Web.ComboBox()
        Me.label5 = New Wisej.Web.Label()
        Me.styleSheet1 = New Wisej.Web.StyleSheet(Me.components)
        Me.SuspendLayout()
        '
        'buttonOK
        '
        Me.buttonOK.Anchor = CType((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.buttonOK.DialogResult = Wisej.Web.DialogResult.OK
        Me.buttonOK.Location = New System.Drawing.Point(133, 379)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(129, 36)
        Me.buttonOK.TabIndex = 10
        Me.buttonOK.Text = "OK"
        '
        'buttonClose
        '
        Me.buttonClose.Anchor = CType((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.buttonClose.DialogResult = Wisej.Web.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(268, 379)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(129, 36)
        Me.buttonClose.TabIndex = 11
        Me.buttonClose.Text = "Close"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(25, 226)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(29, 15)
        Me.label4.TabIndex = 8
        Me.label4.Text = "Text"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(25, 133)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(27, 15)
        Me.label3.TabIndex = 4
        Me.label3.Text = "End"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(25, 83)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(31, 15)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Start"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(25, 33)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(17, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "ID"
        '
        'eventID
        '
        Me.eventID.AutoSize = False
        Me.eventID.InvalidMessage = "Please enter a unique ID."
        Me.eventID.Location = New System.Drawing.Point(80, 26)
        Me.eventID.Name = "eventID"
        Me.eventID.Size = New System.Drawing.Size(100, 30)
        Me.eventID.TabIndex = 1
        '
        'eventStart
        '
        Me.eventStart.AutoSize = False
        Me.eventStart.Checked = False
        Me.eventStart.Format = Wisej.Web.DateTimePickerFormat.DateTime
        Me.eventStart.Location = New System.Drawing.Point(80, 76)
        Me.eventStart.Name = "eventStart"
        Me.eventStart.Size = New System.Drawing.Size(200, 30)
        Me.eventStart.TabIndex = 3
        Me.eventStart.Value = New Date(2017, 2, 8, 16, 20, 0, 0)
        '
        'eventEnd
        '
        Me.eventEnd.AutoSize = False
        Me.eventEnd.Checked = False
        Me.eventEnd.Format = Wisej.Web.DateTimePickerFormat.DateTime
        Me.eventEnd.Location = New System.Drawing.Point(80, 126)
        Me.eventEnd.Name = "eventEnd"
        Me.eventEnd.Size = New System.Drawing.Size(200, 30)
        Me.eventEnd.TabIndex = 5
        Me.eventEnd.Value = New Date(2017, 2, 8, 16, 21, 0, 0)
        '
        'eventText
        '
        Me.eventText.AutoSize = False
        Me.eventText.Location = New System.Drawing.Point(80, 226)
        Me.eventText.Multiline = True
        Me.eventText.Name = "eventText"
        Me.eventText.Size = New System.Drawing.Size(315, 125)
        Me.eventText.TabIndex = 9
        '
        'eventType
        '
        Me.eventType.AllowHtml = True
        Me.eventType.AutoSize = False
        Me.eventType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.eventType.Location = New System.Drawing.Point(80, 176)
        Me.eventType.Name = "eventType"
        Me.eventType.Size = New System.Drawing.Size(200, 30)
        Me.eventType.TabIndex = 7
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(25, 183)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(33, 15)
        Me.label5.TabIndex = 6
        Me.label5.Text = "Type"
        '
        'styleSheet1
        '
        Me.styleSheet1.Styles = resources.GetString("styleSheet1.Styles")
        '
        'EventEditor
        '
        Me.AcceptButton = Me.buttonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.AutoValidate = Wisej.Web.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.buttonClose
        Me.ClientSize = New System.Drawing.Size(411, 430)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.eventType)
        Me.Controls.Add(Me.eventText)
        Me.Controls.Add(Me.eventEnd)
        Me.Controls.Add(Me.eventStart)
        Me.Controls.Add(Me.eventID)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.buttonOK)
        Me.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EventEditor"
        Me.StartPosition = Wisej.Web.FormStartPosition.CenterParent
        Me.Text = "Edit Event"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


#End Region

    Friend WithEvents buttonOK As Web.Button
    Friend WithEvents buttonClose As Web.Button
    Friend WithEvents label4 As Web.Label
    Friend WithEvents label3 As Web.Label
    Friend WithEvents label2 As Web.Label
    Friend WithEvents label1 As Web.Label
    Friend WithEvents eventID As Web.TextBox
    Friend WithEvents eventStart As Web.DateTimePicker
    Friend WithEvents eventEnd As Web.DateTimePicker
    Friend WithEvents eventText As Web.TextBox
    Friend WithEvents eventType As Web.ComboBox
    Friend WithEvents label5 As Web.Label
    Friend WithEvents styleSheet1 As Web.StyleSheet
End Class
