Imports Wisej.Web
Imports DataBinding.Model
Imports DataBinding.DataBinding.Model

Namespace DataBinding.Views
    Public Partial Class DataGridBinding

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub DataGridBinding_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            ' Bind ComboBox list datasources first

            statesBindingSource.EnumToDataSource(GetType(States))
            colState.DataSource = statesBindingSource
            colState.DisplayMember = "Description"
            colState.ValueMember = "Key"
            vendorListBindingSource.DataSource = VendorList.GetVendorList()
        End Sub
    End Class
End Namespace
