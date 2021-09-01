Imports System
Imports System.IO
Imports Wisej.Web

Public Class FolderProperties
    Private CurrentDirectory As DirectoryInfo

    Public Sub New(folder As Wisej.TaskBar.Models.Item)

        InitializeComponent()
        CurrentDirectory = New DirectoryInfo(folder.Path)

        InitializeData()
        LoadFolderSize()

    End Sub

    Private Sub LoadFolderSize()
        Application.StartTask(Sub()
                                  Try
                                      Dim files = CurrentDirectory.GetFiles("*.*", SearchOption.AllDirectories)
                                      Dim size As Double = 0
                                      For Each file In files
                                          size = size + file.Length
                                          lblSize.Text = If(size < 1000, String.Format("{0:0.00}", size) + " octets", If(size < 1000000, String.Format("{0:0.00}", size / (1024)) + " Ko", String.Format("{0:0.00}", size / (1024 * 1024)) + " Mo"))
                                          Application.Update(Me)
                                      Next
                                  Catch ex As Exception
                                      AlertBox.Show(ex.Message, MessageBoxIcon.Error)
                                  End Try

                              End Sub)
    End Sub

    Private Sub InitializeData()
        lblCreationDate.Text = CurrentDirectory.CreationTime.ToLongDateString()
        txtbxPath.Text = CurrentDirectory.FullName
        lblPath.Text = CurrentDirectory.FullName
    End Sub
End Class
