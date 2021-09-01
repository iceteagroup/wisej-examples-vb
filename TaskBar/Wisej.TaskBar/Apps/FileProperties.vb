Imports System
Imports System.IO
Imports Wisej.Web

Public Class FileProperties
    Private CurrentFileInfo As FileInfo
    Private CurrentPath As String

    Public Sub New(item As Wisej.TaskBar.Models.Item)

        InitializeComponent()

        Me.CurrentPath = item.Path
        Me.CurrentFileInfo = New FileInfo(item.Path)

        LoadData()

    End Sub

    Private Sub LoadData()
        Try
            If Not (CurrentFileInfo.Exists) Then
                Throw New Exception($"Path {CurrentPath} not found")
            End If

            txtbxPath.Text = CurrentFileInfo.FullName
            lblSize.Text = If(CurrentFileInfo.Length < 1000, String.Format("{0:0.00}", CurrentFileInfo.Length) + " octets", If(CurrentFileInfo.Length < 1000000, String.Format("{0:0.00}", CurrentFileInfo.Length / (1024)) + " Ko", String.Format("{0:0.00}", CurrentFileInfo.Length / (1024 * 1024)) + " Mo"))
            lblCreationDate.Text = CurrentFileInfo.CreationTime.ToLongDateString()
            lblPath.Text = CurrentFileInfo.FullName

            lblType.Text = CurrentFileInfo.Extension
            lblType2.Text = CurrentFileInfo.Extension.ToUpper()
        Catch ex As Exception
            AlertBox.Show(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub
End Class
