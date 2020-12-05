Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDataDialog
    Inherits Form
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer


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


#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.columnProperty = New Wisej.Web.DataGridViewColumn()
        Me.columnValue = New Wisej.Web.DataGridViewColumn()
        Me.label1 = New Wisej.Web.Label()
        Me.label2 = New Wisej.Web.Label()
        Me.label3 = New Wisej.Web.Label()
        Me.label4 = New Wisej.Web.Label()
        Me.label5 = New Wisej.Web.Label()
        Me.textBoxName = New Wisej.Web.TextBox()
        Me.textBoxLastName = New Wisej.Web.TextBox()
        Me.comboBoxRole = New Wisej.Web.ComboBox()
        Me.dateTimePickerActivation = New Wisej.Web.DateTimePicker()
        Me.dateTimePickerExpiration = New Wisej.Web.DateTimePicker()
        Me.buttonCancel = New Wisej.Web.Button()
        Me.buttonOK = New Wisej.Web.Button()
        Me.helpTip = New Wisej.Web.HelpTip(Me.components)
        Me.SuspendLayout()
        '
        'columnProperty
        '
        Me.columnProperty.HeaderText = "Property"
        Me.columnProperty.Name = "columnProperty"
        Me.columnProperty.Width = 200
        '
        'columnValue
        '
        Me.columnValue.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        Me.columnValue.HeaderText = "Value"
        Me.columnValue.Name = "columnValue"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(36, 43)
        Me.label1.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(91, 29)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Name"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(36, 95)
        Me.label2.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(153, 29)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Last Name"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(36, 145)
        Me.label3.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(73, 29)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Role"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(36, 196)
        Me.label4.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(209, 29)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Activation Date"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(36, 246)
        Me.label5.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(211, 29)
        Me.label5.TabIndex = 8
        Me.label5.Text = "Expiration Date"
        '
        'textBoxName
        '
        Me.helpTip.SetHelpTip(Me.textBoxName, "Enter the user's first name.")
        Me.textBoxName.Location = New System.Drawing.Point(317, 41)
        Me.textBoxName.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.textBoxName.Name = "textBoxName"
        Me.textBoxName.Size = New System.Drawing.Size(437, 27)
        Me.textBoxName.TabIndex = 1
        Me.textBoxName.Watermark = "Enter the name"
        '
        'textBoxLastName
        '
        Me.helpTip.SetHelpTip(Me.textBoxLastName, "Enter the user's last name.")
        Me.textBoxLastName.Location = New System.Drawing.Point(317, 92)
        Me.textBoxLastName.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.textBoxLastName.Name = "textBoxLastName"
        Me.textBoxLastName.Size = New System.Drawing.Size(437, 27)
        Me.textBoxLastName.TabIndex = 3
        Me.textBoxLastName.Watermark = "Enter the last name"
        '
        'comboBoxRole
        '
        Me.comboBoxRole.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.comboBoxRole.FormattingEnabled = True
        Me.helpTip.SetHelpTip(Me.comboBoxRole, "Select the user's role from the list.")
        Me.comboBoxRole.Location = New System.Drawing.Point(317, 142)
        Me.comboBoxRole.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.comboBoxRole.Name = "comboBoxRole"
        Me.comboBoxRole.Size = New System.Drawing.Size(437, 27)
        Me.comboBoxRole.TabIndex = 5
        Me.comboBoxRole.Watermark = "Select a role"
        '
        'dateTimePickerActivation
        '
        Me.dateTimePickerActivation.Checked = False
        Me.helpTip.SetHelpTip(Me.dateTimePickerActivation, "Select the date the user's account was first activated.")
        Me.dateTimePickerActivation.Location = New System.Drawing.Point(317, 189)
        Me.dateTimePickerActivation.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.dateTimePickerActivation.Name = "dateTimePickerActivation"
        Me.dateTimePickerActivation.Size = New System.Drawing.Size(437, 27)
        Me.dateTimePickerActivation.TabIndex = 7
        Me.dateTimePickerActivation.Value = New Date(2016, 4, 28, 13, 0, 0, 0)
        '
        'dateTimePickerExpiration
        '
        Me.dateTimePickerExpiration.Checked = False
        Me.helpTip.SetHelpTip(Me.dateTimePickerExpiration, "Select the date the user's account will automatically expire and get deactivated." &
        "")
        Me.dateTimePickerExpiration.InvalidMessage = "The expiration date is invalid. It should be higher than the Activation Date." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.dateTimePickerExpiration.Location = New System.Drawing.Point(317, 241)
        Me.dateTimePickerExpiration.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.dateTimePickerExpiration.Name = "dateTimePickerExpiration"
        Me.dateTimePickerExpiration.Size = New System.Drawing.Size(437, 27)
        Me.dateTimePickerExpiration.TabIndex = 9
        Me.dateTimePickerExpiration.Value = New Date(2016, 4, 28, 13, 0, 0, 0)
        '
        'buttonCancel
        '
        Me.buttonCancel.AppearanceKey = "button-cancel"
        Me.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel
        Me.helpTip.SetHelpTip(Me.buttonCancel, "Click me to cancel.")
        Me.buttonCancel.Location = New System.Drawing.Point(355, 332)
        Me.buttonCancel.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(173, 51)
        Me.buttonCancel.TabIndex = 10
        Me.buttonCancel.Text = "Cancel"
        '
        'buttonOK
        '
        Me.buttonOK.AppearanceKey = "button-ok"
        Me.buttonOK.DialogResult = Wisej.Web.DialogResult.OK
        Me.helpTip.SetHelpTip(Me.buttonOK, "Click me to confirm.")
        Me.buttonOK.Location = New System.Drawing.Point(579, 329)
        Me.buttonOK.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(179, 53)
        Me.buttonOK.TabIndex = 11
        Me.buttonOK.Text = "&OK"
        '
        'UserDataDialog
        '
        Me.AcceptButton = Me.buttonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 26.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(816, 436)
        Me.Controls.Add(Me.buttonOK)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.dateTimePickerExpiration)
        Me.Controls.Add(Me.dateTimePickerActivation)
        Me.Controls.Add(Me.comboBoxRole)
        Me.Controls.Add(Me.textBoxLastName)
        Me.Controls.Add(Me.textBoxName)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Helvetica", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed
        Me.Margin = New Wisej.Web.Padding(9, 0, 9, 0)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserDataDialog"
        Me.StartPosition = Wisej.Web.FormStartPosition.CenterScreen
        Me.Text = "User Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


#End Region

    Friend WithEvents columnProperty As Wisej.Web.DataGridViewColumn
    Friend WithEvents columnValue As Wisej.Web.DataGridViewColumn
    Friend WithEvents label1 As Wisej.Web.Label
    Friend WithEvents label2 As Wisej.Web.Label
    Friend WithEvents label3 As Wisej.Web.Label
    Friend WithEvents label4 As Wisej.Web.Label
    Friend WithEvents label5 As Wisej.Web.Label
    Friend WithEvents textBoxName As Wisej.Web.TextBox
    Friend WithEvents textBoxLastName As Wisej.Web.TextBox
    Friend WithEvents comboBoxRole As Wisej.Web.ComboBox
    Friend WithEvents dateTimePickerActivation As Wisej.Web.DateTimePicker
    Friend WithEvents dateTimePickerExpiration As Wisej.Web.DateTimePicker
    Friend WithEvents buttonCancel As Wisej.Web.Button
    Friend WithEvents buttonOK As Wisej.Web.Button
    Friend WithEvents helpTip As Wisej.Web.HelpTip
End Class
