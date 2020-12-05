Imports System
Imports Wisej.Web

Partial Public Class DataGridViewJSONColumnEditor
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Property Text As String
        Get
            Return New With {
                .Value1 = textBox1.Text,
                .Value2 = textBox2.Text,
                .Value3 = textBox3.Text
            }.ToJSON(False)
        End Get
        Set(ByVal value As String)
            Dim json = System.JSON.Parse(value)
            textBox1.Text = json.Value1
            textBox2.Text = json.Value2
            textBox3.Text = json.Value3
        End Set
    End Property
End Class
