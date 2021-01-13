Imports System
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Page1_Appear(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Appear
        SetState(controlState.Text)
    End Sub

    Private Sub comboBox1_SelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs) Handles controlState.SelectedItemChanged
        SetState(controlState.Text)
    End Sub

    Private Sub SetState(ByVal state As String)
        statePanel.Text = state
        Dim isDisabled = Equals(state, "Disabled")
        Dim isReadOnly = Equals(state, "ReadOnly")

        For Each control As Control In statePanel.Controls
            control.Enabled = Not isDisabled
            Dim type = control.GetType()

            If type Is GetType(TextBox) Then
                CType(control, TextBox).ReadOnly = isReadOnly
            ElseIf type Is GetType(ComboBox) Then
                CType(control, ComboBox).ReadOnly = isReadOnly
            ElseIf type Is GetType(DomainUpDown) Then
                CType(control, DomainUpDown).ReadOnly = isReadOnly
            ElseIf type Is GetType(NumericUpDown) Then
                CType(control, NumericUpDown).ReadOnly = isReadOnly
            ElseIf type Is GetType(DateTimePicker) Then
                CType(control, DateTimePicker).ReadOnly = isReadOnly
            ElseIf type Is GetType(ListBox) Then
                CType(control, ListBox).ReadOnly = isReadOnly
            End If
        Next
    End Sub
End Class
