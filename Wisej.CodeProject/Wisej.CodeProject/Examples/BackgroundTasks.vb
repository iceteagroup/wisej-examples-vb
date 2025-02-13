Imports System
Imports Wisej.Web
Imports System.Threading

Partial Public Class BackgroundTasks
    Public Sub New()
        InitializeComponent()
        button1.Enabled = True
        button2.Enabled = False
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        [stop] = False
        button1.Enabled = False
        button2.Enabled = True
        Application.StartTask(Sub()
                                  For count = 0 To 100
                                      If [stop] OrElse Application.IsTerminated OrElse IsDisposed Then Exit For
                                      progressBar1.Value = count
                                      progressCircle1.Value = count
                                      progressBar1.Text = count & "%"
                                      label1.Text = BuildText(count)
                                      Application.Update(Me)
                                      Thread.Sleep(500)
                                  Next

                                  button1.Enabled = True
                                  Application.Update(Me)
                              End Sub)
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        [stop] = True
        button2.Enabled = False
    End Sub

    Private [stop] As Boolean

    Private Function BuildText(ByVal count As Integer) As String
        Select Case count
            Case 0
                Return "Started!"
            Case 10
                Return "Reached 10, still going..."
            Case 50
                Return "Half way there."
            Case 100
                Return "<big><big>Done</big></big>"
            Case Else
                Return "<i>Current Progress:</i> " & count
        End Select
    End Function
End Class
