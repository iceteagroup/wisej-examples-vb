Imports System
Imports System.Windows.Forms
Imports DataBinding.Model
Imports DataBinding.Views

Namespace DataBinding
    Public Partial Class MainForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
            VendorList.GetVendorList()
        End Sub

        Private Sub textBoxBindingButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using textBoxBinding = New TextBoxBinding()
                Dim result = textBoxBinding.ShowDialog()
            End Using
        End Sub

        Private Sub dataGridBindingButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using dataGridBinding = New DataGridBinding()
                Dim result = dataGridBinding.ShowDialog()
            End Using
        End Sub

        Private Sub allBindingsButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using allBindings = New AllBindings()
                Dim result = allBindings.ShowDialog()
            End Using
        End Sub
    End Class
End Namespace
