Imports Wisej.Web

Partial Public Class SwitchForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Application.MainPage.GetType() Is GetType(SecondaryPage) Then
            Application.MainPage = Application.Session.pagePrimary
        Else
            Application.MainPage = Application.Session.pageSecondary
        End If
    End Sub
End Class
