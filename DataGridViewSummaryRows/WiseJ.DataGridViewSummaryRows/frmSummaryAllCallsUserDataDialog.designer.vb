<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSummaryAllCallsUserDataDialog
    Inherits Wisej.Web.Form
    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.textBoxTotal = New Wisej.Web.TextBox()
        Me.label6 = New Wisej.Web.Label()
        Me.labelID = New Wisej.Web.Label()
        Me.label7 = New Wisej.Web.Label()
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
        Me.label1.Location = New System.Drawing.Point(36, 97)
        Me.label1.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(91, 30)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Name"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(36, 151)
        Me.label2.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(153, 30)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Last Name"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(36, 201)
        Me.label3.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(73, 30)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Role"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(36, 255)
        Me.label4.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(209, 30)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Activation Date"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(36, 306)
        Me.label5.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(211, 30)
        Me.label5.TabIndex = 8
        Me.label5.Text = "Expiration Date"
        '
        'textBoxName
        '
        Me.helpTip.SetHelpTip(Me.textBoxName, "Enter the user's first name.")
        Me.textBoxName.Location = New System.Drawing.Point(317, 93)
        Me.textBoxName.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.textBoxName.Name = "textBoxName"
        Me.textBoxName.Size = New System.Drawing.Size(437, 27)
        Me.textBoxName.TabIndex = 1
        Me.textBoxName.Watermark = "Enter the name"
        '
        'textBoxLastName
        '
        Me.helpTip.SetHelpTip(Me.textBoxLastName, "Enter the user's last name.")
        Me.textBoxLastName.Location = New System.Drawing.Point(317, 147)
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
        Me.comboBoxRole.Items.AddRange(New Object() {"User", "Editor", "Contributor", "Administrator"})
        Me.comboBoxRole.Location = New System.Drawing.Point(317, 198)
        Me.comboBoxRole.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.comboBoxRole.Name = "comboBoxRole"
        Me.comboBoxRole.Size = New System.Drawing.Size(437, 27)
        Me.comboBoxRole.TabIndex = 5
        Me.comboBoxRole.Watermark = "Select a role"
        '
        'dateTimePickerActivation
        '
        Me.helpTip.SetHelpTip(Me.dateTimePickerActivation, "Select the date the user's account was first activated.")
        Me.dateTimePickerActivation.Location = New System.Drawing.Point(317, 247)
        Me.dateTimePickerActivation.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.dateTimePickerActivation.Name = "dateTimePickerActivation"
        Me.dateTimePickerActivation.Size = New System.Drawing.Size(437, 27)
        Me.dateTimePickerActivation.TabIndex = 7
        Me.dateTimePickerActivation.Value = New Date(2016, 4, 28, 13, 0, 0, 0)
        '
        'dateTimePickerExpiration
        '
        Me.helpTip.SetHelpTip(Me.dateTimePickerExpiration, "Select the date the user's account will automatically expire and get deactivated." &
        "")
        Me.dateTimePickerExpiration.InvalidMessage = "The expiration date is invalid. It should be higher than the Activation Date." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.dateTimePickerExpiration.Location = New System.Drawing.Point(317, 301)
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
        Me.buttonCancel.Location = New System.Drawing.Point(355, 396)
        Me.buttonCancel.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(173, 53)
        Me.buttonCancel.TabIndex = 10
        Me.buttonCancel.Text = "Cancel"
        '
        'buttonOK
        '
        Me.buttonOK.AppearanceKey = "button-ok"
        Me.buttonOK.DialogResult = Wisej.Web.DialogResult.OK
        Me.buttonOK.Location = New System.Drawing.Point(579, 394)
        Me.buttonOK.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(179, 55)
        Me.buttonOK.TabIndex = 11
        Me.buttonOK.Text = "&OK"
        '
        'textBoxTotal
        '
        Me.helpTip.SetHelpTip(Me.textBoxTotal, "Enter the user's last name.")
        Me.textBoxTotal.Location = New System.Drawing.Point(317, 340)
        Me.textBoxTotal.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.textBoxTotal.Name = "textBoxTotal"
        Me.textBoxTotal.Size = New System.Drawing.Size(437, 27)
        Me.textBoxTotal.TabIndex = 16
        Me.textBoxTotal.Watermark = "Enter Total"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(36, 45)
        Me.label6.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(43, 30)
        Me.label6.TabIndex = 13
        Me.label6.Text = "ID"
        '
        'labelID
        '
        Me.labelID.Location = New System.Drawing.Point(317, 45)
        Me.labelID.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(29, 30)
        Me.labelID.TabIndex = 14
        Me.labelID.Text = "#"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(36, 343)
        Me.label7.Margin = New Wisej.Web.Padding(4, 3, 4, 3)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(153, 30)
        Me.label7.TabIndex = 15
        Me.label7.Text = "Total"
        '
        'frmSummaryAllCallsUserDataDialog
        '
        Me.AcceptButton = Me.buttonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(812, 487)
        Me.Controls.Add(Me.textBoxTotal)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.labelID)
        Me.Controls.Add(Me.label6)
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
        Me.Name = "frmSummaryAllCallsUserDataDialog"
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
    Friend WithEvents label6 As Wisej.Web.Label
    Friend WithEvents labelID As Wisej.Web.Label
    Friend WithEvents textBoxTotal As Wisej.Web.TextBox
    Friend WithEvents label7 As Wisej.Web.Label
End Class
