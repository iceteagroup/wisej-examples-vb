Imports System
Imports Wisej.Web

Namespace Views
    Partial Public Class ViewBase

        Public Sub New()
            InitializeComponent()
        End Sub


        ''' <summary>
        ''' Title.
        ''' </summary>
        Public Property Title As String
            Get
                Return labelTitle.Text
            End Get
            Set(ByVal value As String)
                labelTitle.Text = value
            End Set
        End Property

        Private Sub buttonClose_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dispose()
        End Sub
    End Class
End Namespace
