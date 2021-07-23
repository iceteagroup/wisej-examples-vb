Imports System
Imports Wisej.Web

Public Class Home


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnSummaryGroup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSummaryGroup.Click
        Dim window As frmSummaryGroup = New frmSummaryGroup()
        window.StartPosition = FormStartPosition.CenterParent
        window.Show()
    End Sub

    Private Sub btnCase1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCase1.Click
        Dim window As frmSummaryHugeData1 = New frmSummaryHugeData1()
        window.StartPosition = FormStartPosition.CenterParent
        window.Show()
    End Sub

    Private Sub btnCase2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCase2.Click
        Dim window As frmSummaryHugeData2 = New frmSummaryHugeData2()
        window.StartPosition = FormStartPosition.CenterParent
        window.Show()
    End Sub

    Private Sub btnAllCallsSummary_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAllCallsSummary.Click
        Dim window As frmSummaryAllCalls = New frmSummaryAllCalls()
        window.StartPosition = FormStartPosition.CenterParent
        window.Show()
    End Sub
End Class
