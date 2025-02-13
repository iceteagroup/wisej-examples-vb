Imports System
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim table = dataGridView1

        For i = 0 To 100 - 1
            table.Rows.Add("Name " & i, "Last Name " & i, Date.Now.AddYears(-30 + i).AddDays(i), i, i Mod 2 = 1)
        Next
    End Sub
End Class
