Imports System
Imports Wisej.Web
Imports Wisej.Web.Ext.TourPanel

Partial Public Class MyDesktop
    Inherits Desktop

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Watermark As String
    Private Tour1 As TourPanel1

    Private Sub toolBar1_ButtonClick(ByVal sender As Object, ByVal e As ToolBarButtonClickEventArgs) Handles toolBar1.ButtonClick
        Tour1 = New TourPanel1()
        ' wire events
        AddHandler Tour1.Closed, AddressOf Tour1_Closed
        AddHandler Tour1.BeforeStep, AddressOf Tour1_BeforeStep
        AddHandler Tour1.AfterStep, AddressOf Tour1_AfterStep
        AddHandler Tour1.Paused, AddressOf Tour1_Paused
        AddHandler Tour1.Playing, AddressOf Tour1_Playing
        AddHandler Tour1.Ended, AddressOf Tour1_Ended
        '
        If e.Button Is toolBarButton2 Then
            Tour1.AutoPlay = True
        Else
            Tour1.AutoPlay = False
        End If

        ' browse through all steps and disable steps tagged as Chrome if not running in Chrome
        If Not Equals(Application.Browser.Type, "Chrome") Then
            For Each [Step] In Tour1.Steps
                If [Step].Tag IsNot Nothing AndAlso Equals([Step].Tag.ToString(), "Chrome") Then [Step].Enabled = False
            Next
        End If

        Tour1.Show()
    End Sub

    Private Sub Tour1_Ended(ByVal sender As Object, ByVal e As EventArgs)
        AlertBox.Show("Your tour ends here. Thanks for paying attention")
    End Sub

    Private Sub Tour1_Playing(ByVal sender As Object, ByVal e As EventArgs)
        AlertBox.Show("Autoplaying of tour has started. Use the pause button to have a break.")
    End Sub

    Private Sub Tour1_Paused(ByVal sender As Object, ByVal e As EventArgs)
        AlertBox.Show("Autoplaying has paused.")
    End Sub

    Private Sub Tour1_AfterStep(ByVal sender As Object, ByVal e As TourPanelEventArgs)
        If Equals(e.Step.TargetName, "Window5.textBoxWatermark") Then
            ' restore with saved text
            Dim win5 = CType(Application.OpenForms("Window5"), Window5)
            win5.textBoxWatermark.Text = Watermark
        End If
    End Sub

    Private Sub Tour1_BeforeStep(ByVal sender As Object, ByVal e As TourPanelEventArgs)
        If Equals(e.Step.TargetName, "Window3.dataGridView1.colNAME") Then
            Dim win3 = CType(Application.OpenForms("Window3"), Window3)
            win3?.SortDGVByName()
        End If

        ' set different colors and additional text for required fields
        If e.Step.TargetName.Contains("txtFirstName") OrElse e.Step.TargetName.Contains("txtName") Then
            e.Step.Tour.HighlightColor = Drawing.Color.FromArgb(120, 230, 10, 10)
            e.Step.Tour.BackColor = Drawing.Color.FromArgb(255, 209, 204)
            Dim RequiredFieldInfo = "<br/><br/><small> This is a required field</small>"
            If Not e.Step.Text.Contains(RequiredFieldInfo) Then e.Step.Text += RequiredFieldInfo
        Else
            ' use default color
            e.Step.Tour.HighlightColor = Drawing.Color.Empty
            e.Step.Tour.BackColor = Drawing.Color.Empty
        End If

        If Equals(e.Step.TargetName, "Window5.textBoxWatermark") Then
            ' save existing text and emtpy field to have the Watermark displayed
            Dim win5 = CType(Application.OpenForms("Window5"), Window5)
            Watermark = win5.textBoxWatermark.Text
            win5.textBoxWatermark.Clear()
        End If
    End Sub

    Private Sub Tour1_Closed(ByVal sender As Object, ByVal e As EventArgs)
        Tour1.Dispose()
    End Sub
End Class
