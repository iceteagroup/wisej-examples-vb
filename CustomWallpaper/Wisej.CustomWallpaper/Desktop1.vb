Imports System
Imports System.Drawing
Imports Wisej.Web

Partial Public Class Desktop1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Desktop1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim imageList = New ImageListEntry(2) {}
        imageList(0) = New ImageListEntry()
        imageList(0).Name = "blue"
        imageList(0).Image = Image.FromFile(Application.StartupPath & "/Wallpapers/" & "blue.png")
        imageList(1) = New ImageListEntry()
        imageList(1).Name = "purple"
        imageList(1).Image = Image.FromFile(Application.StartupPath & "/Wallpapers/" & "purple.png")
        imageList(2) = New ImageListEntry()
        imageList(2).Name = "orange"
        imageList(2).Image = Image.FromFile(Application.StartupPath & "/Wallpapers/" & "orange.png")
        customWallpaper.Images = imageList
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
        customWallpaper.EnableAnimation = Not customWallpaper.EnableAnimation
    End Sub

    Private Sub btnFadingInterval_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFadingInterval.Click
        customWallpaper.FadeTime = CInt(nudFadingInterval.Value)
    End Sub

    Private Sub btnRotationInterval_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRotationInterval.Click
        customWallpaper.RotationInterval = CInt(nudRotationInterval.Value)
    End Sub
End Class
