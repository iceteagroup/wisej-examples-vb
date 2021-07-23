Imports System
Imports Wisej.Web

Public Class frmSummaryAllCallsUserDataDialog

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Property Values As Object()

    Private Sub UserDataDialog_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadUserData()
    End Sub

    Private Sub LoadUserData()
        labelID.Text = Values(0).ToString()
        textBoxName.Text = Values(1).ToString()
        textBoxLastName.Text = Values(2).ToString()
        comboBoxRole.SelectedItem = Values(3).ToString()
        dateTimePickerActivation.Value = CDate(Values(4))
        dateTimePickerExpiration.Value = CDate(Values(5))
        textBoxTotal.Text = Values(6).ToString()
    End Sub

    Private Sub UpdateUserData()
        Values(1) = textBoxName.Text
        Values(2) = textBoxLastName.Text
        Values(3) = comboBoxRole.Text
        Values(4) = dateTimePickerActivation.Value
        Values(5) = dateTimePickerExpiration.Value
        Values(6) = Double.Parse(textBoxTotal.Text)
    End Sub

    Private Sub buttonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCancel.Click
        Close()
    End Sub

    Private Sub buttonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOK.Click
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
