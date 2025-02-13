Imports System
Imports System.Threading
Imports Wisej.Web

Partial Public Class GagePopup

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub GagePopup_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Visible Then SatrtUpdatingGage()
    End Sub

    Private Sub SatrtUpdatingGage()
        Application.StartTask(Sub()
                                  While Visible AndAlso Not Application.IsTerminated
                                      justGage1.Value = CPU
                                      Application.Update(Me)
                                      Thread.Sleep(1000)
                                  End While
                              End Sub)
    End Sub
End Class
