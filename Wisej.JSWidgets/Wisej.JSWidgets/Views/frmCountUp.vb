Imports System
Imports Wisej.Web

Partial Public Class frmCountUp
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnApplyValue_Click(ByVal sender As Object, ByVal e As EventArgs)
        countUp1.Value = nudNewValue.Value
    End Sub

    Private Sub chkGrouping_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        countUp1.UseGrouping = Not countUp1.UseGrouping
    End Sub

    Private Sub chkEasing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        countUp1.UseEasing = Not countUp1.UseEasing
    End Sub

    Private Sub btnNewDuration_Click(ByVal sender As Object, ByVal e As EventArgs)
        countUp1.Duration = CInt(nudDuration.Value)
    End Sub
End Class
