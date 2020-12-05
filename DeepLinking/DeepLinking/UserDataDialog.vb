Imports System
Imports Wisej.Web

Partial Public Class UserDataDialog

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Property Values As Object()

    Private Sub UserDataDialog_Load(ByVal sender As Object, ByVal e As EventArgs)
        LoadUserData()
    End Sub

    Private Sub LoadUserData()
        labelID.Text = Values(0).ToString()
        textBoxName.Text = Values(1).ToString()
        textBoxLastName.Text = Values(2).ToString()
        comboBoxRole.SelectedItem = Values(3).ToString()
        dateTimePickerActivation.Value = CDate(Values(4))
        dateTimePickerExpiration.Value = CDate(Values(5))
    End Sub

    Private Sub UpdateUserData()
        Values(1) = textBoxName.Text
        Values(2) = textBoxLastName.Text
        Values(3) = comboBoxRole.Text
        Values(4) = dateTimePickerActivation.Value
        Values(5) = dateTimePickerExpiration.Value
    End Sub

    Private Sub buttonCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub buttonOK_Click(ByVal sender As Object, ByVal e As EventArgs)
        UpdateUserData()
        Close()
    End Sub

    Private Sub dateTimePickerExpiration_Validating(ByVal sender As Object, ByVal e As ComponentModel.CancelEventArgs)
        ' this is the new Invalid property. it works in conjunction with the
        ' InvalidMessage property to display the control in an error state (themeable).
        dateTimePickerExpiration.Invalid = dateTimePickerExpiration.Value < dateTimePickerActivation.Value
        e.Cancel = dateTimePickerExpiration.Invalid
    End Sub
End Class
