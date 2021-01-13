Imports System
Imports Wisej.Web

Partial Public Class Login

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub loginButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loginButton.Click
        credentialsError.Visible = False

        If Equals(username.Text, password.Text) Then
            Application.Session.Username = username.Text
            WorkspaceNavigate("Main Page")
            password.Text = String.Empty
        Else
            credentialsError.Visible = True
        End If
    End Sub
End Class
