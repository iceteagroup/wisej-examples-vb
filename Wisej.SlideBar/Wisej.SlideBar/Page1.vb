Imports System
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub slideBar_ScrollAnimationEnd(ByVal sender As Object, ByVal e As EventArgs) Handles slideBar2.ScrollAnimationEnd, slideBar1.ScrollAnimationEnd
        AlertBox.Show("Done scrolling!")
    End Sub

    Private Sub buttonScroll100Px_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonScroll100Px.Click
        slideBar1.ScrollBy(100, 1000)
        slideBar2.ScrollBy(100, 1000)
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadComboWithPictures()
    End Sub

    Private Sub LoadComboWithPictures()
        Dim items = New PictureBox(slideBar1.Controls.Count - 1) {}
        slideBar1.Controls.CopyTo(items, 0)
        comboBox1.DataSource = items
    End Sub

    Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged

        slideBar2.Spacing = Int(numericUpDown1.Value)
        slideBar1.Spacing = slideBar2.Spacing

        'slideBar1.Spacing = CSharpImpl.__Assign(slideBar2.Spacing, numericUpDown1.Value)

    End Sub

    Private Sub buttonScrollIntoView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonScrollIntoView.Click
        Dim tag = CStr(CType(comboBox1.SelectedItem, Control)?.Tag)

        For Each c As Control In slideBar1.Controls

            If Equals(tag, CStr(c.Tag)) Then
                slideBar1.ScrollControlIntoView(c, HorizontalAlignment.Left)
                Exit For
            End If
        Next

        For Each c As Control In slideBar2.Controls

            If Equals(tag, CStr(c.Tag)) Then
                slideBar2.ScrollControlIntoView(c, VerticalAlignment.Top)
                Exit For
            End If
        Next
    End Sub

    Private Sub buttonAddFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAddFirst.Click
        Dim newControl = New PictureBox()
        Dim cloneControl = CType(slideBar1.Controls(slideBar1.Controls.Count - 1), PictureBox)
        newControl.ImageSource = cloneControl.ImageSource
        newControl.SizeMode = cloneControl.SizeMode
        newControl.Size = cloneControl.Size
        slideBar1.Controls.Add(newControl)
        newControl.ScrollControlIntoView()
        newControl = New PictureBox()
        cloneControl = CType(slideBar2.Controls(slideBar2.Controls.Count - 1), PictureBox)
        newControl.ImageSource = cloneControl.ImageSource
        newControl.SizeMode = cloneControl.SizeMode
        newControl.Size = cloneControl.Size
        slideBar2.Controls.Add(newControl)
        newControl.ScrollControlIntoView()
    End Sub

    Private Sub buttonAddLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAddLast.Click
        Dim newControl = New PictureBox()
        Dim cloneControl = CType(slideBar1.Controls(0), PictureBox)
        newControl.ImageSource = cloneControl.ImageSource
        newControl.SizeMode = cloneControl.SizeMode
        newControl.Size = cloneControl.Size
        slideBar1.Controls.Add(newControl)
        newControl.BringToFront()
        newControl.ScrollControlIntoView()
        newControl = New PictureBox()
        cloneControl = CType(slideBar2.Controls(0), PictureBox)
        newControl.ImageSource = cloneControl.ImageSource
        newControl.SizeMode = cloneControl.SizeMode
        newControl.Size = cloneControl.Size
        slideBar2.Controls.Add(newControl)
        newControl.BringToFront()
        newControl.ScrollControlIntoView()
    End Sub

    Private Sub slideBar2_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles slideBar2.Scroll
        label3.Text = e.NewValue.ToString()
    End Sub

    Private Sub slideBar1_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles slideBar1.Scroll
        label2.Text = e.NewValue.ToString()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        AlertBox.Show("Button1 clicked.")
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        AlertBox.Show("Button2 clicked.")
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
        AlertBox.Show("Button3 clicked.")
    End Sub

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class
