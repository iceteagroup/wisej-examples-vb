Imports System
Imports Wisej.Web
Imports System.Drawing
Imports System.Threading

Partial Public Class StartPopup
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Event ExampleCreated As EventHandler

    Private Sub btnBackgroundTasks_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim example = New BackgroundTasks()
        RaiseEvent ExampleCreated(example, EventArgs.Empty)
        example.Show()
    End Sub

    Private Sub btnIntegration_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim example = New HtmlEditorExample()
        RaiseEvent ExampleCreated(example, EventArgs.Empty)
        example.Show()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim example = New MediaExample()
        RaiseEvent ExampleCreated(example, EventArgs.Empty)
        example.Show()
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim example = New DataBinding()
        RaiseEvent ExampleCreated(example, EventArgs.Empty)
        example.Show()
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim example = New CustomPainting()
        RaiseEvent ExampleCreated(example, EventArgs.Empty)
        example.Show()
    End Sub

    Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs)
        Application.StartTask(Sub()
                                  For i = 0 To 4 - 1
                                      AlertBox.Show("Hello, <b>World!</b>", icon:=MessageBoxIcon.Information, alignment:=ContentAlignment.BottomCenter)
                                      AlertBox.Show("Hello, <b>World!</b>", icon:=MessageBoxIcon.Error, alignment:=ContentAlignment.BottomLeft)
                                      AlertBox.Show("Hello, <b>World!</b>", icon:=MessageBoxIcon.Hand, alignment:=ContentAlignment.BottomRight)
                                      AlertBox.Show("Hello, <b>World!</b>", icon:=MessageBoxIcon.Stop, alignment:=ContentAlignment.MiddleCenter)
                                      AlertBox.Show("Hello, <b>World!</b>", icon:=MessageBoxIcon.Question, alignment:=ContentAlignment.MiddleLeft)
                                      AlertBox.Show("Hello, <b>World!</b>", icon:=MessageBoxIcon.Stop, alignment:=ContentAlignment.MiddleRight)
                                      AlertBox.Show("Hello, <b>World!</b>", icon:=MessageBoxIcon.Warning, alignment:=ContentAlignment.TopCenter)
                                      AlertBox.Show("Hello, <b>World!</b>", icon:=MessageBoxIcon.Question, alignment:=ContentAlignment.TopLeft)
                                      AlertBox.Show("Hello, <b>World!</b>", icon:=MessageBoxIcon.Information, alignment:=ContentAlignment.TopRight)
                                      Application.Update(Me)
                                      Thread.Sleep(500)
                                  Next
                              End Sub)
    End Sub
End Class
