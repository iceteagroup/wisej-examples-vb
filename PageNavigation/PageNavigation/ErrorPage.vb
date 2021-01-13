Imports System
Imports System.Drawing
Imports Wisej.Web

Partial Public Class ErrorPage

    Public Property FaultPageName As String
    Public Property Message As String
    Private _startExit As DateTimeOffset

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ErrorPage_Appear(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Appear
        details.Text = $"There was a {Message} on {FaultPageName}." & Environment.NewLine & Environment.NewLine & "We should display some details of the error here."
        continueButton.Text = "Go back to " & FaultPageName
    End Sub

    Private Sub continueButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles continueButton.Click
        Application.OpenPages(FaultPageName).Show()
    End Sub

    Private Sub exit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitButton.Click
        _startExit = DateTimeOffset.Now
        AlertBox.Show("Exit the application...", MessageBoxIcon.Warning, True, ContentAlignment.BottomRight, 3000, New Action(AddressOf AppExit), True)
    End Sub

    Private Sub AppExit()
        Dim endExit = DateTimeOffset.Now
        If (endExit - _startExit).TotalMilliseconds >= 3000 Then Application.Exit()
    End Sub
End Class
