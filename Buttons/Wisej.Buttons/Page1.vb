Imports Wisej.Web

Namespace Wisej.Buttons
    Public Partial Class Page1
        Inherits Page

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button11_Click(sender As Object, e As System.EventArgs) Handles button11.Click
            If (Me.button11.ImageKey <> Me.imageList1.Images(1).Name) Then
                Me.button11.ImageKey = Me.imageList1.Images(1).Name
            Else
                Me.button11.ImageKey = Me.imageList1.Images(0).Name
            End If
        End Sub
    End Class
End Namespace
