Imports System
Imports Wisej.Web
Imports Wisej.Web.Ext

Partial Public Class frmCoolClock
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmCoolClock_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cbClockSkin.DataSource = [Enum].GetNames(GetType(Ext.CoolClock.CoolClockSkin))
        cbClockType.DataSource = [Enum].GetNames(GetType(Ext.CoolClock.CoolClockType))
    End Sub

    Private Sub cbClockSkin_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbClockSkin.SelectedIndexChanged
        Dim OptionSelected As Ext.CoolClock.CoolClockSkin

        If cbClockSkin.SelectedValue IsNot Nothing Then
            [Enum].TryParse(cbClockSkin.SelectedValue.ToString(), OptionSelected)
            coolClock1.Skin = OptionSelected
        End If
    End Sub

    Private Sub cbClockType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbClockType.SelectedIndexChanged
        Dim OptionSelected As Ext.CoolClock.CoolClockType

        If cbClockType.SelectedValue IsNot Nothing Then
            [Enum].TryParse(cbClockType.SelectedValue.ToString(), OptionSelected)
            coolClock1.ClockType = OptionSelected
        End If
    End Sub
End Class
