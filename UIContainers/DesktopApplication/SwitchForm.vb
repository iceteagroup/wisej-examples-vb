Imports System
Imports Wisej.Web

Partial Public Class SwitchForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Application.Desktop.GetType() Is GetType(SecondaryDesktop) Then
            Application.Desktop = Application.Session.desktopPrimary
        Else
            Application.Desktop = Application.Session.desktopSecondary
        End If
    End Sub
End Class
