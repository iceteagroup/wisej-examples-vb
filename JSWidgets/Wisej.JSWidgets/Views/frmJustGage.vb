Imports System
Imports Wisej.Web
Imports Wisej.Web.Ext

Public Class frmJustGaje

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmJustGaje_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Get initial values of properties of JustGaje
        '
        justGageTest.Minimum = numericUpDown1.Value
        justGageTest.Maximum = numericUpDown2.Value
        chkDonut.Checked = justGageTest.Donut
        chkHumanFriendly.Checked = justGageTest.HumanFriendly
        cbAnimationType.DataSource = [Enum].GetNames(GetType(Ext.JustGage.JustGage.JustGageAnimationType))
        trackBarGageChange.Minimum = CInt(numericUpDown1.Value)
        trackBarGageChange.Maximum = CInt(numericUpDown2.Value)
    End Sub

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown2.ValueChanged, numericUpDown1.ValueChanged
        justGageTest.Minimum = numericUpDown1.Value
        trackBarGageChange.Minimum = CInt(numericUpDown1.Value)
    End Sub

    Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        justGageTest.Maximum = numericUpDown2.Value
        trackBarGageChange.Maximum = CInt(numericUpDown2.Value)
    End Sub

    Private Sub chkDonut_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkDonut.CheckedChanged
        justGageTest.Donut = chkDonut.Checked
    End Sub

    Private Sub chkHumanFriendly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkHumanFriendly.CheckedChanged
        justGageTest.HumanFriendly = chkHumanFriendly.Checked
    End Sub

    Private Sub cbAnimationType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAnimationType.SelectedIndexChanged
        Dim OptionSelected As Ext.JustGage.JustGage.JustGageAnimationType

        If cbAnimationType.SelectedValue IsNot Nothing Then
            [Enum].TryParse(cbAnimationType.SelectedValue.ToString(), OptionSelected)
            justGageTest.RefreshAnimationType = OptionSelected
        End If
    End Sub

    Private Sub trackBarGageChange_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarGageChange.ValueChanged
        justGageTest.Value = trackBarGageChange.Value
    End Sub
End Class
