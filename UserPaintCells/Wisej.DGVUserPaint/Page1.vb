Imports System
Imports System.Linq
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Page1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        dataGridView1.RowCount = 10

        For Each row In dataGridView1.Rows
            row(0).Value = "1,2,3,4,5,6,7,8,9,10"
            row(1).Value = "Line"
        Next
    End Sub

    Private Sub dataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dataGridView1.CellValueChanged
        If e.RowIndex > -1 Then

            If e.ColumnIndex = 0 OrElse e.ColumnIndex = 1 Then
                dataGridView1(2, e.RowIndex).Update()
            End If
        End If
    End Sub

    Private Sub dataGridView1_CellPaint(ByVal sender As Object, ByVal e As DataGridViewCellPaintEventArgs) Handles dataGridView1.CellPaint
        If e.ColumnIndex = 2 AndAlso e.RowIndex > -1 Then
            ' e.Graphics.FillRectangle(Brushes.White, e.ClipRectangle);

            Dim text = TryCast(dataGridView1(0, e.RowIndex).Value, String)

            If Not Equals(text, Nothing) Then
                Dim values = text.Split(","c).[Select](Function(n) Convert.ToInt32(n)).ToArray()

                'Dim charType = CType([Enum].Parse(GetType(SeriesChartType), CStr(dataGridView1(1, e.RowIndex).Value)), SeriesChartType)
                'DrawChart(e.Graphics, e.ClipRectangle, values, charType)
                DrawChart(e.Graphics, e.ClipRectangle, values)
            End If
        End If
    End Sub

    Private Sub DrawChart(ByVal g As Graphics, ByVal rect As Rectangle, ByVal values As Integer())

        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim cx As Integer = rect.Width
        Dim cy As Integer = rect.Height
        Dim brush As SolidBrush = New SolidBrush(Color.Blue)
        Dim pen As Pen = New Pen(brush)
        pen.Width = 10.0!
        Dim scale As Single = (CType(cy, Single) / CType(cx, Single))
        Dim x As Single = 0
        Dim i As Integer = 0
        Do While (i < values.Length)
            x = values(i)
            x = (x + 7)
            g.DrawLine(pen, 0, ((cx - x) _
                            * scale), (cx - x), (cy _
                            * (scale * 2)))
            i = (i + 1)
        Loop

    End Sub
End Class
