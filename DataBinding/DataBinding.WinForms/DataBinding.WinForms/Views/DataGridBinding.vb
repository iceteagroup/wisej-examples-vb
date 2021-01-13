Imports System.Windows.Forms
Imports DataBinding.Model

Namespace DataBinding.Views
    Public Partial Class DataGridBinding


        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub DataGridBinding_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            vendorListBindingSource.DataSource = VendorList.GetVendorList()
        End Sub
    End Class
End Namespace
