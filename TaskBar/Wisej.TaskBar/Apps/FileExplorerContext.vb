Imports System.ComponentModel
Imports System.IO
Imports Wisej.TaskBar.Wisej.TaskBar.Models

Namespace Wisej.TaskBar.Apps
    Public Class FileExplorerContext
        Inherits BaseContext

        Private _items As BindingList(Of Models.Item) = New BindingList(Of Item)


        Public Property Items() As BindingList(Of Models.Item)
            Get
                Return Me._items
            End Get
            Set(value As BindingList(Of Models.Item))
                Me._items = value
            End Set
        End Property

        Private _currentPath As String
        Public Property CurrentPath As String
            Get
                Return Me._currentPath
            End Get
            Set(value As String)
                Me._currentPath = value
                OnPropertyChanged("CurrentPath")
            End Set
        End Property


        Public Sub New(path As String)
            CurrentPath = path
            LoadAllItem()
        End Sub

        Public Sub LoadAllItem()
            Try
                Items.Clear()

                Dim directories = Directory.GetDirectories(CurrentPath)
                Dim files = Directory.GetFiles(CurrentPath)

                For Each directory In directories
                    Dim currentDirectory = New DirectoryInfo(directory)

                    Items.Add(New Item(
                        vbNull,
                        Guid.NewGuid().ToString(),
                        currentDirectory.Name,
                        Models.ItemType.Folder,
                        currentDirectory.FullName,
                        ""
                    ))

                Next

                For Each file In files
                    Dim currentFile = New FileInfo(file)
                    Items.Add(New Item(
                        currentFile.Extension,
                        Guid.NewGuid().ToString(),
                        currentFile.Name,
                        Models.ItemType.File,
                        currentFile.FullName,
                        If(currentFile.Length < 1000, String.Format("{0:0.00}", currentFile.Length) + "o", If(currentFile.Length < 1000000, String.Format("{0:0.00}", currentFile.Length / 1000) + "Ko", String.Format("{0:0.00}", currentFile.Length / 1000000) + "Mo"))
                    ))
                Next


            Catch ex As Exception
                AlertBox.Show(ex.Message, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace





