Imports System
Imports Wisej.Web

Partial Public Class Page1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim grid = dataGridView1
        grid.RowCount = 10

        For i = 0 To dataGridView1.RowCount - 1
            ' set json string.
            grid(Column2, i).Value = New With {
                .Value1 = $"Row {i}",
                .Value2 = $"Col {Column2.Name}",
                .Value3 = $"{i * 30}"
            }.ToJSON(False)

            Dim panel = New Panel() With {
                .Dock = DockStyle.Fill
            }
            panel.Controls.Add(New Button() With {
                .Dock = DockStyle.Fill,
                .Text = $"{i}"
            })
            grid(Column0, i).Control = panel
        Next
    End Sub
End Class
