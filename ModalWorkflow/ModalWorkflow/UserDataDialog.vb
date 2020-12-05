Imports System
Imports Wisej.Web

Partial Public Class UserDataDialog


    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal userData As UserData)
        Me.New()
        Me.pUserData = CType(userData.Clone(), UserData)
    End Sub

    Public Property pUserData As UserData

    Private Sub UserDataDialog_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadRoles()
        LoadUserData()
    End Sub

    Private Sub LoadRoles()
        comboBoxRole.Items.Add(UserRole.User)
        comboBoxRole.Items.Add(UserRole.Editor)
        comboBoxRole.Items.Add(UserRole.Contributor)
        comboBoxRole.Items.Add(UserRole.Administrator)
    End Sub

    Private Sub LoadUserData()
        textBoxName.Text = pUserData.Name
        textBoxLastName.Text = pUserData.LastName
        comboBoxRole.SelectedItem = pUserData.Role
        dateTimePickerActivation.Value = pUserData.AccountCreation
        dateTimePickerExpiration.Value = pUserData.AccountExpiration
    End Sub

    Private Sub UpdateUserData()
        pUserData.Name = textBoxName.Text
        pUserData.LastName = textBoxLastName.Text
        pUserData.Role = CType(comboBoxRole.SelectedItem, UserRole)
        pUserData.AccountCreation = dateTimePickerActivation.Value
        pUserData.AccountExpiration = dateTimePickerExpiration.Value
    End Sub

    Private Sub UserDataDialog_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' when the user tries to close the dialog on the client, the server
        ' we receive the FormClosing event and confirm or cancel.
        If MessageBox.Show("Are you sure you want to close this dialog?", buttons:=MessageBoxButtons.YesNoCancel) <> DialogResult.Yes Then
            ' this line i reached only after the message box has been closed.
            e.Cancel = True
        End If
    End Sub

    Private Sub buttonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCancel.Click
        Close()
    End Sub

    Private Sub buttonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOK.Click
        UpdateUserData()
        Close()
    End Sub

    Private Sub dateTimePickerExpiration_Validating(ByVal sender As Object, ByVal e As ComponentModel.CancelEventArgs) Handles dateTimePickerExpiration.Validating
        ' this is the new Invalid pproperty. it works in conjuction with the
        ' InvalidMessage property to display the control in an error state (themeable).
        dateTimePickerExpiration.Invalid = dateTimePickerExpiration.Value < dateTimePickerActivation.Value
        e.Cancel = dateTimePickerExpiration.Invalid
    End Sub
End Class
