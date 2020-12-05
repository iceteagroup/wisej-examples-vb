Imports System

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDataDialog
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


#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        columnProperty = New Wisej.Web.DataGridViewColumn()
        columnValue = New Wisej.Web.DataGridViewColumn()
        label1 = New Wisej.Web.Label()
        label2 = New Wisej.Web.Label()
        label3 = New Wisej.Web.Label()
        label4 = New Wisej.Web.Label()
        label5 = New Wisej.Web.Label()
        textBoxName = New Wisej.Web.TextBox()
        textBoxLastName = New Wisej.Web.TextBox()
        comboBoxRole = New Wisej.Web.ComboBox()
        dateTimePickerActivation = New Wisej.Web.DateTimePicker()
        dateTimePickerExpiration = New Wisej.Web.DateTimePicker()
        buttonCancel = New Wisej.Web.Button()
        buttonOK = New Wisej.Web.Button()
        helpTip = New Wisej.Web.HelpTip(components)
        label6 = New Wisej.Web.Label()
        labelID = New Wisej.Web.Label()
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
        columnValue.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        columnValue.HeaderText = "Value"
        columnValue.Name = "columnValue"
        ' 
        ' label1
        ' 
        label1.Location = New Drawing.Point(27, 86)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(68, 27)
        label1.TabIndex = 12
        label1.Text = "Name"
        ' 
        ' label2
        ' 
        label2.Location = New Drawing.Point(27, 134)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(115, 27)
        label2.TabIndex = 2
        label2.Text = "Last Name"
        ' 
        ' label3
        ' 
        label3.Location = New Drawing.Point(27, 179)
        label3.Name = "label3"
        label3.Size = New Drawing.Size(55, 27)
        label3.TabIndex = 4
        label3.Text = "Role"
        ' 
        ' label4
        ' 
        label4.Location = New Drawing.Point(27, 227)
        label4.Name = "label4"
        label4.Size = New Drawing.Size(157, 27)
        label4.TabIndex = 6
        label4.Text = "Activation Date"
        ' 
        ' label5
        ' 
        label5.Location = New Drawing.Point(27, 272)
        label5.Name = "label5"
        label5.Size = New Drawing.Size(158, 27)
        label5.TabIndex = 8
        label5.Text = "Expiration Date"
        ' 
        ' textBoxName
        ' 
        helpTip.SetHelpTip(textBoxName, "Enter the user's first name.")
        textBoxName.Location = New Drawing.Point(238, 83)
        textBoxName.Name = "textBoxName"
        textBoxName.Size = New Drawing.Size(328, 32)
        textBoxName.TabIndex = 1
        textBoxName.Watermark = "Enter the name"
        ' 
        ' textBoxLastName
        ' 
        helpTip.SetHelpTip(textBoxLastName, "Enter the user's last name.")
        textBoxLastName.Location = New Drawing.Point(238, 131)
        textBoxLastName.Name = "textBoxLastName"
        textBoxLastName.Size = New Drawing.Size(328, 32)
        textBoxLastName.TabIndex = 3
        textBoxLastName.Watermark = "Enter the last name"
        ' 
        ' comboBoxRole
        ' 
        comboBoxRole.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        comboBoxRole.FormattingEnabled = True
        helpTip.SetHelpTip(comboBoxRole, "Select the user's role from the list.")
        comboBoxRole.Items.AddRange(New Object() {"User", "Editor", "Contributor", "Administrator"})
        comboBoxRole.Location = New Drawing.Point(238, 176)
        comboBoxRole.Name = "comboBoxRole"
        comboBoxRole.Size = New Drawing.Size(328, 34)
        comboBoxRole.TabIndex = 5
        comboBoxRole.Watermark = "Select a role"
        ' 
        ' dateTimePickerActivation
        ' 
        helpTip.SetHelpTip(dateTimePickerActivation, "Select the date the user's account was first activated.")
        dateTimePickerActivation.Location = New Drawing.Point(238, 220)
        dateTimePickerActivation.Name = "dateTimePickerActivation"
        dateTimePickerActivation.Size = New Drawing.Size(328, 34)
        dateTimePickerActivation.TabIndex = 7
        dateTimePickerActivation.Value = New DateTime(2016, 4, 28, 13, 0, 0, 0)
        ' 
        ' dateTimePickerExpiration
        ' 
        helpTip.SetHelpTip(dateTimePickerExpiration, "Select the date the user's account will automatically expire and get deactivated." & "")
        dateTimePickerExpiration.InvalidMessage = "The expiration date is invalid. It should be higher than the Activation Date." & Microsoft.VisualBasic.Constants.vbCrLf
        dateTimePickerExpiration.Location = New Drawing.Point(238, 268)
        dateTimePickerExpiration.Name = "dateTimePickerExpiration"
        dateTimePickerExpiration.Size = New Drawing.Size(328, 34)
        dateTimePickerExpiration.TabIndex = 9
        dateTimePickerExpiration.Value = New DateTime(2016, 4, 28, 13, 0, 0, 0)
        AddHandler dateTimePickerExpiration.Validating, New ComponentModel.CancelEventHandler(AddressOf dateTimePickerExpiration_Validating)
        ' 
        ' buttonCancel
        ' 
        buttonCancel.AppearanceKey = "button-cancel"
        buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel
        buttonCancel.Location = New Drawing.Point(266, 352)
        buttonCancel.Name = "buttonCancel"
        buttonCancel.Size = New Drawing.Size(130, 47)
        buttonCancel.TabIndex = 10
        buttonCancel.Text = "Cancel"
        AddHandler buttonCancel.Click, New EventHandler(AddressOf buttonCancel_Click)
        ' 
        ' buttonOK
        ' 
        buttonOK.AppearanceKey = "button-ok"
        buttonOK.DialogResult = Wisej.Web.DialogResult.OK
        buttonOK.Location = New Drawing.Point(434, 350)
        buttonOK.Name = "buttonOK"
        buttonOK.Size = New Drawing.Size(134, 49)
        buttonOK.TabIndex = 11
        buttonOK.Text = "&OK"
        AddHandler buttonOK.Click, New EventHandler(AddressOf buttonOK_Click)
        ' 
        ' label6
        ' 
        label6.Location = New Drawing.Point(27, 40)
        label6.Name = "label6"
        label6.Size = New Drawing.Size(32, 27)
        label6.TabIndex = 13
        label6.Text = "ID"
        ' 
        ' labelID
        ' 
        labelID.Location = New Drawing.Point(238, 40)
        labelID.Name = "labelID"
        labelID.Size = New Drawing.Size(22, 27)
        labelID.TabIndex = 14
        labelID.Text = "#"
        ' 
        ' UserDataDialog
        ' 
        AcceptButton = buttonOK
        AutoScaleDimensions = New Drawing.SizeF(9.0F, 24.0F)
        AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        CancelButton = buttonCancel
        ClientSize = New Drawing.Size(609, 433)
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
        Font = New Drawing.Font("Helvetica", 16.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed
        Margin = New Wisej.Web.Padding(9, 0, 9, 0)
        MaximizeBox = False
        MinimizeBox = False
        Name = "UserDataDialog"
        StartPosition = Wisej.Web.FormStartPosition.CenterScreen
        Text = "User Data"
        AddHandler Load, New EventHandler(AddressOf UserDataDialog_Load)
        ResumeLayout(False)
        PerformLayout()
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
End Class
