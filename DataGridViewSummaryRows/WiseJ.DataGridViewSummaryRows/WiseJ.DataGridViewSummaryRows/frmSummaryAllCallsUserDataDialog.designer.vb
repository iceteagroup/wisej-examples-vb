
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSummaryAllCallsUserDataDialog
    Inherits WiseJ.Web.Form
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
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

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        columnProperty = New WiseJ.Web.DataGridViewColumn()
        columnValue = New WiseJ.Web.DataGridViewColumn()
        label1 = New WiseJ.Web.Label()
        label2 = New WiseJ.Web.Label()
        label3 = New WiseJ.Web.Label()
        label4 = New WiseJ.Web.Label()
        label5 = New WiseJ.Web.Label()
        textBoxName = New WiseJ.Web.TextBox()
        textBoxLastName = New WiseJ.Web.TextBox()
        comboBoxRole = New WiseJ.Web.ComboBox()
        dateTimePickerActivation = New WiseJ.Web.DateTimePicker()
        dateTimePickerExpiration = New WiseJ.Web.DateTimePicker()
        buttonCancel = New WiseJ.Web.Button()
        buttonOK = New WiseJ.Web.Button()
        helpTip = New WiseJ.Web.HelpTip(components)
        label6 = New WiseJ.Web.Label()
        labelID = New WiseJ.Web.Label()
        textBoxTotal = New WiseJ.Web.TextBox()
        label7 = New WiseJ.Web.Label()
        SuspendLayout()
        ' 
        ' columnProperty
        ' 
        columnProperty.HeaderText = "Property"
        columnProperty.Name = "columnProperty"
        columnProperty.Width = 200
        ' 
        ' columnValue
        ' 
        columnValue.AutoSizeMode = WiseJ.Web.DataGridViewAutoSizeColumnMode.Fill
        columnValue.HeaderText = "Value"
        columnValue.Name = "columnValue"
        ' 
        ' label1
        ' 
        label1.Location = New System.Drawing.Point(36, 93)
        label1.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        label1.Name = "label1"
        label1.Size = New System.Drawing.Size(91, 29)
        label1.TabIndex = 12
        label1.Text = "Name"
        ' 
        ' label2
        ' 
        label2.Location = New System.Drawing.Point(36, 145)
        label2.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        label2.Name = "label2"
        label2.Size = New System.Drawing.Size(153, 29)
        label2.TabIndex = 2
        label2.Text = "Last Name"
        ' 
        ' label3
        ' 
        label3.Location = New System.Drawing.Point(36, 194)
        label3.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        label3.Name = "label3"
        label3.Size = New System.Drawing.Size(73, 29)
        label3.TabIndex = 4
        label3.Text = "Role"
        ' 
        ' label4
        ' 
        label4.Location = New System.Drawing.Point(36, 246)
        label4.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        label4.Name = "label4"
        label4.Size = New System.Drawing.Size(209, 29)
        label4.TabIndex = 6
        label4.Text = "Activation Date"
        ' 
        ' label5
        ' 
        label5.Location = New System.Drawing.Point(36, 295)
        label5.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        label5.Name = "label5"
        label5.Size = New System.Drawing.Size(211, 29)
        label5.TabIndex = 8
        label5.Text = "Expiration Date"
        ' 
        ' textBoxName
        ' 
        helpTip.SetHelpTip(textBoxName, "Enter the user's first name.")
        textBoxName.Location = New System.Drawing.Point(317, 90)
        textBoxName.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        textBoxName.Name = "textBoxName"
        textBoxName.Size = New System.Drawing.Size(437, 27)
        textBoxName.TabIndex = 1
        textBoxName.Watermark = "Enter the name"
        ' 
        ' textBoxLastName
        ' 
        helpTip.SetHelpTip(textBoxLastName, "Enter the user's last name.")
        textBoxLastName.Location = New System.Drawing.Point(317, 142)
        textBoxLastName.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        textBoxLastName.Name = "textBoxLastName"
        textBoxLastName.Size = New System.Drawing.Size(437, 27)
        textBoxLastName.TabIndex = 3
        textBoxLastName.Watermark = "Enter the last name"
        ' 
        ' comboBoxRole
        ' 
        comboBoxRole.DropDownStyle = WiseJ.Web.ComboBoxStyle.DropDownList
        comboBoxRole.FormattingEnabled = True
        helpTip.SetHelpTip(comboBoxRole, "Select the user's role from the list.")
        comboBoxRole.Items.AddRange(New Object() {"User", "Editor", "Contributor", "Administrator"})
        comboBoxRole.Location = New System.Drawing.Point(317, 191)
        comboBoxRole.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        comboBoxRole.Name = "comboBoxRole"
        comboBoxRole.Size = New System.Drawing.Size(437, 27)
        comboBoxRole.TabIndex = 5
        comboBoxRole.Watermark = "Select a role"
        ' 
        ' dateTimePickerActivation
        ' 
        helpTip.SetHelpTip(dateTimePickerActivation, "Select the date the user's account was first activated.")
        dateTimePickerActivation.Location = New System.Drawing.Point(317, 238)
        dateTimePickerActivation.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        dateTimePickerActivation.Name = "dateTimePickerActivation"
        dateTimePickerActivation.Size = New System.Drawing.Size(437, 27)
        dateTimePickerActivation.TabIndex = 7
        dateTimePickerActivation.Value = New System.DateTime(2016, 4, 28, 13, 0, 0, 0)
        ' 
        ' dateTimePickerExpiration
        ' 
        helpTip.SetHelpTip(dateTimePickerExpiration, "Select the date the user's account will automatically expire and get deactivated." & "")
        dateTimePickerExpiration.InvalidMessage = "The expiration date is invalid. It should be higher than the Activation Date." & Microsoft.VisualBasic.Constants.vbCrLf
        dateTimePickerExpiration.Location = New System.Drawing.Point(317, 290)
        dateTimePickerExpiration.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        dateTimePickerExpiration.Name = "dateTimePickerExpiration"
        dateTimePickerExpiration.Size = New System.Drawing.Size(437, 27)
        dateTimePickerExpiration.TabIndex = 9
        dateTimePickerExpiration.Value = New System.DateTime(2016, 4, 28, 13, 0, 0, 0)
        ' 
        ' buttonCancel
        ' 
        buttonCancel.AppearanceKey = "button-cancel"
        buttonCancel.DialogResult = WiseJ.Web.DialogResult.Cancel
        buttonCancel.Location = New System.Drawing.Point(355, 381)
        buttonCancel.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        buttonCancel.Name = "buttonCancel"
        buttonCancel.Size = New System.Drawing.Size(173, 51)
        buttonCancel.TabIndex = 10
        buttonCancel.Text = "Cancel"
        ' 
        ' buttonOK
        ' 
        buttonOK.AppearanceKey = "button-ok"
        buttonOK.DialogResult = WiseJ.Web.DialogResult.OK
        buttonOK.Location = New System.Drawing.Point(579, 379)
        buttonOK.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        buttonOK.Name = "buttonOK"
        buttonOK.Size = New System.Drawing.Size(179, 53)
        buttonOK.TabIndex = 11
        buttonOK.Text = "&OK"
        ' 
        ' label6
        ' 
        label6.Location = New System.Drawing.Point(36, 43)
        label6.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        label6.Name = "label6"
        label6.Size = New System.Drawing.Size(43, 29)
        label6.TabIndex = 13
        label6.Text = "ID"
        ' 
        ' labelID
        ' 
        labelID.Location = New System.Drawing.Point(317, 43)
        labelID.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        labelID.Name = "labelID"
        labelID.Size = New System.Drawing.Size(29, 29)
        labelID.TabIndex = 14
        labelID.Text = "#"
        ' 
        ' textBoxTotal
        ' 
        helpTip.SetHelpTip(textBoxTotal, "Enter the user's last name.")
        textBoxTotal.Location = New System.Drawing.Point(317, 327)
        textBoxTotal.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        textBoxTotal.Name = "textBoxTotal"
        textBoxTotal.Size = New System.Drawing.Size(437, 27)
        textBoxTotal.TabIndex = 16
        textBoxTotal.Watermark = "Enter Total"
        ' 
        ' label7
        ' 
        label7.Location = New System.Drawing.Point(36, 330)
        label7.Margin = New WiseJ.Web.Padding(4, 3, 4, 3)
        label7.Name = "label7"
        label7.Size = New System.Drawing.Size(153, 29)
        label7.TabIndex = 15
        label7.Text = "Total"
        ' 
        ' UserDataDialog
        ' 
        AcceptButton = buttonOK
        AutoScaleDimensions = New System.Drawing.SizeF(12.0F, 26.0F)
        AutoScaleMode = WiseJ.Web.AutoScaleMode.Font
        CancelButton = buttonCancel
        ClientSize = New System.Drawing.Size(812, 469)
        Controls.Add(textBoxTotal)
        Controls.Add(label7)
        Controls.Add(labelID)
        Controls.Add(label6)
        Controls.Add(buttonOK)
        Controls.Add(buttonCancel)
        Controls.Add(dateTimePickerExpiration)
        Controls.Add(dateTimePickerActivation)
        Controls.Add(comboBoxRole)
        Controls.Add(textBoxLastName)
        Controls.Add(textBoxName)
        Controls.Add(label5)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(label1)
        Font = New System.Drawing.Font("Helvetica", 16.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        FormBorderStyle = WiseJ.Web.FormBorderStyle.Fixed
        Margin = New WiseJ.Web.Padding(9, 0, 9, 0)
        MaximizeBox = False
        MinimizeBox = False
        Name = "UserDataDialog"
        StartPosition = WiseJ.Web.FormStartPosition.CenterScreen
        Text = "User Data"
        ResumeLayout(False)
        PerformLayout()
    End Sub

#End Region

    Friend WithEvents columnProperty As WiseJ.Web.DataGridViewColumn
    Friend WithEvents columnValue As WiseJ.Web.DataGridViewColumn
    Friend WithEvents label1 As WiseJ.Web.Label
    Friend WithEvents label2 As WiseJ.Web.Label
    Friend WithEvents label3 As WiseJ.Web.Label
    Friend WithEvents label4 As WiseJ.Web.Label
    Friend WithEvents label5 As WiseJ.Web.Label
    Friend WithEvents textBoxName As WiseJ.Web.TextBox
    Friend WithEvents textBoxLastName As WiseJ.Web.TextBox
    Friend WithEvents comboBoxRole As WiseJ.Web.ComboBox
    Friend WithEvents dateTimePickerActivation As WiseJ.Web.DateTimePicker
    Friend WithEvents dateTimePickerExpiration As WiseJ.Web.DateTimePicker
    Friend WithEvents buttonCancel As WiseJ.Web.Button
    Friend WithEvents buttonOK As WiseJ.Web.Button
    Friend WithEvents helpTip As WiseJ.Web.HelpTip
    Friend WithEvents label6 As WiseJ.Web.Label
    Friend WithEvents labelID As WiseJ.Web.Label
    Friend WithEvents textBoxTotal As WiseJ.Web.TextBox
    Friend WithEvents label7 As WiseJ.Web.Label
End Class
