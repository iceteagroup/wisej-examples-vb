Imports System
Imports System.Drawing
Imports Wisej.Web
Imports Wisej.Web.Ext.ChartJS

Public Partial Class MainPage
        Inherits Page

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Randomize()
        End Sub

        Private Sub Randomize()
            For Each chart As Ext.ChartJS.ChartJS In flowLayoutPanel1.Controls
                If chart.DataSets.Count = 0 Then chart.DataSets.Add("Data Set")
                CreateRandomData(chart.DataSets(0), 12, 100)
                chart.UpdateData(trackBar.Value)
            Next
        End Sub

        Private Sub CreateColors(ByVal dataSet As DataSet)
            Select Case dataSet.Type
                Case ChartType.Bar
                    Dim barDataSet = CType(dataSet, BarDataSet)
                    barDataSet.BackgroundColor = New Color() {Color.FromArgb(49, 255, 0, 0), Color.FromArgb(58, 102, 255, 0), Color.FromArgb(52, 0, 183, 255), Color.FromArgb(53, 247, 0, 255), Color.FromArgb(52, 191, 123, 63), Color.FromArgb(53, 191, 63, 86), Color.FromArgb(104, 255, 0, 118), Color.FromArgb(237, 130, 237), Color.FromArgb(88, 64, 224, 208), Color.FromArgb(84, 255, 98, 70), Color.FromArgb(60, 41, 69, 70), Color.FromArgb(98, 0, 0, 128)}
                Case ChartType.Doughnut
                    Dim doughnutDataSet = CType(dataSet, DoughnutDataSet)
                    doughnutDataSet.BackgroundColor = New Color() {Color.FromArgb(49, 255, 0, 0), Color.FromArgb(58, 102, 255, 0), Color.FromArgb(52, 0, 183, 255), Color.FromArgb(53, 247, 0, 255), Color.FromArgb(52, 191, 123, 63), Color.FromArgb(53, 191, 63, 86), Color.FromArgb(104, 255, 0, 118), Color.FromArgb(237, 130, 237), Color.FromArgb(88, 64, 224, 208), Color.FromArgb(84, 255, 98, 70), Color.FromArgb(60, 41, 69, 70), Color.FromArgb(98, 0, 0, 128)}
                Case ChartType.Line
                    Dim lineDataSet = CType(dataSet, LineDataSet)
                    lineDataSet.BackgroundColor = Color.FromArgb(72, 79, 191, 63)
                    lineDataSet.BorderColor = Color.Crimson
                Case ChartType.PolarArea
                    Dim polarDataSet = CType(dataSet, PolarAreaDataSet)
                    polarDataSet.BackgroundColor = New Color() {Color.FromArgb(49, 255, 0, 0), Color.FromArgb(58, 102, 255, 0), Color.FromArgb(52, 0, 183, 255), Color.FromArgb(53, 247, 0, 255), Color.FromArgb(52, 191, 123, 63), Color.FromArgb(53, 191, 63, 86), Color.FromArgb(104, 255, 0, 118), Color.FromArgb(237, 130, 237), Color.FromArgb(88, 64, 224, 208), Color.FromArgb(84, 255, 98, 70), Color.FromArgb(60, 41, 69, 70), Color.FromArgb(98, 0, 0, 128)}
                Case ChartType.Radar
                    Dim radarDataSet = CType(dataSet, RadarDataSet)
                    radarDataSet.BackgroundColor = Color.FromArgb(72, 79, 191, 63)
                Case ChartType.Pie
                    Dim pieDataSet = CType(dataSet, PieDataSet)
                    pieDataSet.BackgroundColor = New Color() {Color.FromArgb(49, 255, 0, 0), Color.FromArgb(58, 102, 255, 0), Color.FromArgb(52, 0, 183, 255), Color.FromArgb(53, 247, 0, 255), Color.FromArgb(52, 191, 123, 63), Color.FromArgb(53, 191, 63, 86), Color.FromArgb(104, 255, 0, 118), Color.FromArgb(237, 130, 237), Color.FromArgb(88, 64, 224, 208), Color.FromArgb(84, 255, 98, 70), Color.FromArgb(60, 41, 69, 70), Color.FromArgb(98, 0, 0, 128)}
            End Select
        End Sub

        Private Sub CreateRandomData(ByVal dataSet As DataSet, ByVal count As Integer, ByVal maxValue As Integer)
            Dim data = New Object(count - 1) {}
            Dim random As Random = New Random()

            For i As Integer = 0 To count - 1
                data(i) = random.Next(maxValue)
            Next

            dataSet.Data = data
            CreateColors(dataSet)
        End Sub

        Private Sub ChartsPage_Load(ByVal sender As Object, ByVal e As EventArgs)
            Randomize()
        End Sub

        Private Sub chartJS_ChartClick(ByVal sender As Object, ByVal e As ChartClickEventArgs)
            AlertBox.Show("<br>" & CType(sender, Control).Text & ":</b> " & e.Values(0), MessageBoxIcon.Information, alignment:=ContentAlignment.MiddleRight)
        End Sub
    End Class

