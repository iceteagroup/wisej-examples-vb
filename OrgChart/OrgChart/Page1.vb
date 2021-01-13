Imports System
Imports Wisej.Web
Imports Wisej.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Page1

    Private data As Object

    Public Sub New()
        InitializeComponent()
        data = New With {
            .name = "Silver Surfer",
            .title = "Department Manager",
            .children = {New With {
                .name = "Spiderman",
                .title = "Senior Engineer"
            }, New With {
                .name = "Daredevil",
                .title = "Junion Associate"
            }}
        }
    End Sub

    <WebMethod>
    Public Function GetOrgChartData() As Object
        Return data
    End Function

    Private Sub widget1_WidgetEvent(ByVal sender As Object, ByVal e As WidgetEventArgs)
        Select Case e.Type
            Case "nodeClick"
                AlertBox.Show("You clicked: " & e.Data)
        End Select
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        data = New With {
            .name = "Superman",
            .title = "Department Manager",
            .children = {New With {
                .name = "Batman",
                .title = "Senior Engineer"
            }}
        }
        widget1.Call("reload")
    End Sub
End Class
