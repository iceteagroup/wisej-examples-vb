Imports System.ComponentModel

Namespace DataBinding.Model
    Public Class VendorList
        Inherits BindingList(Of Vendor)

        Private Shared _instance As VendorList

        Public Shared Function GetVendorList() As VendorList
            If _instance Is Nothing Then BuildInstance()
            Return _instance
        End Function

        Public Shared Function Contains(ByVal vendorId As Integer) As Boolean
            For Each vendor In _instance
                If vendor.VendorId = vendorId Then Return True
            Next

            Return False
        End Function

        Public Shared Function GetVendor(ByVal vendorId As Integer) As Vendor
            For Each vendor In _instance
                If vendor.VendorId = vendorId Then Return vendor
            Next

            Return Nothing
        End Function

        Private Shared Sub BuildInstance()
            _instance = New VendorList()
            Call New Vendor With {
                .FirstName = "Ella",
                .LastName = "Fitzgerald",
                .Town = "Newport News",
                .State = States.VA
            }.Save()
            Call New Vendor With {
                .FirstName = "Louis",
                .LastName = "Armstrong",
                .Town = "New Orleans",
                .State = States.LA
            }.Save()
        End Sub
    End Class
End Namespace
