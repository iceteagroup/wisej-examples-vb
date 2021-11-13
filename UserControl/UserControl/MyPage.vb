Imports System
Imports Wisej.Web

Partial Public Class MyPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub colorSlider_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles colorSlider.ValueChanged
        colorPanel.BackColor = colorSlider.Color
    End Sub

    Private Sub MyPage_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        colorPanel.BackColor = colorSlider.Color
    End Sub

    Private Sub checkBoxShowValueBubble_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxShowValueBubble.CheckedChanged
        colorSlider.ShowValueBubbles = checkBoxShowValueBubble.Checked
    End Sub
End Class
