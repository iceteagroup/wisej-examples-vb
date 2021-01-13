Imports System
Imports DataBinding.Model
Imports DataBinding.Views
Imports Wisej.Web

Namespace DataBinding
    Public Partial Class MainPage

        Public Sub New()
            InitializeComponent()
            VendorList.GetVendorList()
        End Sub

        Private Sub textBoxBindingButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles textBoxBindingButton.Click
            Using textBoxBinding = New TextBoxBinding()
                Dim result = textBoxBinding.ShowDialog()
            End Using
        End Sub

        Private Sub dataGridBindingButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles dataGridBindingButton.Click
            Using dataGridBinding = New DataGridBinding()
                Dim result = dataGridBinding.ShowDialog()
            End Using
        End Sub

        Private Sub allBindingsButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles allBindingsButton.Click
            Using allBindings = New AllBindings()
                Dim result = allBindings.ShowDialog()
            End Using
        End Sub
    End Class
End Namespace
