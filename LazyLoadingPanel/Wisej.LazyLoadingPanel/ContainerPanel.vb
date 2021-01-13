Imports System
Imports Wisej.Web

Partial Public Class ContainerPanel

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Event LoadPanels As EventHandler

    Public Property LoadingMessage As String
        Get
            Return label1.Text
        End Get
        Set(ByVal value As String)
            label1.Text = value
        End Set
    End Property

    Private Sub ContainerPanel_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles MyBase.Scroll
        If loaderPanel.Visible Then
            If e.Type = ScrollEventType.Last Then
                LoadNewPanels()
            ElseIf e.NewValue + Height >= loaderPanel.Top Then
                ScrollControlIntoView(loaderPanel)
            End If
        End If
    End Sub

    Private Sub ContainerPanel_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
        If loaderPanel.Visible Then
            Dim scrollHeight = Height + VerticalScroll.Value
            If loaderPanel.Top < scrollHeight AndAlso loaderPanel.Bottom > scrollHeight Then ScrollControlIntoView(loaderPanel)
        End If
    End Sub

    Private Sub ContainerPanel_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' firs load.
        LoadNewPanels()
    End Sub

    Private Sub LoadNewPanels()
        Dim count = Controls.Count
        RaiseEvent LoadPanels(Me, EventArgs.Empty)

        ' nothing loaded?
        If count = Controls.Count Then loaderPanel.Hide()
    End Sub
End Class
