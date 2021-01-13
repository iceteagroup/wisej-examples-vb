Imports System
Imports Wisej.Web

Namespace DGVEmbeddedNavigator
    Public Partial Class Page1

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub buttonEmbeddedBindingNavigator_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonEmbeddedBindingNavigator.Click
            Using window = New EmbeddedBindingNavigator()
                window.ShowDialog()
            End Using
        End Sub

        Private Sub buttonNavigationPanel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonNavigationPanel.Click
            Using window = New NavigationPanel()
                window.ShowDialog()
            End Using
        End Sub
    End Class
End Namespace
