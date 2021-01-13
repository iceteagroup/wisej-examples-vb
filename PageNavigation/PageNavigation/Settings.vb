Imports System
Imports Wisej.Web

Partial Public Class Settings

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub close_Click(ByVal sender As Object, ByVal e As EventArgs) Handles close.Click
        'TODO: Mark error, equal than in winforms ???
        'Me.close()
        WorkspaceNavigate("Main Page")
    End Sub

    Private Sub errorButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles errorButton.Click
        Throw New Exception("Unknown Issue")
    End Sub
End Class
