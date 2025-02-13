Imports System.ComponentModel
Imports Wisej.Web

Public Class VdsViewer
    Inherits Widget

    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Overrides Property InitScript As String
        Get
            Return GetResourceString("Wisej.SAP3DViewer.JavaScript.Init.js")
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Overrides ReadOnly Property Packages As List(Of Package)
        Get

            If MyBase.Packages.Count = 0 Then
                MyBase.Packages.Add(New Package() With {
                    .Name = "Polyfill",
                    .Source = "https://cdn.jsdelivr.net/npm/promise-polyfill@8/dist/polyfill.min.js"
                })
                MyBase.Packages.Add(New Package() With {
                    .Name = "Loco.js",
                    .Source = "JavaScript\Loco.js"
                })
                MyBase.Packages.Add(New Package() With {
                    .Name = "DVL.js",
                    .Source = "JavaScript\lib\dvl_asm.js"
                })
            End If

            Return MyBase.Packages
        End Get
    End Property
End Class
