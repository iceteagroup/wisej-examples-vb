Imports System.Windows.Forms
Imports DataBinding.Model

Namespace DataBinding.Views
    Public Partial Class AllBindings


        Private _vendor As Vendor

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub DataGridBinding_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            vendorListBindingSource.DataSource = VendorList.GetVendorList()
            dataGridView.Rows(0).Selected = True
        End Sub

        Private Sub newButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newButton.Click
            ClearSelectedRows()
            GetNewVendor()
        End Sub

        Private Sub ClearSelectedRows()
            For index = 0 To dataGridView.RowCount - 1
                dataGridView.Rows(index).Selected = False
            Next
        End Sub

        Private Sub saveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveButton.Click
            Dim isNew = _vendor.IsNew
            _vendor.Save()
            If isNew Then dataGridView.Rows(dataGridView.Rows.Count - 1).Selected = True
        End Sub

        Private Sub removeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles removeButton.Click
            Dim deletedRowIndex = dataGridView.CurrentRow.Index
            _vendor.Delete()

            If dataGridView.RowCount > deletedRowIndex Then
                dataGridView.Rows(deletedRowIndex).Selected = True
            End If
        End Sub

        Private Sub GetNewVendor()
            _vendor = New Vendor()
            vendorBindingSource.DataSource = _vendor
        End Sub

        Private Sub dataGridView_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dataGridView.SelectionChanged
            BindLine()
        End Sub

        Private Sub BindLine()
            If dataGridView.SelectedRows.Count > 0 Then
                Dim id = CInt(dataGridView.SelectedRows(0).Cells(0).Value)
                _vendor = VendorList.GetVendor(id)
                vendorBindingSource.DataSource = _vendor
            End If
        End Sub
    End Class
End Namespace
