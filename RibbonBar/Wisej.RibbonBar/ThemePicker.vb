Imports System
Imports Wisej.Web

Partial Public Class ThemePicker


    Private _SelectedTheme As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Event ThemeClicked As EventHandler

    Private Sub pictureBox_Click(ByVal sender As Object, ByVal e As EventArgs)
        SelectedTheme = CType(sender, PictureBox).ImageSource
        RaiseEvent ThemeClicked(Me, e)
    End Sub

    Public Property SelectedTheme As String
        Get
            Return _SelectedTheme
        End Get
        Private Set(ByVal value As String)
            _SelectedTheme = value
        End Set
    End Property
End Class
