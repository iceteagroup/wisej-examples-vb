Imports System
Imports System.IO
Imports Wisej.Web
Imports Wisej.Web.Ext.RibbonBar

Partial Public Class Window1

    Public Sub New()
        InitializeComponent()
        ribbonBarItemCheckBox1.Checked = True
        AddHandler RibbonBar.MenuButtonItemClick, AddressOf RibbonBar_MenuButtonItemClick
        ribbonBarItemComboBox1.Items = New String() {"One", "Two", "Three"}
        ribbonBarItemComboBox1.Value = "One"
        ribbonBarItemTextBox2.Value = "Text2"
    End Sub

    Private Sub RibbonBar_MenuButtonItemClick(ByVal sender As Object, ByVal e As RibbonBarMenuItemEventArgs)
        Dim button = e.Item
        AlertBox.Show(button.ToString() & " => " & e.Item.ToString())
    End Sub

    Private Sub ribbonBar_ItemClick(ByVal sender As Object, ByVal e As RibbonBarItemEventArgs) Handles ribbonBar.ItemClick
        AlertBox.Show(e.Item.ToString(), showProgressBar:=True)
    End Sub

    Private Sub themePicker1_ThemeClicked(ByVal sender As Object, ByVal e As EventArgs) Handles themePicker1.ThemeClicked
        AlertBox.Show("Theme changed.", showProgressBar:=False)
        Application.LoadTheme(Path.GetFileNameWithoutExtension(themePicker1.SelectedTheme))
    End Sub

    Private Sub ribbonBar_GroupClick(ByVal sender As Object, ByVal e As RibbonBarGroupEventArgs) Handles ribbonBar.GroupClick
        AlertBox.Show(e.Group.ToString(), showProgressBar:=True)
    End Sub

    Private Sub ribbonBar_AppButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonBar.AppButtonClick
        AlertBox.Show("App Button Clicked")
    End Sub

    Private Sub ribbonBar_ToolClick(ByVal sender As Object, ByVal e As ToolClickEventArgs) Handles ribbonBar.ToolClick
        AlertBox.Show("Tool Click: " & e.Tool.Name)
    End Sub
End Class
