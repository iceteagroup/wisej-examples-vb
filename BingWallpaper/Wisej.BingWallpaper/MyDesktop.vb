Imports System
Imports Wisej.Web

Partial Public Class MyDesktop

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnFadingInterval_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFadingInterval.Click
        bingWallpaper.FadeTime = CInt(nudFadingInterval.Value)
    End Sub

    Private Sub btnRotationInterval_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRotationInterval.Click
        bingWallpaper.RotationInterval = CInt(nudRotationInterval.Value)
    End Sub

    Private Sub btnPictureCount_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPictureCount.Click
        bingWallpaper.MaxImages = CInt(nudPictureCount.Value)
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.Click
        bingWallpaper.EnableAnimation = Not bingWallpaper.EnableAnimation
    End Sub
End Class
