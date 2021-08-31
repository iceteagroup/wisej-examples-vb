Imports System
Imports Wisej.Web



Public Class Page1

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnJQueryKnob_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnJQueryKnob.Click
            Dim window = New frmJQueryKnob()
            window.Show()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim window = New frmBubbles()
            window.Show()
        End Sub

        Private Sub btnJustGage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnJustGage.Click
            Call New frmJustGaje().Show()
        End Sub

        Private Sub btnCoolClock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCoolClock.Click
            Call New frmCoolClock().Show()
        End Sub

        Private Sub btnCountUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCountUp.Click
            Dim window = New frmCountUp()
            window.Show()
        End Sub
    End Class
