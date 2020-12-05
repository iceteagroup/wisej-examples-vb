Imports System
Imports Wisej.Web

Partial Public Class Window1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Window1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadUserData(oUserData)
    End Sub

    Private Sub LoadUserData(ByVal data As UserData)
        dataGrid.RowCount = 5
        dataGrid(columnProperty, 0).Value = "Name"
        dataGrid(columnProperty, 1).Value = "Last Name"
        dataGrid(columnProperty, 2).Value = "Role"
        dataGrid(columnProperty, 3).Value = "Activation Date"
        dataGrid(columnProperty, 4).Value = "Expiration Date"
        dataGrid(columnValue, 0).Value = data.Name
        dataGrid(columnValue, 1).Value = data.LastName
        dataGrid(columnValue, 2).Value = data.Role
        dataGrid(columnValue, 3).Value = data.AccountCreation.ToLongDateString()
        dataGrid(columnValue, 4).Value = data.AccountExpiration.ToLongDateString()
    End Sub

    Private oUserData As UserData = New UserData()

    Private Sub buttonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOK.Click
        ' create the dialog in a using block to make sure it gets disposed.
        Using dialog = New UserDataDialog(oUserData)

            ' show the dialog and wait for it to close.
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                ' this code is executed only after the dialog is closed.
                ' until then we are suspended...
                oUserData = dialog.pUserData
                LoadUserData(oUserData)
            End If
        End Using
    End Sub
End Class
