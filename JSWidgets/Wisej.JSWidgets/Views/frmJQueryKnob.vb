Imports System
Imports System.Net.NetworkInformation
Imports Wisej.Web
Imports Wisej.Web.Ext

Partial Public Class frmJQueryKnob

    Private ReadOnly _random As Random
    Private ReadOnly _ping As Ping

    Public Sub New()
        InitializeComponent()
        _random = New Random()
        _ping = New Ping()
        timerCurrentTime.Start()
    End Sub

    Private Sub timerCurrentTime_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timerCurrentTime.Tick
        knobRandom.Value = _random.Next(1, 99)
        Dim currentDate = Date.Now
        knobHour.Value = currentDate.Hour
        knobMinute.Value = currentDate.Minute
        knobSecond.Value = currentDate.Second
        lblCurrentTime.Text = currentDate.ToLongTimeString()
    End Sub

    Private Sub frmJQueryKnob_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cmbLineStyle.DataSource = [Enum].GetNames(GetType(Ext.jQueryKnob.LineCapType))
        cmbKnobStyle.DataSource = [Enum].GetNames(GetType(Ext.jQueryKnob.KnobType))
        cmbBorderStyle.DataSource = [Enum].GetNames(GetType(BorderStyle))
    End Sub

    Private Sub cmbLineStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbLineStyle.SelectedIndexChanged
        Dim OptionSelected As Ext.jQueryKnob.LineCapType

        If cmbLineStyle.SelectedValue IsNot Nothing Then
            [Enum].TryParse(cmbLineStyle.SelectedValue.ToString(), OptionSelected)
            knobCustom.LineCapStyle = OptionSelected
        End If
    End Sub

    Private Sub cmbKnobStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbKnobStyle.SelectedIndexChanged
        Dim OptionSelected As Ext.jQueryKnob.KnobType

        If cmbKnobStyle.SelectedValue IsNot Nothing Then
            [Enum].TryParse(cmbKnobStyle.SelectedValue.ToString(), OptionSelected)
            knobCustom.KnobType = OptionSelected
        End If
    End Sub

    Private Sub cmbBorderStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbBorderStyle.SelectedIndexChanged
        Dim OptionSelected As BorderStyle

        If cmbBorderStyle.SelectedValue IsNot Nothing Then
            [Enum].TryParse(cmbBorderStyle.SelectedValue.ToString(), OptionSelected)
            knobCustom.BorderStyle = OptionSelected
        End If
    End Sub
End Class
