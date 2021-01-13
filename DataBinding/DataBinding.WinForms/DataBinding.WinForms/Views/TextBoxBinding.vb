Imports DataBinding.Model
Imports System.Windows.Forms

Namespace DataBinding.Views
    Public Partial Class TextBoxBinding

        Private _vendor As Vendor

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub TextBoxBinding_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            GetNewVendor()
        End Sub

        Private Sub newButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newButton.Click
            GetNewVendor()
        End Sub

        Private Sub saveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveButton.Click
            _vendor.Save()
        End Sub

        Private Sub removeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles removeButton.Click
            _vendor.Delete()
        End Sub

        Private Sub closeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles closeButton.Click
            Close()
        End Sub

        Private Sub GetNewVendor()
            _vendor = New Vendor()
            vendorBindingSource.DataSource = _vendor
        End Sub
    End Class
End Namespace
