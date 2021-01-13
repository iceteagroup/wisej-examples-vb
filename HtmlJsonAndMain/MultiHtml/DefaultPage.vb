Imports System
Imports Wisej.Web

Namespace MultiHtml
    Public Partial Class DefaultPage

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub DefaultPage_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            url.Text = $"Application URL {Application.Url}"
        End Sub

        Private Sub navigateToAdministration_Click(ByVal sender As Object, ByVal e As EventArgs) Handles navigateToAdministration.Click
            Application.Navigate("/Administration")
        End Sub

        Private Sub navigateToAdministrationHtml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles navigateToAdministrationHtml.Click
            Application.Navigate("/Administration.html")
        End Sub

        Private Sub navigateToStatistics_Click(ByVal sender As Object, ByVal e As EventArgs) Handles navigateToStatistics.Click
            Application.Navigate("/Statistics")
        End Sub

        Private Sub navigateToStatisticsHtml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles navigateToStatisticsHtml.Click
            Application.Navigate("/Statistics.html")
        End Sub

        Private Sub navigateToCustomers_Click(ByVal sender As Object, ByVal e As EventArgs) Handles navigateToCustomers.Click
            Application.Navigate("/Customers")
        End Sub

        Private Sub navigateToCustomersHtml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles navigateToCustomersHtml.Click
            Application.Navigate("/Customers/Default.html")
        End Sub

        Private Sub navigateToSuppliers_Click(ByVal sender As Object, ByVal e As EventArgs) Handles navigateToSuppliers.Click
            Application.Navigate("/Suppliers")
        End Sub

        Private Sub navigateToSuppliersHtml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles navigateToSuppliersHtml.Click
            Application.Navigate("/Suppliers/Default.html")
        End Sub
    End Class
End Namespace
