Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports Wisej.Web

Partial Public Class ItemPanel

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Event ActionClick As EventHandler

    Private Sub action_Click(ByVal sender As Object, ByVal e As EventArgs) Handles action.Click
        RaiseEvent ActionClick(Me, EventArgs.Empty)
    End Sub

    <TypeConverter("Wisej.Web.Design.ImageSourceConverter, Wisej.Web.Design")>
    <Editor("Wisej.Web.Design.ImageSourceEditor, Wisej.Web.Design", GetType(UITypeEditor))>
    Public Property ImageSource As String
        Get
            Return icon.ImageSource
        End Get
        Set(ByVal value As String)
            icon.ImageSource = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return titleField.Text
        End Get
        Set(ByVal value As String)
            titleField.Text = value
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            Return textField.Text
        End Get
        Set(ByVal value As String)
            textField.Text = value
        End Set
    End Property
End Class
