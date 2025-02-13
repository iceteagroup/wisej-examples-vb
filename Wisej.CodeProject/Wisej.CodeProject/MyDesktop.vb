Imports System
Imports Wisej.Web
Imports System.Threading

Partial Public Class MyDesktop

    Private gageuPopup As GagePopup
    Private startPopup As StartPopup

    Public Sub New()
        InitializeComponent()
        startPopup = New StartPopup() With {
            .Alignment = Placement.TopLeft
        }

        AddHandler startPopup.ExampleCreated, AddressOf StartPopup_ExampleCreated
    End Sub

    Private Sub MyDesktop_ItemClick(ByVal sender As Object, ByVal e As DesktopTaskBarItemClickEventArgs) Handles MyBase.ItemClick
        If e.Item Is desktopStart Then
            ' show/hide the start popup.
            If startPopup.Visible Then
                startPopup.Close()

            Else
                startPopup.ShowPopup(e.Item)
            End If
        End If
    End Sub

    Private Sub justGage1_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' show the gage popup.
        If gageuPopup Is Nothing Then gageuPopup = New GagePopup() With {
            .Alignment = Placement.TopRight
        }

        If gageuPopup.Visible Then
            gageuPopup.Close()
        Else
            gageuPopup.ShowPopup(desktopCPU)
        End If
    End Sub

    Private Sub StartPopup_ExampleCreated(ByVal sender As Object, ByVal e As EventArgs)
        ' close the start popup when an example form is created.
        startPopup.Close()
    End Sub

    Private Sub MyDesktop_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' start gage background task.
        SatrtUpdatingGageItem()
    End Sub

    Private Sub SatrtUpdatingGageItem()
        Dim lastValue = 0
        Dim speekCounter = 0
        Application.StartTask(Sub()
                                  While Not Application.IsTerminated
                                      justGage1.Value = CPU

                                      ' speak!
                                      ' use some arbitrary rules to decide when to say something.
                                      If lastValue <> justGage1.Value Then
                                          speekCounter += 1

                                          If speekCounter > 30 Then
                                              speekCounter = 0
                                              lastValue = CInt(Math.Round(justGage1.Value))
                                              speechSynthesis.Speak("The CPU is running at " & lastValue & "%.")
                                          End If
                                      End If

                                      Application.Update(Me)
                                      Thread.Sleep(1000)
                                  End While
                              End Sub)
    End Sub
End Class
