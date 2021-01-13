Imports System
Imports System.Drawing
Imports Wisej.Web

Partial Public Class MainWindow

    Private modeless As Modeless

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MainWindow_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        AddMdiChildSub()
        AddMdiChildSub()
        AddMdiChildSub()

        ' uncomment the line below to hide the Show thumbnais button
        'this.MdiTabProperties.ShowThumbnails = false;
    End Sub

    Private Sub toolBar1_ButtonClick(ByVal sender As Object, ByVal e As ToolBarButtonClickEventArgs) Handles toolBar1.ButtonClick
        If e.Button Is addMdiChild Then
            AddMdiChildSub()
        ElseIf e.Button Is closeMdiChild Then
            If ActiveMdiChild IsNot Nothing Then ActiveMdiChild.Close()
        ElseIf e.Button Is activateFirstMdiChild Then

            If MdiChildren.Length > 0 Then
                MdiChildren(0).Visible = True
                MdiChildren(0).Activate()
            End If
        ElseIf e.Button Is showModeless Then
            ShowModelessSub()
        ElseIf e.Button Is showHideThumbnails Then

            If MdiTabProperties.ShowThumbnails Then
                MdiTabProperties.ShowThumbnails = False
                showHideThumbnails.Text = "Show Thumbnails Buttom"
            Else
                MdiTabProperties.ShowThumbnails = True
                showHideThumbnails.Text = "Hide Thumbnails Buttom"
            End If
        End If
    End Sub

    Private Sub AddMdiChildSub()
        Dim name = "Form " & MdiChildren.Length + 1
        Dim form As Form = New ChildMdi(name) With {
            .Text = name,
            .MdiParent = Me
        }
        form.Show()
    End Sub

    Private Sub ShowModelessSub()
        If modeless Is Nothing Then
            modeless = New Modeless()
            modeless.Location = New Point(Width - modeless.Width - 10, Height - modeless.Height - 10)
            modeless.TopMost = True
        End If

        modeless.Show()
    End Sub
End Class
