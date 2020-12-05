Imports Wisej.Web

Partial Public Class StatsPanel

    Private ReadOnly _supplier As IDataSupplier

    Public Sub New(ByVal supplier As IDataSupplier)
        InitializeComponent()
        _supplier = supplier
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        _supplier.Fill(Me)
    End Sub
End Class
