Imports System
Imports Wisej.Web

Partial Public Class CustomPainting


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub canvas1_Redraw(ByVal sender As Object, ByVal e As EventArgs)
        Dim centerX As Integer = canvas1.Width / 2
        Dim centerY As Integer = canvas1.Height / 2
        Dim radius = 70
        Dim eyeRadius = 10
        Dim eyeXOffset = 25
        Dim eyeYOffset = 20

        ' draw the yellow circle
        Dim context = canvas1
        context.BeginPath()
        context.Arc(centerX, centerY, radius, 0, 360, False)
        context.FillStyle = "yellow"
        context.Fill()
        context.LineWidth = 5
        context.StrokeStyle = "black"
        context.Stroke()

        ' draw the eyes
        context.BeginPath()
        Dim eyeX = centerX - eyeXOffset
        Dim eyeY = centerY - eyeYOffset
        context.Arc(eyeX, eyeY, eyeRadius, 0, 360, False)
        eyeX = centerX + eyeXOffset
        context.Arc(eyeX, eyeY, eyeRadius, 0, 360, False)
        context.FillStyle = "black"
        context.Fill()

        ' draw the mouth
        context.BeginPath()
        context.Arc(centerX, centerY, 50, 0, 180, False)
        context.Stroke()
    End Sub
End Class
