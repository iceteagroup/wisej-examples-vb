Imports System
Imports Wisej.Web

Partial Public Class Page1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub menuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuItem1.Click
        Call New frmCommandLine().Show()
    End Sub

    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuItem2.Click
        Call New frmEvents().Show()
    End Sub
End Class
