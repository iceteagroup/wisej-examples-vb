Imports System
Imports System.Drawing
Imports Wisej.Web

Partial Public Class Page1


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub tagTextBox1_TagAdded(ByVal sender As Object, ByVal e As TagTextBoxEventArgs) Handles tagTextBox1.TagAdded
        AlertBox.Show($"Added: {e.Text}")
    End Sub

    Private Sub tagTextBox1_TagRemoved(ByVal sender As Object, ByVal e As TagTextBoxEventArgs) Handles tagTextBox1.TagRemoved
        AlertBox.Show($"Removed: {e.Text}", icon:=MessageBoxIcon.Warning)
    End Sub

    Private Sub tagTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tagTextBox1.TextChanged
        label2.Text = tagTextBox1.Text
    End Sub

    Private Sub tagTextBox1_TagRejected(ByVal sender As Object, ByVal e As TagTextBoxEventArgs) Handles tagTextBox1.TagRejected
        AlertBox.Show($"Rejected: {e.Text}", icon:=MessageBoxIcon.Error)
    End Sub

    Private Sub tagTextBox1_TagSelected(ByVal sender As Object, ByVal e As TagTextBoxEventArgs) Handles tagTextBox1.TagSelected
        AlertBox.Show($"Selected: {e.Text}")
    End Sub

    Private Sub panel1_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles panel1.SizeChanged
        If checkBox1.Checked Then panel1.CenterToParent()
    End Sub

    Private Sub tagTextBox1_TagRender(ByVal sender As Object, ByVal e As TagTextBoxRenderEventArgs) Handles tagTextBox1.TagRender
        Select Case e.Text
            Case "Arizona"
                e.BackColor = Color.Beige
            Case "Florida"
                e.BackColor = Color.LightGreen
            Case "Alaska"
                e.Html = "<b>" & e.Text & "</b>"
            Case "California"
                e.Html = "<u>" & e.Text & "</u>"
            Case "Georgia"
                e.Html = "<img src='Images/fullstar.png' style='display:inline-block;float:left;padding-right:5px' width=16/>" & e.Text
        End Select
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
        If checkBox1.Checked Then panel1.CenterToParent()
    End Sub
End Class
