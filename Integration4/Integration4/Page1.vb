Imports System.Drawing
Imports Winforms = System.Windows.Forms
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub widgetInput_WebRequest(ByVal sender As Object, ByVal e As WebRequestEventArgs) Handles widgetInput.WebRequest
        e.Response.ContentType = "application/json"
        e.Response.Write(getData())
    End Sub

    Private Sub widgetColorPicker_WidgetEvent(ByVal sender As Object, ByVal e As WidgetEventArgs) Handles widgetColorPicker.WidgetEvent
        Dim color = ColorTranslator.FromHtml("#" & e.Data.color)
        label1.ForeColor = color
        widgetTreeMap.Call("setBaseColor", "#" & e.Data.color)
        Dim lightColor = Winforms.ControlPaint.Light(color)
        widgetTagCloud.Call("setColors", ColorTranslator.ToHtml(lightColor), ColorTranslator.ToHtml(color))
    End Sub

    Private Function getData() As String
        Dim json = "[
            {""Dish"":""Pizza Margherita"", ""Price"": ""4""},
            {""Dish"":""Pizza Funghi"", ""Price"": ""5""},
            {""Dish"":""Pizza Quattro Stagioni"", ""Price"": ""5.5""},
            {""Dish"":""Pizza Frutti di Mare"", ""Price"": ""7""},
            {""Dish"":""Spaghetti Bolognese"", ""Price"": ""4""},
            {""Dish"":""Spaghetti Carbonara"", ""Price"": ""5""},
            {""Dish"":""Rigatoni all'Arrabbiata"", ""Price"": ""5.5""},
            {""Dish"":""Rigatoni al Forno"", ""Price"": ""6""},
            {""Dish"":""Pappardelle con Porcini"", ""Price"": ""7""},
            {""Dish"":""Cesars Salad"", ""Price"": ""5.5""}            
            ]"
        Return json
    End Function

    Private Sub widgetTagCloud_WebRequest(ByVal sender As Object, ByVal e As WebRequestEventArgs) Handles widgetTagCloud.WebRequest
        e.Response.ContentType = "application/json"
        e.Response.Write(getData())
    End Sub
End Class

