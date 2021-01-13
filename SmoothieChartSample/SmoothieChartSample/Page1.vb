Imports System
Imports System.Drawing
Imports Wisej.Web
Imports Wisej.Web.Ext.SmoothieChart

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' 1
        smoothieChart1.TimeSeries.Add(New TimeSeries() With {
            .FillColor = Color.Green
        })
        smoothieChart1.TimeSeries.Add(New TimeSeries() With {
            .FillColor = Color.Red
        })
        smoothieChart1.TimeSeries.Add(New TimeSeries() With {
            .FillColor = Color.Blue
        })
        ' 2
        smoothieChart2.TimeSeries.Add(New TimeSeries() With {
            .FillColor = Color.LightGray,
            .LineColor = Color.White,
            .LineWidth = 5
        })
        ' 3
        smoothieChart3.TimeSeries.Add(New TimeSeries() With {
            .FillColor = Color.Red,
            .LineColor = Color.Black,
            .LineWidth = 2
        })
    End Sub

    Private Shared rnd As Random = New Random()

    Private Sub smoothieChart1_DataNeeded(ByVal sender As Object, ByVal e As DataNeededEventArgs) Handles smoothieChart1.DataNeeded
        If e.LineIndex = 0 Then
            e.Value = rnd.Next(100)
        ElseIf e.LineIndex = 1 Then
            e.Value = rnd.Next(50)
        ElseIf e.LineIndex = 2 Then
            e.Value = rnd.Next(30)
        End If
    End Sub

    Private Sub smoothieChart2_DataNeeded(ByVal sender As Object, ByVal e As DataNeededEventArgs) Handles smoothieChart2.DataNeeded
        e.Value = rnd.Next(1000)
    End Sub

    Private Sub smoothieChart3_DataNeeded(ByVal sender As Object, ByVal e As DataNeededEventArgs) Handles smoothieChart3.DataNeeded
        e.Value = rnd.Next(100)
    End Sub
End Class
