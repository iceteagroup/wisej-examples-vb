Imports System
Imports Wisej.Web

Public Class Page1


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnTransform_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTransform.Click
        If txtSequence.Text.Length = 0 Then
            MessageBox.Show("Text area shouldn't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        sequence.UML = txtSequence.Text
    End Sub

    Private Sub cmbTheme_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbTheme.SelectedIndexChanged
        sequence.Theme = cmbTheme.Text
    End Sub

    Private Sub cmbBorderStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbBorderStyle.SelectedIndexChanged
        Dim borderStyle = Wisej.Web.BorderStyle.None

        If [Enum].TryParse(cmbBorderStyle.Text, borderStyle) Then
        End If

        sequence.BorderStyle = borderStyle
    End Sub

    Private Async Sub btnDownload_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDownload.Click
        Dim image = Await sequence.GetImageAsync()
        If image IsNot Nothing Then Call Application.Download(image, "jSeq" & Date.UtcNow.ToString() & ".png")
    End Sub

    Private Async Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
        Dim image = Await sequence.GetImageAsync()
        Dim oFrmPreview As frmPreview = New frmPreview()
        oFrmPreview.pictureBox1.Image = image
        oFrmPreview.Show()
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs)
        cmbBorderStyle.SelectedIndex = 0
        cmbTheme.SelectedIndex = 0
    End Sub
End Class
