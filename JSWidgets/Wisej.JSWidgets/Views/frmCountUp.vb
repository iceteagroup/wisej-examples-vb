Imports System
Imports Wisej.Web
Imports Wisej.Web.Ext

Partial Public Class frmCountUp

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnApplyValue_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApplyValue.Click
        countUp1.Value = nudNewValue.Value
    End Sub

    Private Sub chkGrouping_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkGrouping.CheckedChanged
        countUp1.UseGrouping = Not countUp1.UseGrouping
    End Sub

    Private Sub chkEasing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkEasing.CheckedChanged
        countUp1.UseEasing = Not countUp1.UseEasing
    End Sub

    Private Sub btnNewDuration_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewDuration.Click
        countUp1.Duration = CInt(nudDuration.Value)
    End Sub
End Class
