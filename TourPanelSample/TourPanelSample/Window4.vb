Imports System
Imports Wisej.Web

Partial Public Class Window4

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Window4_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' hide/show label for Chrome Browser
        If Equals(Application.Browser.Type, "Chrome") Then
            labelChrome.Visible = True
        Else
            labelChrome.Visible = False
        End If

        ckEditor1.Text = "This is a CKEditor. It supports <font color=""blue"">blue</font> text"
    End Sub
End Class
