Imports System
Imports Wisej.Web

Partial Public Class HtmlEditorExample
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub HtmlEditorExample_Load(ByVal sender As Object, ByVal e As EventArgs)
        ckEditor1.Text = "Hello, <b>World!</b>"
    End Sub
End Class
