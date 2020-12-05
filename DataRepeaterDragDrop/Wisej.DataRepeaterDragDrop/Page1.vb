Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub dataRepeater1_ItemSelected(ByVal sender As Object, ByVal e As DataRepeaterItemEventArgs) Handles dataRepeater1.ItemSelected
        button1.Enabled = e.DataRepeaterItem.ItemIndex > 0
        button2.Enabled = e.DataRepeaterItem.ItemIndex < dataRepeater1.ItemCount - 1
    End Sub

    Private Sub dataRepeater1_DragStart(ByVal sender As Object, ByVal e As EventArgs) Handles dataRepeater1.DragStart
        Dim item = dataRepeater1.CurrentItem
        Dim data = CType(dataRepeater1.DataSource, BindingList(Of Model))
        dataRepeater1.DoDragDrop(data(item.ItemIndex), DragDropEffects.Move)
    End Sub

    Private Sub dataRepeater1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles dataRepeater1.DragEnter
        If e.Data.GetDataPresent(GetType(Model)) Then
            e.Effect = DragDropEffects.Move
            e.ImageSource = "data-item.png"
            e.ImageSize = New Size(32, 32)
        End If
    End Sub

    Private Sub dataRepeater1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles dataRepeater1.DragDrop
        Dim data = CType(dataRepeater1.DataSource, BindingList(Of Model))
        Dim item = CType(e.Data.GetData(GetType(Model)), Model)
        Dim target = TryCast(e.DropTarget, DataRepeaterItem)

        If target IsNot Nothing Then
            MoveDataItem(data.IndexOf(item), target.ItemIndex)
        Else
            MoveDataItem(data.IndexOf(item), data.Count - 1)
        End If
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim data = New BindingList(Of Model)()

        For i = 0 To 100 - 1
            data.Add(New Model() With {
                .ID = i,
                .Name = $"Item #{i}"
            })
        Next

        dataRepeater1.DataSource = data
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim index = dataRepeater1.CurrentItemIndex
        MoveDataItem(index, index - 1)
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        Dim index = dataRepeater1.CurrentItemIndex
        MoveDataItem(index, index + 1)
    End Sub

    Private Sub MoveDataItem(ByVal index As Integer, ByVal destination As Integer)
        If index < 0 OrElse index = destination Then Return
        Dim data = CType(dataRepeater1.DataSource, BindingList(Of Model))
        Dim item = data(index)
        data.RemoveAt(index)
        data.Insert(destination, item)
        dataRepeater1.CurrentItemIndex = destination
    End Sub
End Class
