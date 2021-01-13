Imports System
Imports Wisej.Web

Namespace EditorsChoice
    Public Partial Class Window1


        Public Sub New()
            InitializeComponent()
        End Sub
        ' previous text
        Private prevText As String = ""

        Private Sub Window1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' set defaults
            cbLiveSync.Checked = True
            ckEditor1.Text = "Hello"
            timer1.Interval = 50
            timer1.Start()
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
            ' sync if text has changed
            If cbLiveSync.Checked AndAlso Not Equals(ckEditor1.Text, prevText) Then
                ckEditor2.Text = ckEditor1.Text
                Tinyeditor1.Text = ckEditor1.Text
                tinyMCE1.Text = ckEditor1.Text
                prevText = ckEditor1.Text
            End If
        End Sub

        Private Sub ckEditor1_TextChanged(sender As Object, e As EventArgs) Handles ckEditor1.TextChanged

        End Sub
    End Class
End Namespace
