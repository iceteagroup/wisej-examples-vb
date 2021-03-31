Imports System
Imports Wisej.Web
Imports Wisej.Web.Ext.Html2Canvas

Public Class Window1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim image = Await Ext.Html2Canvas.Html2Canvas.ScreenshotAsync(Me)
        Me.PictureBox1.Image = image

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Ext.Html2Canvas.Html2Canvas.Screenshot(Me.Panel1, Sub(Image) Me.PictureBox1.Image = (Image))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Ext.Html2Canvas.Html2Canvas.Screenshot(Sub(Image) Me.PictureBox1.Image = (Image))

    End Sub
End Class
