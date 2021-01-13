Imports System
Imports Wisej.Web

Partial Public Class Window3

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub comboBox1_ToolClick(ByVal sender As Object, ByVal e As ToolClickEventArgs)
        AlertBox.Show("Not implemented in this sample.")
    End Sub

    Private Sub Window3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        dataGridView1.Rows.Add(1, "Joe", "Smith", False, "IT")
        dataGridView1.Rows.Add(2, "Jack", "Jones", True, "Finance")
        dataGridView1.Rows.Add(3, "Paul", "Meyer", True, "Finance")
        dataGridView1.Rows.Add(4, "Susan", "Miller", False, "Administration")
        dataGridView1.Rows.Add(5, "Peter", "McDonald", True, "IT")
        dataGridView1.Rows.Add(6, "Monica", "Di Marco", True, "Finance")
        dataGridView1.Rows.Add(7, "Oliver", "Stone", True, "Administration")
        dataGridView1.Rows.Add(8, "Jill", "Jackson", False, "Administration")
    End Sub

    Public Sub SortDGVByName()
        dataGridView1.Sort(dataGridView1.Columns("colNAME"), ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub dataGridView1_ToolClick(ByVal sender As Object, ByVal e As ToolClickEventArgs) Handles dataGridView1.ToolClick
        AlertBox.Show("Not implemented in this demo.")
    End Sub
End Class
