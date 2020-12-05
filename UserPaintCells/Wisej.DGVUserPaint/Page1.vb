Imports System
Imports System.Linq
Imports System.Drawing
Imports System.Web.UI.DataVisualization.Charting
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
                Dim charType = CType([Enum].Parse(GetType(SeriesChartType), CStr(dataGridView1(1, e.RowIndex).Value)), SeriesChartType)
                DrawChart(e.Graphics, e.ClipRectangle, values, charType)
            End If
        End If
    End Sub

    Private Sub DrawChart(ByVal g As Graphics, ByVal rect As Rectangle, ByVal values As Integer(), ByVal chartType As SeriesChartType)
        Using chart = New Chart()
            rect.Inflate(-10, -10)
            chart.Width = rect.Width - 2
            chart.Height = rect.Height - 2
            chart.BackColor = Color.Transparent
            Dim ca = New ChartArea()
            ca.BackColor = Color.Transparent
            ca.Position = New ElementPosition(1, 1, 99, 99)
            ca.AxisY.LineWidth = 0
            ca.AxisY.MajorGrid.LineWidth = 0
            ca.AxisY.LabelStyle.Enabled = False
            ca.AxisY.MajorTickMark.Enabled = False
            ca.AxisY.MinorTickMark.Enabled = False
            ca.AxisY.IsMarginVisible = False
            ca.AxisX.LineWidth = 0
            ca.AxisX.MajorGrid.LineWidth = 0
            ca.AxisX.LabelStyle.Enabled = False
            ca.AxisX.MajorTickMark.Enabled = False
            ca.AxisX.MinorTickMark.Enabled = False
            ca.AxisX.LineDashStyle = ChartDashStyle.NotSet
            ca.AxisX.IsMarginVisible = False
            chart.ChartAreas.Add(ca)
            Dim s = New Series()
            s.BorderWidth = 2
            s.ChartType = chartType

            For i As Integer = 0 To values.Length - 1
                Dim p As DataPoint = New DataPoint()
                p.XValue = i
                p.YValues = New Double() {values(i)}
                s.Points.Add(p)
            Next

            chart.Series.Add(s)
            chart.Paint(g, rect)
        End Using
    End Sub
End Class
