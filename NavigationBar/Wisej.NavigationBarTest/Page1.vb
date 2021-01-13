Imports System
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        button1.Collapsed = Not button1.Collapsed
        flexLayoutPanel1.Visible = Not button1.Collapsed
    End Sub

    Private Sub panel1_ItemClick(ByVal sender As Object, ByVal e As Web.Ext.NavigationBar.NavigationBarItemClickEventArgs) Handles panel1.ItemClick
        label1.Text = e.Item.Text
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        AddHandler Application.ResponsiveProfileChanged, AddressOf Application_ResponsiveProfileChanged
    End Sub

    Private Sub Application_ResponsiveProfileChanged(ByVal sender As Object, ByVal e As ResponsiveProfileChangedEventArgs)
        If Application.Browser.ScreenSize.Width < 700 Then
            panel1.CompactView = True
        Else
            panel1.CompactView = False
        End If
    End Sub

    Private Sub panel1_TitleClick(ByVal sender As Object, ByVal e As EventArgs) Handles panel1.TitleClick
        panel1.CompactView = Not panel1.CompactView
    End Sub
End Class
