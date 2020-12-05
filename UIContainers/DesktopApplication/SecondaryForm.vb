Imports System
Imports SharedControl
Imports Wisej.Web

Partial Public Class SecondaryForm
    Implements IDataSupplier

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub SecondaryForm_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim stats = New StatsPanel(Me)
        Controls.Add(stats)
        stats.Dock = DockStyle.Fill
    End Sub

    Public Sub Fill(ByVal statsPanel As StatsPanel) Implements IDataSupplier.Fill
        statsPanel.formActiveFormText.Text = ActiveForm.Text

        If Application.MainPage IsNot Nothing Then
            statsPanel.mainPageText.Text = Application.MainPage.Text
            statsPanel.mainPageControlsCount.Text = Application.MainPage.Controls.Count.ToString()

            If Application.MainPage.Controls.Count = 3 Then
                statsPanel.mainPageControlsCount.Text = Application.MainPage.Controls.Count & " (1 label + 2 buttons)"
            Else
                statsPanel.mainPageControlsCount.Text = Application.MainPage.Controls.Count.ToString()
            End If

            If Application.MainPage.ActiveControl IsNot Nothing Then
                statsPanel.mainPageActiveControlText.Text = Application.MainPage.ActiveControl.Text & " (ActiveControl is per page)"
            Else
                statsPanel.mainPageActiveControlText.Text = "NULL (ActiveControl is per page)"
            End If
        Else
            statsPanel.mainPageText.Text = "NULL"
            statsPanel.mainPageControlsCount.Text = "NULL"
            statsPanel.mainPageActiveControlText.Text = "NULL"
        End If

        If Application.Desktop IsNot Nothing Then
            statsPanel.desktopText.Text = Application.Desktop.Text

            If Application.Desktop.Controls.Count = 4 Then
                statsPanel.desktopControlsCount.Text = Application.Desktop.Controls.Count & " (1 label + 1 clock + 2 buttons)"
            Else
                statsPanel.desktopControlsCount.Text = Application.Desktop.Controls.Count.ToString()
            End If

            If Application.Desktop.ActiveControl IsNot Nothing Then
                statsPanel.desktopActiveControlText.Text = Application.Desktop.ActiveControl.Text & " (ActiveControl is per desktop)"
            Else
                statsPanel.desktopActiveControlText.Text = "NULL (ActiveControl is per desktop)"
            End If
        Else
            statsPanel.desktopText.Text = "NULL"
            statsPanel.desktopControlsCount.Text = "NULL"
            statsPanel.desktopActiveControlText.Text = "NULL"
        End If

        statsPanel.applicationOpenForms.Text = Application.OpenForms.Count.ToString()
        statsPanel.applicationOpenPages.Text = Application.OpenPages.Count.ToString()
    End Sub
End Class
