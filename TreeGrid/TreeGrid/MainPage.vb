Imports System
Imports Wisej.Web

Partial Public Class MainPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub dataTable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles dataTable.Click
        Using dataTableWindow = New DataTableWindow()
            dataTableWindow.ShowDialog()
        End Using
    End Sub

    Private Sub objectList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles objectList.Click
        Using objectListWindow = New ObjectListWindow()
            objectListWindow.ShowDialog()
        End Using
    End Sub
End Class
