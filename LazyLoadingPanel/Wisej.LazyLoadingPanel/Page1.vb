Imports System
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub containerPanel1_LoadPanels(ByVal sender As Object, ByVal e As EventArgs)
        Dim container = CType(sender, ContainerPanel)
        Dim count = container.Controls.Count

        If count < 1000 Then
            ' load 50 at a time.
            For i = 0 To 50 - 1
                Dim newItem = New ItemPanel() With {
                    .ImageSource = "https://placeimg.com/64/64/animals?v=" & i,
                    .Dock = DockStyle.Top,
                    .Title = "Item #" & i + count,
                    .Text = " This is item number " & i + count
                }
                AddHandler newItem.ActionClick, AddressOf itemPanel_Click
                container.Controls.Add(newItem)

                ' docking top is reversed to follow winforms standard behavior.
                container.Controls.SetChildIndex(newItem, 1)

                ' uncomment for live loading
                ' Application.Update(this);
            Next
        End If
    End Sub

    Private Sub itemPanel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim panel = CType(sender, ItemPanel)
        AlertBox.Show($"Action click on {panel.Title}")
    End Sub
End Class
