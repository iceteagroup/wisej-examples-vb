Imports System
Imports Wisej.Web

Namespace ChangedNames
    Public Partial Class MainPage

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub MainPage_Load(ByVal sender As Object, ByVal e As EventArgs)
            url.Text = $"URL {Application.Url}"
        End Sub
    End Class
End Namespace
