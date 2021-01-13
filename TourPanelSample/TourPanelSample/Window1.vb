Imports System
Imports Wisej.Web

Partial Public Class Window1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub comboBox1_ToolClick(ByVal sender As Object, ByVal e As ToolClickEventArgs)
        AlertBox.Show("Not implemented in this sample.")
    End Sub
End Class
