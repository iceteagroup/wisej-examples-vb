Imports System
Imports Wisej.Web

Partial Public Class Workspace
    Inherits Page

    Private ReadOnly _previousPage As String

    Public Sub New(ByVal workspaceName As String)
        InitializeComponent()
        Name = workspaceName
        _previousPage = PreviousPage.Name
    End Sub

    Private Sub Workspace_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        usernameLabel.Text = Application.Session.Username
        workspaceLabel.Text = Name

        If Equals(Name, "Main Page") Then
            customerName.Text = "Mr. Joe Bloggs"
            backButton.Text = "Logout"
            errorButton.Text = "Database Error"
        Else
            customerName.Text = "Mrs. Jane Smith"
            newWorkspace.Visible = False
            errorButton.Text = "Server Overloaded"
        End If
    End Sub

    Private Sub backButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backButton.Click
        If Equals(Name, "Main Page") Then
            Application.Session.Username = String.Empty
            Navigate(GetType(Login))
        Else
            WorkspaceNavigate(_previousPage)
        End If
    End Sub

    Private Sub newWorkspace_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newWorkspace.Click
        WorkspaceNavigate("Page 1")
        newWorkspace.Text = "To Page 1"
    End Sub

    Private Sub settingsButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles settingsButton.Click
        Navigate(GetType(Settings))
    End Sub

    Private Sub errorButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles errorButton.Click
        Throw New Exception(errorButton.Text)
    End Sub
End Class
