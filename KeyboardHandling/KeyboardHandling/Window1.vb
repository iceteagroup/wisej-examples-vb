Imports Wisej.Web

Partial Public Class Window1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub textBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        label2.Text = e.KeyChar.ToString()
    End Sub
End Class
