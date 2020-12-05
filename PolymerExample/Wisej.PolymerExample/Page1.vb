Imports System
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        paperSlider1.Value += 1
        paperSlider1.Update()
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        paperSlider1.Value -= 1
        paperSlider1.Update()
    End Sub

    Private Sub paperCheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles paperCheckBox1.CheckedChanged
        label4.Text = paperCheckBox1.Checked.ToString()
    End Sub

    Private Sub paperSlider1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles paperSlider1.ValueChanged
        label3.Text = paperSlider1.Value.ToString()
        paperProgress1.Value = paperSlider1.Value
    End Sub

    Private Sub paperButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles paperButton1.Click
        AlertBox.Show("Thank you!", alignment:=Drawing.ContentAlignment.MiddleCenter)
    End Sub

    Private Sub paperRadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles paperRadioButton1.CheckedChanged
        paperRadioButton2.Checked = Not paperRadioButton1.Checked
    End Sub

    Private Sub paperRadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles paperRadioButton2.CheckedChanged
        paperRadioButton1.Checked = Not paperRadioButton2.Checked
    End Sub

    Private Sub paperRadioGroup1_SelectedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles paperRadioGroup1.SelectedChanged
        AlertBox.Show(paperRadioGroup1.Selected, alignment:=Drawing.ContentAlignment.MiddleCenter, icon:=MessageBoxIcon.Information)
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        googleChart1.Type = "treemap"
        googleChart1.Options.showScale = True
        googleChart1.Options.maxPostDepth = 2
        googleChart1.Data = New Object() {New Object() {"Location", "Parent", "Value"}, New Object() {"Global", Nothing, 0}, New Object() {"America", "Global", 0}, New Object() {"Europe", "Global", 0}, New Object() {"Asia", "Global", 0}, New Object() {"Australia", "Global", 0}, New Object() {"Africa", "Global", 0}, New Object() {"Brazil", "America", 11}, New Object() {"USA", "America", 52}, New Object() {"Mexico", "America", 24}, New Object() {"Canada", "America", 16}, New Object() {"France", "Europe", 42}, New Object() {"Germany", "Europe", 31}, New Object() {"Sweden", "Europe", 22}, New Object() {"Italy", "Europe", 17}, New Object() {"UK", "Europe", 21}, New Object() {"China", "Asia", 36}, New Object() {"Japan", "Asia", 20}, New Object() {"India", "Asia", 40}, New Object() {"Laos", "Asia", 4}, New Object() {"Mongolia", "Asia", 1}, New Object() {"Israel", "Asia", 12}, New Object() {"Iran", "Asia", 18}, New Object() {"Pakistan", "Asia", 11}, New Object() {"Egypt", "Africa", 2}, New Object() {"S. Africa", "Africa", 30}, New Object() {"Sudan", "Africa", 12}, New Object() {"Congo", "Africa", 10}, New Object() {"Zaire", "Africa", 8}}
    End Sub

    Private Sub googleChart1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles googleChart1.SelectionChanged
        Dim selection = googleChart1.Selection
        If selection IsNot Nothing AndAlso selection.Length > 0 Then AlertBox.Show(googleChart1.Data(selection(0).row + 1)(0), alignment:=Drawing.ContentAlignment.TopCenter)
    End Sub
End Class
