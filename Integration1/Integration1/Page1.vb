Imports System
Imports System.Collections.Generic
Imports System.Web.Script.Serialization
Imports Wisej.Core
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' generate data for Pizza store
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function GenerateData() As String
        Dim Category = {"Salad", "Pasta", "Pizza", "Dessert"}
        Dim Dish = New String(12, 1) {
        {"Salad", "Cesars Salad"},
        {"Salad", "Green Salad"},
        {"Pasta", "Spaghetti Carbonara"},
        {"Pasta", "Spaghetti Bolognese"},
        {"Pasta", "Maccheroni all amatriciana"},
        {"Pasta", "Lasagne"},
        {"Pizza", "Margherita"},
        {"Pizza", "Four Cheese"},
        {"Pizza", "Four Seasons"},
        {"Pizza", "Mushroom"},
        {"Dessert", "Tiramisu"},
        {"Dessert", "Panna Cotta"},
        {"Dessert", "Ice Cream"}}
        Dim maxAmount = 200
        Dim startDate As Date = New DateTime(2014, 1, 1)
        Dim endDate As Date = New DateTime(2016, 12, 31)
        Dim id = 1
        Dim dt = startDate
        Dim random As Random = New Random()
        Dim AllData As List(Of SampleData) = New List(Of SampleData)()

        While dt < endDate

            For Each Cat In Category

                For x = 0 To Dish.GetLength(0) - 1

                    If Equals(Dish(x, 0), Cat) Then
                        Dim aSampleDate As SampleData = New SampleData()
                        Dim amount = random.Next(maxAmount + 1)
                        aSampleDate.id = id
                        aSampleDate.date = dt.Year.ToString() & "/" & dt.Month.ToString() & "/" & dt.Day.ToString()
                        aSampleDate.amount = amount
                        aSampleDate.category = Cat
                        aSampleDate.dish = Dish(x, 1)
                        AllData.Add(aSampleDate)
                        id += 1
                    End If
                Next
            Next

            dt = dt.AddDays(1)
        End While

        Dim jsonSerialiser = New JavaScriptSerializer()
        Dim json = jsonSerialiser.Serialize(AllData)
        Return json
    End Function

    ''' <summary>
    ''' sample data structure for Pizza store
    ''' </summary>
    Private Class SampleData
        Public id As Integer
        Public category As String
        Public dish As String
        Public amount As Integer
        Public [date] As String
    End Class

    ''' <summary>
    ''' provide data for PivotGrid
    ''' </summary>
    ''' <paramname="sender"></param>
    ''' <paramname="e"></param>
    Private Sub widgetPivotGrid_WebRequest_1(ByVal sender As Object, ByVal e As WebRequestEventArgs) Handles widgetPivotGrid.WebRequest
        e.Response.ContentType = "application /json"
        e.Response.Write(GenerateData())
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHeatUp.Click
        widgetCircularGage.Eval("this.gauge.value( this.gauge.value() + 10)")
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCoolDown.Click
        widgetCircularGage.Eval("this.gauge.value( this.gauge.value() - 10)")
    End Sub

    Public WidgetCircularGage_StartValue As Integer = 0
    Public WidgetCircularGage_EndValue As Integer = 0

    Private Sub widgetCircularGage_WidgetEvent(ByVal sender As Object, ByVal e As WidgetEventArgs)
        If Equals(e.Type, "Initialized") Then
            ' determine min / max values
            widgetCircularGage.Eval("App.MainPage.SetStartValue(this.gauge._options.scale.startValue)")
            widgetCircularGage.Eval("App.MainPage.SetEndValue(this.gauge._options.scale.endValue)")
        ElseIf Equals(e.Type, "OptionChanged") Then

            If e.Data.optionName Is "value" Then
                Dim value As Integer = e.Data.optionValue

                If value > WidgetCircularGage_EndValue Then
                    AlertBox.Show("That´s too hot !")
                    widgetCircularGage.Eval($"this.gauge.value({WidgetCircularGage_EndValue})")
                ElseIf value < WidgetCircularGage_StartValue Then
                    AlertBox.Show("Come on, guests are hungry, heat up !")
                    widgetCircularGage.Eval($"this.gauge.value({WidgetCircularGage_StartValue})")
                End If
            End If
        End If
    End Sub

    <WebMethod>
    Public Sub SetStartValue(ByVal startValue As Integer)
        WidgetCircularGage_StartValue = startValue
    End Sub

    <WebMethod>
    Public Sub SetEndValue(ByVal endValue As Integer)
        WidgetCircularGage_EndValue = endValue
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
        Dim cmb = TryCast(sender, ComboBox)
        widgetBarGauge.Eval($"this.gauge.option('palette', '{cmb.SelectedItem}')")
    End Sub
End Class
