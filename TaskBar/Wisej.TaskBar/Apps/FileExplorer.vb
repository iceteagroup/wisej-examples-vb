Imports System
Imports System.IO

Public Class FileExplorer


    Private _uriBackup As String
    Private _context As Wisej.TaskBar.Apps.FileExplorerContext


    Public Property UriBackup() As String
        Get
            Return Me._uriBackup
        End Get
        Set(value As String)
            Me._uriBackup = value
        End Set
    End Property

    Public Property Context() As Wisej.TaskBar.Apps.FileExplorerContext
        Get
            Return Me._context
        End Get
        Set(value As Wisej.TaskBar.Apps.FileExplorerContext)
            Me._context = value
        End Set
    End Property
    Public Sub New(path As String)

        InitializeComponent()
        Context = New Wisej.TaskBar.Apps.FileExplorerContext(path)
        txtbxCurrentPath.DataBindings.Add(New Binding("Text", Context, "CurrentPath"))
        UriBackup = path
        RefreshView()


    End Sub

    Private Sub RefreshView()
        list.Items.Clear()
        For Each item In Context.Items
            Dim listViewItem = New ListViewItem()
            If (item.Type = Wisej.TaskBar.Models.ItemType.Folder) Then
                Dim contextMenus = New List(Of MenuItem)

                Dim openInWindowMenu = New MenuItem
                With openInWindowMenu
                    .Text = "Open in new window"
                    .Tag = New Tuple(Of String, Wisej.TaskBar.Models.Item)("open-new-window", item)
                End With
                contextMenus.Add(openInWindowMenu)

                Dim openMenu = New MenuItem
                With openMenu
                    .Text = "Open"
                    .Tag = New Tuple(Of String, Wisej.TaskBar.Models.Item)("open", item)
                End With
                contextMenus.Add(openMenu)

                Dim propertyMenu = New MenuItem
                With propertyMenu
                    .Text = "Properties"
                    .Tag = New Tuple(Of String, Wisej.TaskBar.Models.Item)("properties", item)
                End With
                contextMenus.Add(propertyMenu)

                listViewItem.ContextMenu = New ContextMenu(contextMenus.ToArray())

            Else
                Dim contextMenus = New List(Of MenuItem)

                Dim propertyMenu = New MenuItem
                With propertyMenu
                    .Text = "Properties"
                    .Tag = New Tuple(Of String, Wisej.TaskBar.Models.Item)("details", item)
                End With
                contextMenus.Add(propertyMenu)

                listViewItem.ContextMenu = New ContextMenu(contextMenus.ToArray())

            End If
            AddHandler listViewItem.ContextMenu.MenuItemClicked, Async Sub(sender As Object, e As MenuItemEventArgs)
                                                                     Dim data = TryCast(e.MenuItem.Tag, Tuple(Of String, Wisej.TaskBar.Models.Item))
                                                                     If data.Item1 = "open" Then
                                                                         Context.CurrentPath = data.Item2.Path
                                                                         RefreshView()
                                                                         UriBackup = Context.CurrentPath
                                                                     ElseIf data.Item1 = "open-new-window" Then
                                                                         Dim window = New FileExplorer(data.Item2.Path)
                                                                         window.Show()
                                                                     ElseIf data.Item1 = "properties" Then
                                                                         Dim window = New FolderProperties(data.Item2)
                                                                         Await window.ShowDialogAsync()
                                                                     ElseIf data.Item1 = "details" Then
                                                                         Dim window = New FileProperties(data.Item2)
                                                                         Await window.ShowDialogAsync()
                                                                     End If
                                                                 End Sub


            If item.Type = Wisej.TaskBar.Models.ItemType.Folder Then
                listViewItem.ImageSource = "/Resources/icons8_folder_96px.png"
            Else
                listViewItem.ImageSource = "/Resources/icons8_file_96px.png"
            End If
            listViewItem.ContextMenu.Tag = item
            listViewItem.Tag = item
            listViewItem.Text = item.Name
            listViewItem.ToolTipText = item.Name
            listViewItem.SubItems.Add(item.Size)

            list.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnParentFolder.Click
        Try
            Dim directory = New DirectoryInfo(txtbxCurrentPath.Text)
            If directory.Parent.Equals(Nothing) Then
                Throw New Exception(txtbxCurrentPath.Text + " doesn't exist")
            End If

            Context.CurrentPath = directory.Parent.FullName

            Context.LoadAllItem()

            RefreshView()
        Catch ex As Exception
            AlertBox.Show(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub list_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles list.ItemDoubleClick

        Try
            If (DirectCast(e.Item.Tag, Wisej.TaskBar.Models.Item)).Type = Wisej.TaskBar.Models.ItemType.File Or (DirectCast(e.Item.Tag, Wisej.TaskBar.Models.Item)).Type = Wisej.TaskBar.Models.ItemType.Shortcut Then
                Exit Sub
            End If
            Context.CurrentPath = (DirectCast(e.Item.Tag, Wisej.TaskBar.Models.Item)).Path
            Context.LoadAllItem()
            RefreshView()

        Catch ex As Exception
            AlertBox.Show(ex.Message, MessageBoxIcon.Error)
            Context.CurrentPath = UriBackup

        End Try
    End Sub

    Private Sub list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list.SelectedIndexChanged

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            Dim directory = New DirectoryInfo(txtbxCurrentPath.Text)
            If Not (directory.Exists) Then
                Throw New Exception(txtbxCurrentPath.Text + " doesn't exist")
            End If

            Context.CurrentPath = directory.FullName
            Context.LoadAllItem()

            RefreshView()
        Catch ex As Exception
            AlertBox.Show(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
