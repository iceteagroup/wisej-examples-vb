Imports System.Drawing
Imports Wisej.Web

Partial Public Class Window1


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles button1.Paint
        e.Graphics.FillRectangle(Brushes.Yellow, New Rectangle(10, 10, button1.Width / 10, button1.Height - 20))
    End Sub
End Class
